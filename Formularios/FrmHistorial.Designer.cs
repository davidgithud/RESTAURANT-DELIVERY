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
            lblCantidad = new Label();
            btnLimpiarHist = new Button();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(27, 18);
            label1.Name = "label1";
            label1.Size = new Size(322, 25);
            label1.TabIndex = 0;
            label1.Text = "HISTORIAL DE ESTADO DE PEDIDOS";
            // 
            // dgvHistorial
            // 
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dgvHistorial.BackgroundColor = Color.Bisque;
            dgvHistorial.BorderStyle = BorderStyle.Fixed3D;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(27, 57);
            dgvHistorial.Margin = new Padding(3, 2, 3, 2);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.ReadOnly = true;
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(554, 289);
            dgvHistorial.TabIndex = 1;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Microsoft Tai Le", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidad.ForeColor = Color.DimGray;
            lblCantidad.Location = new Point(510, 365);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(66, 14);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Cantidad: 0";
            // 
            // btnLimpiarHist
            // 
            btnLimpiarHist.Cursor = Cursors.Hand;
            btnLimpiarHist.Location = new Point(455, 17);
            btnLimpiarHist.Name = "btnLimpiarHist";
            btnLimpiarHist.Size = new Size(126, 29);
            btnLimpiarHist.TabIndex = 3;
            btnLimpiarHist.Text = "Limpiar Historial";
            btnLimpiarHist.UseVisualStyleBackColor = true;
            btnLimpiarHist.Click += BtnLimpiarHist_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Cursor = Cursors.Hand;
            btnAnterior.Location = new Point(27, 358);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(80, 29);
            btnAnterior.TabIndex = 1;
            btnAnterior.Text = "Atrás";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Cursor = Cursors.Hand;
            btnSiguiente.Location = new Point(113, 358);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(80, 29);
            btnSiguiente.TabIndex = 2;
            btnSiguiente.Text = "Adelante";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // FrmHistorial
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 406);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAnterior);
            Controls.Add(lblCantidad);
            Controls.Add(btnLimpiarHist);
            Controls.Add(dgvHistorial);
            Controls.Add(label1);
            Font = new Font("Microsoft Tai Le", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
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
        private Label lblCantidad;
        private Button btnLimpiarHist;
        private Button btnAnterior;
        private Button btnSiguiente;
    }
}