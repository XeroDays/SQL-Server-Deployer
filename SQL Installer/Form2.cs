using SQL_Installer.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Installer
{
    public partial class Form2 : Form
    {
        List<string> conLinks;
        bool islinkFound=false;

        public Form2()
        {
            InitializeComponent();
            conLinks = new List<string>();
            string conn = "";
           
            conn= "Data Source=" + sysController.getPCName() + "\\SQLEXPRESS;Initial Catalog=;Integrated Security=true";
            conLinks.Add(conn);
            conn = "Integrated Security=SSPI;" + "Initial Catalog=" + ";" + "Data Source=localhost;";
            conLinks.Add(conn);
            conn = "Integrated Security=True;" + "Initial Catalog=Master;" + "Data Source=localhost;";
            conLinks.Add(conn);
            conn = "Integrated Security=True;" + "Initial Catalog=;" + "Data Source=./;";
            conLinks.Add(conn);
            conn = "Integrated Security=True;" + "Initial Catalog=;" + "Data Source=127.0.0.1;";
            conLinks.Add(conn);
            conn = "Integrated Security=True;" + "Initial Catalog=master;" + "Data Source=./;";
            conLinks.Add(conn); 
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Select Executalbe SQL Server Text File";
            theDialog.Filter = "text files|*.txt";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            { 
                txtSQLtxtFile.Text = theDialog.FileName; 
            }
        }
         
        private string GetDbCreationQuery()
        {
            // your db name
            string dbName = Path.GetFileNameWithoutExtension(txtSQLtxtFile.Text);

            // path to your db files:
            // ensure that the directory exists and you have read write permission.
            string[] files = { Path.Combine(txtStoreDatabaseIn.Text, dbName + ".mdf"),
                       Path.Combine(txtStoreDatabaseIn.Text, dbName + "_log.ldf") };

            string query = "CREATE DATABASE "+dbName+" ON PRIMARY"
            + "(Name="+dbName+"_data, filename = '"+files[0]+"', size=3,"
            + "maxsize=5, filegrowth=10%)log on"
            + "(name="+dbName+ "_log, filename='" + files[1] + "',size=3,"
            + "maxsize=20,filegrowth=1)";

            // db creation query:
            // note that the data file and log file have different logical names
            ////   string query = "CREATE DATABASE "+dbName+" ON PRIMARY " +
            //           "(NAME = "+dbName+", " +
            //           "FILENAME = '"+files[0]+"', " +
            //           "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%) " +
            //           "LOG ON (NAME = "+dbName+", " +
            //           "FILENAME = '"+files[1]+"', " +
            //           "SIZE = 3MB, " +
            //           "MAXSIZE = 5MB, " +
            //           "FILEGROWTH = 10%)";

            return query;
        }
         
        private void Form2_Load(object sender, EventArgs e)
        { 
             txtConnectingString.Text = "Integrated Security=SSPI;" +"Initial Catalog=;" +"Data Source=localhost;";
        }
                
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var dialog = new System.Windows.Forms.FolderBrowserDialog())
            { 
                System.Windows.Forms.DialogResult result = dialog.ShowDialog(); 
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    txtStoreDatabaseIn.Text = dialog.SelectedPath;
                } 
            }
        }

        private async void btnFindConn_Click(object sender, EventArgs e)
        { 
            bool conn = false;
            conLinks.Add(txtConnectingString.Text);
            foreach (string link in conLinks)
            {
                conn = await checkConnections(link);

                if (conn)
                { 
                    txtConnectingString.Text = link;
                    txtConnectingString.Enabled = false;
                    islinkFound = true;
                    break;
                }
            }
            if (!conn)
            {
                MessageBox.Show("Error: Link not Found!");
                txtConnectingString.Text = "";
            }

        }

        private Task<bool> checkConnections(string conLink)
	    {
            TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>();
            Task.Run(()=> {
                dbServer dbServer = new dbServer(conLink);
                bool conn =    dbServer.checkConnectionSync();
                taskCompletionSource.SetResult(conn);
            }); 
            return taskCompletionSource.Task;
        }

        private void btnDeploydb_Click(object sender, EventArgs e)
        {
            //btnFindConn.PerformClick();
            if (islinkFound)
            { 
                dbServer dbServer = new dbServer(txtConnectingString.Text); 
                dbServer.executeStoreProcedure(GetDbCreationQuery()); 
                string dbName = Path.GetFileNameWithoutExtension(txtSQLtxtFile.Text);

                string[] conParts = txtConnectingString.Text.Split(';');
                string connLink = "";
                foreach (var part in conParts)
                {
                    if (part.Contains("Initial"))
                    {
                        connLink += "Initial Catalog=" + dbName;
                    }
                    else
                    {
                        connLink += part;
                    }
                    connLink += ";";
                } 
                dbServer = new dbServer(connLink);
                string[] data = File.ReadAllLines(txtSQLtxtFile.Text);
                List<string> quries = sysController.getQueriesFromSQLFile(data);
                foreach (string command in quries)
                {
                    dbServer.executeStoreProcedure(command);
                }

                Clipboard.SetText(connLink);
                MessageBox.Show("Database Succesfully Deployed! \n And Connection String copied to Clipboard");
            }
            else
            {
                MessageBox.Show("Link not Found! Please wait until Possible link to database in found!");
                btnFindConn.PerformClick();
            }
        }
    }
}
