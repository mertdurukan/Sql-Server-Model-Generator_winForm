namespace SqlModelGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboDb = new System.Windows.Forms.ComboBox();
            this.comboTable = new System.Windows.Forms.ComboBox();
            this.lblDb = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.textBoxCsharp = new System.Windows.Forms.TextBox();
            this.btnForSelectedTable = new System.Windows.Forms.Button();
            this.pictureDb = new System.Windows.Forms.PictureBox();
            this.pictureTable = new System.Windows.Forms.PictureBox();
            this.btnForSelectedDatabase = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCsharp = new System.Windows.Forms.TabPage();
            this.labelUserGuide = new System.Windows.Forms.Label();
            this.labelUpdateHistory = new System.Windows.Forms.Label();
            this.tabPageFlutter = new System.Windows.Forms.TabPage();
            this.textBoxFlutter = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboFilePrefences = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxConnectAnotherServer = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxServerIP = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.comboLogin = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonWindowsAuth = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonSqlServerAuth = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxUserGuide = new System.Windows.Forms.PictureBox();
            this.pictureBoxRelease = new System.Windows.Forms.PictureBox();
            this.textBoxNamespace = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTable)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageCsharp.SuspendLayout();
            this.tabPageFlutter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserGuide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRelease)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboDb
            // 
            this.comboDb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboDb.FormattingEnabled = true;
            this.comboDb.Location = new System.Drawing.Point(16, 50);
            this.comboDb.Name = "comboDb";
            this.comboDb.Size = new System.Drawing.Size(234, 23);
            this.comboDb.TabIndex = 7;
            this.comboDb.SelectedIndexChanged += new System.EventHandler(this.dbCombo_SelectedIndexChanged);
            // 
            // comboTable
            // 
            this.comboTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboTable.FormattingEnabled = true;
            this.comboTable.Location = new System.Drawing.Point(16, 111);
            this.comboTable.Name = "comboTable";
            this.comboTable.Size = new System.Drawing.Size(234, 23);
            this.comboTable.TabIndex = 8;
            this.comboTable.SelectedIndexChanged += new System.EventHandler(this.tableCombo_SelectedIndexChanged);
            // 
            // lblDb
            // 
            this.lblDb.AutoSize = true;
            this.lblDb.Location = new System.Drawing.Point(16, 32);
            this.lblDb.Name = "lblDb";
            this.lblDb.Size = new System.Drawing.Size(55, 15);
            this.lblDb.TabIndex = 3;
            this.lblDb.Text = "Database";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(16, 93);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(34, 15);
            this.lblTable.TabIndex = 4;
            this.lblTable.Text = "Table";
            // 
            // textBoxCsharp
            // 
            this.textBoxCsharp.Location = new System.Drawing.Point(-4, 0);
            this.textBoxCsharp.Multiline = true;
            this.textBoxCsharp.Name = "textBoxCsharp";
            this.textBoxCsharp.Size = new System.Drawing.Size(623, 317);
            this.textBoxCsharp.TabIndex = 7;
            // 
            // btnForSelectedTable
            // 
            this.btnForSelectedTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnForSelectedTable.Location = new System.Drawing.Point(20, 104);
            this.btnForSelectedTable.Name = "btnForSelectedTable";
            this.btnForSelectedTable.Size = new System.Drawing.Size(108, 41);
            this.btnForSelectedTable.TabIndex = 9;
            this.btnForSelectedTable.Text = "Selected Table";
            this.btnForSelectedTable.UseVisualStyleBackColor = true;
            this.btnForSelectedTable.Click += new System.EventHandler(this.btnForSelectedTable_Click);
            // 
            // pictureDb
            // 
            this.pictureDb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureDb.Image = ((System.Drawing.Image)(resources.GetObject("pictureDb.Image")));
            this.pictureDb.Location = new System.Drawing.Point(256, 48);
            this.pictureDb.Name = "pictureDb";
            this.pictureDb.Size = new System.Drawing.Size(26, 25);
            this.pictureDb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureDb.TabIndex = 11;
            this.pictureDb.TabStop = false;
            this.pictureDb.Visible = false;
            // 
            // pictureTable
            // 
            this.pictureTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureTable.Image = ((System.Drawing.Image)(resources.GetObject("pictureTable.Image")));
            this.pictureTable.Location = new System.Drawing.Point(256, 109);
            this.pictureTable.Name = "pictureTable";
            this.pictureTable.Size = new System.Drawing.Size(26, 25);
            this.pictureTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureTable.TabIndex = 12;
            this.pictureTable.TabStop = false;
            this.pictureTable.Visible = false;
            // 
            // btnForSelectedDatabase
            // 
            this.btnForSelectedDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnForSelectedDatabase.Location = new System.Drawing.Point(134, 104);
            this.btnForSelectedDatabase.Name = "btnForSelectedDatabase";
            this.btnForSelectedDatabase.Size = new System.Drawing.Size(108, 41);
            this.btnForSelectedDatabase.TabIndex = 10;
            this.btnForSelectedDatabase.Text = "All table for selected database";
            this.btnForSelectedDatabase.UseVisualStyleBackColor = true;
            this.btnForSelectedDatabase.Click += new System.EventHandler(this.btnForSelectedDatabase_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCsharp);
            this.tabControl1.Controls.Add(this.tabPageFlutter);
            this.tabControl1.Location = new System.Drawing.Point(4, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(623, 341);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPageCsharp
            // 
            this.tabPageCsharp.Controls.Add(this.labelUserGuide);
            this.tabPageCsharp.Controls.Add(this.labelUpdateHistory);
            this.tabPageCsharp.Controls.Add(this.textBoxCsharp);
            this.tabPageCsharp.Location = new System.Drawing.Point(4, 24);
            this.tabPageCsharp.Name = "tabPageCsharp";
            this.tabPageCsharp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCsharp.Size = new System.Drawing.Size(615, 313);
            this.tabPageCsharp.TabIndex = 0;
            this.tabPageCsharp.Text = "C# Model";
            this.tabPageCsharp.UseVisualStyleBackColor = true;
            // 
            // labelUserGuide
            // 
            this.labelUserGuide.AutoSize = true;
            this.labelUserGuide.Location = new System.Drawing.Point(550, 297);
            this.labelUserGuide.Name = "labelUserGuide";
            this.labelUserGuide.Size = new System.Drawing.Size(64, 15);
            this.labelUserGuide.TabIndex = 25;
            this.labelUserGuide.Text = "User Guide";
            this.labelUserGuide.Visible = false;
            // 
            // labelUpdateHistory
            // 
            this.labelUpdateHistory.AutoSize = true;
            this.labelUpdateHistory.Location = new System.Drawing.Point(499, 297);
            this.labelUpdateHistory.Name = "labelUpdateHistory";
            this.labelUpdateHistory.Size = new System.Drawing.Size(86, 15);
            this.labelUpdateHistory.TabIndex = 24;
            this.labelUpdateHistory.Text = "Update History";
            this.labelUpdateHistory.Visible = false;
            // 
            // tabPageFlutter
            // 
            this.tabPageFlutter.Controls.Add(this.textBoxFlutter);
            this.tabPageFlutter.Location = new System.Drawing.Point(4, 24);
            this.tabPageFlutter.Name = "tabPageFlutter";
            this.tabPageFlutter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFlutter.Size = new System.Drawing.Size(615, 313);
            this.tabPageFlutter.TabIndex = 1;
            this.tabPageFlutter.Text = "Flutter Model";
            this.tabPageFlutter.UseVisualStyleBackColor = true;
            // 
            // textBoxFlutter
            // 
            this.textBoxFlutter.Location = new System.Drawing.Point(-4, 0);
            this.textBoxFlutter.Multiline = true;
            this.textBoxFlutter.Name = "textBoxFlutter";
            this.textBoxFlutter.Size = new System.Drawing.Size(623, 317);
            this.textBoxFlutter.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboFilePrefences);
            this.groupBox1.Controls.Add(this.btnForSelectedTable);
            this.groupBox1.Controls.Add(this.btnForSelectedDatabase);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(385, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 165);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Write the file on desktop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Flutter , C# or Both";
            // 
            // comboFilePrefences
            // 
            this.comboFilePrefences.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboFilePrefences.FormattingEnabled = true;
            this.comboFilePrefences.Items.AddRange(new object[] {
            "Both",
            "Flutter",
            "C#"});
            this.comboFilePrefences.Location = new System.Drawing.Point(20, 50);
            this.comboFilePrefences.Name = "comboFilePrefences";
            this.comboFilePrefences.Size = new System.Drawing.Size(222, 23);
            this.comboFilePrefences.TabIndex = 6;
            this.comboFilePrefences.SelectedIndexChanged += new System.EventHandler(this.comboFilePrefences_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDb);
            this.groupBox2.Controls.Add(this.comboDb);
            this.groupBox2.Controls.Add(this.comboTable);
            this.groupBox2.Controls.Add(this.lblTable);
            this.groupBox2.Controls.Add(this.pictureTable);
            this.groupBox2.Controls.Add(this.pictureDb);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(15, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 165);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Database and table selection area";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tabControl1);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Location = new System.Drawing.Point(15, 425);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(629, 370);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "If you have created model file use this screen.";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxConnectAnotherServer);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBoxServerIP);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox4.Location = new System.Drawing.Point(15, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(259, 126);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Server";
            // 
            // checkBoxConnectAnotherServer
            // 
            this.checkBoxConnectAnotherServer.AutoSize = true;
            this.checkBoxConnectAnotherServer.Location = new System.Drawing.Point(16, 21);
            this.checkBoxConnectAnotherServer.Name = "checkBoxConnectAnotherServer";
            this.checkBoxConnectAnotherServer.Size = new System.Drawing.Size(225, 19);
            this.checkBoxConnectAnotherServer.TabIndex = 0;
            this.checkBoxConnectAnotherServer.Text = "Connect to another server (!localhost)";
            this.checkBoxConnectAnotherServer.UseVisualStyleBackColor = true;
            this.checkBoxConnectAnotherServer.CheckedChanged += new System.EventHandler(this.checkBoxConnectAnotherServer_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Server IP";
            // 
            // textBoxServerIP
            // 
            this.textBoxServerIP.Enabled = false;
            this.textBoxServerIP.Location = new System.Drawing.Point(16, 67);
            this.textBoxServerIP.Name = "textBoxServerIP";
            this.textBoxServerIP.PlaceholderText = "127.0.0.1";
            this.textBoxServerIP.Size = new System.Drawing.Size(163, 23);
            this.textBoxServerIP.TabIndex = 1;
            this.textBoxServerIP.TextChanged += new System.EventHandler(this.textBoxServerIP_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Enabled = false;
            this.textBoxPassword.ForeColor = System.Drawing.Color.Red;
            this.textBoxPassword.Location = new System.Drawing.Point(181, 72);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(158, 23);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // comboLogin
            // 
            this.comboLogin.Enabled = false;
            this.comboLogin.ForeColor = System.Drawing.Color.Red;
            this.comboLogin.FormattingEnabled = true;
            this.comboLogin.Location = new System.Drawing.Point(15, 72);
            this.comboLogin.Name = "comboLogin";
            this.comboLogin.Size = new System.Drawing.Size(156, 23);
            this.comboLogin.TabIndex = 4;
            this.comboLogin.SelectedIndexChanged += new System.EventHandler(this.comboLogin_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // radioButtonWindowsAuth
            // 
            this.radioButtonWindowsAuth.AutoSize = true;
            this.radioButtonWindowsAuth.Checked = true;
            this.radioButtonWindowsAuth.Location = new System.Drawing.Point(15, 25);
            this.radioButtonWindowsAuth.Name = "radioButtonWindowsAuth";
            this.radioButtonWindowsAuth.Size = new System.Drawing.Size(156, 19);
            this.radioButtonWindowsAuth.TabIndex = 2;
            this.radioButtonWindowsAuth.TabStop = true;
            this.radioButtonWindowsAuth.Text = "Windows Authentication";
            this.radioButtonWindowsAuth.UseVisualStyleBackColor = true;
            this.radioButtonWindowsAuth.Click += new System.EventHandler(this.radioButtonWindowsAuth_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // radioButtonSqlServerAuth
            // 
            this.radioButtonSqlServerAuth.AutoSize = true;
            this.radioButtonSqlServerAuth.Location = new System.Drawing.Point(181, 25);
            this.radioButtonSqlServerAuth.Name = "radioButtonSqlServerAuth";
            this.radioButtonSqlServerAuth.Size = new System.Drawing.Size(158, 19);
            this.radioButtonSqlServerAuth.TabIndex = 3;
            this.radioButtonSqlServerAuth.TabStop = true;
            this.radioButtonSqlServerAuth.Text = "Sql Server Authentication";
            this.radioButtonSqlServerAuth.UseVisualStyleBackColor = true;
            this.radioButtonSqlServerAuth.Click += new System.EventHandler(this.radioButtonSqlServerAuth_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Controls.Add(this.textBoxPassword);
            this.groupBox5.Controls.Add(this.radioButtonWindowsAuth);
            this.groupBox5.Controls.Add(this.radioButtonSqlServerAuth);
            this.groupBox5.Controls.Add(this.comboLogin);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox5.Location = new System.Drawing.Point(292, 14);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(352, 126);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Login Authentication";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(238, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // pictureBoxUserGuide
            // 
            this.pictureBoxUserGuide.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxUserGuide.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUserGuide.Image")));
            this.pictureBoxUserGuide.Location = new System.Drawing.Point(591, 797);
            this.pictureBoxUserGuide.Name = "pictureBoxUserGuide";
            this.pictureBoxUserGuide.Size = new System.Drawing.Size(28, 28);
            this.pictureBoxUserGuide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUserGuide.TabIndex = 21;
            this.pictureBoxUserGuide.TabStop = false;
            this.pictureBoxUserGuide.Click += new System.EventHandler(this.pictureBoxUserGuide_Click);
            this.pictureBoxUserGuide.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBoxUserGuide.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // pictureBoxRelease
            // 
            this.pictureBoxRelease.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRelease.Image")));
            this.pictureBoxRelease.Location = new System.Drawing.Point(548, 797);
            this.pictureBoxRelease.Name = "pictureBoxRelease";
            this.pictureBoxRelease.Size = new System.Drawing.Size(28, 28);
            this.pictureBoxRelease.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRelease.TabIndex = 23;
            this.pictureBoxRelease.TabStop = false;
            this.pictureBoxRelease.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBoxRelease.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave_1);
            this.pictureBoxRelease.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover_1);
            // 
            // textBoxNamespace
            // 
            this.textBoxNamespace.Location = new System.Drawing.Point(91, 18);
            this.textBoxNamespace.Name = "textBoxNamespace";
            this.textBoxNamespace.Size = new System.Drawing.Size(532, 23);
            this.textBoxNamespace.TabIndex = 24;
            this.textBoxNamespace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNamespace.TextChanged += new System.EventHandler(this.textBoxNamespace_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Namespace";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.textBoxNamespace);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Location = new System.Drawing.Point(15, 337);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(629, 67);
            this.groupBox6.TabIndex = 27;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "( Optional )";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(292, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "projectname.foldername";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 834);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.pictureBoxRelease);
            this.Controls.Add(this.pictureBoxUserGuide);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sql Server Model Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureDb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTable)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageCsharp.ResumeLayout(false);
            this.tabPageCsharp.PerformLayout();
            this.tabPageFlutter.ResumeLayout(false);
            this.tabPageFlutter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserGuide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRelease)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox comboDb;
        private ComboBox comboTable;
        private Label lblDb;
        private Label lblTable;
        private TextBox textBoxCsharp;
        private Button btnForSelectedTable;
        private PictureBox pictureDb;
        private PictureBox pictureTable;
        private Button btnForSelectedDatabase;
        private TabControl tabControl1;
        private TabPage tabPageCsharp;
        private TabPage tabPageFlutter;
        private TextBox textBoxFlutter;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ComboBox comboFilePrefences;
        private Label label2;
        private GroupBox groupBox4;
        private TextBox textBoxPassword;
        private ComboBox comboLogin;
        private Label label3;
        private Label label1;
        private RadioButton radioButtonSqlServerAuth;
        private RadioButton radioButtonWindowsAuth;
        private Label label4;
        private TextBox textBoxServerIP;
        private CheckBox checkBoxConnectAnotherServer;
        private GroupBox groupBox5;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxUserGuide;
        private PictureBox pictureBoxRelease;
        private Label labelUpdateHistory;
        private Label labelUserGuide;
        private TextBox textBoxNamespace;
        private Label label5;
        private GroupBox groupBox6;
        private Label label6;
    }
}