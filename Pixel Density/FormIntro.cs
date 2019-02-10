using Microsoft.Win32;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Pixel_Density
{
    public partial class FormIntro : Form
    {
        [DllImport("gdi32.dll")]
        static extern int GetDeviceCaps(IntPtr hdc, int nIndex);

        [DllImport("gdi32.dll")]
        static extern IntPtr CreateDC(string lpszDriver, string lpszDevice, string lpszOutput, IntPtr lpInitData);

        private int _previousScreenIndex;
        private int _currentScreenIndex;

        private bool ScreenChanged()
        {
            _currentScreenIndex = Array.IndexOf(Screen.AllScreens, Screen.FromControl(this));

            if (_currentScreenIndex != _previousScreenIndex)
            {
                _previousScreenIndex = _currentScreenIndex;
                return true;
            }

            return false;
        }

        public FormIntro()
        {
            InitializeComponent();
        }

        private void btnLoadGridForm_Click(object sender, EventArgs e)
        {
            var startX = Screen.FromControl(this).Bounds.Left;
            var startY = Screen.FromControl(this).Bounds.Top;
            new FormDensity(startX, startY).Show();
        }

        public void SystemEvents_DisplaySettingsChanged(object sender, EventArgs e)
        {
            CalculatePPI();
        }

        private void FormIntro_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            SystemEvents.DisplaySettingsChanged += new EventHandler(SystemEvents_DisplaySettingsChanged);
            CalculatePPI();
        }

        private void FormIntro_Move(object sender, EventArgs e)
        {
            if (ScreenChanged())
            {
                CalculatePPI();
            }
        }

        private void CalculatePPI()
        {
            const int HORZSIZE = 4;
            const int VERTSIZE = 6;
            const double MM_TO_INCH_CONVERSION_FACTOR = 25.4;

            var hDC = Graphics.FromHdc(CreateDC(null, Screen.FromHandle(this.Handle).DeviceName, null, IntPtr.Zero)).GetHdc();
            var horizontalSizeInInches = GetDeviceCaps(hDC, HORZSIZE) / MM_TO_INCH_CONVERSION_FACTOR;
            var verticalSizeInInches = GetDeviceCaps(hDC, VERTSIZE) / MM_TO_INCH_CONVERSION_FACTOR;
            var diagonalSizeInInches = Math.Sqrt(Math.Pow(horizontalSizeInInches, 2) + Math.Pow(verticalSizeInInches, 2));

            var resX = Screen.FromControl(this).Bounds.Width;
            var resY = Screen.FromControl(this).Bounds.Height;
            var pixelDensityPPI = Math.Sqrt(Math.Pow(resX, 2) + Math.Pow(resY, 2)) / diagonalSizeInInches;

            lblMoniHeight.Text = $"Physical Height (in): {verticalSizeInInches:N2}";
            lblMoniWidth.Text = $"Physical Width (in): {horizontalSizeInInches:N2}";
            lblMoniDiagonal.Text = $"Physical Diagonal (in): {diagonalSizeInInches:N2}";
            lblMoniResX.Text = $"Resolution Width (px): {resX:N0}";
            lblMoniResY.Text = $"Resolution Height (px): {resY:N0}";
            lblMoniPPI.Text = $"Density (ppi): {pixelDensityPPI:N0}";
        }
    }
}
