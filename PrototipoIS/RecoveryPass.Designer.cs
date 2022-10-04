namespace PrototipoIS
{
    partial class RecoveryPass
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
            this.btnValidar = new System.Windows.Forms.Button();
            this.tbNomUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.tbContraseñaN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValidar
            // 
            this.btnValidar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnValidar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnValidar.Location = new System.Drawing.Point(120, 126);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 28);
            this.btnValidar.TabIndex = 41;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btm_Click);
            // 
            // tbNomUser
            // 
            this.tbNomUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNomUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbNomUser.Location = new System.Drawing.Point(66, 97);
            this.tbNomUser.Name = "tbNomUser";
            this.tbNomUser.Size = new System.Drawing.Size(190, 23);
            this.tbNomUser.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(63, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nombre de Usuario";
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnGuardarCambios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardarCambios.Location = new System.Drawing.Point(87, 255);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(145, 28);
            this.btnGuardarCambios.TabIndex = 48;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Visible = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // tbContraseñaN
            // 
            this.tbContraseñaN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbContraseñaN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContraseñaN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbContraseñaN.Location = new System.Drawing.Point(66, 226);
            this.tbContraseñaN.Name = "tbContraseñaN";
            this.tbContraseñaN.Size = new System.Drawing.Size(190, 23);
            this.tbContraseñaN.TabIndex = 47;
            this.tbContraseñaN.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(63, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Contraseña Nueva";
            this.label4.Visible = false;
            // 
            // tbContraseña
            // 
            this.tbContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContraseña.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbContraseña.Location = new System.Drawing.Point(66, 181);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(190, 23);
            this.tbContraseña.TabIndex = 45;
            this.tbContraseña.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(63, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Contraseña";
            this.label3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 23);
            this.label1.TabIndex = 49;
            this.label1.Text = "RECUPERAR CONTRASEÑA";
            // 
            // RecoveryPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(310, 315);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.tbContraseñaN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNomUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnValidar);
            this.Name = "RecoveryPass";
            this.Text = "Recuperar Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.TextBox tbNomUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.TextBox tbContraseñaN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}