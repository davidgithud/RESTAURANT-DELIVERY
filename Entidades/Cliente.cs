using System;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Entidades
{
    /// <summary>
    /// Clase que representa un cliente del sistema de delivery.
    /// Contiene información personal, dirección y zona de ubicación.
    /// </summary>
    internal class Cliente
    {
        public int Codigo { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Zona { get; set; }

        // Constructores
        public Cliente()
        {
        }

        public Cliente(int codigo, string dni, string nombre, string telefono, string direccion, string zona)
        {
            Codigo = codigo;
            DNI = dni;
            Nombre = nombre;
            Telefono = telefono;
            Direccion = direccion;
            Zona = zona;
        }

        /// <summary>
        /// Retorna la representación en string del cliente para mostrar en listas.
        /// </summary>
        public override string ToString()
        {
            return Codigo + " - " + Nombre;
        }
    }
}

