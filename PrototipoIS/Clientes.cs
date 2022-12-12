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
            EventosAsociados();
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
                comando.CommandText = ("SELECT * FROM Clientes WHERE id_clientes=@id OR nombreCli LIKE @nombre+'%' ORDER BY id_clientes ");
                comando.Parameters.Add("@id", SqlDbType.Int).Value = id;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
                var datos = new SqlDataAdapter(comando);
                datos.Fill(tabla);
            }
            return tabla;
        }

        private void LoadDGVproductos(bool search)
        {
            if (search == true)
            {
                dgvClientes.DataSource = GetAll();
            }
            else
            {
                dgvClientes.DataSource = GetByValue(tb_buscador.Text);
            }
            ;
            label5.Text = "Total de Registros: " + dgvClientes.RowCount;

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            LoadDGVproductos(true);
            NuevoIngreso();
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
            //tb_telefono.Clear();
            tb_direClie.Clear();
            tbCorreo.Clear();
            tb_CedulaClie.Clear();
            tb_RNC.Clear();
            tb_NombreEmp.Clear();
            tb_DireccionEmpre.Clear();
            tbNomClie.Focus();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
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
                comando.CommandText = "INSERT INTO Clientes VALUES (@nombre, @direccion, @correo, @cedula, @RNC, @nombreEmp, @direccionEmp) ";
                // comando.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(tb_CodProduct.Text);
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = tbNomClie.Text;
                //comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = tb_telefono.Text;
                comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = tb_direClie.Text;
                comando.Parameters.Add("@correo", SqlDbType.VarChar).Value = tbCorreo.Text;
                comando.Parameters.Add("@cedula", SqlDbType.VarChar).Value = tb_CedulaClie.Text;
                comando.Parameters.Add("@RNC", SqlDbType.VarChar).Value = tb_RNC.Text;
                comando.Parameters.Add("@nombreEmp", SqlDbType.VarChar).Value = tb_NombreEmp.Text;
                comando.Parameters.Add("@direccionEmp", SqlDbType.VarChar).Value = tb_DireccionEmpre.Text;
                comando.ExecuteNonQuery();
            }
        }

       /* private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            Guardar();
            Limpieza();
            NuevoIngreso();
            LoadDGVproductos();
            
        }*/
        private void Actualizar()
        {
            using (var openConexion = new SqlConnection(Conexion))
            using (var comando = new SqlCommand())
            {
                openConexion.Open();
                comando.Connection = openConexion;
                comando.CommandText = "UPDATE Clientes SET nom_clie = @nombreCli, direccion_clie = @direccionCli, " +
                    "correo_clie=@correoCli, documento_clie=@documCli, rnc_clie = @rncCli, " +
                    "nom_empresa = @nomEmpCli, direccion_empresa = @direccionempcli WHERE id_clientes = @id";
                comando.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(tbCodClie.Text);
                comando.Parameters.Add("@nombreCli", SqlDbType.VarChar).Value = tbNomClie.Text;
                comando.Parameters.Add("@direccionCli", SqlDbType.VarChar).Value = tb_direClie.Text;
                comando.Parameters.Add("@correoCli", SqlDbType.VarChar).Value = tbCorreo.Text;
                comando.Parameters.Add("@documCli", SqlDbType.VarChar).Value = tb_CedulaClie.Text;
                comando.Parameters.Add("@rncCli", SqlDbType.VarChar).Value = tb_RNC.Text;
                comando.Parameters.Add("@nomEmpCli", SqlDbType.VarChar).Value = tb_NombreEmp.Text;
                comando.Parameters.Add("@direccionempcli", SqlDbType.VarChar).Value = tb_DireccionEmpre.Text;
                comando.ExecuteNonQuery();

            }
        }
       /* private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }*/

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

        /*private void btnEliminar_Click(object sender, EventArgs e)
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
        }*/

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbCodClie.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            tbNomClie.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            tb_direClie.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            tbCorreo.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            tb_CedulaClie.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            tb_RNC.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();
            tb_NombreEmp.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();
            tb_DireccionEmpre.Text = dgvClientes.CurrentRow.Cells[7].Value.ToString();
        }



        private void Procesos(object sender)
        {

            Button btn = sender as Button;

            if (btn == btn_Ingresar)
            {
                Guardar();
            }

            else if (btn == btnRefresh)
            {
                Actualizar();
            }
            else if (btn == btnEliminar)
            {
                Eliminar(Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value));
                Limpieza();
                NuevoIngreso();
                LoadDGVproductos(true);
            }
            if (btn != btnEliminar)
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

            btnRefresh.Click += delegate (object sender, EventArgs e)
            {
                Procesos(btnRefresh);
            };

            btnEliminar.Click += delegate (object sender, EventArgs e)
            {
                var result = MessageBox.Show("¿Desea eliminar este producto?", "ELIMINAR PRODUCTO",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {

                    Procesos(btnEliminar);

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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}
