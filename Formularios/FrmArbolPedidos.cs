using RestaurantIngenieriaTrujillo.Sistema;
using RestaurantIngenieriaTrujillo.Entidades;
using RestaurantIngenieriaTrujillo.Estructuras.Listas;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantIngenieriaTrujillo.Formularios
{
    public partial class FrmArbolPedidos : Form
    {
        public FrmArbolPedidos()
        {
            InitializeComponent();
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FrmArbolPedidos_Load(object sender, EventArgs e)
        {
            dgvArbol.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvArbol.Columns.Add("Codigo", "Código");

            dgvArbol.Columns.Add("Cliente", "Cliente");

            dgvArbol.Columns.Add("Producto", "Producto");

            dgvArbol.Columns.Add("Cantidad", "Cantidad");

            dgvArbol.Columns.Add("Total", "Total");

            dgvArbol.Columns.Add("Prioridad", "Prioridad");

            dgvArbol.Columns.Add("Repartidor", "Repartidor");

            Mostrar(
                SistemaDelivery.ArbolPedidos.InOrden());
        }
        private void Mostrar(ListaPedidosResultado lista)
        {
            dgvArbol.Rows.Clear();

            NodoPedidoResultado aux = lista.ObtenerPrimero();
            while (aux != null)
            {
                Pedido p = aux.Datos;
                dgvArbol.Rows.Add(
                    p.Codigo,
                    p.Cliente.Nombre,
                    p.Producto.Nombre,
                    p.Cantidad,
                    p.Total,
                    p.EsPrioritario ? "Sí" : "No",
                    p.Repartidor == null ? "Sin asignar" : p.Repartidor.Nombre);

                aux = aux.Siguiente;
            }

            lblCantidad.Text =
                "Total de pedidos : " +
                SistemaDelivery.ArbolPedidos.Contar();
        }
        private void btnInOrden_Click(object sender,
                              EventArgs e)
        {
            Mostrar(
                SistemaDelivery.ArbolPedidos.InOrden());
        }
        private void btnBuscar_Click(object sender,
                             EventArgs e)
        {
            if (txtBuscarCodigo.Text == "")
            {
                MessageBox.Show("Ingrese un código.");
                return;
            }

            Pedido pedido =
                SistemaDelivery.ArbolPedidos.Buscar(
                    Convert.ToInt32(
                        txtBuscarCodigo.Text));

            dgvArbol.Rows.Clear();

            if (pedido == null)
            {
                MessageBox.Show("Pedido no encontrado.");
                return;
            }

            dgvArbol.Rows.Add(
                pedido.Codigo,
                pedido.Cliente.Nombre,
                pedido.Producto.Nombre,
                pedido.Cantidad,
                pedido.Total,
                pedido.EsPrioritario ? "Sí" : "No",
                pedido.Repartidor == null ? "Sin asignar" : pedido.Repartidor.Nombre);
        }
        private void btnRango_Click(object sender,
                            EventArgs e)
        {
            int minimo =
                Convert.ToInt32(txtMinimo.Text);

            int maximo =
                Convert.ToInt32(txtMaximo.Text);

            Mostrar(
                SistemaDelivery.ArbolPedidos
                .BuscarPorRango(minimo, maximo));
        }
        private void btnBuscar_Click_1(object sender,
                                EventArgs e){}
    }
}
