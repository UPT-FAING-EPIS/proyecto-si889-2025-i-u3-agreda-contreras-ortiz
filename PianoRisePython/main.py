from gevent import monkey
monkey.patch_all()

import os
from app import create_app, socketio

from flask import request

import sentry_sdk
sentry_url = os.getenv("SENTRY_URL", "")
sentry_sdk.init(
    dsn=sentry_url,
    # Add data like request headers and IP for users,
    # see https://docs.sentry.io/platforms/python/data-management/data-collected/ for more info
    send_default_pii=True,
    traces_sample_rate=1.0,
)


app = create_app()
port = int(os.environ.get("PORT", 5000))

@app.before_request
def log_request_to_sentry():
    sentry_sdk.capture_message(
        f"{request.method} {request.path}",
        level="info"
    )

@app.route("/error")
def hello_world():
    1/0  # raises an error
    return "<p>Hello, World!</p>"

environment = os.getenv("ENVIRONMENT", "development")

if __name__ == "__main__":
    if environment == "production":
        app.config["DEBUG"] = True
        socketio.run(app, host="0.0.0.0", port=port)
    else:
        print(f"Servidor corriendo en http://127.0.0.1:{port}")
        socketio.run(app, host="127.0.0.1", port=port, debug=True)