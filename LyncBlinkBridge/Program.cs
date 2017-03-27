using System;
using System.Windows.Forms;
using Quartz;
using Quartz.Impl;

namespace LyncBlinkBridge
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BlinkLyncConnectorAppContext());
        }
    }
}
