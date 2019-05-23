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
    public partial class HttpPostForm : Form
    {
        private AxNetwork.HttpEx objHttp = new AxNetwork.HttpEx();

        public HttpPostForm()
        {
            InitializeComponent();
        }

        private void HttpPostForm_Load(object sender, EventArgs e)
        {
            ctlLogFile.Text = System.IO.Path.GetTempPath() + "HttpPost.log";
        }

        private void ctlSend_Click(object sender, EventArgs e)
        {
            string strData = "";

            objHttp.LogFile = ctlLogFile.Text;

            strData = objHttp.Post(ctlUrl.Text, ctlPostData.Text);

            if (objHttp.LastError == 0)
                ctlResponse.Text = strData;
            else
                ctlResponse.Text = "";

            ctlStatusCode.Text = objHttp.LastResponseCode.ToString();
            ctlResult.Text = objHttp.LastError + ": " + objHttp.GetErrorDescription(objHttp.LastError);

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