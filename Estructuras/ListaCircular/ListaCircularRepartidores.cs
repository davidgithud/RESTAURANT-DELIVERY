using RestaurantIngenieriaTrujillo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.ListaCircular
{
    internal class ListaCircularRepartidores
    {
        private NodoRepartidor ultimo;
        private NodoRepartidor actual;

        public ListaCircularRepartidores()
        {
            ultimo = null;
            actual = null;
        }
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
        public NodoRepartidor ObtenerPrimero()
        {
            if (ultimo == null)
                return null;

            return ultimo.Siguiente;
        }
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
        public Repartidor ObtenerSiguienteRepartidor()
        {
            if (actual == null)
                return null;

            Repartidor repartidor = actual.Datos;

            actual = actual.Siguiente;

            return repartidor;
        }
        public bool Disponible { get; set; }
        public List<Repartidor> ObtenerTodos()
        {
            List<Repartidor> lista = new List<Repartidor>();

            if (ultimo == null)
                return lista;

            NodoRepartidor aux = ultimo.Siguiente;

            do
            {
                lista.Add(aux.Datos);
                aux = aux.Siguiente;

            } while (aux != ultimo.Siguiente);

            return lista;
        }
    }
}
