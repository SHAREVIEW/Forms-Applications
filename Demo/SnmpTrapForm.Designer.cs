namespace Demo
{
    partial class SnmpTrapForm
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
            this.components = new System.ComponentModel.Container();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.ctlClearList = new System.Windows.Forms.Button();
            this.ctlStopListening = new System.Windows.Forms.Button();
            this.ctlStartListening = new System.Windows.Forms.Button();
            this.ctlReceivedTraps = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.ctlCommunityIn = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.ctlView = new System.Windows.Forms.Button();
            this.ctlLogFile = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ctlResult = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ctlSpecificV1Value = new System.Windows.Forms.TextBox();
            this.ctlLabelSpecificV1Value = new System.Windows.Forms.Label();
            this.ctlGenericV1Trap = new System.Windows.Forms.ComboBox();
            this.ctlLabelGenericV1Trap = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ctlEnterpriseOID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ctlSend = new System.Windows.Forms.Button();
            this.ctlValue = new System.Windows.Forms.TextBox();
            this.ctlType = new System.Windows.Forms.ComboBox();
            this.ctlOID = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.ctlVersion = new System.Windows.Forms.ComboBox();
            this.ctlCommunity = new System.Windows.Forms.TextBox();
            this.ctlAgent = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.ctlAdvanced = new System.Windows.Forms.Button();
            this.btnAuthentication = new System.Windows.Forms.Button();
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Label12);
            this.GroupBox3.Controls.Add(this.ctlClearList);
            this.GroupBox3.Controls.Add(this.ctlStopListening);
            this.GroupBox3.Controls.Add(this.ctlStartListening);
            this.GroupBox3.Controls.Add(this.ctlReceivedTraps);
            this.GroupBox3.Controls.Add(this.ctlCommunityIn);
            this.GroupBox3.Controls.Add(this.Label10);
            this.GroupBox3.Location = new System.Drawing.Point(12, 253);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(548, 232);
            this.GroupBox3.TabIndex = 5;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Receive SNMP Traps";
            // 
            // Label12
            // 
            this.Label12.Location = new System.Drawing.Point(348, 22);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(192, 16);
            this.Label12.TabIndex = 4;
            this.Label12.Text = "(use empty string for any community)";
            // 
            // ctlClearList
            // 
            this.ctlClearList.Location = new System.Drawing.Point(368, 194);
            this.ctlClearList.Name = "ctlClearList";
            this.ctlClearList.Size = new System.Drawing.Size(160, 24);
            this.ctlClearList.TabIndex = 8;
            this.ctlClearList.Text = "Clea&r List";
            this.ctlClearList.Click += new System.EventHandler(this.ctlClearList_Click);
            // 
            // ctlStopListening
            // 
            this.ctlStopListening.Location = new System.Drawing.Point(192, 194);
            this.ctlStopListening.Name = "ctlStopListening";
            this.ctlStopListening.Size = new System.Drawing.Size(160, 24);
            this.ctlStopListening.TabIndex = 7;
            this.ctlStopListening.Text = "St&op Listening";
            this.ctlStopListening.Click += new System.EventHandler(this.ctlStopListening_Click);
            // 
            // ctlStartListening
            // 
            this.ctlStartListening.Location = new System.Drawing.Point(8, 194);
            this.ctlStartListening.Name = "ctlStartListening";
            this.ctlStartListening.Size = new System.Drawing.Size(160, 24);
            this.ctlStartListening.TabIndex = 6;
            this.ctlStartListening.Text = "Start &Listening";
            this.ctlStartListening.Click += new System.EventHandler(this.ctlStartListening_Click);
            // 
            // ctlReceivedTraps
            // 
            this.ctlReceivedTraps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4});
            this.ctlReceivedTraps.GridLines = true;
            this.ctlReceivedTraps.Location = new System.Drawing.Point(8, 50);
            this.ctlReceivedTraps.Name = "ctlReceivedTraps";
            this.ctlReceivedTraps.Size = new System.Drawing.Size(524, 136);
            this.ctlReceivedTraps.TabIndex = 5;
            this.ctlReceivedTraps.UseCompatibleStateImageBehavior = false;
            this.ctlReceivedTraps.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Sender";
            this.ColumnHeader1.Width = 80;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "OID";
            this.ColumnHeader2.Width = 100;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Type";
            this.ColumnHeader3.Width = 120;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "Value";
            this.ColumnHeader4.Width = 1000;
            // 
            // ctlCommunityIn
            // 
            this.ctlCommunityIn.Location = new System.Drawing.Point(100, 18);
            this.ctlCommunityIn.Name = "ctlCommunityIn";
            this.ctlCommunityIn.Size = new System.Drawing.Size(244, 20);
            this.ctlCommunityIn.TabIndex = 1;
            this.ctlCommunityIn.Text = "public";
            // 
            // Label10
            // 
            this.Label10.Location = new System.Drawing.Point(8, 22);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(80, 16);
            this.Label10.TabIndex = 0;
            this.Label10.Text = "Co&mmunity:";
            // 
            // ctlView
            // 
            this.ctlView.Location = new System.Drawing.Point(460, 46);
            this.ctlView.Name = "ctlView";
            this.ctlView.Size = new System.Drawing.Size(80, 22);
            this.ctlView.TabIndex = 4;
            this.ctlView.Text = "Vie&w";
            this.ctlView.Click += new System.EventHandler(this.ctlView_Click);
            // 
            // ctlLogFile
            // 
            this.ctlLogFile.Location = new System.Drawing.Point(104, 46);
            this.ctlLogFile.Name = "ctlLogFile";
            this.ctlLogFile.Size = new System.Drawing.Size(348, 20);
            this.ctlLogFile.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(16, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Log&file:";
            // 
            // ctlResult
            // 
            this.ctlResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlResult.Location = new System.Drawing.Point(104, 22);
            this.ctlResult.Name = "ctlResult";
            this.ctlResult.ReadOnly = true;
            this.ctlResult.Size = new System.Drawing.Size(436, 20);
            this.ctlResult.TabIndex = 1;
            // 
            // Label9
            // 
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(16, 26);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(68, 16);
            this.Label9.TabIndex = 0;
            this.Label9.Text = "Result:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnAuthentication);
            this.GroupBox1.Controls.Add(this.ctlSpecificV1Value);
            this.GroupBox1.Controls.Add(this.ctlLabelSpecificV1Value);
            this.GroupBox1.Controls.Add(this.ctlGenericV1Trap);
            this.GroupBox1.Controls.Add(this.ctlLabelGenericV1Trap);
            this.GroupBox1.Controls.Add(this.label11);
            this.GroupBox1.Controls.Add(this.ctlEnterpriseOID);
            this.GroupBox1.Controls.Add(this.label4);
            this.GroupBox1.Controls.Add(this.ctlSend);
            this.GroupBox1.Controls.Add(this.ctlValue);
            this.GroupBox1.Controls.Add(this.ctlType);
            this.GroupBox1.Controls.Add(this.ctlOID);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.ctlVersion);
            this.GroupBox1.Controls.Add(this.ctlCommunity);
            this.GroupBox1.Controls.Add(this.ctlAgent);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 9);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(548, 228);
            this.GroupBox1.TabIndex = 4;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Send SNMP Trap";
            // 
            // ctlSpecificV1Value
            // 
            this.ctlSpecificV1Value.Location = new System.Drawing.Point(392, 175);
            this.ctlSpecificV1Value.Name = "ctlSpecificV1Value";
            this.ctlSpecificV1Value.Size = new System.Drawing.Size(140, 20);
            this.ctlSpecificV1Value.TabIndex = 21;
            this.ctlSpecificV1Value.Text = "0";
            // 
            // ctlLabelSpecificV1Value
            // 
            this.ctlLabelSpecificV1Value.Location = new System.Drawing.Point(308, 179);
            this.ctlLabelSpecificV1Value.Name = "ctlLabelSpecificV1Value";
            this.ctlLabelSpecificV1Value.Size = new System.Drawing.Size(88, 16);
            this.ctlLabelSpecificV1Value.TabIndex = 20;
            this.ctlLabelSpecificV1Value.Text = "v1 Specific Trap:";
            // 
            // ctlGenericV1Trap
            // 
            this.ctlGenericV1Trap.Location = new System.Drawing.Point(392, 151);
            this.ctlGenericV1Trap.Name = "ctlGenericV1Trap";
            this.ctlGenericV1Trap.Size = new System.Drawing.Size(140, 21);
            this.ctlGenericV1Trap.TabIndex = 19;
            this.ctlGenericV1Trap.SelectedIndexChanged += new System.EventHandler(this.ctlGenericV1Trap_SelectedIndexChanged);
            // 
            // ctlLabelGenericV1Trap
            // 
            this.ctlLabelGenericV1Trap.Location = new System.Drawing.Point(308, 155);
            this.ctlLabelGenericV1Trap.Name = "ctlLabelGenericV1Trap";
            this.ctlLabelGenericV1Trap.Size = new System.Drawing.Size(88, 16);
            this.ctlLabelGenericV1Trap.TabIndex = 18;
            this.ctlLabelGenericV1Trap.Text = "v1 Generic Trap:";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(100, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "(leave blank to use default)";
            // 
            // ctlEnterpriseOID
            // 
            this.ctlEnterpriseOID.Location = new System.Drawing.Point(100, 151);
            this.ctlEnterpriseOID.Name = "ctlEnterpriseOID";
            this.ctlEnterpriseOID.Size = new System.Drawing.Size(188, 20);
            this.ctlEnterpriseOID.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Enterprise OID:";
            // 
            // ctlSend
            // 
            this.ctlSend.Location = new System.Drawing.Point(100, 199);
            this.ctlSend.Name = "ctlSend";
            this.ctlSend.Size = new System.Drawing.Size(432, 24);
            this.ctlSend.TabIndex = 14;
            this.ctlSend.Text = "Send Trap";
            this.ctlSend.Click += new System.EventHandler(this.ctlSend_Click);
            // 
            // ctlValue
            // 
            this.ctlValue.Location = new System.Drawing.Point(100, 127);
            this.ctlValue.Name = "ctlValue";
            this.ctlValue.Size = new System.Drawing.Size(432, 20);
            this.ctlValue.TabIndex = 13;
            this.ctlValue.Text = "A System Description";
            // 
            // ctlType
            // 
            this.ctlType.Location = new System.Drawing.Point(100, 103);
            this.ctlType.Name = "ctlType";
            this.ctlType.Size = new System.Drawing.Size(432, 21);
            this.ctlType.TabIndex = 11;
            // 
            // ctlOID
            // 
            this.ctlOID.Location = new System.Drawing.Point(100, 79);
            this.ctlOID.Name = "ctlOID";
            this.ctlOID.Size = new System.Drawing.Size(432, 20);
            this.ctlOID.TabIndex = 9;
            this.ctlOID.Text = "system.sysDescr.0";
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(8, 131);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(64, 16);
            this.Label7.TabIndex = 12;
            this.Label7.Text = "Valu&e:";
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(8, 107);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(64, 20);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "Data T&ype:";
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(8, 83);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(64, 16);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "Ob&ject ID:";
            // 
            // ctlVersion
            // 
            this.ctlVersion.Location = new System.Drawing.Point(412, 22);
            this.ctlVersion.Name = "ctlVersion";
            this.ctlVersion.Size = new System.Drawing.Size(120, 21);
            this.ctlVersion.TabIndex = 7;
            this.ctlVersion.SelectedIndexChanged += new System.EventHandler(this.ctlVersion_SelectedIndexChanged);
            // 
            // ctlCommunity
            // 
            this.ctlCommunity.Location = new System.Drawing.Point(100, 46);
            this.ctlCommunity.Name = "ctlCommunity";
            this.ctlCommunity.Size = new System.Drawing.Size(240, 20);
            this.ctlCommunity.TabIndex = 5;
            this.ctlCommunity.Text = "public";
            // 
            // ctlAgent
            // 
            this.ctlAgent.Location = new System.Drawing.Point(100, 22);
            this.ctlAgent.Name = "ctlAgent";
            this.ctlAgent.Size = new System.Drawing.Size(240, 20);
            this.ctlAgent.TabIndex = 1;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(368, 26);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(72, 24);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "&Version:";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(8, 50);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(144, 16);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Comm&unity:";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(8, 26);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "&Agent:";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.ctlView);
            this.GroupBox2.Controls.Add(this.ctlLogFile);
            this.GroupBox2.Controls.Add(this.label8);
            this.GroupBox2.Controls.Add(this.ctlResult);
            this.GroupBox2.Controls.Add(this.Label9);
            this.GroupBox2.Location = new System.Drawing.Point(12, 501);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(548, 80);
            this.GroupBox2.TabIndex = 6;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Result";
            // 
            // ctlAdvanced
            // 
            this.ctlAdvanced.Location = new System.Drawing.Point(472, 593);
            this.ctlAdvanced.Name = "ctlAdvanced";
            this.ctlAdvanced.Size = new System.Drawing.Size(80, 22);
            this.ctlAdvanced.TabIndex = 7;
            this.ctlAdvanced.Text = "Advanced...";
            this.ctlAdvanced.Click += new System.EventHandler(this.ctlAdvanced_Click);
            // 
            // btnAuthentication
            // 
            this.btnAuthentication.Location = new System.Drawing.Point(372, 46);
            this.btnAuthentication.Name = "btnAuthentication";
            this.btnAuthentication.Size = new System.Drawing.Size(160, 22);
            this.btnAuthentication.TabIndex = 22;
            this.btnAuthentication.Text = "&Authentication";
            this.btnAuthentication.UseVisualStyleBackColor = true;
            this.btnAuthentication.Click += new System.EventHandler(this.btnAuthentication_Click);
            // 
            // SnmpTrapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 621);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.ctlAdvanced);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SnmpTrapForm";
            this.Text = "ActiveXperts Network Component - C# .NET SNMP Trap Sample";
            this.Load += new System.EventHandler(this.SnmpTrapForm_Load);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Button ctlClearList;
        internal System.Windows.Forms.Button ctlStopListening;
        internal System.Windows.Forms.Button ctlStartListening;
        internal System.Windows.Forms.ListView ctlReceivedTraps;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        internal System.Windows.Forms.TextBox ctlCommunityIn;
        internal System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Button ctlView;
        private System.Windows.Forms.TextBox ctlLogFile;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox ctlResult;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.TextBox ctlSpecificV1Value;
        private System.Windows.Forms.Label ctlLabelSpecificV1Value;
        private System.Windows.Forms.ComboBox ctlGenericV1Trap;
        private System.Windows.Forms.Label ctlLabelGenericV1Trap;
        private System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox ctlEnterpriseOID;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button ctlSend;
        internal System.Windows.Forms.TextBox ctlValue;
        internal System.Windows.Forms.ComboBox ctlType;
        internal System.Windows.Forms.TextBox ctlOID;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ComboBox ctlVersion;
        internal System.Windows.Forms.TextBox ctlCommunity;
        internal System.Windows.Forms.TextBox ctlAgent;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Timer timer;
        internal System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.Button ctlAdvanced;
        private System.Windows.Forms.Button btnAuthentication;
    }
}