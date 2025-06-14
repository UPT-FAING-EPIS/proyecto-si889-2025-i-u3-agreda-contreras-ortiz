<center>

![../media/media/image1.png](../media/logo-upt.png)

**UNIVERSIDAD PRIVADA DE TACNA**

**FACULTAD DE INGENIERÍA**

**Escuela Profesional de Ingeniería de Sistemas**

 **Plataforma Web Interactiva para el Aprendizaje Autónomo del Piano con Reconocimiento de Notas Musicales \- PianoRise**

Curso: *Patrones de Software*

Docente: *Mag. Patrick Cuadros Quiroga*

Integrantes:

 ***Agreda Ramirez, Jesús Eduardo 	(2021069823)***  
***Contreras Lipa, Alvaro Javier            (2021070020)***  
***Ortiz Fernandez, Ximena Andrea	(2021071080)***

**Tacna – Perú**  
**2025**

</center>

---



**Plataforma Web Interactiva para el Aprendizaje Autónomo del Piano con Reconocimiento de Notas Musicales \- PianoRise**

**Documento Informe de Factibilidad**

**Versión *1.0***


|  |        |    CONTROL    |    DE      |   VERSIONES     |                   |
|----------------------|--------|--------|--------|--------|-------------------|
| Versión              | Hecha por | Revisada por | Aprobada por | Fecha  | Motivo            |
| 1.0                  | Agreda Ramirez, Jesús Eduardo<br>Contreras Lipa, Alvaro Javier<br>Ortiz Fernandez, Ximena Andrea | Agreda Ramirez, Jesús Eduardo<br>Contreras Lipa, Alvaro Javier<br>Ortiz Fernandez, Ximena Andrea | Agreda Ramirez, Jesús Eduardo<br>Contreras Lipa, Alvaro Javier<br>Ortiz Fernandez, Ximena Andrea | 26/04/2025 | Versión Original |

---

**ÍNDICE GENERAL**

[1\. Descripción del Proyecto	4](#descripción-del-proyecto)

[2\. Riesgos	6](#riesgos)

[3\. Análisis de la Situación actual	7](#análisis-de-la-situación-actual)

[4\. Estudio de Factibilidad	11](#estudio-de-factibilidad)

[4.1 Factibilidad Técnica	11](#factibilidad-técnica)

[4.2 Factibilidad Económica	12](#factibilidad-económica)

[4.3 Factibilidad Operativa	15](#factibilidad-operativa)

[4.4 Factibilidad Legal	15](#factibilidad-legal)

[4.5 Factibilidad Social	16](#factibilidad-social)

[4.6 Factibilidad Ambiental	16](#factibilidad-ambiental)

[5\. Análisis Financiero	17](#análisis-financiero)

[6\. Conclusiones	20](#conclusiones)

**Informe de Factibilidad**

1. #### Descripción del Proyecto

    1. **Nombre del proyecto**

        Plataforma Web Interactiva para el Aprendizaje Autónomo del Piano con Reconocimiento de Notas Musicales \- PianoRise

    2. **Duración del proyecto**

        Inicio: 13 de marzo

        Fin: 01 de Julio

        El proyecto tendrá una duración aproximada de 17 semanas.

    3. **Descripción**

        Este proyecto busca optimizar el proceso de enseñanza y evaluación musical mediante una plataforma interactiva que conecta a docentes y alumnos en un entorno digital estructurado. A través de una interfaz intuitiva y funcionalidades especializadas, el sistema PianoRise facilita el desarrollo de habilidades musicales, la asignación de repertorios personalizados y el seguimiento del progreso individual de los estudiantes.

        Para su implementación, se desarrollará un prototipo funcional que permite la creación de aulas virtuales por parte de los docentes, quienes podrán seleccionar canciones desde un repertorio general y asignarlas a sus alumnos de acuerdo con el nivel de dificultad y objetivos pedagógicos. El sistema registrará automáticamente el historial de prácticas de cada alumno, brindando datos detallados sobre su evolución musical.

        Además, PianoRise incorporará herramientas que agilizan la gestión académica, como la asignación de evaluaciones, la visualización de métricas de desempeño y la personalización del proceso de aprendizaje. Este enfoque garantizará una enseñanza más efectiva, adaptada a las necesidades individuales de cada estudiante, y fomentará una experiencia educativa más dinámica, interactiva y centrada en el progreso continuo del alumno.

   4. **Objetivos**

      1. **Objetivo general**

          Desarrollar una plataforma web interactiva para el aprendizaje autónomo del piano con reconocimiento de notas musicales denominado PianoRise.

      2. **Objetivos Específicos**

      * Desarrollar un módulo de autenticación de usuarios, que permita registrar, iniciar sesión y gestionar credenciales de acceso de forma segura para administradores, docentes y alumnos.  
      * Desarrollar un módulo de gestión de aulas virtuales, permitiendo a los docentes crear, configurar y administrar aulas musicales con un código de acceso único para los estudiantes.  
      * Implementar un módulo de registro y gestión de docentes, permitiendo al administrador crear, editar y deshabilitar cuentas de docentes dentro del sistema.  
      * Construir un módulo de reconocimiento de notas musicales, utilizando la captura de audio por micrófono para evaluar la ejecución de las canciones.  
      * Desarrollar un módulo de selección de canciones, permitiendo a los alumnos elegir piezas musicales de un repertorio personalizado en cada aula.  
      * Implementar un módulo de gestión del repertorio general, donde el administrador podrá agregar, editar y deshabilitar canciones disponibles para la configuración de las aulas.  
      * Desarrollar un módulo de almacenamiento del progreso del estudiante, registrando las canciones completadas y los errores cometidos durante la práctica.  
      * Implementar un módulo de monitoreo de progreso de estudiantes, para que los docentes puedan visualizar el avance individual de sus alumnos y la puntuación obtenida en cada canción.  
      * Desarrollar un módulo de generación de reportes de desempeño, proporcionando métricas y gráficos sobre el rendimiento de los estudiantes en cada aula.

2. #### Riesgos

    **Corto tiempo para el desarrollo de la aplicación web:**

    * El tiempo disponible para desarrollar PianoRise puede ser limitado, lo que podría afectar la entrega de todas las funcionalidades previstas.  
    * Mitigación: Priorizar las funcionalidades esenciales (gestión de aulas, asignación de canciones y seguimiento de prácticas) y adoptar una estrategia de desarrollo incremental.  
    
    **Dificultad en el desarrollo de interfaces de usuario:**

    * Crear una interfaz intuitiva tanto para docentes como para alumnos puede representar un desafío técnico importante.  
    * Mitigación: Definir un diseño UX/UI claro desde las etapas iniciales y aplicar buenas prácticas de frontend utilizando ASP.NET Framework MVC y Python Flask.  
    
    **Limitada disponibilidad del equipo de desarrollo:**

    * La disponibilidad del equipo podría verse afectada debido a cargas académicas u otras responsabilidades personales.  
    * Mitigación: Establecer un cronograma realista de actividades, asignar tareas de manera eficiente y mantener reuniones periódicas de control de avances.  
    
    **Insuficiente presupuesto para herramientas y servicios:**

    * Algunas herramientas necesarias para el almacenamiento de datos, alojamiento web o servicios de autenticación podrían tener costos asociados.  
    * Mitigación: Evaluar alternativas gratuitas o de bajo costo que cubran las necesidades del proyecto, asegurando la sostenibilidad del sistema.

3. #### Análisis de la Situación actual

   1. ##### **Planteamiento del problema**

      Actualmente, en el entorno de enseñanza musical, los procesos de gestión y seguimiento de las clases de piano presentan importantes limitaciones debido a la falta de herramientas tecnológicas especializadas. El manejo de aulas, el seguimiento del progreso de los estudiantes y la organización del repertorio musical se realizan de manera manual o utilizando plataformas no adaptadas a las necesidades específicas de la formación instrumental. Esta situación genera ineficiencias, dificulta la evaluación objetiva del desempeño y limita el crecimiento académico de los estudiantes. Los principales problemas identificados son:

      * *Procesos manuales e ineficientes:* La creación y gestión de clases, así como el seguimiento del progreso de los alumnos, se realiza de forma manual o con herramientas genéricas, lo que provoca demoras, errores y sobrecarga de trabajo para los docentes.

      * *Falta de seguimiento estructurado del desempeño estudiantil:* Actualmente, no se dispone de un sistema que registre de manera organizada las canciones practicadas, los errores cometidos y los logros alcanzados por los estudiantes, dificultando así una evaluación continua y objetiva.

      * *Ausencia de un módulo especializado para repertorios musicales:* No existe un sistema que permita seleccionar y administrar repertorios adaptados al nivel de cada aula, limitando la personalización de la enseñanza y el desarrollo musical de los estudiantes.

      * *Gestión desorganizada de información:* El registro de alumnos, aulas y progreso de aprendizaje se realiza de forma dispersa, aumentando el riesgo de pérdida de datos importantes y dificultando la obtención de reportes consolidados.

      * *Limitada visibilidad para los docentes sobre el avance de sus estudiantes:* Los docentes carecen de herramientas que les permitan monitorear de forma clara y detallada el desempeño de cada alumno, lo que dificulta identificar áreas de mejora y establecer estrategias de refuerzo.

      * *Falta de mecanismos para generar reportes de desempeño:* No se dispone de un sistema automatizado que permita generar reportes gráficos o métricos sobre el progreso individual y grupal, lo que restringe la capacidad de análisis y retroalimentación educativa.

    2. ##### **Consideraciones de hardware y software**

        Hardware:

        * *Computadora de Desarrollo:*

          Computadoras con hardware suficiente para ejecutar Visual Studio Code y Visual Studio 2022 y diversos programas para la implementación del sistema. Se recomienda una computadora con al menos un procesador de cuatro núcleos, 8 GB de RAM y un disco duro sólido (SSD) para un rendimiento óptimo.

          * Acer nitro 5\.

        * *Memoria RAM:*

          Visual Studio Code  y Visual Studio 2022 puede consumir recursos considerables, especialmente al compilar y ejecutar la aplicación. Por lo tanto, contar con suficiente memoria RAM es esencial para evitar la ralentización del sistema.

          * 16 GB de RAM.

        * *Procesador:*

          El procesador de los equipos de trabajo deben de ser altamente potentes, contando con varios núcleos e hilos para procesar la información del software utilizado.

          * Intel Core i5 12500 H 12 núcleos y 8 hilos.

        * *Tarjeta Gráfica:*

          Los equipos de trabajo deben de contar con una GPU dedicada, necesaria para realizar cálculos paralelos de manera eficiente, mejorar la interactividad y el rendimiento de la aplicación, y facilitar el procesamiento de gráficos para visualizaciones de datos y elementos gráficos avanzados.

          * Nvidia RTX 3050

        Software: 

        * ***Sistema Operativo:***  
          Los programas utilizados para el desarrollo de la aplicación web son compatibles con Windows 10 y Windows 11, permitiendo flexibilidad en el entorno de desarrollo.

        * ***Entorno de Desarrollo Frontend:***  
          El frontend se desarrollará utilizando ASP.NET (MVC) sobre .NET Framework, permitiendo una integración directa con el backend y asegurando una estructura consistente, organizada y de fácil mantenimiento. El diseño visual se apoya en Tailwind CSS, garantizando una interfaz limpia, responsiva y personalizable para los usuarios.

        * ***Entorno de Desarrollo Backend:***  
          El backend será desarrollado en ASP.NET (MVC) bajo .NET Framework, siguiendo el patrón Modelo-Vista-Controlador para una implementación clara, escalable y robusta de las funcionalidades del sistema. El módulo de reconocimiento de notas musicales se desarrollará de forma independiente utilizando Python Flask, empleando librerías especializadas en análisis de audio, y se integrará al sistema principal mediante una comunicación estructurada.

        * ***Hospedaje del proyecto ASP.NET:***  
          El proyecto ASP.NET MVC estará desplegado en Microsoft Azure App Service,  una plataforma de hospedaje en la nube que proporciona alta disponibilidad, escalabilidad automática y administración simplificada.  

        * ***Procesamiento Especializado en Python:***

          El módulo desarrollado en Python, encargado de funciones específicas como el reconocimiento de notas musicales, estará contenerizado en Docker y estará desplegado en Microsoft Azure App Service . 

        * ***Base de Datos Relacional:***  
          Se utilizará PostgreSQL como motor de base de datos, hospedado en el servicio neon.tech. Este sistema de gestión de bases de datos relacional será responsable del almacenamiento estructurado de información, incluyendo datos de usuarios, docentes, aulas, canciones, progreso estudiantil y configuraciones del sistema. PostgreSQL ofrece robustez, soporte avanzado para transacciones, alta disponibilidad, recuperación ante desastres y escalabilidad automática.

        * ***Editores de Código:***  
          Se utilizarán Visual Studio Code y Visual Studio 2022 como entornos de desarrollo principales, permitiendo una escritura, depuración y navegación eficiente del código fuente.

4. #### Estudio de Factibilidad

   1. ##### **Factibilidad Técnica** {#factibilidad-técnica}

      El estudio de factibilidad técnica tiene como finalidad evaluar los recursos tecnológicos actuales y su aplicabilidad en el desarrollo e implementación del sistema propuesto. En este caso, se analiza la infraestructura disponible, tanto de hardware como de software, así como su compatibilidad con los requerimientos del proyecto “PianoRise”.

      Hardware:

      **Servidores:**

      * Host para el Servicio de Cursos de Música: Se utilizará Azure App Service en un plan de pago básico para desplegar el servicio desarrollado en ASP.NET. Este servicio en la nube garantiza la estabilidad, escalabilidad automática, administración simplificada y alta disponibilidad del sistema.

      * Host para el Servicio de Reconocimiento de Notas: El módulo especializado en reconocimiento de notas musicales, desarrollado en Python, estará contenerizado en Docker y estará desplegado en Microsoft Azure App Service.

      **Estaciones de trabajo:**  
      Se cuenta con computadoras personales para los desarrolladores con especificaciones estándar que incluyen procesadores Intel i5/i7, 8–16GB de RAM, y SSDs, que garantizan un entorno de desarrollo ágil y funcional.

      Software:

      **Sistemas operativos:**

      * Desarrollo realizado en Windows, el cual es compatible con las herramientas seleccionadas.

      **Aplicaciones y Herramientas de Desarrollo:**

      * Visual Studio Code: Es uno de los entornos de desarrollo principales utilizados en el proyecto, compatible con los sistemas operativos Windows y macOS. Ofrece una gran variedad de extensiones que permiten personalizar el entorno de trabajo, facilitando la programación y la gestión de proyectos.

      * Visual Studio 2022: También se emplea Visual Studio 2022 como entorno de desarrollo integral (IDE), especialmente para el desarrollo de aplicaciones ASP.NET MVC. Ofrece herramientas avanzadas para depuración, integración continua y desarrollo en la nube, optimizando así la productividad del equipo.

      * Terraform: Utilizado para la creación y gestión automatizada de la infraestructura en Azure, asegurando consistencia, control de cambios y escalabilidad en los recursos desplegados.

      **Lenguajes y frameworks:**

      * Servicio de Cursos de Música: ASP.NET con .NET Framework utilizando el patrón Modelo-Vista-Controlador (MVC) y Tailwind CSS para la maquetación y diseño visual de las interfaces.  
      * Servicio de Reconocimiento de notas musicales: El procesamiento de audio será realizado de forma independiente usando Python con librerías especializadas.

      **Infraestructura de red y acceso a internet**:  
      El sistema se desarrollará y desplegará completamente en línea. Se cuenta con acceso estable a internet para todas las fases del proyecto, y el alojamiento web asegurado con dominio personalizado.

      **Compatibilidad de navegadores**:  
      El sistema será accesible desde navegadores modernos como Google Chrome, Mozilla Firefox, Microsoft Edge y Safari, sin necesidad de instalar software adicional.

    2. ##### **Factibilidad Económica** {#factibilidad-económica}

        Se definieron los siguientes costos:

        1. **Costos Generales**

            “No se consideraron costos generales para el proyecto”.

   
        2. **Costos operativos durante el desarrollo**

        <center>
  
        ![image](https://github.com/user-attachments/assets/f0839f17-aaab-41f6-819e-4c74aeae4db0)
       
        **Imagen 01\.** Imagen de los costos operativos realizada con Infracost para la plataforma PianoRise .  
        ***Fuente:** Elaboración propia.*

        </center>

        <center>
            
        ![image](https://github.com/user-attachments/assets/b6e92ba7-22cc-40ec-a747-ab6f93ac6fc0)
        **Imagen 02\.** Imagen de los costos operativos del hosting de la base de datos NeonTech  para la plataforma PianoRise .  
        ***Fuente:** Elaboración propia*
        </center>

        3. **Costos del ambiente**

        <center>
            
        ![image](https://github.com/user-attachments/assets/8ba688b7-9baa-446c-8203-47707b2d1eef)
        **Imagen 03\.** Imagen de los costos del ambiente realizada con Infracost para la plataforma PianoRise .  
        ***Fuente:** Elaboración propia.*

        </center>
        
        <center>
  
        ![image](https://github.com/user-attachments/assets/6f75d430-810a-4430-8005-e7c7306525e2)

        **Imagen 04\.** Imagen de los costos del ambiente del hosting de la base de datos NeonTech  para la plataforma PianoRise .  
        ***Fuente:** Elaboración propia*

        </center>

        4. **Costos de personal**

        | Nombre del Rol | Cantidad de Personas | Horario de Trabajo |
        | ----- | ----- | ----- |
        | Desarrollador Full Stack | 3 | 20 horas semanales aprox. |

        <center>

        **Tabla 01\.** Tabla de los roles y horas de trabajo del personal de desarrollo de la plataforma PianoRise.  
        ***Fuente:** Elaboración propia.*
        
        </center>

        | Rol | Cantidad | Sueldo Mensual | Duración | Costo Total |
        | ----- | ----- | ----- | ----- | ----- |
        | Desarrollador Full Stack | 3 | 1130 | 4 meses | 13,560 |
        | **Total** |  |  |  | **13,560** |

        <center>

        **Tabla 02\.** Tabla de los costos de personal para el desarrollo de la plataforma PianoRise.  
        ***Fuente:** Elaboración propia.*
        
        </center>

        5. **Costos totales del desarrollo del sistema**

        | Categoría de Costo | Costo Total (S/.) |
        | ----- | ----- |
        | Costos Generales | 0 |
        | Costos Operativos | 0 |
        | Costos del Ambiente (5 años) | 20,400 |
        | Costos de Personal | 13,560 |
        | **Total General del Proyecto** | **S/ 33,960** |

        <center>

        **Tabla 03\.** Tabla de los costos totales para el desarrollo de la plataforma PianoRise.  
        ***Fuente:** Elaboración propia.*

        </center>

    3. ##### **Factibilidad Operativa** {#factibilidad-operativa}

        La factibilidad operativa analiza si el sistema propuesto puede ser implementado, mantenido y utilizado de forma efectiva por la organización y los usuarios finales. En el caso de “PianoRise”, el sistema brindará beneficios significativos en el proceso de enseñanza y evaluación de habilidades musicales.

        **Beneficios del Sistema**:

        * Automatización del proceso de creación y gestión de aulas virtuales.  
        * Mejora en la eficiencia del seguimiento del progreso de los alumnos.  
        * Disminución del tiempo requerido para evaluar el desempeño en ejercicios musicales.  
        * Fortalecimiento de la relación entre docentes y alumnos a través de retroalimentación digital inmediata.  
        * Facilidad de uso para docentes y alumnos mediante interfaces intuitivas.  
        * Posibilidad de expansión hacia nuevos módulos como repertorios personalizados o torneos de práctica musical.

        **Capacidad Operativa**:

        * El sistema es autoadministrado por el personal docente de la Escuela de Música, con soporte técnico mínimo requerido.  
        * Los usuarios (docentes y alumnos) reciben interfaces diferenciadas según su rol y necesidades específicas.  
        * Se considera un uso liviano a moderado del sistema (baja concurrencia simultánea), por lo que no se requieren recursos tecnológicos de alta demanda.  
        * La aplicación cuenta con paneles de control y módulos de práctica amigables, que no requieren entrenamiento técnico especializado para su operación.

    4. ##### **Factibilidad Legal** {#factibilidad-legal}

        El sistema “PianoRise” cumple con las normativas legales y reglamentos nacionales relacionados con el uso de software educativo y protección de datos personales. No se detectan conflictos legales para su implementación.

        Aspectos Legales Considerados:

        * Protección de datos personales: El sistema almacenará información personal de egresados. Se cumplirán los principios de la Ley N.° 29733 (Ley de Protección de Datos Personales), asegurando confidencialidad, integridad y acceso controlado a la información.  
        * Seguridad de la información: Se utilizarán protocolos de seguridad como HTTPS y cifrado de contraseñas.  
        * Uso de software adecuado: El sistema se desarrollará en ASP.NET (.NET Framework) y Python (para el reconocimiento de notas), respetando licencias de uso de software privativo y de código abierto donde corresponda.  
        * Contratos con terceros: Se respetarán los términos de servicio de servicios como Azure (alojamiento de Servicio de Reconocimiento de Notas y Servicio de Cursos de Música), NeonTech (alojamiento de la base de datos PostgreSQL).

    5. ##### **Factibilidad Social** {#factibilidad-social}

        El proyecto “PianoRise” tiene un impacto social positivo al fortalecer la formación musical y promover la innovación educativa mediante el uso de nuevas tecnologías.

        **Factores Sociales Relevantes**:

        * Apoyo institucional: La escuela y sus autoridades respaldan el proyecto como parte de su plan de modernización educativa.  
        * Aceptación cultural: No existen barreras culturales o éticas, ya que el sistema mejora el acceso a métodos de enseñanza innovadores en el ámbito musical.  
        * Inclusión digital: Permite que alumnos de distintos niveles accedan a prácticas musicales asistidas digitalmente, reduciendo brechas tecnológicas y educativas.

    6. ##### **Factibilidad Ambiental** {#factibilidad-ambiental}

        El sistema “PianoRise” es una solución completamente digital, por lo que su impacto ambiental es mínimo

        Evaluación Ambiental:

        * Reducción del uso de papel: Se digitalizan procesos de inscripción, práctica y evaluación de alumnos, contribuyendo a la sostenibilidad ecológica.  
        * Alojamiento en la nube: El uso de servidores en la nube elimina la necesidad de infraestructura física local, reduciendo consumo energético adicional.  
        * No se generan residuos: No se utilizan materiales contaminantes ni recursos físicos desechables en su operación.

  5. ##### **Analisis Financiero** {#analisis-financiero}

      5.1 Justificación de la Inversión

        5.1.1 Beneficios del Proyecto:

        Beneficios tangibles:

        - Reducción de costos operativos en la búsqueda de candidatos, ya que el sistema filtra, pondera y selecciona egresados automáticamente.
        - Reducción del tiempo de selección de egresados para prácticas o empleos, lo que reduce la carga laboral del departamento encargado de inserción laboral.
        - Ahorro en materiales gracias a la digitalización del proceso de vinculación laboral.
        - Ahorro en publicidad para captar postulantes (menos necesidad de anuncios externos).
        - Reducción de personal eventual o temporal que normalmente colabora en los procesos de selección.
        - Aumento de la empleabilidad de los egresados, lo que mejora la reputación de la Escuela Profesional de Ingeniería de Sistemas.
        
        Beneficios intangibles:

        - Mejor imagen institucional, al mostrar un sistema moderno de apoyo a los egresados.
        - Mayor satisfacción de egresados y empresas gracias a procesos más rápidos y personalizados.
        - Mayor control, trazabilidad y gestión de la información en procesos de selección.
        - Facilita el cumplimiento de indicadores de empleabilidad de egresados ante entes supervisores (como SUNEDU).
        - Valor agregado a la formación académica del estudiante, al contar con una plataforma exclusiva de vinculación laboral.
        - Fomento del vínculo universidad-empresa.
        - Mejora en la toma de decisiones, gracias a los reportes generados por el sistema.

        5.1.2 Criterios de Inversión:

        Egresos Anuales:
        <center>

        | Concepto          | Año 1 | Año 2 | Año 3 | Año 4 | Año 5 |
        |-------------------|-------|-------|-------|-------|-------|
        | Hosting Azure     | 960   | 960   | 960   | 960   | 960   |
        | Hosting Elastika  | 100   | 100   | 100   | 100   | 100   |
        | Soporte técnico   | 150   | 200   | 250   | 250   | 250   |
        | Mantenimiento menor | 100 | 140   | 190   | 190   | 190   |
        | **Total egresos anuales (S/.)** | **1,350** | **1,400** | **1,500** | **1,500** | **1,500** |
        
        Tabla 07. Tabla de los egresos anuales de la UPT posterior al desarrollo de la plataforma LinkJob.<br>
        Fuente: Elaboración propia.

        </center>
        <br>
        Cuadro FNC:
        <center>

        | Año | Ingresos (S/.) | Egresos (S/.) | FNC (S/.)  |
        |-----|----------------|---------------|------------|
        | 0   | 0              | 28,500        | -28,500    |
        | 1   | 7,250          | 1,350         | 5,900      |
        | 2   | 7,250          | 1,400         | 5,850      |
        | 3   | 7,250          | 1,500         | 5,750      |
        | 4   | 7,250          | 1,500         | 5,750      |
        | 5   | 7,250          | 1,500         | 5,750      |

        Tabla 08. Tabla del flujo neto de caja del desarrollo y ciclo de vida de la aplicación web LinkJob.<br>
        Fuente: Elaboración propia.
        <br>
        <br>
        </center>

        5.1.2.1 Relación Beneficio/Costo (B/C)

        - B/C = 0.87
        - Como B/C > 1, el proyecto es viable económicamente, ya que los beneficios superan a los costos.

        5.1.2.2 Valor Actual Neto (VAN)

        - VAN = S/ 4,360.65
        - Un VAN positivo indica que el proyecto genera valor adicional después de recuperar la inversión inicial. 

        5.1.2.3 Tasa Interna de Retorno (TIR)

        - TIR = 4.37%
        - Como TIR > tasa de interés (1.5%), el proyecto es rentable y debe aceptarse, ya que supera el costo de oportunidad.

  6. ##### **Conclusiones** {#conclusiones}

      El proyecto LinkJob representa una solución innovadora para la vinculación laboral de los egresados de la Escuela Profesional de Ingeniería de Sistemas de la UPT. A través de una plataforma web con inteligencia artificial, se optimiza el proceso de emparejamiento entre egresados y ofertas laborales, mejorando significativamente la precisión y rapidez en la toma de decisiones del área de empleabilidad.
      
      Desde el punto de vista operativo, la universidad cuenta con la infraestructura y capacidades necesarias para mantener la plataforma funcionando de forma continua, garantizando su sostenibilidad. La solución genera beneficios tanto para los usuarios como para el área académica y de empleabilidad, al centralizar y facilitar la gestión de información relevante.
      
      Legalmente, LinkJob se ajusta a la Ley N° 29733 de Protección de Datos Personales, resguardando la privacidad de la información de egresados y empresas. Además, se utilizan plataformas, librerías y servicios bajo licencias válidas, cumpliendo con los aspectos de propiedad intelectual.
      
      Socialmente, el proyecto impacta de manera positiva en la comunidad universitaria, al facilitar oportunidades laborales para los egresados, fomentar la transparencia del proceso de empleabilidad y reforzar el compromiso institucional con el desarrollo profesional de sus estudiantes.
      
      A nivel ambiental, al tratarse de una plataforma 100% digital, se promueve la reducción del uso de papel y recursos físicos, alineándose con iniciativas sostenibles que minimizan la huella ecológica institucional.
      
      Finalmente, el análisis financiero confirma su viabilidad. La Relación Beneficio/Costo (B/C) es de 1.38, lo que indica que por cada sol invertido se generan S/ 1.38 en beneficios. El Valor Actual Neto (VAN) es de S/ 4,282.91, confirmando que los beneficios superan ampliamente los costos. La Tasa Interna de Retorno (TIR) alcanza el 11.40%, superando la tasa de interés del 1.5%, lo que respalda la rentabilidad del proyecto.
      
      En conjunto, estos resultados demuestran que LinkJob es una inversión estratégica, rentable y sostenible para la universidad.
