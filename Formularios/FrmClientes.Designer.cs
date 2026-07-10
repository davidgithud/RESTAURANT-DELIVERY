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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            btnGuardar = new Button();
            btnBuscar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            lblCantidad = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(22, 55);
            label1.Name = "label1";
            label1.Size = new Size(49, 16);
            label1.TabIndex = 0;
            label1.Text = "Codigo:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.ForeColor = Color.DimGray;
            lblDNI.Location = new Point(20, 165);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(30, 16);
            lblDNI.TabIndex = 1;
            lblDNI.Text = "DNI:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = Color.DimGray;
            lblNombre.Location = new Point(22, 111);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 16);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.ForeColor = Color.DimGray;
            lblTelefono.Location = new Point(116, 166);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(57, 16);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Telefono:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.ForeColor = Color.DimGray;
            lblDireccion.Location = new Point(22, 222);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(60, 16);
            lblDireccion.TabIndex = 4;
            lblDireccion.Text = "Direccion:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(22, 278);
            label6.Name = "label6";
            label6.Size = new Size(37, 16);
            label6.TabIndex = 5;
            label6.Text = "Zona:";
            // 
            // txtCodigo
            // 
            txtCodigo.Cursor = Cursors.IBeam;
            txtCodigo.Location = new Point(22, 72);
            txtCodigo.Margin = new Padding(3, 2, 3, 2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(88, 23);
            txtCodigo.TabIndex = 6;
            txtCodigo.KeyPress += txtCodigo_KeyPress;
            // 
            // txtDNI
            // 
            txtDNI.Cursor = Cursors.IBeam;
            txtDNI.Location = new Point(22, 183);
            txtDNI.Margin = new Padding(3, 2, 3, 2);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(88, 23);
            txtDNI.TabIndex = 9;
            txtDNI.KeyPress += txtDNI_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(22, 128);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(182, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtTelefono
            // 
            txtTelefono.Cursor = Cursors.IBeam;
            txtTelefono.Location = new Point(116, 183);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(88, 23);
            txtTelefono.TabIndex = 10;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // txtDireccion
            // 
            txtDireccion.Cursor = Cursors.IBeam;
            txtDireccion.Location = new Point(22, 239);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(182, 23);
            txtDireccion.TabIndex = 11;
            // 
            // cboZona
            // 
            cboZona.Cursor = Cursors.Hand;
            cboZona.FormattingEnabled = true;
            cboZona.Location = new Point(22, 296);
            cboZona.Margin = new Padding(3, 2, 3, 2);
            cboZona.Name = "cboZona";
            cboZona.Size = new Size(182, 24);
            cboZona.TabIndex = 12;
            // 
            // dgvClientes
            // 
            dataGridViewCellStyle1.Font = new Font("Microsoft Tai Le", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.Bisque;
            dgvClientes.BorderStyle = BorderStyle.Fixed3D;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(228, 72);
            dgvClientes.Margin = new Padding(3, 2, 3, 2);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(492, 248);
            dgvClientes.TabIndex = 17;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.White;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderColor = Color.Orange;
            btnGuardar.Font = new Font("Microsoft Tai Le", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ControlText;
            btnGuardar.Location = new Point(116, 342);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(88, 27);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Location = new Point(116, 70);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(88, 27);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.Location = new Point(228, 342);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(88, 27);
            btnModificar.TabIndex = 15;
            btnModificar.Text = "Editar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Location = new Point(322, 342);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(88, 27);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Location = new Point(22, 342);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(88, 27);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Microsoft Tai Le", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidad.ForeColor = Color.DimGray;
            lblCantidad.Location = new Point(228, 54);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(115, 14);
            lblCantidad.TabIndex = 20;
            lblCantidad.Text = "Cantidad de clientes:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(22, 20);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 21;
            label2.Text = "REGISTRO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(385, 20);
            label3.Name = "label3";
            label3.Size = new Size(153, 19);
            label3.TabIndex = 22;
            label3.Text = "DATOS DE CLIENTES";
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(745, 390);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblCantidad);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnBuscar);
            Controls.Add(btnGuardar);
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
            Font = new Font("Microsoft Tai Le", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
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
        private Button btnGuardar;
        private Button btnBuscar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Label lblCantidad;
        private Label label2;
        private Label label3;
    }
}