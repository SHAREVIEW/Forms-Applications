namespace Demo
{
    partial class IcmpForm
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
            this.ctlView = new System.Windows.Forms.Button();
            this.ctlLogFile = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.ctlPing = new System.Windows.Forms.Button();
            this.ctlResult = new System.Windows.Forms.TextBox();
            this.ctlTTL = new System.Windows.Forms.TextBox();
            this.ctlTimeout = new System.Windows.Forms.TextBox();
            this.ctlHost = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlView
            // 
            this.ctlView.Location = new System.Drawing.Point(440, 120);
            this.ctlView.Name = "ctlView";
            this.ctlView.Size = new System.Drawing.Size(72, 22);
            this.ctlView.TabIndex = 13;
            this.ctlView.Text = "&View";
            this.ctlView.Click += new System.EventHandler(this.ctlView_Click);
            // 
            // ctlLogFile
            // 
            this.ctlLogFile.Location = new System.Drawing.Point(96, 120);
            this.ctlLogFile.Name = "ctlLogFile";
            this.ctlLogFile.Size = new System.Drawing.Size(336, 20);
            this.ctlLogFile.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(16, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "&Logfile:";
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(240, 72);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(120, 16);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "(like the \'ping -i\' option)";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ctlView);
            this.GroupBox1.Controls.Add(this.ctlLogFile);
            this.GroupBox1.Controls.Add(this.label7);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.ctlPing);
            this.GroupBox1.Controls.Add(this.ctlResult);
            this.GroupBox1.Controls.Add(this.ctlTTL);
            this.GroupBox1.Controls.Add(this.ctlTimeout);
            this.GroupBox1.Controls.Add(this.ctlHost);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(528, 152);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "ICMP Ping";
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(240, 48);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(192, 16);
            this.Label5.TabIndex = 9;
            this.Label5.Text = "(like the \'ping -w\' option)";
            // 
            // ctlPing
            // 
            this.ctlPing.Location = new System.Drawing.Point(440, 24);
            this.ctlPing.Name = "ctlPing";
            this.ctlPing.Size = new System.Drawing.Size(72, 22);
            this.ctlPing.TabIndex = 8;
            this.ctlPing.Text = "&Ping";
            this.ctlPing.Click += new System.EventHandler(this.ctlPing_Click);
            // 
            // ctlResult
            // 
            this.ctlResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlResult.Location = new System.Drawing.Point(96, 96);
            this.ctlResult.Name = "ctlResult";
            this.ctlResult.ReadOnly = true;
            this.ctlResult.Size = new System.Drawing.Size(416, 20);
            this.ctlResult.TabIndex = 7;
            // 
            // ctlTTL
            // 
            this.ctlTTL.Location = new System.Drawing.Point(96, 72);
            this.ctlTTL.Name = "ctlTTL";
            this.ctlTTL.Size = new System.Drawing.Size(136, 20);
            this.ctlTTL.TabIndex = 6;
            this.ctlTTL.Text = "255";
            // 
            // ctlTimeout
            // 
            this.ctlTimeout.Location = new System.Drawing.Point(96, 48);
            this.ctlTimeout.Name = "ctlTimeout";
            this.ctlTimeout.Size = new System.Drawing.Size(136, 20);
            this.ctlTimeout.TabIndex = 5;
            this.ctlTimeout.Text = "5000";
            // 
            // ctlHost
            // 
            this.ctlHost.Location = new System.Drawing.Point(96, 24);
            this.ctlHost.Name = "ctlHost";
            this.ctlHost.Size = new System.Drawing.Size(336, 20);
            this.ctlHost.TabIndex = 4;
            this.ctlHost.Text = "www.activexperts.com";
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(16, 100);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(64, 16);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Result:";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(16, 76);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(80, 16);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Ti&me To Live:";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(16, 52);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(80, 16);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "&Timeout (ms):";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 28);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "&Host:";
            // 
            // IcmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 177);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IcmpForm";
            this.Text = "ActiveXperts Network Component - C# .NET ICMP Sample";
            this.Load += new System.EventHandler(this.IcmpForm_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ctlView;
        private System.Windows.Forms.TextBox ctlLogFile;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button ctlPing;
        internal System.Windows.Forms.TextBox ctlResult;
        internal System.Windows.Forms.TextBox ctlTTL;
        internal System.Windows.Forms.TextBox ctlTimeout;
        internal System.Windows.Forms.TextBox ctlHost;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}