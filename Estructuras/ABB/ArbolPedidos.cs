using RestaurantIngenieriaTrujillo.Entidades;
using RestaurantIngenieriaTrujillo.Estructuras.Listas;
using System;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.ABB
{
    // Árbol Binario de Búsqueda (ABB) para gestionar pedidos ordenados por código.
    // Permite inserción, búsqueda y recorridos eficientes de pedidos.
    internal class ArbolPedidos
    {
        private NodoABB raiz;

        public ArbolPedidos()
        {
            raiz = null;
        }

        // Inserta un nuevo pedido en el árbol manteniendo la propiedad BST.
        public void Insertar(Pedido pedido)
        {
            raiz = InsertarRecursivo(raiz, pedido);
        }

        // Método recursivo para inserción.
        // Compara el código del pedido para decidir si ir a izquierda o derecha.
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

        // Busca un pedido por su código.
        // Retorna el pedido si existe, null en caso contrario.
        public Pedido Buscar(int codigo)
        {
            return BuscarRecursivo(raiz, codigo);
        }

        // Método recursivo para búsqueda.
        private Pedido BuscarRecursivo(NodoABB nodo, int codigo)
        {
            if (nodo == null)
                return null;

            if (codigo == nodo.Datos.Codigo)
                return nodo.Datos;

            if (codigo < nodo.Datos.Codigo)
                return BuscarRecursivo(
                    nodo.Izquierdo,
                    codigo);

            return BuscarRecursivo(nodo.Derecho, codigo);
        }

        // Verifica si existe un pedido con el código especificado.
        public bool Existe(int codigo)
        {
            return Buscar(codigo) != null;
        }

        // Realiza un recorrido inorden (izquierda-raíz-derecha).
        // Retorna lista de pedidos ordenados por código.
        public ListaPedidosResultado InOrden()
        {
            ListaPedidosResultado lista = new ListaPedidosResultado();
            InOrdenRecursivo(raiz, lista);
            return lista;
        }

        // Método recursivo para recorrido en orden.
        private void InOrdenRecursivo(NodoABB nodo, ListaPedidosResultado lista)
        {
            if (nodo != null)
            {
                InOrdenRecursivo(nodo.Izquierdo, lista);
                lista.Agregar(nodo.Datos);
                InOrdenRecursivo(
                    nodo.Derecho,
                    lista);
            }
        }

        // Realiza un recorrido preorden (raíz-izquierda-derecha).
        public ListaPedidosResultado PreOrden()
        {
            ListaPedidosResultado lista = new ListaPedidosResultado();
            PreOrdenRecursivo(raiz, lista);
            return lista;
        }

        // Método recursivo para recorrido preorden.
        private void PreOrdenRecursivo(NodoABB nodo, ListaPedidosResultado lista)
        {
            if (nodo != null)
            {
                lista.Agregar(nodo.Datos);
                PreOrdenRecursivo(
                    nodo.Izquierdo,
                    lista);
                PreOrdenRecursivo(
                    nodo.Derecho,
                    lista);
            }
        }

        // Realiza un recorrido postorden (izquierda-derecha-raíz).
        public ListaPedidosResultado PostOrden()
        {
            ListaPedidosResultado lista = new ListaPedidosResultado();
            PostOrdenRecursivo(raiz, lista);
            return lista;
        }

        // Método recursivo para recorrido postorden.
        private void PostOrdenRecursivo(NodoABB nodo, ListaPedidosResultado lista)
        {
            if (nodo != null)
            {
                PostOrdenRecursivo(
                    nodo.Izquierdo,
                    lista);
                PostOrdenRecursivo(
                    nodo.Derecho,
                    lista);
                lista.Agregar(nodo.Datos);
            }
        }

        // Cuenta la cantidad total de pedidos en el árbol.
        public int Contar()
        {
            return ContarRecursivo(raiz);
        }

        // Método recursivo para contar nodos.
        private int ContarRecursivo(NodoABB nodo)
        {
            if (nodo == null)
                return 0;

            return 1
                 + ContarRecursivo(nodo.Izquierdo)
                 + ContarRecursivo(nodo.Derecho);
        }

        // Busca pedidos dentro de un rango de códigos.
        // Retorna lista de pedidos con código entre mínimo y máximo.
        public ListaPedidosResultado BuscarPorRango(int minimo, int maximo)
        {
            ListaPedidosResultado lista = new ListaPedidosResultado();
            BuscarPorRangoRecursivo(raiz, minimo, maximo, lista);
            return lista;
        }

        // Método recursivo para búsqueda por rango.
        private void BuscarPorRangoRecursivo(NodoABB nodo, int minimo, int maximo, ListaPedidosResultado lista)
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
                lista.Agregar(nodo.Datos);
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

        // Elimina un pedido del árbol por su código.
        // Reorganiza el árbol manteniendo la propiedad BST.
        public bool Eliminar(int codigo)
        {
            raiz = EliminarRecursivo(raiz, codigo);
            return true;
        }

        // Método recursivo para eliminación.
        // Maneja tres casos: hoja, un hijo, dos hijos.
        private NodoABB EliminarRecursivo(NodoABB nodo, int codigo)
        {
            if (nodo == null)
                return null;

            if (codigo < nodo.Datos.Codigo)
            {
                nodo.Izquierdo = EliminarRecursivo(nodo.Izquierdo, codigo);
            }
            else if (codigo > nodo.Datos.Codigo)
            {
                nodo.Derecho = EliminarRecursivo(nodo.Derecho, codigo);
            }
            else
            {
                // Nodo encontrado - eliminar
                // Caso 1: Sin hijos (hoja)
                if (nodo.Izquierdo == null && nodo.Derecho == null)
                    return null;

                // Caso 2: Un único hijo
                if (nodo.Izquierdo == null)
                    return nodo.Derecho;
                if (nodo.Derecho == null)
                    return nodo.Izquierdo;

                // Caso 3: Dos hijos
                // Encontrar el mínimo en el subárbol derecho (sucesor)
                NodoABB minDerecho = ObtenerMinimo(nodo.Derecho);
                nodo.Datos = minDerecho.Datos;
                nodo.Derecho = EliminarRecursivo(nodo.Derecho, minDerecho.Datos.Codigo);
            }

            return nodo;
        }

        // Obtiene el nodo con el valor mínimo en un subárbol.
        private NodoABB ObtenerMinimo(NodoABB nodo)
        {
            while (nodo.Izquierdo != null)
                nodo = nodo.Izquierdo;
            return nodo;
        }
    }
}
