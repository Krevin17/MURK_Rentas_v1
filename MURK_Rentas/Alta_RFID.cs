using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.SqlClient;

namespace MURK_Rentas
{
    public partial class Alta_RFID : Form
    {
        System.Data.SqlClient.SqlConnection con;

        string codigo, codigoProcesado;

        public Alta_RFID()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtRFID.Text = codigo;
        }
        private void buscarUltimo()
        {

            //Busca el usuario con el codigo RFId leido
            try
            {
                con.Open();
                SqlCommand query = con.CreateCommand();
                query.CommandType = CommandType.Text;
                query.CommandText = string.Format("exec ULTIMA_PERSONA");
                SqlDataReader busqueda;
                busqueda = query.ExecuteReader();
                while (busqueda.Read() == true)
                {
                    idUser.Text = busqueda["Id"].ToString();

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
                }
            }
        }

        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            codigo = serialPort2.ReadLine().Trim();
            codigoProcesado = codigo.Trim();
        }

        private void Alta_RFID_Load(object sender, EventArgs e)
        {
            timer1.Start();
            try
            {
                serialPort2.Open();
            }
            catch
            {
                lblPort.Text = "Puerto: No disponible";
                serialPort2.Close();
            }
            finally
            {

            }
            showLabelPort();
            lblPort.Text = serialPort2.PortName;

            con = new System.Data.SqlClient.SqlConnection(); //llamar conexion al form load
            con.ConnectionString = "Data Source=localhost;Initial Catalog=MURK;Integrated Security=True";

            buscarUltimo();
        }
        private void showLabelPort()
        {
            Form1 pu = new Form1();

            lblPort.Text = pu.lbPort.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            timer1.Stop();
            serialPort2.Close();
        }
        public void validaSiExiste()
        {
            validaSiExisteArticulo();
            try
            {
                con.Open();
                SqlCommand consulta = con.CreateCommand();//crea comando
                consulta.CommandType = CommandType.Text;
                consulta.CommandText = string.Format("SELECT * FROM Usuarios WHERE Rfid = '" + txtRFID.Text+ "'");
                SqlDataReader busqueda;
                busqueda = consulta.ExecuteReader();
                while (busqueda.Read() == true)
                {
                 

                    MessageBox.Show("Esta tarjeta esta asignada a otro usuario, Ingrese otra", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

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
        public void validaSiExisteArticulo()
        {
            try
            {
                con.Open();
                SqlCommand consulta = con.CreateCommand();//crea comando
                consulta.CommandType = CommandType.Text;
                consulta.CommandText = string.Format("SELECT * FROM Articulo_rfid WHERE Rfid = '" + txtRFID.Text + "'");
                SqlDataReader busqueda;
                busqueda = consulta.ExecuteReader();
                while (busqueda.Read() == true)
                {


                    MessageBox.Show("Esta tarjeta esta asignada a un Artículo, Ingrese otra", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

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
        private void txtRFID_TextChanged(object sender, EventArgs e)
        {
            validaSiExiste();
           
            try
            {
                con.Open();
                SqlCommand query = con.CreateCommand();//crea comando
                query.CommandType = CommandType.Text;
                //rfid, id_persona id_tipo
                query.CommandText = string.Format("EXEC ALTA_USUARIO '" + txtRFID.Text + "','" + idUser.Text + "','" + textBoxp.Text + "'");
                int result = query.ExecuteNonQuery();//Regresa valor binario si se ejecuta o no la consulta
                if (result > 0)
                {

                    MessageBox.Show("La tarjeta RFID fue asignada correctamente");
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("No se pudo almacenar el registro");
                }
            }
            catch
            {

               // MessageBox.Show("Error-catch");
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                    // this.Close();
                }
            }
        }
    }
}
