using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace crosshair4pubg
{
    public partial class crosshair : Form
    {

        public crosshair()
        {
            InitializeComponent();            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int w = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            int h = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;


            int ratio = 4;

            this.Height = h / 9;

            this.Width = 2 * h / 9 / ratio;

            this.Top = h / 2 - this.Height;
            this.Left = w / 2 - this.Width / 2;

            int half = this.Height / 8;

            var g = this.CreateGraphics();

            int[] s = new int[] { 8,6,4,3 };

            for (int i = 0; i < s.Length; ++i)
            {
                g.DrawLine(Pens.Red, this.Width / 2 - s[i] * half / ratio, this.Height - s[i] * half, this.Width / 2 + s[i] * half / ratio, this.Height - s[i] * half);
            }
            g.DrawLine(Pens.Red, this.Width / 2, this.Height, this.Width / 2 - s[0] * half / ratio, this.Height - s[0] * half);
            g.DrawLine(Pens.Red, this.Width / 2 + 1, this.Height, this.Width / 2 + s[0] * half / ratio, this.Height - s[0] * half); 

        }
        private void crosshair_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
