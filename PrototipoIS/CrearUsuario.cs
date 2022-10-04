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
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }

        SqlConnection Conexion = new SqlConnection("Data Source=.;Initial Catalog=PrototipoIS;Integrated Security=True");

        private void CrearUsuario_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 VolverIngreso = new Form1();
            VolverIngreso.Show();
        }

        private void btn_Rusuario_Click(object sender, EventArgs e)
        {
            Conexion.Open();
            int error = 0;
            string Query = "INSERT INTO dbo.Login (Cusuario,nom_user,ape_user,correo_user,Fnacimiento_user,pass_user) VALUES ('" + tb_Cusuarios.Text + "','" + tb_nomUser.Text + "','" + tb_ApeUser.Text + "','" + tb_CorreoUser.Text + "','" + dtp_Fnacimiento.Text + "','" + tb_passUser.Text + "')";
            //MessageBox.Show(Query);
            SqlCommand comando = new SqlCommand(Query, Conexion);

            error = comando.ExecuteNonQuery();
            if (error == 1)
            {
                MessageBox.Show("Usuario creado correctamente.");

                tb_Cusuarios.Clear();
                tb_nomUser.Clear();
                tb_ApeUser.Clear();
                tb_CorreoUser.Clear();
                dtp_Fnacimiento.Text = "";
                tb_passUser.Clear();
                tb_Cusuarios.Focus();

                DataTable data = new DataTable();
                SqlDataAdapter Data = new SqlDataAdapter("SELECT * FROM Login", Conexion);

                Data.Fill(data);

                this.Hide();
                Form1 VolverIngreso = new Form1();
                VolverIngreso.Show();
            }
            else
            {
                MessageBox.Show("Error al crear usuario.");

            }
            Conexion.Close();
        }
    }
}
