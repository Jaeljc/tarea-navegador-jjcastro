#  Navegador - Proyecto DCU

Este proyecto consiste en el desarrollo de un navegador web funcional creado en **C#** utilizando **Visual Studio**, diseñado bajo los principios de las **10 Heurísticas de Usabilidad de Jakob Nielsen**.

##  Características y Heurísticas Aplicadas

Para esta asignación, me enfoqué en que el navegador no solo renderizara páginas, sino que fuera intuitivo:

1. **Visibilidad del estado del sistema:** Implementación de una barra de progreso y etiquetas de estado de carga.
2. **Control y libertad del usuario:** Botones de navegación (Atrás, Adelante, Home) claramente visibles.
3. **Prevención de errores:** Validación de URLs para asegurar que siempre utilicen el protocolo correcto (`https://`).
4. **Consistencia y estándares:** Diseño basado en la arquitectura clásica de navegadores modernos para reducir la curva de aprendizaje.
5. **Estética y diseño minimalista:** Interfaz limpia con acentos en color **morado** (mi toque personal).

##  Tecnologías Utilizadas

* **Lenguaje:** C#
* **Entorno:** Visual Studio 2022
* **Motor de Renderizado:** Microsoft.Web.WebView2 (Chromium)
* **Framework:** .NET (Windows Forms / WPF)

##  Video Explicativo

Puedes ver la explicación detallada de la construcción y la lógica detrás del código en el siguiente enlace:
[(https://drive.google.com/file/d/1g_ny4qQj6_CrqW7Gtlt9T5qjYYyOGNaB/view?usp=sharing) (https://youtu.be/wuVvz1qe3GE)]


##  Instrucciones de Ejecución
1. Clonar el repositorio.
2. Abrir el archivo `.sln` en Visual Studio.
3. Restaurar los paquetes NuGet (WebView2).
4. Ejecutar el proyecto.

---
**Autor:** Jael Castro (2024-1468)
**Institución:** Instituto Tecnológico de las Américas (ITLA)
**Carrera:** Desarrollo de Software
