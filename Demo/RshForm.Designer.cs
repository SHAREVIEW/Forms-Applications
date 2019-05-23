namespace Demo
{
    partial class RshForm
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
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.ctlRun = new System.Windows.Forms.Button();
            this.ctlUser = new System.Windows.Forms.TextBox();
            this.ctlTimeout = new System.Windows.Forms.TextBox();
            this.ctlCommand = new System.Windows.Forms.TextBox();
            this.ctlHost = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.ctlView = new System.Windows.Forms.Button();
            this.ctlLogFile = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ctlStdErr = new System.Windows.Forms.TextBox();
            this.ctlStdOut = new System.Windows.Forms.TextBox();
            this.ctlResult = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(216, 95);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(168, 24);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "(username to use on host)";
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(216, 71);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(72, 16);
            this.Label5.TabIndex = 9;
            this.Label5.Text = "millisecs";
            // 
            // ctlRun
            // 
            this.ctlRun.Location = new System.Drawing.Point(72, 119);
            this.ctlRun.Name = "ctlRun";
            this.ctlRun.Size = new System.Drawing.Size(384, 22);
            this.ctlRun.TabIndex = 8;
            this.ctlRun.Text = "&Run Command";
            this.ctlRun.Click += new System.EventHandler(this.ctlRun_Click);
            // 
            // ctlUser
            // 
            this.ctlUser.Location = new System.Drawing.Point(72, 91);
            this.ctlUser.Name = "ctlUser";
            this.ctlUser.Size = new System.Drawing.Size(136, 20);
            this.ctlUser.TabIndex = 7;
            this.ctlUser.Text = "root";
            // 
            // ctlTimeout
            // 
            this.ctlTimeout.Location = new System.Drawing.Point(72, 67);
            this.ctlTimeout.Name = "ctlTimeout";
            this.ctlTimeout.Size = new System.Drawing.Size(136, 20);
            this.ctlTimeout.TabIndex = 6;
            this.ctlTimeout.Text = "5000";
            // 
            // ctlCommand
            // 
            this.ctlCommand.Location = new System.Drawing.Point(72, 43);
            this.ctlCommand.Name = "ctlCommand";
            this.ctlCommand.Size = new System.Drawing.Size(384, 20);
            this.ctlCommand.TabIndex = 5;
            this.ctlCommand.Text = "/bin/ls -als $HOME";
            // 
            // ctlHost
            // 
            this.ctlHost.Location = new System.Drawing.Point(72, 19);
            this.ctlHost.Name = "ctlHost";
            this.ctlHost.Size = new System.Drawing.Size(384, 20);
            this.ctlHost.TabIndex = 4;
            this.ctlHost.Text = "192.168.31.98";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(16, 71);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(48, 16);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "&Timeout:";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(16, 95);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(48, 16);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "&User:";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(16, 47);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(96, 24);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "&Command:";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.ctlView);
            this.GroupBox2.Controls.Add(this.ctlLogFile);
            this.GroupBox2.Controls.Add(this.label10);
            this.GroupBox2.Controls.Add(this.ctlStdErr);
            this.GroupBox2.Controls.Add(this.ctlStdOut);
            this.GroupBox2.Controls.Add(this.ctlResult);
            this.GroupBox2.Controls.Add(this.Label9);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Location = new System.Drawing.Point(12, 167);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(464, 272);
            this.GroupBox2.TabIndex = 5;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Result";
            // 
            // ctlView
            // 
            this.ctlView.Location = new System.Drawing.Point(384, 43);
            this.ctlView.Name = "ctlView";
            this.ctlView.Size = new System.Drawing.Size(72, 22);
            this.ctlView.TabIndex = 8;
            this.ctlView.Text = "&View";
            this.ctlView.Click += new System.EventHandler(this.ctlView_Click);
            // 
            // ctlLogFile
            // 
            this.ctlLogFile.Location = new System.Drawing.Point(72, 43);
            this.ctlLogFile.Name = "ctlLogFile";
            this.ctlLogFile.Size = new System.Drawing.Size(304, 20);
            this.ctlLogFile.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(16, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "&Logfile:";
            // 
            // ctlStdErr
            // 
            this.ctlStdErr.Location = new System.Drawing.Point(72, 163);
            this.ctlStdErr.Multiline = true;
            this.ctlStdErr.Name = "ctlStdErr";
            this.ctlStdErr.ReadOnly = true;
            this.ctlStdErr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ctlStdErr.Size = new System.Drawing.Size(384, 96);
            this.ctlStdErr.TabIndex = 5;
            // 
            // ctlStdOut
            // 
            this.ctlStdOut.Location = new System.Drawing.Point(72, 67);
            this.ctlStdOut.Multiline = true;
            this.ctlStdOut.Name = "ctlStdOut";
            this.ctlStdOut.ReadOnly = true;
            this.ctlStdOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ctlStdOut.Size = new System.Drawing.Size(384, 88);
            this.ctlStdOut.TabIndex = 4;
            // 
            // ctlResult
            // 
            this.ctlResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlResult.Location = new System.Drawing.Point(72, 19);
            this.ctlResult.Name = "ctlResult";
            this.ctlResult.ReadOnly = true;
            this.ctlResult.Size = new System.Drawing.Size(384, 20);
            this.ctlResult.TabIndex = 3;
            // 
            // Label9
            // 
            this.Label9.Location = new System.Drawing.Point(16, 163);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(48, 20);
            this.Label9.TabIndex = 2;
            this.Label9.Text = "Std&Err:";
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(16, 67);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(72, 16);
            this.Label8.TabIndex = 1;
            this.Label8.Text = "Std&Out:";
            // 
            // Label7
            // 
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(16, 23);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(80, 16);
            this.Label7.TabIndex = 0;
            this.Label7.Text = "Result:";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 23);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(104, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "&Host:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.ctlRun);
            this.GroupBox1.Controls.Add(this.ctlUser);
            this.GroupBox1.Controls.Add(this.ctlTimeout);
            this.GroupBox1.Controls.Add(this.ctlCommand);
            this.GroupBox1.Controls.Add(this.ctlHost);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 7);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(464, 152);
            this.GroupBox1.TabIndex = 4;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "RSH Session";
            // 
            // RshForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 455);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RshForm";
            this.Text = "ActiveXperts Network Component - C# .NET RSH Sample";
            this.Load += new System.EventHandler(this.RshForm_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button ctlRun;
        internal System.Windows.Forms.TextBox ctlUser;
        internal System.Windows.Forms.TextBox ctlTimeout;
        internal System.Windows.Forms.TextBox ctlCommand;
        internal System.Windows.Forms.TextBox ctlHost;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
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
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox GroupBox1;
    }
}