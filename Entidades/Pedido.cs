using System;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Entidades
{
    /// <summary>
    /// Clase que representa un pedido del sistema.
    /// Contiene cliente, producto, cantidad, prioridad, estado y repartidor asignado.
    /// </summary>
    internal class Pedido
    {
        public int Codigo { get; set; }
        public Cliente Cliente { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
        public bool EsPrioritario { get; set; }
        public string Estado { get; set; }
        public Repartidor Repartidor { get; set; }
        public bool EsCompletado { get; set; }

        // Constructores
        public Pedido()
        {
        }

        public Pedido(int codigo, Cliente cliente, Producto producto, int cantidad, bool esPrioritario, string estado, Repartidor repartidor)
        {
            Codigo = codigo;
            Cliente = cliente;
            Producto = producto;
            Cantidad = cantidad;
            Total = producto.Precio * cantidad;
            EsPrioritario = esPrioritario;
            Estado = estado;
            Repartidor = repartidor;
            EsCompletado = false;
        }

        /// <summary>
        /// Retorna la representación en string del pedido.
        /// </summary>
        public override string ToString()
        {
            return Codigo + " - " + Cliente.Nombre;
        }
    }
}
