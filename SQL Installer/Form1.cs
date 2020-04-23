using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Installer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Select Executalbe SQL Server Setup File";
            theDialog.Filter = "Executable files|*.exe";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
               
                txtSetup.Text = theDialog.FileName;  

            }
        }

        private void btnConfiguration_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Select Configuration  File";
            theDialog.Filter = "Config files|*.ini";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            { 
                txtConfiguration.Text = theDialog.FileName;
            }
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            string setupFile = txtSetup.Text ; 
            string configFile= txtConfiguration.Text;
            string command = "\"" + setupFile + "\" /ConfigurationFile=\"" + configFile+ "\"";
            //  MessageBox.Show(command); 
            createFile(command); 
        }


        private static void createFile(string Commands)
	    {
            string path= Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments);
            File.Create(path + "/sqlInstaller.bat").Close();
            File.WriteAllText(path + "/sqlInstaller.bat", Commands);
            Process.Start(path + "/sqlInstaller.bat");
        }

        private void configurationGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string setupFile = txtSetup.Text;
            string configFile = txtConfiguration.Text;
            string command = "\"" + setupFile + "\"  /UIMODE=Normal /ACTION=INSTALL";
            //  MessageBox.Show(command); 
            createFile(command);
            
        }

        private void deployDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
        }
 
    }
}
