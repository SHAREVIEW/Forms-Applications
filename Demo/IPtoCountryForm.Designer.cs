namespace Demo
{
    partial class IPtoCountryForm
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
            this.ctlQuery = new System.Windows.Forms.Button();
            this.ctlLogFile = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ctlResult = new System.Windows.Forms.TextBox();
            this.ctlCountryCode = new System.Windows.Forms.TextBox();
            this.ctlCountry = new System.Windows.Forms.TextBox();
            this.ctlHost = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ctlCountryCodeEx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlView
            // 
            this.ctlView.Location = new System.Drawing.Point(472, 148);
            this.ctlView.Name = "ctlView";
            this.ctlView.Size = new System.Drawing.Size(72, 22);
            this.ctlView.TabIndex = 11;
            this.ctlView.Text = "&View";
            this.ctlView.Click += new System.EventHandler(this.ctlView_Click);
            // 
            // ctlQuery
            // 
            this.ctlQuery.Location = new System.Drawing.Point(472, 24);
            this.ctlQuery.Name = "ctlQuery";
            this.ctlQuery.Size = new System.Drawing.Size(72, 22);
            this.ctlQuery.TabIndex = 10;
            this.ctlQuery.Text = "&Query";
            this.ctlQuery.Click += new System.EventHandler(this.ctlQuery_Click);
            // 
            // ctlLogFile
            // 
            this.ctlLogFile.Location = new System.Drawing.Point(136, 148);
            this.ctlLogFile.Name = "ctlLogFile";
            this.ctlLogFile.Size = new System.Drawing.Size(328, 20);
            this.ctlLogFile.TabIndex = 9;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ctlCountryCodeEx);
            this.GroupBox1.Controls.Add(this.label6);
            this.GroupBox1.Controls.Add(this.ctlView);
            this.GroupBox1.Controls.Add(this.ctlQuery);
            this.GroupBox1.Controls.Add(this.ctlLogFile);
            this.GroupBox1.Controls.Add(this.ctlResult);
            this.GroupBox1.Controls.Add(this.ctlCountryCode);
            this.GroupBox1.Controls.Add(this.ctlCountry);
            this.GroupBox1.Controls.Add(this.ctlHost);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(11, 8);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(552, 178);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "IP to Country";
            // 
            // ctlResult
            // 
            this.ctlResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlResult.Location = new System.Drawing.Point(136, 124);
            this.ctlResult.Name = "ctlResult";
            this.ctlResult.ReadOnly = true;
            this.ctlResult.Size = new System.Drawing.Size(328, 20);
            this.ctlResult.TabIndex = 8;
            // 
            // ctlCountryCode
            // 
            this.ctlCountryCode.Location = new System.Drawing.Point(136, 72);
            this.ctlCountryCode.Name = "ctlCountryCode";
            this.ctlCountryCode.ReadOnly = true;
            this.ctlCountryCode.Size = new System.Drawing.Size(168, 20);
            this.ctlCountryCode.TabIndex = 7;
            // 
            // ctlCountry
            // 
            this.ctlCountry.Location = new System.Drawing.Point(136, 48);
            this.ctlCountry.Name = "ctlCountry";
            this.ctlCountry.ReadOnly = true;
            this.ctlCountry.Size = new System.Drawing.Size(328, 20);
            this.ctlCountry.TabIndex = 6;
            // 
            // ctlHost
            // 
            this.ctlHost.Location = new System.Drawing.Point(136, 24);
            this.ctlHost.Name = "ctlHost";
            this.ctlHost.Size = new System.Drawing.Size(328, 20);
            this.ctlHost.TabIndex = 5;
            this.ctlHost.Text = "forum.activexperts.com";
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(16, 148);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(100, 16);
            this.Label5.TabIndex = 4;
            this.Label5.Text = "&LogFile:";
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(16, 128);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(84, 16);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Result:";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(16, 76);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(100, 16);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Country Code:";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(16, 52);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(80, 16);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Country:";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 28);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(120, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "&Host (IP or hostname):";
            // 
            // ctlCountryCodeEx
            // 
            this.ctlCountryCodeEx.Location = new System.Drawing.Point(136, 98);
            this.ctlCountryCodeEx.Name = "ctlCountryCodeEx";
            this.ctlCountryCodeEx.ReadOnly = true;
            this.ctlCountryCodeEx.Size = new System.Drawing.Size(168, 20);
            this.ctlCountryCodeEx.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(16, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Country Code Ex:";
            // 
            // IPtoCountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 200);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IPtoCountryForm";
            this.Text = "ActiveXperts Network Component - C# .NET IP to Country Sample";
            this.Load += new System.EventHandler(this.IPtoCountryForm_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button ctlView;
        internal System.Windows.Forms.Button ctlQuery;
        internal System.Windows.Forms.TextBox ctlLogFile;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox ctlResult;
        internal System.Windows.Forms.TextBox ctlCountryCode;
        internal System.Windows.Forms.TextBox ctlCountry;
        internal System.Windows.Forms.TextBox ctlHost;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox ctlCountryCodeEx;
        internal System.Windows.Forms.Label label6;
    }
}