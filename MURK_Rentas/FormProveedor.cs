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
    public partial class FormProveedor : Form
    {
        System.Data.SqlClient.SqlConnection con; //variable que lleva al servidor
        public FormProveedor()
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
                query.CommandText = string.Format("EXEC ALTA_PROVEEDOR'" + textBox1.Text + "','" + textBox2.Text + "','"+ textBox3.Text +"','"+ textBox4.Text + "','" + comboBox1.SelectedValue + "'");
                int result = query.ExecuteNonQuery();//Regresa valor binario si se ejecuta o no la consulta
                if (result > 0)
                {
                    MessageBox.Show("Registro almacenado exitosamente");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
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

        private void FormProveedor_Load(object sender, EventArgs e)
        {
            con = new System.Data.SqlClient.SqlConnection(); //llamar conexion al form load
            con.ConnectionString = "Data Source=localhost;Initial Catalog=MURK;Integrated Security=True";
            cargarCompañias();
        }

        public DataTable listaCompañias()
        {
            DataTable tablaComp = new DataTable();
            SqlDataReader leerFilas;         
                        
            con.Open();
            SqlCommand consulta = con.CreateCommand();//crea comando
            consulta.CommandType = CommandType.Text;
            consulta.CommandText = string.Format("EXEC LISTAR_COMPAÑIAS ");
            leerFilas = consulta.ExecuteReader();
            tablaComp.Load(leerFilas);
            leerFilas.Close();
            con.Close();
            return tablaComp;
        }

        public void cargarCompañias()
        {
            comboBox1.DataSource = listaCompañias();
            comboBox1.DisplayMember = "NOMBRE";
            comboBox1.ValueMember = "ID";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand query = con.CreateCommand();//crea comando
                query.CommandType = CommandType.Text;
                query.CommandText = string.Format("EXEC ALTA_COMPAÑIA'" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "'");
                int result = query.ExecuteNonQuery();//Regresa valor binario si se ejecuta o no la consulta
                if (result > 0)
                {
                    MessageBox.Show("Registro almacenado exitosamente");
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    textBox10.Text = "";
                    textBox11.Text = "";
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
                    cargarCompañias();
                }
            }
        }
    }
}
