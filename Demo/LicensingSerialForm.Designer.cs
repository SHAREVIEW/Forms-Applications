namespace Demo
{
    partial class LicensingSerialForm
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
            this.ctlOK = new System.Windows.Forms.Button();
            this.ctlCancel = new System.Windows.Forms.Button();
            this.ctlSerialKey = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctlOK
            // 
            this.ctlOK.Location = new System.Drawing.Point(144, 44);
            this.ctlOK.Name = "ctlOK";
            this.ctlOK.Size = new System.Drawing.Size(75, 23);
            this.ctlOK.TabIndex = 15;
            this.ctlOK.Text = "OK";
            this.ctlOK.Click += new System.EventHandler(this.ctlOK_Click);
            // 
            // ctlCancel
            // 
            this.ctlCancel.Location = new System.Drawing.Point(228, 44);
            this.ctlCancel.Name = "ctlCancel";
            this.ctlCancel.Size = new System.Drawing.Size(75, 23);
            this.ctlCancel.TabIndex = 14;
            this.ctlCancel.Text = "Cancel";
            this.ctlCancel.Click += new System.EventHandler(this.ctlCancel_Click);
            // 
            // ctlSerialKey
            // 
            this.ctlSerialKey.Location = new System.Drawing.Point(76, 12);
            this.ctlSerialKey.Name = "ctlSerialKey";
            this.ctlSerialKey.Size = new System.Drawing.Size(228, 20);
            this.ctlSerialKey.TabIndex = 13;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(12, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(60, 16);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "&Serial Key:";
            // 
            // LicensingSerialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 81);
            this.Controls.Add(this.ctlOK);
            this.Controls.Add(this.ctlCancel);
            this.Controls.Add(this.ctlSerialKey);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LicensingSerialForm";
            this.Text = "Enter serial key";
            this.Load += new System.EventHandler(this.LicensingSerialForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button ctlOK;
        internal System.Windows.Forms.Button ctlCancel;
        internal System.Windows.Forms.TextBox ctlSerialKey;
        internal System.Windows.Forms.Label Label1;
    }
}