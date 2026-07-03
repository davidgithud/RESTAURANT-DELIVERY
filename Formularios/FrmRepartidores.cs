using RestaurantIngenieriaTrujillo.Entidades;
using RestaurantIngenieriaTrujillo.Estructuras.ListaCircular;
using RestaurantIngenieriaTrujillo.Sistema;
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
    public partial class FrmRepartidores : Form
    {
        public FrmRepartidores()
        {
            InitializeComponent();
        }
        private void FrmRepartidores_Load(object sender, EventArgs e)
        {
            dgvRepartidores.AutoSizeColumnsMode =
               DataGridViewAutoSizeColumnsMode.Fill;

            dgvRepartidores.Columns.Add("Codigo", "Código");
            dgvRepartidores.Columns.Add("Nombre", "Nombre");
            dgvRepartidores.Columns.Add("Telefono", "Teléfono");
            dgvRepartidores.Columns.Add("Disponible", "Disponible");
            Mostrar();
        }
        private void Mostrar()
        {
            dgvRepartidores.Rows.Clear();

            NodoRepartidor aux = SistemaDelivery.ListaRepartidores.ObtenerPrimero();

            if (aux == null)
            {
                lblCantidad.Text = "Cantidad: 0";
                return;
            }

            int contador = 0;

            do
            {
                dgvRepartidores.Rows.Add(
                    aux.Datos.Codigo,
                    aux.Datos.Nombre,
                    aux.Datos.Telefono,
                    aux.Datos.Disponible ? "Sí" : "No");

                contador++;

                aux = aux.Siguiente;

            } while (aux != SistemaDelivery.ListaRepartidores.ObtenerPrimero());

            lblCantidad.Text = "Cantidad: " + contador;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Repartidor r = new Repartidor(
                Convert.ToInt32(txtCodigo.Text),
                txtNombre.Text,
                txtTelefono.Text,
                chkDisponible.Checked);

            SistemaDelivery.ListaRepartidores.Insertar(r);

            Mostrar();

            Limpiar();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Repartidor r = SistemaDelivery.ListaRepartidores.Buscar(
                Convert.ToInt32(txtCodigo.Text));

            if (r == null)
            {
                MessageBox.Show("No encontrado");
                return;
            }

            txtNombre.Text = r.Nombre;
            txtTelefono.Text = r.Telefono;
            chkDisponible.Checked = r.Disponible;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Repartidor r = new Repartidor(
                Convert.ToInt32(txtCodigo.Text),
                txtNombre.Text,
                txtTelefono.Text,
                chkDisponible.Checked);

            SistemaDelivery.ListaRepartidores.Modificar(r);

            Mostrar();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SistemaDelivery.ListaRepartidores.Eliminar(
                Convert.ToInt32(txtCodigo.Text));

            Mostrar();

            Limpiar();
        }
        private void Limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            chkDisponible.Checked = false;

            txtCodigo.Focus();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Repartidor r =
                SistemaDelivery.ListaRepartidores.ObtenerSiguienteRepartidor();

            if (r == null)
                return;

            txtCodigo.Text = r.Codigo.ToString();
            txtNombre.Text = r.Nombre;
            txtTelefono.Text = r.Telefono;
            chkDisponible.Checked = r.Disponible;
        }
    }
}
