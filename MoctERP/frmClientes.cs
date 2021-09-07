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
    public partial class frmClientes : Form
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

        int banderaCliente = 0;

        private static frmClientes frmInstance = null;

        public static frmClientes Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmClientes();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        public frmClientes()
        {
            InitializeComponent();

            // >>> Quitar bordes, redondear y mover la ventana sin borde
            #region
            //Mover ventana
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmClientes_MouseMove_1);
            this.lblTituloG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmClientes_MouseMove_1);
            this.pbxLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxLogo_MouseMove);
            this.lblTituloG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTituloG_MouseMove);

            //Quitar bordes a la Forma
            this.FormBorderStyle = FormBorderStyle.None;
            //Dibujar bordes redondos
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            #endregion  
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                cConsultasGenerales ObjCGeneral = new cConsultasGenerales();
                DataSet ds = new DataSet();

                ds = ObjCGeneral.ConsultaT2("Cliente");
                dgvDatosC.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                cFunciones.MessageB(ex);
                //throw;
            }
            

        }
        
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                pnlDCliente.Visible = true;
                pnlDClienteGrid.Visible = false;

                InabilitaBotones();

                btnEliminarC.Visible = false;
                btnAgregar.Visible = false;
                btnCancelar.Visible = true;
                btnAplicarM.Visible = true;


                int rc = dgvDatosC.CurrentCell.RowIndex;  //Obtener el indice de la fila
                int ID = Convert.ToInt32(dgvDatosC[0, rc].Value.ToString());
                cClientes ObjCliente = new cClientes();

                cFunciones.IdCliente = ID;
                ObjCliente.ConsultaUno("Cliente");

                banderaCliente = Convert.ToInt32(ObjCliente.IdCliente.ToString());
                txtRFC.Text = ObjCliente.RFC.ToString();
                txtNombre.Text = ObjCliente.NombreCliente.ToString();
                txtCP.Text = ObjCliente.CP.ToString();
                txtCalle.Text = ObjCliente.Calle.ToString();
                txtNoExt.Text = ObjCliente.NumeroExt.ToString();
                txtNoInt.Text = ObjCliente.NumeroInt.ToString();
                char ConCredito = Convert.ToChar(ObjCliente.ConCredito.ToString());

                if (ConCredito == 'S')
                    chkCredito.Checked = true;
                else
                    chkCredito.Checked = false;


                txtDiasCredito.Text = ObjCliente.DiasCredito.ToString();
                txtLimiteCredito.Text = ObjCliente.LimteCredito.ToString();
                txtSaldo.Text = ObjCliente.Saldo.ToString();
                txtEMail.Text = ObjCliente.Email.ToString();
                cFunciones.IdTelefono = Convert.ToInt32(ObjCliente.IdTelefono.ToString());

                txtTelefono1.Text = ObjCliente.Telefono1.ToString();
                txtTelefono2.Text = ObjCliente.Telefono2.ToString();
                txtTelefono3.Text = ObjCliente.Telefono3.ToString();
                txtTelefono4.Text = ObjCliente.Telefono4.ToString();

                DataSet dsCP = new DataSet();
               dsCP = cFunciones.ConsultaCP();

               DataRow DR = dsCP.Tables[0].Rows[0];
               txtCP.Text = DR["CP"].ToString();

            }
            catch (Exception ex)
            {
                cFunciones.MessageB(ex);
                //throw;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
            try
            {

                pnlDCliente.Visible = true;
                pnlDClienteGrid.Visible = false;

                btnConsultar.Enabled = false;

                btnEliminarC.Visible = false;
                btnCancelar.Visible = true;
                btnAgregar.Visible = false;
                btnAplicarM.Visible = false;
                btnValidar.Visible = false;

                ReadOnly();
                InabilitaBotones();

                int rc = dgvDatosC.CurrentCell.RowIndex;  //Obtener el indice de la fila
                int ID = Convert.ToInt32(dgvDatosC[0, rc].Value.ToString());
                //MessageBox.Show("Current Row Index is = " + rc.ToString());
                cClientes ObjCliente = new cClientes();
                
                cFunciones.IdCliente =ID;
                ObjCliente.ConsultaUno("Cliente");

                txtRFC.Text = ObjCliente.RFC.ToString();
                txtNombre.Text = ObjCliente.NombreCliente.ToString();
                txtCP.Text = ObjCliente.CP.ToString();
                txtCalle.Text = ObjCliente.Calle.ToString();
                txtNoExt.Text = ObjCliente.NumeroExt.ToString();
                txtNoInt.Text = ObjCliente.NumeroInt.ToString();
                char ConCredito = Convert.ToChar(ObjCliente.ConCredito.ToString());

                if (ConCredito == 'S')
                    chkCredito.Checked = true;
                else
                    chkCredito.Checked = false;

                txtDiasCredito.Text = ObjCliente.DiasCredito.ToString();
                txtLimiteCredito.Text = ObjCliente.LimteCredito.ToString();
                txtSaldo.Text = ObjCliente.Saldo.ToString();
                txtEMail.Text = ObjCliente.Email.ToString();
                txtTelefono1.Text = ObjCliente.Telefono1.ToString();
                txtTelefono2.Text = ObjCliente.Telefono2.ToString();
                txtTelefono3.Text = ObjCliente.Telefono3.ToString();
                txtTelefono4.Text = ObjCliente.Telefono4.ToString();


            }
            catch (Exception ex)
            {
                cFunciones.MessageB(ex);
                //throw;
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                pnlDCliente.Visible = true;
                pnlDClienteGrid.Visible = false;

                InabilitaBotones();

                btnAplicarM.Visible = false;
                btnEliminarC.Visible = false;
                btnAgregar.Visible = true;
                btnCancelar.Visible = true;
                txtRFC.Focus();
            }
            catch (Exception ex)
            {
                cFunciones.MessageB(ex);
                //throw;
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
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

                cClientes objCliente = new cClientes();

                objCliente.RFC = txtRFC.Text;
                objCliente.NombreCliente = txtNombre.Text;
                objCliente.Calle = txtCalle.Text;
                objCliente.NumeroExt = txtCalle.Text;
                objCliente.NumeroInt = txtNoInt.Text;
                objCliente.CP = Convert.ToInt32(txtCP.Text);
                objCliente.DiasCredito = Convert.ToInt32(txtDiasCredito.Text);
                objCliente.LimteCredito = Convert.ToDouble(txtLimiteCredito.Text);
                objCliente.Saldo = Convert.ToDouble(txtSaldo.Text);
                objCliente.Email = txtEMail.Text;
                objCliente.Telefono1 = txtTelefono1.Text;
                objCliente.Telefono2 = txtTelefono2.Text;
                objCliente.Telefono3 = txtTelefono3.Text;
                objCliente.Telefono4 = txtTelefono4.Text;
                objCliente.Estatus = "A";

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
                    objCliente.ConCredito = "S";
                }
                else
                {
                    objCliente.ConCredito = "N";
                }

                int actualizados = 0;
                actualizados = objCliente.InsertaCliente();
                if (actualizados > 0)
                    MessageBox.Show("Se registró el cliente correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cConsultasGenerales ObjCGeneral = new cConsultasGenerales();
                DataSet ds = new DataSet();

                ds = ObjCGeneral.ConsultaT2("Cliente");
                dgvDatosC.DataSource = ds.Tables[0];
                txtBusqueda.Text = "";

                pnlDCliente.Visible = false;
                pnlDClienteGrid.Visible = true;
                btnNuevo.Enabled = true;
                GUIDefault();
                HabilitaBotones();
            }
            catch (Exception ex)
            {
                cFunciones.MessageB(ex);
                //throw;
            }
            

        }

        private void InabilitaBotones()
        {
            try
            {
                btnNuevo.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnConsultar.Enabled = false;
            }
            catch (Exception ex)
            {
                cFunciones.MessageB(ex);
                throw;
            }
            
        }

        private void HabilitaBotones()
        {
            try
            {
                btnNuevo.Enabled = true;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                btnConsultar.Enabled = true;
            }
            catch (Exception ex)
            {
                cFunciones.MessageB(ex);
                //throw;
            }
            
        }

        private void GUIDefault()
        {
            try
            {
                pnlDCliente.Visible = false;
                pnlDClienteGrid.Visible = true;

                btnNuevo.Enabled = true;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                btnConsultar.Enabled = true;

                btnAgregar.Visible = true;
                btnAplicarM.Visible = true;
                btnCancelar.Visible = true;
                btnEliminarC.Visible = true;

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
            catch (Exception ex)
            {
                cFunciones.MessageB(ex);
                //throw;
            }
            
        }

        private void ReadOnly()
        {

            try
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
            catch (Exception ex)
            {
                cFunciones.MessageB(ex);
                throw;
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                pnlDCliente.Visible = true;
                pnlDClienteGrid.Visible = false;

                InabilitaBotones();

                btnCancelar.Visible = true;
                btnAgregar.Visible = false;
                btnAplicarM.Visible = false;

                ReadOnly();

                int rc = dgvDatosC.CurrentCell.RowIndex;  //Obtener el indice de la fila
                int ID = Convert.ToInt32(dgvDatosC[0, rc].Value.ToString());
                //MessageBox.Show("Current Row Index is = " + rc.ToString());
                cClientes ObjCliente = new cClientes();

                ObjCliente.IdCliente = ID;
                ObjCliente.ConsultaUno("Cliente");

                txtRFC.Text = ObjCliente.RFC.ToString();
                txtNombre.Text = ObjCliente.NombreCliente.ToString();
                txtCP.Text = ObjCliente.CP.ToString();
                txtCalle.Text = ObjCliente.Calle.ToString();
                txtNoExt.Text = ObjCliente.NumeroExt.ToString();
                txtNoInt.Text = ObjCliente.NumeroInt.ToString();
                char ConCredito = Convert.ToChar(ObjCliente.ConCredito.ToString());

                if (ConCredito == 'S')
                    chkCredito.Checked = true;
                else
                    chkCredito.Checked = false;

                txtDiasCredito.Text = ObjCliente.DiasCredito.ToString();
                txtLimiteCredito.Text = ObjCliente.LimteCredito.ToString();
                txtSaldo.Text = ObjCliente.Saldo.ToString();
                txtEMail.Text = ObjCliente.Email.ToString();
                txtTelefono1.Text = ObjCliente.Telefono1.ToString();
                txtTelefono2.Text = ObjCliente.Telefono2.ToString();
                txtTelefono3.Text = ObjCliente.Telefono3.ToString();
                txtTelefono4.Text = ObjCliente.Telefono4.ToString();
            }
            catch (Exception ex)
            {
                cFunciones.MessageB(ex);
                //throw;
            }
            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            try
            {
                pnlDCliente.Visible = false;
                pnlDClienteGrid.Visible = true;

                btnConsultar.Enabled = true;
                btnAgregar.Visible = true;
                btnCancelar.Visible = false;
                btnAplicarM.Visible = false;
                btnValidar.Visible = true;

                btnNuevo.Enabled = true;

                GUIDefault();
            }
            catch (Exception ex)
            {
                cFunciones.MessageB(ex);
                //throw;
            }
            
        }

        private void btnEliminarC_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("¿Deseas dar de baja el cliente?",
                      "Atención", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        int rc = dgvDatosC.CurrentCell.RowIndex;  //Obtener el indice de la fila
                        int ID = Convert.ToInt32(dgvDatosC[0, rc].Value.ToString());
                        cClientes ObjCliente = new cClientes();

                        ObjCliente.IdCliente = ID;
                        int actualizados = 0;
                        actualizados = ObjCliente.EliminaCliente("Cliente");

                        if (actualizados > 0)
                            MessageBox.Show("Cliente dado de baja correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        GUIDefault();
                        cConsultasGenerales ObjCGeneral = new cConsultasGenerales();
                        DataSet ds = new DataSet();

                        ds = ObjCGeneral.ConsultaT2("Cliente");
                        dgvDatosC.DataSource = ds.Tables[0];
                        txtBusqueda.Text = "";
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            catch (Exception ex)
            {
                cFunciones.MessageB(ex);
                //throw;
            }
            
            
        }

        private void cmdValidar_Click(object sender, EventArgs e)
        {
            try
            {
                cClientes ObjClientes = new cClientes();
                
                
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
                cFunciones.MessageB(ex);

                //throw;
            }
            


        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                cConsultasGenerales ObjCGeneral = new cConsultasGenerales();
                DataSet DS = new DataSet();
                DataSet DS2 = new DataSet();

                DS = ObjCGeneral.ConsultaT("Cliente", txtBusqueda.Text);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    dgvDatosC.DataSource = DS.Tables[0];
                }
                else
                    dgvDatosC.DataSource = DS2;
            }
            catch (Exception ex)
            {
                cFunciones.MessageB(ex);
                //throw;
            }
            

        }

        private void frmClientes_MouseMove_1(object sender, MouseEventArgs e)
        {
         
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                moverForm();
            }
            catch (Exception ex)
            {
                cFunciones.MessageB(ex);
                //throw;
            }
            
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                cFunciones.MessageB(ex);
                //throw;
            }
            
        }

        private void pbxLogo_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                moverForm();
            }
            catch (Exception ex)
            {
                cFunciones.MessageB(ex);
                //throw;
            }
        }

        private void lblTituloG_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                moverForm();
            }
            catch (Exception ex)
            {
                cFunciones.MessageB(ex);
                //throw;
            }
        }

        private void btnAplicarM_Click(object sender, EventArgs e)
        {
            try
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

                cClientes ObjCliente = new cClientes();

                ObjCliente.RFC = txtRFC.Text;
                ObjCliente.NombreCliente = txtNombre.Text;
                ObjCliente.Calle = txtCalle.Text;
                ObjCliente.NumeroExt = txtNoInt.Text;
                ObjCliente.NumeroInt = txtNoInt.Text;
                ObjCliente.CP = Convert.ToInt32(txtCP.Text);
                ObjCliente.DiasCredito = Convert.ToInt32(txtDiasCredito.Text);
                ObjCliente.LimteCredito = Convert.ToDouble(txtLimiteCredito.Text);
                ObjCliente.Saldo = Convert.ToDouble(txtSaldo.Text);
                ObjCliente.Email = txtEMail.Text;
                ObjCliente.Telefono1 = txtTelefono1.Text;
                ObjCliente.Telefono2 = txtTelefono2.Text;
                ObjCliente.Telefono3 = txtTelefono3.Text;
                ObjCliente.Telefono4 = txtTelefono4.Text;
                ObjCliente.Estatus = "A";

                string Colonia = cboColonia.SelectedValue.ToString();
                string Ciudad = cboCiudad.SelectedValue.ToString();
                string Estado = cboEstado.SelectedValue.ToString();
                string Pais = cboPais.SelectedValue.ToString();

                cFunciones.IdColonia = Convert.ToInt32(Colonia);
                cFunciones.IdCiudad = Convert.ToInt32(Ciudad);
                cFunciones.IdEstado = Convert.ToInt32(Estado);
                cFunciones.IdPais = Convert.ToInt32(Pais);
                cFunciones.IdCliente = banderaCliente;


                if (chkCredito.Checked == true)
                {
                    ObjCliente.ConCredito = "S";
                }
                else
                {
                    ObjCliente.ConCredito = "N";
                }

                int actualizados = 0;
                actualizados = ObjCliente.ModificaCliente();
                if (actualizados > 0)
                    MessageBox.Show("Se modificó el cliente correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cConsultasGenerales ObjCGeneral = new cConsultasGenerales();
                DataSet ds = new DataSet();

                ds = ObjCGeneral.ConsultaT2("Cliente");
                dgvDatosC.DataSource = ds.Tables[0];
                txtBusqueda.Text = "";

                pnlDCliente.Visible = false;
                pnlDClienteGrid.Visible = true;
                btnNuevo.Enabled = true;
                GUIDefault();
                HabilitaBotones();
            }
            catch (Exception ex)
            {
                cFunciones.MessageB(ex);
                //throw;
            }
           
        }

        
    }
}
