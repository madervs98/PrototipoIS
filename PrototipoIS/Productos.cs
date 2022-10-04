using System;
using System.Collections;
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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        //Conexión de Base de Datos.
        String Conexion = "Data Source=.;Initial Catalog=PrototipoIS;Integrated Security=True";
        


        private void label1_Click(object sender, EventArgs e)
        {

        }



        public DataTable GetAll()
        {
            var tabla = new DataTable();
            using (var openConexion = new SqlConnection(Conexion))
            using (var comando = new SqlCommand())
            {
                openConexion.Open();
                comando.Connection = openConexion;
                // comando.CommandText = "SELECT * FROM Productos";
                //comando.Parameters.Add("@id", SqlDbType.Int).Value = eliminar;
                //comando.ExecuteNonQuery();
                var datos = new SqlDataAdapter("SELECT * FROM Productos", openConexion);
                datos.Fill(tabla);
            }
            return tabla;
        }

        private void LoadDGVproductos()
        {
            dgvProductos.DataSource = GetAll();
            label8.Text = "Total de Registros: " + dgvProductos.RowCount;
            
        }



        private void Productos_Load(object sender, EventArgs e)
        {

            LoadDGVproductos();
            NuevoIngreso();

            //Conexion.Open();

            //DataTable data = new DataTable();
            //SqlDataAdapter Data = new SqlDataAdapter("SELECT * FROM Productos", Conexion);

            //Data.Fill(data);

            //dgvProductos.DataSource = data;
            //Conexion.Close();
        }
        //Botón para limpiar los campos. 

        private void Limpieza()
        {
            tb_CodProduct.Clear();
            tb_NomPro.Clear();
            cb_TipoPro.Text = "";
            tb_DescripPro.Clear();
            tb_CantPro.Clear();
            tb_PrecioPro.Clear();
            tb_NomPro.Focus();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Limpieza();
        }
        //Boton Ingresar Datos.


        private void NuevoIngreso()
        {
            int id = 0;
            using (var openConexion = new SqlConnection(Conexion))
            using (var comando = new SqlCommand())
            {
                openConexion.Open();
                comando.Connection = openConexion;
                comando.CommandText = "SELECT MAX(id_productos) FROM Productos";
                //comando.ExecuteNonQuery();

                if (comando.ExecuteScalar()is DBNull) { id = 1; }
                else if (Convert.ToInt32(comando.ExecuteScalar()) > 0)
                    {
                    id = Convert.ToInt32(comando.ExecuteScalar()) + 1;
                    }
                tb_CodProduct.Text = Convert.ToString(id);
                    
            }

        }
        private void Guardar()
        {

            using (var openConexion = new SqlConnection(Conexion))
            using (var comando = new SqlCommand())
            {
                openConexion.Open();
                comando.Connection = openConexion;
                comando.CommandText = "INSERT INTO Productos VALUES (@nombre, @tipoPro, @Descripcion, @Cantidad, @Precio) ";
               // comando.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(tb_CodProduct.Text);
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = tb_NomPro.Text;
                comando.Parameters.Add("@tipoPro", SqlDbType.VarChar).Value = cb_TipoPro.Text;
                comando.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = tb_DescripPro.Text;
                comando.Parameters.Add("@Cantidad", SqlDbType.VarChar).Value = tb_CantPro.Text;
                comando.Parameters.Add("@Precio", SqlDbType.VarChar).Value = tb_PrecioPro.Text; 
                comando.ExecuteNonQuery();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Guardar();
            Limpieza();
            NuevoIngreso();
            LoadDGVproductos();
            //Conexion.Open();
            //int error = 0;
            //string Query = "INSERT INTO Productos VALUES('" + tb_CodProduct.Text + "','" + tb_NomPro.Text + "','" + cb_TipoPro.Text + "','" + 
            //    tb_DescripPro.Text + "','" + tb_CantPro.Text + "','" + tb_PrecioPro.Text + "')";

            //SqlCommand comando = new SqlCommand(Query, Conexion);

            //error = comando.ExecuteNonQuery();
            //if (error == 1)
            //{
            //    MessageBox.Show("Datos guardados.");

            //    tb_CodProduct.Clear();
            //    tb_NomPro.Clear();
            //    cb_TipoPro.Text= "";
            //    tb_DescripPro.Clear();
            //    tb_CantPro.Clear();
            //    tb_PrecioPro.Clear();
            //    tb_CodProduct.Focus();

            //    DataTable data = new DataTable();
            //    SqlDataAdapter Data = new SqlDataAdapter("SELECT * FROM Productos", Conexion);

            //    Data.Fill(data);

            //    dgvProductos.DataSource = data;
            //}
            //else
            //    MessageBox.Show("Error al guardar los datos.");

            //Conexion.Close();
        }
        //Botón Actualizar
        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            //Conexion.Open();

            //int error = 0;

            //string Query = " UPDATE Productos SET id_productos= '" + tb_CodProduct.Text + "', nom_pro='" + tb_NomPro.Text + "', tipo_pro='" +
            //cb_TipoPro.Text + "',descrip_pro='" + tb_DescripPro.Text + "',cant_pro='" + tb_CantPro.Text + "',precio_pro='"+ tb_PrecioPro.Text +
            //"' WHERE id_productos='" + tb_CodProduct.Text + "'";

            //SqlCommand comando = new SqlCommand(Query, Conexion);

            //error = comando.ExecuteNonQuery();
            //if (error == 1)
            //{
            //    MessageBox.Show("Datos actualizados.");

            //    tb_CodProduct.Clear();
            //    tb_NomPro.Clear();
            //    cb_TipoPro.Text = "";
            //    tb_DescripPro.Clear();
            //    tb_CantPro.Clear();
            //    tb_PrecioPro.Clear();
            //    tb_CodProduct.Focus();

            //    DataTable data = new DataTable();
            //    SqlDataAdapter Data = new SqlDataAdapter("SELECT * FROM Productos", Conexion);

            //    Data.Fill(data);

            //    dgvProductos.DataSource = data;
            //}else
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
                comando.CommandText = "Delete From Productos Where id_productos = @id";
                comando.Parameters.Add("@id", SqlDbType.Int).Value = eliminar;
                comando.ExecuteNonQuery();
            }

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea eliminar este producto?", "ELIMINAR PRODUCTO",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question, 
            MessageBoxDefaultButton.Button1);

            if(result == DialogResult.Yes) {
                Eliminar(Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value));
                LoadDGVproductos();
            }



            //Conexion.Open();

            //int error = 0;

            //string Query = "DELETE FROM Productos WHERE id_productos=" + tb_CodProduct.Text + "";
            //SqlCommand comando = new SqlCommand(Query, Conexion);

            //error = comando.ExecuteNonQuery();
            //if (error == 1)
            //{
            //    MessageBox.Show("El producto ha sido eliminado.");
            //    tb_CodProduct.Clear();
            //    DataTable data = new DataTable();
            //    SqlDataAdapter Data = new SqlDataAdapter("SELECT * FROM Productos", Conexion);

            //    Data.Fill(data);

            //    dgvProductos.DataSource = data;
            //}

            //else
            //{
            //    MessageBox.Show("No se ha eliminado ningun producto.");
            //}
            //Conexion.Close();
        }


        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuario VolverInicio = new Usuario();
            VolverInicio.Show();
        }

        private void btnBuscador_Click(object sender, EventArgs e)
        {
            //Conexion.Open();

            ////String Contenido = "";

            //string Query = "SELECT * FROM Productos WHERE id_productos= " + tb_buscador.Text;
            //SqlDataAdapter adaptador = new SqlDataAdapter(Query, Conexion);

            //DataTable data = new DataTable();
            //adaptador.Fill(data);
            //dgvProductos.DataSource = data;
            //SqlCommand comando = new SqlCommand(Query, Conexion);
            //SqlDataReader lector;
            //lector = comando.ExecuteReader();


            //Conexion.Close();
        }

        private void tb_buscador_TextChanged(object sender, EventArgs e)
        {
            //Conexion.Open();

            ////String Contenido = "";

            //string Query = "SELECT * FROM Productos WHERE id_productos= " + tb_buscador.Text;
            //SqlDataAdapter adaptador = new SqlDataAdapter(Query, Conexion);

            //DataTable data = new DataTable();
            //adaptador.Fill(data);
            //dgvProductos.DataSource = data;
            //SqlCommand comando = new SqlCommand(Query, Conexion);
            //SqlDataReader lector;
            //lector = comando.ExecuteReader();

            //if(tb_buscador.Text == "")
            //{
                
            //    SqlDataAdapter Data = new SqlDataAdapter("SELECT * FROM Productos", Conexion);

            //    Data.Fill(data);

            //    dgvProductos.DataSource = data;
            //}

            //Conexion.Close();
        }
    }
}
