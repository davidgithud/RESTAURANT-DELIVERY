using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                        fila.Cells[j + 1].Value = "∞";
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
        private void btnBFS_Click(object sender, EventArgs e)
        {
            lstRecorrido.Items.Clear();

            foreach (Zona z in SistemaDelivery.Grafo.BFS(cboOrigen.SelectedIndex))
            {
                lstRecorrido.Items.Add(z.Nombre);
            }
        }
        private void btnDFS_Click(object sender, EventArgs e)
        {
            lstRecorrido.Items.Clear();

            foreach (Zona z in SistemaDelivery.Grafo.DFS(cboOrigen.SelectedIndex))
            {
                lstRecorrido.Items.Add(z.Nombre);
            }
        }
        private void btnDijkstra_Click(object sender, EventArgs e)
        {
            int[] distancia =
                SistemaDelivery.Grafo.Dijkstra(cboOrigen.SelectedIndex);

            int destino = cboDestino.SelectedIndex;

            if (distancia[destino] == int.MaxValue)
            {
                lblDistancia.Text = "Ruta inexistente";
                return;
            }

            lblDistancia.Text =
                "Distancia: " +
                distancia[destino] +
                " km";
        }
        private void btnPrim_Click(object sender, EventArgs e)
        {
            lstRecorrido.Items.Clear();

            foreach (string s in SistemaDelivery.Grafo.Prim())
            {
                lstRecorrido.Items.Add(s);
            }
        }
    }
}
