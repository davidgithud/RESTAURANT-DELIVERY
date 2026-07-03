using RestaurantIngenieriaTrujillo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.Cola
{
    internal class ColaPedidos
    {
        private NodoCola frente;

        private NodoCola fin;

        public ColaPedidos()
        {
            frente = null;

            fin = null;
        }
        public bool EstaVacia()
        {
            return frente == null;
        }
        public void Encolar(Pedido pedido)
        {
            NodoCola nuevo = new NodoCola(pedido);

            if (EstaVacia())
            {
                frente = nuevo;

                fin = nuevo;
            }
            else
            {
                fin.Siguiente = nuevo;

                fin = nuevo;
            }
        }
        public Pedido Desencolar()
        {
            if (EstaVacia())
                return null;

            Pedido pedido = frente.Datos;

            frente = frente.Siguiente;

            if (frente == null)
                fin = null;

            return pedido;
            pedido.Estado = "En reparto";
        }
        public Pedido VerFrente()
        {
            if (EstaVacia())
                return null;

            return frente.Datos;
        }
        public int Contar()
        {
            int contador = 0;

            NodoCola aux = frente;

            while (aux != null)
            {
                contador++;

                aux = aux.Siguiente;
            }

            return contador;
        }
        public NodoCola ObtenerFrente()
        {
            return frente;
        }
    }
}
