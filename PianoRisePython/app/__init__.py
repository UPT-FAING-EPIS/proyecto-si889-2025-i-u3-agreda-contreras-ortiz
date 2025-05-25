from flask import Flask
from flask_socketio import SocketIO
import os

socketio = SocketIO(cors_allowed_origins="*")


def create_app():
    app = Flask(
        __name__,
        template_folder=os.path.join(os.path.dirname(
            os.path.dirname(__file__)), 'templates'),
        static_folder=os.path.join(os.path.dirname(
            os.path.dirname(__file__)), 'static')
    )

    from app.routes.main import main as main_blueprint
    app.register_blueprint(main_blueprint)

    from app.sockets.handlers import register_socketio_events
    register_socketio_events(socketio)

    socketio.init_app(app)

    return app
