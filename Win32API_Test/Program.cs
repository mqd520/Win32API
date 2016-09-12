using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Win32API_Test
{
    static class Program
    {
        internal static IntPtr hInstance = IntPtr.Zero;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process p = Process.GetCurrentProcess();
            hInstance = (IntPtr)Mqd.Win32.API.Win32API.GetModuleHandle(null);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
