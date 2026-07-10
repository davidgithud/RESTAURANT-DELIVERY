namespace RestaurantIngenieriaTrujillo.Formularios
{
    partial class FrmProductos
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
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            btnGuardar = new Button();
            btnBuscar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnNuevo = new Button();
            dgvProductos = new DataGridView();
            lblCantidad = new Label();
            txtTiempoPreparacion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Cursor = Cursors.IBeam;
            txtCodigo.Location = new Point(22, 75);
            txtCodigo.Margin = new Padding(3, 2, 3, 2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(73, 23);
            txtCodigo.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(22, 133);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(152, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.Cursor = Cursors.IBeam;
            txtPrecio.Location = new Point(22, 192);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(73, 23);
            txtPrecio.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.Location = new Point(101, 241);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(73, 26);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(101, 73);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(73, 26);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.Location = new Point(22, 292);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(73, 26);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Editar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Location = new Point(101, 292);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(73, 26);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.White;
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.Location = new Point(22, 241);
            btnNuevo.Margin = new Padding(3, 2, 3, 2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(73, 26);
            btnNuevo.TabIndex = 6;
            btnNuevo.Text = "Limpiar";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.BackgroundColor = Color.Bisque;
            dgvProductos.BorderStyle = BorderStyle.Fixed3D;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(196, 75);
            dgvProductos.Margin = new Padding(3, 2, 3, 2);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(515, 243);
            dgvProductos.TabIndex = 10;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Microsoft Tai Le", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidad.ForeColor = Color.DimGray;
            lblCantidad.Location = new Point(196, 57);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(129, 14);
            lblCantidad.TabIndex = 11;
            lblCantidad.Text = "Cantidad de productos:";
            // 
            // txtTiempoPreparacion
            // 
            txtTiempoPreparacion.Cursor = Cursors.IBeam;
            txtTiempoPreparacion.Location = new Point(101, 192);
            txtTiempoPreparacion.Margin = new Padding(3, 2, 3, 2);
            txtTiempoPreparacion.Name = "txtTiempoPreparacion";
            txtTiempoPreparacion.Size = new Size(73, 23);
            txtTiempoPreparacion.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(22, 57);
            label1.Name = "label1";
            label1.Size = new Size(49, 16);
            label1.TabIndex = 13;
            label1.Text = "Codigo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(22, 115);
            label2.Name = "label2";
            label2.Size = new Size(54, 16);
            label2.TabIndex = 14;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(22, 174);
            label3.Name = "label3";
            label3.Size = new Size(57, 16);
            label3.TabIndex = 15;
            label3.Text = "Precio: S/";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(101, 174);
            label4.Name = "label4";
            label4.Size = new Size(51, 16);
            label4.TabIndex = 16;
            label4.Text = "Tiempo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Orange;
            label5.Location = new Point(22, 21);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 17;
            label5.Text = "REGISTRO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Orange;
            label6.Location = new Point(354, 21);
            label6.Name = "label6";
            label6.Size = new Size(172, 20);
            label6.TabIndex = 18;
            label6.Text = "DATOS DE PRODUCTOS";
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 343);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTiempoPreparacion);
            Controls.Add(lblCantidad);
            Controls.Add(dgvProductos);
            Controls.Add(btnNuevo);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnBuscar);
            Controls.Add(btnGuardar);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Font = new Font("Microsoft Tai Le", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmProductos";
            Text = "FrmProductos";
            Load += FrmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private Button btnGuardar;
        private Button btnBuscar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnNuevo;
        private DataGridView dgvProductos;
        private Label lblCantidad;
        private TextBox txtTiempoPreparacion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}