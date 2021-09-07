using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoctERP
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmAcceso Login = new frmAcceso();
            Login.ShowDialog();
            if (Login.UsuarioValidado)
                //Application.Run(new frmPrincipal());
                Application.Run(new mdiPrincipal());
                
        }
    }
}
