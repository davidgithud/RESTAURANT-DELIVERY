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
            dgvMatriz = new DataGridView();
            lstRecorrido = new ListBox();
            btnMatriz = new Button();
            btnBFS = new Button();
            btnDFS = new Button();
            btnDijsktra = new Button();
            cboOrigen = new ComboBox();
            cboDestino = new ComboBox();
            lblCosto = new Label();
            lblDistancia = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMatriz).BeginInit();
            SuspendLayout();
            // 
            // dgvMatriz
            // 
            dgvMatriz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatriz.Location = new Point(12, 53);
            dgvMatriz.Name = "dgvMatriz";
            dgvMatriz.RowHeadersWidth = 51;
            dgvMatriz.Size = new Size(752, 147);
            dgvMatriz.TabIndex = 0;
            // 
            // lstRecorrido
            // 
            lstRecorrido.FormattingEnabled = true;
            lstRecorrido.Location = new Point(12, 221);
            lstRecorrido.Name = "lstRecorrido";
            lstRecorrido.Size = new Size(345, 164);
            lstRecorrido.TabIndex = 1;
            // 
            // btnMatriz
            // 
            btnMatriz.Location = new Point(382, 221);
            btnMatriz.Name = "btnMatriz";
            btnMatriz.Size = new Size(150, 29);
            btnMatriz.TabIndex = 2;
            btnMatriz.Text = "Matriz";
            btnMatriz.UseVisualStyleBackColor = true;
            btnMatriz.Click += btnMatriz_Click;
            // 
            // btnBFS
            // 
            btnBFS.Location = new Point(382, 263);
            btnBFS.Name = "btnBFS";
            btnBFS.Size = new Size(150, 29);
            btnBFS.TabIndex = 3;
            btnBFS.Text = "BFS";
            btnBFS.UseVisualStyleBackColor = true;
            btnBFS.Click += btnBFS_Click;
            // 
            // btnDFS
            // 
            btnDFS.Location = new Point(382, 314);
            btnDFS.Name = "btnDFS";
            btnDFS.Size = new Size(150, 29);
            btnDFS.TabIndex = 4;
            btnDFS.Text = "DFS";
            btnDFS.UseVisualStyleBackColor = true;
            btnDFS.Click += btnDFS_Click;
            // 
            // btnDijsktra
            // 
            btnDijsktra.Location = new Point(382, 356);
            btnDijsktra.Name = "btnDijsktra";
            btnDijsktra.Size = new Size(150, 29);
            btnDijsktra.TabIndex = 5;
            btnDijsktra.Text = "Dijkstra";
            btnDijsktra.UseVisualStyleBackColor = true;
            btnDijsktra.Click += btnDijkstra_Click;
            // 
            // cboOrigen
            // 
            cboOrigen.FormattingEnabled = true;
            cboOrigen.Location = new Point(576, 221);
            cboOrigen.Name = "cboOrigen";
            cboOrigen.Size = new Size(188, 28);
            cboOrigen.TabIndex = 6;
            cboOrigen.Text = "Origen";
            // 
            // cboDestino
            // 
            cboDestino.FormattingEnabled = true;
            cboDestino.Location = new Point(576, 288);
            cboDestino.Name = "cboDestino";
            cboDestino.Size = new Size(188, 28);
            cboDestino.TabIndex = 7;
            cboDestino.Text = "Destino";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Location = new Point(576, 337);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(50, 20);
            lblCosto.TabIndex = 8;
            lblCosto.Text = "Costo:";
            // 
            // lblDistancia
            // 
            lblDistancia.AutoSize = true;
            lblDistancia.Location = new Point(12, 403);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(73, 20);
            lblDistancia.TabIndex = 9;
            lblDistancia.Text = "Distancia:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(265, 9);
            label1.Name = "label1";
            label1.Size = new Size(267, 38);
            label1.TabIndex = 10;
            label1.Text = "Ruta de los Pedidos";
            // 
            // FrmRutas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblDistancia);
            Controls.Add(lblCosto);
            Controls.Add(cboDestino);
            Controls.Add(cboOrigen);
            Controls.Add(btnDijsktra);
            Controls.Add(btnDFS);
            Controls.Add(btnBFS);
            Controls.Add(btnMatriz);
            Controls.Add(lstRecorrido);
            Controls.Add(dgvMatriz);
            Name = "FrmRutas";
            Text = "FrmRutas";
            Load += FrmRutas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMatriz).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMatriz;
        private ListBox lstRecorrido;
        private Button btnMatriz;
        private Button btnBFS;
        private Button btnDFS;
        private Button btnDijsktra;
        private ComboBox cboOrigen;
        private ComboBox cboDestino;
        private Label lblCosto;
        private Label lblDistancia;
        private Label label1;
    }
}