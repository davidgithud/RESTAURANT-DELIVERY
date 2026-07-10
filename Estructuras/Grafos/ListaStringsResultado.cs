using System;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.Grafos
{
    // Nodo para lista simple de strings de resultado.
    // Se utiliza para retornar rutas y caminos encontrados en el grafo.
    internal class NodoStringResultado
    {
        internal string Datos { get; set; }
        internal NodoStringResultado Siguiente { get; set; }

        internal NodoStringResultado(string datos)
        {
            Datos = datos;
            Siguiente = null;
        }
    }

    // Lista simple auxiliar para retornar colecciones de strings.
    // Se utiliza para retornar rutas y descripciones de caminos del grafo.
    internal class ListaStringsResultado
    {
        private NodoStringResultado primero;

        internal ListaStringsResultado()
        {
            primero = null;
        }

        // Agrega un string al final de la lista de resultados.
        internal void Agregar(string datos)
        {
            NodoStringResultado nuevoNodo = new NodoStringResultado(datos);

            if (primero == null)
            {
                primero = nuevoNodo;
            }
            else
            {
                NodoStringResultado aux = primero;
                while (aux.Siguiente != null)
                {
                    aux = aux.Siguiente;
                }
                aux.Siguiente = nuevoNodo;
            }
        }

        // Retorna el primer string de la lista de resultados.
        internal NodoStringResultado ObtenerPrimero()
        {
            return primero;
        }

        // Cuenta la cantidad total de strings en los resultados.
        internal int Contar()
        {
            int contador = 0;
            NodoStringResultado aux = primero;
            while (aux != null)
            {
                contador++;
                aux = aux.Siguiente;
            }
            return contador;
        }

        // Verifica si hay strings en los resultados.
        internal bool EstaVacia()
        {
            return primero == null;
        }
    }
}
