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
    public partial class GridPrestamos : Form
    {
        string port, user;
        public GridPrestamos(string p, string u)
        {
            InitializeComponent();
            port = p;
            user = u;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Instacia del nuevo formulario a abrir
            FormPrestamo FP = new FormPrestamo();
            //Envio del usuario y puerto al siguiente form
            FP.Puerto.Text = port;
            FP.Usuario.Text = user;
            //Abrir siguiente form
            FP.ShowDialog();
        }
    }
}
