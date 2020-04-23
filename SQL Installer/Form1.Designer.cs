namespace SQL_Installer
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSetup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configurationGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtConfiguration = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSetup = new System.Windows.Forms.Button();
            this.btnConfiguration = new System.Windows.Forms.Button();
            this.btnInstall = new System.Windows.Forms.Button();
            this.deployDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal SQL Installer";
            // 
            // txtSetup
            // 
            this.txtSetup.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetup.Location = new System.Drawing.Point(26, 127);
            this.txtSetup.Name = "txtSetup";
            this.txtSetup.Size = new System.Drawing.Size(445, 22);
            this.txtSetup.TabIndex = 1;
            this.txtSetup.Text = " ";
        //    this.txtSetup.TextChanged += new System.EventHandler(this.txtSetup_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Setup Path";
           // this.label2.Click += new System.EventHandler(this.//label2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationGeneratorToolStripMenuItem,
            this.deployDatabaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(483, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configurationGeneratorToolStripMenuItem
            // 
            this.configurationGeneratorToolStripMenuItem.Name = "configurationGeneratorToolStripMenuItem";
            this.configurationGeneratorToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.configurationGeneratorToolStripMenuItem.Text = "Configuration Generator";
            this.configurationGeneratorToolStripMenuItem.Click += new System.EventHandler(this.configurationGeneratorToolStripMenuItem_Click);
            // 
            // txtConfiguration
            // 
            this.txtConfiguration.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfiguration.Location = new System.Drawing.Point(26, 205);
            this.txtConfiguration.Name = "txtConfiguration";
            this.txtConfiguration.Size = new System.Drawing.Size(445, 22);
            this.txtConfiguration.TabIndex = 1;
            this.txtConfiguration.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Configuration File";
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(396, 155);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(75, 23);
            this.btnSetup.TabIndex = 4;
            this.btnSetup.Text = "Browse";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // btnConfiguration
            // 
            this.btnConfiguration.Location = new System.Drawing.Point(396, 233);
            this.btnConfiguration.Name = "btnConfiguration";
            this.btnConfiguration.Size = new System.Drawing.Size(75, 23);
            this.btnConfiguration.TabIndex = 4;
            this.btnConfiguration.Text = "Browse";
            this.btnConfiguration.UseVisualStyleBackColor = true;
            this.btnConfiguration.Click += new System.EventHandler(this.btnConfiguration_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstall.Location = new System.Drawing.Point(26, 273);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(445, 32);
            this.btnInstall.TabIndex = 5;
            this.btnInstall.Text = "Initiate installer";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // deployDatabaseToolStripMenuItem
            // 
            this.deployDatabaseToolStripMenuItem.Name = "deployDatabaseToolStripMenuItem";
            this.deployDatabaseToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.deployDatabaseToolStripMenuItem.Text = "Deploy Database";
            this.deployDatabaseToolStripMenuItem.Click += new System.EventHandler(this.deployDatabaseToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 317);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.btnConfiguration);
            this.Controls.Add(this.btnSetup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConfiguration);
            this.Controls.Add(this.txtSetup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSetup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configurationGeneratorToolStripMenuItem;
        private System.Windows.Forms.TextBox txtConfiguration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Button btnConfiguration;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.ToolStripMenuItem deployDatabaseToolStripMenuItem;
    }
}

