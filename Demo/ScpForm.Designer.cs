namespace Demo
{
    partial class ScpForm
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ctlAcceptKey = new System.Windows.Forms.CheckBox();
            this.cltBrowse = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ctlKeyFile = new System.Windows.Forms.TextBox();
            this.ctlPassword = new System.Windows.Forms.TextBox();
            this.ctlUsername = new System.Windows.Forms.TextBox();
            this.ctlPort = new System.Windows.Forms.TextBox();
            this.ctlHost = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ctlCopy = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ctlRemoteToLocal = new System.Windows.Forms.RadioButton();
            this.ctlLocalToRemote = new System.Windows.Forms.RadioButton();
            this.ctlToBrowse = new System.Windows.Forms.Button();
            this.ctlLocalFile = new System.Windows.Forms.TextBox();
            this.ctlRemoteFile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ctlProtocolError = new System.Windows.Forms.TextBox();
            this.ctlLogfile = new System.Windows.Forms.TextBox();
            this.ctlResult = new System.Windows.Forms.TextBox();
            this.ctlView = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ctlAcceptKey);
            this.GroupBox1.Controls.Add(this.cltBrowse);
            this.GroupBox1.Controls.Add(this.label7);
            this.GroupBox1.Controls.Add(this.ctlKeyFile);
            this.GroupBox1.Controls.Add(this.ctlPassword);
            this.GroupBox1.Controls.Add(this.ctlUsername);
            this.GroupBox1.Controls.Add(this.ctlPort);
            this.GroupBox1.Controls.Add(this.ctlHost);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(5, 6);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(496, 147);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "SCP Server";
            // 
            // ctlAcceptKey
            // 
            this.ctlAcceptKey.AutoSize = true;
            this.ctlAcceptKey.Checked = true;
            this.ctlAcceptKey.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ctlAcceptKey.Location = new System.Drawing.Point(106, 121);
            this.ctlAcceptKey.Name = "ctlAcceptKey";
            this.ctlAcceptKey.Size = new System.Drawing.Size(106, 17);
            this.ctlAcceptKey.TabIndex = 11;
            this.ctlAcceptKey.Text = "Accept Host Key";
            this.ctlAcceptKey.UseVisualStyleBackColor = true;
            // 
            // cltBrowse
            // 
            this.cltBrowse.Location = new System.Drawing.Point(451, 95);
            this.cltBrowse.Name = "cltBrowse";
            this.cltBrowse.Size = new System.Drawing.Size(26, 19);
            this.cltBrowse.TabIndex = 10;
            this.cltBrowse.Text = "...";
            this.cltBrowse.UseVisualStyleBackColor = true;
            this.cltBrowse.Click += new System.EventHandler(this.cltBrowse_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(16, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Private &Key File:";
            // 
            // ctlKeyFile
            // 
            this.ctlKeyFile.Location = new System.Drawing.Point(106, 94);
            this.ctlKeyFile.Name = "ctlKeyFile";
            this.ctlKeyFile.Size = new System.Drawing.Size(337, 20);
            this.ctlKeyFile.TabIndex = 9;
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
            // ctlPort
            // 
            this.ctlPort.Location = new System.Drawing.Point(415, 22);
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
            this.Label2.Location = new System.Drawing.Point(384, 25);
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
            // ctlCopy
            // 
            this.ctlCopy.Location = new System.Drawing.Point(341, 119);
            this.ctlCopy.Name = "ctlCopy";
            this.ctlCopy.Size = new System.Drawing.Size(136, 22);
            this.ctlCopy.TabIndex = 9;
            this.ctlCopy.Text = "&Copy";
            this.ctlCopy.Click += new System.EventHandler(this.ctlCopy_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.ctlRemoteToLocal);
            this.groupBox2.Controls.Add(this.ctlLocalToRemote);
            this.groupBox2.Controls.Add(this.ctlToBrowse);
            this.groupBox2.Controls.Add(this.ctlLocalFile);
            this.groupBox2.Controls.Add(this.ctlRemoteFile);
            this.groupBox2.Controls.Add(this.ctlCopy);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(5, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 154);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Files";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Direction:";
            // 
            // ctlRemoteToLocal
            // 
            this.ctlRemoteToLocal.AutoSize = true;
            this.ctlRemoteToLocal.Checked = true;
            this.ctlRemoteToLocal.Location = new System.Drawing.Point(106, 39);
            this.ctlRemoteToLocal.Name = "ctlRemoteToLocal";
            this.ctlRemoteToLocal.Size = new System.Drawing.Size(163, 17);
            this.ctlRemoteToLocal.TabIndex = 2;
            this.ctlRemoteToLocal.TabStop = true;
            this.ctlRemoteToLocal.Text = "From remote host to localhost";
            this.ctlRemoteToLocal.UseVisualStyleBackColor = true;
            // 
            // ctlLocalToRemote
            // 
            this.ctlLocalToRemote.AutoSize = true;
            this.ctlLocalToRemote.Location = new System.Drawing.Point(106, 19);
            this.ctlLocalToRemote.Name = "ctlLocalToRemote";
            this.ctlLocalToRemote.Size = new System.Drawing.Size(163, 17);
            this.ctlLocalToRemote.TabIndex = 1;
            this.ctlLocalToRemote.Text = "From localhost to remote host";
            this.ctlLocalToRemote.UseVisualStyleBackColor = true;
            // 
            // ctlToBrowse
            // 
            this.ctlToBrowse.Location = new System.Drawing.Point(451, 92);
            this.ctlToBrowse.Name = "ctlToBrowse";
            this.ctlToBrowse.Size = new System.Drawing.Size(26, 19);
            this.ctlToBrowse.TabIndex = 8;
            this.ctlToBrowse.Text = "...";
            this.ctlToBrowse.UseVisualStyleBackColor = true;
            this.ctlToBrowse.Click += new System.EventHandler(this.ctlToBrowse_Click);
            // 
            // ctlLocalFile
            // 
            this.ctlLocalFile.Location = new System.Drawing.Point(106, 92);
            this.ctlLocalFile.Name = "ctlLocalFile";
            this.ctlLocalFile.Size = new System.Drawing.Size(337, 20);
            this.ctlLocalFile.TabIndex = 7;
            this.ctlLocalFile.Text = "c:\\readme.txt";
            this.ctlLocalFile.TextChanged += new System.EventHandler(this.ctlLocalFile_TextChanged);
            this.ctlLocalFile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctlLocalFile_KeyPress);
            // 
            // ctlRemoteFile
            // 
            this.ctlRemoteFile.Location = new System.Drawing.Point(106, 67);
            this.ctlRemoteFile.Name = "ctlRemoteFile";
            this.ctlRemoteFile.Size = new System.Drawing.Size(337, 20);
            this.ctlRemoteFile.TabIndex = 4;
            this.ctlRemoteFile.Text = "/network-component/readme.txt";
            this.ctlRemoteFile.TextChanged += new System.EventHandler(this.ctlRemoteFile_TextChanged);
            this.ctlRemoteFile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctlRemoteFile_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Local File:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Remote File:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "doc1";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.label11);
            this.GroupBox3.Controls.Add(this.ctlProtocolError);
            this.GroupBox3.Controls.Add(this.ctlLogfile);
            this.GroupBox3.Controls.Add(this.ctlResult);
            this.GroupBox3.Controls.Add(this.ctlView);
            this.GroupBox3.Controls.Add(this.label9);
            this.GroupBox3.Controls.Add(this.label10);
            this.GroupBox3.Location = new System.Drawing.Point(4, 320);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(497, 97);
            this.GroupBox3.TabIndex = 9;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Result";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(16, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Protocol Error:";
            // 
            // ctlProtocolError
            // 
            this.ctlProtocolError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlProtocolError.Location = new System.Drawing.Point(107, 41);
            this.ctlProtocolError.Name = "ctlProtocolError";
            this.ctlProtocolError.ReadOnly = true;
            this.ctlProtocolError.Size = new System.Drawing.Size(371, 20);
            this.ctlProtocolError.TabIndex = 17;
            this.ctlProtocolError.TabStop = false;
            // 
            // ctlLogfile
            // 
            this.ctlLogfile.Location = new System.Drawing.Point(107, 63);
            this.ctlLogfile.Name = "ctlLogfile";
            this.ctlLogfile.Size = new System.Drawing.Size(312, 20);
            this.ctlLogfile.TabIndex = 1;
            // 
            // ctlResult
            // 
            this.ctlResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlResult.Location = new System.Drawing.Point(107, 19);
            this.ctlResult.Name = "ctlResult";
            this.ctlResult.ReadOnly = true;
            this.ctlResult.Size = new System.Drawing.Size(371, 20);
            this.ctlResult.TabIndex = 3;
            this.ctlResult.TabStop = false;
            // 
            // ctlView
            // 
            this.ctlView.Location = new System.Drawing.Point(425, 63);
            this.ctlView.Name = "ctlView";
            this.ctlView.Size = new System.Drawing.Size(53, 21);
            this.ctlView.TabIndex = 2;
            this.ctlView.Text = "&View";
            this.ctlView.Click += new System.EventHandler(this.ctlView_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(16, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "&Logfile:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Result:";
            // 
            // ScpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 426);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScpForm";
            this.Text = "ActiveXperts Network Component - C# .NET Scp Sample";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Button cltBrowse;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox ctlKeyFile;
        internal System.Windows.Forms.TextBox ctlPassword;
        internal System.Windows.Forms.TextBox ctlUsername;
        internal System.Windows.Forms.TextBox ctlPort;
        internal System.Windows.Forms.TextBox ctlHost;
        internal System.Windows.Forms.Button ctlCopy;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton ctlRemoteToLocal;
        private System.Windows.Forms.RadioButton ctlLocalToRemote;
        private System.Windows.Forms.Button ctlToBrowse;
        internal System.Windows.Forms.TextBox ctlLocalFile;
        internal System.Windows.Forms.TextBox ctlRemoteFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.TextBox ctlLogfile;
        internal System.Windows.Forms.TextBox ctlResult;
        internal System.Windows.Forms.Button ctlView;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox ctlAcceptKey;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox ctlProtocolError;
    }
}