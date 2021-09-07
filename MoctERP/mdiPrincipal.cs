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
    public partial class mdiPrincipal : Form
    {
        private int childFormNumber = 0;

        public mdiPrincipal()
        {
            InitializeComponent();

        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void prueba1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFichaCliente mdiFichaCliente = new frmFichaCliente();
            // Set the Parent Form of the Child window.  
            mdiFichaCliente.MdiParent = this;
            // Display the new form.  
            mdiFichaCliente.Show(); 
        }

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes _frmClientes = null;
            _frmClientes = frmClientes.Instance();

            _frmClientes.MdiParent = this;
            _frmClientes.Show();

        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PoveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedores _frmProveedores = null;
            _frmProveedores = frmProveedores.Instance();

            _frmProveedores.MdiParent = this;
            _frmProveedores.Show();
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos _frmProductos = null;
            _frmProductos = frmProductos.Instance();

            _frmProductos.MdiParent = this;
            _frmProductos.Show();; 
        }

        private void VentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas _frmVentas = null;
            _frmVentas = frmVentas.Instance();

            _frmVentas.MdiParent = this;
            _frmVentas.Show();; 

        }
    }
}
