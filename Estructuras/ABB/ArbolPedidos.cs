using RestaurantIngenieriaTrujillo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.ABB
{
    internal class ArbolPedidos
    {
        private NodoABB raiz;

        public ArbolPedidos()
        {
            raiz = null;
        }
        public void Insertar(Pedido pedido)
        {
            raiz = InsertarRecursivo(raiz, pedido);
        }
        private NodoABB InsertarRecursivo(
    NodoABB nodo,
    Pedido pedido)
        {
            if (nodo == null)
                return new NodoABB(pedido);

            if (pedido.Codigo < nodo.Datos.Codigo)
            {
                nodo.Izquierdo =
                    InsertarRecursivo(
                        nodo.Izquierdo,
                        pedido);
            }
            else if (pedido.Codigo > nodo.Datos.Codigo)
            {
                nodo.Derecho =
                    InsertarRecursivo(
                        nodo.Derecho,
                        pedido);
            }

            return nodo;
        }
        public Pedido Buscar(int codigo)
        {
            return BuscarRecursivo(raiz, codigo);
        }
        private Pedido BuscarRecursivo(NodoABB nodo,int codigo)
        {
            if (nodo == null)
                return null;

            if (codigo == nodo.Datos.Codigo)
                return nodo.Datos;

            if (codigo < nodo.Datos.Codigo)
                return BuscarRecursivo(
                    nodo.Izquierdo,
                    codigo);

            return BuscarRecursivo(nodo.Derecho,codigo);
        }
        public bool Existe(int codigo)
        {
            return Buscar(codigo) != null;
        }
        public List<Pedido> InOrden()
        {
            List<Pedido> lista = new List<Pedido>();

            InOrdenRecursivo(raiz, lista);

            return lista;
        }
        private void InOrdenRecursivo(NodoABB nodo,List<Pedido> lista)
        {
            if (nodo != null)
            {
                InOrdenRecursivo(
                    nodo.Izquierdo,
                    lista);

                lista.Add(nodo.Datos);

                InOrdenRecursivo(
                    nodo.Derecho,
                    lista);
            }
        }
        public List<Pedido> PreOrden()
        {
            List<Pedido> lista = new List<Pedido>();

            PreOrdenRecursivo(raiz, lista);

            return lista;
        }
        private void PreOrdenRecursivo(NodoABB nodo, List<Pedido> lista)
        {
            if (nodo != null)
            {
                lista.Add(nodo.Datos);

                PreOrdenRecursivo(
                    nodo.Izquierdo,
                    lista);

                PreOrdenRecursivo(
                    nodo.Derecho,
                    lista);
            }
        }
        public List<Pedido> PostOrden()
        {
            List<Pedido> lista = new List<Pedido>();

            PostOrdenRecursivo(raiz, lista);

            return lista;
        }
        private void PostOrdenRecursivo(NodoABB nodo,List<Pedido> lista)
        {
            if (nodo != null)
            {
                PostOrdenRecursivo(
                    nodo.Izquierdo,
                    lista);

                PostOrdenRecursivo(
                    nodo.Derecho,
                    lista);

                lista.Add(nodo.Datos);
            }
        }
        public int Contar()
        {
            return ContarRecursivo(raiz);
        }
        private int ContarRecursivo(NodoABB nodo)
        {
            if (nodo == null)
                return 0;

            return 1
                 + ContarRecursivo(nodo.Izquierdo)
                 + ContarRecursivo(nodo.Derecho);
        }
        public List<Pedido> BuscarPorRango(int minimo, int maximo)
        {
            List<Pedido> lista = new List<Pedido>();

            BuscarPorRangoRecursivo(raiz, minimo, maximo, lista);

            return lista;
        }
        private void BuscarPorRangoRecursivo(NodoABB nodo, int minimo,int maximo, List<Pedido> lista)
        {
            if (nodo == null)
                return;

            if (nodo.Datos.Codigo > minimo)
            {
                BuscarPorRangoRecursivo(
                    nodo.Izquierdo,
                    minimo,
                    maximo,
                    lista);
            }

            if (nodo.Datos.Codigo >= minimo &&
                nodo.Datos.Codigo <= maximo)
            {
                lista.Add(nodo.Datos);
            }

            if (nodo.Datos.Codigo < maximo)
            {
                BuscarPorRangoRecursivo(
                    nodo.Derecho,
                    minimo,
                    maximo,
                    lista);
            }
        }

    }
}
