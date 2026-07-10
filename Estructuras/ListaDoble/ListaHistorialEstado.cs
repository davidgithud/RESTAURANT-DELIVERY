using System;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.ListaDoble
{
    // Nodo para la lista simple de historial de estado.
    // Contiene datos de un evento de cambio de estado y referencia al siguiente nodo.
    internal class NodoListaHistorialEstado
    {
        internal HistorialEstado Datos { get; set; }
        internal NodoListaHistorialEstado Siguiente { get; set; }

        internal NodoListaHistorialEstado(HistorialEstado datos)
        {
            Datos = datos;
            Siguiente = null;
        }
    }

    // Lista simple auxiliar para almacenar resultados de recorridos del historial.
    // Se utiliza al recuperar datos del historial desde la lista doble.
    internal class ListaHistorialEstado
    {
        private NodoListaHistorialEstado primero;

        internal ListaHistorialEstado()
        {
            primero = null;
        }

        // Agrega un nuevo registro de historial al final de la lista.
        internal void Agregar(HistorialEstado datos)
        {
            NodoListaHistorialEstado nuevoNodo = new NodoListaHistorialEstado(datos);

            if (primero == null)
            {
                primero = nuevoNodo;
            }
            else
            {
                NodoListaHistorialEstado aux = primero;
                while (aux.Siguiente != null)
                {
                    aux = aux.Siguiente;
                }
                aux.Siguiente = nuevoNodo;
            }
        }

        // Retorna el primer nodo de la lista de resultados.
        internal NodoListaHistorialEstado ObtenerPrimero()
        {
            return primero;
        }

        // Cuenta la cantidad total de registros en la lista.
        internal int Contar()
        {
            int contador = 0;
            NodoListaHistorialEstado aux = primero;
            while (aux != null)
            {
                contador++;
                aux = aux.Siguiente;
            }
            return contador;
        }

        // Verifica si la lista está vacía.
        internal bool EstaVacia()
        {
            return primero == null;
        }
    }
}
