using System;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Entidades
{
    /// <summary>
    /// Clase que representa un repartidor del sistema.
    /// Gestiona disponibilidad y contador de pedidos asignados (máximo 3).
    /// </summary>
    internal class Repartidor
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public bool Disponible { get; set; }

        /// <summary>
        /// Contador de pedidos asignados al repartidor. Máximo permitido: 3.
        /// </summary>
        public int PedidosAsignados { get; set; }

        // Constructores
        public Repartidor()
        {
            PedidosAsignados = 0;
        }

        public Repartidor(int codigo, string nombre, string telefono, bool disponible)
        {
            Codigo = codigo;
            Nombre = nombre;
            Telefono = telefono;
            Disponible = disponible;
            PedidosAsignados = 0;
        }

        /// <summary>
        /// Retorna el nombre del repartidor para mostrar en listas.
        /// </summary>
        public override string ToString()
        {
            return Nombre;
        }
    }
}
