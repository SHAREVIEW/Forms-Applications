using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Demo
{
    public partial class RadiusForm : Form
    {
        private AxNetwork.Radius objRadius = new AxNetwork.Radius();

        public RadiusForm()
        {
            InitializeComponent();
        }

        private void RadiusForm_Load(object sender, EventArgs e)
        {
            objRadius.Clear();
            ctlLogfile.Text = System.IO.Path.GetTempPath() + "Radius.log";
            objRadius.LogFile = ctlLogfile.Text;
        }

        private void ctlCheckAccess_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            objRadius.Port = Int32.Parse(textPort.Text);
            objRadius.Protocol = comboProtocol.SelectedIndex;
            objRadius.CheckAccess(ctlHost.Text, ctlUser.Text, ctlPassword.Text, ctlSecret.Text);
            ctlResult.Text = objRadius.LastError.ToString() + ": " + objRadius.GetErrorDescription(objRadius.LastError);
            this.Cursor = Cursors.Default;
        }

        private void ctlView_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(ctlLogfile.Text.ToString()))
            {
                System.Diagnostics.Process.Start(ctlLogfile.Text);
            }
        }
    }
}
