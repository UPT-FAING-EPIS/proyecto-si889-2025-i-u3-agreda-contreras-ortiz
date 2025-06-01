import numpy as np
from app.services.audio_processing import detectar_frecuencia_librosa
from app.services.note_detection import get_note_for_freq, check_progress

user_notes = []
song_actual = []
song_completed = False


def register_socketio_events(socketio):
    @socketio.on("iniciar_cancion")
    def iniciar_cancion(cancion):
        global user_notes, song_actual, song_completed
        user_notes = []
        song_actual = cancion
        song_completed = False
        print(f"🎼 Canción recibida: {song_actual}")

    @socketio.on("audio_stream")
    def handle_audio(audio_chunk):
        global user_notes, song_actual, song_completed

        audio_np = np.frombuffer(audio_chunk, dtype=np.float32)

        if np.all(audio_np == 0) or not song_actual:
            return

        frecuencia = detectar_frecuencia_librosa(audio_np)
        print(f"🔍 Frecuencia detectada: {frecuencia}")

        if not frecuencia:
            return

        detected_note = get_note_for_freq(frecuencia)
        if not detected_note:
            return

        if len(user_notes) < len(song_actual):
            nota_esperada = song_actual[len(user_notes)]
        else:
            nota_esperada = "✅ ¡Completado!"
        user_notes.append(detected_note)
        feedback = check_progress(user_notes, song_actual)
        print(f"📌 Notas detectadas hasta ahora: {user_notes}")

        if len(user_notes) == len(song_actual):
            song_completed = True
            socketio.emit("nota_detectada", {
                "nota": detected_note,
                "feedback": "✅ ¡Canción completa!",
                "nota_esperada": "✅ ¡Completado!"
            })
            user_notes.clear()
            return

        if feedback:
            socketio.emit("nota_detectada", {
                "nota": detected_note,
                "feedback": feedback,
                "nota_esperada": nota_esperada
            })
