namespace PrototipoIS
{
    partial class Productos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.label8 = new System.Windows.Forms.Label();
            this.tb_buscador = new System.Windows.Forms.TextBox();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.cb_TipoPro = new System.Windows.Forms.ComboBox();
            this.tb_PrecioPro = new System.Windows.Forms.TextBox();
            this.tb_CantPro = new System.Windows.Forms.TextBox();
            this.tb_DescripPro = new System.Windows.Forms.TextBox();
            this.tb_NomPro = new System.Windows.Forms.TextBox();
            this.tb_CodProduct = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.AliceBlue;
            this.label8.Location = new System.Drawing.Point(339, 367);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 70;
            this.label8.Text = "Total Registros";
            // 
            // tb_buscador
            // 
            this.tb_buscador.Location = new System.Drawing.Point(600, 80);
            this.tb_buscador.Name = "tb_buscador";
            this.tb_buscador.Size = new System.Drawing.Size(378, 21);
            this.tb_buscador.TabIndex = 69;
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.Ivory;
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_volver.Image = global::PrototipoIS.Properties.Resources.previous;
            this.btn_volver.Location = new System.Drawing.Point(27, 44);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(44, 35);
            this.btn_volver.TabIndex = 68;
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.Ivory;
            this.btn_Eliminar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Eliminar.Image = global::PrototipoIS.Properties.Resources.delete;
            this.btn_Eliminar.Location = new System.Drawing.Point(898, 370);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(80, 35);
            this.btn_Eliminar.TabIndex = 67;
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.BackColor = System.Drawing.Color.Ivory;
            this.btn_Actualizar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Actualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Actualizar.Image = global::PrototipoIS.Properties.Resources.refresh;
            this.btn_Actualizar.Location = new System.Drawing.Point(812, 370);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(80, 35);
            this.btn_Actualizar.TabIndex = 66;
            this.btn_Actualizar.UseVisualStyleBackColor = false;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.Color.Ivory;
            this.btn_Limpiar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Limpiar.Image = global::PrototipoIS.Properties.Resources.limpiar;
            this.btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Limpiar.Location = new System.Drawing.Point(726, 370);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(80, 35);
            this.btn_Limpiar.TabIndex = 65;
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.BackColor = System.Drawing.Color.Ivory;
            this.btn_Ingresar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ingresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Ingresar.Image = global::PrototipoIS.Properties.Resources.plus;
            this.btn_Ingresar.Location = new System.Drawing.Point(640, 370);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(80, 35);
            this.btn_Ingresar.TabIndex = 64;
            this.btn_Ingresar.UseVisualStyleBackColor = false;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LawnGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.GridColor = System.Drawing.Color.Sienna;
            this.dgvProductos.Location = new System.Drawing.Point(333, 107);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.Size = new System.Drawing.Size(645, 257);
            this.dgvProductos.TabIndex = 63;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // cb_TipoPro
            // 
            this.cb_TipoPro.FormattingEnabled = true;
            this.cb_TipoPro.Items.AddRange(new object[] {
            "",
            "Pillow Top",
            "Ortopédicos",
            "Semi-Ortopédico",
            "Latéx"});
            this.cb_TipoPro.Location = new System.Drawing.Point(181, 259);
            this.cb_TipoPro.Name = "cb_TipoPro";
            this.cb_TipoPro.Size = new System.Drawing.Size(137, 24);
            this.cb_TipoPro.TabIndex = 62;
            // 
            // tb_PrecioPro
            // 
            this.tb_PrecioPro.Location = new System.Drawing.Point(181, 343);
            this.tb_PrecioPro.Name = "tb_PrecioPro";
            this.tb_PrecioPro.Size = new System.Drawing.Size(137, 21);
            this.tb_PrecioPro.TabIndex = 61;
            // 
            // tb_CantPro
            // 
            this.tb_CantPro.Location = new System.Drawing.Point(181, 316);
            this.tb_CantPro.Name = "tb_CantPro";
            this.tb_CantPro.Size = new System.Drawing.Size(137, 21);
            this.tb_CantPro.TabIndex = 60;
            // 
            // tb_DescripPro
            // 
            this.tb_DescripPro.Location = new System.Drawing.Point(181, 289);
            this.tb_DescripPro.Name = "tb_DescripPro";
            this.tb_DescripPro.Size = new System.Drawing.Size(137, 21);
            this.tb_DescripPro.TabIndex = 59;
            // 
            // tb_NomPro
            // 
            this.tb_NomPro.Location = new System.Drawing.Point(181, 232);
            this.tb_NomPro.Name = "tb_NomPro";
            this.tb_NomPro.Size = new System.Drawing.Size(137, 21);
            this.tb_NomPro.TabIndex = 58;
            // 
            // tb_CodProduct
            // 
            this.tb_CodProduct.Enabled = false;
            this.tb_CodProduct.Location = new System.Drawing.Point(181, 205);
            this.tb_CodProduct.Name = "tb_CodProduct";
            this.tb_CodProduct.Size = new System.Drawing.Size(137, 21);
            this.tb_CodProduct.TabIndex = 57;
            this.tb_CodProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrototipoIS.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(126, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.AliceBlue;
            this.label7.Location = new System.Drawing.Point(41, 267);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 16);
            this.label7.TabIndex = 55;
            this.label7.Text = "Tipo de Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.AliceBlue;
            this.label6.Location = new System.Drawing.Point(41, 348);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 54;
            this.label6.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.AliceBlue;
            this.label5.Location = new System.Drawing.Point(41, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "Código";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(41, 321);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 52;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(41, 294);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "Descripción ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(41, 237);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "Nombre del Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(329, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 23);
            this.label1.TabIndex = 49;
            this.label1.Text = "REGISTROS DE PRODUCTOS";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1004, 448);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_buscador);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.cb_TipoPro);
            this.Controls.Add(this.tb_PrecioPro);
            this.Controls.Add(this.tb_CantPro);
            this.Controls.Add(this.tb_DescripPro);
            this.Controls.Add(this.tb_NomPro);
            this.Controls.Add(this.tb_CodProduct);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Productos";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_buscador;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.ComboBox cb_TipoPro;
        private System.Windows.Forms.TextBox tb_PrecioPro;
        private System.Windows.Forms.TextBox tb_CantPro;
        private System.Windows.Forms.TextBox tb_DescripPro;
        private System.Windows.Forms.TextBox tb_NomPro;
        private System.Windows.Forms.TextBox tb_CodProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}