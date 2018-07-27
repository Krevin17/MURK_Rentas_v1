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
    public partial class GridInventario : Form
    {
        public GridInventario()
        {
            InitializeComponent();
        }

        private void GridInventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mURKDataSet.V_INVENTARIO' Puede moverla o quitarla según sea necesario.
            this.v_INVENTARIOTableAdapter.Fill(this.mURKDataSet.V_INVENTARIO);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
