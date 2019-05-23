namespace Demo
{
    partial class NtpForm
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ctlLogFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ctlResult = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.ButtonQuery = new System.Windows.Forms.Button();
            this.ctlServer = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlView
            // 
            this.ctlView.Location = new System.Drawing.Point(392, 78);
            this.ctlView.Name = "ctlView";
            this.ctlView.Size = new System.Drawing.Size(72, 22);
            this.ctlView.TabIndex = 7;
            this.ctlView.Text = "&View";
            this.ctlView.Click += new System.EventHandler(this.ctlView_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ctlView);
            this.GroupBox1.Controls.Add(this.ctlLogFile);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.ctlResult);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.ButtonQuery);
            this.GroupBox1.Controls.Add(this.ctlServer);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(472, 111);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "NTP Time Server";
            // 
            // ctlLogFile
            // 
            this.ctlLogFile.Location = new System.Drawing.Point(81, 78);
            this.ctlLogFile.Name = "ctlLogFile";
            this.ctlLogFile.Size = new System.Drawing.Size(305, 20);
            this.ctlLogFile.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "&Logfile:";
            // 
            // ctlResult
            // 
            this.ctlResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlResult.Location = new System.Drawing.Point(81, 52);
            this.ctlResult.Name = "ctlResult";
            this.ctlResult.ReadOnly = true;
            this.ctlResult.Size = new System.Drawing.Size(383, 20);
            this.ctlResult.TabIndex = 4;
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(8, 55);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 16);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Result:";
            // 
            // ButtonQuery
            // 
            this.ButtonQuery.Location = new System.Drawing.Point(392, 24);
            this.ButtonQuery.Name = "ButtonQuery";
            this.ButtonQuery.Size = new System.Drawing.Size(72, 22);
            this.ButtonQuery.TabIndex = 2;
            this.ButtonQuery.Text = "&Query";
            this.ButtonQuery.Click += new System.EventHandler(this.ButtonQuery_Click);
            // 
            // ctlServer
            // 
            this.ctlServer.Location = new System.Drawing.Point(81, 24);
            this.ctlServer.Name = "ctlServer";
            this.ctlServer.Size = new System.Drawing.Size(305, 20);
            this.ctlServer.TabIndex = 1;
            this.ctlServer.Text = "ntp.activexperts-labs.com";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(8, 28);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "&Time Server:";
            // 
            // NtpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 132);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NtpForm";
            this.Text = "ActiveXperts Network Component - C# .NET NTP Sample";
            this.Load += new System.EventHandler(this.NtpForm_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ctlView;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.TextBox ctlLogFile;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox ctlResult;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button ButtonQuery;
        internal System.Windows.Forms.TextBox ctlServer;
        internal System.Windows.Forms.Label Label1;
    }
}