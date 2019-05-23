namespace Demo
{
    partial class SnmpMIBForm
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
            this.ctlStatus = new System.Windows.Forms.TextBox();
            this.ctlResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ctlAccess = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ctlView = new System.Windows.Forms.Button();
            this.ctlLogFile = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ctlUnloadMibFiles = new System.Windows.Forms.Button();
            this.ctlFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctlBrowseFile = new System.Windows.Forms.Button();
            this.ctlAddMibFile = new System.Windows.Forms.Button();
            this.ctlSyntax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ctlDescription = new System.Windows.Forms.TextBox();
            this.ctlOID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ctlOIDName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.ctlMIB = new System.Windows.Forms.TreeView();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlStatus
            // 
            this.ctlStatus.Location = new System.Drawing.Point(102, 367);
            this.ctlStatus.Name = "ctlStatus";
            this.ctlStatus.ReadOnly = true;
            this.ctlStatus.Size = new System.Drawing.Size(456, 20);
            this.ctlStatus.TabIndex = 9;
            // 
            // ctlResult
            // 
            this.ctlResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlResult.Location = new System.Drawing.Point(102, 20);
            this.ctlResult.Name = "ctlResult";
            this.ctlResult.ReadOnly = true;
            this.ctlResult.Size = new System.Drawing.Size(456, 20);
            this.ctlResult.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Access:";
            // 
            // ctlAccess
            // 
            this.ctlAccess.Location = new System.Drawing.Point(102, 343);
            this.ctlAccess.Name = "ctlAccess";
            this.ctlAccess.ReadOnly = true;
            this.ctlAccess.Size = new System.Drawing.Size(456, 20);
            this.ctlAccess.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ctlView);
            this.groupBox3.Controls.Add(this.ctlLogFile);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.ctlResult);
            this.groupBox3.Controls.Add(this.Label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 506);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(570, 76);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // ctlView
            // 
            this.ctlView.Location = new System.Drawing.Point(478, 44);
            this.ctlView.Name = "ctlView";
            this.ctlView.Size = new System.Drawing.Size(80, 22);
            this.ctlView.TabIndex = 4;
            this.ctlView.Text = "Vie&w";
            this.ctlView.Click += new System.EventHandler(this.ctlView_Click);
            // 
            // ctlLogFile
            // 
            this.ctlLogFile.Location = new System.Drawing.Point(102, 44);
            this.ctlLogFile.Name = "ctlLogFile";
            this.ctlLogFile.Size = new System.Drawing.Size(368, 20);
            this.ctlLogFile.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(20, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Log&file:";
            // 
            // Label9
            // 
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(20, 24);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(52, 16);
            this.Label9.TabIndex = 0;
            this.Label9.Text = "Result:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(20, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Status:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctlUnloadMibFiles);
            this.groupBox1.Controls.Add(this.ctlFile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ctlBrowseFile);
            this.groupBox1.Controls.Add(this.ctlAddMibFile);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 80);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User MIB File";
            // 
            // ctlUnloadMibFiles
            // 
            this.ctlUnloadMibFiles.Location = new System.Drawing.Point(226, 48);
            this.ctlUnloadMibFiles.Name = "ctlUnloadMibFiles";
            this.ctlUnloadMibFiles.Size = new System.Drawing.Size(115, 22);
            this.ctlUnloadMibFiles.TabIndex = 4;
            this.ctlUnloadMibFiles.Text = "&Unload MIB File(s)";
            this.ctlUnloadMibFiles.Click += new System.EventHandler(this.ctlUnloadMibFiles_Click);
            // 
            // ctlFile
            // 
            this.ctlFile.Location = new System.Drawing.Point(102, 20);
            this.ctlFile.Name = "ctlFile";
            this.ctlFile.Size = new System.Drawing.Size(380, 20);
            this.ctlFile.TabIndex = 3;
            this.ctlFile.Text = "c:\\windows\\system32\\hostmib.mib";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "&User MIB File:";
            // 
            // ctlBrowseFile
            // 
            this.ctlBrowseFile.Location = new System.Drawing.Point(490, 20);
            this.ctlBrowseFile.Name = "ctlBrowseFile";
            this.ctlBrowseFile.Size = new System.Drawing.Size(68, 21);
            this.ctlBrowseFile.TabIndex = 2;
            this.ctlBrowseFile.Text = "&Browse...";
            this.ctlBrowseFile.Click += new System.EventHandler(this.ctlBrowseFile_Click);
            // 
            // ctlAddMibFile
            // 
            this.ctlAddMibFile.Location = new System.Drawing.Point(102, 48);
            this.ctlAddMibFile.Name = "ctlAddMibFile";
            this.ctlAddMibFile.Size = new System.Drawing.Size(115, 22);
            this.ctlAddMibFile.TabIndex = 2;
            this.ctlAddMibFile.Text = "&Add MIB File";
            this.ctlAddMibFile.Click += new System.EventHandler(this.ctlAddMibFile_Click);
            // 
            // ctlSyntax
            // 
            this.ctlSyntax.Location = new System.Drawing.Point(102, 319);
            this.ctlSyntax.Name = "ctlSyntax";
            this.ctlSyntax.ReadOnly = true;
            this.ctlSyntax.Size = new System.Drawing.Size(456, 20);
            this.ctlSyntax.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Syntax:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description:";
            // 
            // ctlDescription
            // 
            this.ctlDescription.Location = new System.Drawing.Point(102, 271);
            this.ctlDescription.Multiline = true;
            this.ctlDescription.Name = "ctlDescription";
            this.ctlDescription.ReadOnly = true;
            this.ctlDescription.Size = new System.Drawing.Size(456, 43);
            this.ctlDescription.TabIndex = 3;
            // 
            // ctlOID
            // 
            this.ctlOID.Location = new System.Drawing.Point(102, 226);
            this.ctlOID.Name = "ctlOID";
            this.ctlOID.ReadOnly = true;
            this.ctlOID.Size = new System.Drawing.Size(456, 20);
            this.ctlOID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "OID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ctlOIDName);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.Label10);
            this.groupBox2.Controls.Add(this.Label12);
            this.groupBox2.Controls.Add(this.Label11);
            this.groupBox2.Controls.Add(this.Label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ctlStatus);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ctlAccess);
            this.groupBox2.Controls.Add(this.ctlSyntax);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ctlDescription);
            this.groupBox2.Controls.Add(this.ctlOID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ctlMIB);
            this.groupBox2.Location = new System.Drawing.Point(12, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 402);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Browse";
            // 
            // ctlOIDName
            // 
            this.ctlOIDName.Location = new System.Drawing.Point(102, 249);
            this.ctlOIDName.Name = "ctlOIDName";
            this.ctlOIDName.ReadOnly = true;
            this.ctlOIDName.Size = new System.Drawing.Size(456, 20);
            this.ctlOIDName.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(20, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "Name:";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Label10.Location = new System.Drawing.Point(129, 187);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(28, 13);
            this.Label10.TabIndex = 19;
            this.Label10.Text = "Blue";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(129, 201);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(248, 13);
            this.Label12.TabIndex = 18;
            this.Label12.Text = "Black indicates that node is part of the system MIB.";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(155, 187);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(206, 13);
            this.Label11.TabIndex = 17;
            this.Label11.Text = "indicates that node is part of the user MIB.";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(100, 187);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(33, 13);
            this.Label7.TabIndex = 16;
            this.Label7.Text = "Note:";
            // 
            // ctlMIB
            // 
            this.ctlMIB.Location = new System.Drawing.Point(102, 24);
            this.ctlMIB.Name = "ctlMIB";
            this.ctlMIB.Size = new System.Drawing.Size(456, 160);
            this.ctlMIB.TabIndex = 0;
            this.ctlMIB.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ctlMIB_AfterSelect);
            // 
            // SnmpMIBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 591);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SnmpMIBForm";
            this.Text = "ActiveXperts Network Component - C# .NET SNMP MIB Sample";
            this.Load += new System.EventHandler(this.SnmpMIBForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ctlStatus;
        internal System.Windows.Forms.TextBox ctlResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ctlAccess;
        internal System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ctlView;
        private System.Windows.Forms.TextBox ctlLogFile;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ctlUnloadMibFiles;
        private System.Windows.Forms.TextBox ctlFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ctlBrowseFile;
        private System.Windows.Forms.Button ctlAddMibFile;
        private System.Windows.Forms.TextBox ctlSyntax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ctlDescription;
        private System.Windows.Forms.TextBox ctlOID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView ctlMIB;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label7;
        private System.Windows.Forms.TextBox ctlOIDName;
        private System.Windows.Forms.Label label13;
    }
}