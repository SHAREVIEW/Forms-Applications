namespace Demo
{
    partial class XenForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.listCounters = new System.Windows.Forms.ListView();
            this.buttonView = new System.Windows.Forms.Button();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.textLogFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textAccount = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboVMs = new System.Windows.Forms.ComboBox();
            this.radioVirtual = new System.Windows.Forms.RadioButton();
            this.radioHost = new System.Windows.Forms.RadioButton();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textHost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Result:";
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(149, 319);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(123, 21);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "S&top Monitoring";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Context";
            this.columnHeader2.Width = 92;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Display Name";
            this.columnHeader1.Width = 216;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Value";
            this.columnHeader3.Width = 174;
            // 
            // listCounters
            // 
            this.listCounters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listCounters.GridLines = true;
            this.listCounters.Location = new System.Drawing.Point(19, 65);
            this.listCounters.Name = "listCounters";
            this.listCounters.Size = new System.Drawing.Size(535, 248);
            this.listCounters.TabIndex = 3;
            this.listCounters.UseCompatibleStateImageBehavior = false;
            this.listCounters.View = System.Windows.Forms.View.Details;
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(479, 44);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(75, 21);
            this.buttonView.TabIndex = 2;
            this.buttonView.Text = "&View";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 5000;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textResult);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.buttonView);
            this.groupBox3.Controls.Add(this.textLogFile);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 469);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(566, 79);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // textResult
            // 
            this.textResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResult.Location = new System.Drawing.Point(69, 19);
            this.textResult.Name = "textResult";
            this.textResult.ReadOnly = true;
            this.textResult.Size = new System.Drawing.Size(485, 20);
            this.textResult.TabIndex = 4;
            // 
            // textLogFile
            // 
            this.textLogFile.Location = new System.Drawing.Point(69, 45);
            this.textLogFile.Name = "textLogFile";
            this.textLogFile.Size = new System.Drawing.Size(404, 20);
            this.textLogFile.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "&Logfile:";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(19, 319);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(124, 21);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "&Start Monitoring";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(333, 52);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(140, 20);
            this.textPassword.TabIndex = 6;
            // 
            // textAccount
            // 
            this.textAccount.Location = new System.Drawing.Point(107, 52);
            this.textAccount.Name = "textAccount";
            this.textAccount.Size = new System.Drawing.Size(140, 20);
            this.textAccount.TabIndex = 5;
            this.textAccount.Text = "root";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonStop);
            this.groupBox2.Controls.Add(this.buttonStart);
            this.groupBox2.Controls.Add(this.listCounters);
            this.groupBox2.Controls.Add(this.comboVMs);
            this.groupBox2.Controls.Add(this.radioVirtual);
            this.groupBox2.Controls.Add(this.radioHost);
            this.groupBox2.Location = new System.Drawing.Point(12, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(566, 353);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Performance Counters";
            // 
            // comboVMs
            // 
            this.comboVMs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVMs.FormattingEnabled = true;
            this.comboVMs.Location = new System.Drawing.Point(149, 38);
            this.comboVMs.Name = "comboVMs";
            this.comboVMs.Size = new System.Drawing.Size(405, 21);
            this.comboVMs.TabIndex = 2;
            // 
            // radioVirtual
            // 
            this.radioVirtual.AutoSize = true;
            this.radioVirtual.Location = new System.Drawing.Point(19, 42);
            this.radioVirtual.Name = "radioVirtual";
            this.radioVirtual.Size = new System.Drawing.Size(118, 17);
            this.radioVirtual.TabIndex = 1;
            this.radioVirtual.Text = "On &Virtual Machine:";
            this.radioVirtual.UseVisualStyleBackColor = true;
            this.radioVirtual.CheckedChanged += new System.EventHandler(this.radioVirtual_CheckedChanged);
            // 
            // radioHost
            // 
            this.radioHost.AutoSize = true;
            this.radioHost.Checked = true;
            this.radioHost.Location = new System.Drawing.Point(19, 19);
            this.radioHost.Name = "radioHost";
            this.radioHost.Size = new System.Drawing.Size(117, 17);
            this.radioHost.TabIndex = 0;
            this.radioHost.TabStop = true;
            this.radioHost.Text = "&On XenServer Host";
            this.radioHost.UseVisualStyleBackColor = true;
            this.radioHost.CheckedChanged += new System.EventHandler(this.radioHost_CheckedChanged);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(479, 27);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 21);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "&Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textPassword);
            this.groupBox1.Controls.Add(this.textAccount);
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Controls.Add(this.textHost);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 92);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Citrix XenServer Host";
            // 
            // textHost
            // 
            this.textHost.Location = new System.Drawing.Point(107, 27);
            this.textHost.Name = "textHost";
            this.textHost.Size = new System.Drawing.Size(366, 20);
            this.textHost.TabIndex = 3;
            this.textHost.Text = "xen02";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "XenServer &Login:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "XenServer &Host:";
            // 
            // XenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 559);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XenForm";
            this.Text = "ActiveXperts Network Component - C# .NET Citrix XenServer Sample";
            this.Load += new System.EventHandler(this.XenForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listCounters;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.TextBox textLogFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textAccount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboVMs;
        private System.Windows.Forms.RadioButton radioVirtual;
        private System.Windows.Forms.RadioButton radioHost;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textHost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}