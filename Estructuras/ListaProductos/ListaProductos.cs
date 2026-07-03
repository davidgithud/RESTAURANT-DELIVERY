using RestaurantIngenieriaTrujillo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.ListaProductos
{
    internal class ListaProductos
    {
        private NodoProducto primero;

        public ListaProductos()
        {
            primero = null;
        }

        public bool EstaVacia()
        {
            return primero == null;
        }

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

        public List<Producto> ObtenerTodos()
        {
            List<Producto> lista = new List<Producto>();

            NodoProducto aux = primero;

            while (aux != null)
            {
                lista.Add(aux.Datos);
                aux = aux.Siguiente;
            }

            return lista;
        }

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
        public NodoProducto ObtenerPrimero()
        {
            return primero;
        }
    }

}
