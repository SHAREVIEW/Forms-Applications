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
    public partial class IPtoCountryForm : Form
    {
        private AxNetwork.IPtoCountry objIPC = new AxNetwork.IPtoCountry();

        public IPtoCountryForm()
        {
            InitializeComponent();
        }

        private void IPtoCountryForm_Load(object sender, EventArgs e)
        {
            ctlLogFile.Text = System.IO.Path.GetTempPath() + "IPtoCountry.log";
        }

        private void ctlQuery_Click(object sender, EventArgs e)
        {
            objIPC.Clear();
            objIPC.LogFile = ctlLogFile.Text;
            objIPC.Host = ctlHost.Text;
            objIPC.Query();

            ctlResult.Text = string.Format("{0}: {1}", objIPC.LastError.ToString(), objIPC.GetErrorDescription(objIPC.LastError));
            ctlCountry.Text = objIPC.CountryName;
            ctlCountryCodeEx.Text = objIPC.CountryCodeEx;
            ctlCountryCode.Text = objIPC.CountryCode;
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