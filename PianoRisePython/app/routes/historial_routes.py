from flask import Blueprint, request, jsonify, flash, redirect, url_for
from flask_login import login_required, current_user
from app.services.historial_service import HistorialService

historial_bp = Blueprint("historial", __name__, url_prefix="/historial")
svc = HistorialService()


@historial_bp.route("/registrar", methods=["POST"])
@login_required
def registrar():
    """
    Espera un JSON en el body con:
      - "cancion_id": int
      - "aula_id": int
      - "precision": float
      - "errores": int
      - "duracion": float (segundos)
    Retorna JSON: { "success": bool, "message": str }
    """
    data = request.get_json() or {}
    cancion_id = data.get("cancion_id")
    aula_id    = data.get("aula_id")
    precision  = data.get("precision")
    errores    = data.get("errores")
    duracion   = data.get("duracion")

    # Validaciones básicas
    if not all(isinstance(x, (int, float)) for x in [cancion_id, aula_id, precision, errores, duracion]):
        return jsonify(success=False, message="Datos incompletos o con formato incorrecto."), 400

    alumno_id = current_user.id

    ok, msg = svc.registrar_historial(
        alumno_id=alumno_id,
        aula_id=aula_id,
        cancion_id=cancion_id,
        precision=precision,
        errores=errores,
        duracion_segundos=duracion
    )

    status_code = 200 if ok else 200  # podemos devolver 200 aun si no se actualiza, solo false en success
    return jsonify(success=ok, message=msg), status_code
