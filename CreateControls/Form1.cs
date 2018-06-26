using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CreateControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Height = Screen.PrimaryScreen.Bounds.Height - 100;
            Width = Screen.PrimaryScreen.Bounds.Width - 50;
            StartPosition = FormStartPosition.CenterScreen;
            int count = 1;
            var tip = new ToolTip(components);
            try
            {
                const int hh = 20;
                int xMax = Width / hh - 3;
                int yMax = Height / hh - 4;
                for (var y = 1; y <= yMax; y += 1)
                    for (var x = 1; x <= xMax; x += 1)
                    {
                        var ctl = new Button();
                        ctl.Size = new Size(hh, hh);
                        ctl.Location = new Point(x * hh, y * hh);
                        ctl.Click += btn_click;
                        tip.SetToolTip(ctl, count.ToString());
                        Controls.Add(ctl);
                        count += 1;
                    }
            }
            catch (Win32Exception) { }
        }
        private void btn_click(object sender, System.EventArgs e)
        {
            var ctl = (Button)sender;
            ctl.BackColor = Color.Black;
        }
    }
}
