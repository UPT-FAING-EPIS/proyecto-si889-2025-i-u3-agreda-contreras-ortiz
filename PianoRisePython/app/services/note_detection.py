import numpy as np
from app.config.settings import NOTES


def get_note_for_freq(frequency):
    """Asigna una frecuencia detectada a la nota más cercana."""
    if frequency is None or np.isnan(frequency):
        return None

    while frequency < 440:
        frequency *= 2
    while frequency > 830.61:
        frequency /= 2

    best_match = None
    min_diff = float("inf")

    for note, freq in NOTES.items():
        diff = abs(frequency - freq)
        if diff < min_diff:
            min_diff = diff
            best_match = note

    return best_match


def check_progress(user_notes, song):
    """Compara la última nota tocada con la canción y devuelve solo progreso correcto."""
    if not user_notes:
        return "🎹 Esperando nota..."

    index = len(user_notes) - 1

    if index >= len(song):
        user_notes.clear()
        return "❌ Demasiadas notas. Intenta de nuevo."

    if user_notes[index] != song[index]:
        print(f"❌ Nota incorrecta '{user_notes[index]}'. Eliminando...")
        user_notes.pop()
        return None

    if len(user_notes) == len(song):
        user_notes.clear()
        return "✅ ¡Canción completa!"

    return f"🎵 Correcto ({len(user_notes)}/{len(song)})"
