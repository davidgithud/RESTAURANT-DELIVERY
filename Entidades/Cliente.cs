using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Entidades
{
    internal class Cliente
    {
        public int Codigo { get; set; }

        public string DNI { get; set; }

        public string Nombre { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public string Zona { get; set; }

        // Constructor vacío
        public Cliente()
        {

        }

        // Constructor con parámetros
        public Cliente(int codigo, string dni, string nombre, string telefono, string direccion, string zona)
        {
            Codigo = codigo;
            DNI = dni;
            Nombre = nombre;
            Telefono = telefono;
            Direccion = direccion;
            Zona = zona;
        }

        // Método para mostrar información
        public override string ToString()
        {
            return Codigo + " - " + Nombre;
        }
    }
}

