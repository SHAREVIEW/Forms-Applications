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
    public partial class ScpForm : Form
    {
        private AxNetwork.Scp objScp = new AxNetwork.Scp();

        public ScpForm()
        {
            InitializeComponent();
            ctlLocalFile.Text = Path.GetTempPath() + "readme.txt";
            ctlLogfile.Text = System.IO.Path.GetTempPath() + "Scp.log";
            SetLocalFilename();            
        }

        private void ctlCopy_Click(object sender, EventArgs e)
        {
            objScp.Clear();
            objScp.Host = ctlHost.Text;
            objScp.UserName = ctlUsername.Text;
            objScp.Password = ctlPassword.Text;
            objScp.PrivateKeyFile = ctlKeyFile.Text;
            objScp.LogFile = ctlLogfile.Text;
            objScp.AcceptHostKey = ctlAcceptKey.Checked ? true : false;

            Cursor.Current = Cursors.WaitCursor;

            if (ctlRemoteToLocal.Checked)
            {
                objScp.CopyToLocal(ctlRemoteFile.Text, ctlLocalFile.Text);
            }
            else
            {
                objScp.CopyToRemote(ctlLocalFile.Text, ctlRemoteFile.Text);
            }

            Cursor.Current = Cursors.Default;

            GetResult();
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

        private void ctlView_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(ctlLogfile.Text.ToString()))
            {
                System.Diagnostics.Process.Start(ctlLogfile.Text);
            }
        }

        private void cltBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Private key files (*.ppk)|*.ppk";
            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            ctlKeyFile.Text = openFileDialog1.FileName;
        }

        private long GetResult()
        {
            int lResult = objScp.LastError;

            ctlResult.Text = lResult.ToString() + ": " + objScp.GetErrorDescription(lResult);
            ctlProtocolError.Text = objScp.ProtocolError;

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
    }
}