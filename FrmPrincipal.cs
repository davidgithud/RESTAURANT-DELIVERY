using RestaurantIngenieriaTrujillo.Formularios;

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
            Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
