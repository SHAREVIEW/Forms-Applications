namespace Demo
{
    partial class TelnetForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.ctlResponse = new System.Windows.Forms.TextBox();
            this.ctlCommand = new System.Windows.Forms.TextBox();
            this.ctlConnect = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ctlView = new System.Windows.Forms.Button();
            this.ctlLogFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ctlResult = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.ctlDisconnect = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ctlPort = new System.Windows.Forms.TextBox();
            this.ctlHost = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ctlSend = new System.Windows.Forms.Button();
            this.GroupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "&Command:";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.ctlResponse);
            this.GroupBox3.Location = new System.Drawing.Point(12, 124);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(528, 192);
            this.GroupBox3.TabIndex = 8;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Received";
            // 
            // ctlResponse
            // 
            this.ctlResponse.Location = new System.Drawing.Point(16, 24);
            this.ctlResponse.Multiline = true;
            this.ctlResponse.Name = "ctlResponse";
            this.ctlResponse.ReadOnly = true;
            this.ctlResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ctlResponse.Size = new System.Drawing.Size(504, 152);
            this.ctlResponse.TabIndex = 0;
            // 
            // ctlCommand
            // 
            this.ctlCommand.Location = new System.Drawing.Point(80, 72);
            this.ctlCommand.Name = "ctlCommand";
            this.ctlCommand.Size = new System.Drawing.Size(328, 20);
            this.ctlCommand.TabIndex = 7;
            this.ctlCommand.Text = "library";
            // 
            // ctlConnect
            // 
            this.ctlConnect.Location = new System.Drawing.Point(420, 24);
            this.ctlConnect.Name = "ctlConnect";
            this.ctlConnect.Size = new System.Drawing.Size(100, 22);
            this.ctlConnect.TabIndex = 4;
            this.ctlConnect.Text = "&Connect";
            this.ctlConnect.Click += new System.EventHandler(this.ctlConnect_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ctlView);
            this.groupBox2.Controls.Add(this.ctlLogFile);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ctlResult);
            this.groupBox2.Controls.Add(this.Label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(528, 80);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result and logging";
            // 
            // ctlView
            // 
            this.ctlView.Location = new System.Drawing.Point(420, 48);
            this.ctlView.Name = "ctlView";
            this.ctlView.Size = new System.Drawing.Size(100, 22);
            this.ctlView.TabIndex = 5;
            this.ctlView.Text = "View";
            this.ctlView.Click += new System.EventHandler(this.ctlView_Click);
            // 
            // ctlLogFile
            // 
            this.ctlLogFile.Location = new System.Drawing.Point(80, 48);
            this.ctlLogFile.Name = "ctlLogFile";
            this.ctlLogFile.Size = new System.Drawing.Size(328, 20);
            this.ctlLogFile.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "&Logfile:";
            // 
            // ctlResult
            // 
            this.ctlResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlResult.Location = new System.Drawing.Point(80, 24);
            this.ctlResult.Name = "ctlResult";
            this.ctlResult.ReadOnly = true;
            this.ctlResult.Size = new System.Drawing.Size(440, 20);
            this.ctlResult.TabIndex = 2;
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(16, 28);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(48, 16);
            this.Label4.TabIndex = 1;
            this.Label4.Text = "Result:";
            // 
            // ctlDisconnect
            // 
            this.ctlDisconnect.Location = new System.Drawing.Point(420, 48);
            this.ctlDisconnect.Name = "ctlDisconnect";
            this.ctlDisconnect.Size = new System.Drawing.Size(100, 22);
            this.ctlDisconnect.TabIndex = 5;
            this.ctlDisconnect.Text = "&Disconnect";
            this.ctlDisconnect.Click += new System.EventHandler(this.ctlDisconnect_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ctlCommand);
            this.GroupBox1.Controls.Add(this.label5);
            this.GroupBox1.Controls.Add(this.ctlDisconnect);
            this.GroupBox1.Controls.Add(this.ctlConnect);
            this.GroupBox1.Controls.Add(this.ctlPort);
            this.GroupBox1.Controls.Add(this.ctlHost);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.ctlSend);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(528, 104);
            this.GroupBox1.TabIndex = 7;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Server";
            // 
            // ctlPort
            // 
            this.ctlPort.Location = new System.Drawing.Point(352, 24);
            this.ctlPort.Name = "ctlPort";
            this.ctlPort.Size = new System.Drawing.Size(56, 20);
            this.ctlPort.TabIndex = 3;
            this.ctlPort.Text = "23";
            // 
            // ctlHost
            // 
            this.ctlHost.Location = new System.Drawing.Point(80, 24);
            this.ctlHost.Name = "ctlHost";
            this.ctlHost.Size = new System.Drawing.Size(232, 20);
            this.ctlHost.TabIndex = 2;
            this.ctlHost.Text = "telnet.activexperts-labs.com";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(320, 27);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(32, 16);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "&Port:";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 27);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(32, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "&Host:";
            // 
            // ctlSend
            // 
            this.ctlSend.Location = new System.Drawing.Point(420, 72);
            this.ctlSend.Name = "ctlSend";
            this.ctlSend.Size = new System.Drawing.Size(100, 22);
            this.ctlSend.TabIndex = 2;
            this.ctlSend.Text = "&Send";
            this.ctlSend.Click += new System.EventHandler(this.ctlSend_Click);
            // 
            // TelnetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 418);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelnetForm";
            this.Text = "ActiveXperts Network Component - C# .NET Telnet Sample";
            this.Load += new System.EventHandler(this.TelnetForm_Load);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.TextBox ctlResponse;
        private System.Windows.Forms.TextBox ctlCommand;
        internal System.Windows.Forms.Button ctlConnect;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ctlView;
        private System.Windows.Forms.TextBox ctlLogFile;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox ctlResult;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button ctlDisconnect;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox ctlPort;
        internal System.Windows.Forms.TextBox ctlHost;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button ctlSend;
    }
}