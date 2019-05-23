namespace Demo
{
    partial class TraceRouteForm
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
            this.ctlRoute = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ctlLogfile = new System.Windows.Forms.TextBox();
            this.ctlResult = new System.Windows.Forms.TextBox();
            this.ctlView = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ctlResolveHostname = new System.Windows.Forms.CheckBox();
            this.ctlMaxHops = new System.Windows.Forms.NumericUpDown();
            this.ctlTrace = new System.Windows.Forms.Button();
            this.ctlHost = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlMaxHops)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.ctlRoute);
            this.GroupBox3.Controls.Add(this.label4);
            this.GroupBox3.Controls.Add(this.ctlLogfile);
            this.GroupBox3.Controls.Add(this.ctlResult);
            this.GroupBox3.Controls.Add(this.ctlView);
            this.GroupBox3.Controls.Add(this.label2);
            this.GroupBox3.Controls.Add(this.Label5);
            this.GroupBox3.Location = new System.Drawing.Point(12, 118);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(464, 256);
            this.GroupBox3.TabIndex = 11;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Result";
            // 
            // ctlRoute
            // 
            this.ctlRoute.Location = new System.Drawing.Point(80, 47);
            this.ctlRoute.Multiline = true;
            this.ctlRoute.Name = "ctlRoute";
            this.ctlRoute.ReadOnly = true;
            this.ctlRoute.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ctlRoute.Size = new System.Drawing.Size(376, 177);
            this.ctlRoute.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Route:";
            // 
            // ctlLogfile
            // 
            this.ctlLogfile.Location = new System.Drawing.Point(80, 230);
            this.ctlLogfile.Name = "ctlLogfile";
            this.ctlLogfile.Size = new System.Drawing.Size(304, 20);
            this.ctlLogfile.TabIndex = 4;
            // 
            // ctlResult
            // 
            this.ctlResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlResult.Location = new System.Drawing.Point(80, 21);
            this.ctlResult.Name = "ctlResult";
            this.ctlResult.ReadOnly = true;
            this.ctlResult.Size = new System.Drawing.Size(376, 20);
            this.ctlResult.TabIndex = 3;
            // 
            // ctlView
            // 
            this.ctlView.Location = new System.Drawing.Point(390, 230);
            this.ctlView.Name = "ctlView";
            this.ctlView.Size = new System.Drawing.Size(66, 21);
            this.ctlView.TabIndex = 2;
            this.ctlView.Text = "&View";
            this.ctlView.Click += new System.EventHandler(this.ctlView_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Logfile:";
            // 
            // Label5
            // 
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(16, 25);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(120, 16);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "Result:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ctlResolveHostname);
            this.GroupBox1.Controls.Add(this.ctlMaxHops);
            this.GroupBox1.Controls.Add(this.ctlTrace);
            this.GroupBox1.Controls.Add(this.ctlHost);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(464, 100);
            this.GroupBox1.TabIndex = 10;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Server";
            // 
            // ctlResolveHostname
            // 
            this.ctlResolveHostname.AutoSize = true;
            this.ctlResolveHostname.Checked = true;
            this.ctlResolveHostname.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ctlResolveHostname.Location = new System.Drawing.Point(126, 48);
            this.ctlResolveHostname.Name = "ctlResolveHostname";
            this.ctlResolveHostname.Size = new System.Drawing.Size(116, 17);
            this.ctlResolveHostname.TabIndex = 17;
            this.ctlResolveHostname.Text = "Resolve Hostname";
            this.ctlResolveHostname.UseVisualStyleBackColor = true;
            // 
            // ctlMaxHops
            // 
            this.ctlMaxHops.Location = new System.Drawing.Point(80, 45);
            this.ctlMaxHops.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ctlMaxHops.Name = "ctlMaxHops";
            this.ctlMaxHops.Size = new System.Drawing.Size(40, 20);
            this.ctlMaxHops.TabIndex = 16;
            this.ctlMaxHops.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // ctlTrace
            // 
            this.ctlTrace.Location = new System.Drawing.Point(80, 71);
            this.ctlTrace.Name = "ctlTrace";
            this.ctlTrace.Size = new System.Drawing.Size(376, 22);
            this.ctlTrace.TabIndex = 8;
            this.ctlTrace.Text = "&Trace";
            this.ctlTrace.Click += new System.EventHandler(this.ctlTrace_Click);
            // 
            // ctlHost
            // 
            this.ctlHost.Location = new System.Drawing.Point(80, 19);
            this.ctlHost.Name = "ctlHost";
            this.ctlHost.Size = new System.Drawing.Size(376, 20);
            this.ctlHost.TabIndex = 4;
            this.ctlHost.Text = "www.activexperts.com";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(16, 49);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(58, 16);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "&Max Hops:";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 23);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(104, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "&Host:";
            // 
            // TraceRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 386);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TraceRouteForm";
            this.Text = "TraceRouteForm";
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlMaxHops)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.TextBox ctlLogfile;
        internal System.Windows.Forms.TextBox ctlResult;
        internal System.Windows.Forms.Button ctlView;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.CheckBox ctlResolveHostname;
        private System.Windows.Forms.NumericUpDown ctlMaxHops;
        internal System.Windows.Forms.Button ctlTrace;
        internal System.Windows.Forms.TextBox ctlHost;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox ctlRoute;
        private System.Windows.Forms.Label label4;
    }
}