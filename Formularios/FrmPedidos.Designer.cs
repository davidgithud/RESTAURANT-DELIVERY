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
            label7 = new Label();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            btnModificar = new Button();
            btnLimpiar = new Button();
            btnAtender = new Button();
            dgvPedidos = new DataGridView();
            txtCodigo = new TextBox();
            nudCantidad = new NumericUpDown();
            chkPrioridad = new CheckBox();
            cboRepartidor = new ComboBox();
            cboCliente = new ComboBox();
            cboProducto = new ComboBox();
            lblCantidad = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(26, 45);
            label1.Name = "label1";
            label1.Size = new Size(81, 19);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(26, 84);
            label2.Name = "label2";
            label2.Size = new Size(49, 16);
            label2.TabIndex = 1;
            label2.Text = "Codigo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(26, 139);
            label3.Name = "label3";
            label3.Size = new Size(47, 16);
            label3.TabIndex = 2;
            label3.Text = "Cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(26, 198);
            label4.Name = "label4";
            label4.Size = new Size(59, 16);
            label4.TabIndex = 3;
            label4.Text = "Producto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(26, 256);
            label5.Name = "label5";
            label5.Size = new Size(58, 16);
            label5.TabIndex = 4;
            label5.Text = "Cantidad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(26, 314);
            label7.Name = "label7";
            label7.Size = new Size(65, 16);
            label7.TabIndex = 6;
            label7.Text = "Repartidor:";
            // 
            // btnGuardar
            // 
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Location = new Point(106, 377);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(80, 27);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Location = new Point(297, 377);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(80, 27);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Location = new Point(106, 100);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(80, 27);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.Location = new Point(211, 377);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(80, 27);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Editar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Location = new Point(26, 377);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(74, 27);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAtender
            // 
            btnAtender.Cursor = Cursors.Hand;
            btnAtender.Location = new Point(707, 377);
            btnAtender.Margin = new Padding(3, 2, 3, 2);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(117, 27);
            btnAtender.TabIndex = 12;
            btnAtender.Text = "Atender Pedido";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // dgvPedidos
            // 
            dgvPedidos.BackgroundColor = Color.Bisque;
            dgvPedidos.BorderStyle = BorderStyle.Fixed3D;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(211, 102);
            dgvPedidos.Margin = new Padding(3, 2, 3, 2);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.Size = new Size(613, 254);
            dgvPedidos.TabIndex = 13;
            // 
            // txtCodigo
            // 
            txtCodigo.Cursor = Cursors.IBeam;
            txtCodigo.Location = new Point(27, 102);
            txtCodigo.Margin = new Padding(3, 2, 3, 2);
            txtCodigo.MaxLength = 10;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(73, 23);
            txtCodigo.TabIndex = 1;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(26, 274);
            nudCantidad.Margin = new Padding(3, 2, 3, 2);
            nudCantidad.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(74, 23);
            nudCantidad.TabIndex = 5;
            nudCantidad.TextAlign = HorizontalAlignment.Center;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // chkPrioridad
            // 
            chkPrioridad.AutoSize = true;
            chkPrioridad.Font = new Font("Microsoft Tai Le", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkPrioridad.ForeColor = Color.DimGray;
            chkPrioridad.Location = new Point(113, 276);
            chkPrioridad.Margin = new Padding(3, 2, 3, 2);
            chkPrioridad.Name = "chkPrioridad";
            chkPrioridad.Size = new Size(73, 18);
            chkPrioridad.TabIndex = 6;
            chkPrioridad.Text = "Prioridad";
            chkPrioridad.UseVisualStyleBackColor = true;
            // 
            // cboRepartidor
            // 
            cboRepartidor.Cursor = Cursors.Hand;
            cboRepartidor.FormattingEnabled = true;
            cboRepartidor.Location = new Point(26, 332);
            cboRepartidor.Margin = new Padding(3, 2, 3, 2);
            cboRepartidor.Name = "cboRepartidor";
            cboRepartidor.Size = new Size(160, 24);
            cboRepartidor.TabIndex = 7;
            // 
            // cboCliente
            // 
            cboCliente.Cursor = Cursors.Hand;
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(26, 157);
            cboCliente.Margin = new Padding(3, 2, 3, 2);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(160, 24);
            cboCliente.TabIndex = 3;
            // 
            // cboProducto
            // 
            cboProducto.Cursor = Cursors.Hand;
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(26, 216);
            cboProducto.Margin = new Padding(3, 2, 3, 2);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(160, 24);
            cboProducto.TabIndex = 4;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Microsoft Tai Le", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidad.ForeColor = Color.DimGray;
            lblCantidad.Location = new Point(211, 84);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(117, 14);
            lblCantidad.TabIndex = 21;
            lblCantidad.Text = "Cantidad de Pedidos:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Orange;
            label6.Location = new Point(414, 45);
            label6.Name = "label6";
            label6.Size = new Size(149, 19);
            label6.TabIndex = 25;
            label6.Text = "DATOS DE PEDIDOS";
            // 
            // FrmPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 431);
            Controls.Add(label6);
            Controls.Add(cboProducto);
            Controls.Add(cboCliente);
            Controls.Add(lblCantidad);
            Controls.Add(cboRepartidor);
            Controls.Add(chkPrioridad);
            Controls.Add(nudCantidad);
            Controls.Add(txtCodigo);
            Controls.Add(dgvPedidos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAtender);
            Controls.Add(btnModificar);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Tai Le", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
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
        private Label label7;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnBuscar;
        private Button btnModificar;
        private Button btnLimpiar;
        private Button btnAtender;
        private DataGridView dgvPedidos;
        private TextBox txtCodigo;
        private NumericUpDown nudCantidad;
        private CheckBox chkPrioridad;
        private ComboBox cboRepartidor;
        private ComboBox cboCliente;
        private ComboBox cboProducto;
        private Label lblCantidad;
        private Label label6;
    }
}