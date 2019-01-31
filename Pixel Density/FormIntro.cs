using System;
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
    }
}
