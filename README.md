# Sistema de Delivery para Restaurantes de Trujillo

Descripción:
-----------
Aplicación de escritorio desarrollada en C# (.NET 8) con Windows Forms que gestiona clientes, productos, pedidos, repartidores y rutas para un sistema de delivery. El proyecto implementa estructuras de datos desde cero (listas, pilas, colas, ABB, grafos) sin usar colecciones nativas de .NET para demostrar su aplicabilidad en escenarios reales.

Tecnologías
----------
- Lenguaje: C#
- Plataforma: .NET 8
- Interfaz: Windows Forms (WinForms)
- IDE recomendado: Visual Studio 2022/2024/2026

Estructura del repositorio
--------------------------
- Entidades/: clases del dominio (Cliente, Pedido, Producto, Repartidor, Zona).
- Datos/: clases de acceso/persistencia ligera.
- Estructuras/: implementaciones propias de estructuras de datos (ListaSimple, ListaDoble, ListaCircular, Pila, Cola, ColaPrioridad, ABB, Grafos, ListaProductos).
- Formularios/: Windows Forms (UI).
- Sistema/: lógica de negocio y orquestación (SistemaDelivery.cs).
- Properties/: recursos del proyecto.
- Program.cs, FrmPrincipal.* y archivos de proyecto (.csproj, .sln).

Características principales
--------------------------
- Registro y gestión de clientes, productos, pedidos y repartidores.
- Colas FIFO y colas por prioridad para atención de pedidos.
- Árbol binario de búsqueda (ABB) para búsqueda rápida de pedidos por código.
- Lista circular para rotación equitativa de repartidores.
- Grafo de zonas con algoritmos (Dijkstra, Prim) para cálculo de rutas y red mínima.
- Historial de estados mediante lista doble y registro reciente mediante pila.

Estructuras de datos implementadas
---------------------------------
Todas implementadas manualmente sin usar List/Stack/Queue/Dictionary/LINQ/Array.Sort, entre ellas:
- Lista simple (clientes, pedidos)
- Lista doble (historial de estados)
- Lista circular (repartidores)
- Pila (registro reciente de pedidos)
- Cola (pedidos FIFO) y Cola de prioridad
- Árbol Binario de Búsqueda (ArbolPedidos)
- Grafo por matriz de costes (GrafoRutas)
- Lista especializada de productos con ordenación propia

Requisitos de Instalación
----------
- Windows 10/11 (para ejecución WinForms)
- .NET 8 SDK instalado (opcional si usa Visual Studio)
- Visual Studio con carga de trabajo de desarrollo .NET Desktop (recomendado)

Instalación y ejecución
-----------------------
Con Visual Studio:
1. Abrir `RestaurantIngenieriaTrujillo.sln` en Visual Studio.
2. Restaurar/actualizar paquetes (si aplica).
3. Compilar y ejecutar (F5).

Uso básico
---------
- Iniciar la aplicación y usar el formulario principal para acceder a módulos: Clientes, Productos, Pedidos, Repartidores, Rutas, Historial.
- Registrar clientes y productos antes de crear pedidos.
- Registrar pedidos indicando prioridad si aplica; los pedidos se gestionan con estructuras internas (cola, ABB, etc.).

Contribución
----------
1. Hacer fork o clonar el repositorio.
2. Crear branch para la feature/bugfix.
3. Hacer commits pequeños y descriptivos.
4. Abrir Pull Request hacia `develop` (o `main` si procede).
