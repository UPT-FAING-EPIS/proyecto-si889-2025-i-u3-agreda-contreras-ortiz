<center>

[comment]: <img src="./media/media/image1.png" style="width:1.088in;height:1.46256in" alt="escudo.png" />

![./media/media/image1.png](../media/logo-upt.png)

**UNIVERSIDAD PRIVADA DE TACNA**

**FACULTAD DE INGENIERIA**

**Escuela Profesional de Ingeniería de Sistemas**

**Plataforma Web Interactiva para el Aprendizaje Autónomo del Piano con Reconocimiento de Notas Musicales \- PianoRise**

Curso: Patrones de Software

Docente: *Mag. Patrick Cuadros Quiroga*

Integrantes:

***Agreda Ramirez, Jesús Eduardo 	  (2021069823)***  
***Contreras Lipa, Alvaro Javier    (2021070020)***  
***Ortiz Fernandez, Ximena Andrea 	(2021071080)***

**Tacna – Perú**

***2025***


---
</center>
















***Plataforma Web Interactiva para el Aprendizaje Autónomo del Piano con Reconocimiento de Notas en Tiempo Real \- PianoRise***

**Documento de Visión**

**Versión *1.0***

#

|CONTROL DE VERSIONES||||||
| :-: | :- | :- | :- | :- | :- |
|Versión|Hecha por|Revisada por|Aprobada por|Fecha|Motivo|
|1\.0|xxx|xxx|xxx|xx/xx/xxxx|xxx|
---


## **ÍNDICE GENERAL**

- [1. Introducción](#introducción)  
  - [1.1 Propósito](#propósito)  
  - [1.2 Alcance](#alcance)  
  - [1.3 Definiciones, Siglas y Abreviaturas](#definiciones-siglas-y-abreviaturas)  
  - [1.4 Referencias](#referencias)  
  - [1.5 Visión General](#visión-general)  

- [2. Posicionamiento](#posicionamiento)  
  - [2.1 Oportunidad de negocio](#oportunidad-de-negocio)  
  - [2.2 Definición del problema](#definición-del-problema)  

- [3. Descripción de los interesados y usuarios](#descripción-de-los-interesados-y-usuarios)  
  - [3.1 Resumen de los interesados](#resumen-de-los-interesados)  
  - [3.2 Resumen de los usuarios](#resumen-de-los-usuarios)  
  - [3.3 Entorno de usuario](#entorno-de-usuario)  
  - [3.4 Perfiles de los interesados](#perfiles-de-los-interesados)  
  - [3.5 Perfiles de los usuarios](#perfiles-de-los-usuarios)  
  - [3.6 Necesidades de los interesados y usuarios](#necesidades-de-los-interesados-y-usuarios)  

- [4. Vista General del Producto](#vista-general-del-producto)  
  - [4.1 Perspectiva del producto](#perspectiva-del-producto)  
  - [4.2 Resumen de capacidades](#resumen-de-capacidades)  
  - [4.3 Suposiciones y dependencias](#suposiciones-y-dependencias)  
  - [4.4 Costos y precios](#costos-y-precios)  
  - [4.5 Licenciamiento e instalación](#licenciamiento-e-instalación)  

- [5. Características del producto](#características-del-producto)  

- [6. Restricciones](#restricciones)  

- [7. Rangos de calidad](#rangos-de-calidad)  

- [8. Precedencia y Prioridad](#precedencia-y-prioridad)  

- [9. Otros requerimientos del producto](#otros-requerimientos-del-producto)  
  - [b) Estándares legales](#estándares-legales)  
  - [c) Estándares de comunicación](#estándares-de-comunicación)  
  - [d) Estándares de cumplimiento de la plataforma](#estándares-de-cumplimiento-de-la-plataforma)  
  - [e) Estándares de calidad y seguridad](#estándares-de-calidad-y-seguridad)  

- [CONCLUSIONES](#conclusiones)  
- [RECOMENDACIONES](#recomendaciones)  
- [BIBLIOGRAFÍA](#bibliografía)  
- [WEBGRAFÍA](#webgrafía)

---

## Informe de Visión

1. #### Introducción {#introducción}

    El aprendizaje del piano representa un reto común para muchos principiantes, especialmente cuando no cuentan con una guía adecuada, retroalimentación inmediata o acceso a recursos educativos estructurados. A pesar del creciente interés por desarrollar habilidades musicales de forma autodidacta, las herramientas tradicionales como libros, tutoriales en video o aplicaciones básicas no siempre responden a las necesidades prácticas de quienes están dando sus primeros pasos en el mundo musical.
En respuesta a esta problemática, nace PianoRise, una plataforma web interactiva diseñada para facilitar el aprendizaje autónomo del piano a través de una experiencia didáctica, intuitiva y progresiva. El proyecto combina tecnologías de reconocimiento de audio, visualización de notas musicales, y un sistema de avance por fracciones que permite a los estudiantes seguir su progreso de forma clara y motivadora.
Este documento de visión tiene como finalidad presentar los objetivos generales del proyecto, identificar a los actores clave, definir el alcance y describir las características fundamentales de la solución propuesta. Asimismo, se detallan las necesidades del mercado, las oportunidades de negocio, las restricciones técnicas y los factores críticos que condicionarán el desarrollo del sistema.
Con PianoRise, se busca democratizar el acceso a la enseñanza del piano, brindando una alternativa moderna y accesible que impulse el aprendizaje musical en diversos contextos, especialmente en instituciones educativas como la Institución Educativa Privada Verdad y Vida – Veritas et Vita, cliente principal de este proyecto.




    1. ####  **Propósito**{#propósito}

        El objetivo principal de PianoRise es ofrecer una solución digital innovadora que facilite el aprendizaje del piano tanto de forma autónoma como en entornos educativos presenciales. Utilizando tecnologías interactivas como el reconocimiento de audio y la retroalimentación continua, la plataforma optimiza la experiencia del usuario y fomenta un aprendizaje progresivo y motivador.
PianoRise está diseñado para apoyar a estudiantes que se inician en el mundo musical, proporcionando un entorno práctico, accesible y didáctico, sin requerir conocimientos previos en teoría musical. Su enfoque combina la autoformación con el acompañamiento en clase, permitiendo a los alumnos avanzar a su propio ritmo mientras reciben guía y seguimiento de sus docentes.
Los propósitos específicos del sistema son:
Brindar una herramienta intuitiva y accesible para el aprendizaje del piano en contextos de educación formal y autoformación.
Utilizar reconocimiento de audio para detectar las notas tocadas por el usuario y compararlas con las notas esperadas.
Implementar un sistema de avance gradual basado en la precisión de ejecución, mediante un esquema de progreso fraccionado.
Presentar ejercicios interactivos y canciones sencillas que fomenten la motivación y la práctica constante.
Apoyar a los docentes en la supervisión del progreso de los alumnos, facilitando el seguimiento individualizado del aprendizaje musical.sencillas que motiven al usuario en su proceso de aprendizaje musical.
Con este enfoque, PianoRise busca modernizar la enseñanza del piano en instituciones educativas como la Institución Educativa Privada Verdad y Vida – Veritas et Vita, ofreciendo una experiencia pedagógica más dinámica, efectiva y adaptada a las necesidades del alumnado.


      2. ##### **Alcance**{#alcance}

         El presente sistema tiene como alcance el desarrollo e implementación de la plataforma web PianoRise, orientada al aprendizaje autónomo del piano para estudiantes de nivel escolar. El sistema estará enfocado en ofrecer funcionalidades prácticas que permitan la interacción directa del estudiante con ejercicios musicales y retroalimentación inmediata, así como el seguimiento del progreso por parte de los docentes. A continuación se detallan las inclusiones y exclusiones del sistema.


            ##### Inclusiones

            **Desarrollo de una Plataforma Web:**  
            - Creación de una plataforma accesible desde navegadores modernos (Chrome, Firefox, Edge), con una interfaz gráfica intuitiva y moderna.    <br>
            **Funcionalidades Clave:**  
            - **Gestión de usuarios:**
                - Permitir el registro seguro de usuarios (estudiantes y docentes) mediante la creación de credenciales de acceso.
                - Implementar el inicio de sesión y cierre de sesión de forma segura.
                - Permitir la edición de información personal por parte de los usuarios, y la gestión de cuentas docentes por parte del administrador.

            - **Reconocimiento de notas en tiempo real:**
                - Capturar y procesar el audio a través del micrófono del usuario.
                - Detectar las notas musicales tocadas y compararlas con las notas esperadas en cada ejercicio o canción.
                - Proporcionar retroalimentación sobre la precisión de la ejecución.
 
            - **Repertorio de canciones:**
                - Gestionar un repertorio general de canciones sencillas, administrado por el administrador del sistema.
                - Permitir que los docentes seleccionen las canciones del repertorio general que serán asignadas a su aula.
                - Permitir a los estudiantes seleccionar canciones asignadas a su aula para practicarlas.   
            - **Retroalimentación visual y auditiva:**
                - Mostrar en pantalla indicaciones visuales que resalten las notas tocadas correctamente e indiquen los errores cometidos.
                - Emitir señales auditivas de confirmación para notas acertadas y alertas para notas incorrectas.   
            - **Gestión del aula:**
                - Permitir a los docentes crear aulas dentro del sistema para organizar a sus estudiantes.
                - Asignar un repertorio específico de canciones a cada aula durante su creación o edición.
                - Generar códigos únicos de acceso para que los estudiantes se unan a las aulas correspondientes.
            - **Almacenamiento de progreso de los estudiantes:**
                - Registrar únicamente las canciones que los estudiantes completen satisfactoriamente
                - Almacenar la cantidad de errores cometidos en cada canción finalizada.  
            - **Monitoreo de progreso para docentes:**
                - Permitir a los docentes visualizar el avance de sus estudiantes, identificando canciones completadas y no completadas.
                - Mostrar el puntaje y los errores obtenidos por cada estudiante en cada canción.
            - **Generación de reportes de desempeño**
                - Generar reportes que incluyan métricas y gráficos sobre el desempeño general del aula.
                - Permitir la descarga o visualización de reportes para seguimiento académico. 
           <br>

            **Soporte Tecnológico:**  
            - El sistema utilizará bibliotecas especializadas para el procesamiento de audio en tiempo real (como Librosa o similares) para la detección de notas musicales.

            ##### Exclusiones

            - **Compatibilidad móvil:** El sistema será exclusivo para uso en plataformas web y no incluirá versiones nativas ni aplicaciones para dispositivos móviles.  
            - **Instrumentos adicionales:** PianoRise estará enfocado únicamente en la enseñanza del piano. No se contemplará la inclusión de otros instrumentos musicales.  
            - **Evaluación avanzada:** No se integrarán características avanzadas como la evaluación de velocidad, ritmo o teoría musical compleja.  
            - **Integración con plataformas externas:** El sistema no contará con integraciones a plataformas de música, APIs educativas o herramientas de aprendizaje externas.


      3. ##### **Definiciones, Siglas y Abreviaturas**{#definiciones-siglas-y-abreviaturas}


          - **PianoRise:** Nombre de la plataforma, simboliza el progreso y crecimiento en el aprendizaje del piano.  



      4. ##### **Visión General**{#visión-general}
          PianoRise es una plataforma web diseñada para fortalecer el aprendizaje del piano en estudiantes de nivel escolar dentro del entorno educativo de la Institución Educativa Verdad y Vida – Veritas et Vita. El sistema ofrece una experiencia práctica, interactiva y accesible, complementando el trabajo del docente y motivando a los estudiantes a desarrollar sus habilidades musicales.
La plataforma permite a los alumnos practicar canciones asignadas desde su navegador, con retroalimentación inmediata mediante el reconocimiento de notas musicales captadas a través del micrófono. Solo se registra el progreso cuando el estudiante completa satisfactoriamente una canción, almacenando el puntaje y los errores cometidos.
PianoRise proporciona herramientas para que los docentes gestionen aulas virtuales, asignen repertorios personalizados seleccionados de un repositorio general, y supervisen el avance individual de sus estudiantes mediante métricas y reportes de desempeño. Los estudiantes se integran a las aulas mediante códigos únicos generados automáticamente.
Al digitalizar el proceso de enseñanza musical, PianoRise elimina la necesidad de softwares costosos o equipos especializados, promoviendo una educación artística moderna, inclusiva y alineada con las capacidades tecnológicas del entorno escolar.


---


2. #### **Posicionamiento**{#posicionamiento}

      1. ##### **Oportunidad de negocio**{#oportunidad-de-negocio}
          - **Demanda creciente de soluciones tecnológicas educativas en instituciones escolares.**  
          En los últimos años, el uso de plataformas digitales en el aula ha crecido exponencialmente, impulsado por la necesidad de herramientas que complementen el aprendizaje presencial con recursos interactivos. En el ámbito musical, esta tendencia se refleja en la búsqueda de soluciones que permitan la práctica autónoma, personalizada y accesible para estudiantes desde etapas tempranas de formación.

          - **Aprovechamiento de los recursos existentes en las instituciones educativas.**  
          PianoRise puede ser implementado sin necesidad de equipos especializados, aprovechando computadoras con acceso a internet y micrófono, facilitando así su integración en aulas que ya cuentan con infraestructura tecnológica básica.

          - **Contribución a la formación artística en entornos escolares.**  
          El sistema no solo fortalece el área musical, sino que también contribuye a desarrollar competencias como la disciplina, la creatividad y la concentración, elementos clave en la educación integral del estudiante.

      2. ##### **Definición del problema**{#definición-del-problema}


          Actualmente, en el entorno de enseñanza musical, los procesos de gestión y seguimiento de las clases de piano presentan importantes limitaciones debido a la falta de herramientas tecnológicas especializadas. El manejo de aulas, el seguimiento del progreso de los estudiantes y la organización del repertorio musical se realizan de manera manual o utilizando plataformas no adaptadas a las necesidades específicas de la formación instrumental. Esta situación genera ineficiencias, dificulta la evaluación objetiva del desempeño y limita el crecimiento académico de los estudiantes. Los principales problemas identificados son.

          - **Procesos manuales e ineficientes:**  
            La creación y gestión de clases, así como el seguimiento del progreso de los alumnos, se realiza de forma manual o con herramientas genéricas, lo que provoca demoras, errores y sobrecarga de trabajo para los docentes.

          - **Falta de seguimiento estructurado del desempeño estudiantil:**  
            Actualmente, no se dispone de un sistema que registre de manera organizada las canciones practicadas, los errores cometidos y los logros alcanzados por los estudiantes, dificultando así una evaluación continua y objetiva.

          - **Ausencia de un módulo especializado para repertorios musicales:**  
            No existe un sistema que permita seleccionar y administrar repertorios adaptados al nivel de cada aula, limitando la personalización de la enseñanza y el desarrollo musical de los estudiantes.

          - **Gestión desorganizada de información:**  
            El registro de alumnos, aulas y progreso de aprendizaje se realiza de forma dispersa, aumentando el riesgo de pérdida de datos importantes y dificultando la obtención de reportes consolidados.

          - **Limitada visibilidad para los docentes sobre el avance de sus estudiantes:**  
             Los docentes carecen de herramientas que les permitan monitorear de forma clara y detallada el desempeño de cada alumno, lo que dificulta identificar áreas de mejora y establecer estrategias de refuerzo.

          - **Falta de mecanismos para generar reportes de desempeño:**  
            No se dispone de un sistema automatizado que permita generar reportes gráficos o métricos sobre el progreso individual y grupal, lo que restringe la capacidad de análisis y retroalimentación educativa.

---

3. #### **Descripción de los interesados y usuarios**{#descripción-de-los-interesados-y-usuarios}

      1. ##### **Resumen de los interesados**{#resumen-de-los-interesados}

          ##### Estudiantes de Piano:
          - Estudiantes interesados en aprender a tocar piano, especialmente principiantes que buscan una alternativa digital para estudiar de forma autodidacta y práctica.
          - Evaluar la facilidad de uso, la precisión del reconocimiento de notas, la calidad de los ejercicios propuestos y la utilidad del sistema de progreso para el aprendizaje individual.

          ##### Docentes o Instructores de Música:
          - Profesores que podrían recomendar la aplicación a sus estudiantes como herramienta de práctica complementaria.
          - Asegurar que la aplicación refuerce correctamente los conceptos básicos del piano y proporcione retroalimentación útil para el estudiante.

      2. ##### **Resumen de los usuarios**{#resumen-de-los-usuarios}

          ##### Administrador: 
          - Tiene acceso completo al sistema. Puede gestionar el repertorio de canciones, modificar los parámetros de reconocimiento de notas, monitorear el progreso de los estudiantes y generar reportes de desempeño. Su rol es supervisar y optimizar la plataforma para mejorar la experiencia de aprendizaje.

          ##### Docente: 
          - Usuario con permisos intermedios. Puede crear aulas virtuales, registrar estudiantes en ellas, asignar canciones o ejercicios a sus grupos, y visualizar el rendimiento individual y colectivo de los alumnos. Su objetivo es acompañar pedagógicamente el proceso de aprendizaje, personalizando los contenidos según el avance de sus estudiantes.

          ##### Estudiante: 
          - Usuario principal de la plataforma. Puede acceder a las funcionalidades de aprendizaje, seleccionar canciones del repertorio, ejecutar ejercicios interactivos, recibir retroalimentación inmediata y visualizar su progreso. También puede utilizar la práctica libre y retomar su avance en cualquier momento.

      3. ##### **Entorno de usuario**{#entorno-de-usuario}

          ##### Plataforma Web Interactiva:
          - Los usuarios acceden a PianoRise a través de navegadores en computadoras, sin necesidad de instalación. La interfaz está diseñada para ser clara e intuitiva, permitiendo al estudiante concentrarse en su práctica sin distracciones.

          ##### Reconocimiento de Audio:
          - La aplicación detecta las notas que el usuario toca mediante el micrófono del dispositivo y las compara con las notas esperadas para dar retroalimentación.

          ##### Requisitos Técnicos:
          - Acceso a una computadora con micrófono funcional.
          - Navegador web actualizado.
          - Conexión a internet para acceder a los contenidos.

      4. ##### **Perfiles de los interesados**{#perfiles-de-los-interesados}

          ##### Institución Educativa Verdad y Vida – Veritas et Vita: 
          - Entidad promotora del proyecto. Su interés principal es implementar una herramienta tecnológica que complemente la enseñanza musical y potencie el desarrollo artístico de los estudiantes. Busca mejorar la calidad educativa mediante la incorporación de plataformas digitales efectivas y accesibles.

          ##### Docentes de Música  
          - Profesionales responsables de la enseñanza del piano dentro del aula. Están interesados en contar con una plataforma que les permita asignar ejercicios, hacer seguimiento del rendimiento de los estudiantes y personalizar la experiencia de aprendizaje según las necesidades individuales de cada alumno.

          ##### Equipo de desarrollo:
          - Encargados del diseño, programación, prueba y mantenimiento de la plataforma PianoRise. Su interés radica en comprender claramente los requerimientos funcionales y no funcionales para asegurar el cumplimiento de los objetivos técnicos y pedagógicos del proyecto.

      5. ##### **Perfiles de los usuarios**{#perfiles-de-los-usuarios}

          ##### Estudiantes: 
          - Usuarios principales de la plataforma. Son alumnos de nivel escolar que utilizan PianoRise para aprender piano de forma interactiva y autónoma. Buscan una herramienta fácil de usar, motivadora y con retroalimentación inmediata. Sus actividades incluyen realizar ejercicios, tocar canciones guiadas y revisar su progreso.

          ##### Docentes: 
          - Usuarios con funciones de gestión educativa dentro del sistema. Pueden crear aulas, registrar estudiantes, asignar repertorios y revisar el avance de sus alumnos. Requieren funcionalidades que les permitan intervenir en el proceso de enseñanza y adaptar el contenido al nivel de cada grupo.

          ##### Administradores: 
          - Usuarios con acceso completo al sistema. Su perfil incluye la configuración técnica general de la plataforma, la administración del contenido (como el repertorio de canciones) y el soporte a docentes y estudiantes. También pueden generar reportes y aplicar mejoras continuas al sistema.

      6. ##### **Necesidades de los interesados y usuarios**{#necesidades-de-los-interesados-y-usuarios}

          ##### Institución Educativa Verdad y Vida – Veritas et Vita:
          - Contar con una herramienta tecnológica que complemente la enseñanza del piano y se integre fácilmente en el entorno escolar.
          - Asegurar que la plataforma sea accesible, funcional y útil para estudiantes y docentes, sin requerir equipos o licencias costosas.
          - Promover el desarrollo de habilidades musicales como parte de la formación integral de los alumnos.
          - Obtener reportes o evidencias del uso y avance de los estudiantes para evaluar el impacto pedagógico del sistema.

          ##### Docentes de música:
          - Disponer de una plataforma que les permita organizar a los estudiantes por aulas virtuales.
          - Asignar ejercicios o canciones adaptadas al nivel de cada grupo o alumno.
          - Hacer seguimiento del progreso de los estudiantes de forma clara y rápida.
          - Reducir el tiempo destinado a la corrección manual, confiando en la retroalimentación automatizada del sistema.
          - Acceder a un repertorio variado y didáctico que respalde su plan de clases.

          ##### Estudiantes (usuarios finales):
          - Practicar canciones y ejercicios musicales con ayuda visual y auditiva.
          - Recibir retroalimentación inmediata sobre sus errores y aciertos.
          - Ver su progreso de forma clara para mantenerse motivados.
          - Poder practicar desde el aula o el hogar sin necesidad de instalaciones complicadas ni equipos profesionales.

          ##### Administradores del sistema:
          - Supervisar el funcionamiento general del sistema.
          - Gestionar el contenido, usuarios y configuraciones.
          - Detectar fallos técnicos y brindar soporte a docentes y estudiantes.
          - Velar por la integridad y actualización del sistema según el crecimiento del proyecto.

---

4. #### **Vista General del Producto**{#vista-general-del-producto}

    1. ##### **Perspectiva del producto**{#perspectiva-del-producto}


        **PianoRise** será una plataforma web interactiva orientada a facilitar el aprendizaje del piano para principiantes. Su diseño se centrará en una experiencia práctica y progresiva, combinando tecnología de reconocimiento de audio con una interfaz amigable que guíe al usuario en cada paso. La plataforma permitirá a los estudiantes visualizar en pantalla las notas a ejecutar, recibir retroalimentación inmediata sobre su interpretación y monitorear su progreso a través de un sistema de avance fraccionado.

        A través de una metodología didáctica y práctica, PianoRise busca hacer que el estudio del piano sea más accesible, flexible y motivador, sin necesidad de clases presenciales o conocimientos previos. El producto está dirigido tanto a estudiantes autodidactas como a docentes que deseen usarlo como recurso complementario.


    2. ##### **Resumen de capacidades**{#resumen-de-capacidades}

        PianoRise proporcionará un conjunto de funcionalidades esenciales que permitirán a los usuarios interactuar de manera eficiente con la plataforma y cumplir los objetivos educativos planteados. A continuación se detallan las capacidades principales del sistema:

        - **Gestión de usuarios y autenticación:**
          <br>
          El sistema almacenará el avance de los estudiantes únicamente cuando completen satisfactoriamente una canción, registrando además la cantidad de errores cometidos durante la ejecución.
        - **Almacenamiento del progreso:**
          <br>
          El sistema almacenará el avance de los estudiantes únicamente cuando completen satisfactoriamente una canción, registrando además la cantidad de errores cometidos durante la ejecución.
        - **Reconocimiento de notas musicales:**
          <br>
          PianoRise capturará el audio en tiempo real a través del micrófono, identificando las notas tocadas por el estudiante y comparándolas con las notas esperadas en cada ejercicio.
        - **Selección y práctica de canciones:**
          <br>
          Los estudiantes podrán seleccionar canciones del repertorio personalizado de su aula para practicarlas, recibiendo retroalimentación inmediata sobre su ejecución.
        - **Gestión del repertorio de canciones:**  
          <br>
          Los administradores del sistema podrán agregar nuevas canciones, editar información de las existentes o deshabilitar canciones del repositorio general utilizado para las aulas.
        - **Monitoreo del progreso estudiantil:**
          <br>
          Los docentes tendrán la capacidad de visualizar el estado de las canciones completadas y no completadas por sus estudiantes, junto con la puntuación obtenida en cada actividad.
        - **Generación de reportes de desempeño:**
          <br>
          El sistema permitirá generar reportes con métricas y gráficos que reflejen el desempeño general de los estudiantes de un aula, apoyando el análisis pedagógico del proceso de aprendizaje.
        - **Gestión de aulas:**
          <br>
          Los docentes podrán crear aulas virtuales, organizar a sus estudiantes, seleccionar canciones específicas para cada aula, y administrar códigos de ingreso automáticos para su asignación.
        - **Gestión de docentes:**
          <br>
          Los administradores del sistema podrán registrar nuevos docentes, definir sus credenciales de acceso, editar sus datos o deshabilitar usuarios cuando sea necesario.


    3. ##### **Suposiciones y dependencias**{#suposiciones-y-dependencias}
      - Se asume que el desarrollo de la plataforma se realizará en un plazo ajustado, lo que puede limitar la inclusión de funciones avanzadas o ajustes personalizados según pruebas de usuario.
      - La precisión del reconocimiento dependerá de la calidad del micrófono del dispositivo y del entorno acústico, lo cual representa un reto para garantizar una experiencia consistente.
      - La selección de canciones y ejercicios dependerá del acceso a material libre de derechos o con licencias adecuadas para uso educativo.
      - La correcta ejecución del reconocimiento de audio y los componentes gráficos interactivos depende del soporte de los navegadores utilizados. 

    4. ##### **Costos y precios**{#costos-y-precios}
          ### Costos totales del desarrollo del sistema

        | Categoría de Costo        | Costo Total (S/.) |
        |---------------------------|-------------------|
        | Costos Generales          | 0                 |
        | Costos Operativos         | 0                 |
        | Costos del Ambiente (5 años) | 20,400          |
        | Costos de Personal        | 13,560            |
        | **Total General del Proyecto** | **S/ 33,960**   |

        **Tabla 01.** Tabla de los costos totales para el desarrollo de la plataforma PianoRise.  
        *Fuente: Elaboración propia.*



    5. ##### **Licenciamiento e instalación**{#licenciamiento-e-instalación}

      - PianoRise estará disponible como una aplicación web accesible a través de cualquier navegador moderno en computadoras.
      - No requerirá instalación, permitiendo su uso inmediato desde la web oficial.
      - La plataforma se distribuirá bajo una licencia gratuita para los usuarios finales, con todos los derechos reservados al equipo desarrollador.

---

5. #### **Características del producto**{#características-del-producto}

      # Características principales de PianoRise

      El sistema PianoRise presenta las siguientes características principales, diseñadas para cumplir los objetivos pedagógicos y funcionales establecidos:
      
      **Acceso personalizado**:
      - Permite a los usuarios (administradores, docentes y estudiantes) registrarse, iniciar sesión de manera segura y gestionar su información personal.
      
      **Interfaz intuitiva y amigable**:
      - La plataforma contará con un diseño sencillo, adaptado a estudiantes de nivel escolar y docentes, permitiendo una navegación fluida y sin complicaciones.
      
      **Reconocimiento de notas musicales en tiempo real**:
      - Utiliza el micrófono del dispositivo para capturar el audio del piano y procesarlo, identificando las notas tocadas y comparándolas con las notas correctas del ejercicio o canción.
      
      **Retroalimentación inmediata**:
      - Al momento de tocar, el estudiante recibirá información visual y sonora sobre la precisión de sus interpretaciones, ayudándole a corregir errores.
      
      **Selección de canciones personalizadas**:
      - Cada estudiante podrá practicar canciones seleccionadas previamente por su docente desde un repertorio configurado para su aula.
      
      **Registro de progreso**:
      - La plataforma almacenará el historial de canciones completadas, errores cometidos y puntajes obtenidos, permitiendo el seguimiento individual del avance de cada estudiante.
      
      **Gestión de aulas y estudiantes**:
      - Los docentes podrán crear aulas, asignar estudiantes mediante códigos únicos, y gestionar el contenido de aprendizaje de forma personalizada.
      
      **Administración del repertorio**:
      - El administrador podrá agregar, editar o deshabilitar canciones disponibles para ser asignadas en las aulas.
      
      **Reportes de desempeño**:
      - Se generarán reportes gráficos y métricos que reflejen el progreso de los estudiantes a nivel individual y de aula, facilitando la evaluación continua.


---

6. #### **Restricciones**{#restricciones}

      - Compatibilidad web: PianoRise funcionará exclusivamente como una aplicación web, dependiendo del rendimiento del navegador y la calidad del micrófono utilizado. No se desarrollará soporte nativo para dispositivos móviles o sistemas operativos específicos.
      - Procesamiento de audio: La detección de notas se basará en el análisis de sonido, utilizando la señal captada por el micrófono del usuario. El sistema no incluirá corrección de ruido avanzada ni ajustes automáticos para instrumentos desafinados.
      - Alcance del contenido: En su versión inicial, PianoRise ofrecerá únicamente canciones y ejercicios básicos para principiantes. No se incluirán niveles avanzados ni repertorio extenso en esta fase.
      - Tiempo y funcionalidades: El desarrollo del software se limitará a un período determinado, priorizando funciones esenciales. No se implementarán características adicionales fuera del alcance inicial del proyecto.
      - Uso de bibliotecas externas: El procesamiento de audio y la detección de notas se realizará mediante las bibliotecas aubio, librosa y mido, sin modificaciones personalizadas en su funcionamiento.

---

7. #### **Rangos de calidad**{#rangos-de-calidad}

    - Precisión en la Detección de Notas:
      - PianoRise debe reconocer las notas tocadas por el usuario con una precisión superior al 85%, minimizando errores de detección causados por ruido ambiental moderado o variaciones menores en la ejecución.
      - La latencia en la detección debe ser suficientemente baja para proporcionar retroalimentación inmediata, sin retrasos perceptibles que afecten la experiencia de práctica.

    - Interfaz Intuitiva y Fácil de Usar
      - La plataforma debe ofrecer una navegación fluida, con menús y botones organizados de manera lógica y coherente.
      - Los usuarios deben poder visualizar claramente la secuencia de notas que deben tocar y recibir retroalimentación inmediata sobre su ejecución.

    - Retroalimentación Visual y Auditiva
      - La aplicación debe resaltar visualmente las notas correctas tocadas por el estudiante y emitir alertas claras cuando se produzcan errores, promoviendo la corrección instantánea.

    - Progresión y Evaluación del Usuario
      - Aunque no se usará un sistema de fracciones en esta implementación, la plataforma debe mostrar el estado de avance del usuario a través de indicadores claros de canciones completadas, errores cometidos y puntajes obtenidos.
      - Debe permitir la repetición de ejercicios para mejorar la precisión en cada sesión de práctica.

    - Galería de Canciones y Ejercicios
      - La aplicación debe contar con una selección inicial de canciones y ejercicios progresivos, organizados por niveles de dificultad adecuados para estudiantes principiantes.
      - Cada canción incluirá información básica sobre su nivel, para guiar al estudiante en su proceso de aprendizaje.

    - Compatibilidad y Accesibilidad
      - La plataforma debe ser totalmente funcional en navegadores web modernos como Google Chrome, Mozilla Firefox y Microsoft Edge.
      - Debe ser compatible con diferentes tipos de micrófonos integrados o externos, garantizando una correcta captura de audio en entornos escolares.

    - Políticas Claras de Uso
      - PianoRise debe garantizar la privacidad y seguridad de la información de sus usuarios, evitando la recolección de datos personales sensibles.
      - El sistema debe incluir un acuerdo de términos y condiciones claros para todos los usuarios.

---

8. #### **Precedencia y Prioridad**{#precedencia-y-prioridad}

    Dentro del desarrollo de PianoRise, se establecen las siguientes prioridades para la implementación de las funcionalidades.

    **Funcionalidades críticas:**
    - Gestión de usuarios (registro, inicio de sesión, recuperación de contraseña).
    - Reconocimiento de notas.
    - Selección y práctica de canciones por los estudiantes.
    - Registro del progreso de los estudiantes.

    **Funcionalidades importantes:**
    - Creación y gestión de aulas por parte de los docentes.
    - Monitoreo del avance de los estudiantes en cada aula.
    - Gestión del repertorio de canciones (agregar, editar y deshabilitar).

    **Funcionalidades complementarias:**
    - Generación de reportes gráficos y métricos de desempeño de las aulas.
    - Personalización de parámetros de reconocimiento de audio para diferentes tipos de ejercicios o niveles de dificultad.




---

9. #### **Otros requerimientos del producto**{#otros-requerimientos-del-producto}

    - **Estándares legales:** Cumplimiento con regulaciones de privacidad de datos personales y respeto a las normativas de propiedad intelectual.
    - **Estándares de cumplimiento de la plataforma:** Garantizar la disponibilidad y fiabilidad del servicio, asegurando un tiempo de actividad superior al 98%.
    - **Estándares de calidad y seguridad:** Implementación de medidas de seguridad para proteger la información de los usuarios mediante encriptación de datos y autenticación segura.
    - **Estándares de escalabilidad:** Preparar la plataforma para soportar un crecimiento en el número de usuarios, datos y canciones, manteniendo un rendimiento óptimo.

  ---

10. #### **CONCLUSIONES**{#conclusiones}

    PianoRise se establece como una herramienta digital enfocada en el aprendizaje autónomo del piano, proporcionando a los principiantes una plataforma interactiva que combina accesibilidad y tecnología de reconocimiento de audio. La integración de una interfaz intuitiva, un sistema de avance progresivo y retroalimentación en tiempo real permite que los usuarios mejoren su ejecución.

    El proyecto se centra exclusivamente en el piano, evitando la incorporación de otros instrumentos o características avanzadas como la evaluación de velocidad o teoría musical compleja. Además, su desarrollo se limitará a una aplicación web, asegurando compatibilidad con navegadores modernos en computadoras, sin considerar versiones móviles nativas.

    A nivel tecnológico, PianoRise dependerá de bibliotecas especializadas para el procesamiento de audio, garantizando un reconocimiento eficiente de notas. Sin embargo, su precisión estará sujeta a factores externos como la calidad del micrófono y el ruido ambiental.

    Finalmente, el éxito del proyecto dependerá de la implementación efectiva de sus funcionalidades clave y la recepción de los usuarios. A través de mejoras iterativas basadas en pruebas y retroalimentación, PianoRise se podrá consolidar como una solución innovadora para el aprendizaje del piano.

