using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pixel_Density
{
    public partial class FormDensity : Form
    {
        private const int DRAWN_SQUARE_SIZE = 50;

        public FormDensity(int startX = 0, int startY = 0)
        {
            InitializeComponent();
            this.Location = new Point(startX, startY);
        }

        private void FormDensity_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormDensity_Paint(object sender, PaintEventArgs e)
        {
            using (var blackPen = new Pen(Color.FromArgb(255, 0, 0, 0)))
            using (var whitePen = new Pen(Color.FromArgb(255, 255, 255, 255)))
            {
                for (int x = 0; x < DRAWN_SQUARE_SIZE; x++)
                {
                    for (int y = 0; y < DRAWN_SQUARE_SIZE; y++)
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

            Rectangle screenRectangle = RectangleToScreen(this.ClientRectangle);

            var leftSide = DRAWN_SQUARE_SIZE;
            var rowCounter = 0;
            var rowsRequired = this.Height / DRAWN_SQUARE_SIZE;

            while (leftSide <= this.Width)
            {
                e.Graphics.CopyFromScreen(screenRectangle.Left, screenRectangle.Top, leftSide, 0, new Size(leftSide, DRAWN_SQUARE_SIZE));
                leftSide *= 2;
            }
            while (rowCounter <= rowsRequired)
            {
                rowCounter++;
                e.Graphics.CopyFromScreen(screenRectangle.Left, screenRectangle.Top, 0, DRAWN_SQUARE_SIZE * rowCounter, new Size(this.Width, DRAWN_SQUARE_SIZE));
            }
        }
    }
}