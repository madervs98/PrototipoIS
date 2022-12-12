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
    public partial class Suplidores : Form
    {
        public Suplidores()
        {
            InitializeComponent();
            EventosAsociados();

        }

        String Conexion = ("Data Source=.;Initial Catalog=PrototipoIS;Integrated Security=True");

        SuplidoresModel model = new SuplidoresModel();

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuario VolverInicio = new Usuario();
            VolverInicio.Show();
        }

        private void Suplidores_Load(object sender, EventArgs e)
        {
            LoadDGVproductos(true);
            NuevoIngreso();
        }

        //Metodos 
        private void Guardar()
        {

            using (var openConexion = new SqlConnection(Conexion))
            using (var comando = new SqlCommand())
            {
                openConexion.Open();
                comando.Connection = openConexion;
                comando.CommandText = "INSERT INTO Suplidores VALUES (@nombreSup, @direccionSup, @contactoSup, @nombreEmpresaSup) ";
                comando.Parameters.Add("@nombreSup", SqlDbType.VarChar).Value = tb_NomSup.Text;
                comando.Parameters.Add("@direccionSup", SqlDbType.VarChar).Value = tb_DireccionSup.Text;
                comando.Parameters.Add("@contactoSup", SqlDbType.VarChar).Value = tb_ContactoSup.Text;
                comando.Parameters.Add("@nombreEmpresaSup", SqlDbType.VarChar).Value = tb_NomEmpSup.Text;
                comando.ExecuteNonQuery();
            }
        }

        private void NuevoIngreso()
        {
            int id = 0;
            using (var openConexion = new SqlConnection(Conexion))
            using (var comando = new SqlCommand())
            {
                openConexion.Open();
                comando.Connection = openConexion;
                comando.CommandText = "SELECT MAX(id_suplidores) FROM Suplidores";

                if (comando.ExecuteScalar() is DBNull) { id = 1; }
                else if (Convert.ToInt32(comando.ExecuteScalar()) > 0)
                {
                    id = Convert.ToInt32(comando.ExecuteScalar()) + 1;
                }
                tb_CodSup.Text = Convert.ToString(id);

            }

        }

        private void Limpieza()
        {
            tb_NomSup.Clear();
            tb_DireccionSup.Clear();
            tb_ContactoSup.Clear();
            tb_NomEmpSup.Clear();
            tb_NomSup.Focus();
        }

        private void Actualizar()
        {
            using (var openConexion = new SqlConnection(Conexion))
            using (var comando = new SqlCommand())
            {
                openConexion.Open();
                comando.Connection = openConexion;
                comando.CommandText = "UPDATE Suplidores SET nom_supl = @nombreSup, direccion_supl = @direccionSup, contact_supl=@contactoSup, nomEmp_supl=@nombreEmpresaSup WHERE id_suplidores = @id";
                comando.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(tb_CodSup.Text);
                comando.Parameters.Add("@nombreSup", SqlDbType.VarChar).Value = tb_NomSup.Text;
                comando.Parameters.Add("@direccionSup", SqlDbType.VarChar).Value = tb_DireccionSup.Text;
                comando.Parameters.Add("@contactoSup", SqlDbType.VarChar).Value = tb_ContactoSup.Text;
                comando.Parameters.Add("@nombreEmpresaSup", SqlDbType.VarChar).Value = tb_NomEmpSup.Text;
                comando.ExecuteNonQuery();

            }
        }
        private void dgv_Suplidores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_CodSup.Text = dgv_Suplidores.CurrentRow.Cells[0].Value.ToString();
            tb_NomSup.Text = dgv_Suplidores.CurrentRow.Cells[1].Value.ToString();
            tb_DireccionSup.Text = dgv_Suplidores.CurrentRow.Cells[2].Value.ToString();
            tb_ContactoSup.Text = dgv_Suplidores.CurrentRow.Cells[3].Value.ToString();
            tb_NomEmpSup.Text = dgv_Suplidores.CurrentRow.Cells[4].Value.ToString();
        }

        private void Eliminar(int eliminar)
        {
            using (var openConexion = new SqlConnection(Conexion))
            using (var comando = new SqlCommand())
            {
                openConexion.Open();
                comando.Connection = openConexion;
                comando.CommandText = "DELETE FROM Suplidores WHERE id_suplidores = @id";
                comando.Parameters.Add("@id", SqlDbType.Int).Value = eliminar;
                comando.ExecuteNonQuery();
            }

        }

        //Mantener los campos actualizados en el DGV
        public DataTable GetAll()
        {
            var tabla = new DataTable();
            using (var openConexion = new SqlConnection(Conexion))
            using (var comando = new SqlCommand())
            {
                openConexion.Open();
                comando.Connection = openConexion;
                var datos = new SqlDataAdapter("SELECT * FROM Suplidores", openConexion);
                datos.Fill(tabla);
            }
            return tabla;
        }

        public List<SuplidoresModel> GetAllMethod()
         {
             var SuplidoresList = new List<SuplidoresModel>();
             using (var openConexion = new SqlConnection(Conexion))
             using (var comando = new SqlCommand())
             {
                 openConexion.Open();
                 comando.Connection = openConexion;
                 comando.CommandText = "SELECT * FROM Suplidores";
                 //var datos = new SqlDataAdapter("SELECT * FROM Productos", openConexion);
                 //datos.Fill(tabla);
                 using (var read = comando.ExecuteReader())
                 {
                     while (read.Read())
                     {
                         var model = new SuplidoresModel();
                         model.Id = (int)read[0];
                         model.Nombre = read[1].ToString();
                         model.Direccion = read[2].ToString();
                         model.Telefono = read[3].ToString();
                         model.Empresa = read[4].ToString();
                         //model.Precio = read[5].ToString();

                         SuplidoresList.Add(model);
                     }
                 }

             }
             return SuplidoresList;
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
                comando.CommandText = ("SELECT * FROM Suplidores WHERE id_suplidores=@id OR nom_supl LIKE @nombre+'%' ORDER BY id_suplidores ");
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
                dgv_Suplidores.DataSource = GetAll();
            }
            else
            {
                dgv_Suplidores.DataSource = GetByValue(tb_buscador.Text);
            }
            ;
            label7.Text = "Total de Registros: " + dgv_Suplidores.RowCount;

        }

        //Metodo para englobar
        private void Procesos(object sender)
        {

            Button btn = sender as Button;

            if (btn == btn_Ingresar)
            {
                Guardar();
            }

            else if (btn == btn_Actualizar)
            {
                Actualizar();
            }
            else if (btn == btn_Eliminar)
            {
                Eliminar(Convert.ToInt32(dgv_Suplidores.CurrentRow.Cells[0].Value));
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
    }
}

public class SuplidoresModel
{
    //Campos
    private int id;
    private string nombre;
    private string direccion;
    private string telefono;
    private string nombre_empresa;
    private string precio;

    //Propiedades
    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public string Telefono { get => telefono; set => telefono = value; }
    public string Empresa { get => nombre_empresa; set => nombre_empresa = value; }
    //public string Precio { get => precio; set => precio = value; }
}
