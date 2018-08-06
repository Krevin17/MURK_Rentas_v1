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
        string rUsuario, rAutorizacion;
        int valido,step = 1, n_articulo = 0;
        double importe, precioArticulo;

        string[] infoArt = new string[6];
        List<string> Rfids_Articulos = new List<string>();

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
            timer1.Stop();
            serialPort1.Close();
            this.Close();
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
                //Consulta sobre tarjetas de personas
                if (step == 1)
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
                //Consulta sobre tarjetas de articulos
                else if (step == 2)
                {
                    query.CommandText = string.Format("EXEC BUSCAR_ARTICULO_PRESTAMO '" + rfid + "'");
                    SqlDataReader busqueda;
                    busqueda = query.ExecuteReader();
                    while (busqueda.Read() == true)
                    {
                        lbNombre.Text = busqueda["Nombre"].ToString();
                        valido = 1;

                        infoArt[0] = busqueda["Nombre"].ToString();
                        infoArt[1] = busqueda["Descripcion"].ToString();
                        infoArt[2] = busqueda["Categoria"].ToString();
                        infoArt[3] = busqueda["Precio_renta"].ToString();
                        infoArt[4] = busqueda["Stock"].ToString();
                        infoArt[5] = busqueda["Disponible"].ToString();
                    }
                }
                else if (step == 3)
                {

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

        bool EncontrarObjRfid(string rfidDeseado)
        {
            for (int i = 0; i < Rfids_Articulos.Count; i++)
            {
                if (Rfids_Articulos[i] == rfidDeseado)
                {
                    return true;
                }
            }
            return false;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lbRfid.Text = rfid;
        }

        private void lbRfid_TextChanged(object sender, EventArgs e)
        {
            validaConsulta();
        }

        public void validaConsulta()
        {
            //Regresar valido a 0 para ocultar el btnListo si la consulta regreso vacia
            valido = 0;
            buscarRfid(lbRfid.Text);

            if (valido == 1)
            {
                btnListo.Visible = true;
            }
            else
            {
                //si la consulta viene vacia limpiar campos y desactivar los campos
                btnListo.Visible = false;
                lbNombre.Text = "";
                lbRfid.Text = "";
            }
        }

        private void limpiarLb()
        {
            lbNombre.Text = "";
            lbRfid.Text = "";
            btnListo.Visible = false;
        }

        private void calcularCosto()
        {
            importe = importe + precioArticulo;
            lbCosto.Text = importe.ToString();
        }
            

        private void btnListo_Click(object sender, EventArgs e)
        {
            switch (step)
            {
                case 1:
                    //El nombre al panel de datos de prestamo
                    lbUsuario.Text = lbNombre.Text;
                    rUsuario = rfid;
                    rfid = "";
                    //btnListo.Text = "Añadir";
                    step=2;
                    break;
                case 2:
                    n_articulo++;
                    //Valida que el artiulo no se este en el 
                    if (EncontrarObjRfid(rfid) == true)
                    {
                        MessageBox.Show("Dato en el Grid");
                    }
                    else
                    {
                        //Anadir rfid de la tarjeta a la lista 
                        Rfids_Articulos.Add(rfid);
                        dataGridView2.Rows.Add(n_articulo, rfid, infoArt[0], infoArt[1], infoArt[2], infoArt[3]);
                        precioArticulo = Convert.ToDouble(infoArt[3]);
                        calcularCosto();
                    }                    
                    break;
                default:
                    break;
            }
            limpiarLb();
        }
    }
}
