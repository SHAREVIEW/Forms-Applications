namespace Demo
{
    partial class UdpForm
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
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.ctlView = new System.Windows.Forms.Button();
            this.ctlLogFile = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.ctlClientSend = new System.Windows.Forms.Button();
            this.ctlServerResult = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.ctlClientResult = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.ctlServerListenStop = new System.Windows.Forms.Button();
            this.ctlClientCommand = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.ctlClientClose = new System.Windows.Forms.Button();
            this.ctlServerPort = new System.Windows.Forms.TextBox();
            this.ctlServerListenStart = new System.Windows.Forms.Button();
            this.ctlClientOpen = new System.Windows.Forms.Button();
            this.ctServerResponse = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ctlServerVersion = new System.Windows.Forms.CheckBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.ctlClientPort = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.ctlClientHost = new System.Windows.Forms.TextBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.ctlView);
            this.GroupBox3.Controls.Add(this.ctlLogFile);
            this.GroupBox3.Controls.Add(this.Label8);
            this.GroupBox3.Location = new System.Drawing.Point(12, 363);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(528, 56);
            this.GroupBox3.TabIndex = 8;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Logging";
            // 
            // ctlView
            // 
            this.ctlView.Location = new System.Drawing.Point(444, 24);
            this.ctlView.Name = "ctlView";
            this.ctlView.Size = new System.Drawing.Size(75, 22);
            this.ctlView.TabIndex = 2;
            this.ctlView.Text = "&View...";
            this.ctlView.Click += new System.EventHandler(this.ctlView_Click);
            // 
            // ctlLogFile
            // 
            this.ctlLogFile.Location = new System.Drawing.Point(80, 24);
            this.ctlLogFile.Name = "ctlLogFile";
            this.ctlLogFile.Size = new System.Drawing.Size(356, 20);
            this.ctlLogFile.TabIndex = 1;
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(16, 26);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(48, 16);
            this.Label8.TabIndex = 0;
            this.Label8.Text = "&Logfile:";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(16, 87);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(60, 16);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Received:";
            // 
            // ctlClientSend
            // 
            this.ctlClientSend.Location = new System.Drawing.Point(444, 48);
            this.ctlClientSend.Name = "ctlClientSend";
            this.ctlClientSend.Size = new System.Drawing.Size(75, 22);
            this.ctlClientSend.TabIndex = 10;
            this.ctlClientSend.Text = "&Send";
            this.ctlClientSend.Click += new System.EventHandler(this.ctlClientSend_Click);
            // 
            // ctlServerResult
            // 
            this.ctlServerResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlServerResult.Location = new System.Drawing.Point(80, 63);
            this.ctlServerResult.Name = "ctlServerResult";
            this.ctlServerResult.ReadOnly = true;
            this.ctlServerResult.Size = new System.Drawing.Size(440, 20);
            this.ctlServerResult.TabIndex = 5;
            // 
            // Label7
            // 
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(16, 75);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(52, 16);
            this.Label7.TabIndex = 8;
            this.Label7.Text = "Result:";
            // 
            // ctlClientResult
            // 
            this.ctlClientResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlClientResult.Location = new System.Drawing.Point(80, 72);
            this.ctlClientResult.Name = "ctlClientResult";
            this.ctlClientResult.ReadOnly = true;
            this.ctlClientResult.Size = new System.Drawing.Size(440, 20);
            this.ctlClientResult.TabIndex = 9;
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(16, 65);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(60, 16);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Result:";
            // 
            // ctlServerListenStop
            // 
            this.ctlServerListenStop.Location = new System.Drawing.Point(444, 21);
            this.ctlServerListenStop.Name = "ctlServerListenStop";
            this.ctlServerListenStop.Size = new System.Drawing.Size(75, 22);
            this.ctlServerListenStop.TabIndex = 3;
            this.ctlServerListenStop.Text = "&Close";
            this.ctlServerListenStop.Click += new System.EventHandler(this.ctlServerListenStop_Click);
            // 
            // ctlClientCommand
            // 
            this.ctlClientCommand.Location = new System.Drawing.Point(80, 48);
            this.ctlClientCommand.Name = "ctlClientCommand";
            this.ctlClientCommand.Size = new System.Drawing.Size(356, 20);
            this.ctlClientCommand.TabIndex = 7;
            this.ctlClientCommand.Text = "Hello World !!!";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 23);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(168, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Listen on local machine on port:";
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(16, 50);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(63, 16);
            this.Label6.TabIndex = 6;
            this.Label6.Text = "Send string:";
            // 
            // ctlClientClose
            // 
            this.ctlClientClose.Location = new System.Drawing.Point(444, 24);
            this.ctlClientClose.Name = "ctlClientClose";
            this.ctlClientClose.Size = new System.Drawing.Size(75, 22);
            this.ctlClientClose.TabIndex = 5;
            this.ctlClientClose.Text = "Cl&ose";
            this.ctlClientClose.Click += new System.EventHandler(this.ctlClientClose_Click);
            // 
            // ctlServerPort
            // 
            this.ctlServerPort.Location = new System.Drawing.Point(176, 21);
            this.ctlServerPort.Name = "ctlServerPort";
            this.ctlServerPort.Size = new System.Drawing.Size(176, 20);
            this.ctlServerPort.TabIndex = 1;
            this.ctlServerPort.Text = "1500";
            // 
            // ctlServerListenStart
            // 
            this.ctlServerListenStart.Location = new System.Drawing.Point(356, 21);
            this.ctlServerListenStart.Name = "ctlServerListenStart";
            this.ctlServerListenStart.Size = new System.Drawing.Size(80, 22);
            this.ctlServerListenStart.TabIndex = 2;
            this.ctlServerListenStart.Text = "&Listen";
            this.ctlServerListenStart.Click += new System.EventHandler(this.ctlServerListenStart_Click);
            // 
            // ctlClientOpen
            // 
            this.ctlClientOpen.Location = new System.Drawing.Point(360, 24);
            this.ctlClientOpen.Name = "ctlClientOpen";
            this.ctlClientOpen.Size = new System.Drawing.Size(75, 22);
            this.ctlClientOpen.TabIndex = 4;
            this.ctlClientOpen.Text = "&Open";
            this.ctlClientOpen.Click += new System.EventHandler(this.ctlClientOpen_Click);
            // 
            // ctServerResponse
            // 
            this.ctServerResponse.Location = new System.Drawing.Point(80, 87);
            this.ctServerResponse.Multiline = true;
            this.ctServerResponse.Name = "ctServerResponse";
            this.ctServerResponse.ReadOnly = true;
            this.ctServerResponse.Size = new System.Drawing.Size(440, 144);
            this.ctServerResponse.TabIndex = 7;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ctlServerVersion);
            this.GroupBox1.Controls.Add(this.ctServerResponse);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.ctlServerResult);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.ctlServerListenStop);
            this.GroupBox1.Controls.Add(this.ctlServerListenStart);
            this.GroupBox1.Controls.Add(this.ctlServerPort);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(528, 239);
            this.GroupBox1.TabIndex = 6;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Server";
            // 
            // ctlServerVersion
            // 
            this.ctlServerVersion.AutoSize = true;
            this.ctlServerVersion.Location = new System.Drawing.Point(176, 43);
            this.ctlServerVersion.Name = "ctlServerVersion";
            this.ctlServerVersion.Size = new System.Drawing.Size(134, 17);
            this.ctlServerVersion.TabIndex = 8;
            this.ctlServerVersion.Text = "Listen on IPv6 address";
            this.ctlServerVersion.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(16, 28);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(56, 16);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "Send to:";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.ctlClientSend);
            this.GroupBox2.Controls.Add(this.ctlClientResult);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.ctlClientCommand);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.ctlClientClose);
            this.GroupBox2.Controls.Add(this.ctlClientOpen);
            this.GroupBox2.Controls.Add(this.ctlClientPort);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.ctlClientHost);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Location = new System.Drawing.Point(12, 255);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(528, 104);
            this.GroupBox2.TabIndex = 7;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Client";
            // 
            // ctlClientPort
            // 
            this.ctlClientPort.Location = new System.Drawing.Point(248, 24);
            this.ctlClientPort.Name = "ctlClientPort";
            this.ctlClientPort.Size = new System.Drawing.Size(96, 20);
            this.ctlClientPort.TabIndex = 3;
            this.ctlClientPort.Text = "1500";
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(198, 27);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(48, 16);
            this.Label5.TabIndex = 2;
            this.Label5.Text = "on port:";
            // 
            // ctlClientHost
            // 
            this.ctlClientHost.Location = new System.Drawing.Point(80, 24);
            this.ctlClientHost.Name = "ctlClientHost";
            this.ctlClientHost.Size = new System.Drawing.Size(112, 20);
            this.ctlClientHost.TabIndex = 1;
            this.ctlClientHost.Text = "127.0.0.1";
            // 
            // Timer
            // 
            this.Timer.Interval = 500;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // UdpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 432);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UdpForm";
            this.Text = "ActiveXperts Network Component - C# .NET UDP Client Sample";
            this.Load += new System.EventHandler(this.UdpForm_Load);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button ctlView;
        internal System.Windows.Forms.TextBox ctlLogFile;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button ctlClientSend;
        internal System.Windows.Forms.TextBox ctlServerResult;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox ctlClientResult;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button ctlServerListenStop;
        internal System.Windows.Forms.TextBox ctlClientCommand;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button ctlClientClose;
        internal System.Windows.Forms.TextBox ctlServerPort;
        internal System.Windows.Forms.Button ctlServerListenStart;
        internal System.Windows.Forms.Button ctlClientOpen;
        internal System.Windows.Forms.TextBox ctServerResponse;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox ctlClientPort;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox ctlClientHost;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.CheckBox ctlServerVersion;
    }
}