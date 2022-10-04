using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoIS
{
    public partial class RecoveryPass : Form
    {
        public RecoveryPass()
        {
            InitializeComponent();
        }

        private void btm_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            tbContraseña.Visible = true;
            label4.Visible = true;
            tbContraseñaN.Visible = true;
            btnGuardarCambios.Visible = true;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Cambiados Correctamente.");
            this.Hide();
        }
    }
}
