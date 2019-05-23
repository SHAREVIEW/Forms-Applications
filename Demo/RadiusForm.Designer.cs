namespace Demo
{
    partial class RadiusForm
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ctlSecret = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ctlPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ctlCheckAccess = new System.Windows.Forms.Button();
            this.ctlUser = new System.Windows.Forms.TextBox();
            this.ctlHost = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.ctlLogfile = new System.Windows.Forms.TextBox();
            this.ctlResult = new System.Windows.Forms.TextBox();
            this.ctlView = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textPort = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboProtocol = new System.Windows.Forms.ComboBox();
            this.GroupBox1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.comboProtocol);
            this.GroupBox1.Controls.Add(this.label8);
            this.GroupBox1.Controls.Add(this.textPort);
            this.GroupBox1.Controls.Add(this.label6);
            this.GroupBox1.Controls.Add(this.ctlSecret);
            this.GroupBox1.Controls.Add(this.label7);
            this.GroupBox1.Controls.Add(this.ctlPassword);
            this.GroupBox1.Controls.Add(this.label4);
            this.GroupBox1.Controls.Add(this.ctlCheckAccess);
            this.GroupBox1.Controls.Add(this.ctlUser);
            this.GroupBox1.Controls.Add(this.ctlHost);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(5, 6);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(464, 150);
            this.GroupBox1.TabIndex = 5;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Radius Server";
            // 
            // ctlSecret
            // 
            this.ctlSecret.Location = new System.Drawing.Point(72, 97);
            this.ctlSecret.Name = "ctlSecret";
            this.ctlSecret.Size = new System.Drawing.Size(136, 20);
            this.ctlSecret.TabIndex = 11;
            this.ctlSecret.Text = "AxSecret";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(16, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "&Secret:";
            // 
            // ctlPassword
            // 
            this.ctlPassword.Location = new System.Drawing.Point(72, 71);
            this.ctlPassword.Name = "ctlPassword";
            this.ctlPassword.Size = new System.Drawing.Size(136, 20);
            this.ctlPassword.TabIndex = 9;
            this.ctlPassword.Text = "demo";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "&Password:";
            // 
            // ctlCheckAccess
            // 
            this.ctlCheckAccess.Location = new System.Drawing.Point(72, 123);
            this.ctlCheckAccess.Name = "ctlCheckAccess";
            this.ctlCheckAccess.Size = new System.Drawing.Size(384, 22);
            this.ctlCheckAccess.TabIndex = 12;
            this.ctlCheckAccess.Text = "&Check Access";
            this.ctlCheckAccess.Click += new System.EventHandler(this.ctlCheckAccess_Click);
            // 
            // ctlUser
            // 
            this.ctlUser.Location = new System.Drawing.Point(72, 45);
            this.ctlUser.Name = "ctlUser";
            this.ctlUser.Size = new System.Drawing.Size(136, 20);
            this.ctlUser.TabIndex = 5;
            this.ctlUser.Text = "demo";
            // 
            // ctlHost
            // 
            this.ctlHost.Location = new System.Drawing.Point(72, 19);
            this.ctlHost.Name = "ctlHost";
            this.ctlHost.Size = new System.Drawing.Size(225, 20);
            this.ctlHost.TabIndex = 1;
            this.ctlHost.Text = "srv202.activexperts-labs.com";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(16, 49);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(48, 16);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "&User:";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 23);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(104, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "&Host:";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.ctlLogfile);
            this.GroupBox3.Controls.Add(this.ctlResult);
            this.GroupBox3.Controls.Add(this.ctlView);
            this.GroupBox3.Controls.Add(this.label2);
            this.GroupBox3.Controls.Add(this.Label5);
            this.GroupBox3.Location = new System.Drawing.Point(5, 162);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(464, 74);
            this.GroupBox3.TabIndex = 9;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Result";
            // 
            // ctlLogfile
            // 
            this.ctlLogfile.Location = new System.Drawing.Point(64, 45);
            this.ctlLogfile.Name = "ctlLogfile";
            this.ctlLogfile.Size = new System.Drawing.Size(320, 20);
            this.ctlLogfile.TabIndex = 16;
            // 
            // ctlResult
            // 
            this.ctlResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlResult.Location = new System.Drawing.Point(64, 21);
            this.ctlResult.Name = "ctlResult";
            this.ctlResult.ReadOnly = true;
            this.ctlResult.Size = new System.Drawing.Size(392, 20);
            this.ctlResult.TabIndex = 14;
            // 
            // ctlView
            // 
            this.ctlView.Location = new System.Drawing.Point(390, 45);
            this.ctlView.Name = "ctlView";
            this.ctlView.Size = new System.Drawing.Size(66, 21);
            this.ctlView.TabIndex = 17;
            this.ctlView.Text = "&View";
            this.ctlView.Click += new System.EventHandler(this.ctlView_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "&Logfile:";
            // 
            // Label5
            // 
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(16, 25);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(120, 16);
            this.Label5.TabIndex = 13;
            this.Label5.Text = "Result:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "P&ort:";
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(369, 19);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(87, 20);
            this.textPort.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "P&rotocol:";
            // 
            // comboProtocol
            // 
            this.comboProtocol.FormattingEnabled = true;
            this.comboProtocol.Items.AddRange(new object[] {
            "PAP",
            "CHAP"});
            this.comboProtocol.Location = new System.Drawing.Point(369, 46);
            this.comboProtocol.Name = "comboProtocol";
            this.comboProtocol.Size = new System.Drawing.Size(87, 21);
            this.comboProtocol.TabIndex = 7;
            // 
            // RadiusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 247);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RadiusForm";
            this.Text = "RadiusForm";
            this.Load += new System.EventHandler(this.RadiusForm_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button ctlCheckAccess;
        internal System.Windows.Forms.TextBox ctlUser;
        internal System.Windows.Forms.TextBox ctlHost;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox ctlSecret;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox ctlPassword;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.TextBox ctlLogfile;
        internal System.Windows.Forms.TextBox ctlResult;
        internal System.Windows.Forms.Button ctlView;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label Label5;
        private System.Windows.Forms.ComboBox comboProtocol;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Label label6;
    }
}