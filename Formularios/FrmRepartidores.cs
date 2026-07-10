using RestaurantIngenieriaTrujillo.Entidades;
using RestaurantIngenieriaTrujillo.Estructuras.ListaCircular;
using RestaurantIngenieriaTrujillo.Estructuras.Listas;
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

            dgvRepartidores.CellClick += dgvRepartidores_CellClick;

            Mostrar();
        }

        private void dgvRepartidores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtCodigo.Text = dgvRepartidores.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNombre.Text = dgvRepartidores.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTelefono.Text = dgvRepartidores.Rows[e.RowIndex].Cells[2].Value.ToString();
            chkDisponible.Checked = dgvRepartidores.Rows[e.RowIndex].Cells[3].Value.ToString() == "Sí";
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
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Ingrese el código.");
                return;
            }

            if (!int.TryParse(txtCodigo.Text, out int codigo) || codigo <= 0)
            {
                MessageBox.Show("Ingrese un código valido.");
                return;
            }

            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre.");
                return;
            }

            if (txtTelefono.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el teléfono.");
                return;
            }

            if (txtTelefono.Text.Length != 9)
            {
                MessageBox.Show("El teléfono debe tener 9 dígitos.");
                return;
            }

            Repartidor existente = SistemaDelivery.ListaRepartidores.Buscar(codigo);

            if (existente != null)
            {
                MessageBox.Show("Ya existe un repartidor con ese código. Use 'Modificar' para actualizar.");
                return;
            }

            Repartidor r = new Repartidor(
                codigo,
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
            MessageBox.Show("Repartidor encontrado. Use 'Modificar' para actualizar sus datos.");

            // Seleccionar la fila en el DataGridView
            SeleccionarRepartidorEnGrid(r.Codigo);
        }

        private void SeleccionarRepartidorEnGrid(int codigo)
        {
            for (int i = 0; i < dgvRepartidores.Rows.Count; i++)
            {
                if (dgvRepartidores.Rows[i].Cells[0].Value != null && 
                    Convert.ToInt32(dgvRepartidores.Rows[i].Cells[0].Value) == codigo)
                {
                    dgvRepartidores.ClearSelection();
                    dgvRepartidores.Rows[i].Selected = true;
                    dgvRepartidores.FirstDisplayedScrollingRowIndex = i;
                    break;
                }
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Seleccione o ingrese código a modificar.");
                return;
            }

            Repartidor r = new Repartidor(
                Convert.ToInt32(txtCodigo.Text),
                txtNombre.Text,
                txtTelefono.Text,
                chkDisponible.Checked);

            bool ok = SistemaDelivery.ListaRepartidores.Modificar(r);
            if(ok)
            {
                MessageBox.Show("Repartidor modificado correctamente.");
                Mostrar();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Repartidor no encontrado.");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Ingrese o seleccione un repartidor a eliminar.");
                return;
            }

            int codigoRepartidor = Convert.ToInt32(txtCodigo.Text);

            // Verificar si el repartidor está asignado a pedidos pendientes
            ListaPedidosResultado pedidosActivos = SistemaDelivery.ArbolPedidos.InOrden();
            bool tieneAsignaciones = false;

            NodoPedidoResultado aux = pedidosActivos.ObtenerPrimero();
            while (aux != null)
            {
                Pedido p = aux.Datos;
                if (p.Repartidor != null && p.Repartidor.Codigo == codigoRepartidor && !p.EsCompletado)
                {
                    tieneAsignaciones = true;
                    break;
                }
                aux = aux.Siguiente;
            }

            if (tieneAsignaciones)
            {
                MessageBox.Show("No se puede eliminar este repartidor ya que tiene pedidos asignados pendientes de atender.\nEntregue o cancele los pedidos primero.");
                return;
            }

            SistemaDelivery.ListaRepartidores.Eliminar(codigoRepartidor);

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
