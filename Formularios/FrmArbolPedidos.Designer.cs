namespace RestaurantIngenieriaTrujillo.Formularios
{
    partial class FrmArbolPedidos
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
            dgvArbol = new DataGridView();
            btnInOrden = new Button();
            groupBox2 = new GroupBox();
            btnBuscar = new Button();
            label4 = new Label();
            txtBuscarCodigo = new TextBox();
            groupBox3 = new GroupBox();
            label2 = new Label();
            btnRango = new Button();
            txtMinimo = new TextBox();
            label3 = new Label();
            txtMaximo = new TextBox();
            lblCantidad = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvArbol).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(26, 22);
            label1.Name = "label1";
            label1.Size = new Size(252, 30);
            label1.TabIndex = 0;
            label1.Text = "BUSQUEDA DE PEDIDOS";
            // 
            // dgvArbol
            // 
            dgvArbol.AllowUserToAddRows = false;
            dgvArbol.AllowUserToDeleteRows = false;
            dgvArbol.BackgroundColor = Color.Bisque;
            dgvArbol.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArbol.Location = new Point(26, 63);
            dgvArbol.Margin = new Padding(3, 2, 3, 2);
            dgvArbol.Name = "dgvArbol";
            dgvArbol.ReadOnly = true;
            dgvArbol.RowHeadersWidth = 40;
            dgvArbol.Size = new Size(927, 232);
            dgvArbol.TabIndex = 1;
            // 
            // btnInOrden
            // 
            btnInOrden.Cursor = Cursors.Hand;
            btnInOrden.Location = new Point(838, 312);
            btnInOrden.Margin = new Padding(3, 2, 3, 2);
            btnInOrden.Name = "btnInOrden";
            btnInOrden.Size = new Size(115, 26);
            btnInOrden.TabIndex = 6;
            btnInOrden.Text = "Limpiar Filtros";
            btnInOrden.UseVisualStyleBackColor = true;
            btnInOrden.Click += btnInOrden_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtBuscarCodigo);
            groupBox2.ForeColor = Color.DimGray;
            groupBox2.Location = new Point(26, 312);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(206, 94);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Busqueda Por Código";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(113, 48);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(79, 26);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 30);
            label4.Name = "label4";
            label4.Size = new Size(49, 16);
            label4.TabIndex = 16;
            label4.Text = "Codigo:";
            // 
            // txtBuscarCodigo
            // 
            txtBuscarCodigo.Cursor = Cursors.IBeam;
            txtBuscarCodigo.Location = new Point(14, 48);
            txtBuscarCodigo.Margin = new Padding(3, 2, 3, 2);
            txtBuscarCodigo.Name = "txtBuscarCodigo";
            txtBuscarCodigo.Size = new Size(93, 23);
            txtBuscarCodigo.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(btnRango);
            groupBox3.Controls.Add(txtMinimo);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtMaximo);
            groupBox3.ForeColor = Color.DimGray;
            groupBox3.Location = new Point(259, 312);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(298, 94);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Busqueda Por Rango";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 30);
            label2.Name = "label2";
            label2.Size = new Size(52, 16);
            label2.TabIndex = 12;
            label2.Text = "Minimo:";
            // 
            // btnRango
            // 
            btnRango.Cursor = Cursors.Hand;
            btnRango.ForeColor = Color.Black;
            btnRango.Location = new Point(202, 48);
            btnRango.Margin = new Padding(3, 2, 3, 2);
            btnRango.Name = "btnRango";
            btnRango.Size = new Size(79, 26);
            btnRango.TabIndex = 5;
            btnRango.Text = "Buscar";
            btnRango.UseVisualStyleBackColor = true;
            btnRango.Click += btnRango_Click;
            // 
            // txtMinimo
            // 
            txtMinimo.Cursor = Cursors.IBeam;
            txtMinimo.Location = new Point(15, 48);
            txtMinimo.Margin = new Padding(3, 2, 3, 2);
            txtMinimo.Name = "txtMinimo";
            txtMinimo.Size = new Size(85, 23);
            txtMinimo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 32);
            label3.Name = "label3";
            label3.Size = new Size(53, 16);
            label3.TabIndex = 13;
            label3.Text = "Maximo:";
            // 
            // txtMaximo
            // 
            txtMaximo.Cursor = Cursors.IBeam;
            txtMaximo.Location = new Point(109, 48);
            txtMaximo.Margin = new Padding(3, 2, 3, 2);
            txtMaximo.Name = "txtMaximo";
            txtMaximo.Size = new Size(85, 23);
            txtMaximo.TabIndex = 4;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Microsoft Tai Le", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidad.ForeColor = Color.DimGray;
            lblCantidad.Location = new Point(838, 47);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(85, 14);
            lblCantidad.TabIndex = 14;
            lblCantidad.Text = "Cantidad Total:";
            // 
            // FrmArbolPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 432);
            Controls.Add(lblCantidad);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnInOrden);
            Controls.Add(dgvArbol);
            Controls.Add(label1);
            Font = new Font("Microsoft Tai Le", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmArbolPedidos";
            Text = "FrmArbolPedidos";
            Load += FrmArbolPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArbol).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvArbol;
        private Button btnInOrden;
        private GroupBox groupBox2;
        private TextBox txtBuscarCodigo;
        private GroupBox groupBox3;
        private TextBox txtMinimo;
        private TextBox txtMaximo;
        private Button btnRango;
        private Label label2;
        private Label label3;
        private Label lblCantidad;
        private Button btnBuscar;
        private Label label4;
    }
}