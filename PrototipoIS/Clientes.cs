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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }
        SqlConnection Conexion = new SqlConnection("Data Source=.;Initial Catalog=PrototipoIS;Integrated Security=True");

        private void Clientes_Load(object sender, EventArgs e)
        {
            Conexion.Open();

            DataTable data = new DataTable();
            SqlDataAdapter Data = new SqlDataAdapter("SELECT * FROM Clientes", Conexion);

            Data.Fill(data);

            dgvClientes.DataSource = data;
            Conexion.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuario VolverInicio = new Usuario();
            VolverInicio.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbNomClie.Clear();
            tb_telefono.Clear();
            tb_direClie.Text = "";
            tbCorreo.Clear();
            tb_CedulaClie.Clear();
            tb_RNC.Clear();
            tb_NombreEmp.Clear();
            tb_DireccionEmpre.Clear();
            tbNomClie.Focus();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            Conexion.Open();
            int error = 0;
            string Query = "INSERT INTO dbo.Clientes (nom_clie,direccion_clie,correo_clie,documento_clie,rnc_clie, nom_empresa, direccion_empresa) " +
                "VALUES ('" + tbNomClie.Text + "','" + tb_telefono.Text + "','" + tb_direClie.Text + "','" + tb_CedulaClie.Text + "','" + tb_RNC.Text + 
                "','" + tb_NombreEmp.Text + "','" + tb_DireccionEmpre.Text + "')";
            //MessageBox.Show(Query);
            SqlCommand comando = new SqlCommand(Query, Conexion);

            error = comando.ExecuteNonQuery();
            if (error == 1)
            {
                MessageBox.Show("Cliente creado correctamente.");

                tbNomClie.Clear();
                tb_telefono.Clear();
                tb_direClie.Text = "";
                tbCorreo.Clear();
                tb_CedulaClie.Clear();
                tb_RNC.Clear();
                tb_NombreEmp.Clear();
                tb_DireccionEmpre.Clear();
                tbNomClie.Focus();

                DataTable data = new DataTable();
                SqlDataAdapter Data = new SqlDataAdapter("SELECT * FROM Clientes", Conexion);

                Data.Fill(data);

                dgvClientes.DataSource = data;
            }
            else
            {
                MessageBox.Show("Error al crear Cliente.");

            }
            Conexion.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Conexion.Open();

            int error = 0;

            string Query = " UPDATE Clientes SET id_productos= '" + tbNomClie.Text + "','" + tb_telefono.Text + "','" + tb_direClie.Text + "','" + tb_CedulaClie.Text + "','" + tb_RNC.Text +
                "','" + tb_NombreEmp.Text + "','" + tb_DireccionEmpre.Text + "'";

            SqlCommand comando = new SqlCommand(Query, Conexion);

            error = comando.ExecuteNonQuery();
            if (error == 1)
            {
                MessageBox.Show("Datos actualizados.");

                tbNomClie.Clear();
                tb_telefono.Clear();
                tb_direClie.Text = "";
                tbCorreo.Clear();
                tb_CedulaClie.Clear();
                tb_RNC.Clear();
                tb_NombreEmp.Clear();
                tb_DireccionEmpre.Clear();
                tbNomClie.Focus();

                DataTable data = new DataTable();
                SqlDataAdapter Data = new SqlDataAdapter("SELECT * FROM Clientes", Conexion);

                Data.Fill(data);

                dgvClientes.DataSource = data;
            }
            else
            {
                MessageBox.Show("Error al actualizar información.");
            }

            Conexion.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Conexion.Open();

            int error = 0;

            string Query = "DELETE FROM Clientes WHERE nom_clie=" + tbNomClie.Text + "";
            SqlCommand comando = new SqlCommand(Query, Conexion);

            error = comando.ExecuteNonQuery();
            if (error == 1)
            {
                MessageBox.Show("El Cliente ha sido eliminado.");
                tbNomClie.Clear();
                DataTable data = new DataTable();
                SqlDataAdapter Data = new SqlDataAdapter("SELECT * FROM Clientes", Conexion);

                Data.Fill(data);

                dgvClientes.DataSource = data;
            }

            else
            {
                MessageBox.Show("No se ha eliminado ningun cliente.");
            }
            Conexion.Close();
        }
    }
}
