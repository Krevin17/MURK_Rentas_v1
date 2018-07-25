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
    public partial class FormCategoria : Form
    {
        System.Data.SqlClient.SqlConnection con; //variable que lleva al servidor
        public FormCategoria()
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
                query.CommandText = string.Format("EXEC ALTA_CATEGORIA '" + textBox1.Text + "'");
                int result = query.ExecuteNonQuery();//Regresa valor binario si se ejecuta o no la consulta
                if (result > 0)
                {
                    MessageBox.Show("Registro almacenado exitosamente");
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("No se pudo almacenar el registro");
                }
            }
            catch
            {

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

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            con = new System.Data.SqlClient.SqlConnection(); //llamar conexion al form load
            con.ConnectionString = "Data Source=localhost;Initial Catalog=MURK;Integrated Security=True";
        }

        private void FormCategoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
