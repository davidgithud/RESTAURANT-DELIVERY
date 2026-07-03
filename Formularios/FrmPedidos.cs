using RestaurantIngenieriaTrujillo.Entidades;
using RestaurantIngenieriaTrujillo.Estructuras.Cola;
using RestaurantIngenieriaTrujillo.Estructuras.ListaDoble;
using RestaurantIngenieriaTrujillo.Estructuras.ListaProductos;
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
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }


        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            dgvPedidos.Columns.Clear();

            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvPedidos.Columns.Add("Codigo", "Código");
            dgvPedidos.Columns.Add("Cliente", "Cliente");
            dgvPedidos.Columns.Add("Producto", "Producto");
            dgvPedidos.Columns.Add("Cantidad", "Cantidad");
            dgvPedidos.Columns.Add("Total", "Total");
            dgvPedidos.Columns.Add("Prioridad", "Prioridad");
            dgvPedidos.Columns.Add("Estado", "Estado");
            dgvPedidos.Columns.Add("Repartidor", "Repartidor");

            CargarClientes();
            CargarProductos();
            CargarRepartidores();
            MostrarPedidos();

        }

        private void MostrarPedidos()
        {
            dgvPedidos.Rows.Clear();

            NodoCola aux = SistemaDelivery.ColaPedidos.ObtenerFrente();

            while (aux != null)
            {
                dgvPedidos.Rows.Add(aux.Datos.Codigo, aux.Datos.Cliente.Nombre, aux.Datos.Producto.Nombre, aux.Datos.Cantidad, aux.Datos.Total, aux.Datos.EsPrioritario ? "Sí" : "No", aux.Datos.Estado, aux.Datos.Repartidor == null ? "Sin asignar" : aux.Datos.Repartidor.Nombre);

                aux = aux.Siguiente;
            }

            lblCantidad.Text = "Pedidos en cola: " + SistemaDelivery.ColaPedidos.Contar();
        }
        private void CargarClientes()
        {
            cboCliente.Items.Clear();

            NodoCliente aux = SistemaDelivery.ListaClientes.ObtenerCabeza();

            while (aux != null)
            {
                cboCliente.Items.Add(aux.Datos);
                aux = aux.Siguiente;
            }

            if (cboCliente.Items.Count > 0)
                cboCliente.SelectedIndex = 0;
        }
        private void CargarProductos()
        {
            cboProducto.Items.Clear();

            NodoProducto aux = SistemaDelivery.ListaProductos.ObtenerPrimero();

            while (aux != null)
            {
                cboProducto.Items.Add(aux.Datos);

                aux = aux.Siguiente;
            }

            if (cboProducto.Items.Count > 0)
                cboProducto.SelectedIndex = 0;
        }
        private void CargarRepartidores()
        {
            cboRepartidor.Items.Clear();

            foreach (Repartidor r in SistemaDelivery.ListaRepartidores.ObtenerTodos())
            {
                cboRepartidor.Items.Add(r);
            }

            if (cboRepartidor.Items.Count > 0)
                cboRepartidor.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el código del pedido.");
                txtCodigo.Focus();
                return;
            }

            if (SistemaDelivery.ArbolPedidos.Existe(Convert.ToInt32(txtCodigo.Text)))
            {
                MessageBox.Show("Ya existe un pedido con ese código.");
                return;
            }

            Cliente cliente = (Cliente)cboCliente.SelectedItem;

            Producto producto = (Producto)cboProducto.SelectedItem;

            // Asignación automática del repartidor (Lista Circular)
            Repartidor repartidor =
                SistemaDelivery.ListaRepartidores.ObtenerSiguienteRepartidor();

            Pedido pedido = new Pedido(
                Convert.ToInt32(txtCodigo.Text),
                cliente,
                producto,
                (int)nudCantidad.Value,
                chkPrioridad.Checked,
                "Pendiente",
                repartidor
            );

            // Cola correspondiente
            if (pedido.EsPrioritario)
                SistemaDelivery.ColaPrioridad.Encolar(pedido);
            else
                SistemaDelivery.ColaPedidos.Encolar(pedido);

            // ABB
            SistemaDelivery.ArbolPedidos.Insertar(pedido);

            // Historial
            SistemaDelivery.Historial.Insertar(
                new HistorialEstado(
                    pedido.Codigo,
                    pedido.Estado));

            // Pila
            SistemaDelivery.PilaCambios.Push(pedido);

            MostrarPedidos();

            LimpiarPedido();

            MessageBox.Show("Pedido registrado correctamente.");
        }
        private void LimpiarPedido()
        {
            txtCodigo.Clear();

            nudCantidad.Value = 1;

            chkPrioridad.Checked = false;

            if (cboCliente.Items.Count > 0)
                cboCliente.SelectedIndex = 0;

            if (cboProducto.Items.Count > 0)
                cboProducto.SelectedIndex = 0;

            if (cboRepartidor.Items.Count > 0)
                cboRepartidor.SelectedIndex = 0;

            txtCodigo.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
