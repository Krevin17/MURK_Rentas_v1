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
    public partial class GridProveedores : Form
    {
        System.Data.SqlClient.SqlConnection con; //variable que lleva al servidor

        public GridProveedores()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormProveedor FPro = new FormProveedor();
            FPro.ShowDialog();
        }

        private void GridProveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mURKDataSet.V_PROVEEDORES' Puede moverla o quitarla según sea necesario.
            this.v_PROVEEDORESTableAdapter.Fill(this.mURKDataSet.V_PROVEEDORES);
            con = new System.Data.SqlClient.SqlConnection(); //llamar conexion al form load
            con.ConnectionString = "Data Source=localhost;Initial Catalog=MURK;Integrated Security=True";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string ID_Proveedor = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Desea editar el proveedor ", "MURK - Editar Proveedor", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormProveedor FP = new FormProveedor();
                FP.lbID.Text = ID_Proveedor;
                FP.tituloForm.Text = "Editar Proveedor";
                FP.ShowDialog();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string ID_Proveedor = dataGridView2.CurrentRow.Cells[0].Value.ToString();

            try
            {
                con.Open();
                SqlCommand query = con.CreateCommand();//crea comando
                query.CommandType = CommandType.Text;
                query.CommandText = string.Format("EXEC ELIMINAR_PROVEEDOR '" + ID_Proveedor + "'");
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
                    this.v_PROVEEDORESTableAdapter.Fill(this.mURKDataSet.V_PROVEEDORES);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.v_PROVEEDORESTableAdapter.Fill(this.mURKDataSet.V_PROVEEDORES);
        }
    }
}
