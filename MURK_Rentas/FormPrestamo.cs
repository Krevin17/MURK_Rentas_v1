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
    public partial class FormPrestamo : Form
    {
        System.Data.SqlClient.SqlConnection con;
        string rfid;
        string rUsuario, rAutorizadcion, rArticulo;
        int valido,step=1;


        public FormPrestamo()
        {
            InitializeComponent();
        }

        private void FormPrestamo_Load(object sender, EventArgs e)
        {
            serialPort1.PortName = Puerto.Text;
            serialPort1.Open();
            timer1.Start();
            con = new System.Data.SqlClient.SqlConnection();
            con.ConnectionString = "Data Source=localhost;Initial Catalog=MURK;Integrated Security=True";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            rfid = serialPort1.ReadLine().Trim();
        }

        private void buscarRfid(string rfid)
        {
            try
            {
                con.Open();
                SqlCommand query = con.CreateCommand();
                query.CommandType = CommandType.Text;
                if(step==1)
                {
                    query.CommandText = string.Format("EXEC BUSCAR_PERSONA_PRESTAMO '" + rfid + "'");
                    SqlDataReader busqueda;
                    busqueda = query.ExecuteReader();
                    while (busqueda.Read() == true)
                    {
                        lbNombre.Text = busqueda["Nombre"].ToString();
                        valido = 1;
                    }
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

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbRfid.Text = rfid;
        }

        private void lbRfid_TextChanged(object sender, EventArgs e)
        {
            valido = 0;
            buscarRfid(lbRfid.Text);
            if (valido == 1)
                btnListo.Visible = true;
            else
                btnListo.Visible = false;
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            switch (step)
            {
                case 1:
                    //El nombre al panel de datos de prestamo
                    lbUsuario.Text = lbNombre.Text;
                    lbNombre.Text = "";
                    lbRfid.Text = "";
                    btnListo.Visible = false;
                    step++;
                    break;
                case 2:
                    btnListo.Visible = false;
                    break;
                default:
                    break;
            }
        }
    }
}
