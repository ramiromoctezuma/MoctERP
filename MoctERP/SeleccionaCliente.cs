using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoctERP
{
    public partial class SeleccionaCliente : Form
    {
        public SeleccionaCliente()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {

                int rc = dgvDatosC.CurrentCell.RowIndex;  //Obtener el indice de la fila
                int ID = Convert.ToInt32(dgvDatosC[0, rc].Value.ToString());
                //MessageBox.Show("Current Row Index is = " + rc.ToString());
                cFunciones.IdCliente = ID;
                cFunciones.BanderaCliente = 1;
                frmVentas principal = new frmVentas();

                principal.MdiParent = this.MdiParent;

                principal.Show();
                this.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //throw;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeleccionaCliente_Load(object sender, EventArgs e)
        {
            cConsultasGenerales ObjCGeneral = new cConsultasGenerales();
            DataSet ds = new DataSet();

            ds = ObjCGeneral.ConsultaT2("Cliente");
            dgvDatosC.DataSource = ds.Tables[0];
        }

        private void dgvDatosC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int rc = dgvDatosC.CurrentCell.RowIndex;  //Obtener el indice de la fila
                int ID = Convert.ToInt32(dgvDatosC[0, rc].Value.ToString());
                //MessageBox.Show("Current Row Index is = " + rc.ToString());
                cFunciones.IdCliente = ID;
                cFunciones.BanderaCliente = 1;
                frmVentas principal = new frmVentas();

                principal.MdiParent = this.MdiParent;

                principal.Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //throw;
            }
        }
    }
}
