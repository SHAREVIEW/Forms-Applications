namespace Demo
{
    partial class SnmpForm
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
            this.label11 = new System.Windows.Forms.Label();
            this.ctlResult = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.ctlType = new System.Windows.Forms.TextBox();
            this.ctlPort = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.ctlSet = new System.Windows.Forms.Button();
            this.ctlGetNext = new System.Windows.Forms.Button();
            this.ctlCommunity = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.ctlAgent = new System.Windows.Forms.TextBox();
            this.ctlMibFile = new System.Windows.Forms.TextBox();
            this.ctlGet = new System.Windows.Forms.Button();
            this.ctlNewValue = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ctlBrowse = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.ctlValue = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ctlVersion = new System.Windows.Forms.ComboBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.ctlOID = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ctlAuthentication = new System.Windows.Forms.Button();
            this.GroupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.ctlView);
            this.GroupBox3.Controls.Add(this.ctlLogFile);
            this.GroupBox3.Controls.Add(this.label11);
            this.GroupBox3.Controls.Add(this.ctlResult);
            this.GroupBox3.Controls.Add(this.Label9);
            this.GroupBox3.Location = new System.Drawing.Point(12, 408);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(552, 80);
            this.GroupBox3.TabIndex = 9;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Result";
            // 
            // ctlView
            // 
            this.ctlView.Location = new System.Drawing.Point(472, 48);
            this.ctlView.Name = "ctlView";
            this.ctlView.Size = new System.Drawing.Size(72, 22);
            this.ctlView.TabIndex = 4;
            this.ctlView.Text = "&View";
            this.ctlView.Click += new System.EventHandler(this.ctlView_Click);
            // 
            // ctlLogFile
            // 
            this.ctlLogFile.Location = new System.Drawing.Point(104, 48);
            this.ctlLogFile.Name = "ctlLogFile";
            this.ctlLogFile.Size = new System.Drawing.Size(360, 20);
            this.ctlLogFile.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(16, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "&Logfile:";
            // 
            // ctlResult
            // 
            this.ctlResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlResult.Location = new System.Drawing.Point(104, 24);
            this.ctlResult.Name = "ctlResult";
            this.ctlResult.ReadOnly = true;
            this.ctlResult.Size = new System.Drawing.Size(440, 20);
            this.ctlResult.TabIndex = 1;
            // 
            // Label9
            // 
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(16, 27);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(64, 16);
            this.Label9.TabIndex = 0;
            this.Label9.Text = "Result:";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(328, 52);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(48, 16);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "&Version:";
            // 
            // ctlType
            // 
            this.ctlType.Location = new System.Drawing.Point(104, 72);
            this.ctlType.Name = "ctlType";
            this.ctlType.ReadOnly = true;
            this.ctlType.Size = new System.Drawing.Size(360, 20);
            this.ctlType.TabIndex = 12;
            // 
            // ctlPort
            // 
            this.ctlPort.Location = new System.Drawing.Point(384, 24);
            this.ctlPort.Name = "ctlPort";
            this.ctlPort.Size = new System.Drawing.Size(160, 20);
            this.ctlPort.TabIndex = 6;
            this.ctlPort.Text = "161";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(328, 28);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(32, 16);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "&Port:";
            // 
            // ctlSet
            // 
            this.ctlSet.Location = new System.Drawing.Point(472, 152);
            this.ctlSet.Name = "ctlSet";
            this.ctlSet.Size = new System.Drawing.Size(72, 22);
            this.ctlSet.TabIndex = 10;
            this.ctlSet.Text = "&Set";
            this.ctlSet.Click += new System.EventHandler(this.ctlSet_Click);
            // 
            // ctlGetNext
            // 
            this.ctlGetNext.Location = new System.Drawing.Point(472, 48);
            this.ctlGetNext.Name = "ctlGetNext";
            this.ctlGetNext.Size = new System.Drawing.Size(72, 22);
            this.ctlGetNext.TabIndex = 9;
            this.ctlGetNext.Text = "Get &Next";
            this.ctlGetNext.Click += new System.EventHandler(this.ctlGetNext_Click);
            // 
            // ctlCommunity
            // 
            this.ctlCommunity.Location = new System.Drawing.Point(104, 48);
            this.ctlCommunity.Name = "ctlCommunity";
            this.ctlCommunity.Size = new System.Drawing.Size(208, 20);
            this.ctlCommunity.TabIndex = 4;
            this.ctlCommunity.Text = "public";
            // 
            // Label10
            // 
            this.Label10.Location = new System.Drawing.Point(104, 176);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(360, 48);
            this.Label10.TabIndex = 11;
            this.Label10.Text = "The \'Set\' opertaion use the above \'OID\' and \'Data Type\' parameters. It only works" +
                " with agents that accept \'Set\' calls, otherwise the \'Set\' command is just ignore" +
                "d!";
            // 
            // ctlAgent
            // 
            this.ctlAgent.Location = new System.Drawing.Point(104, 24);
            this.ctlAgent.Name = "ctlAgent";
            this.ctlAgent.Size = new System.Drawing.Size(208, 20);
            this.ctlAgent.TabIndex = 3;
            // 
            // ctlMibFile
            // 
            this.ctlMibFile.Location = new System.Drawing.Point(104, 20);
            this.ctlMibFile.Name = "ctlMibFile";
            this.ctlMibFile.Size = new System.Drawing.Size(360, 20);
            this.ctlMibFile.TabIndex = 2;
            this.ctlMibFile.Text = "c:\\windows\\system32\\hostmib.mib";
            // 
            // ctlGet
            // 
            this.ctlGet.Location = new System.Drawing.Point(472, 24);
            this.ctlGet.Name = "ctlGet";
            this.ctlGet.Size = new System.Drawing.Size(72, 22);
            this.ctlGet.TabIndex = 8;
            this.ctlGet.Text = "&Get";
            this.ctlGet.Click += new System.EventHandler(this.ctlGet_Click);
            // 
            // ctlNewValue
            // 
            this.ctlNewValue.Location = new System.Drawing.Point(104, 152);
            this.ctlNewValue.Name = "ctlNewValue";
            this.ctlNewValue.Size = new System.Drawing.Size(360, 20);
            this.ctlNewValue.TabIndex = 7;
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(16, 156);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(80, 16);
            this.Label8.TabIndex = 6;
            this.Label8.Text = "&Set new value:";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(20, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "&File:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ctlMibFile);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.ctlBrowse);
            this.groupBox4.Location = new System.Drawing.Point(12, 120);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(552, 48);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "MIB File (optional)";
            // 
            // ctlBrowse
            // 
            this.ctlBrowse.Location = new System.Drawing.Point(472, 20);
            this.ctlBrowse.Name = "ctlBrowse";
            this.ctlBrowse.Size = new System.Drawing.Size(72, 22);
            this.ctlBrowse.TabIndex = 13;
            this.ctlBrowse.Text = "&Browse...";
            this.ctlBrowse.Click += new System.EventHandler(this.ctlBrowse_Click);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 28);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(76, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "&Agent:";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(16, 52);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 16);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "&Community:";
            // 
            // ctlValue
            // 
            this.ctlValue.Location = new System.Drawing.Point(104, 96);
            this.ctlValue.Multiline = true;
            this.ctlValue.Name = "ctlValue";
            this.ctlValue.ReadOnly = true;
            this.ctlValue.Size = new System.Drawing.Size(360, 56);
            this.ctlValue.TabIndex = 5;
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(16, 96);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(80, 16);
            this.Label7.TabIndex = 4;
            this.Label7.Text = "Data &Value:";
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.Location = new System.Drawing.Point(104, 72);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(100, 22);
            this.ButtonOpen.TabIndex = 9;
            this.ButtonOpen.Text = "&Open";
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(208, 72);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(100, 22);
            this.ButtonClose.TabIndex = 10;
            this.ButtonClose.Text = "&Close";
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ctlVersion
            // 
            this.ctlVersion.Items.AddRange(new object[] {
            "V1",
            "V2C",
            "V3"});
            this.ctlVersion.Location = new System.Drawing.Point(384, 48);
            this.ctlVersion.Name = "ctlVersion";
            this.ctlVersion.Size = new System.Drawing.Size(160, 21);
            this.ctlVersion.TabIndex = 11;
            this.ctlVersion.Text = "V2C";
            this.ctlVersion.SelectedIndexChanged += new System.EventHandler(this.ctlVersion_SelectedIndexChanged);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.ctlType);
            this.GroupBox2.Controls.Add(this.Label10);
            this.GroupBox2.Controls.Add(this.ctlSet);
            this.GroupBox2.Controls.Add(this.ctlGetNext);
            this.GroupBox2.Controls.Add(this.ctlGet);
            this.GroupBox2.Controls.Add(this.ctlNewValue);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.ctlValue);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.ctlOID);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Location = new System.Drawing.Point(12, 176);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(552, 232);
            this.GroupBox2.TabIndex = 8;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "SNMP Operations";
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(16, 72);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(80, 16);
            this.Label6.TabIndex = 2;
            this.Label6.Text = "Data &Type:";
            // 
            // ctlOID
            // 
            this.ctlOID.Location = new System.Drawing.Point(104, 24);
            this.ctlOID.Name = "ctlOID";
            this.ctlOID.Size = new System.Drawing.Size(360, 20);
            this.ctlOID.TabIndex = 1;
            this.ctlOID.Text = "system.sysName.0";
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(16, 28);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(64, 16);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "Object ID:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ctlAuthentication);
            this.GroupBox1.Controls.Add(this.ctlVersion);
            this.GroupBox1.Controls.Add(this.ButtonClose);
            this.GroupBox1.Controls.Add(this.ButtonOpen);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.ctlPort);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.ctlCommunity);
            this.GroupBox1.Controls.Add(this.ctlAgent);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(552, 104);
            this.GroupBox1.TabIndex = 7;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "SNMP Session";
            // 
            // btnAuthentication
            // 
            this.ctlAuthentication.Location = new System.Drawing.Point(384, 72);
            this.ctlAuthentication.Name = "btnAuthentication";
            this.ctlAuthentication.Size = new System.Drawing.Size(160, 24);
            this.ctlAuthentication.TabIndex = 12;
            this.ctlAuthentication.Text = "&Authentication...";
            this.ctlAuthentication.UseVisualStyleBackColor = true;
            this.ctlAuthentication.Click += new System.EventHandler(this.btnAuthentication_Click);
            // 
            // SnmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 502);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SnmpForm";
            this.Text = "ActiveXperts Network Component - C# .NET SNMP Sample";
            this.Load += new System.EventHandler(this.SnmpForm_Load);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox3;
        private System.Windows.Forms.Button ctlView;
        private System.Windows.Forms.TextBox ctlLogFile;
        private System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox ctlResult;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox ctlType;
        internal System.Windows.Forms.TextBox ctlPort;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button ctlSet;
        internal System.Windows.Forms.Button ctlGetNext;
        internal System.Windows.Forms.TextBox ctlCommunity;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox ctlAgent;
        internal System.Windows.Forms.TextBox ctlMibFile;
        internal System.Windows.Forms.Button ctlGet;
        internal System.Windows.Forms.TextBox ctlNewValue;
        internal System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.Button ctlBrowse;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox ctlValue;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button ButtonOpen;
        internal System.Windows.Forms.Button ButtonClose;
        internal System.Windows.Forms.ComboBox ctlVersion;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox ctlOID;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Button ctlAuthentication;
    }
}