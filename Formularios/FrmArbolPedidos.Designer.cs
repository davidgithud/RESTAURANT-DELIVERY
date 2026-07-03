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
            Codigo = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btnInOrden = new Button();
            btnPreOrden = new Button();
            btnPostOrden = new Button();
            groupBox2 = new GroupBox();
            txtBuscarCodigo = new TextBox();
            groupBox3 = new GroupBox();
            txtMinimo = new TextBox();
            txtMaximo = new TextBox();
            btnRango = new Button();
            label2 = new Label();
            label3 = new Label();
            lblCantidad = new Label();
            btnBuscar = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvArbol).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(304, 20);
            label1.Name = "label1";
            label1.Size = new Size(433, 41);
            label1.TabIndex = 0;
            label1.Text = "ARBOL BINARIO DE PEDIDOS";
            // 
            // dgvArbol
            // 
            dgvArbol.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArbol.Columns.AddRange(new DataGridViewColumn[] { Codigo, Cliente, Producto, Estado, Total });
            dgvArbol.Location = new Point(12, 83);
            dgvArbol.Name = "dgvArbol";
            dgvArbol.RowHeadersWidth = 51;
            dgvArbol.Size = new Size(674, 210);
            dgvArbol.TabIndex = 1;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.Width = 125;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 6;
            Cliente.Name = "Cliente";
            Cliente.Width = 125;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.Width = 125;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.Width = 125;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.Width = 125;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(24, 313);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 137);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recorridos";
            // 
            // btnInOrden
            // 
            btnInOrden.Location = new Point(290, 325);
            btnInOrden.Name = "btnInOrden";
            btnInOrden.Size = new Size(94, 29);
            btnInOrden.TabIndex = 3;
            btnInOrden.Text = "InOrden";
            btnInOrden.UseVisualStyleBackColor = true;
            btnInOrden.Click += btnInOrden_Click;
            // 
            // btnPreOrden
            // 
            btnPreOrden.Location = new Point(290, 374);
            btnPreOrden.Name = "btnPreOrden";
            btnPreOrden.Size = new Size(94, 29);
            btnPreOrden.TabIndex = 4;
            btnPreOrden.Text = "PreOrden";
            btnPreOrden.UseVisualStyleBackColor = true;
            btnPreOrden.Click += btnPreOrden_Click;
            // 
            // btnPostOrden
            // 
            btnPostOrden.Location = new Point(290, 423);
            btnPostOrden.Name = "btnPostOrden";
            btnPostOrden.Size = new Size(94, 29);
            btnPostOrden.TabIndex = 5;
            btnPostOrden.Text = "PostOrden";
            btnPostOrden.UseVisualStyleBackColor = true;
            btnPostOrden.Click += btnPostOrden_Click;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(436, 313);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 76);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Busqueda";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // txtBuscarCodigo
            // 
            txtBuscarCodigo.Location = new Point(436, 423);
            txtBuscarCodigo.Name = "txtBuscarCodigo";
            txtBuscarCodigo.Size = new Size(150, 27);
            txtBuscarCodigo.TabIndex = 7;
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(730, 83);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(287, 125);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Busqueda por Rango";
            // 
            // txtMinimo
            // 
            txtMinimo.Location = new Point(730, 249);
            txtMinimo.Name = "txtMinimo";
            txtMinimo.Size = new Size(128, 27);
            txtMinimo.TabIndex = 9;
            // 
            // txtMaximo
            // 
            txtMaximo.Location = new Point(880, 249);
            txtMaximo.Name = "txtMaximo";
            txtMaximo.Size = new Size(137, 27);
            txtMaximo.TabIndex = 10;
            // 
            // btnRango
            // 
            btnRango.Location = new Point(809, 291);
            btnRango.Name = "btnRango";
            btnRango.Size = new Size(120, 29);
            btnRango.TabIndex = 11;
            btnRango.Text = "Rango";
            btnRango.UseVisualStyleBackColor = true;
            btnRango.Click += btnRango_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(748, 226);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 12;
            label2.Text = "Minimo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(898, 226);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 13;
            label3.Text = "Maximo:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(739, 334);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(72, 20);
            lblCantidad.TabIndex = 14;
            lblCantidad.Text = "Cantidad:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(592, 423);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(436, 399);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 16;
            label4.Text = "Codigo:";
            // 
            // FrmArbolPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 476);
            Controls.Add(label4);
            Controls.Add(btnBuscar);
            Controls.Add(lblCantidad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnRango);
            Controls.Add(txtMaximo);
            Controls.Add(txtMinimo);
            Controls.Add(groupBox3);
            Controls.Add(txtBuscarCodigo);
            Controls.Add(groupBox2);
            Controls.Add(btnPostOrden);
            Controls.Add(btnPreOrden);
            Controls.Add(btnInOrden);
            Controls.Add(groupBox1);
            Controls.Add(dgvArbol);
            Controls.Add(label1);
            Name = "FrmArbolPedidos";
            Text = "FrmArbolPedidos";
            Load += FrmArbolPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArbol).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvArbol;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Total;
        private GroupBox groupBox1;
        private Button btnInOrden;
        private Button btnPreOrden;
        private Button btnPostOrden;
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