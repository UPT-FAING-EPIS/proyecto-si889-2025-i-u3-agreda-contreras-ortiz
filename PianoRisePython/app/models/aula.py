# app/models/aula.py
from datetime import datetime
from sqlalchemy import Column, Integer, String, SmallInteger, Boolean, DateTime, ForeignKey
from sqlalchemy.orm import relationship
from app import db

class Aula(db.Model):
    __tablename__ = "aula"

    id              = Column("id", Integer, primary_key=True)
    descripcion     = Column("descripcion", String, nullable=False)
    docente_id      = Column("docente_id", Integer, ForeignKey("usuario.id"), nullable=False)
    creado_en       = Column("creado_en", DateTime, default=datetime.utcnow, nullable=False)
    grado           = Column("grado", SmallInteger, nullable=True)
    seccion         = Column("seccion", String(1), nullable=True)
    anio            = Column("anio", SmallInteger, nullable=True)
    codigo          = Column("codigo", String(4), nullable=True)
    estado          = Column("estado", Boolean, default=True, nullable=False)

    docente         = relationship("Usuario", lazy="joined")
    alumno_aulas    = relationship("AlumnoAula",    back_populates="aula", lazy="dynamic")
    aula_canciones  = relationship("AulaCancion",   back_populates="aula", lazy="dynamic")
    historiales     = relationship("Historial",     back_populates="aula", lazy="dynamic")
