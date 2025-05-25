#!/bin/bash

echo "📦 Generando diagramas de PianoRisePyton..."

# Crear carpeta si no existe
mkdir -p diagrams

# ----------------------------------------
# 1️⃣ Diagrama de Clases - pyreverse
echo "🎨 Generando diagrama de clases con pyreverse..."
pyreverse -o png -p PianoRisePyton app/
mv classes_PianoRisePyton.png diagrams/class_diagram.png || echo "❌ No se generó class_diagram.png"

# ----------------------------------------
# 3️⃣ Diagrama de Componentes - Doxygen
echo "🧩 Generando documentación y componentes con Doxygen..."
doxygen Doxyfile || echo "❌ Error ejecutando Doxygen"

echo "✅ Diagramas generados en carpeta diagrams/ y docs/html/"

