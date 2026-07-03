using RestaurantIngenieriaTrujillo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.ABB
{
    internal class NodoABB
    {
        public Pedido Datos { get; set; }

        public NodoABB Izquierdo { get; set; }

        public NodoABB Derecho { get; set; }

        public NodoABB(Pedido pedido)
        {
            Datos = pedido;

            Izquierdo = null;

            Derecho = null;
        }
    }
}
