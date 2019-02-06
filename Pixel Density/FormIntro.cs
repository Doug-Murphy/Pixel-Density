using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pixel_Density
{
    public partial class FormIntro : Form
    {
        public FormIntro()
        {
            InitializeComponent();
        }

        private void btnLoadGridForm_Click(object sender, EventArgs e)
        {
            new FormDensity().Show();
        }

        private void FormIntro_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }
    }
}
