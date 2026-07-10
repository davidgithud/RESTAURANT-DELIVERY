using RestaurantIngenieriaTrujillo.Entidades;

namespace RestaurantIngenieriaTrujillo.Estructuras.Listas
{
    // Nodo para lista simple de pedidos de resultado.
    // Se utiliza al retornar colecciones de pedidos desde el árbol y otras estructuras.
    internal class NodoPedidoResultado
    {
        public Pedido Datos { get; set; }
        public NodoPedidoResultado Siguiente { get; set; }

        public NodoPedidoResultado(Pedido datos)
        {
            Datos = datos;
            Siguiente = null;
        }
    }

    // Lista simple auxiliar para retornar colecciones de pedidos.
    // Utilizada como estructura de resultado en recorridos del árbol y búsquedas.
    internal class ListaPedidosResultado
    {
        private NodoPedidoResultado primero;

        public ListaPedidosResultado()
        {
            primero = null;
        }

        // Agrega un pedido al final de la lista de resultados.
        public void Agregar(Pedido pedido)
        {
            NodoPedidoResultado nuevo = new NodoPedidoResultado(pedido);

            if (primero == null)
            {
                primero = nuevo;
                return;
            }

            NodoPedidoResultado aux = primero;
            while (aux.Siguiente != null)
            {
                aux = aux.Siguiente;
            }

            aux.Siguiente = nuevo;
        }

        // Retorna el primer pedido de la lista de resultados.
        public NodoPedidoResultado ObtenerPrimero()
        {
            return primero;
        }

        // Cuenta el total de pedidos en los resultados.
        public int Contar()
        {
            int contador = 0;
            NodoPedidoResultado aux = primero;

            while (aux != null)
            {
                contador++;
                aux = aux.Siguiente;
            }

            return contador;
        }

        // Verifica si hay pedidos en los resultados.
        public bool EstaVacia()
        {
            return primero == null;
        }
    }
}
