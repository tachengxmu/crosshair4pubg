using System; 
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
            main.AutoScaleMode = AutoScaleMode.Dpi;
            main.AllowTransparency = true;
            main.StartPosition = FormStartPosition.Manual;
            Application.Run(main);
        }
    }
}

