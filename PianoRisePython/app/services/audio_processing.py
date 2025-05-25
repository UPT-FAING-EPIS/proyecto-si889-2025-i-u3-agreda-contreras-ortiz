import numpy as np
import librosa
from app.config.settings import ENERGY_THRESHOLD


def detectar_frecuencia_librosa(audio_data):
    """Detecta la frecuencia usando librosa."""
    energy = np.mean(audio_data ** 2)
    if energy < ENERGY_THRESHOLD:
        print(f"⚠ Energía demasiado baja: {energy:.8f} (Ignorando)")
        return None
    f0, _, _ = librosa.pyin(audio_data, fmin=82, fmax=1000)
    if f0 is None or np.isnan(np.nanmean(f0)):
        return None
    return np.nanmean(f0)

