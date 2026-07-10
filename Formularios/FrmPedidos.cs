using RestaurantIngenieriaTrujillo.Entidades;
using RestaurantIngenieriaTrujillo.Estructuras.Cola;
using RestaurantIngenieriaTrujillo.Estructuras.ListaDoble;
using RestaurantIngenieriaTrujillo.Estructuras.ListaProductos;
using RestaurantIngenieriaTrujillo.Estructuras.ListaSimple;
using RestaurantIngenieriaTrujillo.Estructuras.ListaCircular;
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

            dgvPedidos.CellClick += dgvPedidos_CellClick;

            CargarClientes();
            CargarProductos();
            CargarRepartidores();
            MostrarPedidos();

        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Seleccione un pedido.");
                return;
            }

            int cod = Convert.ToInt32(txtCodigo.Text);
            Pedido p = SistemaDelivery.ArbolPedidos.Buscar(cod);
            if (p != null)
            {
                // Guardar nombre del cliente antes de eliminar el pedido
                string nombreCliente = p.Cliente != null ? p.Cliente.Nombre : "N/A";

                // Ajustar conteo del repartidor si existe
                if (p.Repartidor != null)
                {
                    p.Repartidor.PedidosAsignados--;
                    if (p.Repartidor.PedidosAsignados < 3)
                        p.Repartidor.Disponible = true;
                }

                // Marcar como completado
                p.EsCompletado = true;
                SistemaDelivery.Historial.Insertar(new HistorialEstado(p.Codigo, nombreCliente, "Entregado"));

                // Eliminar del árbol de pedidos
                SistemaDelivery.ArbolPedidos.Eliminar(cod);

                // Eliminar de la cola correspondiente (prioridad o normal)
                SistemaDelivery.ColaPrioridad.Eliminar(cod);
                SistemaDelivery.ColaPedidos.Eliminar(cod);

                MostrarPedidos();
                MessageBox.Show("Pedido atendido y eliminado del sistema.");
                LimpiarPedido();
            }
        }

        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvPedidos.Rows[e.RowIndex];
            txtCodigo.Text = row.Cells[0].Value?.ToString();
            nudCantidad.Value = Convert.ToDecimal(row.Cells[3].Value);
            chkPrioridad.Checked = row.Cells[5].Value?.ToString() == "Sí";

            foreach (Cliente c in cboCliente.Items)
            {
                if (c.Nombre == row.Cells[1].Value?.ToString()) { cboCliente.SelectedItem = c; break; }
            }
            foreach (Producto pr in cboProducto.Items)
            {
                if (pr.Nombre == row.Cells[2].Value?.ToString()) { cboProducto.SelectedItem = pr; break; }
            }
            foreach (Repartidor r in cboRepartidor.Items)
            {
                if (r.Nombre == row.Cells[7].Value?.ToString()) { cboRepartidor.SelectedItem = r; break; }
            }
        }

        private void MostrarPedidos()
        {
            dgvPedidos.Rows.Clear();

            // Cola Prioridad
            RestaurantIngenieriaTrujillo.Estructuras.ColaPrioridad.NodoPrioridad auxP = SistemaDelivery.ColaPrioridad.ObtenerFrente();
            while (auxP != null)
            {
                // No mostrar pedidos completados
                if (!auxP.Datos.EsCompletado)
                {
                    dgvPedidos.Rows.Add(auxP.Datos.Codigo, auxP.Datos.Cliente.Nombre, auxP.Datos.Producto.Nombre, auxP.Datos.Cantidad, auxP.Datos.Total, auxP.Datos.EsPrioritario ? "Sí" : "No", auxP.Datos.Estado, auxP.Datos.Repartidor == null ? "Sin asignar" : auxP.Datos.Repartidor.Nombre);
                }
                auxP = auxP.Siguiente;
            }

            NodoCola aux = SistemaDelivery.ColaPedidos.ObtenerFrente();
            
            // Cola Pedido
            while (aux != null)
            {
                // No mostrar pedidos completados
                if (!aux.Datos.EsCompletado)
                {
                    dgvPedidos.Rows.Add(aux.Datos.Codigo, aux.Datos.Cliente.Nombre, aux.Datos.Producto.Nombre, aux.Datos.Cantidad, aux.Datos.Total, aux.Datos.EsPrioritario ? "Sí" : "No", aux.Datos.Estado, aux.Datos.Repartidor == null ? "Sin asignar" : aux.Datos.Repartidor.Nombre);
                }

                aux = aux.Siguiente;
            }

            lblCantidad.Text = "Pedidos en cola Normal: " + SistemaDelivery.ColaPedidos.Contar() + " | Prioridad: " + SistemaDelivery.ColaPrioridad.Contar();
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

            ListaRepartidoresResultado lista = SistemaDelivery.ListaRepartidores.ObtenerTodos();
            NodoRepartidorResultado aux = lista.ObtenerPrimero();

            while (aux != null)
            {
                Repartidor r = aux.Datos;
                cboRepartidor.Items.Add(r);
                aux = aux.Siguiente;
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

            if (!int.TryParse(txtCodigo.Text, out int codigo) || codigo <= 0)
            {
                MessageBox.Show("Ingrese un código valido.");
                txtCodigo.Focus();
                return;
            }

            if (SistemaDelivery.ArbolPedidos.Existe(Convert.ToInt32(txtCodigo.Text)))
            {
                MessageBox.Show("Ya existe un pedido con ese código.");
                return;
            }

            if (nudCantidad.Value <= 0)
            {
                MessageBox.Show("La cantidad debe ser mínimo 1.");
                nudCantidad.Focus();
                return;
            }

            Cliente cliente = (Cliente)cboCliente.SelectedItem;

            Producto producto = (Producto)cboProducto.SelectedItem;

            // Asignación automática del repartidor
            Repartidor repartidorManual = null;
            if (cboRepartidor.SelectedItem != null)
                repartidorManual = (Repartidor)cboRepartidor.SelectedItem;

            Repartidor repartidor = null;

            if (repartidorManual != null)
            {
                if (!repartidorManual.Disponible || repartidorManual.PedidosAsignados >= 3)
                {
                    MessageBox.Show("El repartidor seleccionado no está disponible (límite 3 pedidos).");
                    return;
                }

                repartidor = repartidorManual;
            }
            else
            {
                repartidor = SistemaDelivery.ListaRepartidores.ObtenerSiguienteRepartidor();
            }

            // Si no hay repartidor disponible, no registrar el pedido
            if (repartidor == null)
            {
                MessageBox.Show("Repartidores no disponibles");
                return;
            }

            Pedido pedido = new Pedido(
                Convert.ToInt32(txtCodigo.Text),
                cliente,
                producto,
                (int)nudCantidad.Value,
                chkPrioridad.Checked,
                "Pendiente",
                repartidor
            );

            // Aumentar contador de pedidos del repartidor asignado y actualizar disponibilidad
            repartidor.PedidosAsignados++;
            if (repartidor.PedidosAsignados >= 3)
                repartidor.Disponible = false;

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
                    pedido.Cliente != null ? pedido.Cliente.Nombre : "N/A",
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
            LimpiarPedido();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Seleccione un pedido a eliminar.");
                return;
            }

            int cod = Convert.ToInt32(txtCodigo.Text);
            Pedido p = SistemaDelivery.ArbolPedidos.Buscar(cod);

            if (p == null)
            {
                MessageBox.Show("Pedido no encontrado.");
                return;
            }

            if (MessageBox.Show("¿Desea eliminar este pedido?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Guardar nombre del cliente antes de eliminar el pedido
                string nombreCliente = p.Cliente != null ? p.Cliente.Nombre : "N/A";

                // Agregar al historial como eliminado antes de quitarlo del sistema
                SistemaDelivery.Historial.Insertar(new HistorialEstado(p.Codigo, nombreCliente, "Eliminado"));

                // Marcar como completado para que no aparezca en la vista de pedidos
                p.EsCompletado = true;

                // Ajustar conteo del repartidor si existe
                if (p.Repartidor != null)
                {
                    p.Repartidor.PedidosAsignados--;
                    if (p.Repartidor.PedidosAsignados < 3)
                        p.Repartidor.Disponible = true;
                }

                SistemaDelivery.ArbolPedidos.Eliminar(cod);
                // Eliminar de la cola correspondiente (prioridad o normal)
                SistemaDelivery.ColaPrioridad.Eliminar(cod);
                SistemaDelivery.ColaPedidos.Eliminar(cod);
                MostrarPedidos();
                LimpiarPedido();
                MessageBox.Show("Pedido eliminado correctamente.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "") return;
            Pedido p = SistemaDelivery.ArbolPedidos.Buscar(Convert.ToInt32(txtCodigo.Text));
            if (p != null)
            {
                nudCantidad.Value = p.Cantidad;
                chkPrioridad.Checked = p.EsPrioritario;
                foreach (Cliente c in cboCliente.Items)
                {
                    if (c.Codigo == p.Cliente.Codigo) { cboCliente.SelectedItem = c; break; }
                }
                foreach (Producto pr in cboProducto.Items)
                {
                    if (pr.Codigo == p.Producto.Codigo) { cboProducto.SelectedItem = pr; break; }
                }
                if (p.Repartidor != null)
                {
                    foreach (Repartidor r in cboRepartidor.Items)
                    {
                        if (r.Codigo == p.Repartidor.Codigo) { cboRepartidor.SelectedItem = r; break; }
                    }
                }
                MessageBox.Show("Pedido encontrado.");

                // Seleccionar la fila en el DataGridView
                SeleccionarPedidoEnGrid(p.Codigo);
            }
            else
            {
                MessageBox.Show("Pedido no encontrado.");
            }
        }

        private void SeleccionarPedidoEnGrid(int codigo)
        {
            for (int i = 0; i < dgvPedidos.Rows.Count; i++)
            {
                if (dgvPedidos.Rows[i].Cells[0].Value != null && 
                    Convert.ToInt32(dgvPedidos.Rows[i].Cells[0].Value) == codigo)
                {
                    dgvPedidos.ClearSelection();
                    dgvPedidos.Rows[i].Selected = true;
                    dgvPedidos.FirstDisplayedScrollingRowIndex = i;
                    break;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "") return;
            Pedido p = SistemaDelivery.ArbolPedidos.Buscar(Convert.ToInt32(txtCodigo.Text));
            if(p != null)
            {
                // Manejar reasignación de repartidor con límite de 3 pedidos
                Repartidor antiguo = p.Repartidor;
                Repartidor nuevo = (Repartidor)cboRepartidor.SelectedItem;

                // Solo validar si estamos cambiando a un repartidor diferente
                if (nuevo != null && nuevo != antiguo && (!nuevo.Disponible || nuevo.PedidosAsignados >= 3))
                {
                    MessageBox.Show("El repartidor seleccionado no está disponible (límite 3 pedidos).");
                    return;
                }

                // Restar del repartidor antiguo
                if (antiguo != null && antiguo != nuevo)
                {
                    antiguo.PedidosAsignados--;
                    if (antiguo.PedidosAsignados < 3) antiguo.Disponible = true;
                }

                // Sumar al repartidor nuevo (solo si es diferente)
                if (nuevo != null && nuevo != antiguo)
                {
                    nuevo.PedidosAsignados++;
                    if (nuevo.PedidosAsignados >= 3) nuevo.Disponible = false;
                }

                p.Cliente = (Cliente)cboCliente.SelectedItem;
                p.Producto = (Producto)cboProducto.SelectedItem;
                p.Cantidad = (int)nudCantidad.Value;
                p.EsPrioritario = chkPrioridad.Checked;
                p.Repartidor = nuevo;
                p.Total = p.Producto.Precio * p.Cantidad;
                MostrarPedidos();
                MessageBox.Show("Pedido modificado.");
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarPedido();
        }
    }
}
