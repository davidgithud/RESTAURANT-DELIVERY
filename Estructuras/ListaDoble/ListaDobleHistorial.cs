using System;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.ListaDoble
{
    // Lista doble enlazada para gestionar el historial de cambios de estado de pedidos.
    internal class ListaDobleHistorial
    {
        private NodoHistorial primero;
        private NodoHistorial ultimo;
        private NodoHistorial punteroActual;

        public ListaDobleHistorial()
        {
            primero = null;
            ultimo = null;
            punteroActual = null;
        }

        // Se inserta nuevo cambio de estado al final de la lista.
        public void Insertar(HistorialEstado historial)
        {
            NodoHistorial nuevo = new NodoHistorial(historial);

            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Anterior = ultimo;
                ultimo = nuevo;
            }

            punteroActual = primero;
        }

        // Limpieza del historial.
        public void Limpiar()
        {
            primero = null;
            ultimo = null;
            punteroActual = null;
        }

        // Retorna el primer nodo del historial.
        public NodoHistorial ObtenerPrimero()
        {
            return primero;
        }

        // Retorna el último nodo del historial.
        public NodoHistorial ObtenerUltimo()
        {
            return ultimo;
        }

        // Recorre el historial desde el inicio hacia el final.
        // Retorna una lista con todos los registros en orden cronológico.
        public ListaHistorialEstado RecorrerAdelante()
        {
            ListaHistorialEstado lista = new ListaHistorialEstado();
            NodoHistorial aux = primero;

            while (aux != null)
            {
                lista.Agregar(aux.Datos);
                aux = aux.Siguiente;
            }

            return lista;
        }

        // Recorre el historial desde el final hacia el inicio.
        // Retorna una lista con todos los registros en orden inverso.
        public ListaHistorialEstado RecorrerAtras()
        {
            ListaHistorialEstado lista = new ListaHistorialEstado();
            NodoHistorial aux = ultimo;

            while (aux != null)
            {
                lista.Agregar(aux.Datos);
                aux = aux.Anterior;
            }

            return lista;
        }
    }
}
