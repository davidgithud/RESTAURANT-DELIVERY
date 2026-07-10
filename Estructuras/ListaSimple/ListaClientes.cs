using RestaurantIngenieriaTrujillo.Entidades;
using System;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.ListaSimple
{
    /// <summary>
    /// Lista simple enlazada para gestionar clientes.
    /// Implementa operaciones de inserción, búsqueda, eliminación y modificación.
    /// También permite ordenamiento alfabético por nombre.
    /// </summary>
    internal class ListaClientes
    {
        private NodoCliente cabeza;

        public ListaClientes()
        {
            cabeza = null;
        }

        /// <summary>
        /// Inserta un nuevo cliente al final de la lista.
        /// </summary>
        public void Insertar(Cliente cliente)
        {
            NodoCliente nuevo = new NodoCliente(cliente);

            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                NodoCliente aux = cabeza;

                while (aux.Siguiente != null)
                {
                    aux = aux.Siguiente;
                }

                aux.Siguiente = nuevo;
            }
        }

        /// <summary>
        /// Busca un cliente por su código.
        /// Retorna null si no existe.
        /// </summary>
        public Cliente Buscar(int codigo)
        {
            NodoCliente aux = cabeza;

            while (aux != null)
            {
                if (aux.Datos.Codigo == codigo)
                    return aux.Datos;

                aux = aux.Siguiente;
            }

            return null;
        }

        /// <summary>
        /// Elimina un cliente por su código.
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

            NodoCliente anterior = cabeza;
            NodoCliente actual = cabeza.Siguiente;

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
        /// Modifica un cliente existente por su código.
        /// Retorna true si se modificó, false si no existe.
        /// </summary>
        public bool Modificar(Cliente cliente)
        {
            NodoCliente aux = cabeza;

            while (aux != null)
            {
                if (aux.Datos.Codigo == cliente.Codigo)
                {
                    aux.Datos = cliente;
                    return true;
                }

                aux = aux.Siguiente;
            }

            return false;
        }

        /// <summary>
        /// Retorna el primer nodo de la lista.
        /// </summary>
        public NodoCliente ObtenerCabeza()
        {
            return cabeza;
        }

        /// <summary>
        /// Ordena los clientes alfabéticamente por nombre usando algoritmo de burbuja.
        /// </summary>
        public void OrdenarPorNombre()
        {
            NodoCliente actual = cabeza;

            while (actual != null)
            {
                NodoCliente siguiente = actual.Siguiente;

                while (siguiente != null)
                {
                    if (string.Compare(actual.Datos.Nombre,
                                       siguiente.Datos.Nombre) > 0)
                    {
                        Cliente aux = actual.Datos;
                        actual.Datos = siguiente.Datos;
                        siguiente.Datos = aux;
                    }

                    siguiente = siguiente.Siguiente;
                }

                actual = actual.Siguiente;
            }
        }
    }

}
