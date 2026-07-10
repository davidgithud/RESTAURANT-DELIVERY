using RestaurantIngenieriaTrujillo.Entidades;
using System;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantIngenieriaTrujillo.Datos
{
    internal class ProductoDatos
    {
        private Producto[] productos;

        private int cantidad;

        public ProductoDatos()
        {
            productos = new Producto[100];

            cantidad = 0;
        }
        public bool Registrar(Producto producto)
        {
            if (cantidad >= productos.Length)
                return false;

            productos[cantidad] = producto;

            cantidad++;

            return true;
        }
        public Producto Buscar(int codigo)
        {
            for (int i = 0; i < cantidad; i++)
            {
                if (productos[i].Codigo == codigo)
                    return productos[i];
            }

            return null;
        }
        public bool Eliminar(int codigo)
        {
            int posicion = -1;

            for (int i = 0; i < cantidad; i++)
            {
                if (productos[i].Codigo == codigo)
                {
                    posicion = i;
                    break;
                }
            }

            if (posicion == -1)
                return false;

            for (int i = posicion; i < cantidad - 1; i++)
            {
                productos[i] = productos[i + 1];
            }

            cantidad--;

            return true;
        }
        public bool Modificar(Producto producto)
        {
            for (int i = 0; i < cantidad; i++)
            {
                if (productos[i].Codigo == producto.Codigo)
                {
                    productos[i] = producto;

                    return true;
                }
            }

            return false;
        }
        public int Cantidad()
        {
            return cantidad;
        }
        public Producto ObtenerProducto(int indice)
        {
            if (indice >= 0 && indice < cantidad)
                return productos[indice];

            return null;
        }
    }
}
