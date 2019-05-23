using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Demo
{
    public partial class TraceRouteForm : Form
    {
        private AxNetwork.TraceRoute objTraceRoute = new AxNetwork.TraceRoute();

        public TraceRouteForm()
        {
            InitializeComponent();
            objTraceRoute.Clear();
            ctlLogfile.Text = System.IO.Path.GetTempPath() + "TraceRoute.log";
        }

        private void ctlTrace_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Traceroute will now start, this can take a while.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Cursor = Cursors.WaitCursor;

            objTraceRoute.Clear();
            objTraceRoute.LogFile = ctlLogfile.Text;

            objTraceRoute.MaxHops = (int)ctlMaxHops.Value;
            objTraceRoute.ResolveHostName = ctlResolveHostname.Checked;

            AxNetwork.TraceHop objTraceHop;
            objTraceHop = (AxNetwork.TraceHop)objTraceRoute.FindFirstHop(ctlHost.Text);
            ctlResult.Text = string.Format("{0}: {1}",objTraceRoute.LastError.ToString(), objTraceRoute.GetErrorDescription(objTraceRoute.LastError));
            ctlRoute.Text = "";
            this.Cursor = Cursors.WaitCursor;
            while (objTraceRoute.LastError == 0)
            {
                ctlRoute.Text += string.Format("#{0}, IP: {1} [ {2} ], Time: {3}ms.\r\n", objTraceHop.Hop, objTraceHop.IP, objTraceHop.Host, objTraceHop.ResponseTime);
                objTraceHop = (AxNetwork.TraceHop)objTraceRoute.FindNextHop();
                Application.DoEvents();
                this.Cursor = Cursors.WaitCursor;
            }

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
