using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//base de datos
using System.Text.RegularExpressions;

namespace MURK_Rentas
{
   
    public partial class FormUsuarios : Form
    {
        bool error = true;

        string port; //Usar esta variable en -> SerialPort1.NamePort = port
        public FormUsuarios(string p)
        {
            InitializeComponent();
            port = p;
        }

        System.Data.SqlClient.SqlConnection con; //variable que lleva al servidor
        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            con = new System.Data.SqlClient.SqlConnection(); //llamar conexion al form load
            con.ConnectionString = "Data Source=localhost;Initial Catalog=MURK;Integrated Security=True";

            if (tituloForm.Text == "Editar Usuario")
            {
                BusquedaEditar();
            }

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
                    labelUltimo.Text = busqueda["Id"].ToString();

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

        private void editarRegistro()
        {
            try
            {
                con.Open();
                SqlCommand query = con.CreateCommand();//crea comando
                query.CommandType = CommandType.Text;
                query.CommandText = string.Format("EXEC MOD_PERSONAS '" + labelUltimo.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox11.Text + "','" + textBox10.Text + "'");
                int result = query.ExecuteNonQuery();//Regresa valor binario si se ejecuta o no la consulta
                if (result > 0)
                {
                    MessageBox.Show("Registro modificado exitosamente");
                   
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
                    this.Close();
                }
                GridUsuarios gu = new GridUsuarios(port);
                gu.refresh();
            }
        }

        private void BusquedaEditar()
        {
            try
            {
                con.Open();
                SqlCommand consulta = con.CreateCommand();//crea comando
                consulta.CommandType = CommandType.Text;
                consulta.CommandText = string.Format("SELECT * FROM Personas WHERE Id = '" + labelUltimo.Text + "'");
                SqlDataReader busqueda;
                busqueda = consulta.ExecuteReader();
                while (busqueda.Read() == true)
                {
                    textBox1.Text = busqueda["Nombre"].ToString();
                    textBox2.Text = busqueda["Apellido_P"].ToString();
                    textBox3.Text = busqueda["Apellido_M"].ToString();
                    dateTimePicker1.Text = busqueda["FechaNacimiento"].ToString();
                    textBox4.Text = busqueda["Direccion"].ToString();
                    textBox5.Text = busqueda["Colonia"].ToString();
                    textBox6.Text = busqueda["Municipio"].ToString();
                    textBox7.Text = busqueda["Estado"].ToString();
                    textBox11.Text = busqueda["Email"].ToString();
                    textBox10.Text = busqueda["Telefono"].ToString();



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
        private Boolean expresionEmail(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private bool validarUsuario()
        {
            if (expresionEmail(textBox11.Text) == false)
            {
                errorProvider1.SetError(textBox11, "Ingresar correo electronico valido.");

                return false;
            }
            else if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider1.SetError(textBox1, "Campo requerido");
                errorProvider1.SetError(textBox2, "Campo requerido");
                errorProvider1.SetError(textBox3, "Campo requerido");
                errorProvider1.SetError(textBox4, "Campo requerido");
                errorProvider1.SetError(textBox5, "Campo requerido");
                errorProvider1.SetError(textBox6, "Campo requerido");
                errorProvider1.SetError(textBox7, "Campo requerido");
                errorProvider1.SetError(textBox10, "Campo requerido");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                error = false;
                return true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (validarUsuario() == true)
            {
                if (tituloForm.Text == "Editar Usuario")
                {
                    editarRegistro();
                }
                else
                {
                    try
                    {
                        con.Open();
                        SqlCommand query = con.CreateCommand();//crea comando
                        query.CommandType = CommandType.Text;
                        query.CommandText = string.Format("EXEC ALTA_PERSONA'" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox11.Text + "','" + textBox10.Text + "'");
                        int result = query.ExecuteNonQuery();//Regresa valor binario si se ejecuta o no la consulta
                        if (result > 0)
                        {
                            MessageBox.Show("Registro almacenado exitosamente ");
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

                        buscarUltimo();

                        this.Close();

                        if (MessageBox.Show("Desea asignar una Tarjeta RFID a este usuario?", "MURK - Registro Usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {

                            Alta_RFID ar = new Alta_RFID();
                            ar.lblName.Text = "Asignar Tarjeta RFID a Usuario";
                            this.Hide();
                            ar.ShowDialog();

                            timer1.Stop();
                        }
                        else
                        {
                            this.Close();
                        }

                    }
                }
            }
        }
    }
    }

