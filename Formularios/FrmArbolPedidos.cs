using RestaurantIngenieriaTrujillo.Sistema;
using RestaurantIngenieriaTrujillo.Entidades;
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

            dgvArbol.Columns.Add("Estado", "Estado");

            dgvArbol.Columns.Add("Total", "Total");

            Mostrar(
                SistemaDelivery.ArbolPedidos.InOrden());
        }
        private void Mostrar(List<Pedido> lista)
        {
            dgvArbol.Rows.Clear();

            foreach (Pedido p in lista)
            {
                dgvArbol.Rows.Add(
                    p.Codigo,
                    p.Cliente.Nombre,
                    p.Producto.Nombre,
                    p.Estado,
                    p.Total);
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
        private void btnPreOrden_Click(object sender,
                               EventArgs e)
        {
            Mostrar(
                SistemaDelivery.ArbolPedidos.PreOrden());
        }
        private void btnPostOrden_Click(object sender,
                                EventArgs e)
        {
            Mostrar(
                SistemaDelivery.ArbolPedidos.PostOrden());
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
                pedido.Estado,
                pedido.Total);
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
