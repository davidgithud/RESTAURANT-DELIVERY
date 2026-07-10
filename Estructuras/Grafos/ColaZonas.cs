namespace RestaurantIngenieriaTrujillo.Estructuras.Grafos
{
    // Nodo para la cola de zonas utilizada en el recorrido BFS del grafo.
    // Almacena el índice de una zona para procesar en el grafo de rutas.
    internal class NodoColaZona
    {
        public int Indice { get; set; }
        public NodoColaZona Siguiente { get; set; }

        public NodoColaZona(int indice)
        {
            Indice = indice;
            Siguiente = null;
        }
    }

    // Cola FIFO de zonas para el recorrido BFS (Breadth First Search) del grafo.
    // Utilizada en búsquedas de rutas y conectividad entre zonas.
    internal class ColaZonas
    {
        private NodoColaZona frente;
        private NodoColaZona fondo;

        public ColaZonas()
        {
            frente = null;
            fondo = null;
        }

        public void Encolar(int indice)
        {
            NodoColaZona nuevo = new NodoColaZona(indice);

            if (frente == null)
            {
                frente = nuevo;
                fondo = nuevo;
            }
            else
            {
                fondo.Siguiente = nuevo;
                fondo = nuevo;
            }
        }

        public int Desencolar()
        {
            if (EstaVacia())
                return -1;

            int indice = frente.Indice;
            frente = frente.Siguiente;

            if (frente == null)
                fondo = null;

            return indice;
        }

        public int VerFrente()
        {
            if (EstaVacia())
                return -1;

            return frente.Indice;
        }

        public bool EstaVacia()
        {
            return frente == null;
        }

        public int Contar()
        {
            int contador = 0;
            NodoColaZona aux = frente;

            while (aux != null)
            {
                contador++;
                aux = aux.Siguiente;
            }

            return contador;
        }
    }
}
