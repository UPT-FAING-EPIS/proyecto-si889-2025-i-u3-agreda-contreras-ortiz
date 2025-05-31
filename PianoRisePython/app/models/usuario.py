from datetime import datetime
from sqlalchemy import Column, Integer, String, Date, DateTime, Boolean, ForeignKey, Text
from sqlalchemy.orm import relationship
from app import db


class Usuario(db.Model):
    __tablename__ = "usuario"

    id                 = Column("id", Integer, primary_key=True)
    nombre_completo    = Column("nombre_completo", String(100), nullable=False)
    correo_electronico = Column("correo_electronico", String(100), unique=True, nullable=False)
    contrasena_hash    = Column("contrasena_hash", Text, nullable=False)

    rol_id             = Column("rol_id", Integer, ForeignKey("rol.id"), nullable=False)
    rol                = relationship("Rol", back_populates="usuarios")

    telefono           = Column("telefono", String(15), nullable=True)
    fecha_registro     = Column("fecha_registro", DateTime, default=datetime.utcnow, nullable=False)
    fecha_nacimiento   = Column("fecha_nacimiento", Date, nullable=True)
    esta_activo        = Column("esta_activo", Boolean, default=True, nullable=False)

    alumno_aulas       = relationship("AlumnoAula", back_populates="alumno", lazy="dynamic")
    historiales        = relationship("Historial",   back_populates="usuario", lazy="dynamic")
    
    @property
    def is_active(self):
        return self.esta_activo
    
    def get_id(self):
        return str(self.id)
    
    @property
    def is_authenticated(self) -> bool:
        return True

    @property
    def is_anonymous(self) -> bool:
        return False