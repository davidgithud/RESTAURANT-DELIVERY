using RestaurantIngenieriaTrujillo.Entidades;
using System;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.Pila
{
    internal class NodoPila
    {
        public Pedido Datos { get; set; }

        public NodoPila Siguiente { get; set; }

        public NodoPila(Pedido pedido)
        {
            Datos = pedido;
            Siguiente = null;
        }
    }
}
