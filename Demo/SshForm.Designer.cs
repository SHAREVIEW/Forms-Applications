namespace Demo
{
    partial class SshForm
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
            this.components = new System.ComponentModel.Container();
            this.label15 = new System.Windows.Forms.Label();
            this.ctlConnectTimeout = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ctlAcceptHostKey = new System.Windows.Forms.CheckBox();
            this.ctlPort = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ctlBrowse = new System.Windows.Forms.Button();
            this.ctlPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ctlPrivateKeyFile = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.ctlProtocolError = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ctlView = new System.Windows.Forms.Button();
            this.ctlLogFile = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ctlStdErr = new System.Windows.Forms.TextBox();
            this.ctlStdOut = new System.Windows.Forms.TextBox();
            this.ctlResult = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.ctlUser = new System.Windows.Forms.TextBox();
            this.ctlHost = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ctlConnect = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ctlExecuteCommand = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ctlCommandTimeout = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ctlCommand = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(546, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 16);
            this.label15.TabIndex = 8;
            this.label15.Text = "ms";
            // 
            // ctlConnectTimeout
            // 
            this.ctlConnectTimeout.Location = new System.Drawing.Point(498, 25);
            this.ctlConnectTimeout.Name = "ctlConnectTimeout";
            this.ctlConnectTimeout.Size = new System.Drawing.Size(48, 20);
            this.ctlConnectTimeout.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(452, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "Timeout:";
            // 
            // ctlAcceptHostKey
            // 
            this.ctlAcceptHostKey.Checked = true;
            this.ctlAcceptHostKey.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ctlAcceptHostKey.Location = new System.Drawing.Point(104, 117);
            this.ctlAcceptHostKey.Name = "ctlAcceptHostKey";
            this.ctlAcceptHostKey.Size = new System.Drawing.Size(244, 24);
            this.ctlAcceptHostKey.TabIndex = 16;
            this.ctlAcceptHostKey.Text = "Accept Host Key";
            // 
            // ctlPort
            // 
            this.ctlPort.Location = new System.Drawing.Point(394, 24);
            this.ctlPort.Name = "ctlPort";
            this.ctlPort.Size = new System.Drawing.Size(48, 20);
            this.ctlPort.TabIndex = 3;
            this.ctlPort.Text = "22";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(365, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "&Port:";
            // 
            // ctlBrowse
            // 
            this.ctlBrowse.Location = new System.Drawing.Point(448, 98);
            this.ctlBrowse.Name = "ctlBrowse";
            this.ctlBrowse.Size = new System.Drawing.Size(26, 19);
            this.ctlBrowse.TabIndex = 15;
            this.ctlBrowse.Text = "...";
            this.ctlBrowse.Click += new System.EventHandler(this.ctlBrowse_Click);
            // 
            // ctlPassword
            // 
            this.ctlPassword.Location = new System.Drawing.Point(104, 73);
            this.ctlPassword.Name = "ctlPassword";
            this.ctlPassword.PasswordChar = '*';
            this.ctlPassword.Size = new System.Drawing.Size(256, 20);
            this.ctlPassword.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(16, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Pass&word:";
            // 
            // ctlPrivateKeyFile
            // 
            this.ctlPrivateKeyFile.Location = new System.Drawing.Point(104, 97);
            this.ctlPrivateKeyFile.Name = "ctlPrivateKeyFile";
            this.ctlPrivateKeyFile.Size = new System.Drawing.Size(339, 20);
            this.ctlPrivateKeyFile.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(16, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "&Private Key File:";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.ctlProtocolError);
            this.GroupBox2.Controls.Add(this.label4);
            this.GroupBox2.Controls.Add(this.ctlView);
            this.GroupBox2.Controls.Add(this.ctlLogFile);
            this.GroupBox2.Controls.Add(this.label10);
            this.GroupBox2.Controls.Add(this.ctlStdErr);
            this.GroupBox2.Controls.Add(this.ctlStdOut);
            this.GroupBox2.Controls.Add(this.ctlResult);
            this.GroupBox2.Controls.Add(this.Label9);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Location = new System.Drawing.Point(12, 293);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(572, 281);
            this.GroupBox2.TabIndex = 7;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Result";
            // 
            // ctlProtocolError
            // 
            this.ctlProtocolError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlProtocolError.Location = new System.Drawing.Point(104, 47);
            this.ctlProtocolError.Name = "ctlProtocolError";
            this.ctlProtocolError.ReadOnly = true;
            this.ctlProtocolError.Size = new System.Drawing.Size(457, 20);
            this.ctlProtocolError.TabIndex = 10;
            this.ctlProtocolError.TabStop = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Protocol Error:";
            // 
            // ctlView
            // 
            this.ctlView.Location = new System.Drawing.Point(490, 70);
            this.ctlView.Name = "ctlView";
            this.ctlView.Size = new System.Drawing.Size(72, 21);
            this.ctlView.TabIndex = 2;
            this.ctlView.Text = "&View";
            this.ctlView.Click += new System.EventHandler(this.ctlView_Click);
            // 
            // ctlLogFile
            // 
            this.ctlLogFile.Location = new System.Drawing.Point(104, 70);
            this.ctlLogFile.Name = "ctlLogFile";
            this.ctlLogFile.Size = new System.Drawing.Size(379, 20);
            this.ctlLogFile.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(16, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "&Logfile:";
            // 
            // ctlStdErr
            // 
            this.ctlStdErr.Location = new System.Drawing.Point(104, 181);
            this.ctlStdErr.Multiline = true;
            this.ctlStdErr.Name = "ctlStdErr";
            this.ctlStdErr.ReadOnly = true;
            this.ctlStdErr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ctlStdErr.Size = new System.Drawing.Size(457, 88);
            this.ctlStdErr.TabIndex = 5;
            this.ctlStdErr.TabStop = false;
            // 
            // ctlStdOut
            // 
            this.ctlStdOut.Location = new System.Drawing.Point(104, 95);
            this.ctlStdOut.Multiline = true;
            this.ctlStdOut.Name = "ctlStdOut";
            this.ctlStdOut.ReadOnly = true;
            this.ctlStdOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ctlStdOut.Size = new System.Drawing.Size(457, 80);
            this.ctlStdOut.TabIndex = 4;
            this.ctlStdOut.TabStop = false;
            // 
            // ctlResult
            // 
            this.ctlResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlResult.Location = new System.Drawing.Point(104, 24);
            this.ctlResult.Name = "ctlResult";
            this.ctlResult.ReadOnly = true;
            this.ctlResult.Size = new System.Drawing.Size(457, 20);
            this.ctlResult.TabIndex = 3;
            this.ctlResult.TabStop = false;
            // 
            // Label9
            // 
            this.Label9.Location = new System.Drawing.Point(16, 182);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(44, 20);
            this.Label9.TabIndex = 2;
            this.Label9.Text = "Std&Err:";
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(16, 96);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(72, 16);
            this.Label8.TabIndex = 1;
            this.Label8.Text = "Std&Out:";
            // 
            // Label7
            // 
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(16, 28);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(68, 16);
            this.Label7.TabIndex = 0;
            this.Label7.Text = "Result:";
            // 
            // ctlUser
            // 
            this.ctlUser.Location = new System.Drawing.Point(104, 49);
            this.ctlUser.Name = "ctlUser";
            this.ctlUser.Size = new System.Drawing.Size(256, 20);
            this.ctlUser.TabIndex = 10;
            // 
            // ctlHost
            // 
            this.ctlHost.Location = new System.Drawing.Point(104, 24);
            this.ctlHost.Name = "ctlHost";
            this.ctlHost.Size = new System.Drawing.Size(256, 20);
            this.ctlHost.TabIndex = 1;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(16, 53);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(56, 16);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "&User:";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 28);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(76, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "&Host:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ctlConnect);
            this.GroupBox1.Controls.Add(this.label15);
            this.GroupBox1.Controls.Add(this.ctlConnectTimeout);
            this.GroupBox1.Controls.Add(this.label14);
            this.GroupBox1.Controls.Add(this.ctlAcceptHostKey);
            this.GroupBox1.Controls.Add(this.ctlPort);
            this.GroupBox1.Controls.Add(this.label13);
            this.GroupBox1.Controls.Add(this.ctlBrowse);
            this.GroupBox1.Controls.Add(this.ctlPassword);
            this.GroupBox1.Controls.Add(this.label12);
            this.GroupBox1.Controls.Add(this.ctlPrivateKeyFile);
            this.GroupBox1.Controls.Add(this.label11);
            this.GroupBox1.Controls.Add(this.ctlUser);
            this.GroupBox1.Controls.Add(this.ctlHost);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(572, 178);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "SSH Session";
            // 
            // ctlConnect
            // 
            this.ctlConnect.Location = new System.Drawing.Point(104, 146);
            this.ctlConnect.Name = "ctlConnect";
            this.ctlConnect.Size = new System.Drawing.Size(256, 21);
            this.ctlConnect.TabIndex = 11;
            this.ctlConnect.Text = "&OpenSession";
            this.ctlConnect.Click += new System.EventHandler(this.ctlConnect_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ctlExecuteCommand);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.ctlCommandTimeout);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.ctlCommand);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(12, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(572, 85);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Command";
            // 
            // ctlExecuteCommand
            // 
            this.ctlExecuteCommand.Location = new System.Drawing.Point(104, 52);
            this.ctlExecuteCommand.Name = "ctlExecuteCommand";
            this.ctlExecuteCommand.Size = new System.Drawing.Size(256, 21);
            this.ctlExecuteCommand.TabIndex = 14;
            this.ctlExecuteCommand.Text = "&ExecuteCommand";
            this.ctlExecuteCommand.Click += new System.EventHandler(this.ctlExecuteCommand_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(546, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "ms";
            // 
            // ctlCommandTimeout
            // 
            this.ctlCommandTimeout.Location = new System.Drawing.Point(498, 25);
            this.ctlCommandTimeout.Name = "ctlCommandTimeout";
            this.ctlCommandTimeout.Size = new System.Drawing.Size(48, 20);
            this.ctlCommandTimeout.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(452, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Timeout:";
            // 
            // ctlCommand
            // 
            this.ctlCommand.Location = new System.Drawing.Point(104, 25);
            this.ctlCommand.Name = "ctlCommand";
            this.ctlCommand.Size = new System.Drawing.Size(339, 20);
            this.ctlCommand.TabIndex = 10;
            this.ctlCommand.Text = "ls";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(16, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 20);
            this.label16.TabIndex = 9;
            this.label16.Text = "&Command:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // SshForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 588);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SshForm";
            this.Text = "ActiveXperts Network Component - C# .NET SSH Sample";
            this.Load += new System.EventHandler(this.SshForm_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.TextBox ctlConnectTimeout;
        internal System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox ctlAcceptHostKey;
        internal System.Windows.Forms.TextBox ctlPort;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button ctlBrowse;
        internal System.Windows.Forms.TextBox ctlPassword;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox ctlPrivateKeyFile;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.Button ctlView;
        private System.Windows.Forms.TextBox ctlLogFile;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox ctlStdErr;
        internal System.Windows.Forms.TextBox ctlStdOut;
        internal System.Windows.Forms.TextBox ctlResult;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox ctlUser;
        internal System.Windows.Forms.TextBox ctlHost;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox ctlProtocolError;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox ctlCommandTimeout;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox ctlCommand;
        internal System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button ctlConnect;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ctlExecuteCommand;
    }
}