namespace Demo
{
    partial class SnmpTrapFormAdvanced
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnmpTrapFormAdvanced));
            this.ctlPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctlMibFile = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ctlBrowse = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlPort
            // 
            this.ctlPort.Location = new System.Drawing.Point(112, 24);
            this.ctlPort.Name = "ctlPort";
            this.ctlPort.Size = new System.Drawing.Size(64, 20);
            this.ctlPort.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "&SNMP Port:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(524, 56);
            this.label2.TabIndex = 25;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // ctlMibFile
            // 
            this.ctlMibFile.Location = new System.Drawing.Point(112, 48);
            this.ctlMibFile.Name = "ctlMibFile";
            this.ctlMibFile.Size = new System.Drawing.Size(316, 20);
            this.ctlMibFile.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(12, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "&MIB File (optional):";
            // 
            // ctlBrowse
            // 
            this.ctlBrowse.Location = new System.Drawing.Point(444, 48);
            this.ctlBrowse.Name = "ctlBrowse";
            this.ctlBrowse.Size = new System.Drawing.Size(72, 22);
            this.ctlBrowse.TabIndex = 26;
            this.ctlBrowse.Text = "&Browse...";
            this.ctlBrowse.Click += new System.EventHandler(this.ctlBrowse_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ctlPort);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ctlMibFile);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.ctlBrowse);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 88);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Advanced SNMP Settings";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(456, 180);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 24);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(372, 180);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(72, 24);
            this.btnOK.TabIndex = 26;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // SnmpTrapFormAdvanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 215);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SnmpTrapFormAdvanced";
            this.Text = "Advanced SNMP Trap Settings";
            this.Load += new System.EventHandler(this.SnmpTrapFormAdvanced_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ctlPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox ctlMibFile;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Button ctlBrowse;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnOK;
    }
}