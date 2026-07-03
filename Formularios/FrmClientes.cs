using RestaurantIngenieriaTrujillo.Entidades;
using RestaurantIngenieriaTrujillo.Estructuras.ListaSimple;
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
    public partial class FrmClientes : Form
    {
        

        public FrmClientes()
        {
            InitializeComponent();

            
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cboZona.Items.Add("Centro");
            cboZona.Items.Add("California");
            cboZona.Items.Add("El Recreo");
            cboZona.Items.Add("Primavera");
            cboZona.Items.Add("San Andrés");
            cboZona.Items.Add("Las Quintanas");
            cboZona.Items.Add("Palermo");
            cboZona.Items.Add("El Golf");
            cboZona.Items.Add("Víctor Larco");
            cboZona.Items.Add("Buenos Aires");

            cboZona.SelectedIndex = 0;

            dgvClientes.Columns.Add("Codigo", "Código");
            dgvClientes.Columns.Add("DNI", "DNI");
            dgvClientes.Columns.Add("Nombre", "Nombre");
            dgvClientes.Columns.Add("Telefono", "Teléfono");
            dgvClientes.Columns.Add("Direccion", "Dirección");
            dgvClientes.Columns.Add("Zona", "Zona");

        }
        private void Limpiar()
        {
            txtCodigo.Clear();
            txtDNI.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();

            cboZona.SelectedIndex = 0;

            txtCodigo.Focus();
        }
        private bool ValidarDatos()
        {
            if (txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el código.");
                txtCodigo.Focus();
                return false;
            }

            if (txtDNI.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el DNI.");
                txtDNI.Focus();
                return false;
            }

            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre.");
                txtNombre.Focus();
                return false;
            }

            if (txtTelefono.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el teléfono.");
                txtTelefono.Focus();
                return false;
            }

            if (txtDireccion.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la dirección.");
                txtDireccion.Focus();
                return false;
            }
            if (txtDNI.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 dígitos.");
                txtDNI.Focus();
                return false;
            }
            return true;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
                return;

            int codigo = Convert.ToInt32(txtCodigo.Text);

            if (SistemaDelivery.ListaClientes.Buscar(codigo) != null)
            {
                MessageBox.Show("Ya existe un cliente con ese código.");
                txtCodigo.Focus();
                return;
            }

            Cliente cliente = new Cliente(
                codigo,
                txtDNI.Text,
                txtNombre.Text,
                txtTelefono.Text,
                txtDireccion.Text,
                cboZona.Text
            );

            SistemaDelivery.ListaClientes.Insertar(cliente);

            MostrarClientes();

            MessageBox.Show("Cliente registrado correctamente.");

            Limpiar();
        }
        private void MostrarClientes()
        {
            dgvClientes.Rows.Clear();

            NodoCliente aux = SistemaDelivery.ListaClientes.ObtenerCabeza();
            int contador = 0;
            while (aux != null)
            {
                contador++;
                dgvClientes.Rows.Add(aux.Datos.Codigo, aux.Datos.DNI, aux.Datos.Nombre, aux.Datos.Telefono, aux.Datos.Direccion, aux.Datos.Zona
                );

                aux = aux.Siguiente;
            }
            lblCantidad.Text = "Clientes registrados : " + contador;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Ingrese el código.");
                return;
            }

            Cliente cliente = SistemaDelivery.ListaClientes.Buscar(Convert.ToInt32(txtCodigo.Text));

            if (cliente == null)
            {
                MessageBox.Show("Cliente no encontrado.");
                return;
            }

            txtDNI.Text = cliente.DNI;
            txtNombre.Text = cliente.Nombre;
            txtTelefono.Text = cliente.Telefono;
            txtDireccion.Text = cliente.Direccion;
            cboZona.Text = cliente.Zona;
        }
        private void btnEliminar_Click(object sender,
                               EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Ingrese el código.");

                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Desea eliminar este cliente?", "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
                return;

            bool eliminado = SistemaDelivery.ListaClientes.Eliminar(Convert.ToInt32(txtCodigo.Text));

            if (eliminado)
            {
                MostrarClientes();

                MessageBox.Show("Cliente eliminado.");

                Limpiar();
            }
            else
            {
                MessageBox.Show("No existe el cliente.");
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(Convert.ToInt32(txtCodigo.Text),
                txtDNI.Text,
                txtNombre.Text,
                txtTelefono.Text,
                txtDireccion.Text,
                cboZona.Text
            );

            bool modificado = SistemaDelivery.ListaClientes.Modificar(cliente);

            if (modificado)
            {
                MessageBox.Show("Cliente actualizado.");

                MostrarClientes();

                Limpiar();
            }
            else
            {
                MessageBox.Show("Cliente no encontrado.");
            }
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            SistemaDelivery.ListaClientes.OrdenarPorNombre();

            MostrarClientes();

            MessageBox.Show("Lista ordenada.");
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            txtCodigo.Text =dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString();

            txtDNI.Text = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();

            txtNombre.Text = dgvClientes.Rows[e.RowIndex].Cells[2].Value.ToString();

            txtTelefono.Text = dgvClientes.Rows[e.RowIndex].Cells[3].Value.ToString();

            txtDireccion.Text = dgvClientes.Rows[e.RowIndex].Cells[4].Value.ToString();

            cboZona.Text = dgvClientes.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}
