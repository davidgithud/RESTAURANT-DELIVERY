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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Sistema
{
    internal class SistemaDelivery
    {
        public static ListaClientes ListaClientes = new ListaClientes();

        public static ListaProductos ListaProductos = new ListaProductos();

        public static ListaCircularRepartidores ListaRepartidores = new ListaCircularRepartidores();

        public static ColaPedidos ColaPedidos = new ColaPedidos();

        public static ColaPrioridadPedidos ColaPrioridad = new ColaPrioridadPedidos();

        public static ListaDobleHistorial Historial =new ListaDobleHistorial();

        public static PilaPedidos PilaCambios = new PilaPedidos();

        public static ArbolPedidos ArbolPedidos = new ArbolPedidos();

        public static GrafoRutas Grafo = new GrafoRutas();
    }
}
