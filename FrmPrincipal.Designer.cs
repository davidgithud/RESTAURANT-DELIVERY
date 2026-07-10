namespace RestaurantIngenieriaTrujillo
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            repartidoresToolStripMenuItem = new ToolStripMenuItem();
            gestionarPedidosToolStripMenuItem = new ToolStripMenuItem();
            historialToolStripMenuItem = new ToolStripMenuItem();
            aBBPedidosToolStripMenuItem = new ToolStripMenuItem();
            rutasToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            redMinimaToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.White;
            menuStrip1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.GripMargin = new Padding(0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, productosToolStripMenuItem, repartidoresToolStripMenuItem, gestionarPedidosToolStripMenuItem, historialToolStripMenuItem, aBBPedidosToolStripMenuItem, rutasToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(4, 3);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(59, 10, 10, 10);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(696, 48);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.ForeColor = Color.Black;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(56, 28);
            toolStripMenuItem1.Text = "Clientes";
            toolStripMenuItem1.Click += ClientestoolStripMenuItem1_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.ForeColor = Color.Black;
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(67, 28);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // repartidoresToolStripMenuItem
            // 
            repartidoresToolStripMenuItem.ForeColor = Color.Black;
            repartidoresToolStripMenuItem.Name = "repartidoresToolStripMenuItem";
            repartidoresToolStripMenuItem.Size = new Size(79, 28);
            repartidoresToolStripMenuItem.Text = "Repartidores";
            repartidoresToolStripMenuItem.Click += repartidoresToolStripMenuItem_Click;
            // 
            // gestionarPedidosToolStripMenuItem
            // 
            gestionarPedidosToolStripMenuItem.ForeColor = Color.Black;
            gestionarPedidosToolStripMenuItem.Name = "gestionarPedidosToolStripMenuItem";
            gestionarPedidosToolStripMenuItem.Size = new Size(111, 28);
            gestionarPedidosToolStripMenuItem.Text = "Gestión de Pedidos";
            gestionarPedidosToolStripMenuItem.Click += gestionarPedidosToolStripMenuItem_Click;
            // 
            // historialToolStripMenuItem
            // 
            historialToolStripMenuItem.ForeColor = Color.Black;
            historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            historialToolStripMenuItem.Size = new Size(56, 28);
            historialToolStripMenuItem.Text = "Historial";
            historialToolStripMenuItem.Click += historialToolStripMenuItem_Click;
            // 
            // aBBPedidosToolStripMenuItem
            // 
            aBBPedidosToolStripMenuItem.ForeColor = Color.Black;
            aBBPedidosToolStripMenuItem.Name = "aBBPedidosToolStripMenuItem";
            aBBPedidosToolStripMenuItem.Size = new Size(123, 28);
            aBBPedidosToolStripMenuItem.Text = "Búsqueda de Pedidos";
            aBBPedidosToolStripMenuItem.Click += aBBPedidosToolStripMenuItem_Click;
            // 
            // rutasToolStripMenuItem
            // 
            rutasToolStripMenuItem.ForeColor = Color.Black;
            rutasToolStripMenuItem.Name = "rutasToolStripMenuItem";
            rutasToolStripMenuItem.Size = new Size(47, 28);
            rutasToolStripMenuItem.Text = "Rutas";
            rutasToolStripMenuItem.Click += rutasToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.ForeColor = Color.Black;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(39, 28);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // redMinimaToolStripMenuItem
            // 
            redMinimaToolStripMenuItem.Name = "redMinimaToolStripMenuItem";
            redMinimaToolStripMenuItem.Size = new Size(32, 19);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Tai Le", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.ImageAlign = ContentAlignment.BottomLeft;
            label1.Location = new Point(180, 71);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Padding = new Padding(12);
            label1.Size = new Size(336, 65);
            label1.TabIndex = 1;
            label1.Text = "Sistema de Delivery";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(268, 155);
            pictureBox1.Margin = new Padding(4, 2, 4, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(704, 350);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlText;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 2, 4, 2);
            Name = "FrmPrincipal";
            Padding = new Padding(4, 3, 4, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Delivery - Restaurant Trujillo";
            WindowState = FormWindowState.Minimized;
            Load += FrmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gestionarPedidosToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem repartidoresToolStripMenuItem;
        private ToolStripMenuItem historialToolStripMenuItem;
        private ToolStripMenuItem aBBPedidosToolStripMenuItem;
        private ToolStripMenuItem rutasToolStripMenuItem;
        private ToolStripMenuItem redMinimaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
