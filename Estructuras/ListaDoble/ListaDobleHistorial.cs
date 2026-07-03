using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.ListaDoble
{
    internal class ListaDobleHistorial
    {
        private NodoHistorial primero;

        private NodoHistorial ultimo;

        public ListaDobleHistorial()
        {
            primero = null;

            ultimo = null;
        }
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
        }
        public NodoHistorial ObtenerPrimero()
        {
            return primero;
        }
        public NodoHistorial ObtenerUltimo()
        {
            return ultimo;
        }
        public List<HistorialEstado> RecorrerAdelante()
        {
            List<HistorialEstado> lista =
                new List<HistorialEstado>();

            NodoHistorial aux = primero;

            while (aux != null)
            {
                lista.Add(aux.Datos);

                aux = aux.Siguiente;
            }

            return lista;
        }
        public List<HistorialEstado> RecorrerAtras()
        {
            List<HistorialEstado> lista = new List<HistorialEstado>();

            NodoHistorial aux = ultimo;

            while (aux != null)
            {
                lista.Add(aux.Datos);

                aux = aux.Anterior;
            }

            return lista;

        }

    }
}
