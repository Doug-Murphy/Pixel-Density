﻿using System;
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

        private void Panel_Paint(object sender, PaintEventArgs e)
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

            var leftSide = 0;
            var columnCounter = 0;
            var rowCounter = 0;
            var rowsRequired = this.Height / DRAWN_SQUARE_SIZE;

            while (leftSide <= this.Width && rowCounter <= rowsRequired)
            {
                e.Graphics.CopyFromScreen(screenRectangle.Left, screenRectangle.Top, DRAWN_SQUARE_SIZE * columnCounter, DRAWN_SQUARE_SIZE * rowCounter, new Size(DRAWN_SQUARE_SIZE, DRAWN_SQUARE_SIZE));
                leftSide += DRAWN_SQUARE_SIZE;
                columnCounter++;
                if (leftSide >= this.Width)
                {
                    rowCounter++;
                    columnCounter = 0;
                    leftSide = 0;
                }
            }
        }
    }
}