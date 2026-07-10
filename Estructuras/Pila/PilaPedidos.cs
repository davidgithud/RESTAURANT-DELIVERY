using RestaurantIngenieriaTrujillo.Entidades;
using System;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.Pila
{
    /// <summary>
    /// Pila de pedidos con operaciones LIFO (Last In First Out).
    /// Registra el historial de cambios realizados en pedidos.
    /// </summary>
    internal class PilaPedidos
    {
        private NodoPila cima;

        public PilaPedidos()
        {
            cima = null;
        }

        /// <summary>
        /// Verifica si la pila está vacía.
        /// </summary>
        public bool EstaVacia()
        {
            return cima == null;
        }

        /// <summary>
        /// Inserta un pedido en la cima de la pila.
        /// </summary>
        public void Push(Pedido pedido)
        {
            NodoPila nuevo = new NodoPila(pedido);
            nuevo.Siguiente = cima;
            cima = nuevo;
        }

        /// <summary>
        /// Extrae y retorna el pedido de la cima.
        /// Retorna null si está vacía.
        /// </summary>
        public Pedido Pop()
        {
            if (EstaVacia())
                return null;

            Pedido pedido = cima.Datos;
            cima = cima.Siguiente;

            return pedido;
        }

        /// <summary>
        /// Retorna el pedido de la cima sin removerlo.
        /// Retorna null si está vacía.
        /// </summary>
        public Pedido Peek()
        {
            if (EstaVacia())
                return null;

            return cima.Datos;
        }

        /// <summary>
        /// Cuenta la cantidad total de pedidos en la pila.
        /// </summary>
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

        /// <summary>
        /// Retorna el nodo de la cima de la pila.
        /// </summary>
        public NodoPila ObtenerCima()
        {
            return cima;
        }
    }
}
