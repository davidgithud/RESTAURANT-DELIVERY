using RestaurantIngenieriaTrujillo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RestaurantIngenieriaTrujillo.Estructuras.ListaDoble
{
    internal class NodoHistorial
    {
        public HistorialEstado Datos { get; set; }

        public NodoHistorial Anterior { get; set; }

        public NodoHistorial Siguiente { get; set; }

        public NodoHistorial(HistorialEstado historial)
        {
            Datos = historial;

            Anterior = null;

            Siguiente = null;
        }
    }
}
