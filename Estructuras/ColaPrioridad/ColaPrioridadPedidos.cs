using RestaurantIngenieriaTrujillo.Entidades;
using RestaurantIngenieriaTrujillo.Estructuras.Cola;
using System;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.ColaPrioridad
{
    // Cola con prioridad que separa pedidos prioritarios de los normales.
    // Los pickeos prioritarios se atienden primero, manteniendo FIFO dentro de cada nivel.
    internal class ColaPrioridadPedidos
    {
        private NodoPrioridad frente;
        private ColaPedidos colaPrioritarios;
        private ColaPedidos colaNormal;

        public ColaPrioridadPedidos()
        {
            colaPrioritarios = new ColaPedidos();
            colaNormal = new ColaPedidos();
            frente = null;
        }

        // Verifica si ambas colas (prioritaria y normal) están vacías.
        public bool EstaVacia()
        {
            return colaPrioritarios.EstaVacia() && colaNormal.EstaVacia();
        }

        // Encola un pedido en la cola correspondiente según su prioridad.
        // Los prioritarios se insertan al frente, los normales al final.
        public void Encolar(Pedido pedido)
        {
            NodoPrioridad nuevo = new NodoPrioridad(pedido);

            if (frente == null)
            {
                frente = nuevo;
                return;
            }

            if (pedido.EsPrioritario)
                colaPrioritarios.Encolar(pedido);
            else
                colaNormal.Encolar(pedido);

            if (pedido.EsPrioritario)
            {
                nuevo.Siguiente = frente;
                frente = nuevo;
            }
            else
            {
                NodoPrioridad aux = frente;
                while (aux.Siguiente != null)
                {
                    aux = aux.Siguiente;
                }
                aux.Siguiente = nuevo;
            }
        }

        // Desencola un pedido: primero de la cola prioritaria, luego de la normal.
        public Pedido Desencolar()
        {
            if (!colaPrioritarios.EstaVacia())
                return colaPrioritarios.Desencolar();

            return colaNormal.Desencolar();
        }

        // Retorna el próximo pedido sin removerlo: prioritario si existe, sino normal.
        public Pedido VerFrente()
        {
            if (!colaPrioritarios.EstaVacia())
                return colaPrioritarios.VerFrente();

            return colaNormal.VerFrente();
        }

        // Cuenta la cantidad total de pedidos en ambas colas.
        public int Contar()
        {
            return colaPrioritarios.Contar() + colaNormal.Contar();
        }

        // Retorna el nodo del frente de la estructura.
        public NodoPrioridad ObtenerFrente()
        {
            return frente;
        }

        // Retorna la cola de pedidos prioritarios.
        public ColaPedidos ObtenerColaPrioritarios()
        {
            return colaPrioritarios;
        }

        // Retorna la cola de pedidos normales.
        public ColaPedidos ObtenerColaNormal()
        {
            return colaNormal;
        }

        // Elimina un pedido específico de cualquiera de las dos colas por su código.
        public bool Eliminar(int codigoPedido)
        {
            bool eliminado = false;

            // Intenta eliminar de colas prioritarias primero
            if (colaPrioritarios.Eliminar(codigoPedido))
            {
                eliminado = true;
            }
            else if (colaNormal.Eliminar(codigoPedido))
            {
                eliminado = true;
            }

            if (!eliminado)
                return false;

            // Elimina también del listado de nodos de prioridad
            if (frente == null)
                return true;

            if (frente.Datos.Codigo == codigoPedido)
            {
                frente = frente.Siguiente;
                return true;
            }

            NodoPrioridad anterior = frente;
            NodoPrioridad actual = frente.Siguiente;

            while (actual != null)
            {
                if (actual.Datos.Codigo == codigoPedido)
                {
                    anterior.Siguiente = actual.Siguiente;
                    return true;
                }

                anterior = actual;
                actual = actual.Siguiente;
            }

            return true;
        }
    }
}
