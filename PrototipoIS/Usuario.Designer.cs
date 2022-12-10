namespace PrototipoIS
{
    partial class Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.RClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.RSuplidores = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónCotizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Sienna;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeClientesToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(677, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroDeClientesToolStripMenuItem
            // 
            this.registroDeClientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RProductos,
            this.RClientes,
            this.RSuplidores});
            this.registroDeClientesToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroDeClientesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.registroDeClientesToolStripMenuItem.Name = "registroDeClientesToolStripMenuItem";
            this.registroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.registroDeClientesToolStripMenuItem.Text = "Registro";
            this.registroDeClientesToolStripMenuItem.Click += new System.EventHandler(this.registroDeClientesToolStripMenuItem_Click);
            // 
            // RProductos
            // 
            this.RProductos.ImageTransparentColor = System.Drawing.Color.White;
            this.RProductos.Name = "RProductos";
            this.RProductos.Size = new System.Drawing.Size(134, 22);
            this.RProductos.Text = "Productos";
            this.RProductos.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // RClientes
            // 
            this.RClientes.Name = "RClientes";
            this.RClientes.Size = new System.Drawing.Size(134, 22);
            this.RClientes.Text = "Clientes";
            this.RClientes.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // RSuplidores
            // 
            this.RSuplidores.Name = "RSuplidores";
            this.RSuplidores.Size = new System.Drawing.Size(134, 22);
            this.RSuplidores.Text = "Suplidores";
            this.RSuplidores.Click += new System.EventHandler(this.suplidoresToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteVentasToolStripMenuItem,
            this.reporteDeComprasToolStripMenuItem,
            this.facturaciónCotizaciónToolStripMenuItem});
            this.consultasToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.consultasToolStripMenuItem.Text = "Reportes y Consultas";
            // 
            // reporteVentasToolStripMenuItem
            // 
            this.reporteVentasToolStripMenuItem.Name = "reporteVentasToolStripMenuItem";
            this.reporteVentasToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.reporteVentasToolStripMenuItem.Text = "Reporte de Ventas";
            this.reporteVentasToolStripMenuItem.Click += new System.EventHandler(this.reporteVentasToolStripMenuItem_Click);
            // 
            // reporteDeComprasToolStripMenuItem
            // 
            this.reporteDeComprasToolStripMenuItem.Name = "reporteDeComprasToolStripMenuItem";
            this.reporteDeComprasToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.reporteDeComprasToolStripMenuItem.Text = "Reporte de Compras";
            // 
            // facturaciónCotizaciónToolStripMenuItem
            // 
            this.facturaciónCotizaciónToolStripMenuItem.Name = "facturaciónCotizaciónToolStripMenuItem";
            this.facturaciónCotizaciónToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.facturaciónCotizaciónToolStripMenuItem.Text = "Facturación y Cotización";
            this.facturaciónCotizaciónToolStripMenuItem.Click += new System.EventHandler(this.facturaciónCotizaciónToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Sienna;
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.Cornsilk;
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Sienna;
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(677, 410);
            this.splitContainer1.SplitterDistance = 212;
            this.splitContainer1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Snow;
            this.pictureBox1.Image = global::PrototipoIS.Properties.Resources.close_29379;
            this.pictureBox1.Location = new System.Drawing.Point(649, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PrototipoIS.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(461, 409);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(677, 434);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Usuario";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOAM REYES";
            this.Load += new System.EventHandler(this.Usuario_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RProductos;
        private System.Windows.Forms.ToolStripMenuItem RClientes;
        private System.Windows.Forms.ToolStripMenuItem RSuplidores;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeComprasToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem facturaciónCotizaciónToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}