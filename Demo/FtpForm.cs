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
    public partial class FtpForm : Form
    {
        private AxNetwork.FtpServer objFtp = new AxNetwork.FtpServer();
        private bool bConnected = false;

        public FtpForm()
        {
            InitializeComponent();
        }

        private void FtpForm_Load(object sender, EventArgs e)
        {
            ctlLogfile.Text = System.IO.Path.GetTempPath() + "Ftp.log";

            bConnected = false;

            EnableControls();
        }

        private void ctlConnect_Click(object sender, EventArgs e)
        {
            if (bConnected)
                return;

            objFtp.LogFile = ctlLogfile.Text;
            objFtp.HostPort = Int32.Parse(ctlPort.Text);

            objFtp.Connect(ctlHost.Text, ctlUsername.Text, ctlPassword.Text);

            if (GetResult() == 0)
            {
                bConnected = true;
                EnableControls();
                RefreshDir();
            }
        }

        private void ctlDisconnect_Click(object sender, EventArgs e)
        {
            if (!bConnected)
                return;

            objFtp.Disconnect();
            ctlResult.Text = objFtp.LastError.ToString() + ": " + objFtp.GetErrorDescription(objFtp.LastError);
            ctlListFiles.Items.Clear();
            bConnected = false;
            EnableControls();
        }

        private void ctlRefresh_Click(object sender, EventArgs e)
        {
            RefreshDir();
        }

        private void ctlGet_Click(object sender, EventArgs e)
        {
            if (!bConnected)
                return;

            if (ctlListFiles.SelectedItems.Count > 0 && ctlListFiles.SelectedItems[0].SubItems[1].Text != "<DIR>")
            {
                saveFileDialog1.FileName = ctlListFiles.SelectedItems[0].Text;
                if( saveFileDialog1.ShowDialog()!= System.Windows.Forms.DialogResult.OK)
                    return;

                objFtp.GetFile(ctlListFiles.SelectedItems[0].Text, saveFileDialog1.FileName);

                if (GetResult() == 0)
                {
                    RefreshDir();
                }
            }
        }

        private void ctlPut_Click(object sender, EventArgs e)
        {
            if (!bConnected)
                return;

            if( openFileDialog1.ShowDialog()!= System.Windows.Forms.DialogResult.OK)
                    return;

            objFtp.PutFile(openFileDialog1.FileName, string.Empty);

            if (GetResult() == 0)
            {
                RefreshDir();
            }
        }

        private void ctlDelete_Click(object sender, EventArgs e)
        {
            if (!bConnected)
                return;

            if (ctlListFiles.SelectedItems.Count > 0 && ctlListFiles.SelectedItems[0].SubItems[1].Text != "<DIR>")
            {
                objFtp.DeleteFile(ctlListFiles.SelectedItems[0].Text);

                if (GetResult() == 0)
                {
                    RefreshDir();
                }
            }
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
            int lResult = objFtp.LastError;

            ctlResult.Text = lResult.ToString() + ": " + objFtp.GetErrorDescription(lResult);

            return lResult;
        }

        private void EnableControls()
        {
            ctlHost.Enabled = !bConnected;
            ctlPort.Enabled = !bConnected;

            ctlConnect.Enabled = !bConnected;
            ctlUsername.Enabled = !bConnected;
            ctlPassword.Enabled = !bConnected;

            ctlDisconnect.Enabled = bConnected;
            ctlRefresh.Enabled = bConnected;
            ctlGet.Enabled = bConnected;
            ctlPut.Enabled = bConnected;
            ctlDelete.Enabled = bConnected;
            ctlListFiles.Enabled = bConnected;
        }

        private void RefreshDir()
        {
            ListViewItem objItem;

            ctlListFiles.Items.Clear();

            objItem = ctlListFiles.Items.Add("..");
            objItem.SubItems.Add("<DIR>");

            FtpFile objFile;

            objFile = (FtpFile)objFtp.FindFirstFile();

            while (objFtp.LastError == 0)
            {
                objItem = ctlListFiles.Items.Add(objFile.Name);

                if (objFile.IsDirectory )
                {
                    objItem.SubItems.Add("<DIR>");
                }
                else
                {
                    objItem.SubItems.Add(objFile.Size.ToString());
                }

                objItem.SubItems.Add(objFile.Date);

                objFile = (FtpFile)objFtp.FindNextFile();
            }
        }

        private void ctlListFiles_DoubleClick(object sender, EventArgs e)
        {
            if (ctlListFiles.SelectedItems[0].SubItems[1].Text == "<DIR>")
            {
                objFtp.ChangeDir(ctlListFiles.SelectedItems[0].Text);

                if (GetResult() == 0)
                {
                    RefreshDir();
                }
            }
        }
    }
}