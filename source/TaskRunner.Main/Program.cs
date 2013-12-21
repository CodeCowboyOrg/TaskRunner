using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace TaskRunner.Main
{
    static class Program
    {
        /// <summary>
        /// Rights to use any portion of this code for any Production related purposes
        /// require explicit written permission from the author Johnson Fan and can be
        /// reached at JohnsonFan@yahoo.com.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TaskRunnerMain());
        }
    }
}
