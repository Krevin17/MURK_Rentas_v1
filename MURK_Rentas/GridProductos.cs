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
    public partial class GridProductos : Form
    {
        public GridProductos()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormArticulos FA = new FormArticulos();
            FA.Show();
        }

        private void GridProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mURKDataSet.V_ARTICULOS' Puede moverla o quitarla según sea necesario.
            this.v_ARTICULOSTableAdapter.Fill(this.mURKDataSet.V_ARTICULOS);

        }
    }
}
