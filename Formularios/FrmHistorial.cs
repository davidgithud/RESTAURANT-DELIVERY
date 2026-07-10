using RestaurantIngenieriaTrujillo.Sistema;
using RestaurantIngenieriaTrujillo.Estructuras.ListaDoble;
using RestaurantIngenieriaTrujillo.Entidades;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantIngenieriaTrujillo.Formularios
{
    /// <summary>
    /// Formulario para visualizar el historial de estados de pedidos.
    /// Permite navegar entre registros usando lista doble enlazada.
    /// </summary>
    public partial class FrmHistorial : Form
    {
        private NodoHistorial punteroActual;
        private int fichaActual;

        public FrmHistorial()
        {
            InitializeComponent();
        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.Columns.Add("Codigo", "Código");
            dgvHistorial.Columns.Add("Cliente", "Cliente");
            dgvHistorial.Columns.Add("Estado", "Estado");
            dgvHistorial.Columns.Add("Fecha", "Fecha");

            fichaActual = 0;
            punteroActual = SistemaDelivery.Historial.ObtenerPrimero();
            MostrarTodosLosRegistros();
        }

        private void BtnLimpiarHist_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere proceder a limpiar el historial?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SistemaDelivery.Historial.Limpiar();
                fichaActual = 0;
                punteroActual = null;
                dgvHistorial.Rows.Clear();
                lblCantidad.Text = "Cantidad: 0";
            }
        }

        /// <summary>
        /// Muestra todos los registros del historial con el actual resaltado.
        /// Navega por lista doble permitiendo avanzar y retroceder.
        /// </summary>
        private void MostrarTodosLosRegistros()
        {
            dgvHistorial.Rows.Clear();

            int contador = 0;
            int filaPuntero = 0;

            NodoHistorial aux = SistemaDelivery.Historial.ObtenerPrimero();

            while (aux != null)
            {
                HistorialEstado h = aux.Datos;

                dgvHistorial.Rows.Add(
                    h.CodigoPedido,
                    h.NombreCliente,
                    h.Estado,
                    h.FechaHora);

                if (aux == punteroActual)
                    filaPuntero = contador;

                contador++;
                aux = aux.Siguiente;
            }

            lblCantidad.Text = "Cantidad: " + contador;

            if (contador > 0 && filaPuntero < dgvHistorial.Rows.Count)
            {
                dgvHistorial.ClearSelection();
                dgvHistorial.Rows[filaPuntero].Selected = true;
                dgvHistorial.FirstDisplayedScrollingRowIndex = filaPuntero;
            }
        }

        private void MostrarSiguiente()
        {
            if (punteroActual != null && punteroActual.Siguiente != null)
            {
                punteroActual = punteroActual.Siguiente;
                fichaActual++;
            }
            else if (punteroActual == null)
            {
                punteroActual = SistemaDelivery.Historial.ObtenerPrimero();
                fichaActual = 0;
            }

            MostrarTodosLosRegistros();
        }

        private void MostrarAnterior()
        {
            if (punteroActual != null && punteroActual.Anterior != null)
            {
                punteroActual = punteroActual.Anterior;
                fichaActual--;
            }
            else if (punteroActual == null)
            {
                punteroActual = SistemaDelivery.Historial.ObtenerUltimo();
                // Calcular la última posición
                NodoHistorial aux = SistemaDelivery.Historial.ObtenerPrimero();
                fichaActual = 0;
                while (aux != null && aux.Siguiente != null)
                {
                    fichaActual++;
                    aux = aux.Siguiente;
                }
            }

            MostrarTodosLosRegistros();
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
