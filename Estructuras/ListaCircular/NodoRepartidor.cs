using RestaurantIngenieriaTrujillo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.ListaCircular
{
    internal class NodoRepartidor
    {
        public Repartidor Datos { get; set; }

        public NodoRepartidor Siguiente { get; set; }

        public NodoRepartidor(Repartidor repartidor)
        {
            Datos = repartidor;
            Siguiente = null;
        }
    }
}
