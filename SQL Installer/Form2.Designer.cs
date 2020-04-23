namespace SQL_Installer
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSetup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSQLtxtFile = new System.Windows.Forms.TextBox();
            this.btnDeploydb = new System.Windows.Forms.Button();
            this.txtConnectingString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStoreDatabaseIn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnFindConn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(411, 166);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(75, 23);
            this.btnSetup.TabIndex = 7;
            this.btnSetup.Text = "Browse";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "SQL txt File";
            // 
            // txtSQLtxtFile
            // 
            this.txtSQLtxtFile.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSQLtxtFile.Location = new System.Drawing.Point(41, 138);
            this.txtSQLtxtFile.Name = "txtSQLtxtFile";
            this.txtSQLtxtFile.Size = new System.Drawing.Size(445, 22);
            this.txtSQLtxtFile.TabIndex = 5;
            this.txtSQLtxtFile.Text = "C:\\Users\\Wizard\\Desktop\\tree.txt";
            // 
            // btnDeploydb
            // 
            this.btnDeploydb.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeploydb.Location = new System.Drawing.Point(320, 271);
            this.btnDeploydb.Name = "btnDeploydb";
            this.btnDeploydb.Size = new System.Drawing.Size(274, 57);
            this.btnDeploydb.TabIndex = 7;
            this.btnDeploydb.Text = "Deploy Database";
            this.btnDeploydb.UseVisualStyleBackColor = true;
            this.btnDeploydb.Click += new System.EventHandler(this.btnDeploydb_Click);
            // 
            // txtConnectingString
            // 
            this.txtConnectingString.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConnectingString.Location = new System.Drawing.Point(41, 49);
            this.txtConnectingString.Name = "txtConnectingString";
            this.txtConnectingString.Size = new System.Drawing.Size(445, 22);
            this.txtConnectingString.TabIndex = 5;
            this.txtConnectingString.Text = "Integrated Security=SSPI;Initial Catalog=;Data Source=localhost;";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Connecting String";
            // 
            // txtStoreDatabaseIn
            // 
            this.txtStoreDatabaseIn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStoreDatabaseIn.Location = new System.Drawing.Point(41, 195);
            this.txtStoreDatabaseIn.Name = "txtStoreDatabaseIn";
            this.txtStoreDatabaseIn.Size = new System.Drawing.Size(445, 22);
            this.txtStoreDatabaseIn.TabIndex = 5;
            this.txtStoreDatabaseIn.Text = "C:\\Temp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stroe Database File In";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(411, 223);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnFindConn
            // 
            this.btnFindConn.Location = new System.Drawing.Point(492, 35);
            this.btnFindConn.Name = "btnFindConn";
            this.btnFindConn.Size = new System.Drawing.Size(102, 47);
            this.btnFindConn.TabIndex = 8;
            this.btnFindConn.Text = "Auto Find Connections";
            this.btnFindConn.UseVisualStyleBackColor = true;
            this.btnFindConn.Click += new System.EventHandler(this.btnFindConn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 350);
            this.Controls.Add(this.btnFindConn);
            this.Controls.Add(this.btnDeploydb);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnSetup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConnectingString);
            this.Controls.Add(this.txtStoreDatabaseIn);
            this.Controls.Add(this.txtSQLtxtFile);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSQLtxtFile;
        private System.Windows.Forms.Button btnDeploydb;
        private System.Windows.Forms.TextBox txtConnectingString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStoreDatabaseIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnFindConn;
    }
}