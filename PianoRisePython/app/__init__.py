import os
from dotenv import load_dotenv
from flask import Flask
from flask_socketio import SocketIO
from flask_sqlalchemy import SQLAlchemy
from flask_migrate import Migrate
from flask_login import LoginManager

# Carga variables de entorno de la raíz del proyecto
load_dotenv()

# Inicialización de extensiones
socketio = SocketIO(cors_allowed_origins="*")
db       = SQLAlchemy()
migrate  = Migrate()
login_manager = LoginManager()

login_manager.login_view = "usuario.login"

def create_app():
    base = os.path.dirname(__file__)
    app = Flask(
        __name__,
        template_folder=os.path.join(base, '..', 'templates'),
        static_folder=os.path.join(base, '..', 'static')
    )

    # 1) Clave secreta para sesiones y flash
    secret = os.getenv("SECRET_KEY")
    if not secret:
        raise RuntimeError("La variable SECRET_KEY no está definida en .env")
    app.config['SECRET_KEY'] = secret

    # 2) Configuración de detección (solo constantes)
    from app.config.settings import NOTES, ENERGY_THRESHOLD
    app.config['NOTES']            = NOTES
    app.config['ENERGY_THRESHOLD'] = ENERGY_THRESHOLD

    # 3) Configuración de la base de datos
    database_url = os.getenv("DATABASE_URL")
    if not database_url:
        raise RuntimeError("La variable DATABASE_URL no está definida en .env")
    app.config['SQLALCHEMY_DATABASE_URI']        = database_url
    app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = False

    # 4) Inicializa extensiones con la app
    db.init_app(app)
    migrate.init_app(app, db)
    socketio.init_app(app)
    login_manager.init_app(app)
    
    from app.models.usuario import Usuario
    @login_manager.user_loader
    def load_user(user_id):
        return Usuario.query.get(int(user_id))
    
    # 5) Blueprints y sockets
    from app.routes.main import main as main_bp
    app.register_blueprint(main_bp)

    from app.routes.usuario_routes import usuario_bp
    app.register_blueprint(usuario_bp)

    from app.sockets.handlers import register_socketio_events
    register_socketio_events(socketio)

    return app
