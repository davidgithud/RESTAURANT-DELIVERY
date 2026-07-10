using RestaurantIngenieriaTrujillo.Entidades;
using System;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.ListaProductos
{
    // Nodo para lista simple de productos de resultado.
    // Se utiliza cuando se retornan productos desde la lista principal.
    internal class NodoProductoResultado
    {
        internal Producto Datos { get; set; }
        internal NodoProductoResultado Siguiente { get; set; }

        internal NodoProductoResultado(Producto datos)
        {
            Datos = datos;
            Siguiente = null;
        }
    }

    // Lista simple auxiliar para retornar colecciones de productos.
    // Utilizada como estructura de resultado en métodos de búsqueda y filtrado.
    internal class ListaProductosResultado
    {
        private NodoProductoResultado primero;

        internal ListaProductosResultado()
        {
            primero = null;
        }

        // Agrega un producto al final de la lista de resultados.
        internal void Agregar(Producto datos)
        {
            NodoProductoResultado nuevoNodo = new NodoProductoResultado(datos);

            if (primero == null)
            {
                primero = nuevoNodo;
            }
            else
            {
                NodoProductoResultado aux = primero;
                while (aux.Siguiente != null)
                {
                    aux = aux.Siguiente;
                }
                aux.Siguiente = nuevoNodo;
            }
        }

        // Retorna el primer producto de la lista de resultados.
        internal NodoProductoResultado ObtenerPrimero()
        {
            return primero;
        }

        // Cuenta el total de productos en los resultados.
        internal int Contar()
        {
            int contador = 0;
            NodoProductoResultado aux = primero;
            while (aux != null)
            {
                contador++;
                aux = aux.Siguiente;
            }
            return contador;
        }

        // Verifica si hay productos en los resultados.
        internal bool EstaVacia()
        {
            return primero == null;
        }
    }
}
