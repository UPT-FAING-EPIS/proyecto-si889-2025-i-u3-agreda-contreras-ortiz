import numpy as np
from app.services.audio_processing import detectar_frecuencia_librosa
from app.services.note_detection import get_note_for_freq, check_progress
from app.config.settings import SONG

user_notes = []
song_completed = False


def register_socketio_events(socketio):
    @socketio.on("audio_stream")
    def handle_audio(audio_chunk):
        global song_completed
        audio_np = np.frombuffer(audio_chunk, dtype=np.float32)

        if np.all(audio_np == 0):
            return

        frecuencia = detectar_frecuencia_librosa(audio_np)
        print(f"🔍 Frecuencia detectada: {frecuencia}")

        if frecuencia:
            detected_note = get_note_for_freq(frecuencia)
        else:
            return

        if detected_note:
            user_notes.append(detected_note)
            feedback = check_progress(user_notes, SONG)

            print(f"📌 Notas detectadas hasta ahora: {user_notes}")

            if len(user_notes) == len(SONG):
                song_completed = True
                socketio.emit("nota_detectada", {
                    "nota": detected_note,
                    "feedback": "✅ ¡Canción completa!",
                    "nota_esperada": "✅ ¡Completado!"
                })
                user_notes.clear()
                return

            nota_esperada = SONG[len(user_notes)] if len(
                user_notes) < len(SONG) else "✅ ¡Completado!"

            if feedback:
                socketio.emit("nota_detectada", {
                    "nota": detected_note,
                    "feedback": feedback,
                    "nota_esperada": nota_esperada
                })
