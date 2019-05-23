using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AxNetwork;
using System.IO;


namespace Demo
{
    public partial class TftpForm : Form
    {
        private TftpServer objTftp = new TftpServer();

        public TftpForm()
        {
            InitializeComponent();
            ctlLocalFile.Text = Path.GetTempPath();
            ctlLogfile.Text = System.IO.Path.GetTempPath() + "Tftp.log";
            SetLocalFilename();
            ctlLocalFile.Text += "readme.txt";
        }

        private void TftpForm_Load(object sender, EventArgs e)
        {

        }

        private void ctlToBrowse_Click(object sender, EventArgs e)
        {
            if (ctlRemoteToLocal.Checked)
            {
                saveFileDialog1.FileName = GetFileNameRemote();
                if (saveFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;

                ctlLocalFile.Text = saveFileDialog1.FileName;
            }
            else
            {
                if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;

                ctlLocalFile.Text = openFileDialog1.FileName;
            }
        }

        private void ctlConnect_Click(object sender, EventArgs e)
        {
            objTftp.Clear();
            objTftp.LogFile = ctlLogfile.Text;
            objTftp.HostPort = Int32.Parse(ctlPort.Text);
            objTftp.BinaryTransfer = true;

            if (ctlRemoteToLocal.Checked)
            {
                objTftp.Get(ctlHost.Text, ctlRemoteFile.Text, ctlLocalFile.Text);
            }
            else
            {
                objTftp.Put(ctlHost.Text, ctlLocalFile.Text, ctlRemoteFile.Text);
            }

            GetResult();
        }

        private void ctlView_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(ctlLogfile.Text.ToString()))
            {
                System.Diagnostics.Process.Start(ctlLogfile.Text);
            }
        }

        private long GetResult()
        {
            int lResult = objTftp.LastError;

            ctlResult.Text = lResult.ToString() + ": " + objTftp.GetErrorDescription(lResult);

            return lResult;
        }

        public void SetLocalFilename()
        {
            string strFileName = "";
            string strPath = "";
            if (ctlRemoteFile.Text.Contains("/"))
            {
                strFileName = ctlRemoteFile.Text.Substring(ctlRemoteFile.Text.LastIndexOf("/") + 1);
            }
            else
            {
                strFileName = ctlRemoteFile.Text;
            }

            if (ctlLocalFile.Text.Contains(@"\"))
            {
                strPath = ctlLocalFile.Text.Substring(0, ctlLocalFile.Text.LastIndexOf(@"\") + 1);
            }

            strPath += strFileName;
            ctlLocalFile.Text = strPath;
        }

        public void SetRemoteFilename()
        {
            string strFileName = "";
            string strPath = "";            

            if (ctlLocalFile.Text.Contains(@"\"))
            {
                strFileName = ctlLocalFile.Text.Substring(ctlLocalFile.Text.LastIndexOf(@"\") + 1);
            }
            else
            {
                strFileName = ctlLocalFile.Text;
            }

            if (ctlRemoteFile.Text.Contains("/"))
            {
                strPath = ctlRemoteFile.Text.Substring(0, ctlRemoteFile.Text.LastIndexOf("/") + 1);
            }

            strPath += strFileName;
            ctlRemoteFile.Text = strPath;
        }

        private void ctlRemoteFile_TextChanged(object sender, EventArgs e)
        {
          SetLocalFilename();            
        }

        private void ctlLocalFile_TextChanged(object sender, EventArgs e)
        {
            SetRemoteFilename();
        }

        private void ctlRemoteFile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\\')
            {
                e.KeyChar = '/';
            }
        }

        private void ctlLocalFile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '/')
            {
                e.KeyChar = '\\';
            }
        }

        private string GetFileNameRemote()
        {
            if (ctlRemoteFile.Text.Contains("/"))
            {
                return ctlRemoteFile.Text.Substring(ctlRemoteFile.Text.LastIndexOf("/") + 1);
            }
            else
            {
                return ctlRemoteFile.Text;
            }
        }
    }
}