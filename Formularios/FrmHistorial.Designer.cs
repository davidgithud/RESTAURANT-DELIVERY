namespace RestaurantIngenieriaTrujillo.Formularios
{
    partial class FrmHistorial
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
            dgvHistorial = new DataGridView();
            CodigoPedido = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            FechaHora = new DataGridViewTextBoxColumn();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            lblCantidad = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(111, 32);
            label1.Name = "label1";
            label1.Size = new Size(330, 31);
            label1.TabIndex = 0;
            label1.Text = "Historial de Estado de Pedidos";
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Columns.AddRange(new DataGridViewColumn[] { CodigoPedido, Estado, FechaHora });
            dgvHistorial.Location = new Point(53, 82);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(421, 232);
            dgvHistorial.TabIndex = 1;
            // 
            // CodigoPedido
            // 
            CodigoPedido.HeaderText = "Codigo Pedido";
            CodigoPedido.MinimumWidth = 6;
            CodigoPedido.Name = "CodigoPedido";
            CodigoPedido.Width = 125;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.Width = 125;
            // 
            // FechaHora
            // 
            FechaHora.HeaderText = "Fecha y Hora";
            FechaHora.MinimumWidth = 6;
            FechaHora.Name = "FechaHora";
            FechaHora.Width = 125;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(53, 365);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(200, 29);
            btnSiguiente.TabIndex = 2;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(274, 365);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(200, 29);
            btnAnterior.TabIndex = 3;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(53, 317);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(84, 20);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Cantidad: 0";
            // 
            // FrmHistorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 423);
            Controls.Add(lblCantidad);
            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Controls.Add(dgvHistorial);
            Controls.Add(label1);
            Name = "FrmHistorial";
            Text = "FrmHistorial";
            Load += FrmHistorial_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvHistorial;
        private DataGridViewTextBoxColumn CodigoPedido;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn FechaHora;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Label lblCantidad;
    }
}