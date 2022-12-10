using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
        String Conexion = "Data Source=.;Initial Catalog=PrototipoIS;Integrated Security=True";

        public DataTable GetAll()
        {
            var tabla = new DataTable();
            using (var openConexion = new SqlConnection(Conexion))
            using (var comando = new SqlCommand())
            {
                openConexion.Open();
                comando.Connection = openConexion;
                var datos = new SqlDataAdapter("SELECT * FROM Clientes", openConexion);
                datos.Fill(tabla);
            }
            return tabla;
        }

        private void LoadDGVproductos()
        {
            dgvClientes.DataSource = GetAll();
            label5.Text = "Total de Registros: " + dgvClientes.RowCount;

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            LoadDGVproductos();
            //NuevoIngreso();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuario VolverInicio = new Usuario();
            VolverInicio.Show();
        }

        private void Limpieza()
        {

            tbNomClie.Clear();
            tb_telefono.Clear();
            tb_direClie.Clear();
            tbCorreo.Clear();
            tb_CedulaClie.Clear();
            tb_RNC.Clear();
            tb_NombreEmp.Clear();
            tb_DireccionEmpre.Clear();
            tbNomClie.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Limpieza();
        }

        private void NuevoIngreso()
        {
            int id = 0;
            using (var openConexion = new SqlConnection(Conexion))
            using (var comando = new SqlCommand())
            {
                openConexion.Open();
                comando.Connection = openConexion;
                comando.CommandText = "SELECT MAX(id_clientes) FROM Clientes";
                //comando.ExecuteNonQuery();

                if (comando.ExecuteScalar() is DBNull) { id = 1; }
                else if (Convert.ToInt32(comando.ExecuteScalar()) > 0)
                {
                    id = Convert.ToInt32(comando.ExecuteScalar()) + 1;
                }
                tbCodClie.Text = Convert.ToString(id);

            }

        }
        //Metodo Guardar
        private void Guardar()
        {

            using (var openConexion = new SqlConnection(Conexion))
            using (var comando = new SqlCommand())
            {
                openConexion.Open();
                comando.Connection = openConexion;
                comando.CommandText = "INSERT INTO Clientes VALUES (@nombre, @telefono, @direccion, @cedula, @RNC, @nombreEmp, @direccionEmp) ";
                // comando.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(tb_CodProduct.Text);
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = tbNomClie.Text;
                comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = tb_telefono.Text;
                comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = tb_DireccionEmpre.Text;
                comando.Parameters.Add("@cedula", SqlDbType.VarChar).Value = tb_CedulaClie.Text;
                comando.Parameters.Add("@RNC", SqlDbType.VarChar).Value = tb_RNC.Text;
                comando.Parameters.Add("@nombreEmp", SqlDbType.VarChar).Value = tb_NombreEmp.Text;
                comando.Parameters.Add("@direccionEmp", SqlDbType.VarChar).Value = tb_DireccionEmpre.Text;
                comando.ExecuteNonQuery();
            }
        }
        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            Guardar();
            Limpieza();
            NuevoIngreso();
            LoadDGVproductos();

            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Conexion.Open();

            //int error = 0;

            //string Query = " UPDATE Clientes SET id_productos= '" + tbNomClie.Text + "','" + tb_telefono.Text + "','" + tb_direClie.Text + "','" + tb_CedulaClie.Text + "','" + tb_RNC.Text +
            //    "','" + tb_NombreEmp.Text + "','" + tb_DireccionEmpre.Text + "'";

            //SqlCommand comando = new SqlCommand(Query, Conexion);

            //error = comando.ExecuteNonQuery();
            //if (error == 1)
            //{
            //    MessageBox.Show("Datos actualizados.");

            //    tbNomClie.Clear();
            //    tb_telefono.Clear();
            //    tb_direClie.Text = "";
            //    tbCorreo.Clear();
            //    tb_CedulaClie.Clear();
            //    tb_RNC.Clear();
            //    tb_NombreEmp.Clear();
            //    tb_DireccionEmpre.Clear();
            //    tbNomClie.Focus();

            //    DataTable data = new DataTable();
            //    SqlDataAdapter Data = new SqlDataAdapter("SELECT * FROM Clientes", Conexion);

            //    Data.Fill(data);

            //    dgvClientes.DataSource = data;
            //}
            //else
            //{
            //    MessageBox.Show("Error al actualizar información.");
            //}

            //Conexion.Close();
        }

        private void Eliminar(int eliminar)
        {
            using (var openConexion = new SqlConnection(Conexion))
            using (var comando = new SqlCommand())
            {
                openConexion.Open();
                comando.Connection = openConexion;
                comando.CommandText = "DELETE FROM Clientes WHERE id_clientes = @id";
                comando.Parameters.Add("@id", SqlDbType.Int).Value = eliminar;
                comando.ExecuteNonQuery();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea eliminar este producto?", "ELIMINAR PRODUCTO",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                Eliminar(Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value));
                LoadDGVproductos();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
