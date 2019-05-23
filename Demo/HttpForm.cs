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
    public partial class HttpForm : Form
    {
        private AxNetwork.HttpEx objHttp = new HttpEx();

        public HttpForm()
        {
            InitializeComponent();
        }

        private void HttpForm_Load(object sender, EventArgs e)
        {
            ctlLogFile.Text = System.IO.Path.GetTempPath() + "Http.log";

            ctlAllowSSL3.Checked = objHttp.AllowSSL3;   // Initialize with ActiveXperts Network Monitor's default value
            ctlAllowSSL2.Checked = objHttp.AllowSSL2;   // Initialize with ActiveXperts Network Monitor's default value
            ctlAllowTLS1.Checked = objHttp.AllowTLS1;   // Initialize with ActiveXperts Network Monitor's default value

        }

        private void ctlGo_Click(object sender, EventArgs e)
        {
            objHttp.Clear();
            string strData = "";
            ctlResult.Text = "";
            ctlStatusCode.Text = "";

            Cursor.Current = Cursors.WaitCursor;

            objHttp.WebAccount = ctlAccount.Text;
            objHttp.WebPassword = ctlPassword.Text;

            objHttp.ProxyAccount = ctlProxyAccount.Text;
            objHttp.ProxyPassword = ctlProxyPassword.Text;
            objHttp.ProxyServer = ctlProxyServer.Text;

            objHttp.AllowSSL3 = ctlAllowSSL3.Checked;
            objHttp.AllowSSL2 = ctlAllowSSL2.Checked;
            objHttp.AllowTLS1 = ctlAllowTLS1.Checked;

            objHttp.LogFile = ctlLogFile.Text;

            
            strData = objHttp.Get(ctlServer.Text);
            ctlResult.Text = objHttp.LastError + ": " + objHttp.GetErrorDescription(objHttp.LastError);
            ctlStatusCode.Text = objHttp.LastResponseCode.ToString();

            if (objHttp.LastError == 0)
            {
                ctlOutput.Text = strData;
            }
            else
            {
                ctlOutput.Text = "n/a";
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