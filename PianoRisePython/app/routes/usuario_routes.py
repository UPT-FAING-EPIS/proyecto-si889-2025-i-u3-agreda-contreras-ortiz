from flask import Blueprint, render_template, request, redirect, url_for, flash, session
from app.services.usuario_services import UsuarioService
from app.config.database import Database
from flask_login import login_user, logout_user, login_required, current_user

usuario_bp = Blueprint("usuario", __name__, url_prefix="/usuario")
svc        = UsuarioService()
db         = Database()

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
        # loguear
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
    # Solo alumnos (rol_id = 3)
    if current_user.rol_id != 3:
        flash("Acceso denegado.", "warning")
        return redirect(url_for("main.index"))
    return render_template("dashboard.html", usuario=current_user)