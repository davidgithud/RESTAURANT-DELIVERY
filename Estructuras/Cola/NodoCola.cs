using RestaurantIngenieriaTrujillo.Entidades;
using System;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.Cola
{
    internal class NodoCola
    {
        public Pedido Datos { get; set; }

        public NodoCola Siguiente { get; set; }

        public NodoCola(Pedido pedido)
        {
            Datos = pedido;

            Siguiente = null;
        }
    }
}
