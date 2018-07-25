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

        private void AbrirGridInPanel(object FormHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirGridInPanel(new GridUsuarios());
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
            AbrirGridInPanel(new GridProductos());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirGridInPanel(new GridInventario());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirGridInPanel(new GridProveedores());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirGridInPanel(new GridEntradas());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirGridInPanel(new Configuraciones());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirGridInPanel(new GridPrestamos());
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
