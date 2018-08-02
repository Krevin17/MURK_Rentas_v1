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
    public partial class GridEntradas : Form
    {
        public GridEntradas()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormEntradas FE = new FormEntradas();
            FE.ShowDialog();
        }
    }
}
