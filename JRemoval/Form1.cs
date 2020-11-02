using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using ezPC;
using System.Management;
using JRemoval.Properties;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace JRemoval
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string userName = Environment.UserName;
            label2.Text = "User Signed In: " + userName;
            PowerStatus status = SystemInformation.PowerStatus;
            lblBatteryPercent.Text = status.BatteryLifePercent.ToString("P0");
            if (lblBatteryPercent.Text.Contains("30"))
            {
                notifyIcon2.ShowBalloonTip(1000);
            }
        }
        private void metroTile1_Click(object sender, EventArgs e)
        {
            var CleanPC = new frmCleanupComputer();
            CleanPC.Show();
        }
        private void metroTile2_Click(object sender, EventArgs e)
        {

        }

        // Sidebar Runs Start
        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("control", "powercfg.cpl");
            }
            catch
            {
                MessageBox.Show("An unknown error has occurred.");
            }
        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("control", "sysdm.cpl");
            }
            catch
            {
                MessageBox.Show("An unknown error has occurred.");
            }
        }
        private void lblBatteryPercent_Click(object sender, EventArgs e)
        {
        }
        // Sidebar Runs End


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var Settings = new frmSettings();
            Settings.Show();
        }

        //Code to hide to tray start
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RunInBackground == true)
            {
                notifyIcon1.ShowBalloonTip(1000);
                this.Visible = false;
            }
            else
            {
                this.Close();
            }
            //This will make it so it will hide to tray. Obviously since people do not want it to ALWAYS hide, it can be changed via Settings
        }



        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }
        //Code to hide to tray end




                             // Thank you wpf man
        internal static class Program
        {
            [STAThread]
            private static void Main2()
            {
                if (Environment.OSVersion.Version.Major >= 6)
                    SetProcessDPIAware();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }

            [DllImport("user32.dll", SetLastError = true)]
            private static extern bool SetProcessDPIAware();
        }
                              // Thank you wpf man

    }


}
