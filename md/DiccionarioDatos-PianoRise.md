# Plataforma Web Interactiva para el Aprendizaje Autónomo del Piano con Reconocimiento de Notas Musicales - PianoRise

## Documento de Diccionario de Datos
**Versión 1.0**

---

## Historia de Revisión

| Ítem | Fecha       | Versión | Descripción       | Equipo  |
|------|-------------|---------|-------------------|---------|
| 1    | 02/06/2025  | 1.0     | Versión completa. | Grupo 6 |

---

# 📑 Tabla de Contenidos

1. [🎯 OBJETIVO](#-objetivo)  
2. [📂 DECLARACIÓN DE TABLAS](#-tablas)  
   - [Tabla: `usuario`](#tabla-usuario)  
   - [Tabla: `rol`](#tabla-rol)  
   - [Tabla: `aula`](#tabla-aula)  
   - [Tabla: `alumno_aula`](#tabla-alumno_aula)  
   - [Tabla: `cancion`](#tabla-cancion)  
   - [Tabla: `aula_cancion`](#tabla-aula_cancion)  
   - [Tabla: `historial`](#tabla-historial)  

---

# 📘 Diccionario de Datos – PianoRise

## 🎯 Objetivo

Establecer las reglas y convenciones para la definición, estructuración y documentación de las tablas y campos de la base de datos PostgreSQL de la plataforma **PianoRise**.

Este diccionario garantiza un modelo de datos claro, coherente y normalizado, que facilite su implementación, mantenimiento y comprensión por parte del equipo de desarrollo.

### Lineamientos:

- Los nombres de las tablas están en singular, en idioma español, utilizando `snake_case` en minúsculas.
- Los campos de las tablas también están en `snake_case` en minúsculas y son descriptivos.
- Claves primarias se llaman `id`; claves foráneas terminan en `_id`.
- Campos booleanos con prefijos `es_`, `esta_` o directamente como `activo` / `activa`.
- Tipos de datos estándar de PostgreSQL (`varchar(n)`, `integer`, `boolean`, `timestamp`, `jsonb`, `interval`, etc.).
- Cada campo incluye una descripción breve de su propósito.

---

## 📂 Tablas

### Tabla: `usuario`

| Campo              | Tipo de Dato  | Null | PK  | FK         | Descripción                         |
|-------------------|---------------|------|-----|------------|-------------------------------------|
| id                | integer       | NO   | Sí  |            | Identificador del usuario           |
| nombre_completo   | varchar(100)  | NO   |     |            | Nombre completo                     |
| correo_electronico| varchar(100)  | NO   |     |            | Correo único                        |
| contrasena_hash   | text          | NO   |     |            | Contraseña en hash                  |
| rol_id            | integer       | NO   |     | rol.id     | Clave foránea al rol                |
| telefono          | varchar(15)   | SÍ   |     |            | Número telefónico                   |
| fecha_registro    | timestamp     | NO   |     |            | Fecha y hora de registro            |
| fecha_nacimiento  | date          | SÍ   |     |            | Fecha de nacimiento                 |
| esta_activo       | boolean       | NO   |     |            | Estado activo/inactivo              |

---

### Tabla: `rol`

| Campo  | Tipo de Dato  | Null | PK  | FK | Descripción                  |
|--------|---------------|------|-----|----|------------------------------|
| id     | integer       | NO   | Sí  |    | Identificador del rol        |
| nombre | varchar(100)  | NO   |     |    | Nombre del rol (docente, etc.) |

---

### Tabla: `aula`

| Campo      | Tipo de Dato | Null | PK  | FK         | Descripción                  |
|------------|--------------|------|-----|------------|------------------------------|
| id         | integer      | NO   | Sí  |            | ID del aula                  |
| descripcion| varchar      | NO   |     |            | Descripción del aula         |
| docente_id | integer      | NO   |     | usuario.id | Docente responsable          |
| creado_en  | timestamp    | NO   |     |            | Fecha de creación            |
| grado      | smallint     | SÍ   |     |            | Grado                        |
| seccion    | varchar(1)   | SÍ   |     |            | Sección (letra)              |
| anio       | smallint     | SÍ   |     |            | Año escolar                  |
| codigo     | varchar(4)   | SÍ   |     |            | Código del aula              |
| estado     | boolean      | NO   |     |            | Estado (activo/inactivo)     |

---

### Tabla: `alumno_aula`

| Campo      | Tipo de Dato | Null | PK  | FK         | Descripción                  |
|------------|--------------|------|-----|------------|------------------------------|
| id         | integer      | NO   | Sí  |            | ID del registro              |
| alumno_id  | integer      | NO   |     | usuario.id | Usuario alumno               |
| aula_id    | integer      | NO   |     | aula.id    | Aula asignada                |
| inscrito_en| timestamp    | NO   |     |            | Fecha de inscripción         |

---

### Tabla: `cancion`

| Campo     | Tipo de Dato | Null | PK  | FK | Descripción                        |
|-----------|--------------|------|-----|----|------------------------------------|
| id        | integer      | NO   | Sí  |    | ID de la canción                   |
| titulo    | varchar      | NO   |     |    | Título de la canción               |
| nivel     | integer      | NO   |     |    | Nivel de dificultad                |
| compositor| varchar      | NO   |     |    | Nombre del compositor              |
| creado_en | timestamp    | NO   |     |    | Fecha de creación                  |
| estado    | boolean      | NO   |     |    | Estado (activa/inactiva)          |
| notas     | jsonb        | NO   |     |    | Notas musicales (en JSONB)         |

---

### Tabla: `aula_cancion`

| Campo      | Tipo de Dato | Null | PK  | FK         | Descripción           |
|------------|--------------|------|-----|------------|-----------------------|
| id         | integer      | NO   | Sí  |            | ID                    |
| aula_id    | integer      | NO   |     | aula.id    | Aula asignada         |
| cancion_id | integer      | NO   |     | cancion.id | Canción asignada      |
| asignado_en| timestamp    | NO   |     |            | Fecha de asignación   |

---

### Tabla: `historial`

| Campo       | Tipo de Dato | Null | PK  | FK           | Descripción                      |
|-------------|--------------|------|-----|--------------|----------------------------------|
| id          | integer      | NO   | Sí  |              | ID                               |
| alumno_id   | integer      | NO   |     | usuario.id   | Alumno que ejecutó               |
| aula_id     | integer      | NO   |     | aula.id      | Aula de la ejecución             |
| cancion_id  | integer      | NO   |     | cancion.id   | Canción tocada                   |
| precision   | numeric      | NO   |     |              | Precisión de ejecución           |
| errores     | integer      | NO   |     |              | Número de errores                |
| duracion    | interval     | NO   |     |              | Duración total                   |
| registrado_en| timestamp   | NO   |     |              | Fecha y hora de ejecución        |
