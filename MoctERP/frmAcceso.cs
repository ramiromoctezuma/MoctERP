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
    public partial class frmAcceso : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public frmAcceso()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private bool _UsuarioValidado = false;
        public bool UsuarioValidado
        {
            get
            {
                return _UsuarioValidado;
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            try
            {

                cUsuario objCusuario = new cUsuario();
                if (txtUsuario.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Favor de especificar el usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Focus();
                    return;
                }

                bool res = objCusuario.ValidaUsuario(txtUsuario.Text);

                if (res)
                {
                    txtNombreU.Text = objCusuario.Usuario.ToString();
                    pnlUsuario.Visible = false;
                    pnlContraseña.Visible = true;
                    txtContrasena.Focus();
                    
                }

                else
                    MessageBox.Show("No se ha podido encontrar tu usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsuario.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void btnContinuarC_Click(object sender, EventArgs e)
        {
            try
            {
                cUsuario objCusuario = new cUsuario();
                objCusuario.ValidaUsuario(txtUsuario.Text);
                if (txtContrasena.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Favor de especificar la contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContrasena.Focus();
                    return;
                }

                if (txtContrasena.Text == objCusuario.Contrasena.ToString())
                {
                    pnlUsuario.Visible = true;
                    pnlContraseña.Visible = false;
                    _UsuarioValidado = true;
                    this.Close();

                }

                else
                    MessageBox.Show("Contraseña Incorrecta. Vuelve a intentarlo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtContrasena.Text = "";
                    txtContrasena.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Sistema", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Contraseña Incorrecta. Vuelve a intentarlo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //throw;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAcceso_Load(object sender, EventArgs e)
        {
            //System.Drawing.Drawing2D.GraphicsPath objDraw = new
            //System.Drawing.Drawing2D.GraphicsPath();
            //objDraw.AddEllipse(10, 10, this.Width, this.Height);
            //this.Region = new Region(objDraw);
        }
    }
}
