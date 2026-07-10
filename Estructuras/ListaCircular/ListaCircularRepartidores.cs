using RestaurantIngenieriaTrujillo.Entidades;
using System;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.ListaCircular
{
    // Lista circular enlazada de repartidores.
    // El último nodo apunta al primero, permitiendo rotación cíclica para asignación equitativa de pedidos.
    internal class ListaCircularRepartidores
    {
        private NodoRepartidor ultimo;
        private NodoRepartidor actual;

        public ListaCircularRepartidores()
        {
            ultimo = null;
            actual = null;
        }

        // Inserta un nuevo repartidor al final de la lista manteniendo la circularidad.
        public void Insertar(Repartidor repartidor)
        {
            NodoRepartidor nuevo = new NodoRepartidor(repartidor);

            if (ultimo == null)
            {
                ultimo = nuevo;
                ultimo.Siguiente = ultimo;
                actual = nuevo;
            }
            else
            {
                nuevo.Siguiente = ultimo.Siguiente;
                ultimo.Siguiente = nuevo;
                ultimo = nuevo;
            }
        }

        // Retorna el primer repartidor de la lista circular.
        public NodoRepartidor ObtenerPrimero()
        {
            if (ultimo == null)
                return null;

            return ultimo.Siguiente;
        }

        // Busca un repartidor por su código recorriendo la lista circular.
        public Repartidor Buscar(int codigo)
        {
            if (ultimo == null)
                return null;

            NodoRepartidor aux = ultimo.Siguiente;

            do
            {
                if (aux.Datos.Codigo == codigo)
                    return aux.Datos;

                aux = aux.Siguiente;

            } while (aux != ultimo.Siguiente);

            return null;
        }

        // Modifica un repartidor existente por su código.
        public bool Modificar(Repartidor repartidor)
        {
            if (ultimo == null)
                return false;

            NodoRepartidor aux = ultimo.Siguiente;

            do
            {
                if (aux.Datos.Codigo == repartidor.Codigo)
                {
                    aux.Datos = repartidor;
                    return true;
                }

                aux = aux.Siguiente;

            } while (aux != ultimo.Siguiente);

            return false;
        }

        // Elimina un repartidor por su código manteniendo la circularidad.
        // Maneja casos: un único nodo, eliminar el último, eliminar otros.
        public bool Eliminar(int codigo)
        {
            if (ultimo == null)
                return false;

            NodoRepartidor actual = ultimo.Siguiente;
            NodoRepartidor anterior = ultimo;

            do
            {
                if (actual.Datos.Codigo == codigo)
                {
                    // Caso 1: Solo existe un nodo
                    if (actual == ultimo && actual == ultimo.Siguiente)
                    {
                        ultimo = null;
                    }
                    // Caso 2: Eliminar el último
                    else if (actual == ultimo)
                    {
                        anterior.Siguiente = actual.Siguiente;
                        ultimo = anterior;
                    }
                    // Caso 3: Eliminar cualquier otro
                    else
                    {
                        anterior.Siguiente = actual.Siguiente;
                    }

                    return true;
                }

                anterior = actual;
                actual = actual.Siguiente;

            } while (actual != ultimo.Siguiente);

            return false;
        }

        // Obtiene el siguiente repartidor disponible con rotación.
        // Solo retorna repartidores con disponibilidad y menos de 3 pedidos asignados.
        public Repartidor ObtenerSiguienteRepartidor()
        {
            if (actual == null)
                return null;

            int contador = 0;
            NodoRepartidor temp = actual;
            do
            {
                // Solo repartidores disponibles con menos de 3 pedidos
                if (temp.Datos.Disponible && temp.Datos.PedidosAsignados < 3)
                {
                    Repartidor r = temp.Datos;
                    actual = temp.Siguiente;
                    return r;
                }
                temp = temp.Siguiente;
                contador++;
            } while (temp != actual && contador < 1000);

            return null; // Ninguno disponible
        }

        public bool Disponible { get; set; }

        // Retorna todos los repartidores en una lista de resultado.
        public ListaRepartidoresResultado ObtenerTodos()
        {
            ListaRepartidoresResultado lista = new ListaRepartidoresResultado();

            if (ultimo == null)
                return lista;

            NodoRepartidor aux = ultimo.Siguiente;

            do
            {
                lista.Agregar(aux.Datos);
                aux = aux.Siguiente;

            } while (aux != ultimo.Siguiente);

            return lista;
        }
    }
}
