using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Program7_5
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
