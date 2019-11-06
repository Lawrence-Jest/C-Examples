// Class Program to provide the entry point for the date validator app.
//
// Lawrence Jest-A00583216.
// June 22, 2018.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Assign05
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
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
