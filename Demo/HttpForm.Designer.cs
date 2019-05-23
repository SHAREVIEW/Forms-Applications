namespace Demo
{
    partial class HttpForm
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
            this.ctlAccount = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.ctlAllowSSL2 = new System.Windows.Forms.CheckBox();
            this.ctlGo = new System.Windows.Forms.Button();
            this.ctlServer = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.ctlStatusCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ctlView = new System.Windows.Forms.Button();
            this.ctlLogFile = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ctlResult = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.ctlOutput = new System.Windows.Forms.TextBox();
            this.ctlProxyPassword = new System.Windows.Forms.TextBox();
            this.ctlPassword = new System.Windows.Forms.TextBox();
            this.ctlProxyAccount = new System.Windows.Forms.TextBox();
            this.ctlProxyServer = new System.Windows.Forms.TextBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ctlAllowSSL3 = new System.Windows.Forms.CheckBox();
            this.ctlAllowTLS1 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlAccount
            // 
            this.ctlAccount.Location = new System.Drawing.Point(100, 24);
            this.ctlAccount.Name = "ctlAccount";
            this.ctlAccount.Size = new System.Drawing.Size(172, 20);
            this.ctlAccount.TabIndex = 1;
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(288, 27);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(120, 16);
            this.Label7.TabIndex = 2;
            this.Label7.Text = "Web Pass&word:";
            // 
            // ctlAllowSSL2
            // 
            this.ctlAllowSSL2.Location = new System.Drawing.Point(406, 43);
            this.ctlAllowSSL2.Name = "ctlAllowSSL2";
            this.ctlAllowSSL2.Size = new System.Drawing.Size(82, 16);
            this.ctlAllowSSL2.TabIndex = 5;
            this.ctlAllowSSL2.Text = "Allow SSL&2";
            // 
            // ctlGo
            // 
            this.ctlGo.Location = new System.Drawing.Point(484, 20);
            this.ctlGo.Name = "ctlGo";
            this.ctlGo.Size = new System.Drawing.Size(70, 21);
            this.ctlGo.TabIndex = 6;
            this.ctlGo.Text = "&Go";
            this.ctlGo.Click += new System.EventHandler(this.ctlGo_Click);
            // 
            // ctlServer
            // 
            this.ctlServer.Location = new System.Drawing.Point(100, 20);
            this.ctlServer.Name = "ctlServer";
            this.ctlServer.Size = new System.Drawing.Size(376, 20);
            this.ctlServer.TabIndex = 1;
            this.ctlServer.Text = "https://www.activexperts.com/network-component";
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(16, 27);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(80, 16);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "Web &Account:";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.ctlStatusCode);
            this.GroupBox2.Controls.Add(this.label10);
            this.GroupBox2.Controls.Add(this.ctlView);
            this.GroupBox2.Controls.Add(this.ctlLogFile);
            this.GroupBox2.Controls.Add(this.label9);
            this.GroupBox2.Controls.Add(this.label8);
            this.GroupBox2.Controls.Add(this.ctlResult);
            this.GroupBox2.Controls.Add(this.Label1);
            this.GroupBox2.Controls.Add(this.ctlOutput);
            this.GroupBox2.Location = new System.Drawing.Point(12, 251);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(564, 288);
            this.GroupBox2.TabIndex = 8;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Tag = "Result";
            this.GroupBox2.Text = "Result";
            // 
            // ctlStatusCode
            // 
            this.ctlStatusCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlStatusCode.Location = new System.Drawing.Point(100, 204);
            this.ctlStatusCode.Name = "ctlStatusCode";
            this.ctlStatusCode.ReadOnly = true;
            this.ctlStatusCode.Size = new System.Drawing.Size(455, 20);
            this.ctlStatusCode.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Status Code:";
            // 
            // ctlView
            // 
            this.ctlView.Location = new System.Drawing.Point(485, 255);
            this.ctlView.Name = "ctlView";
            this.ctlView.Size = new System.Drawing.Size(70, 21);
            this.ctlView.TabIndex = 8;
            this.ctlView.Text = "&View";
            this.ctlView.Click += new System.EventHandler(this.ctlView_Click);
            // 
            // ctlLogFile
            // 
            this.ctlLogFile.Location = new System.Drawing.Point(100, 254);
            this.ctlLogFile.Name = "ctlLogFile";
            this.ctlLogFile.Size = new System.Drawing.Size(380, 20);
            this.ctlLogFile.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(16, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "&Logfile:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(16, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Received:";
            // 
            // ctlResult
            // 
            this.ctlResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlResult.Location = new System.Drawing.Point(100, 230);
            this.ctlResult.Name = "ctlResult";
            this.ctlResult.ReadOnly = true;
            this.ctlResult.Size = new System.Drawing.Size(454, 20);
            this.ctlResult.TabIndex = 5;
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(16, 234);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(56, 16);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Result:";
            // 
            // ctlOutput
            // 
            this.ctlOutput.Location = new System.Drawing.Point(100, 24);
            this.ctlOutput.Multiline = true;
            this.ctlOutput.Name = "ctlOutput";
            this.ctlOutput.ReadOnly = true;
            this.ctlOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ctlOutput.Size = new System.Drawing.Size(455, 172);
            this.ctlOutput.TabIndex = 1;
            // 
            // ctlProxyPassword
            // 
            this.ctlProxyPassword.Location = new System.Drawing.Point(387, 49);
            this.ctlProxyPassword.Name = "ctlProxyPassword";
            this.ctlProxyPassword.Size = new System.Drawing.Size(167, 20);
            this.ctlProxyPassword.TabIndex = 5;
            // 
            // ctlPassword
            // 
            this.ctlPassword.Location = new System.Drawing.Point(386, 24);
            this.ctlPassword.Name = "ctlPassword";
            this.ctlPassword.PasswordChar = '*';
            this.ctlPassword.Size = new System.Drawing.Size(168, 20);
            this.ctlPassword.TabIndex = 3;
            // 
            // ctlProxyAccount
            // 
            this.ctlProxyAccount.Location = new System.Drawing.Point(100, 49);
            this.ctlProxyAccount.Name = "ctlProxyAccount";
            this.ctlProxyAccount.Size = new System.Drawing.Size(172, 20);
            this.ctlProxyAccount.TabIndex = 3;
            // 
            // ctlProxyServer
            // 
            this.ctlProxyServer.Location = new System.Drawing.Point(100, 24);
            this.ctlProxyServer.Name = "ctlProxyServer";
            this.ctlProxyServer.Size = new System.Drawing.Size(173, 20);
            this.ctlProxyServer.TabIndex = 1;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.ctlProxyPassword);
            this.GroupBox3.Controls.Add(this.ctlProxyAccount);
            this.GroupBox3.Controls.Add(this.ctlProxyServer);
            this.GroupBox3.Controls.Add(this.Label5);
            this.GroupBox3.Controls.Add(this.Label4);
            this.GroupBox3.Controls.Add(this.Label3);
            this.GroupBox3.Location = new System.Drawing.Point(12, 95);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(563, 81);
            this.GroupBox3.TabIndex = 1;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Proxy (leave blank if you do not use a proxy server)";
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(287, 52);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(96, 16);
            this.Label5.TabIndex = 4;
            this.Label5.Text = "Pr&oxy Password:";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(16, 52);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(80, 16);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "P&roxy Account:";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(16, 27);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(80, 16);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "&Proxy Server:";
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.ctlPassword);
            this.GroupBox4.Controls.Add(this.ctlAccount);
            this.GroupBox4.Controls.Add(this.Label7);
            this.GroupBox4.Controls.Add(this.Label6);
            this.GroupBox4.Location = new System.Drawing.Point(12, 184);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(564, 59);
            this.GroupBox4.TabIndex = 2;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Authentication (leave blank if not required)";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(16, 24);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(49, 16);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "&Website:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.label11);
            this.GroupBox1.Controls.Add(this.ctlAllowTLS1);
            this.GroupBox1.Controls.Add(this.ctlAllowSSL3);
            this.GroupBox1.Controls.Add(this.ctlAllowSSL2);
            this.GroupBox1.Controls.Add(this.ctlGo);
            this.GroupBox1.Controls.Add(this.ctlServer);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(563, 72);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Settings";
            // 
            // ctlAllowSSL3
            // 
            this.ctlAllowSSL3.Location = new System.Drawing.Point(316, 43);
            this.ctlAllowSSL3.Name = "ctlAllowSSL3";
            this.ctlAllowSSL3.Size = new System.Drawing.Size(82, 16);
            this.ctlAllowSSL3.TabIndex = 4;
            this.ctlAllowSSL3.Text = "Allow SSL&3";
            // 
            // ctlAllowTLS1
            // 
            this.ctlAllowTLS1.Location = new System.Drawing.Point(225, 43);
            this.ctlAllowTLS1.Name = "ctlAllowTLS1";
            this.ctlAllowTLS1.Size = new System.Drawing.Size(82, 16);
            this.ctlAllowTLS1.TabIndex = 3;
            this.ctlAllowTLS1.Text = "Allow TLS&1";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(98, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "For secure connections:";
            // 
            // HttpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 548);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HttpForm";
            this.Text = "ActiveXperts Network Component - C# .NET HTTP Sample";
            this.Load += new System.EventHandler(this.HttpForm_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TextBox ctlAccount;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.CheckBox ctlAllowSSL2;
        internal System.Windows.Forms.Button ctlGo;
        internal System.Windows.Forms.TextBox ctlServer;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.Button ctlView;
        private System.Windows.Forms.TextBox ctlLogFile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox ctlResult;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox ctlOutput;
        internal System.Windows.Forms.TextBox ctlProxyPassword;
        internal System.Windows.Forms.TextBox ctlPassword;
        internal System.Windows.Forms.TextBox ctlProxyAccount;
        internal System.Windows.Forms.TextBox ctlProxyServer;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox ctlStatusCode;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.CheckBox ctlAllowTLS1;
        internal System.Windows.Forms.CheckBox ctlAllowSSL3;
        internal System.Windows.Forms.Label label11;
    }
}