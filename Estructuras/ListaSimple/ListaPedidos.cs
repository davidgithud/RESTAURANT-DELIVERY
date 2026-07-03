using RestaurantIngenieriaTrujillo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.ListaSimple
{
    internal class ListaPedidos
    {
        private NodoPedido cabeza;

        public ListaPedidos()
        {
            cabeza = null;
        }
        public void Insertar(Pedido pedido)
        {
            NodoPedido nuevo = new NodoPedido(pedido);

            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                NodoPedido aux = cabeza;

                while (aux.Siguiente != null)
                {
                    aux = aux.Siguiente;
                }

                aux.Siguiente = nuevo;
            }

        }
        public NodoPedido ObtenerCabeza()
        {
            return cabeza;
        }
        public Pedido Buscar(int codigo)
        {
            NodoPedido aux = cabeza;

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

            // Si el primer nodo es el que se eliminará
            if (cabeza.Datos.Codigo == codigo)
            {
                cabeza = cabeza.Siguiente;
                return true;
            }

            NodoPedido anterior = cabeza;
            NodoPedido actual = cabeza.Siguiente;

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
        public bool Modificar(Pedido pedidoModificado)
        {
            NodoPedido aux = cabeza;

            while (aux != null)
            {
                if (aux.Datos.Codigo == pedidoModificado.Codigo)
                {
                    aux.Datos = pedidoModificado;
                    return true;
                }

                aux = aux.Siguiente;
            }

            return false;
        }
        public void OrdenarPorCodigo()
        {
            if (cabeza == null)
                return;

            NodoPedido actual = cabeza;

            while (actual != null)
            {
                NodoPedido siguiente = actual.Siguiente;

                while (siguiente != null)
                {
                    if (actual.Datos.Codigo > siguiente.Datos.Codigo)
                    {
                        Pedido aux = actual.Datos;
                        actual.Datos = siguiente.Datos;
                        siguiente.Datos = aux;
                    }

                    siguiente = siguiente.Siguiente;
                }

                actual = actual.Siguiente;
            }
        }
        public void Mezclar(ListaPedidos otraLista)
        {
            NodoPedido aux = otraLista.ObtenerCabeza();

            while (aux != null)
            {
                Insertar(aux.Datos);
                aux = aux.Siguiente;
            }
        }
    }
}
