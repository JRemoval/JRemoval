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
    public partial class frmSystemStatus : Form
    {
        public frmSystemStatus()
        {
            InitializeComponent();
        }

        private void btnChangePCName_Click(object sender, EventArgs e)
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

        private void frmSystemStatus_Load(object sender, EventArgs e)
        {

        }
    }
}
