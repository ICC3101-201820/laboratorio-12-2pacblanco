using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
            Controller controlador = new Controller();
            Form1 form1 = new Form1();
            controlador.form1 = form1;
            form1.OnAgregarComida += controlador.OnAgregarComida;
            Application.Run(form1);
        }
    }
}
