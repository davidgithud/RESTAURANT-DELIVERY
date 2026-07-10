using RestaurantIngenieriaTrujillo.Entidades;
using System;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.ListaProductos
{
    /// <summary>
    /// Lista simple de productos del menú del restaurante.
    /// Implementa operaciones de inserción, búsqueda, eliminación y modificación.
    /// Permite ordenamiento por nombre y obtención de todos los productos.
    /// </summary>
    internal class ListaProductos
    {
        private NodoProducto primero;

        public ListaProductos()
        {
            primero = null;
        }

        /// <summary>
        /// Verifica si la lista está vacía.
        /// </summary>
        public bool EstaVacia()
        {
            return primero == null;
        }

        /// <summary>
        /// Inserta un nuevo producto al final de la lista.
        /// </summary>
        public void Insertar(Producto producto)
        {
            NodoProducto nuevo = new NodoProducto(producto);

            if (primero == null)
            {
                primero = nuevo;
                return;
            }

            NodoProducto aux = primero;

            while (aux.Siguiente != null)
            {
                aux = aux.Siguiente;
            }

            aux.Siguiente = nuevo;
        }

        /// <summary>
        /// Busca un producto por su código.
        /// Retorna null si no existe.
        /// </summary>
        public Producto Buscar(int codigo)
        {
            NodoProducto aux = primero;

            while (aux != null)
            {
                if (aux.Datos.Codigo == codigo)
                    return aux.Datos;

                aux = aux.Siguiente;
            }

            return null;
        }

        /// <summary>
        /// Elimina un producto por su código.
        /// Retorna true si se eliminó correctamente, false de lo contrario.
        /// </summary>
        public bool Eliminar(int codigo)
        {
            if (primero == null)
                return false;

            if (primero.Datos.Codigo == codigo)
            {
                primero = primero.Siguiente;
                return true;
            }

            NodoProducto anterior = primero;
            NodoProducto actual = primero.Siguiente;

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
        /// Retorna todos los productos en una lista de resultado.
        /// </summary>
        public ListaProductosResultado ObtenerTodos()
        {
            ListaProductosResultado lista = new ListaProductosResultado();

            NodoProducto aux = primero;

            while (aux != null)
            {
                lista.Agregar(aux.Datos);
                aux = aux.Siguiente;
            }

            return lista;
        }

        /// <summary>
        /// Cuenta la cantidad total de productos en la lista.
        /// </summary>
        public int Contar()
        {
            int contador = 0;

            NodoProducto aux = primero;

            while (aux != null)
            {
                contador++;
                aux = aux.Siguiente;
            }

            return contador;
        }

        /// <summary>
        /// Modifica un producto existente por su código.
        /// Retorna true si se modificó, false si no existe.
        /// </summary>
        public bool Modificar(Producto producto)
        {
            NodoProducto aux = primero;

            while (aux != null)
            {
                if (aux.Datos.Codigo == producto.Codigo)
                {
                    aux.Datos = producto;
                    return true;
                }

                aux = aux.Siguiente;
            }

            return false;
        }

        /// <summary>
        /// Ordena los productos alfabéticamente por nombre usando algoritmo de burbuja.
        /// </summary>
        public void OrdenarPorNombre()
        {
            if (primero == null)
                return;

            NodoProducto actual = primero;

            while (actual != null)
            {
                NodoProducto siguiente = actual.Siguiente;

                while (siguiente != null)
                {
                    if (string.Compare(actual.Datos.Nombre,
                                       siguiente.Datos.Nombre) > 0)
                    {
                        Producto aux = actual.Datos;
                        actual.Datos = siguiente.Datos;
                        siguiente.Datos = aux;
                    }

                    siguiente = siguiente.Siguiente;
                }

                actual = actual.Siguiente;
            }
        }

        /// <summary>
        /// Retorna el primer nodo de la lista.
        /// </summary>
        public NodoProducto ObtenerPrimero()
        {
            return primero;
        }
    }

}
