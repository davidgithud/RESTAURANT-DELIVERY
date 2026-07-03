using RestaurantIngenieriaTrujillo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.Pila
{
    internal class PilaPedidos
    {
        private NodoPila cima;

        public PilaPedidos()
        {
            cima = null;
        }
        public bool EstaVacia()
        {
            return cima == null;
        }
        public void Push(Pedido pedido)
        {
            NodoPila nuevo = new NodoPila(pedido);

            nuevo.Siguiente = cima;

            cima = nuevo;
        }
        public Pedido Pop()
        {
            if (EstaVacia())
                return null;

            Pedido pedido = cima.Datos;

            cima = cima.Siguiente;

            return pedido;
        }
        public Pedido Peek()
        {
            if (EstaVacia())
                return null;

            return cima.Datos;
        }
        public int Contar()
        {
            int contador = 0;

            NodoPila aux = cima;

            while (aux != null)
            {
                contador++;

                aux = aux.Siguiente;
            }

            return contador;
        }
        public NodoPila ObtenerCima()
        {
            return cima;
        }
    }
}
