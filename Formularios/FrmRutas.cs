using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantIngenieriaTrujillo.Sistema;
using RestaurantIngenieriaTrujillo.Entidades;
using RestaurantIngenieriaTrujillo.Estructuras.Grafos;

namespace RestaurantIngenieriaTrujillo.Formularios
{
    public partial class FrmRutas : Form
    {
        public FrmRutas()
        {
            InitializeComponent();
        }

        private void FrmRutas_Load(object sender, EventArgs e)
        {
            InicializarGrafo();

            CargarCombos();

            MostrarMatriz();
        }

        private void BtnAgregarLugar_Click(object sender, EventArgs e)
        {
            if (txtNombreLugar.Text == "") return;
            // Verificar limite
            if (SistemaDelivery.Grafo.CantidadZonas() >= 20) { MessageBox.Show("Límite de zonas alcanzado."); return; }
            SistemaDelivery.Grafo.AgregarZona(new Zona(SistemaDelivery.Grafo.CantidadZonas(), txtNombreLugar.Text));
            // Por defecto, agregar conexiones aleatorias con el centro u otro lugar para que no quede aislado
            if (SistemaDelivery.Grafo.CantidadZonas() > 1) {
                SistemaDelivery.Grafo.AgregarConexion(SistemaDelivery.Grafo.CantidadZonas() - 1, 0, new Random().Next(2, 6));
            }
            CargarCombos();
            txtNombreLugar.Clear();
            MessageBox.Show("Lugar agregado.");
        }

        private void BtnModificarLugar_Click(object sender, EventArgs e)
        {
            if (txtNombreLugar.Text == "" || cboOrigen.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un lugar en 'Origen' e ingrese el nuevo nombre.");
                return;
            }

            int zonaIndex = cboOrigen.SelectedIndex;
            if (zonaIndex == 0)
            {
                MessageBox.Show("No se puede modificar la zona 'Restaurant'.");
                return;
            }

            Zona zonaActual = SistemaDelivery.Grafo.ObtenerZona(zonaIndex);

            if (zonaActual == null)
            {
                MessageBox.Show("Zona no encontrada.");
                return;
            }

            // Modificar el nombre de la zona
            zonaActual.Nombre = txtNombreLugar.Text;

            CargarCombos();
            txtNombreLugar.Clear();
            MostrarMatriz();
            MessageBox.Show("Lugar modificado correctamente.");
        }
        private void InicializarGrafo()
        {
            if (SistemaDelivery.Grafo.CantidadZonas() > 0)
                return;

            SistemaDelivery.Grafo.AgregarZona(new Zona(0, "Restaurant"));
            SistemaDelivery.Grafo.AgregarZona(new Zona(1, "Centro"));
            SistemaDelivery.Grafo.AgregarZona(new Zona(2, "California"));
            SistemaDelivery.Grafo.AgregarZona(new Zona(3, "El Recreo"));
            SistemaDelivery.Grafo.AgregarZona(new Zona(4, "Primavera"));
            SistemaDelivery.Grafo.AgregarZona(new Zona(5, "San Andrés"));
            SistemaDelivery.Grafo.AgregarZona(new Zona(6, "Las Quintanas"));
            SistemaDelivery.Grafo.AgregarZona(new Zona(7, "Palermo"));
            SistemaDelivery.Grafo.AgregarZona(new Zona(8, "El Golf"));
            SistemaDelivery.Grafo.AgregarZona(new Zona(9, "Víctor Larco"));

            SistemaDelivery.Grafo.AgregarConexion(0, 1, 2);
            SistemaDelivery.Grafo.AgregarConexion(0, 2, 4);
            SistemaDelivery.Grafo.AgregarConexion(1, 3, 2);
            SistemaDelivery.Grafo.AgregarConexion(2, 4, 3);
            SistemaDelivery.Grafo.AgregarConexion(3, 5, 2);
            SistemaDelivery.Grafo.AgregarConexion(4, 6, 2);
            SistemaDelivery.Grafo.AgregarConexion(5, 7, 3);
            SistemaDelivery.Grafo.AgregarConexion(6, 8, 2);
            SistemaDelivery.Grafo.AgregarConexion(8, 9, 4);
        }
        private void CargarCombos()
        {
            cboOrigen.Items.Clear();
            cboDestino.Items.Clear();

            for (int i = 0; i < SistemaDelivery.Grafo.CantidadZonas(); i++)
            {
                Zona z = SistemaDelivery.Grafo.ObtenerZona(i);

                cboOrigen.Items.Add(z.Nombre);

                cboDestino.Items.Add(z.Nombre);
            }

            cboOrigen.SelectedIndex = 0;
            cboDestino.SelectedIndex = 0;
        }
        private void MostrarMatriz()
        {
            dgvMatriz.Columns.Clear();
            dgvMatriz.Rows.Clear();

            int n = SistemaDelivery.Grafo.CantidadZonas();

            dgvMatriz.Columns.Add("", "");

            for (int i = 0; i < n; i++)
                dgvMatriz.Columns.Add(i.ToString(),
                    SistemaDelivery.Grafo.ObtenerZona(i).Nombre);

            int[,] matriz = SistemaDelivery.Grafo.ObtenerMatriz();

            for (int i = 0; i < n; i++)
            {
                DataGridViewRow fila = new DataGridViewRow();

                fila.CreateCells(dgvMatriz);

                fila.Cells[0].Value =
                    SistemaDelivery.Grafo.ObtenerZona(i).Nombre;

                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == int.MaxValue)
                        fila.Cells[j + 1].Value = "8";
                    else
                        fila.Cells[j + 1].Value = matriz[i, j];
                }

                dgvMatriz.Rows.Add(fila);
            }
        }
        private void btnMatriz_Click(object sender, EventArgs e)
        {
            MostrarMatriz();
        }

        private void btnDijkstra_Click(object sender, EventArgs e)
        {
            int distancia = 0;
            // Get Distance using Dijkstra
            int[] distancias = SistemaDelivery.Grafo.Dijkstra(cboOrigen.SelectedIndex);
            int destino = cboDestino.SelectedIndex;

            if (distancias[destino] == int.MaxValue)
            {
                lblDistancia.Text = "Ruta inexistente\nTiempo aproximado: ---";
                return;
            }

            distancia = distancias[destino];
            int minutos = distancia * 5; // Aprox 5 mins per km

            lblDistancia.Text =
                "Distancia: " +
                distancia +
                " km\nTiempo aproximado: " + minutos + " minutos";
        }

        private void BtnEliminarLugar_Click(object sender, EventArgs e)
        {
            if (cboOrigen.SelectedIndex < 1)
            {
                MessageBox.Show("Seleccione un lugar en 'Origen' para eliminar.");
                return;
            }

            int zonaIndex = cboOrigen.SelectedIndex;
            Zona zonaAEliminar = SistemaDelivery.Grafo.ObtenerZona(zonaIndex);

            if (zonaAEliminar == null)
            {
                MessageBox.Show("Zona no encontrada.");
                return;
            }

            if (zonaIndex == 0)
            {
                MessageBox.Show("No se puede eliminar la zona 'Restaurant'.");
                return;
            }

            if (MessageBox.Show("¿Está seguro que desea eliminar la zona '" + zonaAEliminar.Nombre + "'?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (SistemaDelivery.Grafo.EliminarZona(zonaIndex))
                {
                    CargarCombos();
                    MostrarMatriz();
                    MessageBox.Show("Zona eliminada correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la zona.");
                }
            }
        }
    }
}
