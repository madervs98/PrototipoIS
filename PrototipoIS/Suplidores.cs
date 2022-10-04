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
    public partial class Suplidores : Form
    {
        public Suplidores()
        {
            InitializeComponent();
        }

        SqlConnection Conexion = new SqlConnection("Data Source=.;Initial Catalog=PrototipoIS;Integrated Security=True");


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuario VolverInicio = new Usuario();
            VolverInicio.Show();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            Conexion.Open();
            int error = 0;
            string Query = "INSERT INTO dbo.Suplidores (nom_supl, direccion_supl, contact_supl, nomEmp_supl) VALUES('" + tb_NomSup.Text + "','" + tb_DireccionSup.Text + "','" + tb_ContactoSup.Text + "','" + tb_NomEmpSup.Text + "')";

            SqlCommand comando = new SqlCommand(Query, Conexion);

            error = comando.ExecuteNonQuery();
            if (error == 1)
            {
                MessageBox.Show("Datos guardados.");

                tb_CodSup.Clear();
                tb_NomSup.Clear();
                tb_DireccionSup.Clear();
                tb_ContactoSup.Clear();
                tb_NomEmpSup.Clear();
                tb_CodSup.Focus();

                DataTable data = new DataTable();
                SqlDataAdapter Data = new SqlDataAdapter("SELECT * FROM Suplidores", Conexion);

                Data.Fill(data);

                dgv_Suplidores.DataSource = data;
            }
            else
                MessageBox.Show("Error al guardar los datos.");

            Conexion.Close();
        }

        private void Suplidores_Load(object sender, EventArgs e)
        {
            Conexion.Open();

            DataTable data = new DataTable();
            SqlDataAdapter Data = new SqlDataAdapter("SELECT * FROM Suplidores", Conexion);

            Data.Fill(data);

            dgv_Suplidores.DataSource = data;
            Conexion.Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            tb_CodSup.Clear();
            tb_NomSup.Clear();
            tb_DireccionSup.Clear();
            tb_ContactoSup.Clear();
            tb_NomEmpSup.Clear();
            tb_CodSup.Focus();
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            Conexion.Open();

            int error = 0;

            string Query = " UPDATE Suplidores SET nom_supl= '" + tb_NomSup.Text + "', direccion_supl='" + tb_DireccionSup.Text + "',contact_supl='"
                + tb_ContactoSup.Text + "',nomEmp_supl='" + tb_NomEmpSup.Text + "'";

            SqlCommand comando = new SqlCommand(Query, Conexion);

            error = comando.ExecuteNonQuery();
            if (error == 1)
            {
                MessageBox.Show("Datos actualizados");
                tb_CodSup.Clear();
                tb_NomSup.Clear();
                tb_DireccionSup.Clear();
                tb_ContactoSup.Clear();
                tb_NomEmpSup.Clear();
                tb_CodSup.Focus();
                DataTable data = new DataTable();
                SqlDataAdapter Data = new SqlDataAdapter("SELECT * FROM Suplidores", Conexion);

                Data.Fill(data);

                dgv_Suplidores.DataSource = data;
            }

            Conexion.Close();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Conexion.Open();

            int error = 0;

            string Query = "DELETE FROM Suplidores WHERE nom_supl=" + tb_NomSup.Text + "";
            SqlCommand comando = new SqlCommand(Query, Conexion);

            error = comando.ExecuteNonQuery();
            if (error == 1)
            {
                MessageBox.Show("El producto ha sido eliminado.");
                tb_NomSup.Clear();
                DataTable data = new DataTable();
                SqlDataAdapter Data = new SqlDataAdapter("SELECT * FROM Suplidores", Conexion);

                Data.Fill(data);

                dgv_Suplidores.DataSource = data;
            }

            else
            {
                MessageBox.Show("No se ha eliminado ningun producto.");
            }
            Conexion.Close();
        }

        private void btnBuscador_Click(object sender, EventArgs e)
        {
            Conexion.Open();

            string Query = "SELECT * FROM Suplidores WHERE id_suplidores= " + tb_buscador.Text;
            SqlDataAdapter adaptador = new SqlDataAdapter(Query, Conexion);
            DataTable data = new DataTable();
            adaptador.Fill(data);
            dgv_Suplidores.DataSource = data;
            SqlCommand comando = new SqlCommand(Query, Conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();

            Conexion.Close();
        }
    }
}
