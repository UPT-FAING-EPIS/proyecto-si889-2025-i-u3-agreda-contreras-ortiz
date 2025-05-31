from datetime import date
from werkzeug.security import generate_password_hash, check_password_hash
from sqlalchemy.exc import IntegrityError
from app.config.database import Database
from app.models.usuario import Usuario

class UsuarioService:
    def __init__(self):
        db = Database()
        self.session = db.get_session()

    def register_user(self, data: dict):
        """
        data debe contener:
          - nombre, correo, contrasena, contrasena2
          - telefono (opcional), fecha_nacimiento (date, string 'YYYY-MM-DD' o None)
        Retorna (True, usuario) o (False, mensaje_error).
        """
        # Validación de campos obligatorios
        required = ["nombre", "correo", "contrasena", "contrasena2"]
        if any(not data.get(field) for field in required):
            return False, "Por favor completa todos los campos requeridos."
        if data["contrasena"] != data["contrasena2"]:
            return False, "Las contraseñas no coinciden."

        # Parseo de fecha de nacimiento
        fn = data.get("fecha_nacimiento")
        fecha_nac = None
        if fn:
            if isinstance(fn, date):
                fecha_nac = fn
            else:
                try:
                    fecha_nac = date.fromisoformat(fn)
                except ValueError:
                    return False, "Formato de fecha inválido. Usa YYYY-MM-DD."

        # Creación del usuario en la base de datos
        nuevo = Usuario(
            nombre_completo    = data["nombre"],
            correo_electronico = data["correo"],
            contrasena_hash    = generate_password_hash(data["contrasena"]),
            rol_id             = 3,
            telefono           = data.get("telefono"),
            fecha_nacimiento   = fecha_nac
        )
        self.session.add(nuevo)
        try:
            self.session.commit()
            return True, nuevo
        except IntegrityError:
            self.session.rollback()
            return False, "El correo ya está registrado."
        except Exception as e:
            self.session.rollback()
            return False, f"Error inesperado: {str(e)}"

    def authenticate_user(self, correo: str, contrasena: str):
        """
        Retorna (True, usuario) o (False, mensaje_error).
        """
        if not correo or not contrasena:
            return False, "Completa ambos campos."
        usuario = (
            self.session
            .query(Usuario)
            .filter_by(correo_electronico=correo)
            .first()
        )
        if not usuario or not check_password_hash(usuario.contrasena_hash, contrasena):
            return False, "Credenciales inválidas."
        return True, usuario
