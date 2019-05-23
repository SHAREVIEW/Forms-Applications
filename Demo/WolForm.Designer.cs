namespace Demo
{
    partial class WolForm
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
            this.textLogFile = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ctlWake = new System.Windows.Forms.Button();
            this.ctlResult = new System.Windows.Forms.TextBox();
            this.ctlMAC = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ctlView = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textLogFile
            // 
            this.textLogFile.Location = new System.Drawing.Point(96, 72);
            this.textLogFile.Name = "textLogFile";
            this.textLogFile.Size = new System.Drawing.Size(232, 20);
            this.textLogFile.TabIndex = 6;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.textLogFile);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.ctlWake);
            this.GroupBox1.Controls.Add(this.ctlResult);
            this.GroupBox1.Controls.Add(this.ctlMAC);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.ctlView);
            this.GroupBox1.Location = new System.Drawing.Point(12, 10);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(419, 104);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Wake On Lan";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "&Logfile:";
            // 
            // ctlWake
            // 
            this.ctlWake.Location = new System.Drawing.Point(336, 23);
            this.ctlWake.Name = "ctlWake";
            this.ctlWake.Size = new System.Drawing.Size(72, 22);
            this.ctlWake.TabIndex = 4;
            this.ctlWake.Text = "&Wake Up";
            this.ctlWake.Click += new System.EventHandler(this.ctlWake_Click);
            // 
            // ctlResult
            // 
            this.ctlResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlResult.Location = new System.Drawing.Point(96, 48);
            this.ctlResult.Name = "ctlResult";
            this.ctlResult.ReadOnly = true;
            this.ctlResult.Size = new System.Drawing.Size(312, 20);
            this.ctlResult.TabIndex = 3;
            // 
            // ctlMAC
            // 
            this.ctlMAC.Location = new System.Drawing.Point(96, 24);
            this.ctlMAC.Name = "ctlMAC";
            this.ctlMAC.Size = new System.Drawing.Size(232, 20);
            this.ctlMAC.TabIndex = 2;
            this.ctlMAC.Text = "00-0F-1F-4E-B2-4A";
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(16, 50);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(68, 16);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "&Result:";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "&MAC Address:";
            // 
            // ctlView
            // 
            this.ctlView.Location = new System.Drawing.Point(336, 71);
            this.ctlView.Name = "ctlView";
            this.ctlView.Size = new System.Drawing.Size(72, 22);
            this.ctlView.TabIndex = 7;
            this.ctlView.Text = "&View";
            this.ctlView.Click += new System.EventHandler(this.ctlView_Click);
            // 
            // WolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 127);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WolForm";
            this.Text = "ActiveXperts Network Component - C# .NET Wake On Lan Sample";
            this.Load += new System.EventHandler(this.WolForm_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textLogFile;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button ctlWake;
        internal System.Windows.Forms.TextBox ctlResult;
        internal System.Windows.Forms.TextBox ctlMAC;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button ctlView;
    }
}