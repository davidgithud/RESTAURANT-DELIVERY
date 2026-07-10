using RestaurantIngenieriaTrujillo.Entidades;
using System;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.ListaCircular
{
    // Nodo para lista simple de repartidores de resultado.
    // Se utiliza al retornar colecciones de repartidores desde la lista circular.
    internal class NodoRepartidorResultado
    {
        internal Repartidor Datos { get; set; }
        internal NodoRepartidorResultado Siguiente { get; set; }

        internal NodoRepartidorResultado(Repartidor datos)
        {
            Datos = datos;
            Siguiente = null;
        }
    }

    // Lista simple auxiliar para retornar colecciones de repartidores.
    // Se utiliza en operaciones de obtención de datos desde la lista circular.
    internal class ListaRepartidoresResultado
    {
        private NodoRepartidorResultado primero;

        internal ListaRepartidoresResultado()
        {
            primero = null;
        }

        // Agrega un repartidor al final de la lista de resultados.
        internal void Agregar(Repartidor datos)
        {
            NodoRepartidorResultado nuevoNodo = new NodoRepartidorResultado(datos);

            if (primero == null)
            {
                primero = nuevoNodo;
            }
            else
            {
                NodoRepartidorResultado aux = primero;
                while (aux.Siguiente != null)
                {
                    aux = aux.Siguiente;
                }
                aux.Siguiente = nuevoNodo;
            }
        }

        // Retorna el primer repartidor de la lista de resultados.
        internal NodoRepartidorResultado ObtenerPrimero()
        {
            return primero;
        }

        // Cuenta el total de repartidores en los resultados.
        internal int Contar()
        {
            int contador = 0;
            NodoRepartidorResultado aux = primero;
            while (aux != null)
            {
                contador++;
                aux = aux.Siguiente;
            }
            return contador;
        }

        // Verifica si hay repartidores en los resultados.
        internal bool EstaVacia()
        {
            return primero == null;
        }
    }
}
