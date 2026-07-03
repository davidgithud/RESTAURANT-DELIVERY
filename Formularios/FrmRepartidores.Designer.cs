namespace RestaurantIngenieriaTrujillo.Formularios
{
    partial class FrmRepartidores
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
            txtTelefono = new TextBox();
            chkDisponible = new CheckBox();
            dgvRepartidores = new DataGridView();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            btnNuevo = new Button();
            btnSiguiente = new Button();
            lblCantidad = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRepartidores).BeginInit();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(12, 109);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(177, 27);
            txtCodigo.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 165);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(177, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(12, 221);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(177, 27);
            txtTelefono.TabIndex = 2;
            // 
            // chkDisponible
            // 
            chkDisponible.AutoSize = true;
            chkDisponible.Location = new Point(12, 272);
            chkDisponible.Name = "chkDisponible";
            chkDisponible.Size = new Size(103, 24);
            chkDisponible.TabIndex = 4;
            chkDisponible.Text = "Disponible";
            chkDisponible.UseVisualStyleBackColor = true;
            // 
            // dgvRepartidores
            // 
            dgvRepartidores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRepartidores.Location = new Point(224, 221);
            dgvRepartidores.Name = "dgvRepartidores";
            dgvRepartidores.RowHeadersWidth = 51;
            dgvRepartidores.Size = new Size(505, 188);
            dgvRepartidores.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(230, 107);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(158, 29);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(230, 157);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(158, 29);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(403, 109);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(158, 29);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(403, 159);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(158, 29);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(571, 109);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(158, 29);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(571, 159);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(158, 29);
            btnSiguiente.TabIndex = 11;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(224, 421);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(72, 20);
            lblCantidad.TabIndex = 12;
            lblCantidad.Text = "Cantidad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 86);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 13;
            label1.Text = "Codigo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 139);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 14;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 198);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 15;
            label3.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(230, 30);
            label4.Name = "label4";
            label4.Size = new Size(331, 38);
            label4.TabIndex = 16;
            label4.Text = "Registro de Repartidores";
            // 
            // FrmRepartidores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblCantidad);
            Controls.Add(btnSiguiente);
            Controls.Add(btnNuevo);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvRepartidores);
            Controls.Add(chkDisponible);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Name = "FrmRepartidores";
            Text = "FrmRepartidores";
            Load += FrmRepartidores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRepartidores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private CheckBox chkDisponible;
        private DataGridView dgvRepartidores;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnBuscar;
        private Button btnNuevo;
        private Button btnSiguiente;
        private Label lblCantidad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}