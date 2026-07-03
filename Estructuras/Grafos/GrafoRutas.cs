using System.Collections.Generic;
using RestaurantIngenieriaTrujillo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.Grafos
{
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
        public void AgregarZona(Zona zona)
        {
            zonas[cantidad] = zona;

            cantidad++;
        }
        public void AgregarConexion(int origen,int destino,int distancia)
        {
            matrizCostos[origen, destino] = distancia;

            matrizCostos[destino, origen] = distancia;
        }
        public int ObtenerDistancia(int origen, int destino)
        {
            return matrizCostos[origen, destino];
        }
        public Zona ObtenerZona(int indice)
        {
            return zonas[indice];
        }
        public int CantidadZonas()
        {
            return cantidad;
        }
        public int[,] ObtenerMatriz()
        {
            return matrizCostos;
        }
        public List<Zona> BFS(int origen)
        {
            List<Zona> recorrido = new List<Zona>();

            bool[] visitado = new bool[cantidad];

            Queue<int> cola = new Queue<int>();

            visitado[origen] = true;

            cola.Enqueue(origen);

            while (cola.Count > 0)
            {
                int actual = cola.Dequeue();

                recorrido.Add(zonas[actual]);

                for (int i = 0; i < cantidad; i++)
                {
                    if (matrizCostos[actual, i] != int.MaxValue &&
                        !visitado[i] &&
                        actual != i)
                    {
                        visitado[i] = true;
                        cola.Enqueue(i);
                    }
                }
            }

            return recorrido;
        }
        public List<Zona> DFS(int origen)
        {
            List<Zona> recorrido = new List<Zona>();

            bool[] visitado = new bool[cantidad];

            DFSRecursivo(origen, visitado, recorrido);

            return recorrido;
        }

        private void DFSRecursivo(
            int actual,
            bool[] visitado,
            List<Zona> recorrido)
        {
            visitado[actual] = true;

            recorrido.Add(zonas[actual]);

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
        public List<string> Prim()
        {
            List<string> resultado = new List<string>();

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

                resultado.Add(
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
