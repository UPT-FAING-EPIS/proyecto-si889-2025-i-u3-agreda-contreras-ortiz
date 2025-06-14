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

***Agreda Ramirez, Jesús Eduardo 	(2021069823)***  
***Contreras Lipa, Alvaro Javier    (2021070020)***  
***Ortiz Fernandez, Ximena Andrea 	(2021071080)***

**Tacna – Perú**  
**2025**
</center>

---

**Plataforma Web Interactiva para el Aprendizaje Autónomo del Piano con Reconocimiento de Notas en Tiempo Real \- PianoRise**

**Documento de Especificación de Requerimientos de Software**

**Versión *1.0***

| CONTROL DE VERSIONES |  |  |  |  |  |
| :---: | :---: | :---: | :---: | :---: | ----- |
| Versión | Hecha por | Revisada por | Aprobada por | Fecha | Motivo |
| 1.0 |  |  |  | 29/03/2025 | Versión Original |
| 2.0 |  |  |  | 10/06/2025 | Version 2.0      |

---
**ÍNDICE GENERAL**

[Introducción](#introducción)

[I. Generalidades de la Empresa](#generalidades-de-la-empresa)

[1\. Nombre de la Empresa](#nombre-de-la-empresa)

[2\. Visión](#visión)

[3\. Misión](#misión)

[4\. Organigrama](#organigrama)

[II. Visionamiento de la Empresa](#visionamiento-de-la-empresa)

[1\. Descripción del Problema](#descripción-del-problema)

[2\. Objetivos de Negocios](#objetivos-de-negocios)

[3\. Objetivos de Diseño](#objetivos-de-diseño)

[4\. Alcance del proyecto](#alcance-del-proyecto)

[5\. Viabilidad del sistema](#viabilidad-del-sistema)

[6\. Información obtenida del Levantamiento de Información](#información-obtenida-del-levantamiento-de-información)

[III. Análisis de Procesos](#análisis-de-procesos)

[a) Diagrama del Proceso Actual \- Diagrama de actividades](#diagrama-del-proceso-actual---diagrama-de-actividades)

[b) Diagrama del Proceso Propuesto \- Diagrama de actividades Inicial](#diagrama-del-proceso-propuesto---diagrama-de-actividades-inicial)

[IV. Especificación de Requerimientos de Software](#especificación-de-requerimientos-de-software)

[a) Cuadro de Requerimientos Funcionales Inicial](#cuadro-de-requerimientos-funcionales-inicial)

[b) Cuadro de Requerimientos No Funcionales](#cuadro-de-requerimientos-no-funcionales)

[c) Cuadro de Requerimientos Funcionales Final](#cuadro-de-requerimientos-funcionales-inicial)

[d) Reglas de Negocio](#reglas-de-negocio)

[V. Fases de Desarrollo](#fases-de-desarrollo)

[1\. Perfiles de Usuario](#perfiles-de-usuario)

[2\. Modelo Conceptual](#modelo-conceptual)

[a) Diagrama de Paquetes](#diagrama-de-paquetes)

[b) Diagrama de Casos de Uso](#diagrama-de-casos-de-uso)

[c) Escenarios de Caso de Uso (Narrativa)](#escenarios-de-caso-de-uso-\(narrativa\))

[3\. Modelo Lógico](#modelo-lógico)

[a) Análisis de Objetos](#análisis-de-objetos)

[b) Diagrama de Actividades con Objetos](#diagrama-de-actividades-con-objetos)

[c) Diagrama Secuencia](#diagrama-secuencia)

[d) Diagrama de Clases](#diagrama-de-clases-\(link-a-diagrama-de-clases\))

[Conclusiones](#conclusiones)

[Recomendaciones](#recomendaciones)

---

## **Documento de Especificación de Requerimientos de Software**

### **Introducción** {#introducción}

El presente documento de Especificación de Requerimientos de Software (SRS) describe los requisitos funcionales y no funcionales para el desarrollo de la plataforma PianoRise, una aplicación web interactiva diseñada para facilitar el aprendizaje autónomo del piano, especialmente para estudiantes principiantes. Esta plataforma surge como una solución educativa innovadora ante los desafíos que enfrentan quienes desean aprender piano sin acceso a instrucción presencial o métodos interactivos eficaces.

En respuesta a la necesidad de ofrecer una herramienta accesible, práctica y motivadora, PianoRise busca establecer un nuevo estándar en la enseñanza digital del piano. Mediante una interfaz intuitiva y un sistema de reconocimiento de audio, la plataforma permitirá a los usuarios visualizar en pantalla las notas a tocar, recibir retroalimentación inmediata y monitorear su avance.

Además, PianoRise se compromete a brindar una experiencia didáctica centrada en la práctica, ofreciendo un repertorio de canciones básicas, ejercicios progresivos y una estructura de aprendizaje flexible. Todo ello se desarrollará bajo tecnologías web modernas, permitiendo el acceso desde navegadores sin necesidad de instalación adicional.

Este documento establece los objetivos funcionales y técnicos del sistema, así como el alcance del proyecto, incluyendo las funcionalidades que serán implementadas en esta primera versión y las limitaciones correspondientes. Su propósito es servir como guía para el diseño, desarrollo, validación y mantenimiento de la plataforma PianoRise.



---

1. #### **Generalidades de la Empresa** {#generalidades-de-la-empresa}

   1. ##### **Nombre de la Empresa** {#nombre-de-la-empresa}

      Institución Educativa Privada Verdad y Vida – Veritas et Vita.

   2. ##### **Visión** {#visión}

      Ser una institución educativa líder en la formación integral de estudiantes, promoviendo valores éticos, responsabilidad social y excelencia académica, contribuyendo al desarrollo sostenible de la sociedad.

   3. ##### **Misión** {#misión}

      Brindar una educación de calidad que fomente el desarrollo de competencias académicas, personales y sociales en los estudiantes, mediante una enseñanza innovadora y comprometida con los valores institucionales.​​

   4. ##### **Organigrama** {#organigrama}
<center>

   ![width:320](../media/Organigrama.png)  
   
   **Gráfico 01\.** Organigrama  de la Institución Educativa Privada Verdad y Vida.
   ***Fuente:** Elaboración propia.*

</center>

---

2. #### Visionamiento de la Empresa

   1. ##### **Descripción del Problema** {#descripción-del-problema}

      Actualmente, en el entorno de enseñanza musical, los procesos de gestión y seguimiento de las clases de piano presentan importantes limitaciones debido a la falta de herramientas tecnológicas especializadas. El manejo de aulas, el seguimiento del progreso de los estudiantes y la organización del repertorio musical se realizan de manera manual o utilizando plataformas no adaptadas a las necesidades específicas de la formación instrumental. Esta situación genera ineficiencias, dificulta la evaluación objetiva del desempeño y limita el crecimiento académico de los estudiantes. Los principales problemas identificados son:

      - **Procesos manuales e ineficientes**: La creación y gestión de clases, así como el seguimiento del progreso de los alumnos, se realiza de forma manual o con herramientas genéricas, lo que provoca demoras, errores y sobrecarga de trabajo para los docentes.
      - **Falta de seguimiento estructurado del desempeño estudiantil**: Actualmente, no se dispone de un sistema que registre de manera organizada las canciones practicadas, los errores cometidos y los logros alcanzados por los estudiantes, dificultando así una evaluación continua y objetiva.
      - **Ausencia de un módulo especializado para repertorios musicales**: No existe un sistema que permita seleccionar y administrar repertorios adaptados al nivel de cada aula, limitando la personalización de la enseñanza y el desarrollo musical de los estudiantes.
      - **Gestión desorganizada de información**: El registro de alumnos, aulas y progreso de aprendizaje se realiza de forma dispersa, aumentando el riesgo de pérdida de datos importantes y dificultando la obtención de reportes consolidados.
      - **Limitada visibilidad para los docentes sobre el avance de sus estudiantes**: Los docentes carecen de herramientas que les permitan monitorear de forma clara y detallada el desempeño de cada alumno, lo que dificulta identificar áreas de mejora y establecer estrategias de refuerzo.
      - **Falta de mecanismos para generar reportes de desempeño**: No se dispone de un sistema automatizado que permita generar reportes gráficos o métricos sobre el progreso individual y grupal, lo que restringe la capacidad de análisis y retroalimentación educativa.
   2. ##### **Objetivos de Negocios** {#objetivos-de-negocios}
   - Proporcionar una solución tecnológica accesible para mejorar la enseñanza del piano a estudiantes principiantes.
   - Incrementar el interés de los estudiantes en la práctica diaria mediante una plataforma interactiva.
   - Asegurar la participación activa de los docentes al incorporar PianoRise como herramienta complementaria para la enseñanza presencial.
   - Facilitar el monitoreo del progreso de los estudiantes a través de una interfaz de administración para docentes, mejorando la eficiencia en el seguimiento y evaluación del rendimiento.

   3. ##### **Objetivos de Diseño** {#objetivos-de-diseño}
      El diseño del sistema busca cumplir con una serie de objetivos estratégicos y técnicos que garanticen una experiencia efectiva, funcional y sostenible tanto para los estudiantes como para los       docentes y administradores. Los principales objetivos de diseño considerados en el desarrollo de la plataforma:
      - Interfaz intuitiva y centrada en el usuario
      - Evaluación musical con retroalimentación inmediata
      - Seguimiento personalizado del progreso
      - Gestión del repertorio por aula
      - Reportes detallados de desempeño
      - Gestión de usuarios y control de acceso


   4. ##### **Alcance del proyecto** {#alcance-del-proyecto}

      1) Inclusiones
         - **Desarrollo de una Plataforma Web**: 
            - Creación de una plataforma web accesible desde navegadores (Chrome, Firefox, Edge), con una interfaz gráfica intuitiva y moderna.
         - **Funcionalidades Clave**:
            - **Gestión de usuarios**: 
               - Permitir el registro seguro de usuarios mediante la creación de credenciales de acceso.
               - Implementar el inicio de sesión y cierre de sesión de forma segura.
               - Permitir la edición de información personal por parte de los usuarios, y la gestión de cuentas docentes por parte del administrador.
            - **Reconocimiento de notas**:
               - Capturar y procesar el audio a través del micrófono del usuario.
               - Detectar las notas musicales tocadas y compararlas con las notas esperadas en cada ejercicio o canción.
               - Proporcionar retroalimentación sobre la precisión de la ejecución.
            - **Repertorio de canciones**:
               - Gestionar un repertorio general de canciones sencillas, administrado por el administrador del sistema.
               - Permitir que los docentes seleccionen las canciones del repertorio general que serán asignadas a su aula.
               - Permitir a los estudiantes seleccionar canciones asignadas a su aula para practicarlas.
      
            - **Retroalimentación visual y auditiva**: 
               - Mostrar en pantalla indicaciones visuales que resalten las notas tocadas correctamente e indiquen los errores cometidos.
               - Emitir señales auditivas de confirmación para notas acertadas y alertas para notas incorrectas.
            - **Gestión de aulas**:
               - Creación de aulas: Solo el administrador tiene la facultad de crear aulas dentro del sistema. Durante este proceso, deberá asignar un docente responsable a cada aula.

               - Edición por docentes: El docente asignado será responsable de editar la información de su aula, incluyendo la configuración del repertorio de canciones, los detalles del aula y la gestión de estudiantes.

               - Código de ingreso: El sistema generará automáticamente un código único por aula. Los estudiantes podrán unirse a su aula correspondiente mediante este código.
            
            - **Almacenamiento de progreso de los estudiantes**:
               - Registrar únicamente las canciones que los estudiantes completen satisfactoriamente.
               - Almacenar la cantidad de errores cometidos en cada canción finalizada.
            - **Monitoreo del progreso por parte de los docentes**:
               - Permitir a los docentes visualizar el avance de sus estudiantes, identificando canciones completadas y no completadas.
               - Mostrar el puntaje y los errores obtenidos por cada estudiante en cada canción.
            
            - **Generación de reportes de desempeño**
               - Generar reportes que incluyan métricas y gráficos sobre el desempeño general del aula.
               - Permitir la descarga o visualización de reportes para seguimiento académico.
            
         - **Soporte Tecnológico**: 
           - El sistema utilizará bibliotecas especializadas en procesamiento de audio, para la detección de notas musicales.


      2) Exclusiones:
         - **Compatibilidad móvil**: El sistema será exclusivo para su uso en plataformas web y no contará con versiones nativas para dispositivos móviles o aplicaciones móviles.
         - **Instrumentos adicionales**: El sistema estará enfocado exclusivamente en la enseñanza del piano, sin inclusión de otros instrumentos musicales.
         - **Evaluación avanzada**: No se incluirán características avanzadas como la evaluación de la velocidad de ejecución o teoría musical compleja
         - **Integración con plataformas externas**: No habrá integraciones con plataformas externas de música o herramientas de aprendizaje de piano.

   5. ##### **Viabilidad del sistema** {#viabilidad-del-sistema}

      1. **Viabilidad Técnica:**

         - Hardware:
            Servidores:
            - Host para el Servicio de Cursos de Música: Se utilizará Azure App Service en un plan de pago básico para desplegar el servicio desarrollado en ASP.NET. Este servicio en la nube garantiza la estabilidad, escalabilidad automática, administración simplificada y alta disponibilidad del sistema.
            - Host para el Servicio de Reconocimiento de Notas: El módulo especializado en reconocimiento de notas musicales, desarrollado en Python, estará contenerizado en Docker y estará desplegado en Microsoft Azure App Service.


            Estaciones de trabajo:
            - Se cuenta con computadoras personales para los desarrolladores con especificaciones estándar que incluyen procesadores Intel i5/i7, 8–16GB de RAM, y SSDs, que garantizan un entorno de desarrollo ágil y funcional.
         - Software
            Sistemas operativos:
            - Desarrollo realizado en Windows, el cual es compatible con las herramientas seleccionadas.
   
         - Aplicaciones y Herramientas de Desarrollo:
            - Visual Studio Code: Es uno de los entornos de desarrollo principales utilizados en el proyecto, compatible con los sistemas operativos Windows y macOS. Ofrece una gran variedad de extensiones que permiten personalizar el entorno de trabajo, facilitando la programación y la gestión de proyectos.
            - Visual Studio 2022: También se emplea Visual Studio 2022 como entorno de desarrollo integral (IDE), especialmente para el desarrollo de aplicaciones ASP.NET MVC. Ofrece herramientas avanzadas para depuración, integración continua y desarrollo en la nube, optimizando así la productividad del equipo.
            - Terraform: Utilizado para la creación y gestión automatizada de la infraestructura en Azure, asegurando consistencia, control de cambios y escalabilidad en los recursos desplegados.


         - Lenguajes y frameworks:
            - Servicio de Cursos de Música: ASP.NET con .NET Framework utilizando el patrón Modelo-Vista-Controlador (MVC) y Tailwind CSS para la maquetación y diseño visual de las interfaces.
            - Servicio de Reconocimiento de notas musicales: El procesamiento de audio será realizado de forma independiente usando Python con librerías especializadas.
         - Infraestructura de red y acceso a internet:
            El sistema se desarrollará y desplegará completamente en línea. Se cuenta con acceso estable a internet para todas las fases del proyecto, y el alojamiento web asegurado con dominio personalizado.
         - Compatibilidad de navegadores:
            El sistema será accesible desde navegadores modernos como Google Chrome, Mozilla Firefox, Microsoft Edge y Safari, sin necesidad de instalar software adicional.

      2. **Viabilidad Económica:**

         - Desarrollo e Implementación: 


            - Desarrollo del software:
                           PianoRise se desarrollará utilizando ASP.NET Framework en MVC para el backend y frontend. Este enfoque de tecnología proporciona una plataforma robusta, escalable y de código abierto, lo que minimiza los costos de licencias. Python se utilizará únicamente para el módulo de reconocimiento de notas musicales, el cual se desplegará en Azure App Service.


            - Infraestructura:
               El sistema se desplegará en los servicios de Azure. Tanto el servicio de Cursos de Musica y el Servicio de Reconocimiento de Notas Azure App Service. Se utilizará una base de datos PostgreSQL proporcionada por NeonTech, que tiene costos asociados, así como los costos derivados de los servicios de Azure.


            - Base de datos y almacenamiento:
            Se usará PostgreSQL proporcionado por NeonTech para la gestión de la base de datos, aprovechando su confiabilidad y características avanzadas. Los archivos de audio y recursos multimedia se almacenarán en servidores web o en soluciones de almacenamiento en la nube de Azure, optimizando costos y escalabilidad.



         - Mantenimiento y Soporte:

            - Actualización del software:
            El mantenimiento y actualización del software se llevarán a cabo periódicamente para implementar nuevas funcionalidades, garantizar la seguridad y mejorar la compatibilidad con navegadores modernos. Un programador con experiencia en ASP.NET y bases de datos será necesario para realizar estas tareas de mantenimiento.


            - Capacitación del personal:
            Se proporcionará capacitación inicial a los docentes y administradores para gestionar las aulas, monitorear el progreso de los estudiantes y generar reportes. Gracias a su interfaz intuitiva, el tiempo de aprendizaje del sistema se reduce significativamente.


         - Beneficios Económicos:
            - Reducción de costos en materiales didácticos:
               La digitalización de partituras y la automatización del seguimiento del progreso estudiantil eliminará la necesidad de materiales físicos, reduciendo costos operativos.

            - Optimización del tiempo docente:
               El monitoreo automático del progreso estudiantil permitirá a los docentes centrarse en aspectos más cualitativos del aprendizaje, optimizando su tiempo y recursos.
            
            - Oferta de talleres pagados:
               La plataforma permitirá a los docentes monetizar talleres de refuerzo musical, generando ingresos adicionales.
            
            - Licencias institucionales:
               Las instituciones educativas podrán adquirir licencias para sus estudiantes, generando ingresos recurrentes para el sistema.
            
            - Mejora del rendimiento estudiantil:
               El sistema de práctica personalizada incrementará la competencia musical de los estudiantes, lo que, a su vez, mejorará el prestigio de las instituciones educativas.

      3.  **Viabilidad Operativa:**
            La factibilidad operativa analiza si el sistema propuesto puede ser implementado, mantenido y utilizado de forma efectiva por la organización y los usuarios finales. En el caso de “PianoRise”, el sistema brindará beneficios significativos en el proceso de enseñanza y evaluación de habilidades musicales.

            - Beneficios del Sistema:
               - Automatización del proceso de creación y gestión de aulas virtuales.
               - Mejora en la eficiencia del seguimiento del progreso de los alumnos.
               - Disminución del tiempo requerido para evaluar el desempeño en ejercicios musicales.
               - Fortalecimiento de la relación entre docentes y alumnos a través de retroalimentación digital inmediata.
               - Facilidad de uso para docentes y alumnos mediante interfaces intuitivas.
               - Posibilidad de expansión hacia nuevos módulos como repertorios personalizados o torneos de práctica musical.

            - Capacidad Operativa:
               - El sistema es autoadministrado por el personal docente de la Escuela de Música, con soporte técnico mínimo requerido.
               - Los usuarios (docentes y alumnos) reciben interfaces diferenciadas según su rol y necesidades específicas.
               - Se considera un uso liviano a moderado del sistema (baja concurrencia simultánea), por lo que no se requieren recursos tecnológicos de alta demanda.
               - La aplicación cuenta con paneles de control y módulos de práctica amigables, que no requieren entrenamiento técnico especializado para su operación.

   6. ##### **Información obtenida del Levantamiento de Información:**{#información-obtenida-del-levantamiento-de-información}

      Se analizaron diversas herramientas actualmente utilizadas por docentes y estudiantes en el proceso de aprendizaje del piano. Este análisis permitió comprender las fortalezas y limitaciones de dichas herramientas frente a las necesidades específicas del entorno educativo donde se implementará el sistema.
      Entre las herramientas se encuentran:
      - Aplicaciones móviles como Simply Piano: Esta plataforma ofrece lecciones guiadas, reconocimiento de notas y ejercicios interactivos. Sin embargo, su enfoque es general y no permite una gestión personalizada por parte del docente ni seguimiento detallado del progreso en un entorno de aula.
      - Métodos tradicionales con partituras impresas y evaluaciones manuales: Aunque son ampliamente utilizados, estos métodos requieren de la presencia constante del docente para brindar retroalimentación, y no permiten un registro automático ni histórico del progreso del estudiante.
      - Videos educativos en plataformas como YouTube: Muchos estudiantes recurren a tutoriales en línea para complementar su práctica. No obstante, este enfoque es completamente autodidacta, no estructurado y carece de evaluación o seguimiento personalizado.


---

3. #### Análisis de Procesos

   1) ##### **Diagrama del Proceso Actual \- Diagrama de actividades** {#diagrama-del-proceso-actual---diagrama-de-actividades}

      "El sistema actual no cuenta con un flujo definido. PianoRise viene a estructurar este proceso."

   2) #####  **Diagrama del Proceso Propuesto \- Diagrama de actividades Inicial** {#diagrama-del-proceso-propuesto---diagrama-de-actividades-inicial}

   <center>

      ![width=500](../media/DiagramaProcesoPropuesto.png)  


      **Diagrama 01:** El diagrama representa el flujo de PianoRise.
   </center>
---


4. #### **Especificación de Requerimientos de Software** {#especificacion-de-requerimientos-de-software}

   ## a) Cuadro de Requerimientos Funcionales Inicial

   | Código  | Requerimiento                                | Descripción                                                                                                                                                                                                                          | Prioridad |
   |---------|-----------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|-----------|
   | RF-01   | Gestionar autenticación y credenciales del usuario | Permitir a los usuarios registrarse en el sistema proporcionando sus credenciales de acceso. Además, el sistema debe permitir que los usuarios puedan iniciar sesión utilizando dichas credenciales y cerrar sesión de forma segura. | Alta      |
   | RF-02   | Almacenar progreso                            | Guardar el progreso de los estudiantes únicamente cuando completen satisfactoriamente una canción. El sistema registrará la canción como completada y almacenará la cantidad de errores cometidos durante su ejecución.              | Alta      |
   | RF-03   | Reconocer notas musicales                     | Capturar y procesar el audio del usuario a través del micrófono, identificando las notas tocadas y comparándolas con las esperadas en cada ejercicio.                                                                                | Alta      |
   | RF-04   | Seleccionar canciones de un repertorio        | Permitir que los estudiantes elijan canciones disponibles en el repertorio personalizado de su aula para practicarlas dentro del sistema.                                                                                           | Media     |
   | RF-05   | Gestionar repertorio de canciones             | Permitir que los administradores agreguen, editen o deshabiliten canciones del repertorio disponible general antes y después de la configuración del aula.                                                                          | Media     |
   | RF-06   | Monitorear progreso de estudiantes            | Permitir que los docentes visualicen el estado de las canciones completadas y no completadas por cada estudiante, junto con la puntuación obtenida en cada canción.                                                                 | Alta      |
   | RF-07   | Generar reportes de desempeño                 | Generar un reporte que muestre diferentes métricas y gráficos del desempeño de un aula.                                                                                                                                            | Media     |
   | RF-08   | Gestionar Aulas                               | Permitir que el administrador cree aulas dentro del sistema y asigne a un docente responsable por cada una. Tanto el administrador como el docente podrán generar o actualizar el código de ingreso de 4 dígitos para el aula. Este código será utilizado por los estudiantes para unirse. El docente será responsable de editar los contenidos del aula, como el repertorio de canciones, descripción y demás configuraciones académicas. | Alta      |
   | RF-09   | Gestionar Docentes                            | Permitir al administrador del sistema registrar nuevos docentes creando sus credenciales de acceso definiendo su nombre, apellido, correo y contraseña. Además, de poder editar y deshabilitar.                                   | Alta      |

   ---

   ## b) Cuadro de Requerimientos No Funcionales

   | Código   | Requerimiento                       | Descripción                                                                                                                                                                                                                  |
   |----------|--------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
   | RNF-01   | Garantizar disponibilidad del sistema | El sistema debe garantizar una disponibilidad mínima del 97%, asegurando su correcto funcionamiento para el aprendizaje interactivo del piano. Esta disponibilidad considera mantenimientos programados y posibles interrupciones imprevistas. |
   | RNF-02   | Seguridad en la plataforma            | PianoRise debe proteger la información de los usuarios mediante mecanismos de autenticación y control de acceso. Se deben realizar pruebas de seguridad, incluyendo análisis de vulnerabilidades y pruebas de penetración.     |
   | RNF-03   | Escalabilidad del sistema             | El sistema debe ser capaz de manejar un aumento en el número de usuarios sin afectar el rendimiento. Se prioriza una arquitectura optimizada para procesamiento de audio y reconocimiento de notas musicales sin latencias significativas. |
   | RNF-04   | Usabilidad de la plataforma           | El sistema debe ofrecer una interfaz intuitiva y accesible, especialmente diseñada para principiantes en el piano.                                                                                                              |

   ---

   ## c) Cuadro de Requerimientos Funcionales Final

   > Nota: Coinciden con los iniciales, se repiten para validación posterior.

   | Código  | Requerimiento                                | Descripción                                                                                                                                                                                                                          | Prioridad |
   |---------|-----------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|-----------|
   | RF-01   | Gestionar autenticación y credenciales del usuario | Permitir a los usuarios registrarse en el sistema proporcionando sus credenciales de acceso. Además, el sistema debe permitir que los usuarios puedan iniciar sesión utilizando dichas credenciales y cerrar sesión de forma segura. | Alta      |
   | RF-02   | Almacenar progreso                            | Guardar el progreso de los estudiantes únicamente cuando completen satisfactoriamente una canción. El sistema registrará la canción como completada y almacenará la cantidad de errores cometidos durante su ejecución.              | Alta      |
   | RF-03   | Reconocer notas musicales                     | Capturar y procesar el audio del usuario a través del micrófono, identificando las notas tocadas y comparándolas con las esperadas en cada ejercicio.                                                                                | Alta      |
   | RF-04   | Seleccionar canciones de un repertorio        | Permitir que los estudiantes elijan canciones disponibles en el repertorio personalizado de su aula para practicarlas dentro del sistema.                                                                                           | Media     |
   | RF-05   | Gestionar repertorio de canciones             | Permitir que los administradores agreguen, editen o deshabiliten canciones del repertorio disponible general antes y después de la configuración del aula.                                                                          | Media     |
   | RF-06   | Monitorear progreso de estudiantes            | Permitir que los docentes visualicen el estado de las canciones completadas y no completadas por cada estudiante, junto con la puntuación obtenida en cada canción.                                                                 | Alta      |
   | RF-07   | Generar reportes de desempeño                 | Generar un reporte que muestre diferentes métricas y gráficos del desempeño de un aula.                                                                                                                                            | Media     |
   | RF-08   | Gestionar Aulas                               | Permitir que el administrador cree aulas dentro del sistema y asigne a un docente responsable por cada una. Tanto el administrador como el docente podrán generar o actualizar el código de ingreso de 4 dígitos para el aula. Este código será utilizado por los estudiantes para unirse. El docente será responsable de editar los contenidos del aula, como el repertorio de canciones. | Alta      |
   | RF-09   | Gestionar Docentes                            | Permitir al administrador del sistema registrar nuevos docentes creando sus credenciales de acceso definiendo su nombre, apellido, correo y contraseña. Además, de poder editar y deshabilitar.                                   | Alta      |

   ---

   ## d) Reglas de Negocio

   | Nombre                         | Descripción                                                                                                                                                                | Autoridad     |
   |--------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------|---------------|
   | Acceso al Aula                 | El alumno solo se podrá unir al aula ingresando el código de la misma.                                                                                                    | Sistema       |
   | Creación de aulas              | Un docente puede tener múltiples aulas activas, cada una con su propio repertorio y grupo de estudiantes.                                                                | Docente       |
   | Privilegios del administrador  | Solo el administrador puede registrar docentes y asignar el docente al aula.                                                                                              | Administrador |
   | Repertorio general predeterminado | Los docentes no pueden editar el repertorio general, solo configurar su aula seleccionando las canciones de este.                                                        | Sistema       |
   | Criterio de progreso           | Solo se registrará como “completada” una canción si el estudiante finaliza toda la pieza dentro del margen definido.                                                      | Sistema       |
   | Validación de audio            | El reconocimiento de notas debe ejecutarse de inmediato y sólo evaluará sonidos del instrumento.                                                                          | Sistema       |

---


5. #### **Fases de Desarrollo** {#fases-de-desarrollo}

---

### **Perfiles de Usuario**

- **Estudiantes**  
   Usuarios principales de la plataforma. Son alumnos de nivel escolar que utilizan PianoRise para aprender piano de forma interactiva y autónoma. Buscan una herramienta fácil de usar, motivadora y con retroalimentación inmediata. Sus actividades incluyen realizar ejercicios, tocar canciones guiadas y revisar su progreso.

- **Docentes**  
Usuarios con funciones de gestión educativa dentro del sistema. Pueden editar aulas, registrar estudiantes, asignar repertorios y revisar el avance de sus alumnos. Requieren funcionalidades que les permitan intervenir en el proceso de enseñanza y adaptar el contenido al nivel de cada grupo.

- **Administradores**  
Usuarios con acceso completo al sistema. Su perfil incluye la configuración técnica general de la plataforma, la administración del contenido (como el repertorio de canciones) y el soporte a docentes y estudiantes. También pueden generar reportes y aplicar mejoras continuas al sistema.

---

### **Modelo Conceptual**

#### Diagrama de Paquetes de la Plataforma Web

El diagrama presenta la estructura del sistema PianoRise, organizando sus funcionalidades clave en paquetes como Autenticación, Gestion Docente, Gestion Aula, Interacción Estudiante, Gestion de Canciones, Seguimiento y Reportes. Cada paquete contiene casos de uso específicos que reflejan las acciones disponibles para los usuarios.

<center>

   ![width=500](../media/dg_paquetes.png)  


   **Diagrama 02: Diagrama de Paquetes de PianoRise**  
   *Fuente: Elaboración propia.*
</center>

---

#### Diagrama de Casos de Uso de la Plataforma Web

Este diagrama de casos de uso representa las funcionalidades del sistema PianoRise. En él se identifican tres actores principales: Estudiante, Docente y Administrador, cada uno con permisos y acciones específicas. Los estudiantes pueden iniciar sesión, gestionar su autenticación, acceder a su aula, seleccionar canciones del repertorio y practicar con evaluación. Los docentes tienen acceso a funcionalidades adicionales como la gestión del repertorio musical, asignación y remoción de canciones en el aula, así como el monitoreo del progreso y la generación de reportes de desempeño. Los administradores, por su parte, gestionan las credenciales de los docentes, incluyendo su creación, edición y deshabilitación.



<center>

   ![width=500](../media/DiagramaCasosuso.png)  


   **Diagrama 03: Diagrama de Casos de Uso**  
   *Fuente: Elaboración propia.*
</center>

## c) Escenarios de Caso de Uso (Narrativa)

---

### Narrativa de CU-01: Gestionar Autenticación y Credenciales de Usuario

**Caso de Uso:** CU-01  
**Nombre:** Gestionar autenticación y credenciales de usuario  
**Actores:** Estudiante, Docente, Administrador  
**Descripción:** Permite a un usuario registrarse en el sistema, así como también iniciar sesión con sus credenciales y cerrar sesión de forma segura.  
**Precondiciones:** -  

#### Acción: Autenticar, Registrar

| ACCIÓN DEL ACTOR                                           | CURSO DEL SISTEMA                                                                                                   |
|------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------|
| El usuario accede a la plataforma PianoRise desde su navegador. | El sistema muestra la interfaz de inicio de sesión, con campos para correo y contraseña, y botones para ingresar o registrarse. |
| El usuario completa los campos y selecciona iniciar sesión. | El sistema valida las credenciales. Si son correctas, redirige al panel correspondiente. Si no, muestra error.        |

**Flujo Alternativo – Registrar Usuario**

| ACCIÓN DEL ACTOR                                           | CURSO DEL SISTEMA                                                                                                   |
|------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------|
| El usuario selecciona la opción de registrarse.            | El sistema muestra el formulario de registro.                                                                       |
| Completa los campos requeridos y selecciona “Registrarse”.| El sistema valida y registra al usuario, luego lo redirige al inicio de sesión.                                     |

---

### Narrativa de CU-02: Gestionar Aula

**Caso de Uso:** CU-02  
**Nombre:** Gestionar aula  
**Actores:** Docente, Estudiante  
**Descripción:** Permite la administración de aulas virtuales dentro de PianoRise. Los docentes pueden crear, editar, deshabilitar aulas y los estudiantes se unen mediante un código.  
**Precondiciones:** CU-01  

#### Acción: Crear aula, Unirse a aula

| ACCIÓN DEL ACTOR                             | CURSO DEL SISTEMA                                                                                                   |
|----------------------------------------------|----------------------------------------------------------------------------------------------------------------------|
| Docente accede al módulo de aulas.           | El sistema muestra la lista y opciones (crear, editar, deshabilitar).                                               |
| Selecciona “Crear aula”.                     | Se muestra formulario con nombre, descripción, configuración inicial y selección de canciones.                      |
| Completa y guarda.                           | El sistema registra el aula, canciones y genera un código único.                                                    |

**Flujos Alternativos:**

- **Editar Aula**: Docente edita un aula existente → sistema muestra y actualiza datos.
- **Deshabilitar Aula**: Docente selecciona y confirma deshabilitación → sistema inactiva el aula.
- **Unirse a Aula**: Estudiante ingresa código → sistema valida y lo une al aula.

---

### Narrativa de CU-03: Seleccionar una canción del repertorio

**Caso de Uso:** CU-03  
**Nombre:** Seleccionar una canción del repertorio  
**Actores:** Estudiante  
**Descripción:** Permite que el estudiante visualice y seleccione una canción del repertorio, con detalles como título, nivel y duración.  
**Precondiciones:** CU-01, CU-02  

#### Acción: Seleccionar una canción del repertorio

| ACCIÓN DEL ACTOR                      | CURSO DEL SISTEMA                                                                 |
|---------------------------------------|------------------------------------------------------------------------------------|
| Accede a la sección “Repertorio”.     | El sistema muestra la lista de canciones.                                          |
| Explora e inicia práctica de una canción. | El sistema carga la partitura y comienza la evaluación por micrófono.            |
| Toca el instrumento.                  | El sistema analiza y compara las notas.                                            |
| Finaliza práctica.                    | El sistema guarda el progreso.                                                    |

---

### Narrativa de CU-04: Gestionar repertorio de canciones

**Caso de Uso:** CU-04  
**Nombre:** Gestionar repertorio de canciones  
**Actores:** Docente  
**Descripción:** Permite agregar o quitar canciones del repertorio del aula.  
**Precondiciones:** CU-01, CU-02  

#### Acción: Gestionar repertorio de canciones

| ACCIÓN DEL ACTOR                              | CURSO DEL SISTEMA                                                                          |
|-----------------------------------------------|---------------------------------------------------------------------------------------------|
| Accede al “Repertorio del aula”.              | El sistema muestra canciones asignadas y opciones de gestión.                              |
| Selecciona “Agregar canciones”.               | El sistema muestra el repertorio general.                                                  |
| Selecciona canciones para agregar.            | El sistema las asigna al aula.                                                             |
| Selecciona una canción del aula y elige “Remover”. | El sistema muestra confirmación, y luego la desasocia del aula.                        |

---

### Narrativa de CU-05: Monitorear progreso de estudiantes

**Caso de Uso:** CU-05  
**Nombre:** Monitorear progreso de estudiantes  
**Actores:** Docente  
**Descripción:** Permite visualizar el progreso individual de cada estudiante: canciones completadas y puntuaciones.  
**Precondiciones:** CU-01, CU-02  

#### Acción: Monitorear progreso

| ACCIÓN DEL ACTOR                     | CURSO DEL SISTEMA                                                                    |
|--------------------------------------|---------------------------------------------------------------------------------------|
| Accede a “Monitorear progreso”.      | El sistema muestra la lista de estudiantes.                                           |
| Selecciona un estudiante.            | El sistema muestra detalles del progreso y puntuación.                               |
| Revisa métricas.                     | El sistema presenta gráficos de desempeño.                                           |

---

### Narrativa de CU-06: Generar reportes de desempeño

**Caso de Uso:** CU-06  
**Nombre:** Generar reportes de desempeño  
**Actores:** Docente  
**Descripción:** Permite generar y exportar reportes del progreso del aula, incluyendo gráficos y métricas.  
**Precondiciones:** CU-01, CU-02  

#### Acción: Generar reportes

| ACCIÓN DEL ACTOR                        | CURSO DEL SISTEMA                                                                 |
|-----------------------------------------|------------------------------------------------------------------------------------|
| Accede a “Reportes de desempeño”.       | El sistema muestra filtros y opciones.                                            |
| Selecciona parámetros.                  | El sistema genera vista previa de gráficos.                                       |
| Revisa gráficos.                        | El sistema muestra desempeño detallado.                                           |
| Exporta reporte.                        | El sistema genera archivo PDF y confirma exportación.                             |

---

### Narrativa de CU-07: Gestionar Docente

**Caso de Uso:** CU-07  
**Nombre:** Gestionar docente  
**Actores:** Administrador  
**Descripción:** Permite al administrador registrar, editar y deshabilitar cuentas de docentes.  
**Precondiciones:** CU-01  

#### Acción: Gestionar credenciales de docente

**Flujo Alternativo – Crear Docente**

| ACCIÓN DEL ACTOR                      | CURSO DEL SISTEMA                                                              |
|---------------------------------------|---------------------------------------------------------------------------------|
| Accede a gestión de docentes.         | El sistema muestra la lista con opciones.                                       |
| Selecciona “Crear docente”.           | El sistema muestra formulario con nombre, correo y contraseña.                 |
| Completa y confirma.                  | El sistema registra al nuevo docente y muestra mensaje de éxito.               |

**Flujo Alternativo – Editar Docente**

| ACCIÓN DEL ACTOR                      | CURSO DEL SISTEMA                                                              |
|---------------------------------------|---------------------------------------------------------------------------------|
| Selecciona docente existente y “Editar”. | El sistema muestra el formulario actual.                                     |
| Modifica campos y guarda.             | El sistema actualiza los datos y muestra confirmación.                         |

**Flujo Alternativo – Deshabilitar Docente**

| ACCIÓN DEL ACTOR                      | CURSO DEL SISTEMA                                                              |
|---------------------------------------|---------------------------------------------------------------------------------|
| Selecciona docente y “Deshabilitar”.  | El sistema solicita confirmación.                                              |
| Confirma la acción.                   | El sistema desactiva la cuenta del docente.                                     |

   3. ##### **Modelo Lógico** {#modelo-lógico}

      1) ##### Análisis de Objetos {#análisis-de-objetos}

      Objetos Entidad:

      <center>

      ![width=500](../media/entidad.png)

      **Gráfico 03:** Objetos entidad de la plataforma web PianoRise.
      <br>
      **Fuente:** Elaboración propia.
      </center>

      Objetos Frontera:

      <center>

      ![width=500](../media/frontera.png)

      **Gráfico 04:** Objetos frontera de la plataforma web PianoRise.
      <br>
      **Fuente:** Elaboración propia.
      </center>

      Objetos Control:

      <center>

      ![width=500](../media/controlador.png)

      **Gráfico 05:** Objetos control de la plataforma web PianoRise.
      <br>
      **Fuente:** Elaboración propia.
      </center>

      2) ##### Diagrama de Actividades con Objetos {#diagrama-de-actividades-con-objetos}

      <center>
      
      Caso de uso 01: Gestionar Autenticación y Credenciales de Usuario
      
      ![width=500](../media/actividades-1.png)

      **Diagrama 04:** Diagrama de actividades con objetos del caso de uso 01.
      <br>
      **Fuente:** Elaboración propia.
      </center>

      <center>
      
      Caso de uso 02: Gestionar Aula
      
      ![width=500](../media/actividades-2.png)

      **Diagrama 05:** Diagrama de actividades con objetos del caso de uso 02.
      <br>
      **Fuente:** Elaboración propia.
      </center>
      
      <center>
      
      Caso de uso 03: Seleccionar Canción del Repertorio
      
      ![width=500](../media/actividades-3.png)

      **Diagrama 06:** Diagrama de actividades con objetos del caso de uso 03.
      <br>
      **Fuente:** Elaboración propia.
      </center>
      
      <center>
      
      Caso de uso 04: Gestionar Repertorio de Canciones
      
      ![width=500](../media/actividades-4.png)

      **Diagrama 07:** Diagrama de actividades con objetos del caso de uso 04.
      <br>
      **Fuente:** Elaboración propia.
      </center>
      
      <center>
      
      Caso de uso 05: Monitorear Progreso de Estudiantes
      
      ![width=500](../media/actividades-5.png)

      **Diagrama 08:** Diagrama de actividades con objetos del caso de uso 05.
      <br>
      **Fuente:** Elaboración propia.
      </center>
      
      <center>
      
      Caso de uso 06: Generar Reporte de Desempeño
      
      ![width=500](../media/actividades-6.png)

      **Diagrama 09:** Diagrama de actividades con objetos del caso de uso 06.
      <br>
      **Fuente:** Elaboración propia.
      </center>
      
      <center>
      
      Caso de uso 07: Gestionar Credenciales de Docente
      
      ![width=500](../media/actividades-7.png)

      **Diagrama 10:** Diagrama de actividades con objetos del caso de uso 07.
      <br>
      **Fuente:** Elaboración propia.
      </center>
   
      3) ##### Diagrama Secuencia {#diagrama-secuencia}

      <center>
      
      Diagrama de secuencia CU - 01: Gestionar Autentiación y Credenciales de Usuario
      
      ![width=500](../media/secuencia-1.png)

      **Diagrama 11:**  Diagrama de secuencia del caso de uso 01.
      <br>
      **Fuente:** Elaboración propia.
      </center>

      <center>
      
      Diagrama de secuencia CU - 02: Gestionar Autentiación y Credenciales de Usuario
      
      ![width=500](../media/secuencia-2.png)

      **Diagrama 12:**  Diagrama de secuencia del caso de uso 02.
      <br>
      **Fuente:** Elaboración propia.
      </center>

      <center>
      
      Diagrama de secuencia CU - 03: Gestionar Autentiación y Credenciales de Usuario
      
      ![width=500](../media/secuencia-3.png)

      **Diagrama 13:**  Diagrama de secuencia del caso de uso 03.
      <br>
      **Fuente:** Elaboración propia.
      </center>

      <center>
      
      Diagrama de secuencia CU - 04: Gestionar Autentiación y Credenciales de Usuario
      
      ![width=500](../media/secuencia-4.png)

      **Diagrama 14:**  Diagrama de secuencia del caso de uso 04.
      <br>
      **Fuente:** Elaboración propia.
      </center>

      <center>
      
      Diagrama de secuencia CU - 05: Gestionar Autentiación y Credenciales de Usuario
      
      ![width=500](../media/secuencia-5.png)

      **Diagrama 15:**  Diagrama de secuencia del caso de uso 05.
      <br>
      **Fuente:** Elaboración propia.
      </center>

      <center>
      
      Diagrama de secuencia CU - 06: Gestionar Autentiación y Credenciales de Usuario
      
      ![width=500](../media/secuencia-6.png)

      **Diagrama 16:**  Diagrama de secuencia del caso de uso 06.
      <br>
      **Fuente:** Elaboración propia.
      </center>

      <center>
      
      Diagrama de secuencia CU - 07: Gestionar Autentiación y Credenciales de Usuario
      
      ![width=500](../media/secuencia-7.png)

      **Diagrama 17:**  Diagrama de secuencia del caso de uso 07.
      <br>
      **Fuente:** Elaboración propia.
      </center>
      
      4) ##### Diagrama de Clases ([Link a Diagrama de Clases](https://uml.planttext.com/plantuml/svg/hLPDZzCm4BrNwd_mZQoWVm0jQAEqY4gbgT9TBeY3Dx629SUk_047uB_ZxyQfqxA87khwsPvvRpmpxeEGa4iraELYkNW5thaF-5IlDxlw6EPciILG2F0a5EIOWP_B1G2lCPLWstdC8a9oJ7jGCSvHWXpqwH-CTsEiOThjxxFnDMiHbUYMyJqRdZaIOwWy8K9mnnBm4P-ODfaSLGFY3XpvBOaQw4rD_yUj1jTGeaSy8F01jT_W7hPum5ftucpRbOh0bAK6FCV9fiZQ1p0Y5QGITx1p0aLwGntksPRsMXBBqAeuqiGOJIXeUmPB8kMnD09IaKa-32Sci6JSei-C4L2s4d-7errVle8ZQXNIzk2UIIWItn-nqCSn98dtY8umf_OwnKde3efA1UCc0squP-6wqz1uMkTggUhzOrFlodNTREPhfc9KSaO8ubw12G2Z3HAAIB1ZFQQ5PzVQyda3_FJaQ-SkUumfMMHM6jJhs738Yr2poesPlPiEwpPG6DdOU9batNNc9bEusLRO38NwA-EY5BYdUf-z6-_9JQBCrgPaJYGsNSfO5pcbfSxXFfhsnGpjC4_4vuHducUH2hRfSPTB_kl1y5oAK2cj6_yYvddHMRrEmGkekvZSIC1PVsiaeJubvhdUql94CHV8vaXorxxzP4vyHZoMTZOlVQlxLqqsQOlmu7HkV5bbH7xNEMIKb7EvwVWU61-7AhtGSzTfDhkosjPxtNBSSmtkL-_3pr4J2kL__skr0l65ID3GCKCyLjgGBUQtDb3BXPrOr5MNnhLe_MffInuogwDk70fW0aT38sn6LDfLpzgE6N6ZAp36u-izwLv1Ltx11o6p51-GonwGB5_KMM8tjpWAmsL6cmtnmdBfDh4mjoKmc5kF_9UB1qGx-s_m3m00))  {#diagrama-de-clases-(link-a-diagrama-de-clases)}

         El diagrama de clases representa la estructura lógica del sistema PianoRise, una plataforma educativa orientada al aprendizaje del piano. El modelo define entidades clave como Usuario, Alumno, Docente, Aula, Cancion e Historial, así como sus relaciones e interacciones mediante controladores específicos. Los alumnos y docentes se autentican como usuarios del sistema y se agrupan en aulas virtuales donde se asignan canciones para su práctica. A través de la clase Historial, se registra el desempeño del alumno en cada canción asignada, incluyendo su puntuación, errores y fecha. El sistema cuenta con controladores que gestionan operaciones como la creación de aulas, asignación de canciones, registro de usuarios y seguimiento del aprendizaje, permitiendo una administración eficiente y escalable del proceso educativo.
<center>

![width=500](../media/DiagramaClases.png)


**Diagrama 18:** El Diagrama de Clases muestra la interacción entre usuarios, administradores, empresas, egresados, ofertas laborales y postulaciones.
</center>

---

### **Conclusiones**

   PianoRise representa una solución innovadora y accesible para la enseñanza del piano, enfocada en estudiantes principiantes. Al integrar un sistema de retroalimentación inmediata mediante reconocimiento de audio, permite a los estudiantes practicar de manera autónoma, lo que mejora la motivación y acelera el proceso de aprendizaje. Este enfoque interactivo supera las limitaciones de los métodos tradicionales de enseñanza, que no brindan la oportunidad de recibir correcciones instantáneas mientras se toca.

   La plataforma también se distingue por su capacidad para facilitar el monitoreo del progreso de los estudiantes. Los docentes podrán visualizar de manera clara el desempeño de cada alumno, las canciones completadas y las puntuaciones obtenidas, lo que optimiza el seguimiento individualizado. Esta funcionalidad ofrece una mejora significativa en la gestión educativa, ya que permite a los docentes tomar decisiones más informadas sobre el avance de sus estudiantes.

   La accesibilidad es otro punto clave del proyecto. PianoRise, al ser una aplicación web, está disponible a través de navegadores modernos, lo que permite a los estudiantes practicar desde cualquier lugar y en cualquier momento, sin necesidad de instalaciones adicionales. Esta flexibilidad facilita el aprendizaje autónomo, permitiendo a los estudiantes practicar según su propio ritmo y disponibilidad.

   En términos de seguridad y privacidad, PianoRise debe implementar medidas robustas para proteger los datos personales y de rendimiento de los usuarios. Esto garantizará la confianza de los estudiantes y docentes en el uso de la plataforma. Además, el monitoreo del rendimiento y la recolección de retroalimentación son esenciales para continuar mejorando la experiencia del usuario y adaptarse a las necesidades cambiantes de los estudiantes.

   En conclusión, PianoRise ofrece una plataforma eficiente y accesible para el aprendizaje del piano, especialmente diseñada para estudiantes principiantes, con un enfoque en la retroalimentación inmediata y el seguimiento personalizado del progreso. A medida que el sistema evoluciona, tiene un gran potencial para crecer y adaptarse a nuevas necesidades, consolidándose como una herramienta valiosa para la educación musical digital.

### **Recomendaciones**

   - <strong>Refinar las funcionalidades de gestión de aulas:</strong> La gestión de aulas es crucial para los docentes, por lo que se recomienda continuar refinando la experiencia del administrador y el docente en la plataforma, incluyendo la posibilidad de asignar ejercicios y hacer un seguimiento detallado del progreso de los estudiantes.

   - <strong>Optimización del procesamiento de audio:</strong> A medida que el sistema se vaya desarrollando, se recomienda seguir optimizando las bibliotecas y tecnologías utilizadas para el procesamiento del audio, como Librosa, para mejorar la precisión y reducir posibles retrasos en la retroalimentación.

   - <strong>Desarrollo de más contenido de aprendizaje:</strong> En la fase inicial, el repertorio de canciones es básico, pero se recomienda agregar progresivamente más canciones y ejercicios que permitan a los estudiantes avanzar en su aprendizaje de forma más fluida y adaptada a sus necesidades.

   - <strong>Análisis de usuarios y retroalimentación:</strong> Es recomendable que el sistema implemente un sistema de recolección de retroalimentación de los usuarios (tanto docentes como estudiantes) para obtener insights sobre la experiencia de uso y mejorar la plataforma en iteraciones futuras.
   Pruebas rigurosas: Antes de la implementación completa, es crucial realizar pruebas rigurosas, especialmente en el procesamiento de audio y la precisión en la detección de notas. Estas pruebas deben garantizar que el sistema pueda manejar una variedad de entornos y condiciones de usuario.

   - <strong>Preparación para la expansión:</strong> A pesar de las limitaciones actuales, la plataforma debe estar diseñada de tal manera que en el futuro se pueda integrar con otras herramientas educativas (por ejemplo, otros instrumentos musicales o aplicaciones de enseñanza complementarias) sin una reestructuración completa del sistema.