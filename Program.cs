using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sotietkiem99
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmdangnhap frm = new frmdangnhap();
           // frmkhachhang frm = new frmkhachhang();

            frm.ShowDialog();
            if (keycode.dangnhap)
            {
               Application.Run(new frmmain());
            }
        }
    }
}
