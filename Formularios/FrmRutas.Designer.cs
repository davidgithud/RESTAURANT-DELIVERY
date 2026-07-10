namespace RestaurantIngenieriaTrujillo.Formularios
{
    partial class FrmRutas
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
            btnDijsktra = new Button();
            cboOrigen = new ComboBox();
            cboDestino = new ComboBox();
            lblDistancia = new Label();
            label1 = new Label();
            txtNombreLugar = new TextBox();
            btnAgregarLugar = new Button();
            btnModificarLugar = new Button();
            btnEliminarLugar = new Button();
            lblOrigen = new Label();
            lblDestino = new Label();
            lblLugares = new Label();
            dgvMatriz = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMatriz).BeginInit();
            SuspendLayout();
            // 
            // btnDijsktra
            // 
            btnDijsktra.Cursor = Cursors.Hand;
            btnDijsktra.Location = new Point(28, 203);
            btnDijsktra.Margin = new Padding(3, 2, 3, 2);
            btnDijsktra.Name = "btnDijsktra";
            btnDijsktra.Size = new Size(107, 23);
            btnDijsktra.TabIndex = 7;
            btnDijsktra.Text = "Calcular Ruta";
            btnDijsktra.UseVisualStyleBackColor = true;
            btnDijsktra.Click += btnDijkstra_Click;
            // 
            // cboOrigen
            // 
            cboOrigen.Cursor = Cursors.Hand;
            cboOrigen.FormattingEnabled = true;
            cboOrigen.Location = new Point(28, 165);
            cboOrigen.Margin = new Padding(3, 2, 3, 2);
            cboOrigen.Name = "cboOrigen";
            cboOrigen.Size = new Size(170, 24);
            cboOrigen.TabIndex = 5;
            // 
            // cboDestino
            // 
            cboDestino.Cursor = Cursors.Hand;
            cboDestino.FormattingEnabled = true;
            cboDestino.Location = new Point(231, 165);
            cboDestino.Margin = new Padding(3, 2, 3, 2);
            cboDestino.Name = "cboDestino";
            cboDestino.Size = new Size(170, 24);
            cboDestino.TabIndex = 6;
            // 
            // lblDistancia
            // 
            lblDistancia.AutoSize = true;
            lblDistancia.ForeColor = Color.DimGray;
            lblDistancia.Location = new Point(28, 240);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(58, 16);
            lblDistancia.TabIndex = 9;
            lblDistancia.Text = "Distancia:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(112, 29);
            label1.Name = "label1";
            label1.Size = new Size(197, 30);
            label1.TabIndex = 10;
            label1.Text = "RUTA DE PEDIDOS";
            // 
            // txtNombreLugar
            // 
            txtNombreLugar.Cursor = Cursors.IBeam;
            txtNombreLugar.Location = new Point(28, 101);
            txtNombreLugar.Margin = new Padding(3, 2, 3, 2);
            txtNombreLugar.Name = "txtNombreLugar";
            txtNombreLugar.PlaceholderText = "Nombre del lugar";
            txtNombreLugar.Size = new Size(130, 23);
            txtNombreLugar.TabIndex = 1;
            // 
            // btnAgregarLugar
            // 
            btnAgregarLugar.Cursor = Cursors.Hand;
            btnAgregarLugar.Location = new Point(164, 101);
            btnAgregarLugar.Margin = new Padding(3, 2, 3, 2);
            btnAgregarLugar.Name = "btnAgregarLugar";
            btnAgregarLugar.Size = new Size(75, 25);
            btnAgregarLugar.TabIndex = 2;
            btnAgregarLugar.Text = "Agregar";
            btnAgregarLugar.UseVisualStyleBackColor = true;
            btnAgregarLugar.Click += BtnAgregarLugar_Click;
            // 
            // btnModificarLugar
            // 
            btnModificarLugar.Cursor = Cursors.Hand;
            btnModificarLugar.Location = new Point(245, 101);
            btnModificarLugar.Margin = new Padding(3, 2, 3, 2);
            btnModificarLugar.Name = "btnModificarLugar";
            btnModificarLugar.Size = new Size(75, 25);
            btnModificarLugar.TabIndex = 3;
            btnModificarLugar.Text = "Modificar";
            btnModificarLugar.UseVisualStyleBackColor = true;
            btnModificarLugar.Click += BtnModificarLugar_Click;
            // 
            // btnEliminarLugar
            // 
            btnEliminarLugar.Cursor = Cursors.Hand;
            btnEliminarLugar.Location = new Point(326, 101);
            btnEliminarLugar.Margin = new Padding(3, 2, 3, 2);
            btnEliminarLugar.Name = "btnEliminarLugar";
            btnEliminarLugar.Size = new Size(75, 25);
            btnEliminarLugar.TabIndex = 4;
            btnEliminarLugar.Text = "Eliminar";
            btnEliminarLugar.UseVisualStyleBackColor = true;
            btnEliminarLugar.Click += BtnEliminarLugar_Click;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.ForeColor = Color.DimGray;
            lblOrigen.Location = new Point(28, 147);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(46, 16);
            lblOrigen.TabIndex = 15;
            lblOrigen.Text = "Origen:";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.ForeColor = Color.DimGray;
            lblDestino.Location = new Point(231, 147);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(50, 16);
            lblDestino.TabIndex = 16;
            lblDestino.Text = "Destino:";
            // 
            // lblLugares
            // 
            lblLugares.AutoSize = true;
            lblLugares.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLugares.ForeColor = Color.DimGray;
            lblLugares.Location = new Point(28, 82);
            lblLugares.Name = "lblLugares";
            lblLugares.Size = new Size(121, 17);
            lblLugares.TabIndex = 11;
            lblLugares.Text = "Gestión de Lugares";
            // 
            // dgvMatriz
            // 
            dgvMatriz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatriz.Location = new Point(28, 82);
            dgvMatriz.Margin = new Padding(3, 2, 3, 2);
            dgvMatriz.Name = "dgvMatriz";
            dgvMatriz.RowHeadersWidth = 51;
            dgvMatriz.Size = new Size(373, 193);
            dgvMatriz.TabIndex = 0;
            dgvMatriz.Visible = false;
            // 
            // FrmRutas
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 317);
            Controls.Add(lblDestino);
            Controls.Add(lblOrigen);
            Controls.Add(btnEliminarLugar);
            Controls.Add(btnModificarLugar);
            Controls.Add(btnAgregarLugar);
            Controls.Add(txtNombreLugar);
            Controls.Add(lblLugares);
            Controls.Add(label1);
            Controls.Add(lblDistancia);
            Controls.Add(cboDestino);
            Controls.Add(cboOrigen);
            Controls.Add(btnDijsktra);
            Controls.Add(dgvMatriz);
            Font = new Font("Microsoft Tai Le", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmRutas";
            Text = "FrmRutas";
            Load += FrmRutas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMatriz).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDijsktra;
        private ComboBox cboOrigen;
        private ComboBox cboDestino;
        private Label lblDistancia;
        private Label label1;
        private TextBox txtNombreLugar;
        private Button btnAgregarLugar;
        private Button btnModificarLugar;
        private Button btnEliminarLugar;
        private Label lblOrigen;
        private Label lblDestino;
        private Label lblLugares;
        private DataGridView dgvMatriz;
    }
}