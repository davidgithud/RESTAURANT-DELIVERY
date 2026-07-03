using RestaurantIngenieriaTrujillo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.ListaSimple
{
    internal class ListaClientes
    {
        private NodoCliente cabeza;

        public ListaClientes()
        {
            cabeza = null;
        }
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
        public NodoCliente ObtenerCabeza()
        {
            return cabeza;
        }
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
