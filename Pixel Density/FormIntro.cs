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
            new FormDensity().Show();
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

            Console.WriteLine($"DeviceName = {Screen.FromHandle(this.Handle).DeviceName}");
            var hDC = Graphics.FromHwnd(this.Handle).GetHdc();
            var horizontalSizeInMilliMeters = GetDeviceCaps(hDC, HORZSIZE);
            var verticalSizeInMilliMeters = GetDeviceCaps(hDC, VERTSIZE);

            var horizontalSizeInInches = horizontalSizeInMilliMeters / MM_TO_INCH_CONVERSION_FACTOR;
            var verticalSizeInInches = verticalSizeInMilliMeters / MM_TO_INCH_CONVERSION_FACTOR;
            var diagonalSizeInInches = Math.Sqrt(Math.Pow(horizontalSizeInInches, 2) + Math.Pow(verticalSizeInInches, 2));

            var screenHeight = Screen.FromControl(this).Bounds.Height;
            var screenWidth = Screen.FromControl(this).Bounds.Width;

            Console.WriteLine($"screenHeight = {screenHeight}. screenWidth = {screenWidth}");

            var pixelDensityPPI = Math.Sqrt(Math.Pow(screenWidth, 2) + Math.Pow(screenHeight, 2)) / diagonalSizeInInches;

            lblPPI.Text = $"Current Monitor's PPI: {pixelDensityPPI}";
            Console.WriteLine($"Horizontal Inches = {horizontalSizeInInches}. Vertical Inches = {verticalSizeInInches}. Diagonal Inches = {diagonalSizeInInches}. Pixel Density (PPI) = {pixelDensityPPI}");
        }
    }
}
