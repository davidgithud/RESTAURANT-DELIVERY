using RestaurantIngenieriaTrujillo.Entidades;
using System;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.ListaSimple
{
    /// <summary>
    /// Lista simple enlazada para gestionar pedidos.
    /// Implementa operaciones de inserción, búsqueda, eliminación y modificación.
    /// Permite ordenamiento por código y mezcla de listas.
    /// </summary>
    internal class ListaPedidos
    {
        private NodoPedido cabeza;

        public ListaPedidos()
        {
            cabeza = null;
        }

        /// <summary>
        /// Inserta un nuevo pedido al final de la lista.
        /// </summary>
        public void Insertar(Pedido pedido)
        {
            NodoPedido nuevo = new NodoPedido(pedido);

            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                NodoPedido aux = cabeza;

                while (aux.Siguiente != null)
                {
                    aux = aux.Siguiente;
                }

                aux.Siguiente = nuevo;
            }
        }

        /// <summary>
        /// Retorna el primer nodo de la lista.
        /// </summary>
        public NodoPedido ObtenerCabeza()
        {
            return cabeza;
        }

        /// <summary>
        /// Busca un pedido por su código.
        /// Retorna null si no existe.
        /// </summary>
        public Pedido Buscar(int codigo)
        {
            NodoPedido aux = cabeza;

            while (aux != null)
            {
                if (aux.Datos.Codigo == codigo)
                    return aux.Datos;

                aux = aux.Siguiente;
            }

            return null;
        }

        /// <summary>
        /// Elimina un pedido por su código.
        /// Retorna true si se eliminó correctamente, false de lo contrario.
        /// </summary>
        public bool Eliminar(int codigo)
        {
            if (cabeza == null)
                return false;

            if (cabeza.Datos.Codigo == codigo)
            {
                cabeza = cabeza.Siguiente;
                return true;
            }

            NodoPedido anterior = cabeza;
            NodoPedido actual = cabeza.Siguiente;

            while (actual != null)
            {
                if (actual.Datos.Codigo == codigo)
                {
                    anterior.Siguiente = actual.Siguiente;
                    return true;
                }

                anterior = actual;
                actual = actual.Siguiente;
            }

            return false;
        }

        /// <summary>
        /// Modifica un pedido existente por su código.
        /// Retorna true si se modificó, false si no existe.
        /// </summary>
        public bool Modificar(Pedido pedidoModificado)
        {
            NodoPedido aux = cabeza;

            while (aux != null)
            {
                if (aux.Datos.Codigo == pedidoModificado.Codigo)
                {
                    aux.Datos = pedidoModificado;
                    return true;
                }

                aux = aux.Siguiente;
            }

            return false;
        }

        /// <summary>
        /// Ordena los pedidos por código en orden ascendente usando algoritmo de burbuja.
        /// </summary>
        public void OrdenarPorCodigo()
        {
            if (cabeza == null)
                return;

            NodoPedido actual = cabeza;

            while (actual != null)
            {
                NodoPedido siguiente = actual.Siguiente;

                while (siguiente != null)
                {
                    if (actual.Datos.Codigo > siguiente.Datos.Codigo)
                    {
                        Pedido aux = actual.Datos;
                        actual.Datos = siguiente.Datos;
                        siguiente.Datos = aux;
                    }

                    siguiente = siguiente.Siguiente;
                }

                actual = actual.Siguiente;
            }
        }

        /// <summary>
        /// Mezcla todos los pedidos de otra lista al final de esta lista.
        /// </summary>
        public void Mezclar(ListaPedidos otraLista)
        {
            NodoPedido aux = otraLista.ObtenerCabeza();

            while (aux != null)
            {
                Insertar(aux.Datos);
                aux = aux.Siguiente;
            }
        }
    }
}
