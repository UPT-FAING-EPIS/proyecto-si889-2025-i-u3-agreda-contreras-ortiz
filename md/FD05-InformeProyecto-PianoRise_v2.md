<center>

[comment]: <img src="./media/media/image1.png" style="width:1.088in;height:1.46256in" alt="escudo.png" />

![./media/media/image1.png](../media/logo-upt.png)

**UNIVERSIDAD PRIVADA DE TACNA**

**FACULTAD DE INGENIERÍA**

**Escuela Profesional de Ingeniería de Sistemas**

**Plataforma Web Interactiva para el Aprendizaje Autónomo del Piano con Reconocimiento de Notas Musicales \- PianoRise**

Curso: Patrones de Software

Docente: *Mag. Patrick Cuadros Quiroga*

Integrantes:

***Agreda Ramirez, Jesús Eduardo 	  (2021069823)***  
***Contreras Lipa, Alvaro Javier    (2021070020)***  
***Ortiz Fernandez, Ximena Andrea 	(2021071080)***

**Tacna – Perú**  
**2025**
</center>

---

**Plataforma Web Interactiva para el Aprendizaje Autónomo del Piano con Reconocimiento de Notas Musicales \- PianoRise**

**Informe Final de Proyecto**

**Versión *1.0***

| CONTROL DE VERSIONES |  |  |  |  |  |
| :---: | :---: | :---: | :---: | :---: | ----- |
| Versión | Hecha por | Revisada por | Aprobada por | Fecha | Motivo |
| 1.0 |  |  |  | 02/06/2025 | Versión Original |
| 2.0 |  |  |  | 13/06/2025 | Version 2.0      |

---
<br>

## Índice

1. [Antecedentes](#1-antecedentes)  
2. [Planteamiento del Problema](#2-planteamiento-del-problema)  
   a. [Problema](#21-problema)  
   b. [Justificación](#22-justificación)  
   c. [Alcance](#23-alcance)  
3. [Objetivos](#3-objetivos)  
4. [Marco Teórico](#4-marco-teórico)  
5. [Desarrollo de la Solución](#5-desarrollo-de-la-solución)  
   a. [Análisis de Factibilidad](#51-análisis-de-factibilidad)  
   b. [Tecnología de Desarrollo](#52-tecnología-de-desarrollo)  
   c. [Metodología de implementación](#53-metodología-de-implementación)  
6. [Cronograma](#6-cronograma)  
7. [Presupuesto](#7-presupuesto)  
8. [Conclusiones](#8-conclusiones)

## 1. Antecedentes

La enseñanza del piano en entornos escolares ha enfrentado desafíos relacionados con la falta de recursos tecnológicos adecuados para la práctica individualizada y el seguimiento del progreso estudiantil. A pesar de los avances en plataformas educativas generales, no existen soluciones específicas que integren reconocimiento musical automático con funcionalidades pedagógicas adaptadas a la formación artística.

La propuesta de la plataforma web **PianoRise** responde a esta necesidad, ofreciendo una solución integral para el aprendizaje del piano con retroalimentación, seguimiento académico y gestión estructurada de aulas virtuales.

## 2. Planteamiento del Problema

### 2.1 Problema

La enseñanza del piano en contextos escolares carece de un sistema especializado que permita la práctica autónoma, el seguimiento estructurado del progreso musical y la gestión académica eficiente, lo cual limita el aprendizaje y dificulta la labor del docente.

**Problemáticas específicas**:

- **Ausencia de herramientas tecnológicas** adaptadas a la enseñanza musical escolar.
- **Seguimiento manual y disperso** del progreso del alumno.
- **Repertorios desorganizados y no personalizados**.
- **Falta de reportes automatizados**.
- **Experiencia poco motivadora** para los alumnos.

### 2.2 Justificación

**PianoRise** responde directamente a las carencias actuales mediante las siguientes contribuciones clave:

- Reconocimiento de notas musicales en tiempo real.  
- Seguimiento personalizado del avance del estudiante.  
- Gestión académica estructurada por aulas.  
- Reportes automatizados con métricas visuales.  
- Accesibilidad desde cualquier navegador moderno.

### 2.3 Alcance

#### Inclusiones

- Desarrollo de una **plataforma web** accesible desde navegadores modernos.
- Funcionalidades clave:
  - Gestión de usuarios y autenticación.
  - Reconocimiento de notas musicales.
  - Repertorio general y asignación de canciones.
  - Retroalimentación visual y auditiva.
  - Gestión y código de acceso a aulas.
  - Registro del progreso del estudiante.
  - Monitoreo docente.
  - Generación de reportes.

#### Exclusiones

- No incluye aplicaciones móviles.
- No contempla enseñanza de otros instrumentos.
- No incluye evaluación avanzada o teoría musical compleja.
- No se integrará con plataformas externas.

## 3. Objetivos

### Objetivo General

> Desarrollar una plataforma web interactiva para el aprendizaje autónomo del piano con reconocimiento de notas musicales denominado **PianoRise**.

### Objetivos Específicos

- Módulo de autenticación y gestión de credenciales.
- Gestión de aulas virtuales con código de acceso.
- Registro y administración de docentes.
- Captura de audio y reconocimiento de notas.
- Selección de canciones desde el repertorio.
- Gestión del repertorio general por el administrador.
- Registro de progreso y errores cometidos.
- Monitoreo del avance estudiantil por parte del docente.
- Reportes automatizados con gráficos y exportación a PDF.

## 4. Marco Teórico

El aprendizaje musical asistido por tecnologías interactivas ha evolucionado significativamente en la última década. Estudios como los de Collins (2020) y Tanaka et al. (2021) destacan la importancia de herramientas de retroalimentación automática en el desarrollo de habilidades instrumentales.

En este contexto, sistemas de reconocimiento de audio han sido empleados exitosamente en entornos educativos para evaluar la precisión de ejecución de instrumentos como piano, guitarra y violín.

El reconocimiento de notas musicales mediante procesamiento digital de señales se apoya en librerías como Librosa o Essentia, capaces de identificar frecuencias fundamentales y transformarlas en notación musical (Smith, 2019). Estas tecnologías permiten comparar la ejecución del estudiante con una partitura de referencia, generando reportes objetivos sobre errores, precisión y mejora.

En términos pedagógicos, la gamificación, la retroalimentación inmediata y el aprendizaje autónomo son principios clave que sustentan plataformas como Simply Piano y Yousician, aunque estas carecen de gestión académica por parte del docente (Lopez et al., 2023).

**PianoRise** se diferencia al combinar capacidades de seguimiento estructurado, asignación de repertorio y visualización de avances, lo que responde a los principios del modelo de enseñanza musical estructurada (Gordon, 2017).

## 5. Desarrollo de la Solución

### 5.1 Análisis de Factibilidad

#### Factibilidad técnica

El sistema se desarrolla utilizando ASP.NET (MVC) para el backend y frontend, y Python con Flask para el reconocimiento de notas musicales. Se despliega en Azure App Service, con PostgreSQL como base de datos relacional y contenedores Docker para modularidad. Todas las herramientas son compatibles con los entornos de desarrollo actuales (Windows 10/11) y permiten escalabilidad futura.

#### Factibilidad económica

El costo total estimado es de **S/. 33,960**, distribuido en infraestructura (Azure y NeonTech) y sueldos de desarrollo (3 integrantes, 4 meses). Se han mitigado costos mediante el uso de licencias gratuitas y servicios en la nube de bajo costo.

#### Factibilidad operativa

El sistema puede ser operado por docentes sin conocimientos técnicos avanzados, gracias a su interfaz intuitiva. Requiere únicamente acceso a navegador web y micrófono. La carga operativa es baja, con mantenimiento semestral y actualizaciones incrementales.

### 5.2 Tecnología de Desarrollo

| Componente               | Tecnología                             |
|--------------------------|-----------------------------------------|
| Frontend / Backend       | ASP.NET MVC + Tailwind CSS              |
| Reconocimiento de notas  | Python (Flask) + Librosa                |
| Base de datos            | PostgreSQL (NeonTech)                   |
| Hospedaje                | Azure App Service                       |
| Contenedores             | Docker                                  |
| Infraestructura          | Terraform                               |
| Entornos de desarrollo   | Visual Studio 2022, Visual Studio Code  |

### 5.3 Metodología de implementación

Se empleó la metodología ágil **Scrum** en 5 sprints:

| Sprint | Actividad Principal                                  |
|--------|-------------------------------------------------------|
| 1      | Requisitos y diseño de interfaz                      |
| 2      | Autenticación y gestión de usuarios                  |
| 3      | Aulas virtuales, repertorio y reconocimiento básico  |
| 4      | Monitoreo, historial y reportes                      |
| 5      | Pruebas, mejoras e integración final                 |

## 6. Cronograma

| Fecha        | Actividad / Módulo                          | Descripción                                                              |
|--------------|---------------------------------------------|--------------------------------------------------------------------------|
| 30/04/2025   | Inicio del Proyecto                         | Inicio oficial del desarrollo del sistema PianoRise.                     |
| 30/04/2025   | Configuración del entorno Python            | Instalación de dependencias (pyaudio, librosa, etc.).                    |
| 01/05/2025   | Módulo Captura de Audio                     | Captura de audio en tiempo real mediante micrófono.                      |
| 01/05/2025   | Procesamiento de Frecuencias                | Extracción de notas musicales desde el espectro.                         |
| 02/05/2025   | Comparación de Notas y Evaluación           | Evaluación de notas correctas e incorrectas.                             |
| 02/05/2025   | Feedback Visual del Progreso                | Visualización de aciertos al tocar notas.                                |
| 03/05/2025   | Primera Entrega                             | Entrega del módulo de reconocimiento.                                    |
| 04–05/05     | Autenticación                               | Registro e inicio de sesión para administradores, docentes y alumnos.    |
| 06–07/05     | Gestión de Aulas Virtuales                  | Creación y edición de aulas.                                             |
| 08–09/05     | Registro de Docentes                        | Administración de docentes por parte del administrador.                  |

## 7. Presupuesto

| Categoría de Costo     | Costo Total (S/.) |
|------------------------|-------------------|
| Costos Generales       | 0                 |
| Costos Operativos      | 0                 |
| Costos del Ambiente    | 20,400            |
| Costos de Personal     | 13,560            |
| **Total del Proyecto** | **S/ 33,960**     |

> **Tabla 01**. Tabla de los costos totales para el desarrollo de la plataforma PianoRise.  
> **Fuente**: Elaboración propia.

