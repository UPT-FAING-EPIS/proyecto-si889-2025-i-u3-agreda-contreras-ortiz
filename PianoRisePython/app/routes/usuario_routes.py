from flask import Blueprint, render_template, request, redirect, url_for, flash
from app.models.aula import Aula
from app.models.alumno_aula import AlumnoAula
from app.models.cancion import Cancion
from app.services.usuario_services import UsuarioService
from app import db  # ✅ Este es el db correcto
from flask_login import login_user, logout_user, login_required, current_user

usuario_bp = Blueprint("usuario", __name__, url_prefix="/usuario")
svc = UsuarioService()


@usuario_bp.route("/registro", methods=["GET", "POST"])
def register():
    if request.method == "POST":
        success, result = svc.register_user(request.form.to_dict())
        if not success:
            flash(result, "warning")
            return render_template("registro.html", **request.form)
        flash("¡Registro exitoso! Ya puedes iniciar sesión.", "success")
        return redirect(url_for("usuario.login"))
    return render_template("registro.html")


@usuario_bp.route("/login", methods=["GET", "POST"])
def login():
    if request.method == "POST":
        success, result = svc.authenticate_user(
            request.form.get("correo"),
            request.form.get("contrasena")
        )
        if not success:
            flash(result, "warning")
            return render_template("login.html", correo=request.form.get("correo"))
        login_user(result)
        return redirect(url_for("usuario.dashboard"))
    return render_template("login.html")


@usuario_bp.route("/logout")
@login_required
def logout():
    logout_user()
    flash("Has cerrado sesión.", "success")
    return redirect(url_for("main.index"))


@usuario_bp.route("/dashboard")
@login_required
def dashboard():
    if current_user.rol_id != 3:
        flash("Acceso denegado.", "warning")
        return redirect(url_for("main.index"))

    aula_asignada = current_user.alumno_aulas.first()
    if aula_asignada:
        return redirect(url_for("usuario.aula", aula_id=aula_asignada.aula_id))

    return render_template("vincular_aula.html", usuario=current_user)


@usuario_bp.route("/aula/<int:aula_id>")
@login_required
def aula(aula_id):
    if current_user.rol_id != 3:
        flash("Acceso denegado.", "warning")
        return redirect(url_for("main.index"))

    vinculo = current_user.alumno_aulas.filter_by(aula_id=aula_id).first()
    if not vinculo:
        flash("No estás inscrito en esta aula.", "warning")
        return redirect(url_for("usuario.dashboard"))

    aula = vinculo.aula
    canciones = aula.aula_canciones.all()
    return render_template("aula.html", usuario=current_user, aula=aula, canciones=canciones)


@usuario_bp.route("/vincular-aula", methods=["POST"])
@login_required
def vincular_aula():
    codigo = request.form.get("codigo_aula", "").strip()

    aula = Aula.query.filter_by(codigo=codigo, estado=True).first()
    if not aula:
        flash("Código de aula inválido o inactivo.", "danger")
        return redirect(url_for("usuario.dashboard"))

    ya_vinculado = current_user.alumno_aulas.filter_by(aula_id=aula.id).first()
    if ya_vinculado:
        flash("Ya estás inscrito en esta aula.", "info")
        return redirect(url_for("usuario.aula", aula_id=aula.id))

    try:
        nueva_vinculacion = AlumnoAula(
            alumno_id=current_user.id, aula_id=aula.id)
        db.session.add(nueva_vinculacion)
        db.session.commit()
        flash("¡Te has unido al aula correctamente!", "success")
    except Exception as e:
        db.session.rollback()
        flash("Error al unirse al aula. Intenta nuevamente.", "danger")
        print("Error al vincular aula:", e)
        return redirect(url_for("usuario.dashboard"))

    return redirect(url_for("usuario.aula", aula_id=aula.id))


@usuario_bp.route("/reconocimiento/<int:cancion_id>")
@login_required
def reconocimiento_cancion(cancion_id):
    if current_user.rol_id != 3:
        flash("Acceso denegado.", "warning")
        return redirect(url_for("main.index"))

    cancion = Cancion.query.get_or_404(cancion_id)

    return render_template(
        "reconocimiento.html",
        usuario=current_user,
        cancion=cancion,
        notas=cancion.notas
    )
