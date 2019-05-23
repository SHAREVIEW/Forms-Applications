namespace Demo
{
    partial class HttpPostForm
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
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.ctlView = new System.Windows.Forms.Button();
            this.ctlLogFile = new System.Windows.Forms.TextBox();
            this.ctlResult = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.ctlResponse = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ctlSend = new System.Windows.Forms.Button();
            this.ctlPostData = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ctlUrl = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.ctlStatusCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.ctlStatusCode);
            this.GroupBox3.Controls.Add(this.label10);
            this.GroupBox3.Controls.Add(this.ctlView);
            this.GroupBox3.Controls.Add(this.ctlLogFile);
            this.GroupBox3.Controls.Add(this.ctlResult);
            this.GroupBox3.Controls.Add(this.Label7);
            this.GroupBox3.Controls.Add(this.Label6);
            this.GroupBox3.Controls.Add(this.ctlResponse);
            this.GroupBox3.Controls.Add(this.Label5);
            this.GroupBox3.Location = new System.Drawing.Point(12, 131);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(568, 247);
            this.GroupBox3.TabIndex = 8;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Result";
            // 
            // ctlView
            // 
            this.ctlView.Location = new System.Drawing.Point(483, 219);
            this.ctlView.Name = "ctlView";
            this.ctlView.Size = new System.Drawing.Size(75, 21);
            this.ctlView.TabIndex = 6;
            this.ctlView.Text = "&View...";
            this.ctlView.Click += new System.EventHandler(this.ctlView_Click);
            // 
            // ctlLogFile
            // 
            this.ctlLogFile.Location = new System.Drawing.Point(95, 219);
            this.ctlLogFile.Name = "ctlLogFile";
            this.ctlLogFile.Size = new System.Drawing.Size(382, 20);
            this.ctlLogFile.TabIndex = 5;
            // 
            // ctlResult
            // 
            this.ctlResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlResult.Location = new System.Drawing.Point(95, 193);
            this.ctlResult.Name = "ctlResult";
            this.ctlResult.ReadOnly = true;
            this.ctlResult.Size = new System.Drawing.Size(463, 20);
            this.ctlResult.TabIndex = 4;
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(16, 224);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(92, 15);
            this.Label7.TabIndex = 3;
            this.Label7.Text = "&LogFile:";
            // 
            // Label6
            // 
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(16, 198);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(92, 16);
            this.Label6.TabIndex = 2;
            this.Label6.Text = "Result:";
            // 
            // ctlResponse
            // 
            this.ctlResponse.Location = new System.Drawing.Point(95, 17);
            this.ctlResponse.Multiline = true;
            this.ctlResponse.Name = "ctlResponse";
            this.ctlResponse.ReadOnly = true;
            this.ctlResponse.Size = new System.Drawing.Size(463, 144);
            this.ctlResponse.TabIndex = 1;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(16, 17);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(88, 16);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "Response:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ctlSend);
            this.GroupBox1.Controls.Add(this.ctlPostData);
            this.GroupBox1.Controls.Add(this.label8);
            this.GroupBox1.Controls.Add(this.ctlUrl);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 8);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(568, 115);
            this.GroupBox1.TabIndex = 6;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Web Site";
            // 
            // ctlSend
            // 
            this.ctlSend.Location = new System.Drawing.Point(95, 75);
            this.ctlSend.Name = "ctlSend";
            this.ctlSend.Size = new System.Drawing.Size(463, 23);
            this.ctlSend.TabIndex = 6;
            this.ctlSend.Text = "&Commit";
            this.ctlSend.Click += new System.EventHandler(this.ctlSend_Click);
            // 
            // ctlPostData
            // 
            this.ctlPostData.Location = new System.Drawing.Point(95, 44);
            this.ctlPostData.Name = "ctlPostData";
            this.ctlPostData.Size = new System.Drawing.Size(463, 20);
            this.ctlPostData.TabIndex = 3;
            this.ctlPostData.Text = "TXT_COMPANY_NAME=test&TXT_COMPANY_URL=test&TXT_COMPANY_EMAIL=test";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(16, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "&Post:";
            // 
            // ctlUrl
            // 
            this.ctlUrl.Location = new System.Drawing.Point(95, 18);
            this.ctlUrl.Name = "ctlUrl";
            this.ctlUrl.Size = new System.Drawing.Size(464, 20);
            this.ctlUrl.TabIndex = 1;
            this.ctlUrl.Text = "http://www.cs.tut.fi/cgi-bin/run/~jkorpela/echo.cgi";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(47, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "&URL:";
            // 
            // ctlStatusCode
            // 
            this.ctlStatusCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlStatusCode.Location = new System.Drawing.Point(95, 167);
            this.ctlStatusCode.Name = "ctlStatusCode";
            this.ctlStatusCode.ReadOnly = true;
            this.ctlStatusCode.Size = new System.Drawing.Size(463, 20);
            this.ctlStatusCode.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Status Code:";
            // 
            // HttpPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 387);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HttpPostForm";
            this.Text = "ActiveXperts Network Component - C# .NET HTTP POST Sample";
            this.Load += new System.EventHandler(this.HttpPostForm_Load);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button ctlView;
        internal System.Windows.Forms.TextBox ctlLogFile;
        internal System.Windows.Forms.TextBox ctlResult;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox ctlResponse;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox ctlPostData;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox ctlUrl;
        internal System.Windows.Forms.Button ctlSend;
        internal System.Windows.Forms.TextBox ctlStatusCode;
        private System.Windows.Forms.Label label10;
    }
}