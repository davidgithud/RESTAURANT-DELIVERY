using System;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Entidades
{
    /// <summary>
    /// Clase que representa una zona de cobertura para las rutas de delivery.
    /// Utilizada en el grafo de rutas.
    /// </summary>
    internal class Zona
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }

        // Constructores
        public Zona()
        {
        }

        public Zona(int codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
        }

        /// <summary>
        /// Retorna el nombre de la zona.
        /// </summary>
        public override string ToString()
        {
            return Nombre;
        }
    }
}
