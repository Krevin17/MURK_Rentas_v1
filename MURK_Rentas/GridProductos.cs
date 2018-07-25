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
    public partial class GridProductos : Form
    {
        System.Data.SqlClient.SqlConnection con; //variable que lleva al servidor
        public GridProductos()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormArticulos FA = new FormArticulos();
            FA.ShowDialog();
        }

        private void GridProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mURKDataSet.V_ARTICULOS' Puede moverla o quitarla según sea necesario.
            this.v_ARTICULOSTableAdapter.Fill(this.mURKDataSet.V_ARTICULOS);
            con = new System.Data.SqlClient.SqlConnection(); //llamar conexion al form load
            con.ConnectionString = "Data Source=localhost;Initial Catalog=MURK;Integrated Security=True";

        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            this.v_ARTICULOSTableAdapter.Fill(this.mURKDataSet.V_ARTICULOS);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string ID_articulo = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            if(MessageBox.Show("Desea editar el producto ", "MURK - Editar Producto", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormArticulos FA = new FormArticulos();
                FA.lbID.Text = ID_articulo;
                FA.tituloForm.Text = "Editar Articulo";
                FA.ShowDialog();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string ID_articulo = dataGridView2.CurrentRow.Cells[0].Value.ToString();

            try
            {
                con.Open();
                SqlCommand query = con.CreateCommand();//crea comando
                query.CommandType = CommandType.Text;
                query.CommandText = string.Format("EXEC ELIMINAR_ARTICULO '" + ID_articulo + "'");
                int result = query.ExecuteNonQuery();//Regresa valor binario si se ejecuta o no la consulta
                if (result > 0)
                {
                    MessageBox.Show("Registro eliminado exitosamente");
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el registro");
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
                    this.v_ARTICULOSTableAdapter.Fill(this.mURKDataSet.V_ARTICULOS);
                }
            }
        }
    }
}
