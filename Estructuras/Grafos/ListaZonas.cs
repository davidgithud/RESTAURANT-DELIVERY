using RestaurantIngenieriaTrujillo.Entidades;

namespace RestaurantIngenieriaTrujillo.Estructuras.Grafos
{
    // Nodo para lista simple de zonas del grafo.
    // Almacena una zona con referencia al siguiente nodo.
    internal class NodoZona
    {
        public Zona Datos { get; set; }
        public NodoZona Siguiente { get; set; }

        public NodoZona(Zona datos)
        {
            Datos = datos;
            Siguiente = null;
        }
    }

    // Lista simple de zonas del grafo de rutas.
    // Se utiliza para recorridos y búsquedas en el grafo.
    internal class ListaZonas
    {
        private NodoZona primero;

        public ListaZonas()
        {
            primero = null;
        }

        // Agrega una zona al final de la lista.
        public void Agregar(Zona zona)
        {
            NodoZona nuevo = new NodoZona(zona);

            if (primero == null)
            {
                primero = nuevo;
                return;
            }

            NodoZona aux = primero;
            while (aux.Siguiente != null)
            {
                aux = aux.Siguiente;
            }

            aux.Siguiente = nuevo;
        }

        // Retorna el primer nodo de la lista de zonas.
        public NodoZona ObtenerPrimero()
        {
            return primero;
        }

        // Cuenta la cantidad total de zonas.
        public int Contar()
        {
            int contador = 0;
            NodoZona aux = primero;

            while (aux != null)
            {
                contador++;
                aux = aux.Siguiente;
            }

            return contador;
        }

        // Verifica si hay zonas en la lista.
        public bool EstaVacia()
        {
            return primero == null;
        }
    }
}
