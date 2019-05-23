namespace Demo
{
    partial class ClientServerForm
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
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.ctlClientResult = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.ctlClientSend = new System.Windows.Forms.Button();
            this.ctlClientCommand = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.ctlClientDisconnect = new System.Windows.Forms.Button();
            this.ctlClientConnect = new System.Windows.Forms.Button();
            this.ctlClientHost = new System.Windows.Forms.TextBox();
            this.ctlClientPort = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.ctlServerDisconnect = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.ctlServerPort = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.ctlServerResult = new System.Windows.Forms.TextBox();
            this.ctlServerReceived = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ctlServerVersion = new System.Windows.Forms.CheckBox();
            this.ctlServerListenStop = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ctlServerListenStart = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ctlView = new System.Windows.Forms.Button();
            this.ctlLogFile = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.ctlClientResult);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.ctlClientSend);
            this.GroupBox2.Controls.Add(this.ctlClientCommand);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.ctlClientDisconnect);
            this.GroupBox2.Controls.Add(this.ctlClientConnect);
            this.GroupBox2.Controls.Add(this.ctlClientHost);
            this.GroupBox2.Controls.Add(this.ctlClientPort);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Location = new System.Drawing.Point(12, 273);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(472, 172);
            this.GroupBox2.TabIndex = 1;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Client";
            // 
            // ctlClientResult
            // 
            this.ctlClientResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlClientResult.Location = new System.Drawing.Point(84, 136);
            this.ctlClientResult.Name = "ctlClientResult";
            this.ctlClientResult.ReadOnly = true;
            this.ctlClientResult.Size = new System.Drawing.Size(380, 20);
            this.ctlClientResult.TabIndex = 10;
            // 
            // Label6
            // 
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(16, 138);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(72, 16);
            this.Label6.TabIndex = 9;
            this.Label6.Text = "Result:";
            // 
            // ctlClientSend
            // 
            this.ctlClientSend.Location = new System.Drawing.Point(84, 104);
            this.ctlClientSend.Name = "ctlClientSend";
            this.ctlClientSend.Size = new System.Drawing.Size(239, 22);
            this.ctlClientSend.TabIndex = 0;
            this.ctlClientSend.Text = "S&end";
            this.ctlClientSend.Click += new System.EventHandler(this.ctlClientSend_Click);
            // 
            // ctlClientCommand
            // 
            this.ctlClientCommand.Location = new System.Drawing.Point(84, 80);
            this.ctlClientCommand.Name = "ctlClientCommand";
            this.ctlClientCommand.Size = new System.Drawing.Size(240, 20);
            this.ctlClientCommand.TabIndex = 8;
            this.ctlClientCommand.Text = "Hello World!";
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(16, 83);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(60, 16);
            this.Label5.TabIndex = 7;
            this.Label5.Text = "&Command:";
            // 
            // ctlClientDisconnect
            // 
            this.ctlClientDisconnect.Location = new System.Drawing.Point(211, 48);
            this.ctlClientDisconnect.Name = "ctlClientDisconnect";
            this.ctlClientDisconnect.Size = new System.Drawing.Size(112, 22);
            this.ctlClientDisconnect.TabIndex = 6;
            this.ctlClientDisconnect.Text = "&Disconnect";
            this.ctlClientDisconnect.Click += new System.EventHandler(this.ctlClientDisconnect_Click);
            // 
            // ctlClientConnect
            // 
            this.ctlClientConnect.Location = new System.Drawing.Point(84, 48);
            this.ctlClientConnect.Name = "ctlClientConnect";
            this.ctlClientConnect.Size = new System.Drawing.Size(112, 22);
            this.ctlClientConnect.TabIndex = 5;
            this.ctlClientConnect.Text = "C&onnect";
            this.ctlClientConnect.Click += new System.EventHandler(this.ctlClientConnect_Click);
            // 
            // ctlClientHost
            // 
            this.ctlClientHost.Location = new System.Drawing.Point(84, 24);
            this.ctlClientHost.Name = "ctlClientHost";
            this.ctlClientHost.Size = new System.Drawing.Size(240, 20);
            this.ctlClientHost.TabIndex = 2;
            this.ctlClientHost.Text = "127.0.0.1";
            // 
            // ctlClientPort
            // 
            this.ctlClientPort.Location = new System.Drawing.Point(384, 24);
            this.ctlClientPort.Name = "ctlClientPort";
            this.ctlClientPort.Size = new System.Drawing.Size(80, 20);
            this.ctlClientPort.TabIndex = 4;
            this.ctlClientPort.Text = "1500";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(352, 27);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(32, 16);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "&Port:";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(16, 28);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(72, 16);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "&Server:";
            // 
            // ctlServerDisconnect
            // 
            this.ctlServerDisconnect.Location = new System.Drawing.Point(204, 55);
            this.ctlServerDisconnect.Name = "ctlServerDisconnect";
            this.ctlServerDisconnect.Size = new System.Drawing.Size(108, 22);
            this.ctlServerDisconnect.TabIndex = 3;
            this.ctlServerDisconnect.Text = "&Disconnect";
            this.ctlServerDisconnect.Click += new System.EventHandler(this.ctlServerDisconnect_Click);
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(16, 85);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 16);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Result:";
            // 
            // ctlServerPort
            // 
            this.ctlServerPort.Location = new System.Drawing.Point(171, 22);
            this.ctlServerPort.Name = "ctlServerPort";
            this.ctlServerPort.Size = new System.Drawing.Size(52, 20);
            this.ctlServerPort.TabIndex = 2;
            this.ctlServerPort.Text = "1500";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 26);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(168, 16);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "L&isten on local machine on port:";
            // 
            // ctlServerResult
            // 
            this.ctlServerResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlServerResult.Location = new System.Drawing.Point(88, 83);
            this.ctlServerResult.Name = "ctlServerResult";
            this.ctlServerResult.ReadOnly = true;
            this.ctlServerResult.Size = new System.Drawing.Size(376, 20);
            this.ctlServerResult.TabIndex = 6;
            // 
            // ctlServerReceived
            // 
            this.ctlServerReceived.Location = new System.Drawing.Point(88, 107);
            this.ctlServerReceived.Multiline = true;
            this.ctlServerReceived.Name = "ctlServerReceived";
            this.ctlServerReceived.ReadOnly = true;
            this.ctlServerReceived.Size = new System.Drawing.Size(376, 128);
            this.ctlServerReceived.TabIndex = 8;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ctlServerVersion);
            this.GroupBox1.Controls.Add(this.ctlServerListenStop);
            this.GroupBox1.Controls.Add(this.label7);
            this.GroupBox1.Controls.Add(this.ctlServerReceived);
            this.GroupBox1.Controls.Add(this.ctlServerResult);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.ctlServerDisconnect);
            this.GroupBox1.Controls.Add(this.ctlServerListenStart);
            this.GroupBox1.Controls.Add(this.ctlServerPort);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 8);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(472, 249);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Server";
            // 
            // ctlServerVersion
            // 
            this.ctlServerVersion.AutoSize = true;
            this.ctlServerVersion.Location = new System.Drawing.Point(243, 24);
            this.ctlServerVersion.Name = "ctlServerVersion";
            this.ctlServerVersion.Size = new System.Drawing.Size(134, 17);
            this.ctlServerVersion.TabIndex = 9;
            this.ctlServerVersion.Text = "Listen on IPv6 address";
            this.ctlServerVersion.UseVisualStyleBackColor = true;
            // 
            // ctlServerListenStop
            // 
            this.ctlServerListenStop.Location = new System.Drawing.Point(318, 55);
            this.ctlServerListenStop.Name = "ctlServerListenStop";
            this.ctlServerListenStop.Size = new System.Drawing.Size(108, 22);
            this.ctlServerListenStop.TabIndex = 4;
            this.ctlServerListenStop.Text = "&Stop Listening";
            this.ctlServerListenStop.Click += new System.EventHandler(this.ctlServerListenStop_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(16, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Received:";
            // 
            // ctlServerListenStart
            // 
            this.ctlServerListenStart.Location = new System.Drawing.Point(88, 55);
            this.ctlServerListenStart.Name = "ctlServerListenStart";
            this.ctlServerListenStart.Size = new System.Drawing.Size(108, 22);
            this.ctlServerListenStart.TabIndex = 0;
            this.ctlServerListenStart.Text = "&Listen";
            this.ctlServerListenStart.Click += new System.EventHandler(this.ctlServerListenStart_Click);
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ctlView
            // 
            this.ctlView.Location = new System.Drawing.Point(397, 459);
            this.ctlView.Name = "ctlView";
            this.ctlView.Size = new System.Drawing.Size(78, 22);
            this.ctlView.TabIndex = 4;
            this.ctlView.Text = "&View";
            this.ctlView.Click += new System.EventHandler(this.ctlView_Click);
            // 
            // ctlLogFile
            // 
            this.ctlLogFile.Location = new System.Drawing.Point(95, 459);
            this.ctlLogFile.Name = "ctlLogFile";
            this.ctlLogFile.Size = new System.Drawing.Size(292, 20);
            this.ctlLogFile.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(25, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "&Logfile:";
            // 
            // ClientServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 495);
            this.Controls.Add(this.ctlView);
            this.Controls.Add(this.ctlLogFile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientServerForm";
            this.Text = "ActiveXperts Network Component - C# .NET TCP Client Sample";
            this.Load += new System.EventHandler(this.ClientServerForm_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox ctlClientResult;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button ctlClientSend;
        internal System.Windows.Forms.TextBox ctlClientCommand;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button ctlClientDisconnect;
        internal System.Windows.Forms.Button ctlClientConnect;
        internal System.Windows.Forms.TextBox ctlClientHost;
        internal System.Windows.Forms.TextBox ctlClientPort;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button ctlServerDisconnect;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox ctlServerPort;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox ctlServerResult;
        internal System.Windows.Forms.TextBox ctlServerReceived;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer;
        internal System.Windows.Forms.Button ctlServerListenStop;
        internal System.Windows.Forms.Button ctlServerListenStart;
        private System.Windows.Forms.Button ctlView;
        private System.Windows.Forms.TextBox ctlLogFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ctlServerVersion;
    }
}