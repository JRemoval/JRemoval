using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JRemoval
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.RunInBackground = true;

        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.RunInBackground = false;
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            label3.Text = Properties.Settings.Default.ver;
        }
    }
}
