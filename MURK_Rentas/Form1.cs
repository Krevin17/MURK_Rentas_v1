using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MURK_Rentas
{
    public partial class Form1 : Form
    {
        string rfid_usurio = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            if (MessageBox.Show("Desea cerrar la aplicación", "MURK - Inicio de sesión", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Abre modal de configuracion del puerto com para la utilzacion del arduino
            serialPort1.Close();
            Puertos set_port = new Puertos();
            this.Hide();
            set_port.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.lbPort_menu.Text = lbPort.Text;
            menu.lbRFID_menu.Text = rfid_usurio;
            this.Hide();
            menu.ShowDialog();
            this.Close();          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbPort.Text = serialPort1.PortName;
            
            try
            {              
                serialPort1.Open();
            }
            catch
            {
                lbPort.Text = "Puerto: No disponible";
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            rfid_usurio = serialPort1.ReadLine().Trim();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbRFID.Text = rfid_usurio;
        }

        private void lbPort_TextChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = lbPort.Text;
        }
    }
}
