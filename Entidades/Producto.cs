using System;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Entidades
{
    /// <summary>
    /// Clase que representa un producto del menú del restaurante.
    /// Incluye precio y tiempo de preparación estimado.
    /// </summary>
    internal class Producto
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int TiempoPreparacion { get; set; }

        // Constructores
        public Producto()
        {
        }

        public Producto(int codigo, string nombre, decimal precio, int tiempoPreparacion)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            TiempoPreparacion = tiempoPreparacion;
        }

        /// <summary>
        /// Retorna el nombre del producto para mostrar en listas.
        /// </summary>
        public override string ToString()
        {
            return Nombre;
        }
    }
}
