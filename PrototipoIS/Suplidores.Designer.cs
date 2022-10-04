namespace PrototipoIS
{
    partial class Suplidores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suplidores));
            this.dgv_Suplidores = new System.Windows.Forms.DataGridView();
            this.tb_ContactoSup = new System.Windows.Forms.TextBox();
            this.tb_DireccionSup = new System.Windows.Forms.TextBox();
            this.tb_NomSup = new System.Windows.Forms.TextBox();
            this.tb_CodSup = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_NomEmpSup = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_buscador = new System.Windows.Forms.TextBox();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBuscador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Suplidores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Suplidores
            // 
            this.dgv_Suplidores.AllowUserToAddRows = false;
            this.dgv_Suplidores.AllowUserToDeleteRows = false;
            this.dgv_Suplidores.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_Suplidores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LawnGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Suplidores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Suplidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Suplidores.GridColor = System.Drawing.Color.LawnGreen;
            this.dgv_Suplidores.Location = new System.Drawing.Point(329, 93);
            this.dgv_Suplidores.Name = "dgv_Suplidores";
            this.dgv_Suplidores.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LawnGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Suplidores.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Suplidores.Size = new System.Drawing.Size(544, 228);
            this.dgv_Suplidores.TabIndex = 35;
            // 
            // tb_ContactoSup
            // 
            this.tb_ContactoSup.Location = new System.Drawing.Point(185, 275);
            this.tb_ContactoSup.Name = "tb_ContactoSup";
            this.tb_ContactoSup.Size = new System.Drawing.Size(137, 20);
            this.tb_ContactoSup.TabIndex = 32;
            // 
            // tb_DireccionSup
            // 
            this.tb_DireccionSup.Location = new System.Drawing.Point(185, 249);
            this.tb_DireccionSup.Name = "tb_DireccionSup";
            this.tb_DireccionSup.Size = new System.Drawing.Size(137, 20);
            this.tb_DireccionSup.TabIndex = 31;
            // 
            // tb_NomSup
            // 
            this.tb_NomSup.Location = new System.Drawing.Point(185, 223);
            this.tb_NomSup.Name = "tb_NomSup";
            this.tb_NomSup.Size = new System.Drawing.Size(137, 20);
            this.tb_NomSup.TabIndex = 30;
            // 
            // tb_CodSup
            // 
            this.tb_CodSup.Location = new System.Drawing.Point(185, 196);
            this.tb_CodSup.Name = "tb_CodSup";
            this.tb_CodSup.Size = new System.Drawing.Size(137, 20);
            this.tb_CodSup.TabIndex = 29;
            this.tb_CodSup.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(38, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Código";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(38, 279);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Teléfono de Contacto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(38, 253);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Dirección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(38, 227);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombre del Suplidor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(325, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "REGISTRO DE SUPLIDORES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_NomEmpSup
            // 
            this.tb_NomEmpSup.Location = new System.Drawing.Point(185, 301);
            this.tb_NomEmpSup.Name = "tb_NomEmpSup";
            this.tb_NomEmpSup.Size = new System.Drawing.Size(137, 20);
            this.tb_NomEmpSup.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(38, 305);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "Nombre de la Empresa";
            // 
            // tb_buscador
            // 
            this.tb_buscador.Location = new System.Drawing.Point(564, 67);
            this.tb_buscador.Name = "tb_buscador";
            this.tb_buscador.Size = new System.Drawing.Size(268, 20);
            this.tb_buscador.TabIndex = 45;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.Color.Ivory;
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpiar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Limpiar.Image = global::PrototipoIS.Properties.Resources.limpiar;
            this.btn_Limpiar.Location = new System.Drawing.Point(621, 327);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(80, 35);
            this.btn_Limpiar.TabIndex = 44;
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.BackColor = System.Drawing.Color.Ivory;
            this.btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ingresar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ingresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Ingresar.Image = global::PrototipoIS.Properties.Resources.plus;
            this.btn_Ingresar.Location = new System.Drawing.Point(535, 327);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(80, 35);
            this.btn_Ingresar.TabIndex = 43;
            this.btn_Ingresar.UseVisualStyleBackColor = false;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Ivory;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.Transparent;
            this.btnVolver.Image = global::PrototipoIS.Properties.Resources.previous;
            this.btnVolver.Location = new System.Drawing.Point(12, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(44, 40);
            this.btnVolver.TabIndex = 40;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.Ivory;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Eliminar.Image = global::PrototipoIS.Properties.Resources.delete;
            this.btn_Eliminar.Location = new System.Drawing.Point(793, 327);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(80, 35);
            this.btn_Eliminar.TabIndex = 39;
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.BackColor = System.Drawing.Color.Ivory;
            this.btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Actualizar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Actualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Actualizar.Image = global::PrototipoIS.Properties.Resources.refresh;
            this.btn_Actualizar.Location = new System.Drawing.Point(707, 327);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(80, 35);
            this.btn_Actualizar.TabIndex = 38;
            this.btn_Actualizar.UseVisualStyleBackColor = false;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrototipoIS.Properties.Resources.Logo2;
            this.pictureBox1.Location = new System.Drawing.Point(131, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btnBuscador
            // 
            this.btnBuscador.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscador.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscador.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscador.Image = global::PrototipoIS.Properties.Resources.search;
            this.btnBuscador.Location = new System.Drawing.Point(838, 56);
            this.btnBuscador.Name = "btnBuscador";
            this.btnBuscador.Size = new System.Drawing.Size(35, 31);
            this.btnBuscador.TabIndex = 46;
            this.btnBuscador.UseVisualStyleBackColor = false;
            this.btnBuscador.Click += new System.EventHandler(this.btnBuscador_Click);
            // 
            // Suplidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.btnBuscador);
            this.Controls.Add(this.tb_buscador);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.tb_NomEmpSup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.dgv_Suplidores);
            this.Controls.Add(this.tb_ContactoSup);
            this.Controls.Add(this.tb_DireccionSup);
            this.Controls.Add(this.tb_NomSup);
            this.Controls.Add(this.tb_CodSup);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Suplidores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suplidores";
            this.Load += new System.EventHandler(this.Suplidores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Suplidores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.DataGridView dgv_Suplidores;
        private System.Windows.Forms.TextBox tb_ContactoSup;
        private System.Windows.Forms.TextBox tb_DireccionSup;
        private System.Windows.Forms.TextBox tb_NomSup;
        private System.Windows.Forms.TextBox tb_CodSup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_NomEmpSup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.TextBox tb_buscador;
        private System.Windows.Forms.Button btnBuscador;
    }
}