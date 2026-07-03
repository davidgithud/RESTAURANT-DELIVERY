using RestaurantIngenieriaTrujillo.Sistema;
using RestaurantIngenieriaTrujillo.Estructuras.ListaDoble;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantIngenieriaTrujillo.Formularios
{
    public partial class FrmHistorial : Form
    {
        public FrmHistorial()
        {
            InitializeComponent();
        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvHistorial.Columns.Add("Codigo", "Código");

            dgvHistorial.Columns.Add("Estado", "Estado");

            dgvHistorial.Columns.Add("Fecha", "Fecha");

            MostrarSiguiente();
        }
        private void MostrarSiguiente()
        {
            dgvHistorial.Rows.Clear();

            int contador = 0;

            foreach (HistorialEstado h
                in SistemaDelivery.Historial.RecorrerAdelante())
            {
                dgvHistorial.Rows.Add(
                    h.CodigoPedido,
                    h.Estado,
                    h.FechaHora);

                contador++;
            }

            lblCantidad.Text = "Cantidad: " + contador;
        }
        private void MostrarAnterior()
        {
            dgvHistorial.Rows.Clear();

            int contador = 0;

            foreach (HistorialEstado h
                in SistemaDelivery.Historial.RecorrerAtras())
            {
                dgvHistorial.Rows.Add(
                    h.CodigoPedido,
                    h.Estado,
                    h.FechaHora);

                contador++;
            }

            lblCantidad.Text =
                "Cantidad: " + contador;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            MostrarSiguiente();
        }
        private void btnAnterior_Click(object sender,
                            EventArgs e)
        {
            MostrarAnterior();
        }
    }
}
