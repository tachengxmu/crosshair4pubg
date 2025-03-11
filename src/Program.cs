using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crosshair4pubg
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            var main = new crosshair();
            main.AllowTransparency = true;
            main.StartPosition = FormStartPosition.Manual;
            Application.Run(main);
        }
    }
}

