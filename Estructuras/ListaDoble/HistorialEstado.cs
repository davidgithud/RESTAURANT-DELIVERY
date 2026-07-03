using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.ListaDoble
{
    internal class HistorialEstado
    {
        public int CodigoPedido { get; set; }

        public string Estado { get; set; }

        public DateTime FechaHora { get; set; }

        public HistorialEstado()
        {

        }

        public HistorialEstado(
            int codigoPedido,
            string estado)
        {
            CodigoPedido = codigoPedido;

            Estado = estado;

            FechaHora = DateTime.Now;
        }
    }
}
