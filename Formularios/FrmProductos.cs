using RestaurantIngenieriaTrujillo.Entidades;
using RestaurantIngenieriaTrujillo.Estructuras.ListaProductos;
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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.Columns.Clear();

            dgvProductos.Columns.Add("Codigo", "Código");
            dgvProductos.Columns.Add("Nombre", "Nombre");
            dgvProductos.Columns.Add("Precio", "Precio");
            dgvProductos.Columns.Add("Tiempo", "Tiempo (min)");

            MostrarProductos();
        }
        private void Limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();

            txtTiempoPreparacion.Clear();

            txtCodigo.Focus();
        }
        private bool Validar()
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Ingrese el código.");
                return false;
            }

            if (!int.TryParse(txtCodigo.Text, out int codigo) || codigo <= 0)
            {
                MessageBox.Show("Ingrese un código valido.");
                return false;
            }

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre.");
                return false;
            }

            if (txtPrecio.Text == "")
            {
                MessageBox.Show("Ingrese el precio.");
                return false;
            }
            if (txtTiempoPreparacion.Text == "")
            {
                MessageBox.Show("Ingrese el tiempo de preparación.");
                txtTiempoPreparacion.Focus();
                return false;
            }

            if (!int.TryParse(txtTiempoPreparacion.Text, out int tiempo) || tiempo <= 0)
            {
                MessageBox.Show("El tiempo de preparación debe ser mínimo 1 minuto.");
                txtTiempoPreparacion.Focus();
                return false;
            }

            return true;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;

            int codigo = Convert.ToInt32(txtCodigo.Text);

            if (SistemaDelivery.ListaProductos.Buscar(codigo) != null)
            {
                MessageBox.Show("Ya existe un producto con ese código.");
                return;
            }

            Producto producto = new Producto(codigo, txtNombre.Text, Convert.ToDecimal(txtPrecio.Text), Convert.ToInt32(txtTiempoPreparacion.Text));


            SistemaDelivery.ListaProductos.Insertar(producto);

            MostrarProductos();

            Limpiar();

            MessageBox.Show("Producto registrado.");
        }
        private void MostrarProductos()
        {
            dgvProductos.Rows.Clear();

            ListaProductosResultado lista =
                SistemaDelivery.ListaProductos.ObtenerTodos();

            int contador = 0;
            NodoProductoResultado aux = lista.ObtenerPrimero();

            while (aux != null)
            {
                Producto p = aux.Datos;
                dgvProductos.Rows.Add(p.Codigo, p.Nombre, p.Precio, p.TiempoPreparacion);
                contador++;
                aux = aux.Siguiente;
            }

            lblCantidad.Text = "Productos registrados: " + contador;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Producto producto = SistemaDelivery.ListaProductos.Buscar(Convert.ToInt32(txtCodigo.Text));

            if (producto == null)
            {
                MessageBox.Show("Producto no encontrado.");
                return;
            }

            txtNombre.Text = producto.Nombre;
            txtPrecio.Text = producto.Precio.ToString();
            txtTiempoPreparacion.Text = producto.TiempoPreparacion.ToString();

            // Seleccionar la fila en el DataGridView
            SeleccionarProductoEnGrid(producto.Codigo);
        }

        private void SeleccionarProductoEnGrid(int codigo)
        {
            for (int i = 0; i < dgvProductos.Rows.Count; i++)
            {
                if (dgvProductos.Rows[i].Cells[0].Value != null && 
                    Convert.ToInt32(dgvProductos.Rows[i].Cells[0].Value) == codigo)
                {
                    dgvProductos.ClearSelection();
                    dgvProductos.Rows[i].Selected = true;
                    dgvProductos.FirstDisplayedScrollingRowIndex = i;
                    break;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;
            Producto producto = new Producto(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, Convert.ToDecimal(txtPrecio.Text),Convert.ToInt32(txtTiempoPreparacion.Text));
            bool modificado = SistemaDelivery.ListaProductos.Modificar(producto);

            if (modificado)
            {
                MessageBox.Show("Producto actualizado.");

                MostrarProductos();

                Limpiar();
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Ingrese el código.");
                return;
            }

            DialogResult r = MessageBox.Show(
                "¿Desea eliminar el producto?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r == DialogResult.No)
                return;

            bool eliminado =
                SistemaDelivery.ListaProductos.Eliminar(
                Convert.ToInt32(txtCodigo.Text));

            if (eliminado)
            {
                MostrarProductos();

                Limpiar();

                MessageBox.Show("Producto eliminado.");
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void dgvProductos_CellClick(object sender,
    DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            txtCodigo.Text =
                dgvProductos.Rows[e.RowIndex].Cells[0].Value.ToString();

            txtNombre.Text =
                dgvProductos.Rows[e.RowIndex].Cells[1].Value.ToString();

            txtPrecio.Text =
                dgvProductos.Rows[e.RowIndex].Cells[2].Value.ToString();

            txtTiempoPreparacion.Text =
                dgvProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) &&
                        !char.IsDigit(e.KeyChar);
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void txtTiempoPreparacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) &&
                        !char.IsDigit(e.KeyChar);
        }
    }
}
