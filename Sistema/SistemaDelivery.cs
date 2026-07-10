using RestaurantIngenieriaTrujillo.Estructuras.ABB;
using RestaurantIngenieriaTrujillo.Estructuras.ColaPrioridad;
using RestaurantIngenieriaTrujillo.Estructuras.Grafos;
using RestaurantIngenieriaTrujillo.Estructuras.ListaCircular;
using RestaurantIngenieriaTrujillo.Estructuras.ListaDoble;
using RestaurantIngenieriaTrujillo.Estructuras.ListaSimple;
using RestaurantIngenieriaTrujillo.Estructuras.Pila;
using RestaurantIngenieriaTrujillo.Estructuras.ListaProductos;
using RestaurantIngenieriaTrujillo.Estructuras.Cola;
using System;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Sistema
{
    /// Clase central del sistema que gestiona todas las estructuras de datos.
    /// Actúa como contenedor de instancias estáticas para acceso global.
    internal class SistemaDelivery
    {
        /// Lista simple de clientes registrados en el sistema.
        public static ListaClientes ListaClientes = new ListaClientes();

        /// Lista de productos disponibles en el menú del restaurante.
        public static ListaProductos ListaProductos = new ListaProductos();

        /// Lista circular de repartidores disponibles para entregas.
        public static ListaCircularRepartidores ListaRepartidores = new ListaCircularRepartidores();

        /// Cola FIFO de pedidos con prioridad normal.
        public static ColaPedidos ColaPedidos = new ColaPedidos();

        /// Cola de prioridad para pedidos prioritarios.
        public static ColaPrioridadPedidos ColaPrioridad = new ColaPrioridadPedidos();

        /// Lista doble para registrar historial de cambios de estado de pedidos.
        public static ListaDobleHistorial Historial = new ListaDobleHistorial();

        /// Pila LIFO que almacena el historial de cambios para deshacer operaciones.
        public static PilaPedidos PilaCambios = new PilaPedidos();

        /// Árbol binario de búsqueda que almacena todos los pedidos para búsquedas eficientes.
        public static ArbolPedidos ArbolPedidos = new ArbolPedidos();

        /// Grafo que representa las rutas y zonas de cobertura del servicio de delivery.
        public static GrafoRutas Grafo = new GrafoRutas();
    }
}
