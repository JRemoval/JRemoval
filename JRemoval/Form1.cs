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
using ezPC.Logging;
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
                notifyIcon2.Visible = true;
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
            Logger.Log("Test");
           
        }

        private void tileSystemStatus_Click(object sender, EventArgs e)
        {
            var SystemStatus = new frmSystemStatus();
            SystemStatus.Show();
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

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("cleanmgr");
            }
            catch
            {
                MessageBox.Show("An unknown error has occurred.");
            }
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("dfrgui");
            }
            catch
            {
                MessageBox.Show("An unknown error has occurred.");
            }
        }

        private void lblBatteryPercent_Click(object sender, EventArgs e)
        {
        }
  


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var Settings = new frmSettings();
            Settings.Show();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RunInBackground == true)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
                this.Visible = false;
            }
            else
            {
                this.Close();
            }
            //This will make it so it will hide to tray. Obviously since people do not want it to ALWAYS hide, it can be changed via Settings
        }
        private void quitJRemovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Code to hide to tray end
     

    }


}
