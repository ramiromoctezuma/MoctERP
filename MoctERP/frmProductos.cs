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
    public partial class frmProductos : Form
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

        //private void moverForm()
        //{
        //    ReleaseCapture();
        //    SendMessage(this.Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0);
        //}

        //// **** MOVER VENTANA
        #endregion

        private static frmProductos frmInstance = null;

        public static frmProductos Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmProductos();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        public frmProductos()
        {
            
                // >>> Quitar bordes, redondear y mover la ventana sin borde
                //#region
                ////Mover ventana
                //this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmProductos_MouseMove_1);
                //this.lblTituloG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmProductos_MouseMove_1);
                //this.pbxLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxLogo_MouseMove);
                //this.lblTituloG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTituloG_MouseMove);

                ////Quitar bordes a la Forma
                //this.FormBorderStyle = FormBorderStyle.None;
                ////Dibujar bordes redondos
                //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
                //#endregion
            
            InitializeComponent();

            
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            try
            {
                cConsultasGenerales ObjCGeneral = new cConsultasGenerales();
                DataSet ds = new DataSet();

                ds = ObjCGeneral.ConsultaT2("Productos");
                dgvDatosC.DataSource = ds.Tables[0];

                txtBusqueda.Focus();
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
                pnlDProducto.Visible = true;
                pnlDProductoGrid.Visible = false;

                InabilitaBotones();

                btnEliminarC.Visible = false;
                btnAgregar.Visible = false;
                btnCancelar.Visible = true;
                btnAplicarM.Visible = true;


                int rc = dgvDatosC.CurrentCell.RowIndex;  //Obtener el indice de la fila
                int ID = Convert.ToInt32(dgvDatosC[0, rc].Value.ToString());
                cProductos ObjProductos = new cProductos();

                cFunciones.IdProducto = ID;
                ObjProductos.ConsultaUno("Productos");

                //banderaCliente = Convert.ToInt32(ObjProductos.IdCliente.ToString());
                txtDescripcion.Text = ObjProductos.Descripcion.ToString();
                txtCosto.Text = ObjProductos.Costo.ToString();
                txtPrecio.Text = ObjProductos.Precio.ToString();
                txtUnidadMedida.Text = ObjProductos.UnidadMedida.ToString();
                txtFotografia.Text = ObjProductos.Fotografia.ToString();
                txtExistencia.Text = ObjProductos.Existencia.ToString();
                

                System.IO.MemoryStream ms = new System.IO.MemoryStream(ObjProductos.Fotografia);
                pbxFoto.Image = System.Drawing.Bitmap.FromStream(ms);

                char Tipo = Convert.ToChar(ObjProductos.Tipo.ToString());
                if (Tipo == 'M')
                    rbtMaterial.Checked = true;
                else
                    rbtMaterial.Checked = false;

                DataSet dsCol = new DataSet();

                dsCol = cFunciones.CargaLinea();
                cboLinea.DataSource = dsCol.Tables[0];
                cboLinea.DisplayMember = "DescripcionLinea";
                cboLinea.ValueMember = "IdLinea";

                txtFotografia.Text = "";
                txtExistencia.Visible = true;
                txtExistencia.Enabled = false;

                
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
                if (txtDescripcion.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Favor de especificar la descripción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescripcion.Focus();
                    return;
                }

                if (txtCosto.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Favor de especificar el Costo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCosto.Focus();
                    return;
                }

                if (txtPrecio.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Favor de especificar el Precio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrecio.Focus();
                    return;
                }

                if (txtUnidadMedida.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Favor de especificar la Unidad de Medida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUnidadMedida.Focus();
                    return;
                }

                if (txtFotografia.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Favor de seleccionar  la fotografía", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFotografia.Focus();
                    return;
                }

                if (cboLinea.SelectedIndex.Equals(-1))
                {
                    MessageBox.Show("Favor de validar el CP.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboLinea.Focus();
                    return;
                }

                if ((rbtMaterial.Checked == false) && (rbtProductoT.Checked == false))
                {
                    MessageBox.Show("Favor de especificar el Tipo de producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rbtMaterial.Focus();
                    return;
                }

                #endregion

                cProductos objProductos = new cProductos();

                objProductos.Descripcion = txtDescripcion.Text;
                objProductos.Costo = float.Parse(txtCosto.Text);
                objProductos.Precio = float.Parse(txtPrecio.Text);
                objProductos.UnidadMedida = txtUnidadMedida.Text;

                if (rbtMaterial.Checked == true)
                {
                    objProductos.Tipo = "M";
                }
                else if (rbtProductoT.Checked == true)
                {
                    objProductos.Tipo = "P";
                }

                string Linea = cboLinea.SelectedValue.ToString();
                cFunciones.IdLinea = Convert.ToInt32(Linea);

                int actualizados = 0;
                actualizados = objProductos.ModificaProducto(pbxFoto);
                if (actualizados > 0)
                    MessageBox.Show("Se modificó el producto correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cConsultasGenerales ObjCGeneral = new cConsultasGenerales();
                DataSet ds = new DataSet();

                ds = ObjCGeneral.ConsultaT2("Productos");
                dgvDatosC.DataSource = ds.Tables[0];
                txtBusqueda.Text = "";

                pnlDProducto.Visible = false;
                pnlDProductoGrid.Visible = true;
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            try
            {

                pnlDProducto.Visible = true;
                pnlDProductoGrid.Visible = false;
                btnSeleccionaI.Enabled = false;

                btnConsultar.Enabled = false;

                btnEliminarC.Visible = false;
                btnCancelar.Visible = true;
                btnAgregar.Visible = false;
                btnAplicarM.Visible = false;

                ReadOnly();
                InabilitaBotones();

                int rc = dgvDatosC.CurrentCell.RowIndex;  //Obtener el indice de la fila
                int ID = Convert.ToInt32(dgvDatosC[0, rc].Value.ToString());
                cProductos ObjProductos = new cProductos();

                cFunciones.IdProducto = ID;
                ObjProductos.ConsultaUno("Productos");

                //banderaCliente = Convert.ToInt32(ObjProductos.IdCliente.ToString());
                txtDescripcion.Text = ObjProductos.Descripcion.ToString();
                txtCosto.Text = ObjProductos.Costo.ToString();
                txtPrecio.Text = ObjProductos.Precio.ToString();
                txtUnidadMedida.Text = ObjProductos.UnidadMedida.ToString();
                txtFotografia.Text = ObjProductos.Fotografia.ToString();
                txtExistencia.Text = ObjProductos.Existencia.ToString();


                System.IO.MemoryStream ms = new System.IO.MemoryStream(ObjProductos.Fotografia);
                pbxFoto.Image = System.Drawing.Bitmap.FromStream(ms);

                char Tipo = Convert.ToChar(ObjProductos.Tipo.ToString());
                if (Tipo == 'M')
                    rbtMaterial.Checked = true;
                else
                    rbtMaterial.Checked = false;

                DataSet dsCol = new DataSet();

                dsCol = cFunciones.CargaLinea();
                cboLinea.DataSource = dsCol.Tables[0];
                cboLinea.DisplayMember = "DescripcionLinea";
                cboLinea.ValueMember = "IdLinea";

                txtFotografia.Text = "";


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
                pnlDProducto.Visible = true;
                pnlDProductoGrid.Visible = false;

                InabilitaBotones();

                btnAplicarM.Visible = false;
                btnEliminarC.Visible = false;
                btnAgregar.Visible = true;
                btnCancelar.Visible = true;
                txtDescripcion.Focus();

                DataSet dsCol = new DataSet();

                dsCol = cFunciones.CargaLinea();
                cboLinea.DataSource = dsCol.Tables[0];
                cboLinea.DisplayMember = "DescripcionLinea";
                cboLinea.ValueMember = "IdLinea";
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
                if (txtDescripcion.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Favor de especificar la descripción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescripcion.Focus();
                    return;
                }

                if (txtCosto.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Favor de especificar el Costo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCosto.Focus();
                    return;
                }

                if (txtPrecio.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Favor de especificar el Precio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrecio.Focus();
                    return;
                }

                if (txtUnidadMedida.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Favor de especificar la Unidad de Medida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUnidadMedida.Focus();
                    return;
                }

                if (txtFotografia.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Favor de seleccionar  la fotografía", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFotografia.Focus();
                    return;
                }

                if (cboLinea.SelectedIndex.Equals(-1))
                {
                    MessageBox.Show("Favor de validar el CP.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboLinea.Focus();
                    return;
                }

                if ((rbtMaterial.Checked == false) && (rbtProductoT.Checked == false))
                {
                    MessageBox.Show("Favor de especificar el Tipo de producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rbtMaterial.Focus();
                    return;
                }

                #endregion

                cProductos objProductos = new cProductos();

                objProductos.Descripcion = txtDescripcion.Text;
                objProductos.Costo = float.Parse(txtCosto.Text);
                objProductos.Precio = float.Parse(txtPrecio.Text);
                objProductos.UnidadMedida = txtUnidadMedida.Text;

                if (rbtMaterial.Checked == true)
                {
                    objProductos.Tipo = "M";
                }
                else if (rbtProductoT.Checked == true)
                {
                    objProductos.Tipo = "P";
                }

                string Linea = cboLinea.SelectedValue.ToString();
                cFunciones.IdLinea = Convert.ToInt32(Linea);

                int actualizados = 0;
                actualizados = objProductos.InsertaProducto(pbxFoto);
                if (actualizados > 0)
                    MessageBox.Show("Se registró el producto correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cConsultasGenerales ObjCGeneral = new cConsultasGenerales();
                DataSet ds = new DataSet();

                ds = ObjCGeneral.ConsultaT2("Productos");
                dgvDatosC.DataSource = ds.Tables[0];
                txtBusqueda.Text = "";

                pnlDProducto.Visible = false;
                pnlDProductoGrid.Visible = true;
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
                //throw;
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
                pnlDProducto.Visible = false;
                pnlDProductoGrid.Visible = true;

                btnNuevo.Enabled = true;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                btnConsultar.Enabled = true;

                btnAgregar.Visible = true;
                btnAplicarM.Visible = true;
                btnCancelar.Visible = true;
                btnEliminarC.Visible = true;

                cboLinea.DataSource = null;

                txtDescripcion.Text = "";
                txtCosto.Text = "";
                txtPrecio.Text = "";
                txtUnidadMedida.Text = "";
                txtFotografia.Text = "";
                txtExistencia.Text = "";

                rbtMaterial.Checked = false;
                rbtProductoT.Checked = false;


                txtDescripcion.ReadOnly = false;
                txtCosto.ReadOnly = false;
                txtPrecio.ReadOnly = false;
                cboLinea.Enabled = true;
                txtUnidadMedida.ReadOnly = false;
                txtFotografia.ReadOnly = false;
                txtExistencia.ReadOnly = false;
                rbtMaterial.Enabled = true;
                rbtProductoT.Enabled = true;
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
                txtDescripcion.ReadOnly = true;
                txtCosto.ReadOnly = true;
                txtPrecio.ReadOnly = true;
                cboLinea.Enabled = false;
                txtUnidadMedida.ReadOnly = true;
                txtFotografia.ReadOnly = true;
                txtExistencia.ReadOnly = true;
                rbtMaterial.Enabled = false;
                rbtProductoT.Enabled = false;
            }
            catch (Exception ex)
            {
                cFunciones.MessageB(ex);
                //throw;
            }
            

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                pnlDProducto.Visible = true;
                pnlDProductoGrid.Visible = false;

                InabilitaBotones();

                btnCancelar.Visible = true;
                btnAgregar.Visible = false;
                btnAplicarM.Visible = false;

                ReadOnly();

                int rc = dgvDatosC.CurrentCell.RowIndex;  //Obtener el indice de la fila
                int ID = Convert.ToInt32(dgvDatosC[0, rc].Value.ToString());
                //MessageBox.Show("Current Row Index is = " + rc.ToString());
                cProductos ObjProductos = new cProductos();

                cFunciones.IdProducto = ID;
                ObjProductos.ConsultaUno("Productos");

                txtDescripcion.Text = ObjProductos.Descripcion.ToString();
                txtCosto.Text = ObjProductos.Costo.ToString();
                txtPrecio.Text = ObjProductos.Precio.ToString();
                txtUnidadMedida.Text = ObjProductos.UnidadMedida.ToString();
                txtFotografia.Text = ObjProductos.Fotografia.ToString();
                txtExistencia.Text = ObjProductos.Existencia.ToString();


                System.IO.MemoryStream ms = new System.IO.MemoryStream(ObjProductos.Fotografia);
                pbxFoto.Image = System.Drawing.Bitmap.FromStream(ms);

                char Tipo = Convert.ToChar(ObjProductos.Tipo.ToString());
                if (Tipo == 'M')
                    rbtMaterial.Checked = true;
                else
                    rbtMaterial.Checked = false;

                DataSet dsCol = new DataSet();

                dsCol = cFunciones.CargaLinea();
                cboLinea.DataSource = dsCol.Tables[0];
                cboLinea.DisplayMember = "DescripcionLinea";
                cboLinea.ValueMember = "IdLinea";

                txtFotografia.Text = "";
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
                DialogResult dr = MessageBox.Show("¿Deseas dar de baja el producto?",
                      "Atención", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        int rc = dgvDatosC.CurrentCell.RowIndex;  //Obtener el indice de la fila
                        int ID = Convert.ToInt32(dgvDatosC[0, rc].Value.ToString());
                        cProductos ObjProducto = new cProductos();

                        ObjProducto.IdProducto = ID;
                        int actualizados = 0;
                        actualizados = ObjProducto.EliminaProducto("Productos");

                        if (actualizados > 0)
                            MessageBox.Show("Producto dado de baja correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        GUIDefault();
                        cConsultasGenerales ObjCGeneral = new cConsultasGenerales();
                        DataSet ds = new DataSet();

                        ds = ObjCGeneral.ConsultaT2("Productos");
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

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                cConsultasGenerales ObjCGeneral = new cConsultasGenerales();
                DataSet DS = new DataSet();
                DataSet DS2 = new DataSet();

                DS = ObjCGeneral.ConsultaT("Productos", txtBusqueda.Text);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                pnlDProducto.Visible = false;
                pnlDProductoGrid.Visible = true;

                btnConsultar.Enabled = true;
                btnAgregar.Visible = true;
                btnCancelar.Visible = false;
                btnAplicarM.Visible = false;
                btnSeleccionaI.Visible = true;

                btnNuevo.Enabled = true;

                GUIDefault();
            }
            catch (Exception ex)
            {
                cFunciones.MessageB(ex);
                //throw;
            }
            
            
        }
        
        private void btnSeleccionaI_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog BuscarImagen = new OpenFileDialog(); BuscarImagen.Filter = "Archivos de Imagen|*.jpg";
                //Aquí incluiremos los filtros que queramos.
                BuscarImagen.FileName = "";
                BuscarImagen.Title = "Selecciona la imagen";
                BuscarImagen.InitialDirectory = "C:\\"; BuscarImagen.FileName = this.txtFotografia.Text;
                if (BuscarImagen.ShowDialog() == DialogResult.OK)
                {
                    /// Si esto se cumple, capturamos la propiedad File Name y la guardamos en el control
                    this.txtFotografia.Text = BuscarImagen.FileName;
                    String Direccion = BuscarImagen.FileName;
                    this.pbxFoto.ImageLocation = Direccion;
                    //Pueden usar tambien esta forma para cargar la Imagen solo activenla y comenten la linea donde se cargaba anteriormente 
                    //this.pictureBox1.ImageLocation = textBox1.Text;
                    pbxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                //if (openFileDialog1.FileName.Equals("") == false)
                //{
                //    pbxFoto.Load(openFileDialog1.FileName);
                //}
            }
            catch (Exception ex)
            {
                cFunciones.MessageB(ex);
                //throw;
            }
            
          
            

        }

        //private void panel3_MouseDown(object sender, MouseEventArgs e)
        //{
        //    try
        //    {
        //        moverForm();
        //    }
        //    catch (Exception ex)
        //    {
        //        cFunciones.MessageB(ex);
        //        //throw;
        //    }
            
        //}

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

        //private void frmProductos_MouseMove_1(object sender, MouseEventArgs e)
        //{
           
        //        moverForm();
            
        //}

        //private void pbxLogo_MouseMove(object sender, MouseEventArgs e)
        //{
            
        //        moverForm();
           
        //}

        //private void lblTituloG_MouseMove(object sender, MouseEventArgs e)
        //{
            
        //        moverForm();
            
        //}
    }
}
