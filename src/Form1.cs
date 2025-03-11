using System; 
using System.Drawing; 
using System.Windows.Forms; 

namespace crosshair4pubg
{
    public partial class crosshair : Form
    {

        public crosshair()
        {
            InitializeComponent();

            w = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            h = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;

            int hh = h / 9;

            int ww = hh * 2 / ratio;

            bm = new Bitmap(ww, hh);

            var g = Graphics.FromImage(bm);

            int[] s = new int[] { 8, 6, 4, 3 };
            for (int i = 0; i < s.Length; ++i)
            {
                s[i] = s[i] * hh;
            }

            for (int i = 0; i < s.Length; ++i)
            {
                g.DrawLine(pen, ww / 2 - s[i] / (ratio * half_ratio), hh - s[i] / half_ratio, ww / 2 + s[i] / (ratio * half_ratio), hh - s[i] / half_ratio);
            }
            g.DrawLine(pen, ww / 2, hh, ww / 2 - s[0] / (ratio * half_ratio), hh - s[0] / half_ratio);
            g.DrawLine(pen, ww / 2 + 1, hh, ww / 2 + s[0] / (ratio * half_ratio), hh - s[0] / half_ratio);
            g.Dispose();
        }
        int w, h;
        Bitmap bm;

        Pen pen = Pens.Red;
        const int ratio = 4;
        const int half_ratio = 8;

        private void Form1_Paint(object sender, PaintEventArgs e)
        { 
            var tg = this.CreateGraphics();
            this.Height = h / 9;
            this.Width = 2 * this.Height / ratio;
            this.Top = h / 2 - this.Height;
            this.Left = w / 2 - this.Width / 2;
            tg.DrawImage(bm, 0, 0, this.Width, this.Height);
            tg.Dispose();
        }
         
        private void crosshair_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
