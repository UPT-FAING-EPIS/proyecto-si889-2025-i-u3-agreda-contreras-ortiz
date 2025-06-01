from sqlalchemy import Column, Integer, String
from sqlalchemy.orm import relationship
from app import db

class Rol(db.Model):
    __tablename__ = "rol"

    id       = Column("id", Integer, primary_key=True)
    nombre   = Column("nombre", String(100), nullable=False)

    usuarios = relationship("Usuario", back_populates="rol", lazy="dynamic")
