using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JRemoval
{
    public partial class frmCleanupComputer : Form
    {
        public frmCleanupComputer()
        {
            InitializeComponent();
        }

        private void frmCleanupComputer_Load(object sender, EventArgs e)
        {

        }























        // This is the code to clean all temp folders
        private void CleanTemporaryFolders()
        {
            String tempFolder = Environment.ExpandEnvironmentVariables("%TEMP%");
            String recent = Environment.ExpandEnvironmentVariables("%USERPROFILE%") + "\\Recent";
            String prefetch = Environment.ExpandEnvironmentVariables("%SYSTEMROOT%") + "\\Prefetch";
            EmptyFolderContents(tempFolder);
            EmptyFolderContents(recent);
            EmptyFolderContents(prefetch);
        }

        private void EmptyFolderContents(string folderName)
        {
            foreach (var folder in Directory.GetDirectories(folderName))
            {
                try
                {
                    Directory.Delete(folder, true);
                }
                catch (Exception excep)
                {
                    System.Diagnostics.Debug.WriteLine(excep);
                }
            }
            foreach (var file in Directory.GetFiles(folderName))
            {
                try
                {
                    File.Delete(file);
                }
                catch (Exception excep)
                {
                    System.Diagnostics.Debug.WriteLine(excep);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CleanTemporaryFolders();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //not copied code
            try
            {
                System.Diagnostics.Process.Start("cleanmgr");
            }
            catch
            {
                MessageBox.Show("An unknown error has occurred.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
