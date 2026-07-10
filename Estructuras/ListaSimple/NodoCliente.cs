using RestaurantIngenieriaTrujillo.Entidades;
using System;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.ListaSimple
{
    internal class NodoCliente
    {
        public Cliente Datos { get; set; }

        public NodoCliente Siguiente { get; set; }

        public NodoCliente(Cliente cliente)
        {
            Datos = cliente;
            Siguiente = null;
        }
    }
}
