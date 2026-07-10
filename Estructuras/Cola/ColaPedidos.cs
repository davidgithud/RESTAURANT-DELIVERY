using RestaurantIngenieriaTrujillo.Entidades;
using System;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.Cola
{
    /// <summary>
    /// Cola de pedidos con operaciones FIFO (First In First Out).
    /// Gestiona pedidos de prioridad normal en orden de llegada.
    /// </summary>
    internal class ColaPedidos
    {
        private NodoCola frente;
        private NodoCola fin;

        public ColaPedidos()
        {
            frente = null;
            fin = null;
        }

        /// <summary>
        /// Verifica si la cola está vacía.
        /// </summary>
        public bool EstaVacia()
        {
            return frente == null;
        }

        /// <summary>
        /// Encola un nuevo pedido al final.
        /// </summary>
        public void Encolar(Pedido pedido)
        {
            NodoCola nuevo = new NodoCola(pedido);

            if (EstaVacia())
            {
                frente = nuevo;
                fin = nuevo;
            }
            else
            {
                fin.Siguiente = nuevo;
                fin = nuevo;
            }
        }

        /// <summary>
        /// Desencola y retorna el pedido del frente.
        /// Retorna null si está vacía.
        /// </summary>
        public Pedido Desencolar()
        {
            if (EstaVacia())
                return null;

            Pedido pedido = frente.Datos;
            frente = frente.Siguiente;

            if (frente == null)
                fin = null;

            return pedido;
        }

        /// <summary>
        /// Retorna el pedido del frente sin removerlo.
        /// Retorna null si está vacía.
        /// </summary>
        public Pedido VerFrente()
        {
            if (EstaVacia())
                return null;

            return frente.Datos;
        }

        /// <summary>
        /// Cuenta la cantidad total de pedidos en la cola.
        /// </summary>
        public int Contar()
        {
            int contador = 0;
            NodoCola aux = frente;

            while (aux != null)
            {
                contador++;
                aux = aux.Siguiente;
            }

            return contador;
        }

        /// <summary>
        /// Retorna el nodo del frente de la cola.
        /// </summary>
        public NodoCola ObtenerFrente()
        {
            return frente;
        }

        /// <summary>
        /// Elimina un pedido específico de la cola por su código.
        /// Retorna true si se eliminó, false si no existe.
        /// </summary>
        public bool Eliminar(int codigoPedido)
        {
            if (EstaVacia())
                return false;

            if (frente.Datos.Codigo == codigoPedido)
            {
                frente = frente.Siguiente;
                if (frente == null)
                    fin = null;
                return true;
            }

            NodoCola anterior = frente;
            NodoCola actual = frente.Siguiente;

            while (actual != null)
            {
                if (actual.Datos.Codigo == codigoPedido)
                {
                    anterior.Siguiente = actual.Siguiente;
                    if (actual == fin)
                        fin = anterior;
                    return true;
                }
                anterior = actual;
                actual = actual.Siguiente;
            }

            return false;
        }
    }
}
