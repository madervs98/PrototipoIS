using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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
            EventosAsociados();
        }

        //Conexión de Base de Datos.
        String Conexion = "Data Source=.;Initial Catalog=PrototipoIS;Integrated Security=True";
        
        //Mantener los campos actualizados en el DGV
        public DataTable GetAll()
        {
            var tabla = new DataTable();
           // int id = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            //string nombre = value;
            using (var openConexion = new SqlConnection(Conexion))
            using (var comando = new SqlCommand())
            {
                openConexion.Open();
                comando.Connection = openConexion;
                var datos = new SqlDataAdapter("SELECT * FROM Productos", openConexion);
                datos.Fill(tabla);
            }
            return tabla;
        }

        public DataTable GetByValue(string value)
        {
            var tabla = new DataTable();
            int id = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string nombre = value;
            using (var openConexion = new SqlConnection(Conexion))
            using (var comando = new SqlCommand())
            {
                openConexion.Open();
                comando.Connection = openConexion;
                comando.CommandText = ("SELECT * FROM Productos WHERE id_productos=@id OR nom_pro LIKE @nombre+'%' ORDER BY id_productos ");
                comando.Parameters.Add("@id", SqlDbType.Int).Value = id;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
                var datos = new SqlDataAdapter(comando);
                datos.Fill(tabla);
            }
            return tabla;
        }

        private void LoadDGVproductos(bool search)
        {
            if(search == true)
            {
                dgvProductos.DataSource = GetAll();
            }
            else
            {
                dgvProductos.DataSource = GetByValue(tb_buscador.Text);
            }
            ;
            label8.Text = "Total de Registros: " + dgvProductos.RowCount;
            
        }

        private void Productos_Load(object sender, EventArgs e)
        {

            LoadDGVproductos(true);
            NuevoIngreso();
    
        }

        //Botón para limpiar los campos. 
        private void Limpieza()
        {
            tb_NomPro.Clear();
            cb_TipoPro.Text = "";
            tb_DescripPro.Clear();
            tb_CantPro.Clear();
            tb_PrecioPro.Clear();
            tb_NomPro.Focus();
        }

        //Metodo Nuevo Ingreso
        private void NuevoIngreso()
        {
            int id = 0;
            using (var openConexion = new SqlConnection(Conexion))
            using (var comando = new SqlCommand())
            {
                openConexion.Open();
                comando.Connection = openConexion;
                comando.CommandText = "SELECT MAX(id_productos) FROM Productos";

                if (comando.ExecuteScalar()is DBNull) { id = 1; }
                else if (Convert.ToInt32(comando.ExecuteScalar()) > 0)
                    {
                    id = Convert.ToInt32(comando.ExecuteScalar()) + 1;
                    }
                tb_CodProduct.Text = Convert.ToString(id);
                    
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
                comando.CommandText = "INSERT INTO Productos VALUES (@nombre, @tipoPro, @Descripcion, @Cantidad, @Precio) ";
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = tb_NomPro.Text;
                comando.Parameters.Add("@tipoPro", SqlDbType.VarChar).Value = cb_TipoPro.Text;
                comando.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = tb_DescripPro.Text;
                comando.Parameters.Add("@Cantidad", SqlDbType.VarChar).Value = tb_CantPro.Text;
                comando.Parameters.Add("@Precio", SqlDbType.VarChar).Value = tb_PrecioPro.Text; 
                comando.ExecuteNonQuery();
            }
        }

        private void Actualizar()
        {
            using (var openConexion = new SqlConnection(Conexion))
            using (var comando = new SqlCommand())
            {
                openConexion.Open();
                comando.Connection = openConexion;
                comando.CommandText = "UPDATE Productos SET nom_pro = @nombre, tipo_pro = @tipoPro, descrip_pro=@Descripcion, cant_pro=@Cantidad, precio_pro=@Precio WHERE id_productos = @id";
                comando.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(tb_CodProduct.Text);
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = tb_NomPro.Text;
                comando.Parameters.Add("@tipoPro", SqlDbType.VarChar).Value = cb_TipoPro.Text;
                comando.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = tb_DescripPro.Text;
                comando.Parameters.Add("@Cantidad", SqlDbType.VarChar).Value = tb_CantPro.Text;
                comando.Parameters.Add("@Precio", SqlDbType.VarChar).Value = tb_PrecioPro.Text;
                comando.ExecuteNonQuery();
                
            }
        }

        private void Eliminar(int eliminar)
        {
            using (var openConexion = new SqlConnection(Conexion))
            using (var comando = new SqlCommand())
            {
                openConexion.Open();
                comando.Connection = openConexion;
                comando.CommandText = "DELETE FROM Productos WHERE id_productos = @id";
                comando.Parameters.Add("@id", SqlDbType.Int).Value = eliminar;
                comando.ExecuteNonQuery();
            }

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuario VolverInicio = new Usuario();
            VolverInicio.Show();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_CodProduct.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            tb_NomPro.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            tb_DescripPro.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
            cb_TipoPro.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
            tb_CantPro.Text = dgvProductos.CurrentRow.Cells[4].Value.ToString();
            tb_PrecioPro.Text = dgvProductos.CurrentRow.Cells[5].Value.ToString();
        }

        //Metodo para englobar
        private void Procesos(object sender)
        {
            
            Button btn = sender as Button;
            
            if (btn == btn_Ingresar)
            {
                Guardar();
            }
            /*else if(btn == btn_Limpiar)
            {
                Limpieza();
            }*/
            else if (btn == btn_Actualizar)
            {
                Actualizar();
            }
            else if (btn == btn_Eliminar)
            {
                Eliminar(Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value));
                Limpieza();
                NuevoIngreso();
                LoadDGVproductos(true);
            }
            if (btn != btn_Eliminar)
            {
                Limpieza(); 
                NuevoIngreso();
                LoadDGVproductos(true); 
            }
            
        }

        private void EventosAsociados()
        {
            btn_Ingresar.Click += delegate (object sender, EventArgs e) //Agregar
            {
                Procesos(btn_Ingresar);
            };

            btn_Limpiar.Click += delegate (object sender, EventArgs e) //Limpiar
           {
               Procesos(btn_Limpiar);

           };

            btn_Actualizar.Click += delegate (object sender, EventArgs e)
            {
                Procesos(btn_Actualizar);
            };

            btn_Eliminar.Click += delegate (object sender, EventArgs e)
            {
                var result = MessageBox.Show("¿Desea eliminar este producto?", "ELIMINAR PRODUCTO",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {

                    Procesos(btn_Eliminar);

                }
            };

            tb_buscador.TextChanged += delegate (object sender, EventArgs e)
            {
                if (string.IsNullOrWhiteSpace(tb_buscador.Text))
                {
                    LoadDGVproductos(true);
                    return;
                }
                LoadDGVproductos(false);
            };
        }

        //Final
    }
}
