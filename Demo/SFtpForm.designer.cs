namespace Demo
{
    partial class SFtpForm
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
            this.ctlPassword = new System.Windows.Forms.TextBox();
            this.ctlUsername = new System.Windows.Forms.TextBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.ctlProtocolError = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ctlLogfile = new System.Windows.Forms.TextBox();
            this.ctlResult = new System.Windows.Forms.TextBox();
            this.ctlView = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.ctlPort = new System.Windows.Forms.TextBox();
            this.ctlHost = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ctlAcceptKey = new System.Windows.Forms.CheckBox();
            this.ctlBrowse = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ctlKeyFile = new System.Windows.Forms.TextBox();
            this.ctlDisconnect = new System.Windows.Forms.Button();
            this.ctlConnect = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.ctlCwd = new System.Windows.Forms.TextBox();
            this.ctlDelete = new System.Windows.Forms.Button();
            this.ctlPut = new System.Windows.Forms.Button();
            this.ctlGet = new System.Windows.Forms.Button();
            this.ctlRefresh = new System.Windows.Forms.Button();
            this.ctlListFiles = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlPassword
            // 
            this.ctlPassword.Location = new System.Drawing.Point(106, 69);
            this.ctlPassword.Name = "ctlPassword";
            this.ctlPassword.PasswordChar = '*';
            this.ctlPassword.Size = new System.Drawing.Size(272, 20);
            this.ctlPassword.TabIndex = 7;
            this.ctlPassword.Text = "topsecret";
            // 
            // ctlUsername
            // 
            this.ctlUsername.Location = new System.Drawing.Point(106, 45);
            this.ctlUsername.Name = "ctlUsername";
            this.ctlUsername.Size = new System.Drawing.Size(272, 20);
            this.ctlUsername.TabIndex = 5;
            this.ctlUsername.Text = "activexperts";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.ctlProtocolError);
            this.GroupBox3.Controls.Add(this.label8);
            this.GroupBox3.Controls.Add(this.ctlLogfile);
            this.GroupBox3.Controls.Add(this.ctlResult);
            this.GroupBox3.Controls.Add(this.ctlView);
            this.GroupBox3.Controls.Add(this.Label6);
            this.GroupBox3.Controls.Add(this.Label5);
            this.GroupBox3.Location = new System.Drawing.Point(14, 414);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(568, 104);
            this.GroupBox3.TabIndex = 8;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Result";
            // 
            // ctlProtocolError
            // 
            this.ctlProtocolError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlProtocolError.Location = new System.Drawing.Point(90, 45);
            this.ctlProtocolError.Name = "ctlProtocolError";
            this.ctlProtocolError.ReadOnly = true;
            this.ctlProtocolError.Size = new System.Drawing.Size(468, 20);
            this.ctlProtocolError.TabIndex = 18;
            this.ctlProtocolError.TabStop = false;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Protocol Error:";
            // 
            // ctlLogfile
            // 
            this.ctlLogfile.Location = new System.Drawing.Point(90, 70);
            this.ctlLogfile.Name = "ctlLogfile";
            this.ctlLogfile.Size = new System.Drawing.Size(420, 20);
            this.ctlLogfile.TabIndex = 1;
            // 
            // ctlResult
            // 
            this.ctlResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlResult.Location = new System.Drawing.Point(90, 21);
            this.ctlResult.Name = "ctlResult";
            this.ctlResult.ReadOnly = true;
            this.ctlResult.Size = new System.Drawing.Size(468, 20);
            this.ctlResult.TabIndex = 3;
            this.ctlResult.TabStop = false;
            // 
            // ctlView
            // 
            this.ctlView.Location = new System.Drawing.Point(514, 70);
            this.ctlView.Name = "ctlView";
            this.ctlView.Size = new System.Drawing.Size(45, 21);
            this.ctlView.TabIndex = 2;
            this.ctlView.Text = "&View";
            this.ctlView.Click += new System.EventHandler(this.ctlView_Click);
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(16, 73);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(44, 20);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "&Logfile:";
            // 
            // Label5
            // 
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(16, 24);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(47, 16);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "Result:";
            // 
            // ctlPort
            // 
            this.ctlPort.Location = new System.Drawing.Point(435, 21);
            this.ctlPort.Name = "ctlPort";
            this.ctlPort.Size = new System.Drawing.Size(64, 20);
            this.ctlPort.TabIndex = 3;
            this.ctlPort.Text = "22";
            // 
            // ctlHost
            // 
            this.ctlHost.Location = new System.Drawing.Point(106, 21);
            this.ctlHost.Name = "ctlHost";
            this.ctlHost.Size = new System.Drawing.Size(272, 20);
            this.ctlHost.TabIndex = 1;
            this.ctlHost.Text = "srv202.activexperts-labs.com";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ctlAcceptKey);
            this.GroupBox1.Controls.Add(this.ctlBrowse);
            this.GroupBox1.Controls.Add(this.label7);
            this.GroupBox1.Controls.Add(this.ctlKeyFile);
            this.GroupBox1.Controls.Add(this.ctlPassword);
            this.GroupBox1.Controls.Add(this.ctlUsername);
            this.GroupBox1.Controls.Add(this.ctlPort);
            this.GroupBox1.Controls.Add(this.ctlHost);
            this.GroupBox1.Controls.Add(this.ctlDisconnect);
            this.GroupBox1.Controls.Add(this.ctlConnect);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 9);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(568, 179);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "SFTP Server";
            // 
            // ctlAcceptKey
            // 
            this.ctlAcceptKey.AutoSize = true;
            this.ctlAcceptKey.Checked = true;
            this.ctlAcceptKey.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ctlAcceptKey.Location = new System.Drawing.Point(106, 120);
            this.ctlAcceptKey.Name = "ctlAcceptKey";
            this.ctlAcceptKey.Size = new System.Drawing.Size(106, 17);
            this.ctlAcceptKey.TabIndex = 11;
            this.ctlAcceptKey.Text = "Accept Host Key";
            this.ctlAcceptKey.UseVisualStyleBackColor = true;
            // 
            // ctlBrowse
            // 
            this.ctlBrowse.Location = new System.Drawing.Point(384, 95);
            this.ctlBrowse.Name = "ctlBrowse";
            this.ctlBrowse.Size = new System.Drawing.Size(32, 21);
            this.ctlBrowse.TabIndex = 10;
            this.ctlBrowse.Text = "...";
            this.ctlBrowse.UseVisualStyleBackColor = true;
            this.ctlBrowse.Click += new System.EventHandler(this.cltBrowsePrivKey_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(16, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Private &Key File:";
            // 
            // ctlKeyFile
            // 
            this.ctlKeyFile.Location = new System.Drawing.Point(106, 95);
            this.ctlKeyFile.Name = "ctlKeyFile";
            this.ctlKeyFile.Size = new System.Drawing.Size(272, 20);
            this.ctlKeyFile.TabIndex = 9;
            // 
            // ctlDisconnect
            // 
            this.ctlDisconnect.Location = new System.Drawing.Point(250, 143);
            this.ctlDisconnect.Name = "ctlDisconnect";
            this.ctlDisconnect.Size = new System.Drawing.Size(128, 24);
            this.ctlDisconnect.TabIndex = 13;
            this.ctlDisconnect.Text = "&Disconnect";
            this.ctlDisconnect.Click += new System.EventHandler(this.ctlDisconnect_Click);
            // 
            // ctlConnect
            // 
            this.ctlConnect.Location = new System.Drawing.Point(106, 143);
            this.ctlConnect.Name = "ctlConnect";
            this.ctlConnect.Size = new System.Drawing.Size(128, 24);
            this.ctlConnect.TabIndex = 12;
            this.ctlConnect.Text = "&Connect";
            this.ctlConnect.Click += new System.EventHandler(this.ctlConnect_Click);
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(16, 72);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(80, 16);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "&Password:";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(16, 48);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(80, 16);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "&Username:";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(393, 25);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(36, 16);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "&Port:";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "&Host:";
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Date";
            this.ColumnHeader3.Width = 134;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Size";
            this.ColumnHeader2.Width = 149;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.ctlCwd);
            this.GroupBox2.Controls.Add(this.ctlDelete);
            this.GroupBox2.Controls.Add(this.ctlPut);
            this.GroupBox2.Controls.Add(this.ctlGet);
            this.GroupBox2.Controls.Add(this.ctlRefresh);
            this.GroupBox2.Controls.Add(this.ctlListFiles);
            this.GroupBox2.Location = new System.Drawing.Point(12, 194);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(568, 214);
            this.GroupBox2.TabIndex = 1;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Files";
            // 
            // ctlCwd
            // 
            this.ctlCwd.Location = new System.Drawing.Point(16, 19);
            this.ctlCwd.Name = "ctlCwd";
            this.ctlCwd.ReadOnly = true;
            this.ctlCwd.Size = new System.Drawing.Size(536, 20);
            this.ctlCwd.TabIndex = 0;
            this.ctlCwd.TabStop = false;
            // 
            // ctlDelete
            // 
            this.ctlDelete.Location = new System.Drawing.Point(424, 181);
            this.ctlDelete.Name = "ctlDelete";
            this.ctlDelete.Size = new System.Drawing.Size(128, 24);
            this.ctlDelete.TabIndex = 5;
            this.ctlDelete.Text = "&Delete File";
            this.ctlDelete.Click += new System.EventHandler(this.ctlDelete_Click);
            // 
            // ctlPut
            // 
            this.ctlPut.Location = new System.Drawing.Point(288, 181);
            this.ctlPut.Name = "ctlPut";
            this.ctlPut.Size = new System.Drawing.Size(128, 24);
            this.ctlPut.TabIndex = 4;
            this.ctlPut.Text = "&Upload File...";
            this.ctlPut.Click += new System.EventHandler(this.ctlPut_Click);
            // 
            // ctlGet
            // 
            this.ctlGet.Location = new System.Drawing.Point(152, 181);
            this.ctlGet.Name = "ctlGet";
            this.ctlGet.Size = new System.Drawing.Size(128, 24);
            this.ctlGet.TabIndex = 3;
            this.ctlGet.Text = "&Download File...";
            this.ctlGet.Click += new System.EventHandler(this.ctlGet_Click);
            // 
            // ctlRefresh
            // 
            this.ctlRefresh.Location = new System.Drawing.Point(16, 181);
            this.ctlRefresh.Name = "ctlRefresh";
            this.ctlRefresh.Size = new System.Drawing.Size(128, 24);
            this.ctlRefresh.TabIndex = 2;
            this.ctlRefresh.Text = "&Refresh";
            this.ctlRefresh.Click += new System.EventHandler(this.ctlRefresh_Click);
            // 
            // ctlListFiles
            // 
            this.ctlListFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3});
            this.ctlListFiles.FullRowSelect = true;
            this.ctlListFiles.GridLines = true;
            this.ctlListFiles.Location = new System.Drawing.Point(16, 45);
            this.ctlListFiles.MultiSelect = false;
            this.ctlListFiles.Name = "ctlListFiles";
            this.ctlListFiles.Size = new System.Drawing.Size(536, 128);
            this.ctlListFiles.TabIndex = 1;
            this.ctlListFiles.UseCompatibleStateImageBehavior = false;
            this.ctlListFiles.View = System.Windows.Forms.View.Details;
            this.ctlListFiles.DoubleClick += new System.EventHandler(this.ctlListFiles_DoubleClick);
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Name";
            this.ColumnHeader1.Width = 248;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "doc1";
            // 
            // SFtpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 534);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SFtpForm";
            this.Text = "ActiveXperts Network Component - C# .NET SFtp Sample";
            this.Load += new System.EventHandler(this.SFtpForm_Load);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TextBox ctlPassword;
        internal System.Windows.Forms.TextBox ctlUsername;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.TextBox ctlLogfile;
        internal System.Windows.Forms.TextBox ctlResult;
        internal System.Windows.Forms.Button ctlView;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox ctlPort;
        internal System.Windows.Forms.TextBox ctlHost;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button ctlDisconnect;
        internal System.Windows.Forms.Button ctlConnect;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button ctlDelete;
        internal System.Windows.Forms.Button ctlPut;
        internal System.Windows.Forms.Button ctlGet;
        internal System.Windows.Forms.Button ctlRefresh;
        internal System.Windows.Forms.ListView ctlListFiles;
        public System.Windows.Forms.ColumnHeader ColumnHeader1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox ctlKeyFile;
        private System.Windows.Forms.Button ctlBrowse;
        private System.Windows.Forms.CheckBox ctlAcceptKey;
        private System.Windows.Forms.TextBox ctlCwd;
        internal System.Windows.Forms.TextBox ctlProtocolError;
        internal System.Windows.Forms.Label label8;
    }
}