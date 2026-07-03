using RestaurantIngenieriaTrujillo.Entidades;
using RestaurantIngenieriaTrujillo.Estructuras.Cola;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.ColaPrioridad
{
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
        public bool EstaVacia()
        {
            return colaPrioritarios.EstaVacia() && colaNormal.EstaVacia();
            
        }
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

        public Pedido Desencolar()
        {
            if (!colaPrioritarios.EstaVacia())
                return colaPrioritarios.Desencolar();

            return colaNormal.Desencolar();
           
        }
        public Pedido VerFrente()
        {
            if (!colaPrioritarios.EstaVacia())
                return colaPrioritarios.VerFrente();

            return colaNormal.VerFrente();
           
        }
        public int Contar()
        {
            return colaPrioritarios.Contar() + colaNormal.Contar();
        }
        public NodoPrioridad ObtenerFrente()
        {
            return frente;
        }
        public ColaPedidos ObtenerColaPrioritarios()
        {
            return colaPrioritarios;
        }
        public ColaPedidos ObtenerColaNormal()
        {
            return colaNormal;
        }

    }
}
