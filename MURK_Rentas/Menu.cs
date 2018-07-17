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
    public partial class Menu : Form
    {
       

        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GridUsuarios us = new GridUsuarios();
            us.MdiParent = this;
            us.Show();
            button1.Enabled = false;
            us.lbPort.Text = lbPort_menu.Text;

        }


        private void btnmenu0_Click(object sender, EventArgs e)
        {
                MenuVertical.Width = 53;
                btnmenu2.Visible = true;
                btnmenu0.Visible = false;
        }

        private void btnmenu2_Click(object sender, EventArgs e)
        {
                MenuVertical.Width = 170;
                btnmenu2.Visible = false;
                btnmenu0.Visible = true;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GridProductos gp = new GridProductos();
            gp.MdiParent = this;
            gp.Show();
            button6.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GridInventario gi = new GridInventario();
            gi.MdiParent = this;
            gi.Show();
            button2.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GridProveedores gpv = new GridProveedores();
            gpv.MdiParent = this;
            gpv.Show();
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GridEntradas ge = new GridEntradas();
            ge.MdiParent = this;
            ge.Show();
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Configuraciones config = new Configuraciones();
            config.MdiParent = this;
            config.Show();
            button5.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GridPrestamos gpres = new GridPrestamos();
            gpres.MdiParent = this;
            gpres.Show();
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lbPort_menu.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
