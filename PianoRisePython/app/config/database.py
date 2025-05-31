import os
from dotenv import load_dotenv
from sqlalchemy import create_engine
from sqlalchemy.orm import sessionmaker, scoped_session

class Database:
    _instance = None

    def __new__(cls):
        if cls._instance is None:
            # Carga las variables de entorno desde .env
            load_dotenv()

            database_url = os.getenv("DATABASE_URL")
            if not database_url:
                raise RuntimeError("La variable DATABASE_URL no está definida en .env")

            # Crea el engine de SQLAlchemy
            engine = create_engine(
                database_url,
                echo=False,       # pon True para ver el SQL en consola
                future=True       # usar la API 2.0 de SQLAlchemy
            )
            # Crea el factory de sesiones
            session_factory = sessionmaker(
                bind=engine,
                autoflush=False,
                autocommit=False,
                expire_on_commit=False
            )
            # Scoped session para que sea thread-safe
            Session = scoped_session(session_factory)

            # Instancia única
            cls._instance = super(Database, cls).__new__(cls)
            cls._instance.engine = engine
            cls._instance.Session = Session

        return cls._instance

    def get_engine(self):
        return self.engine

    def get_session(self):
        return self.Session()

