namespace Demo
{
    partial class TftpForm
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
            this.ctlPort = new System.Windows.Forms.TextBox();
            this.ctlHost = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ctlConnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ctlRemoteToLocal = new System.Windows.Forms.RadioButton();
            this.ctlLocalToRemote = new System.Windows.Forms.RadioButton();
            this.ctlToBrowse = new System.Windows.Forms.Button();
            this.ctlLocalFile = new System.Windows.Forms.TextBox();
            this.ctlRemoteFile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.ctlLogfile = new System.Windows.Forms.TextBox();
            this.ctlResult = new System.Windows.Forms.TextBox();
            this.ctlView = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ctlPort);
            this.GroupBox1.Controls.Add(this.ctlHost);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(5, 6);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(496, 57);
            this.GroupBox1.TabIndex = 7;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "TFTP Server";
            // 
            // ctlPort
            // 
            this.ctlPort.Location = new System.Drawing.Point(415, 22);
            this.ctlPort.Name = "ctlPort";
            this.ctlPort.Size = new System.Drawing.Size(64, 20);
            this.ctlPort.TabIndex = 2;
            this.ctlPort.Text = "69";
            // 
            // ctlHost
            // 
            this.ctlHost.Location = new System.Drawing.Point(106, 21);
            this.ctlHost.Name = "ctlHost";
            this.ctlHost.Size = new System.Drawing.Size(272, 20);
            this.ctlHost.TabIndex = 1;
            this.ctlHost.Text = "srv202.activexperts-labs.com";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(384, 25);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(36, 16);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "&Port:";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "&Host:";
            // 
            // ctlConnect
            // 
            this.ctlConnect.Location = new System.Drawing.Point(351, 119);
            this.ctlConnect.Name = "ctlConnect";
            this.ctlConnect.Size = new System.Drawing.Size(128, 24);
            this.ctlConnect.TabIndex = 9;
            this.ctlConnect.Text = "&Copy";
            this.ctlConnect.Click += new System.EventHandler(this.ctlConnect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.ctlRemoteToLocal);
            this.groupBox2.Controls.Add(this.ctlLocalToRemote);
            this.groupBox2.Controls.Add(this.ctlToBrowse);
            this.groupBox2.Controls.Add(this.ctlLocalFile);
            this.groupBox2.Controls.Add(this.ctlRemoteFile);
            this.groupBox2.Controls.Add(this.ctlConnect);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(5, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 154);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Files";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Direction:";
            // 
            // ctlRemoteToLocal
            // 
            this.ctlRemoteToLocal.AutoSize = true;
            this.ctlRemoteToLocal.Checked = true;
            this.ctlRemoteToLocal.Location = new System.Drawing.Point(106, 42);
            this.ctlRemoteToLocal.Name = "ctlRemoteToLocal";
            this.ctlRemoteToLocal.Size = new System.Drawing.Size(163, 17);
            this.ctlRemoteToLocal.TabIndex = 4;
            this.ctlRemoteToLocal.TabStop = true;
            this.ctlRemoteToLocal.Text = "From remote host to localhost";
            this.ctlRemoteToLocal.UseVisualStyleBackColor = true;
            // 
            // ctlLocalToRemote
            // 
            this.ctlLocalToRemote.AutoSize = true;
            this.ctlLocalToRemote.Location = new System.Drawing.Point(106, 19);
            this.ctlLocalToRemote.Name = "ctlLocalToRemote";
            this.ctlLocalToRemote.Size = new System.Drawing.Size(163, 17);
            this.ctlLocalToRemote.TabIndex = 3;
            this.ctlLocalToRemote.Text = "From localhost to remote host";
            this.ctlLocalToRemote.UseVisualStyleBackColor = true;
            // 
            // ctlToBrowse
            // 
            this.ctlToBrowse.Location = new System.Drawing.Point(453, 93);
            this.ctlToBrowse.Name = "ctlToBrowse";
            this.ctlToBrowse.Size = new System.Drawing.Size(26, 20);
            this.ctlToBrowse.TabIndex = 8;
            this.ctlToBrowse.Text = "...";
            this.ctlToBrowse.UseVisualStyleBackColor = true;
            this.ctlToBrowse.Click += new System.EventHandler(this.ctlToBrowse_Click);
            // 
            // ctlLocalFile
            // 
            this.ctlLocalFile.Location = new System.Drawing.Point(106, 93);
            this.ctlLocalFile.Name = "ctlLocalFile";
            this.ctlLocalFile.Size = new System.Drawing.Size(341, 20);
            this.ctlLocalFile.TabIndex = 7;
            this.ctlLocalFile.Text = "c:\\readme.txt";
            this.ctlLocalFile.TextChanged += new System.EventHandler(this.ctlLocalFile_TextChanged);
            this.ctlLocalFile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctlLocalFile_KeyPress);
            // 
            // ctlRemoteFile
            // 
            this.ctlRemoteFile.Location = new System.Drawing.Point(106, 67);
            this.ctlRemoteFile.Name = "ctlRemoteFile";
            this.ctlRemoteFile.Size = new System.Drawing.Size(341, 20);
            this.ctlRemoteFile.TabIndex = 5;
            this.ctlRemoteFile.Text = "/network-component/readme.txt";
            this.ctlRemoteFile.TextChanged += new System.EventHandler(this.ctlRemoteFile_TextChanged);
            this.ctlRemoteFile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctlRemoteFile_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Local file:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Remote file:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "doc1";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.ctlLogfile);
            this.GroupBox3.Controls.Add(this.ctlResult);
            this.GroupBox3.Controls.Add(this.ctlView);
            this.GroupBox3.Controls.Add(this.label9);
            this.GroupBox3.Controls.Add(this.label10);
            this.GroupBox3.Location = new System.Drawing.Point(4, 225);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(497, 76);
            this.GroupBox3.TabIndex = 9;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Result";
            // 
            // ctlLogfile
            // 
            this.ctlLogfile.Location = new System.Drawing.Point(107, 45);
            this.ctlLogfile.Name = "ctlLogfile";
            this.ctlLogfile.Size = new System.Drawing.Size(302, 20);
            this.ctlLogfile.TabIndex = 10;
            // 
            // ctlResult
            // 
            this.ctlResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlResult.Location = new System.Drawing.Point(107, 19);
            this.ctlResult.Name = "ctlResult";
            this.ctlResult.ReadOnly = true;
            this.ctlResult.Size = new System.Drawing.Size(302, 20);
            this.ctlResult.TabIndex = 3;
            this.ctlResult.TabStop = false;
            // 
            // ctlView
            // 
            this.ctlView.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.ctlView.Location = new System.Drawing.Point(423, 43);
            this.ctlView.Name = "ctlView";
            this.ctlView.Size = new System.Drawing.Size(57, 22);
            this.ctlView.TabIndex = 11;
            this.ctlView.Text = "&View";
            this.ctlView.Click += new System.EventHandler(this.ctlView_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(16, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "&Logfile:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Result:";
            // 
            // TftpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 309);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TftpForm";
            this.Text = "ActiveXperts Network Component - C# .NET Tftp Sample";
            this.Load += new System.EventHandler(this.TftpForm_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox ctlPort;
        internal System.Windows.Forms.TextBox ctlHost;
        internal System.Windows.Forms.Button ctlConnect;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton ctlRemoteToLocal;
        private System.Windows.Forms.RadioButton ctlLocalToRemote;
        private System.Windows.Forms.Button ctlToBrowse;
        internal System.Windows.Forms.TextBox ctlLocalFile;
        internal System.Windows.Forms.TextBox ctlRemoteFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.TextBox ctlLogfile;
        internal System.Windows.Forms.TextBox ctlResult;
        internal System.Windows.Forms.Button ctlView;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label10;
    }
}