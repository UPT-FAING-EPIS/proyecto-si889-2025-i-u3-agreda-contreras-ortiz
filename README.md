# 🎹 PianoRise - Plataforma Web para el Aprendizaje del Piano

**PianoRise** es una aplicación web educativa que busca facilitar el aprendizaje del piano para estudiantes de nivel escolar. El sistema permite a los alumnos practicar canciones y ejercicios musicales con retroalimentación en tiempo real, y a los docentes monitorear su avance. El proyecto está dividido en dos módulos: uno desarrollado en **.NET (ASP.NET Core)** y otro en **Python (Flask + Uvicorn)** para el procesamiento de audio.

---

## 🌐 Links de Despliegue

- [Alumno (Frontend)](https://pianorise-alumno.azurewebsites.net/)
- [Admin (Frontend)](https://pianorise.azurewebsites.net/)

---
## ⚙️ Requisitos Previos

- [.NET SDK 8.0.409]([https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/en-us/download/dotnet/8.0))
- [Python 3.10+](https://www.python.org/)
- [pip](https://pip.pypa.io/)

---

## 🚀 Instrucciones de Ejecución

### 🧩 Backend .NET (ASP.NET Core)

1. Navegar al directorio:  
   `cd PianoRiseDotnet`

2. Restaurar dependencias:  
   `dotnet restore`

3. Construir el proyecto:  
   `dotnet build`

4. Ejecutar el servidor:  
   `dotnet run`

---

### 🎧 Servicio de Audio (Python + Flask + Uvicorn)

1. Navegar al directorio:  
   `cd PianoRisePython`

2. Crear entorno virtual:  
   `python -m venv venv`

3. Activar entorno virtual:  
   - Linux/macOS: `source venv/bin/activate`  
   - Windows: `venv\Scripts\activate`

4. Instalar dependencias:  
   `pip install -r requirements.txt`

5. Ejecutar el servidor:  
   `uvicorn main:app --reload --port 8000`

> 🔗 El servicio estará disponible en `http://127.0.0.1:8000`.

---

## 🛠 Tecnologías Usadas

- **.NET Core (C#)** – Backend principal y lógica del sistema
- **Python + Flask + Uvicorn** – Servicio auxiliar para captura/procesamiento de audio
- **MongoDB / SQL Server** – Base de datos (según configuración)
- **Web Audio API** – Captura de notas musicales desde el navegador

---

