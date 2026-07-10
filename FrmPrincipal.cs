using RestaurantIngenieriaTrujillo.Formularios;
using RestaurantIngenieriaTrujillo.Entidades;
using RestaurantIngenieriaTrujillo.Sistema;

namespace RestaurantIngenieriaTrujillo
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void gestionarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedidos frm = new FrmPedidos();

            frm.ShowDialog();

        }

        private void ClientestoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            frm.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductos frm = new FrmProductos();
            frm.ShowDialog();
        }

        private void repartidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRepartidores frm = new FrmRepartidores();
            frm.ShowDialog();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHistorial frm = new FrmHistorial();
            frm.ShowDialog();
        }

        private void aBBPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmArbolPedidos frm = new FrmArbolPedidos();
            frm.ShowDialog();
        }

        private void rutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRutas frm = new FrmRutas();
            frm.ShowDialog();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Desea salir de la aplicación?",
                "Confirmar Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            InicializarGrafo();
        }

        private void InicializarGrafo()
        {
            if (SistemaDelivery.Grafo.CantidadZonas() > 0)
                return;

            SistemaDelivery.Grafo.AgregarZona(new Zona(0, "Restaurant"));
            SistemaDelivery.Grafo.AgregarZona(new Zona(1, "Centro"));
            SistemaDelivery.Grafo.AgregarZona(new Zona(2, "California"));
            SistemaDelivery.Grafo.AgregarZona(new Zona(3, "El Recreo"));
            SistemaDelivery.Grafo.AgregarZona(new Zona(4, "Primavera"));
            SistemaDelivery.Grafo.AgregarZona(new Zona(5, "San Andrés"));
            SistemaDelivery.Grafo.AgregarZona(new Zona(6, "Las Quintanas"));
            SistemaDelivery.Grafo.AgregarZona(new Zona(7, "Palermo"));
            SistemaDelivery.Grafo.AgregarZona(new Zona(8, "El Golf"));
            SistemaDelivery.Grafo.AgregarZona(new Zona(9, "Víctor Larco"));

            SistemaDelivery.Grafo.AgregarConexion(0, 1, 2);
            SistemaDelivery.Grafo.AgregarConexion(0, 2, 4);
            SistemaDelivery.Grafo.AgregarConexion(1, 3, 2);
            SistemaDelivery.Grafo.AgregarConexion(2, 4, 3);
            SistemaDelivery.Grafo.AgregarConexion(3, 5, 2);
            SistemaDelivery.Grafo.AgregarConexion(4, 6, 2);
            SistemaDelivery.Grafo.AgregarConexion(5, 7, 3);
            SistemaDelivery.Grafo.AgregarConexion(6, 8, 2);
            SistemaDelivery.Grafo.AgregarConexion(8, 9, 4);
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
