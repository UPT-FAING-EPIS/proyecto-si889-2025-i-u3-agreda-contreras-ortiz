from datetime import timedelta
from sqlalchemy.exc import SQLAlchemyError
from app.config.database import Database
from app.models.historial import Historial


class HistorialService:
    def __init__(self):
        db = Database()
        self.session = db.get_session()

    def registrar_historial(
        self,
        alumno_id: int,
        aula_id: int,
        cancion_id: int,
        precision: float,
        errores: int,
        duracion_segundos: float
    ):
        """
        Registra o actualiza el historial de un alumno en una canción concreta.
        - Si no existe un registro previo para (alumno_id, aula_id, cancion_id), crea uno nuevo.
        - Si existe, se actualiza únicamente si:
             * precision_nueva > precision_anterior
             * errores_nuevos < errores_anteriores

        `duracion_segundos` es un float con los segundos que tardó en completar la canción.
        """
        try:
            # Buscamos un historial existente para este alumno/aula/canción
            existente = (
                self.session
                .query(Historial)
                .filter_by(alumno_id=alumno_id,
                           aula_id=aula_id,
                           cancion_id=cancion_id)
                .first()
            )

            # Convertimos segundos a timedelta
            duracion_td = timedelta(seconds=duracion_segundos)

            if existente is None:
                # No había historial previo: creamos uno nuevo
                nuevo = Historial(
                    alumno_id=alumno_id,
                    aula_id=aula_id,
                    cancion_id=cancion_id,
                    precision=precision,
                    errores=errores,
                    duracion=duracion_td
                )
                self.session.add(nuevo)
                self.session.commit()
                return True, "Historial creado."
            else:
                # Existe un registro: solo actualizamos si mejora ambas métricas
                if precision > float(existente.precision) and errores < existente.errores:
                    existente.precision = precision
                    existente.errores = errores
                    existente.duracion = duracion_td
                    existente.registrado_en = None  # se actualizará al salvar si tiene default
                    self.session.commit()
                    return True, "Historial actualizado."
                else:
                    return False, "No hay mejora en precisión y/o errores."

        except SQLAlchemyError as e:
            self.session.rollback()
            return False, f"Error de base de datos: {str(e)}"
        except Exception as e:
            self.session.rollback()
            return False, f"Error inesperado: {str(e)}"
