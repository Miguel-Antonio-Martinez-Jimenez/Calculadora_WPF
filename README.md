<div align="center">

# Calculadora WPF
</div>

### Descripción
Este proyecto es una calculadora de escritorio desarrollada en `C#` utilizando `Windows Presentation Foundation (WPF)`. La aplicación proporciona una interfaz gráfica intuitiva que facilita la ejecución de operaciones matemáticas básicas, tales como suma, resta, multiplicación y división, en un entorno interactivo y visualmente atractivo.

## Objetivo
El objetivo de este proyecto es crear una calculadora de escritorio en `C#` utilizando `Windows Presentation Foundation (WPF)` con un enfoque en la simplicidad y la facilidad de uso. La calculadora está diseñada para realizar operaciones matemáticas básicas como suma, resta, multiplicación y división, proporcionando una experiencia de usuario amigable y eficiente. La meta es ofrecer una herramienta visualmente atractiva que agilice los cálculos cotidianos, combinando funcionalidad y un diseño intuitivo para mejorar la interacción del usuario.

## Características
1. **Operaciones Matemáticas Básicas**: La calculadora permite realizar operaciones aritméticas esenciales como:
 - **Suma**: Adición de dos o más números.
 - **Resta**: Substracción de un número de otro.
 - **Multiplicación**: Producto de dos números.
 - **División**: División de un número por otro, con manejo de errores como la división por cero.
2. **Interfaz Gráfica Intuitiva**:
 - **Diseño Responsive**: Adaptación de los elementos gráficos para proporcionar una experiencia de usuario fluida y sin complicaciones.
 - **Botones de Entrada**: Uso de botones que representan números y operaciones matemáticas, diseñados para ser fácilmente accesibles y entendibles.
 - **Pantalla de Visualización**: Muestra los cálculos en curso y los resultados, proporcionando retroalimentación instantánea al usuario.
3. **Eventos y Validaciones**:
 - Captura de eventos de clic en los botones y ejecución de la lógica asociada a cada operación.
 - Manejo de errores comunes como entradas no válidas o intentos de dividir por cero.

## Requisitos
- **Visual Studio 2022** (o superior) para desarrollar y ejecutar el proyecto.
- **.NET Framework 4.7.2** (o superior).
> [!Important]
> Es importante asegurarse de que todos los requisitos estén instalados y configurados correctamente antes de ejecutar este proyecto para evitar problemas y asegurar un funcionamiento óptimo.

## Guía de Instalación
1. Clona el repositorio o descarga los archivos.
   
   ```bash
   git clone https://github.com/Miguel-Antonio-Martinez-Jimenez/Calculadora_WPF.git
3. Navega hasta el directorio del proyecto y abre el archivo de solución `(Calculadora.sln)` con Visual Studio.
4. Restaura los paquetes NuGet si es necesario y asegúrate de que todos los componentes estén correctamente instalados.
5. Compila el proyecto presionando `Ctrl + Shift + B` o seleccionando **"Compilar Solución"** en el menú.
6. Ejecuta la aplicación presionando `F5` o seleccionando **"Iniciar Depuración"**.

## Conexión con la Base de Datos
Este proyecto no requiere un sistema de gestión de bases de datos. En su lugar, se emplean archivos para el almacenamiento y manejo de los datos.

## Accesos o Credenciales
El proyecto no requiere de accesos o credenciales específicas para su uso. Solo es necesario clonar el repositorio y contar con los requisitos instalados en tu sistema para poder ejecutar el código.

## Guía de Uso del Proyecto
1. Al iniciar la aplicación, se abrirá la ventana principal de la calculadora.
2. Utiliza los botones numéricos para ingresar los valores.
3. Selecciona la operación deseada (suma, resta, multiplicación, o división).
4. Presiona el botón "=" para ver el resultado en la pantalla de la calculadora.
5. Utiliza el botón "C" para borrar la entrada y reiniciar el cálculo.

## Estructura de Archivos
- `App.xaml` y `App.xaml.cs`: Configuración principal de la aplicación, incluyendo el manejo de recursos y eventos de inicio.
- `AssemblyInfo.cs`: Contiene metadatos sobre el ensamblado (assembly), como el título, la versión, la descripción, la visibilidad COM y un identificador único (GUID).
- `Calculadora.csproj`: Archivo de proyecto que define las dependencias, configuraciones de compilación y otras propiedades del proyecto.
- `MainWindow.xaml`: Define el diseño visual de la ventana principal de la calculadora, incluyendo botones, pantalla y otros controles.
- `MainWindow.xaml.cs`: Contiene la lógica de la aplicación, como la captura de eventos de clic y la ejecución de las operaciones matemáticas.
- `Calculadora.sln`: Archivo de solución de Visual Studio que contiene la configuración del proyecto.

  ```bash
  Calculadora_WPF/
  ├── Calculadora/
  │   ├── App.xaml
  │   ├── App.xaml.cs
  │   ├── AssemblyInfo.cs
  │   ├── Calculadora.csproj
  │   ├── MainWindow.xaml
  │   └── MainWindow.xaml.cs
  ├── Calculadora.sln
  ├── LICENSE
  └── README.md

## Estado del Proyecto
**Estado Actual:** `Finalizado.`
> [!Note]
> Este proyecto se encuentra en estado **Finalizado**, lo que significa que todas las funcionalidades planeadas han sido implementadas y probadas satisfactoriamente. El código está disponible para su uso y estudio, y se aceptan contribuciones para mejoras o nuevas características.
<!--### Posibles Estados del Proyecto
- **Inicios:** El proyecto está en sus etapas iniciales de planificación y desarrollo. Apenas se están definiendo los requisitos y comenzando la implementación básica.
- **En Desarrollo:** El proyecto está en plena fase de desarrollo, con funcionalidades siendo añadidas y pruebas en curso. Puede contener errores o estar sujeto a cambios importantes.
- **Finalizado:** El proyecto ha alcanzado sus objetivos iniciales, con todas las funcionalidades implementadas y probadas. Puede recibir mantenimiento o mejoras menores.
- **Mantenimiento:** El proyecto está completo, pero sigue recibiendo actualizaciones menores, corrección de errores o mejoras en la documentación y el rendimiento.
- **Abandonado:** El desarrollo ha sido detenido y no se planean futuras actualizaciones ni mantenimiento. -->

## Contribuciónes
> [!Tip]
> Si deseas contribuir al proyecto, reportar errores o proponer mejoras, te invitamos a abrir un pull request o issue en el repositorio. También puedes contactarme directamente para compartir tus ideas o sugerencias a través de mi correo electrónico miguelantoniomartinezjimenez00@gmail.com. ¡Toda colaboración es bienvenida!

## Autores
[MiguelMartinez30 - @DevDarkSonic](https://github.com/Miguel-Antonio-Martinez-Jimenez)

## Licencia
Este proyecto está licenciado bajo la Licencia MIT. Consulta el archivo LICENSE para más detalles.
