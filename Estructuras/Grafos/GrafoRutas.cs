using RestaurantIngenieriaTrujillo.Entidades;
using System;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.Grafos
{
    // Grafo de rutas que representa las zonas de entrega y conexiones entre ellas.
    // Utiliza matriz de costos de adyacencia para almacenar distancias entre zonas.
    internal class GrafoRutas
    {
        private const int MAX = 20;
        private Zona[] zonas;
        private int[,] matrizCostos;
        private int cantidad;

        public GrafoRutas()
        {
            zonas = new Zona[MAX];
            matrizCostos = new int[MAX, MAX];
            cantidad = 0;
            InicializarMatriz();
        }

        // Inicializa la matriz de costos con 0 en la diagonal y MaxValue en otros lugares.
        private void InicializarMatriz()
        {
            for (int i = 0; i < MAX; i++)
            {
                for (int j = 0; j < MAX; j++)
                {
                    if (i == j)
                        matrizCostos[i, j] = 0;
                    else
                        matrizCostos[i, j] = int.MaxValue;
                }
            }
        }

        // Agrega una nueva zona al grafo.
        public void AgregarZona(Zona zona)
        {
            zonas[cantidad] = zona;
            cantidad++;
        }

        // Agrega una conexión (arista bidireccional) entre dos zonas con una distancia.
        public void AgregarConexion(int origen, int destino, int distancia)
        {
            matrizCostos[origen, destino] = distancia;
            matrizCostos[destino, origen] = distancia;
        }

        // Obtiene la distancia entre dos zonas.
        public int ObtenerDistancia(int origen, int destino)
        {
            return matrizCostos[origen, destino];
        }

        // Obtiene una zona por su índice.
        public Zona ObtenerZona(int indice)
        {
            return zonas[indice];
        }

        // Retorna la cantidad total de zonas en el grafo.
        public int CantidadZonas()
        {
            return cantidad;
        }

        // Elimina una zona del grafo (exceptuando la zona 0 que es el restaurante).
        public bool EliminarZona(int indice)
        {
            // No permitir eliminar la zona 0 (Restaurant)
            if (indice <= 0 || indice >= cantidad)
                return false;

            // Desplazar todas las zonas después del índice eliminado
            for (int i = indice; i < cantidad - 1; i++)
            {
                zonas[i] = zonas[i + 1];
                zonas[i].Codigo = i; // Actualizar código en la zona
            }

            zonas[cantidad - 1] = null;
            cantidad--;

            // Eliminar fila y columna del índice
            int[,] nuevaMatriz = new int[MAX, MAX];
            InicializarMatriz();

            int filaSrc = 0;
            for (int i = 0; i <= cantidad; i++)
            {
                if (i == indice) continue; // Saltar la fila eliminada

                    int colSrc = 0;
                    for (int j = 0; j <= cantidad; j++)
                    {
                        if (j == indice) continue; // Saltar la columna eliminada

                        if (filaSrc < cantidad && colSrc < cantidad)
                        {
                            matrizCostos[filaSrc, colSrc] = 
                                (i < MAX && j < MAX) ? matrizCostos[i, j] : int.MaxValue;
                        }
                        colSrc++;
                    }
                    filaSrc++;
                    }

                    return true;
                }

                // Retorna la matriz de costos para inspección.
                public int[,] ObtenerMatriz()
                {
                    return matrizCostos;
                }

                // Realiza un recorrido BFS (Breadth First Search) desde una zona origen.
                // Retorna todas las zonas alcanzables en orden de descubrimiento.
                public ListaZonas BFS(int origen)
                {
                    ListaZonas recorrido = new ListaZonas();
                    bool[] visitado = new bool[cantidad];
                    ColaZonas cola = new ColaZonas();
                    visitado[origen] = true;
                    cola.Encolar(origen);

                    while (!cola.EstaVacia())
                    {
                        int actual = cola.Desencolar();
                        recorrido.Agregar(zonas[actual]);

                        for (int i = 0; i < cantidad; i++)
                        {
                            if (matrizCostos[actual, i] != int.MaxValue &&
                                !visitado[i] &&
                                actual != i)
                            {
                                visitado[i] = true;
                                cola.Encolar(i);
                            }
                        }
                    }            return recorrido;
        }

        // Realiza un recorrido DFS (Depth First Search) desde una zona origen.
        // Retorna todas las zonas alcanzables en orden de exploración profunda.
        public ListaZonas DFS(int origen)
        {
            ListaZonas recorrido = new ListaZonas();
            bool[] visitado = new bool[cantidad];
            DFSRecursivo(origen, visitado, recorrido);
            return recorrido;
        }

        // Método recursivo para DFS.
        private void DFSRecursivo(
            int actual,
            bool[] visitado,
            ListaZonas recorrido)
        {
            visitado[actual] = true;
            recorrido.Agregar(zonas[actual]);

            for (int i = 0; i < cantidad; i++)
            {
                if (matrizCostos[actual, i] != int.MaxValue &&
                    !visitado[i] &&
                    actual != i)
                {
                    DFSRecursivo(i, visitado, recorrido);
                }
            }
        }

        // Algoritmo de Dijkstra para encontrar el camino más corto desde un origen.
        // Retorna array de distancias mínimas a cada zona.
        public int[] Dijkstra(int origen)
        {
            int[] distancia = new int[cantidad];
            bool[] visitado = new bool[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                distancia[i] = int.MaxValue;
                visitado[i] = false;
            }

            distancia[origen] = 0;

            for (int c = 0; c < cantidad - 1; c++)
            {
                int u = -1;
                int minimo = int.MaxValue;

                for (int i = 0; i < cantidad; i++)
                {
                    if (!visitado[i] &&
                        distancia[i] < minimo)
                    {
                        minimo = distancia[i];
                        u = i;
                    }
                }

                if (u == -1)
                    break;

                visitado[u] = true;

                for (int v = 0; v < cantidad; v++)
                {
                    if (!visitado[v] &&
                        matrizCostos[u, v] != int.MaxValue &&
                        distancia[u] != int.MaxValue &&
                        distancia[u] + matrizCostos[u, v] < distancia[v])
                    {
                        distancia[v] =
                            distancia[u] + matrizCostos[u, v];
                    }
                }
            }

            return distancia;
        }
        public ListaStringsResultado Prim()
        {
            ListaStringsResultado resultado = new ListaStringsResultado();

            bool[] seleccionado = new bool[cantidad];

            seleccionado[0] = true;

            int aristas = 0;

            while (aristas < cantidad - 1)
            {
                int minimo = int.MaxValue;

                int x = 0;
                int y = 0;

                for (int i = 0; i < cantidad; i++)
                {
                    if (seleccionado[i])
                    {
                        for (int j = 0; j < cantidad; j++)
                        {
                            if (!seleccionado[j] &&
                                matrizCostos[i, j] < minimo)
                            {
                                minimo = matrizCostos[i, j];
                                x = i;
                                y = j;
                            }
                        }
                    }
                }

                resultado.Agregar(
                    zonas[x].Nombre +
                    " -> " +
                    zonas[y].Nombre +
                    " = " +
                    minimo + " km");

                seleccionado[y] = true;

                aristas++;
            }

            return resultado;
        }
    }
}
