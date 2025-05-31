# app/models/aula_cancion.py
from datetime import datetime
from sqlalchemy import Column, Integer, DateTime, ForeignKey
from sqlalchemy.orm import relationship
from app import db

class AulaCancion(db.Model):
    __tablename__ = "aula_cancion"

    id          = Column("id", Integer, primary_key=True)
    aula_id     = Column("aula_id", Integer, ForeignKey("aula.id"),     nullable=False)
    cancion_id  = Column("cancion_id", Integer, ForeignKey("cancion.id"), nullable=False)
    asignado_en = Column("asignado_en", DateTime, default=datetime.utcnow, nullable=False)

    aula    = relationship("Aula",    back_populates="aula_canciones")
    cancion = relationship("Cancion", back_populates="aula_canciones")
