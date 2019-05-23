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
    public partial class SFtpForm : Form
    {
        private AxNetwork.SFtp objSFtp = new AxNetwork.SFtp();
        private bool bConnected = false;

        public SFtpForm()
        {
            InitializeComponent();
        }

        private void SFtpForm_Load(object sender, EventArgs e)
        {
            ctlLogfile.Text = System.IO.Path.GetTempPath() + "SFtp.log";

            bConnected = false;

            UpdateControls();
        }

        private void ctlConnect_Click(object sender, EventArgs e)
        {
           objSFtp.Clear();
            objSFtp.LogFile = ctlLogfile.Text;
            objSFtp.Port = Int32.Parse(ctlPort.Text);
            objSFtp.Host = ctlHost.Text;
            objSFtp.UserName = ctlUsername.Text;
            objSFtp.Password = ctlPassword.Text;
            objSFtp.PrivateKeyFile = ctlKeyFile.Text;
            objSFtp.AcceptHostKey = ctlAcceptKey.Checked ? true : false;

            Cursor.Current = Cursors.WaitCursor;
            objSFtp.Connect();
            Cursor.Current = Cursors.Default;

            if (GetResult() == 0)
            {
                bConnected = true;
                RefreshDir();
            }

            UpdateControls();
        }

        private void ctlDisconnect_Click(object sender, EventArgs e)
        {
            objSFtp.Disconnect();
            ctlListFiles.Clear();
            ctlProtocolError.Text = "";
            bConnected = false;
            UpdateControls();
        }

        private void ctlRefresh_Click(object sender, EventArgs e)
        {
            RefreshDir();
        }

        private void ctlGet_Click(object sender, EventArgs e)
        {
            if (ctlListFiles.SelectedItems.Count > 0 && ctlListFiles.SelectedItems[0].SubItems[1].Text != "<DIR>")
            {
                saveFileDialog1.FileName = ctlListFiles.SelectedItems[0].Text;
                if (saveFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;

                objSFtp.GetFile(ctlListFiles.SelectedItems[0].Text, saveFileDialog1.FileName);

                if (GetResult() == 0)
                {
                    RefreshDir();
                }
            }
        }

        private void ctlPut_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            String target = "./" + System.IO.Path.GetFileName(openFileDialog1.FileName);
            objSFtp.PutFile(openFileDialog1.FileName, target);            

            if (GetResult() == 0)
            {
                RefreshDir();
            }
        }

        private void ctlDelete_Click(object sender, EventArgs e)
        {
            if (ctlListFiles.SelectedItems.Count > 0 && ctlListFiles.SelectedItems[0].SubItems[1].Text != "<DIR>")
            {
                objSFtp.DeleteFile(ctlListFiles.SelectedItems[0].Text);

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
            int lResult = objSFtp.LastError;

            ctlResult.Text = lResult.ToString() + ": " + objSFtp.GetErrorDescription(lResult);
            ctlProtocolError.Text = objSFtp.ProtocolError;

            return lResult;
        }

        private void UpdateControls()
        {
            ctlHost.Enabled = !bConnected;
            ctlPort.Enabled = !bConnected;

            ctlConnect.Enabled = !bConnected;
            ctlUsername.Enabled = !bConnected;
            ctlPassword.Enabled = !bConnected;
            ctlKeyFile.Enabled = !bConnected;
            ctlBrowse.Enabled = !bConnected;
            ctlAcceptKey.Enabled = !bConnected;

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

            ctlCwd.Text = objSFtp.GetCurrentDir();

            ctlListFiles.Items.Clear();

            objItem = ctlListFiles.Items.Add("..");
            objItem.SubItems.Add("<DIR>");

            SFtpFile objFile;

            objFile = (SFtpFile)objSFtp.FindFirstFile(".");

            while (objSFtp.LastError == 0)
            {
                if (!(objFile.Name == "." || objFile.Name == ".."))
                {
                    objItem = ctlListFiles.Items.Add(objFile.Name);

                    if (objFile.IsDirectory )
                    {
                        objItem.SubItems.Add("<DIR>");
                    }
                    else
                    {
                        objItem.SubItems.Add(objFile.SizeBytes.ToString());
                    }

                    objItem.SubItems.Add(objFile.Date);
                }

                objFile = (SFtpFile)objSFtp.FindNextFile();
            }
        }

        private void ctlListFiles_DoubleClick(object sender, EventArgs e)
        {
            if (ctlListFiles.SelectedItems.Count > 0 && ctlListFiles.SelectedItems[0].SubItems[1].Text == "<DIR>")
            {
                objSFtp.ChangeDir(ctlListFiles.SelectedItems[0].Text);

                if (GetResult() == 0)
                {
                    RefreshDir();
                }
            }
        }

        private void cltBrowsePrivKey_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Private key files (*.ppk)|*.ppk";
            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            ctlKeyFile.Text = openFileDialog1.FileName;
        }
    }
}