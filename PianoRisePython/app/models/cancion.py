# app/models/cancion.py
from datetime import datetime
from sqlalchemy import Column, Integer, String, Boolean, DateTime
from sqlalchemy.dialects.postgresql import JSONB
from sqlalchemy.orm import relationship
from app import db

class Cancion(db.Model):
    __tablename__ = "cancion"

    id             = Column("id", Integer, primary_key=True)
    titulo         = Column("titulo", String,  nullable=False)
    nivel          = Column("nivel", Integer, nullable=False)
    compositor     = Column("compositor", String, nullable=False)
    creado_en      = Column("creado_en", DateTime, default=datetime.utcnow, nullable=False)
    estado         = Column("estado", Boolean, nullable=False)
    notas          = Column("notas", JSONB, nullable=False, default=list)

    aula_canciones = relationship("AulaCancion", back_populates="cancion", lazy="dynamic")
    historiales    = relationship("Historial",    back_populates="cancion", lazy="dynamic")
