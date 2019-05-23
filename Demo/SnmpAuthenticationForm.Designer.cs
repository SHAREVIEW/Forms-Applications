namespace Demo
{
    partial class SnmpAuthenticationForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAuthUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAuthPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxAuthProtocol = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxPrivacyProtocol = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrivacyPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtContextName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtEngineID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxAuthProtocol);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAuthPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAuthUsername);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(321, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authentication";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Username:";
            // 
            // txtAuthUsername
            // 
            this.txtAuthUsername.Location = new System.Drawing.Point(103, 20);
            this.txtAuthUsername.Name = "txtAuthUsername";
            this.txtAuthUsername.Size = new System.Drawing.Size(205, 20);
            this.txtAuthUsername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Password:";
            // 
            // txtAuthPassword
            // 
            this.txtAuthPassword.Location = new System.Drawing.Point(103, 46);
            this.txtAuthPassword.Name = "txtAuthPassword";
            this.txtAuthPassword.Size = new System.Drawing.Size(205, 20);
            this.txtAuthPassword.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "P&rotocol:";
            // 
            // cbxAuthProtocol
            // 
            this.cbxAuthProtocol.FormattingEnabled = true;
            this.cbxAuthProtocol.Items.AddRange(new object[] {
            "SHA1",
            "MD5"});
            this.cbxAuthProtocol.Location = new System.Drawing.Point(103, 72);
            this.cbxAuthProtocol.Name = "cbxAuthProtocol";
            this.cbxAuthProtocol.Size = new System.Drawing.Size(205, 21);
            this.cbxAuthProtocol.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxPrivacyProtocol);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPrivacyPassword);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(321, 76);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Privacy";
            // 
            // cbxPrivacyProtocol
            // 
            this.cbxPrivacyProtocol.FormattingEnabled = true;
            this.cbxPrivacyProtocol.Items.AddRange(new object[] {
            "DES",
            "AES"});
            this.cbxPrivacyProtocol.Location = new System.Drawing.Point(103, 46);
            this.cbxPrivacyProtocol.Name = "cbxPrivacyProtocol";
            this.cbxPrivacyProtocol.Size = new System.Drawing.Size(205, 21);
            this.cbxPrivacyProtocol.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pro&tocol:";
            // 
            // txtPrivacyPassword
            // 
            this.txtPrivacyPassword.Location = new System.Drawing.Point(103, 20);
            this.txtPrivacyPassword.Name = "txtPrivacyPassword";
            this.txtPrivacyPassword.Size = new System.Drawing.Size(205, 20);
            this.txtPrivacyPassword.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pa&ssword:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtContextName);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox3.Size = new System.Drawing.Size(321, 51);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Misc";
            // 
            // txtContextName
            // 
            this.txtContextName.Location = new System.Drawing.Point(103, 20);
            this.txtContextName.Name = "txtContextName";
            this.txtContextName.Size = new System.Drawing.Size(205, 20);
            this.txtContextName.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "&Context Name:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtEngineID);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(12, 264);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox4.Size = new System.Drawing.Size(321, 52);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Trap Receiver";
            // 
            // txtEngineID
            // 
            this.txtEngineID.Location = new System.Drawing.Point(103, 20);
            this.txtEngineID.Name = "txtEngineID";
            this.txtEngineID.Size = new System.Drawing.Size(205, 20);
            this.txtEngineID.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "&Engine ID:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(177, 322);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(258, 322);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SnmpAuthenticationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 354);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SnmpAuthenticationForm";
            this.Text = "SNMPv3 Authentication";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxAuthProtocol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAuthPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAuthUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxPrivacyProtocol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrivacyPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtContextName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtEngineID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}