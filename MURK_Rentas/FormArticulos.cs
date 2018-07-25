using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MURK_Rentas
{
    public partial class FormArticulos : Form
    {
        System.Data.SqlClient.SqlConnection con; //variable que lleva al servidor

        public FormArticulos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand query = con.CreateCommand();//crea comando
                query.CommandType = CommandType.Text;
                query.CommandText = string.Format("EXEC ALTA_ARTICULO'" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.SelectedValue + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox2.SelectedValue + "'");
                int result = query.ExecuteNonQuery();//Regresa valor binario si se ejecuta o no la consulta
                if (result > 0)
                {
                    MessageBox.Show("Registro almacenado exitosamente");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                }
                else
                {
                    MessageBox.Show("No se pudo almacenar el registro");
                }
            }
            catch
            {
                MessageBox.Show("Error-catch");
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();                    
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCategoria FCat = new FormCategoria();
            FCat.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormProveedor FPro = new FormProveedor();
            FPro.Show();
        }

        public DataTable listaProveedores()
        {
            DataTable tablaProv = new DataTable();
            SqlDataReader leerFilas;

            con.Open();
            SqlCommand consulta = con.CreateCommand();//crea comando
            consulta.CommandType = CommandType.Text;
            consulta.CommandText = string.Format("EXEC LISTAR_PROVEEDORES ");
            leerFilas = consulta.ExecuteReader();
            tablaProv.Load(leerFilas);
            leerFilas.Close();
            con.Close();
            return tablaProv;
        }

        public void cargarProveedores()
        {
            comboBox2.DataSource = listaProveedores();
            comboBox2.DisplayMember = "Proveedor";
            comboBox2.ValueMember = "ID";
        }

        public DataTable listaCategorias()
        {
            DataTable tablaProv = new DataTable();
            SqlDataReader leerFilas;

            con.Open();
            SqlCommand consulta = con.CreateCommand();//crea comando
            consulta.CommandType = CommandType.Text;
            consulta.CommandText = string.Format("EXEC LISTAR_CATEGORIAS ");
            leerFilas = consulta.ExecuteReader();
            tablaProv.Load(leerFilas);
            leerFilas.Close();
            con.Close();
            return tablaProv;
        }

        public void cargarCategorias()
        {
            comboBox1.DataSource = listaCategorias();
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "ID";
        }

        private void FormArticulos_Load(object sender, EventArgs e)
        {
            //conexion
            con = new System.Data.SqlClient.SqlConnection(); //llamar conexion al form load
            con.ConnectionString = "Data Source=localhost;Initial Catalog=MURK;Integrated Security=True";
            cargarProveedores();
            cargarCategorias();
        }
    }
}
