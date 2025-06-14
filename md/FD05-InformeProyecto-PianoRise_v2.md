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


**Plataforma Web Interactiva para el Aprendizaje Autónomo del Piano con Reconocimiento de Notas en Tiempo Real \- PianoRise**

**Documento de Arquitectura de Software**

**Versión *1.0***

| CONTROL DE VERSIONES |  |  |  |  |  |
| :---: | :---: | :---: | :---: | :---: | ----- |
| Versión | Hecha por | Revisada por | Aprobada por | Fecha | Motivo |
| 1.0 |  |  |  | 29/03/2025 | Versión Original |

---


**ÍNDICE GENERAL**

[1\. Introducción	4](#introducción)

[1.1. Propósito	5](#propósito)

[1.2. Alcance	6](#alcance)

[1.3. Definiciones, Siglas y Abreviaturas	7](#definiciones,-siglas-y-abreviaturas)

[1.4. Visión General	8](#visión-general)

[2\. Representación Arquitectónica	8](#representación-arquitectónica)

[2.1. Escenarios	8](#escenarios)

[2.2. Vista Lógica	9](#vista-lógica)

[2.3. Vista del Proceso	10](#vista-del-proceso)

[2.4. Vista de desarrollo	28](#vista-de-desarrollo)

[2.5. Vista Física	29](#vista-física)

[3\. Objetivos y Limitaciones Arquitectónicas	29](#objetivos-y-limitaciones-arquitectónicas)

[3.1. Disponibilidad	29](#disponibilidad)

[3.2. Seguridad	30](#seguridad)

[3.3. Adaptabilidad	30](#adaptabilidad)

[3.4. Rendimiento	30](#rendimiento)

[4\. Análisis de Requerimientos	31](#análisis-de-requerimientos)

[4.1. Requerimientos funcionales	31](#requerimientos-funcionales)

[4.2. Requerimientos no funcionales	35](#requerimientos-no-funcionales)

[5\. Vistas de Caso de Uso	36](#heading=h.wh1otg33i288)

[6\. Vista Lógica	42](#vista-lógica-1)

[6.1. Diagrama Contextual	42](#diagrama-contextual)

[7\. Vista de Procesos	43](#vista-de-procesos)

[7.1. Diagrama de Proceso Actual	43](#diagrama-de-proceso-actual)

[7.2. Diagrama de Proceso Propuesto	44](#diagrama-de-proceso-propuesto)

[8\. Vista de Despliegue	45](#vista-de-despliegue)

[8.1. Diagrama de Contenedor	45](#diagrama-de-contenedor-\(link-del-diagrama\))

[9\. Vista de Implementación	45](#vista-de-implementación)

[9.1. Diagrama de Componentes	45](#diagrama-de-componentes)

[10\. Vista de Datos	47](#vista-de-datos)

[10.1. Diagrama Entidad Relación	47](#diagrama-entidad-relación)

[11\. Calidad	48](#calidad)

[11.1. Escenario de Seguridad	48](#escenario-de-seguridad)

[11.2. Escenario de Usabilidad	48](#escenario-de-usabilidad)

[11.3. Escenario de Adaptabilidad	49](#escenario-de-adaptabilidad)

[11.4. Escenario de Disponibilidad	50](#escenario-de-disponibilidad)

[11.5. Otro Escenario	51](#otro-escenario)

---