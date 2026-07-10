using System;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Estructuras.ListaDoble
{
    /// <summary>
    /// Clase que registra el cambio de estado de un pedido en el historial.
    /// Almacena código del pedido, nombre del cliente, estado actual y marca de tiempo.
    /// </summary>
    internal class HistorialEstado
    {
        public int CodigoPedido { get; set; }
        public string NombreCliente { get; set; }
        public string Estado { get; set; }
        public DateTime FechaHora { get; set; }

        // Constructores
        public HistorialEstado()
        {
        }

        public HistorialEstado(int codigoPedido, string estado)
        {
            CodigoPedido = codigoPedido;
            NombreCliente = "N/A";
            Estado = estado;
            FechaHora = DateTime.Now;
        }

        public HistorialEstado(int codigoPedido, string nombreCliente, string estado)
        {
            CodigoPedido = codigoPedido;
            NombreCliente = nombreCliente;
            Estado = estado;
            FechaHora = DateTime.Now;
        }
    }
}
