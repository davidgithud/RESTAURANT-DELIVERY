using RestaurantIngenieriaTrujillo.Entidades;
using RestaurantIngenieriaTrujillo.Estructuras.ListaSimple;
using RestaurantIngenieriaTrujillo.Sistema;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            // Cargar las zonas dinámicamente desde el grafo
            CargarZonasDesdeGrafo();

            dgvClientes.Columns.Add("Codigo", "Código");
            dgvClientes.Columns.Add("DNI", "DNI");
            dgvClientes.Columns.Add("Nombre", "Nombre");
            dgvClientes.Columns.Add("Telefono", "Teléfono");
            dgvClientes.Columns.Add("Direccion", "Dirección");
            dgvClientes.Columns.Add("Zona", "Zona");

            MostrarClientes();
        }

        private void CargarZonasDesdeGrafo()
        {
            cboZona.Items.Clear();

            // Cargar todas las zonas del grafo (excepto el Restaurant que es la zona 0)
            for (int i = 1; i < SistemaDelivery.Grafo.CantidadZonas(); i++)
            {
                Zona zona = SistemaDelivery.Grafo.ObtenerZona(i);
                if (zona != null)
                {
                    cboZona.Items.Add(zona.Nombre);
                }
            }

            if (cboZona.Items.Count > 0)
                cboZona.SelectedIndex = 0;
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

            // Validar que el código no sea 0
            if (!int.TryParse(txtCodigo.Text, out int codigo) || codigo <= 0)
            {
                MessageBox.Show("Ingrese un código válido.");
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
            if (txtTelefono.Text.Length != 9)
            {
                MessageBox.Show("El teléfono debe tener 9 dígitos.");
                txtTelefono.Focus();
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
            if (txtCodigo.Text == "" && txtDNI.Text == "")
            {
                MessageBox.Show("Ingrese el código o el DNI para buscar.");
                return;
            }

            Cliente cliente = null;

            if (txtCodigo.Text != "")
            {
                cliente = SistemaDelivery.ListaClientes.Buscar(Convert.ToInt32(txtCodigo.Text));
            }

            if (cliente == null && txtDNI.Text != "")
            {
                NodoCliente aux = SistemaDelivery.ListaClientes.ObtenerCabeza();
                while (aux != null)
                {
                    if (aux.Datos.DNI == txtDNI.Text)
                    {
                        cliente = aux.Datos;
                        break;
                    }
                    aux = aux.Siguiente;
                }
            }

            if (cliente == null)
            {
                MessageBox.Show("Cliente no encontrado.");
                return;
            }
            txtCodigo.Text = cliente.Codigo.ToString();
            txtDNI.Text = cliente.DNI;
            txtNombre.Text = cliente.Nombre;
            txtTelefono.Text = cliente.Telefono;
            txtDireccion.Text = cliente.Direccion;
            cboZona.Text = cliente.Zona;

            // Seleccionar la fila en el DataGridView
            SeleccionarClienteEnGrid(cliente.Codigo);
        }

        private void SeleccionarClienteEnGrid(int codigo)
        {
            for (int i = 0; i < dgvClientes.Rows.Count; i++)
            {
                if (dgvClientes.Rows[i].Cells[0].Value != null && 
                    Convert.ToInt32(dgvClientes.Rows[i].Cells[0].Value) == codigo)
                {
                    dgvClientes.ClearSelection();
                    dgvClientes.Rows[i].Selected = true;
                    dgvClientes.FirstDisplayedScrollingRowIndex = i;
                    break;
                }
            }
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
