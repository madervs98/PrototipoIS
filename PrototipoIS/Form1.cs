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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Conexión de Base de Datos.
        SqlConnection Conexion = new SqlConnection("Data Source=.;Initial Catalog=PrototipoIS;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //Botón de Crear Usuario. 
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearUsuario Cusuario = new CrearUsuario();
            Cusuario.Show();
        }

        //Botón de Iniciar Sesión.
        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Acceder_Click(object sender, EventArgs e)
        {
            Conexion.Open();

            string Consulta = "SELECT * FROM Login WHERE Cusuario='" + tb_usuario.Text + "' and pass_user='" + tb_password.Text + "'";
            SqlCommand Comando = new SqlCommand(Consulta, Conexion);

            SqlDataReader lector;

            lector = Comando.ExecuteReader();
            if (lector.HasRows == true)
            {
                MessageBox.Show("Bienvenido.");
                this.Hide();
                Usuario PerfilUsuario = new Usuario();
                PerfilUsuario.Show();
            }
           
            else 
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta.");
            }

            Conexion.Close();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecoveryPass RecuperarClave = new RecoveryPass();
            RecuperarClave.Show();
        }
    }
}
