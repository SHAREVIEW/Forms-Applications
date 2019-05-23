namespace Demo
{
    partial class DnsForm
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
            this.ctlLookup = new System.Windows.Forms.Button();
            this.ctlType = new System.Windows.Forms.ComboBox();
            this.ctlHost = new System.Windows.Forms.TextBox();
            this.ctlServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctlResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ctlQueryResults = new System.Windows.Forms.TextBox();
            this.ctlLogFile = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ctlView = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctlLookup);
            this.groupBox1.Controls.Add(this.ctlType);
            this.groupBox1.Controls.Add(this.ctlHost);
            this.groupBox1.Controls.Add(this.ctlServer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 136);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DNS Lookup";
            // 
            // ctlLookup
            // 
            this.ctlLookup.Location = new System.Drawing.Point(96, 104);
            this.ctlLookup.Name = "ctlLookup";
            this.ctlLookup.Size = new System.Drawing.Size(288, 22);
            this.ctlLookup.TabIndex = 6;
            this.ctlLookup.Text = "&Lookup";
            this.ctlLookup.Click += new System.EventHandler(this.ctlLookup_Click);
            // 
            // ctlType
            // 
            this.ctlType.Location = new System.Drawing.Point(96, 72);
            this.ctlType.Name = "ctlType";
            this.ctlType.Size = new System.Drawing.Size(168, 21);
            this.ctlType.TabIndex = 5;
            // 
            // ctlHost
            // 
            this.ctlHost.Location = new System.Drawing.Point(96, 48);
            this.ctlHost.Name = "ctlHost";
            this.ctlHost.Size = new System.Drawing.Size(288, 20);
            this.ctlHost.TabIndex = 4;
            this.ctlHost.Text = "activexperts.com";
            // 
            // ctlServer
            // 
            this.ctlServer.Location = new System.Drawing.Point(96, 24);
            this.ctlServer.Name = "ctlServer";
            this.ctlServer.Size = new System.Drawing.Size(288, 20);
            this.ctlServer.TabIndex = 3;
            this.ctlServer.Text = "ns1.interstroom.nl";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Type:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Host:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "&DNS Server:";
            // 
            // ctlResult
            // 
            this.ctlResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlResult.Location = new System.Drawing.Point(96, 24);
            this.ctlResult.Name = "ctlResult";
            this.ctlResult.ReadOnly = true;
            this.ctlResult.Size = new System.Drawing.Size(392, 20);
            this.ctlResult.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(16, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "&LogFile:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "&Query results:";
            // 
            // ctlQueryResults
            // 
            this.ctlQueryResults.Location = new System.Drawing.Point(96, 48);
            this.ctlQueryResults.Multiline = true;
            this.ctlQueryResults.Name = "ctlQueryResults";
            this.ctlQueryResults.ReadOnly = true;
            this.ctlQueryResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ctlQueryResults.Size = new System.Drawing.Size(392, 144);
            this.ctlQueryResults.TabIndex = 4;
            // 
            // ctlLogFile
            // 
            this.ctlLogFile.Location = new System.Drawing.Point(96, 200);
            this.ctlLogFile.Name = "ctlLogFile";
            this.ctlLogFile.Size = new System.Drawing.Size(320, 20);
            this.ctlLogFile.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ctlView);
            this.groupBox2.Controls.Add(this.ctlLogFile);
            this.groupBox2.Controls.Add(this.ctlQueryResults);
            this.groupBox2.Controls.Add(this.ctlResult);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 232);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // ctlView
            // 
            this.ctlView.Location = new System.Drawing.Point(418, 199);
            this.ctlView.Name = "ctlView";
            this.ctlView.Size = new System.Drawing.Size(70, 22);
            this.ctlView.TabIndex = 6;
            this.ctlView.Text = "&View";
            this.ctlView.Click += new System.EventHandler(this.ctlView_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Result:";
            // 
            // DnsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 399);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DnsForm";
            this.Text = "ActiveXperts Network Component - C# .NET DNS Sample";
            this.Load += new System.EventHandler(this.DnsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ctlLookup;
        private System.Windows.Forms.ComboBox ctlType;
        private System.Windows.Forms.TextBox ctlHost;
        private System.Windows.Forms.TextBox ctlServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ctlResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ctlQueryResults;
        private System.Windows.Forms.TextBox ctlLogFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ctlView;
        private System.Windows.Forms.Label label4;
    }
}