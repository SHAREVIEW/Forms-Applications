using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AxNetwork;

namespace Demo
{
    public partial class IcmpForm : Form
    {
        private AxNetwork.Icmp objIcmp = new AxNetwork.Icmp();

        public IcmpForm()
        {
            InitializeComponent();
        }

        private void IcmpForm_Load(object sender, EventArgs e)
        {
            ctlLogFile.Text = System.IO.Path.GetTempPath() + "Icmp.log"; 
        }

        private void ctlPing_Click(object sender, EventArgs e)
        {
            objIcmp.Ttl = Int32.Parse(ctlTTL.Text);
            objIcmp.LogFile = ctlLogFile.Text;

            Cursor.Current = Cursors.WaitCursor;

            objIcmp.Ping(ctlHost.Text, System.Int32.Parse(ctlTimeout.Text));

            if (objIcmp.LastError > 0)
            {
                ctlResult.Text = objIcmp.LastError.ToString() + ": " + objIcmp.GetErrorDescription(objIcmp.LastError);

            }
            else
            {
                ctlResult.Text = "Reply from " + ctlHost.Text + ": time=" + objIcmp.LastDuration + " ms   TTL=" + objIcmp.LastTtl;
            }

            Cursor.Current = Cursors.Default;

        }

        private void ctlView_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(ctlLogFile.Text.ToString()))
            {
                System.Diagnostics.Process.Start(ctlLogFile.Text);
            }
        }
    }
}