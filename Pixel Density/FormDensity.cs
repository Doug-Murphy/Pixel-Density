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
            //this.Size = Screen.FromControl(this).Bounds.Size;
            this.Opacity = 0;
            this.Size = new Size(500, 500);
            this.Location = new Point(0, 0);
        }

        private void DrawGrid(object sender, PaintEventArgs e)
        {
            var start = DateTime.Now;
            using (var blackPen = new Pen(Color.FromArgb(255, 0, 0, 0)))
            using (var whitePen = new Pen(Color.FromArgb(255, 255, 255, 255)))
            {
                for (int x = 0; x < this.Width; x++)
                {
                    for (int y = 0; y < this.Height; y++)
                    {
                        if ((x % 2 == 0 && y % 2 == 1) || (x % 2 == 1 && y % 2 == 0))
                        {
                            e.Graphics.DrawRectangle(whitePen, x, y, 1, 1);
                            Console.WriteLine($"Drawing white at ({x},{y})");
                        }
                        else
                        {
                            e.Graphics.DrawRectangle(blackPen, x, y, 1, 1);
                            Console.WriteLine($"Drawing black at ({x},{y})");
                        }
                    }
                }

            }
            Console.WriteLine($"Total milliseconds = {DateTime.Now.Subtract(start).TotalMilliseconds}.");
            this.Opacity = 100;

            //using (var blackPen = new Pen(Color.FromArgb(255, 0, 0, 0)))
            //using (var whitePen = new Pen(Color.FromArgb(255, 255, 255, 255)))
            //{
            //    var paintTasks = new List<Task>
            //    {
            //        Task.Factory.StartNew(() =>
            //        {
            //            for (int x = (this.Width / 5) * 0; x < (this.Width / 5) * 1; x++)
            //            {
            //                for (int y =0; y < this.Height; y++)
            //                {
            //                    if (x % 2 == 0 && y % 2 == 0) //even x, even y
            //                    {
            //                        e.Graphics.DrawRectangle(blackPen, x, y, 1, 1);
            //                        //Console.WriteLine($"Drawing black at ({x},{y})");
            //                    }
            //                    else if (x % 2 == 0 && y % 2 == 1) //even x, odd y
            //                    {
            //                        e.Graphics.DrawRectangle(whitePen, x, y, 1, 1);
            //                        //Console.WriteLine($"Drawing white at ({x},{y})");
            //                    }
            //                    else if (x % 2 == 1 && y % 2 == 0) //odd x, even y
            //                    {
            //                        e.Graphics.DrawRectangle(whitePen, x, y, 1, 1);
            //                        //Console.WriteLine($"Drawing white at ({x},{y})");
            //                    }
            //                    else //odd x, odd y
            //                    {
            //                        e.Graphics.DrawRectangle(blackPen, x, y, 1, 1);
            //                        //Console.WriteLine($"Drawing black at ({x},{y})");
            //                    }
            //                }
            //            }
            //        }),
            //        Task.Factory.StartNew(() =>
            //        {
            //            for (int x = (this.Width / 5) * 1; x < (this.Width / 5) * 2; x++)
            //            {
            //                for (int y =0; y < this.Height; y++)
            //                {
            //                    if (x % 2 == 0 && y % 2 == 0) //even x, even y
            //                    {
            //                        e.Graphics.DrawRectangle(blackPen, x, y, 1, 1);
            //                        //Console.WriteLine($"Drawing black at ({x},{y})");
            //                    }
            //                    else if (x % 2 == 0 && y % 2 == 1) //even x, odd y
            //                    {
            //                        e.Graphics.DrawRectangle(whitePen, x, y, 1, 1);
            //                        //Console.WriteLine($"Drawing white at ({x},{y})");
            //                    }
            //                    else if (x % 2 == 1 && y % 2 == 0) //odd x, even y
            //                    {
            //                        e.Graphics.DrawRectangle(whitePen, x, y, 1, 1);
            //                        //Console.WriteLine($"Drawing white at ({x},{y})");
            //                    }
            //                    else //odd x, odd y
            //                    {
            //                        e.Graphics.DrawRectangle(blackPen, x, y, 1, 1);
            //                        //Console.WriteLine($"Drawing black at ({x},{y})");
            //                    }
            //                }
            //            }
            //        }),
            //        Task.Factory.StartNew(() =>
            //        {
            //            for (int x = (this.Width / 5) * 2; x < (this.Width / 5) * 3; x++)
            //            {
            //                for (int y =0; y < this.Height; y++)
            //                {
            //                    if (x % 2 == 0 && y % 2 == 0) //even x, even y
            //                    {
            //                        e.Graphics.DrawRectangle(blackPen, x, y, 1, 1);
            //                        //Console.WriteLine($"Drawing black at ({x},{y})");
            //                    }
            //                    else if (x % 2 == 0 && y % 2 == 1) //even x, odd y
            //                    {
            //                        e.Graphics.DrawRectangle(whitePen, x, y, 1, 1);
            //                        //Console.WriteLine($"Drawing white at ({x},{y})");
            //                    }
            //                    else if (x % 2 == 1 && y % 2 == 0) //odd x, even y
            //                    {
            //                        e.Graphics.DrawRectangle(whitePen, x, y, 1, 1);
            //                        //Console.WriteLine($"Drawing white at ({x},{y})");
            //                    }
            //                    else //odd x, odd y
            //                    {
            //                        e.Graphics.DrawRectangle(blackPen, x, y, 1, 1);
            //                        //Console.WriteLine($"Drawing black at ({x},{y})");
            //                    }
            //                }
            //            }
            //        }),
            //        Task.Factory.StartNew(() =>
            //        {
            //            for (int x = (this.Width / 5) * 3; x < (this.Width / 5) * 4; x++)
            //            {
            //                for (int y =0; y < this.Height; y++)
            //                {
            //                    if (x % 2 == 0 && y % 2 == 0) //even x, even y
            //                    {
            //                        e.Graphics.DrawRectangle(blackPen, x, y, 1, 1);
            //                        //Console.WriteLine($"Drawing black at ({x},{y})");
            //                    }
            //                    else if (x % 2 == 0 && y % 2 == 1) //even x, odd y
            //                    {
            //                        e.Graphics.DrawRectangle(whitePen, x, y, 1, 1);
            //                        //Console.WriteLine($"Drawing white at ({x},{y})");
            //                    }
            //                    else if (x % 2 == 1 && y % 2 == 0) //odd x, even y
            //                    {
            //                        e.Graphics.DrawRectangle(whitePen, x, y, 1, 1);
            //                        //Console.WriteLine($"Drawing white at ({x},{y})");
            //                    }
            //                    else //odd x, odd y
            //                    {
            //                        e.Graphics.DrawRectangle(blackPen, x, y, 1, 1);
            //                        //Console.WriteLine($"Drawing black at ({x},{y})");
            //                    }
            //                }
            //            }
            //        }),
            //        Task.Factory.StartNew(() =>
            //        {
            //            for (int x = (this.Width / 5) * 4; x < (this.Width / 5) * 5; x++)
            //            {
            //                for (int y =0; y < this.Height; y++)
            //                {
            //                    if (x % 2 == 0 && y % 2 == 0) //even x, even y
            //                    {
            //                        e.Graphics.DrawRectangle(blackPen, x, y, 1, 1);
            //                        //Console.WriteLine($"Drawing black at ({x},{y})");
            //                    }
            //                    else if (x % 2 == 0 && y % 2 == 1) //even x, odd y
            //                    {
            //                        e.Graphics.DrawRectangle(whitePen, x, y, 1, 1);
            //                        //Console.WriteLine($"Drawing white at ({x},{y})");
            //                    }
            //                    else if (x % 2 == 1 && y % 2 == 0) //odd x, even y
            //                    {
            //                        e.Graphics.DrawRectangle(whitePen, x, y, 1, 1);
            //                        //Console.WriteLine($"Drawing white at ({x},{y})");
            //                    }
            //                    else //odd x, odd y
            //                    {
            //                        e.Graphics.DrawRectangle(blackPen, x, y, 1, 1);
            //                        //Console.WriteLine($"Drawing black at ({x},{y})");
            //                    }
            //                }
            //            }
            //        })
            //    };

            //    Task.WaitAll(paintTasks.ToArray());
        }
    }
}