using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Login_Form
{
    public partial class LoginTwitter : Form
    {
        public LoginTwitter()
        {
            InitializeComponent();

            int borderRadius = 7;
            Region = Region.FromHrgn(NativeMethods.CreateRoundRectRgn(0, 0, Width, Height, borderRadius, borderRadius));

            label1.Text = battery_level();
            vaqt.Text = clock_find();
        }

        public static class NativeMethods
        {
            [System.Runtime.InteropServices.DllImport("gdi32.dll")]
            public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        public string clock_find()
        {
            DateTime currentTime = DateTime.Now;
            return currentTime.ToString("HH:mm");
        }

        public string battery_level()
        {
            PowerStatus powerStatus = SystemInformation.PowerStatus;
            float batteryLevel = powerStatus.BatteryLifePercent;
            return batteryLevel.ToString("0%");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void exit()
        {
            this.Close();

            Form MainPage = new Form1();
            MainPage.ShowDialog();

            MainPage = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            exit();
        }
    }
}
