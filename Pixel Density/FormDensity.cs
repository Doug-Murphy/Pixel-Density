using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pixel_Density
{
    public partial class FormDensity : Form
    {
        public FormDensity()
        {
            InitializeComponent();
        }

        private void FormLines_Load(object sender, EventArgs e)
        {
            this.Size = new Size(400, 400);
            this.Location = new Point(0, 0);

            var halfWidth = this.Width / 2;
            var halfHeight = this.Height / 2;

            var panel1 = new Panel
            {
                Location = new Point(halfWidth * 0, halfWidth * 0),
                Size = new Size(halfWidth, halfHeight)
            };
            panel1.Paint += Panel_Paint;

            var panel2 = new Panel
            {
                Location = new Point(halfWidth * 1, halfWidth * 0),
                Size = new Size(halfWidth, halfHeight)
            };
            panel2.Paint += Panel_Paint;

            var panel3 = new Panel
            {
                Location = new Point(halfWidth * 0, halfWidth * 1),
                Size = new Size(halfWidth, halfHeight)
            };
            panel3.Paint += Panel_Paint;

            var panel4 = new Panel
            {
                Location = new Point(halfWidth * 1, halfWidth * 1),
                Size = new Size(halfWidth, halfHeight)
            };
            panel4.Paint += Panel_Paint;

            this.Controls.Add(panel1);
            this.Controls.Add(panel2);
            this.Controls.Add(panel3);
            this.Controls.Add(panel4);
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            var panelWidth = ((Control)sender).Width;
            var panelHeight = ((Control)sender).Height;

            using (var blackPen = new Pen(Color.FromArgb(255, 0, 0, 0)))
            using (var whitePen = new Pen(Color.FromArgb(255, 255, 255, 255)))
            {
                for (int x = 0; x < panelWidth; x++)
                {
                    for (int y = 0; y < panelHeight; y++)
                    {
                        if ((x % 2 == 0 && y % 2 == 1) || (x % 2 == 1 && y % 2 == 0))
                        {
                            e.Graphics.DrawRectangle(whitePen, x, y, 1, 1);
                        }
                        else
                        {
                            e.Graphics.DrawRectangle(blackPen, x, y, 1, 1);
                        }
                    }
                }

            }
        }
    }
}