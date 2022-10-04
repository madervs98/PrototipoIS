using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoIS
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }
        SqlConnection Conexion = new SqlConnection("Data Source=.;Initial Catalog=PrototipoIS;Integrated Security=True");


        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void registroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Productos productos = new Productos();
            productos.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes clientes = new Clientes();
            clientes.Show();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void suplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Suplidores suplidor = new Suplidores();
            suplidor.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturas facturacion = new Facturas();
            facturacion.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void facturaciónCotizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Facturas CrearFactura = new Facturas();
            CrearFactura.Show();
        }

        private void reporteVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Cotizaciones CrearOrdenC = new Cotizaciones();
            CrearOrdenC.Show();
        }
    }
}
