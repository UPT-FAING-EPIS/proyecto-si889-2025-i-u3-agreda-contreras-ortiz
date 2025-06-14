from gevent import monkey
monkey.patch_all()

import os
from app import create_app, socketio

app = create_app()
port = int(os.environ.get("PORT", 5000))

environment = os.getenv("ENVIRONMENT", "development")

if __name__ == "__main__":
    if environment == "production":
        app.config["DEBUG"] = True
        socketio.run(app, host="0.0.0.0", port=port)
    else:
        print(f"Servidor corriendo en http://127.0.0.1:{port}")
        socketio.run(app, host="127.0.0.1", port=port, debug=True)


