using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MoctERP
{
    public partial class frmProveedores : Form
    {

        // >>> Quitar bordes, redondear y mover la ventana sin borde
        #region
        //DLL para REDONDEAR VENTANA
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        //Función para REDONDEAR VENTANA
        private static extern IntPtr CreateRoundRectRgn
        (
             int nLeftRect, // x-coordinate of upper-left corner
             int nTopRect, // y-coordinate of upper-left corner
             int nRightRect, // x-coordinate of lower-right corner
             int nBottomRect, // y-coordinate of lower-right corner
             int nWidthEllipse, // height of ellipse
             int nHeightEllipse // width of ellipse
         );

        // **** MOVER VENTANA
        const int WM_SYSCOMMAND = 0x112;
        const int MOUSE_MOVE = 0xF012;

        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void moverForm()
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0);
        }

        // **** MOVER VENTANA
        #endregion

        private static frmProveedores frmInstance = null;

        public static frmProveedores Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmProveedores();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        int banderaProveedor = 0;

        public frmProveedores()
        {
            InitializeComponent();

            // >>> Quitar bordes, redondear y mover la ventana sin borde
            #region
            //Mover ventana
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmProveedores_MouseMove);
            this.lblTituloG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmProveedores_MouseMove);
            this.pbxLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxLogo_MouseMove);
            this.lblTituloG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTituloG_MouseMove);

            //Quitar bordes a la Forma
            this.FormBorderStyle = FormBorderStyle.None;
            //Dibujar bordes redondos
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            #endregion  
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            cConsultasGenerales ObjCGeneral = new cConsultasGenerales();
            DataSet ds = new DataSet();

            ds = ObjCGeneral.ConsultaT2("Proveedor");
            dgvDatosC.DataSource = ds.Tables[0];
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                pnlDProveedor.Visible = true;
                pnlDProveedorGrid.Visible = false;

                InabilitaBotones();

                btnEliminarP.Visible = false;
                btnAgregar.Visible = false;
                btnCancelar.Visible = true;
                btnAplicarM.Visible = true;


                int rc = dgvDatosC.CurrentCell.RowIndex;  //Obtener el indice de la fila
                int ID = Convert.ToInt32(dgvDatosC[0, rc].Value.ToString());
                cProveedores objProvedor = new cProveedores();

                cFunciones.IdProveedor = ID;
                objProvedor.ConsultaUno("Proveedor");

                banderaProveedor = Convert.ToInt32(objProvedor.Idproveedor .ToString());
                txtRFC.Text = objProvedor.RFC.ToString();
                txtNombre.Text = objProvedor.NombreProveedor.ToString();
                txtCP.Text = objProvedor.CP.ToString();
                txtCalle.Text = objProvedor.Calle.ToString();
                txtNoExt.Text = objProvedor.NumeroExt.ToString();
                txtNoInt.Text = objProvedor.NumeroInt.ToString();
                char ConCredito = Convert.ToChar(objProvedor.ConCredito.ToString());

                if (ConCredito == 'S')
                    chkCredito.Checked = true;
                else
                    chkCredito.Checked = false;


                txtDiasCredito.Text = objProvedor.DiasCredito.ToString();
                txtLimiteCredito.Text = objProvedor.LimteCredito.ToString();
                txtSaldo.Text = objProvedor.Saldo.ToString();
                txtEMail.Text = objProvedor.Email.ToString();
                cFunciones.IdTelefono = Convert.ToInt32(objProvedor.IdTelefono.ToString());

                txtTelefono1.Text = objProvedor.Telefono1.ToString();
                txtTelefono2.Text = objProvedor.Telefono2.ToString();
                txtTelefono3.Text = objProvedor.Telefono3.ToString();
                txtTelefono4.Text = objProvedor.Telefono4.ToString();

                DataSet dsCP = new DataSet();
                dsCP = cFunciones.ConsultaCP();

                DataRow DR = dsCP.Tables[0].Rows[0];
                txtCP.Text = DR["CP"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //throw;
            }
        }

        private void btnAplicarM_Click(object sender, EventArgs e)
        {
            //Validación de campos
            #region
            if (txtRFC.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de especificar el RFC", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRFC.Focus();
                return;
            }

            if (txtNombre.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de especificar el Nombre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (txtCP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de especificar el CP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCP.Focus();
                return;
            }

            if (txtCalle.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de especificar la Calle", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCalle.Focus();
                return;
            }

            if (txtNoExt.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de especificar el Número Exterior", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoExt.Focus();
                return;
            }

            if (txtNoInt.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de especificar el Número Exterior", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoInt.Focus();
                return;
            }

            if (txtDiasCredito.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de especificar los días de crédito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiasCredito.Focus();
                return;
            }

            if (txtLimiteCredito.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de especificar el Limite de Crédito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLimiteCredito.Focus();
                return;
            }

            if (txtSaldo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de especificar el Saldo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSaldo.Focus();
                return;
            }

            if (txtEMail.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de especificar el EMail", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEMail.Focus();
                return;
            }

            if (txtTelefono1.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de especificar el Telefono 1.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono1.Focus();
                return;
            }

            if (txtTelefono2.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de especificar el Telefono 2.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono2.Focus();
                return;
            }

            if (txtTelefono3.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de especificar el Telefono 3.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono3.Focus();
                return;
            }

            if (txtTelefono4.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de especificar el Telefono 4.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono4.Focus();
                return;
            }

            if (cboColonia.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Favor de validar el CP.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCP.Focus();
                return;
            }

            if ((chkCredito.Checked == true) && (Convert.ToInt32(txtDiasCredito.Text.ToString()) == 0))
            {
                MessageBox.Show("Favor de especificar los días de crédito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCP.Focus();
                return;
            }

            #endregion

            cProveedores objProveedor = new cProveedores();

            objProveedor.RFC = txtRFC.Text;
            objProveedor.NombreProveedor = txtNombre.Text;
            objProveedor.Calle = txtCalle.Text;
            objProveedor.NumeroExt = txtNoExt.Text;
            objProveedor.NumeroInt = txtNoInt.Text;
            objProveedor.CP = Convert.ToInt32(txtCP.Text);
            objProveedor.DiasCredito = Convert.ToInt32(txtDiasCredito.Text);
            objProveedor.LimteCredito = Convert.ToDouble(txtLimiteCredito.Text);
            objProveedor.Saldo = Convert.ToDouble(txtSaldo.Text);
            objProveedor.Email = txtEMail.Text;
            objProveedor.Telefono1 = txtTelefono1.Text;
            objProveedor.Telefono2 = txtTelefono2.Text;
            objProveedor.Telefono3 = txtTelefono3.Text;
            objProveedor.Telefono4 = txtTelefono4.Text;
            objProveedor.Estatus = "A";

            string Colonia = cboColonia.SelectedValue.ToString();
            string Ciudad = cboCiudad.SelectedValue.ToString();
            string Estado = cboEstado.SelectedValue.ToString();
            string Pais = cboPais.SelectedValue.ToString();

            cFunciones.IdColonia = Convert.ToInt32(Colonia);
            cFunciones.IdCiudad = Convert.ToInt32(Ciudad);
            cFunciones.IdEstado = Convert.ToInt32(Estado);
            cFunciones.IdPais = Convert.ToInt32(Pais);
            cFunciones.IdCliente = banderaProveedor;


            if (chkCredito.Checked == true)
            {
                objProveedor.ConCredito = "S";
            }
            else
            {
                objProveedor.ConCredito = "N";
            }

            int actualizados = 0;
            actualizados = objProveedor.ModificaProveedor();
            if (actualizados > 0)
                MessageBox.Show("Se modificó el cliente correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            pnlDProveedor.Visible = false;
            pnlDProveedorGrid.Visible = true;
            btnNuevo.Enabled = true;
            GUIDefault();
            HabilitaBotones();

            cConsultasGenerales ObjCGeneral = new cConsultasGenerales();
            DataSet ds = new DataSet();

            ds = ObjCGeneral.ConsultaT2("Proveedor");
            dgvDatosC.DataSource = ds.Tables[0];
            txtBusqueda.Text = "";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            try
            {

                pnlDProveedor.Visible = true;
                pnlDProveedorGrid.Visible = false;

                btnConsultar.Enabled = false;

                btnEliminarP.Visible = false;
                btnCancelar.Visible = true;
                btnAgregar.Visible = false;
                btnAplicarM.Visible = false;
                btnValidar.Visible = false;

                ReadOnly();
                InabilitaBotones();

                int rc = dgvDatosC.CurrentCell.RowIndex;  //Obtener el indice de la fila
                int ID = Convert.ToInt32(dgvDatosC[0, rc].Value.ToString());
                //MessageBox.Show("Current Row Index is = " + rc.ToString());
                cProveedores objProveedor = new cProveedores();

                cFunciones.IdProveedor = ID;
                objProveedor.ConsultaUno("Proveedor");

                txtRFC.Text = objProveedor.RFC.ToString();
                txtNombre.Text = objProveedor.NombreProveedor.ToString();
                txtCP.Text = objProveedor.CP.ToString();
                txtCalle.Text = objProveedor.Calle.ToString();
                txtNoExt.Text = objProveedor.NumeroExt.ToString();
                txtNoInt.Text = objProveedor.NumeroInt.ToString();
                char ConCredito = Convert.ToChar(objProveedor.ConCredito.ToString());

                if (ConCredito == 'S')
                    chkCredito.Checked = true;
                else
                    chkCredito.Checked = false;

                txtDiasCredito.Text = objProveedor.DiasCredito.ToString();
                txtLimiteCredito.Text = objProveedor.LimteCredito.ToString();
                txtSaldo.Text = objProveedor.Saldo.ToString();
                txtEMail.Text = objProveedor.Email.ToString();
                txtTelefono1.Text = objProveedor.Telefono1.ToString();
                txtTelefono2.Text = objProveedor.Telefono2.ToString();
                txtTelefono3.Text = objProveedor.Telefono3.ToString();
                txtTelefono4.Text = objProveedor.Telefono4.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //throw;
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            pnlDProveedor.Visible = true;
            pnlDProveedorGrid.Visible = false;

            InabilitaBotones();

            btnAplicarM.Visible = false;
            btnEliminarP.Visible = false;
            btnAgregar.Visible = true;
            btnCancelar.Visible = true;
            txtRFC.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            //Validación de campos
            #region
            if (txtRFC.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de especificar el RFC", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRFC.Focus();
                return;
            }

            if (txtNombre.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de especificar el Nombre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (txtCP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de especificar el CP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCP.Focus();
                return;
            }

            if (txtCalle.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de especificar la Calle", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCalle.Focus();
                return;
            }

            if (txtNoExt.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de especificar el Número Exterior", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoExt.Focus();
                return;
            }

            if (txtNoInt.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de especificar el Número Exterior", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoInt.Focus();
                return;
            }

            if (txtDiasCredito.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de especificar los días de crédito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiasCredito.Focus();
                return;
            }

            if (txtLimiteCredito.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de especificar el Limite de Crédito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLimiteCredito.Focus();
                return;
            }

            if (txtSaldo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de especificar el Saldo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSaldo.Focus();
                return;
            }

            if (txtEMail.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de especificar el EMail", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEMail.Focus();
                return;
            }

            if (txtTelefono1.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de especificar el Telefono 1.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono1.Focus();
                return;
            }

            if (txtTelefono2.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de especificar el Telefono 2.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono2.Focus();
                return;
            }

            if (txtTelefono3.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de especificar el Telefono 3.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono3.Focus();
                return;
            }

            if (txtTelefono4.Text.Trim().Equals(""))
            {
                MessageBox.Show("Favor de especificar el Telefono 4.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono4.Focus();
                return;
            }

            if (cboColonia.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Favor de validar el CP.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCP.Focus();
                return;
            }

            if ((chkCredito.Checked == true) && (Convert.ToInt32(txtDiasCredito.Text.ToString()) == 0))
            {
                MessageBox.Show("Favor de especificar los días de crédito.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCP.Focus();
                return;
            }

            #endregion

            cProveedores objProvedor = new cProveedores();

            objProvedor.RFC = txtRFC.Text;
            objProvedor.NombreProveedor = txtNombre.Text;
            objProvedor.Calle = txtCalle.Text;
            objProvedor.NumeroExt = txtCalle.Text;
            objProvedor.NumeroInt = txtNoInt.Text;
            objProvedor.CP = Convert.ToInt32(txtCP.Text);
            objProvedor.DiasCredito = Convert.ToInt32(txtDiasCredito.Text);
            objProvedor.LimteCredito = Convert.ToDouble(txtLimiteCredito.Text);
            objProvedor.Saldo = Convert.ToDouble(txtSaldo.Text);
            objProvedor.Email = txtEMail.Text;
            objProvedor.Telefono1 = txtTelefono1.Text;
            objProvedor.Telefono2 = txtTelefono2.Text;
            objProvedor.Telefono3 = txtTelefono3.Text;
            objProvedor.Telefono4 = txtTelefono4.Text;
            objProvedor.Estatus = "A";

            string Colonia = cboColonia.SelectedValue.ToString();
            string Ciudad = cboCiudad.SelectedValue.ToString();
            string Estado = cboEstado.SelectedValue.ToString();
            string Pais = cboPais.SelectedValue.ToString();

            cFunciones.IdColonia = Convert.ToInt32(Colonia);
            cFunciones.IdCiudad = Convert.ToInt32(Ciudad);
            cFunciones.IdEstado = Convert.ToInt32(Estado);
            cFunciones.IdPais = Convert.ToInt32(Pais);


            if (chkCredito.Checked == true)
            {
                objProvedor.ConCredito = "S";
            }
            else
            {
                objProvedor.ConCredito = "N";
            }

            int actualizados = 0;
            actualizados = objProvedor.InsertaProveedor();
            if (actualizados > 0)
                MessageBox.Show("Se registró el proveedor correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cConsultasGenerales ObjCGeneral = new cConsultasGenerales();
            DataSet ds = new DataSet();

            ds = ObjCGeneral.ConsultaT2("Proveedor");
            dgvDatosC.DataSource = ds.Tables[0];
            txtBusqueda.Text = "";

            pnlDProveedor.Visible = false;
            pnlDProveedorGrid.Visible = true;
            btnNuevo.Enabled = true;
            GUIDefault();
            HabilitaBotones();

        }

        private void InabilitaBotones()
        {
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnConsultar.Enabled = false;
        }

        private void HabilitaBotones()
        {
            btnNuevo.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnConsultar.Enabled = true;
        }

        private void GUIDefault()
        {
            pnlDProveedor.Visible = false;
            pnlDProveedorGrid.Visible = true;

            btnNuevo.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnConsultar.Enabled = true;

            btnAgregar.Visible = true;
            btnAplicarM.Visible = true;
            btnCancelar.Visible = true;
            btnEliminarP.Visible = true;

            cboColonia.DataSource = null;
            cboCiudad.DataSource = null;
            cboEstado.DataSource = null;
            cboPais.DataSource = null;


            txtRFC.Text = "";
            txtNombre.Text = "";
            txtCP.Text = "";
            txtCalle.Text = "";
            txtNoExt.Text = "";
            txtNoInt.Text = "";
            chkCredito.Checked = false;
            txtDiasCredito.Text = "";
            txtLimiteCredito.Text = "";
            txtSaldo.Text = "";
            txtEMail.Text = "";
            txtTelefono1.Text = "";
            txtTelefono2.Text = "";
            txtTelefono3.Text = "";
            txtTelefono4.Text = "";
            txtCalle.ReadOnly = false;
            txtRFC.ReadOnly = false;
            txtNombre.ReadOnly = false;
            txtCP.ReadOnly = false;
            txtCalle.ReadOnly = false;
            txtNoExt.ReadOnly = false;
            txtNoInt.ReadOnly = false;
            chkCredito.Enabled = true;
            txtDiasCredito.ReadOnly = false;
            txtLimiteCredito.ReadOnly = false;
            txtSaldo.ReadOnly = false;
            txtEMail.ReadOnly = false;
            txtTelefono1.ReadOnly = false;
            txtTelefono2.ReadOnly = false;
            txtTelefono3.ReadOnly = false;
            txtTelefono4.ReadOnly = false;
        }

        private void ReadOnly()
        {
            txtCalle.ReadOnly = true;
            txtRFC.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtCP.ReadOnly = true;
            txtCalle.ReadOnly = true;
            txtNoExt.ReadOnly = true;
            txtNoInt.ReadOnly = true;
            chkCredito.Enabled = false;
            txtDiasCredito.ReadOnly = true;
            txtLimiteCredito.ReadOnly = true;
            txtSaldo.ReadOnly = true;
            txtEMail.ReadOnly = true;
            txtTelefono1.ReadOnly = true;
            txtTelefono2.ReadOnly = true;
            txtTelefono3.ReadOnly = true;
            txtTelefono4.ReadOnly = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            pnlDProveedor.Visible = true;
            pnlDProveedorGrid.Visible = false;

            InabilitaBotones();

            btnCancelar.Visible = true;
            btnAgregar.Visible = false;
            btnAplicarM.Visible = false;

            ReadOnly();

            int rc = dgvDatosC.CurrentCell.RowIndex;  //Obtener el indice de la fila
            int ID = Convert.ToInt32(dgvDatosC[0, rc].Value.ToString());
            //MessageBox.Show("Current Row Index is = " + rc.ToString());
            cProveedores objProveedor = new cProveedores();

            objProveedor.Idproveedor = ID;
            objProveedor.ConsultaUno("Proveedor");

            txtRFC.Text = objProveedor.RFC.ToString();
            txtNombre.Text = objProveedor.NombreProveedor.ToString();
            txtCP.Text = objProveedor.CP.ToString();
            txtCalle.Text = objProveedor.Calle.ToString();
            txtNoExt.Text = objProveedor.NumeroExt.ToString();
            txtNoInt.Text = objProveedor.NumeroInt.ToString();
            char ConCredito = Convert.ToChar(objProveedor.ConCredito.ToString());

            if (ConCredito == 'S')
                chkCredito.Checked = true;
            else
                chkCredito.Checked = false;

            txtDiasCredito.Text = objProveedor.DiasCredito.ToString();
            txtLimiteCredito.Text = objProveedor.LimteCredito.ToString();
            txtSaldo.Text = objProveedor.Saldo.ToString();
            txtEMail.Text = objProveedor.Email.ToString();
            txtTelefono1.Text = objProveedor.Telefono1.ToString();
            txtTelefono2.Text = objProveedor.Telefono2.ToString();
            txtTelefono3.Text = objProveedor.Telefono3.ToString();
            txtTelefono4.Text = objProveedor.Telefono4.ToString();

        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("¿Deseas dar de baja el Proveedor?",
                      "Atención", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    int rc = dgvDatosC.CurrentCell.RowIndex;  //Obtener el indice de la fila
                    int ID = Convert.ToInt32(dgvDatosC[0, rc].Value.ToString());
                    cProveedores objProveedor = new cProveedores();

                    objProveedor.Idproveedor = ID;
                    int actualizados = 0;
                    actualizados = objProveedor.EliminaProveedor("Proveedor");

                    if (actualizados > 0)
                        MessageBox.Show("proveedor dado de baja correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GUIDefault();
                    cConsultasGenerales ObjCGeneral = new cConsultasGenerales();
                    DataSet ds = new DataSet();

                    ds = ObjCGeneral.ConsultaT2("proveedor");
                    dgvDatosC.DataSource = ds.Tables[0];
                    txtBusqueda.Text = "";
                    break;
                case DialogResult.No:
                    break;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlDProveedor.Visible = false;
            pnlDProveedorGrid.Visible = true;

            btnConsultar.Enabled = true;
            btnAgregar.Visible = true;
            btnCancelar.Visible = false;
            btnAplicarM.Visible = false;
            btnValidar.Visible = true;

            btnNuevo.Enabled = true;

            GUIDefault();
        }

        private void cmdValidar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dsCol = new DataSet();

                dsCol = cFunciones.ConsultaColonia(Convert.ToInt32(txtCP.Text));
                cboColonia.DataSource = dsCol.Tables[0];
                cboColonia.DisplayMember = "Colonia";
                cboColonia.ValueMember = "IdColonia";
                //cboColonia.SelectedIndex = -1;


                DataSet dsCiu = new DataSet();

                dsCiu = cFunciones.ConsultaCiudad(Convert.ToInt32(txtCP.Text));
                cboCiudad.DataSource = dsCiu.Tables[0];
                cboCiudad.DisplayMember = "Ciudad";
                cboCiudad.ValueMember = "IdCiudad";
                //cboColonia.SelectedIndex = -1;


                DataSet dsCli = new DataSet();

                dsCli = cFunciones.ConsultaEstado(Convert.ToInt32(txtCP.Text));
                cboEstado.DataSource = dsCli.Tables[0];
                cboEstado.DisplayMember = "Estado";
                cboEstado.ValueMember = "IdEstado";
                //cboColonia.SelectedIndex = -1;    


                DataSet dsPais = new DataSet();

                dsPais = cFunciones.ConsultaPais(Convert.ToInt32(txtCP.Text));
                cboPais.DataSource = dsPais.Tables[0];
                cboPais.DisplayMember = "Pais";
                cboPais.ValueMember = "IdPais";
                //cboColonia.SelectedIndex = -1; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //throw;
            }

        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {

            cConsultasGenerales ObjCGeneral = new cConsultasGenerales();
            DataSet DS = new DataSet();
            DataSet DS2 = new DataSet();

            DS = ObjCGeneral.ConsultaT("Proveedor", txtBusqueda.Text);
            if (DS.Tables[0].Rows.Count > 0)
            {
                dgvDatosC.DataSource = DS.Tables[0];
            }
            else
                dgvDatosC.DataSource = DS2;

        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxLogo_MouseMove(object sender, MouseEventArgs e)
        {
            moverForm();
        }

        private void lblTituloG_MouseMove(object sender, MouseEventArgs e)
        {
            moverForm();
        }

        private void pnlTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            moverForm();
        }

        private void frmProveedores_MouseMove(object sender, MouseEventArgs e)
        {
            moverForm();
        }

    }
}
