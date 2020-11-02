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
            label2.Text = "Current User: " +  userName;

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
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            if (lblBatteryPercent.Text.Contains("30"))
            {
                notifyIcon2.ShowBalloonTip(1000);

            }
        }
        




    }
}
