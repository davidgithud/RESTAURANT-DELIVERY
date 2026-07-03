namespace RestaurantIngenieriaTrujillo.Formularios
{
    partial class FrmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblDNI = new Label();
            lblNombre = new Label();
            lblTelefono = new Label();
            lblDireccion = new Label();
            label6 = new Label();
            txtCodigo = new TextBox();
            txtDNI = new TextBox();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            cboZona = new ComboBox();
            dgvClientes = new DataGridView();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnBuscar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnOrdenar = new Button();
            btnLimpiar = new Button();
            lblCantidad = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 66);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Codigo:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(24, 118);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(38, 20);
            lblDNI.TabIndex = 1;
            lblDNI.Text = "DNI:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(24, 170);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(24, 228);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Telefono:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(24, 284);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(75, 20);
            lblDireccion.TabIndex = 4;
            lblDireccion.Text = "Direccion:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 343);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 5;
            label6.Text = "Zona:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(24, 89);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(151, 27);
            txtCodigo.TabIndex = 6;
            txtCodigo.KeyPress += txtCodigo_KeyPress;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(24, 141);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(151, 27);
            txtDNI.TabIndex = 7;
            txtDNI.KeyPress += txtDNI_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(24, 193);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(151, 27);
            txtNombre.TabIndex = 8;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(24, 251);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(151, 27);
            txtTelefono.TabIndex = 9;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(24, 307);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(151, 27);
            txtDireccion.TabIndex = 10;
            // 
            // cboZona
            // 
            cboZona.FormattingEnabled = true;
            cboZona.Location = new Point(24, 366);
            cboZona.Name = "cboZona";
            cboZona.Size = new Size(151, 28);
            cboZona.TabIndex = 11;
            // 
            // dgvClientes
            // 
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(212, 89);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(562, 245);
            dgvClientes.TabIndex = 12;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(616, 378);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(158, 29);
            btnNuevo.TabIndex = 13;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(212, 378);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(161, 29);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(803, 86);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(136, 29);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(803, 140);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(136, 29);
            btnModificar.TabIndex = 16;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(803, 192);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(136, 29);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(803, 248);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(136, 29);
            btnOrdenar.TabIndex = 18;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(803, 306);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(136, 29);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(212, 341);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(147, 20);
            lblCantidad.TabIndex = 20;
            lblCantidad.Text = "Cantidad de clientes:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(307, 22);
            label2.Name = "label2";
            label2.Size = new Size(326, 38);
            label2.TabIndex = 21;
            label2.Text = "REGISTRO DE CLIENTES";
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 450);
            Controls.Add(label2);
            Controls.Add(lblCantidad);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOrdenar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnBuscar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(dgvClientes);
            Controls.Add(cboZona);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(txtDNI);
            Controls.Add(txtCodigo);
            Controls.Add(label6);
            Controls.Add(lblDireccion);
            Controls.Add(lblTelefono);
            Controls.Add(lblNombre);
            Controls.Add(lblDNI);
            Controls.Add(label1);
            Name = "FrmClientes";
            Text = "FrmClientes";
            Load += FrmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblDNI;
        private Label lblNombre;
        private Label lblTelefono;
        private Label lblDireccion;
        private Label label6;
        private TextBox txtCodigo;
        private TextBox txtDNI;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private ComboBox cboZona;
        private DataGridView dgvClientes;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnBuscar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnOrdenar;
        private Button btnLimpiar;
        private Label lblCantidad;
        private Label label2;
    }
}