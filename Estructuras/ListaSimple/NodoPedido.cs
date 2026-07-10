using RestaurantIngenieriaTrujillo.Entidades;
using System;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.ListaSimple
{
    internal class NodoPedido
    {
        // Información del nodo
        public Pedido Datos { get; set; }

        // Apunta al siguiente nodo
        public NodoPedido Siguiente { get; set; }

        // Constructor
        public NodoPedido(Pedido pedido)
        {
            Datos = pedido;
            Siguiente = null;
        }
    }
}
