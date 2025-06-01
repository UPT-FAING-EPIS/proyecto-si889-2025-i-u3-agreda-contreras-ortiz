from datetime import datetime
from sqlalchemy import Column, Integer, Numeric, DateTime, ForeignKey, Interval
from sqlalchemy.orm import relationship
from app import db

class Historial(db.Model):
    __tablename__ = "historial"

    id            = Column("id", Integer, primary_key=True)
    alumno_id     = Column("alumno_id", Integer, ForeignKey("usuario.id"),    nullable=False)
    aula_id       = Column("aula_id",   Integer, ForeignKey("aula.id"),       nullable=False)
    cancion_id    = Column("cancion_id",Integer, ForeignKey("cancion.id"),   nullable=False)
    precision     = Column("precision", Numeric, nullable=False)
    errores       = Column("errores",   Integer, nullable=False)
    duracion      = Column("duracion",  Interval, nullable=False)
    registrado_en = Column("registrado_en", DateTime, default=datetime.utcnow, nullable=False)

    usuario  = relationship("Usuario",   back_populates="historiales")
    aula     = relationship("Aula",      back_populates="historiales")
    cancion  = relationship("Cancion",   back_populates="historiales")
