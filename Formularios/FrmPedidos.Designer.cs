namespace RestaurantIngenieriaTrujillo.Formularios
{
    partial class FrmPedidos
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            btnOrdenar = new Button();
            btnModificar = new Button();
            btnLimpiar = new Button();
            dgvPedidos = new DataGridView();
            txtCodigo = new TextBox();
            nudCantidad = new NumericUpDown();
            chkPrioridad = new CheckBox();
            cboRepartidor = new ComboBox();
            lblCantidad = new Label();
            cboCliente = new ComboBox();
            cboProducto = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(337, 33);
            label1.Name = "label1";
            label1.Size = new Size(311, 38);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO DE PEDIDOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 93);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "Codigo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 145);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 199);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "Producto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 249);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 4;
            label5.Text = "Cantidad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 300);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 5;
            label6.Text = "Prioridad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 351);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 6;
            label7.Text = "Repartidor:";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(211, 152);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(170, 29);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.ImageAlign = ContentAlignment.TopLeft;
            btnGuardar.Location = new Point(211, 105);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(170, 29);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.TopCenter;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(491, 105);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(170, 29);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(742, 105);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(170, 29);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(491, 152);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(170, 29);
            btnOrdenar.TabIndex = 11;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(742, 152);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(170, 29);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(750, 436);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(162, 29);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvPedidos
            // 
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(211, 187);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.Size = new Size(701, 243);
            dgvPedidos.TabIndex = 14;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(30, 116);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(150, 27);
            txtCodigo.TabIndex = 15;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(30, 272);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(150, 27);
            nudCantidad.TabIndex = 18;
            // 
            // chkPrioridad
            // 
            chkPrioridad.AutoSize = true;
            chkPrioridad.Location = new Point(30, 324);
            chkPrioridad.Name = "chkPrioridad";
            chkPrioridad.Size = new Size(92, 24);
            chkPrioridad.TabIndex = 19;
            chkPrioridad.Text = "Prioridad";
            chkPrioridad.UseVisualStyleBackColor = true;
            // 
            // cboRepartidor
            // 
            cboRepartidor.FormattingEnabled = true;
            cboRepartidor.Location = new Point(30, 374);
            cboRepartidor.Name = "cboRepartidor";
            cboRepartidor.Size = new Size(151, 28);
            cboRepartidor.TabIndex = 20;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(211, 436);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(149, 20);
            lblCantidad.TabIndex = 21;
            lblCantidad.Text = "Cantidad de Pedidos:";
            // 
            // cboCliente
            // 
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(30, 168);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(151, 28);
            cboCliente.TabIndex = 22;
            // 
            // cboProducto
            // 
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(30, 222);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(151, 28);
            cboProducto.TabIndex = 23;
            // 
            // FrmPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 496);
            Controls.Add(cboProducto);
            Controls.Add(cboCliente);
            Controls.Add(lblCantidad);
            Controls.Add(cboRepartidor);
            Controls.Add(chkPrioridad);
            Controls.Add(nudCantidad);
            Controls.Add(txtCodigo);
            Controls.Add(dgvPedidos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnModificar);
            Controls.Add(btnOrdenar);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmPedidos";
            Text = "FrmPedidos";
            Load += FrmPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnBuscar;
        private Button btnOrdenar;
        private Button btnModificar;
        private Button btnLimpiar;
        private DataGridView dgvPedidos;
        private TextBox txtCodigo;
        private NumericUpDown nudCantidad;
        private CheckBox chkPrioridad;
        private ComboBox cboRepartidor;
        private Label lblCantidad;
        private ComboBox cboCliente;
        private ComboBox cboProducto;
    }
}