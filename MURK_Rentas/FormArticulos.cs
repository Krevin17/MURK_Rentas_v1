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
            if (tituloForm.Text == "Nuevo Articulo")
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
            else if (tituloForm.Text == "Editar Articulo")
            {
                try
                {
                    con.Open();
                    SqlCommand query = con.CreateCommand();//crea comando
                    query.CommandType = CommandType.Text;
                    query.CommandText = string.Format("EXEC MOD_ARTICULOS '" + lbID.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.SelectedValue + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox2.SelectedValue + "'");
                    int result = query.ExecuteNonQuery();//Regresa valor binario si se ejecuta o no la consulta
                    if (result > 0)
                    {
                        MessageBox.Show("Registro modificado exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el registro");
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
                        this.Close();
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCategoria FCat = new FormCategoria();
            FCat.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormProveedor FPro = new FormProveedor();
            FPro.ShowDialog();
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
            if (tituloForm.Text == "Editar Articulo")
            {
                BusquedaEditar();
            }            
        }

        private void BusquedaEditar()
        {
            try
            {
                con.Open();
                SqlCommand consulta = con.CreateCommand();//crea comando
                consulta.CommandType = CommandType.Text;
                consulta.CommandText = string.Format("SELECT * FROM Articulos WHERE Id = '" + lbID.Text + "'");
                SqlDataReader busqueda;
                busqueda = consulta.ExecuteReader();
                while (busqueda.Read() == true)
                {
                    textBox1.Text = busqueda["nombre"].ToString();
                    textBox2.Text = busqueda["descripcion"].ToString();
                    comboBox1.SelectedValue = busqueda["id_categoria"].ToString();
                    textBox3.Text = busqueda["precio_compra"].ToString();
                    textBox4.Text = busqueda["precio_renta"].ToString();
                    comboBox2.SelectedValue = busqueda["id_provedor"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error de busqueda catch");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
