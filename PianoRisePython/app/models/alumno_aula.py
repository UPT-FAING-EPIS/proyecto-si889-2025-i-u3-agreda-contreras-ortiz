from datetime import datetime
from sqlalchemy import Column, Integer, DateTime, ForeignKey
from sqlalchemy.orm import relationship
from app import db

class AlumnoAula(db.Model):
    __tablename__ = "alumno_aula"

    id           = Column("id", Integer, primary_key=True)
    alumno_id    = Column("alumno_id", Integer, ForeignKey("usuario.id"), nullable=False)
    aula_id      = Column("aula_id",   Integer, ForeignKey("aula.id"),    nullable=False)
    inscrito_en  = Column("inscrito_en", DateTime, default=datetime.utcnow, nullable=False)

    alumno = relationship("Usuario",    back_populates="alumno_aulas")
    aula   = relationship("Aula",       back_populates="alumno_aulas")
