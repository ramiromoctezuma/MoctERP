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
    public partial class frmVentas : Form
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

        private static frmVentas frmInstance = null;

        public static frmVentas Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmVentas();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        public frmVentas()
        {
            InitializeComponent();
            // >>> Quitar bordes, redondear y mover la ventana sin borde
            #region
            //Mover ventana
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmVentas_MouseMove);
            this.lblTituloG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmVentas_MouseMove);
            this.pbxLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxLogo_MouseMove);
            this.lblTituloG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTituloG_MouseMove);

            //Quitar bordes a la Forma
            this.FormBorderStyle = FormBorderStyle.None;
            //Dibujar bordes redondos
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            #endregion
        }

      

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

            SeleccionaCliente principal = new SeleccionaCliente();

            principal.MdiParent = this.MdiParent;
            
            principal.Show();
            this.Close();

        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            pnlDCliente.Visible = true;
            if (cFunciones.BanderaCliente == 1)
            {
                
                cClientes ObjCliente = new cClientes();

                ObjCliente.ConsultaUno("Cliente");

                txtRFC.Text = ObjCliente.RFC.ToString();
                txtCliente.Text = ObjCliente.NombreCliente.ToString();
                btnSeleccionar.Enabled = false;

                dgvDatosP.Enabled = true;

                txtProducto.Focus();


            }
            else
            {
                dgvDatosP.Enabled = false;
                
            }
            cConsultasGenerales ObjCGeneral = new cConsultasGenerales();
            DataSet ds = new DataSet();

            ds = ObjCGeneral.ConsultaT("Productos", "");
            dgvDatosP.DataSource = ds.Tables[0];

            
        }

        private void txtProducto_KeyUp(object sender, KeyEventArgs e)
        {
            cConsultasGenerales ObjCGeneral = new cConsultasGenerales();
            DataSet DS = new DataSet();
            DataSet DS2 = new DataSet();

            DS = ObjCGeneral.ConsultaT("Productos", txtProducto.Text);
            if (DS.Tables[0].Rows.Count > 0)
            {
                dgvDatosP.DataSource = DS.Tables[0];
                //dgvDatosP.Height = 150;
            }
            else
                dgvDatosP.DataSource = DS2;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            moverForm();
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVentas_MouseMove(object sender, MouseEventArgs e)
        {
            moverForm();
        }

        private void pbxLogo_MouseMove(object sender, MouseEventArgs e)
        {
            moverForm();
        }

        private void lblTituloG_MouseMove(object sender, MouseEventArgs e)
        {
            moverForm();
        }

        private void pbxAgregar_Click(object sender, EventArgs e)
        {

            try
            {

                if (txtCant.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Favor de capturar la cantidad", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCant.Focus();
                    return;
                }

                //int rc = dgvDatosPAgregado.CurrentCell.RowIndex;  //Obtener el indice de la fila

                int rc = dgvDatosP.CurrentCell.RowIndex;  //Obtener el indice de la fila
                int ID = Convert.ToInt32(dgvDatosP[0, rc].Value.ToString());

                if (Convert.ToDouble(dgvDatosP[3, rc].Value.ToString()) < (Convert.ToDouble(txtCant.Text)))
                {
                    MessageBox.Show("La cantidad es mayor a las existencias", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCant.Focus();
                    return;
                }

                double cantidad = 0;
                double cantidad1 = 0;
                double Precio = 0;

                if (dgvDatosPAgregado.Rows.Count == 0)
                {
                    String Descripcion = dgvDatosP[1, rc].Value.ToString();
                    Precio = (double)Convert.ToDecimal(dgvDatosP[2, rc].Value.ToString());
                    cFunciones.pdesc = (double)(Convert.ToDecimal(txtPDescuento.Text));
                    cantidad = (double)Convert.ToDecimal(txtCant.Text.ToString());

                    cFunciones.subtotalpp = cantidad * Precio;
                    int renglon = dgvDatosPAgregado.Rows.Add();

                    cFunciones.subtotal = cFunciones.subtotal + cFunciones.subtotalpp;
                    cFunciones.descuento = cFunciones.subtotal * (cFunciones.pdesc / 100);
                    cFunciones.impuesto = (cFunciones.subtotal - cFunciones.descuento) * (double)(0.16);
                    cFunciones.total = cFunciones.subtotal - cFunciones.descuento + cFunciones.impuesto;

                    txtSubtotal.Text = Convert.ToString(cFunciones.subtotal);
                    txtDescuento.Text = Convert.ToString(cFunciones.descuento);
                    txtImpuesto.Text = Convert.ToString(cFunciones.impuesto);
                    txtTotal.Text = Convert.ToString(cFunciones.total);

                    dgvDatosPAgregado.Rows[renglon].Cells["IdProducto"].Value = ID;
                    dgvDatosPAgregado.Rows[renglon].Cells["Cantidad"].Value = cantidad;
                    dgvDatosPAgregado.Rows[renglon].Cells["Producto"].Value = Descripcion;
                    dgvDatosPAgregado.Rows[renglon].Cells["Precio"].Value = Precio;
                    dgvDatosPAgregado.Rows[renglon].Cells["SubtotalPartida"].Value = cFunciones.subtotalpp;
                }
                else
                {
                    int regactualizado = 0;
                    int renglonaux = 0;
                    double subtaux=0;
                    foreach (DataGridViewRow row in dgvDatosPAgregado.Rows)
                    {
                        
                        //Detalle Venta
                        int IDP = Convert.ToInt32(row.Cells["IdProducto"].Value.ToString());
                        if (ID == IDP)
                        {
                            String Descripcion = dgvDatosP[1, rc].Value.ToString();
                            Precio = (double)Convert.ToDecimal(dgvDatosP[2, rc].Value.ToString());
                            cFunciones.pdesc = (double)(Convert.ToDecimal(txtPDescuento.Text));
                            cantidad1 = (double)Convert.ToDecimal(txtCant.Text.ToString());

                            cantidad = ((double)Convert.ToDecimal(txtCant.Text.ToString())) + ((double)Convert.ToInt32(row.Cells["Cantidad"].Value.ToString()));

                            subtaux = cantidad1 * Precio;

                            cFunciones.subtotalpp=cantidad * Precio;

                            //int renglon = dgvDatosPAgregado.Rows.Add();

                            cFunciones.subtotal = cFunciones.subtotal + subtaux;
                            cFunciones.descuento = cFunciones.subtotal * (cFunciones.pdesc / 100);
                            cFunciones.impuesto = (cFunciones.subtotal - cFunciones.descuento) * (double)(0.16);
                            cFunciones.total = cFunciones.subtotal - cFunciones.descuento + cFunciones.impuesto;

                            txtSubtotal.Text = Convert.ToString(cFunciones.subtotal);
                            txtDescuento.Text = Convert.ToString(cFunciones.descuento);
                            txtImpuesto.Text = Convert.ToString(cFunciones.impuesto);
                            txtTotal.Text = Convert.ToString(cFunciones.total);
                            
                            //dgvDatosPAgregado.Rows.RemoveAt(dgvDatosPAgregado.CurrentRow.Index);

                            dgvDatosPAgregado.Rows[renglonaux].Cells["IdProducto"].Value = ID;
                            dgvDatosPAgregado.Rows[renglonaux].Cells["Cantidad"].Value = cantidad;
                            dgvDatosPAgregado.Rows[renglonaux].Cells["Producto"].Value = Descripcion;
                            dgvDatosPAgregado.Rows[renglonaux].Cells["Precio"].Value = Precio;
                            dgvDatosPAgregado.Rows[renglonaux].Cells["SubtotalPartida"].Value = cFunciones.subtotalpp;

                               
                            regactualizado = 1;

                            
                        }
                        renglonaux++;
                    }
                    if (regactualizado != 1)
                    {
                        String Descripcion = dgvDatosP[1, rc].Value.ToString();
                        Precio = (double)Convert.ToDecimal(dgvDatosP[2, rc].Value.ToString());
                        cFunciones.pdesc = (double)(Convert.ToDecimal(txtPDescuento.Text));
                        cantidad = (double)Convert.ToDecimal(txtCant.Text.ToString());

                        cFunciones.subtotalpp = cantidad * Precio;
                        int renglon = dgvDatosPAgregado.Rows.Add();

                        cFunciones.subtotal = cFunciones.subtotal + cFunciones.subtotalpp;
                        cFunciones.descuento = cFunciones.subtotal * (cFunciones.pdesc / 100);
                        cFunciones.impuesto = (cFunciones.subtotal - cFunciones.descuento) * (double)(0.16);
                        cFunciones.total = cFunciones.subtotal - cFunciones.descuento + cFunciones.impuesto;

                        txtSubtotal.Text = Convert.ToString(cFunciones.subtotal);
                        txtDescuento.Text = Convert.ToString(cFunciones.descuento);
                        txtImpuesto.Text = Convert.ToString(cFunciones.impuesto);
                        txtTotal.Text = Convert.ToString(cFunciones.total);

                        dgvDatosPAgregado.Rows[renglon].Cells["IdProducto"].Value = ID;
                        dgvDatosPAgregado.Rows[renglon].Cells["Cantidad"].Value = cantidad;
                        dgvDatosPAgregado.Rows[renglon].Cells["Producto"].Value = Descripcion;
                        dgvDatosPAgregado.Rows[renglon].Cells["Precio"].Value = Precio;
                        dgvDatosPAgregado.Rows[renglon].Cells["SubtotalPartida"].Value = cFunciones.subtotalpp;
                    }
                }

            }
            catch (Exception ex)
            {
                cFunciones.MessageB(ex);
                throw;
            }
            
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                int rc = dgvDatosPAgregado.CurrentCell.RowIndex;  //Obtener el indice de la fila

                //string que = 
                float subtotalpp = (float)Convert.ToDecimal(dgvDatosPAgregado[4, rc].Value.ToString());

                cFunciones.subtotal = cFunciones.subtotal - subtotalpp;
                cFunciones.descuento = cFunciones.subtotal * (cFunciones.pdesc / 100);
                cFunciones.impuesto = (cFunciones.subtotal - cFunciones.descuento) * (float)(0.16);
                cFunciones.total = cFunciones.subtotal - cFunciones.descuento + cFunciones.impuesto;

                txtSubtotal.Text = Convert.ToString(cFunciones.subtotal);
                txtDescuento.Text = Convert.ToString(cFunciones.descuento);
                txtImpuesto.Text = Convert.ToString(cFunciones.impuesto);
                txtTotal.Text = Convert.ToString(cFunciones.total);

                dgvDatosPAgregado.Rows.RemoveAt(dgvDatosPAgregado.CurrentRow.Index);
            }
            catch (Exception ex)
            {
                cFunciones.MessageB(ex);
               // throw;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                

                    if (txtCliente.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Favor de seleccionar un cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnSeleccionar.Focus();
                        return;
                    }

                    if (txtPDescuento.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Favor de especificar un descuento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPDescuento.Focus();
                        return;
                    }

               
                if (dgvDatosPAgregado.RowCount != 0)
                {
                    cVentas objVentas = new cVentas();

                    int actualizados = 0;
                    int act = 0;

                    //Venta

                    //objVentas.FechaVenta = Convert.ToDateTime(dtpFechas.ToString());

                    objVentas.FechaVenta = Convert.ToDateTime(dtpFechas.Value);

                    objVentas.Subtotal = Convert.ToDouble(txtSubtotal.Text);
                    objVentas.Descuento = Convert.ToDouble(txtDescuento.Text);
                    objVentas.Impuesto = Convert.ToDouble(txtImpuesto.Text);
                    objVentas.Total = Convert.ToDouble(txtTotal.Text);

                    act = objVentas.GuardaVenta();

                    if (act > 0)
                    {

                        foreach (DataGridViewRow row in dgvDatosPAgregado.Rows)
                        {

                            //Detalle Venta
                            objVentas.IdProducto = Convert.ToInt32(row.Cells["IdProducto"].Value.ToString());
                            objVentas.Cantidad = (double)Convert.ToInt32(row.Cells["Cantidad"].Value.ToString());
                            objVentas.Precio = (double)Convert.ToInt32(row.Cells["Precio"].Value.ToString());

                            actualizados = objVentas.InsertaDetalleVenta();
                            if (actualizados < 0)
                                MessageBox.Show("Error al registrar el detalle venta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (actualizados > 0)
                            MessageBox.Show("Venta registrada exitosamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                        //this.Controls.Clear();

                        this.InitializeComponent();
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar la venta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No se ha agregado ningun producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
            catch (Exception ex)
            {
                cFunciones.MessageB(ex);
                //throw;
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiar()
        {
            txtCliente.Text = "";
            txtRFC.Text = "";
            dtpFechas.Refresh();
            txtDescuento.Text = "";
            txtPDescuento.Text = "";
            txtCant.Text = "";
            txtSubtotal.Text = "";
            txtDescuento.Text = "";
            txtImpuesto.Text = "";
            txtTotal.Text = "";

            btnSeleccionar.Focus();

            cConsultasGenerales ObjCGeneral = new cConsultasGenerales();

            DataSet ds2 = new DataSet();
            DataSet ds = new DataSet();

            ds = ObjCGeneral.ConsultaT("Productos", "");
            dgvDatosP.DataSource = ds.Tables[0];

            DataTable dt;
            dt = (DataTable)(((DataGridView)dgvDatosPAgregado).DataSource);
            dt.Rows.Clear();

            //dgvDatosPAgregado.
            //dgvDatosPAgregado.DataSource = ds2.Tables[0];
        }
            
    }
}
