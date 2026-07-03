using RestaurantIngenieriaTrujillo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.ListaProductos
{
    internal class NodoProducto
    {
        public Producto Datos { get; set; }

        public NodoProducto Siguiente { get; set; }

        public NodoProducto(Producto producto)
        {
            Datos = producto;
            Siguiente = null;
        }
    }
}
