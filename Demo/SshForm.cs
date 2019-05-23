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
    public partial class SshForm : Form
    {
        private Ssh objSsh = new Ssh();

        public SshForm()
        {
            InitializeComponent();
        }

        private void SshForm_Load(object sender, EventArgs e)
        {
            objSsh.Clear();
            ctlPort.Text = objSsh.Port.ToString();
            ctlConnectTimeout.Text = objSsh.ConnectTimeout.ToString();	// Take toolkit's default timeout value
            ctlCommandTimeout.Text = objSsh.CommandTimeout.ToString();	// Take toolkit's default timeout value
            ctlLogFile.Text = System.IO.Path.GetTempPath() + "Ssh.log";

            timer1.Enabled = true;
        }
       
        private void ctlBrowse_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog fdlg;

            fdlg = new OpenFileDialog();
            fdlg.Title = "Select Attachment";
            fdlg.InitialDirectory = "C:\\";
            fdlg.Filter = "PPK files (*.ppk)|*.ppk";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() != DialogResult.OK)
                return;

            ctlPrivateKeyFile.Text = fdlg.FileName;
        }

        private void ctlView_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(ctlLogFile.Text.ToString()))
            {
                System.Diagnostics.Process.Start(ctlLogFile.Text);
            }
        }


        private void ctlConnect_Click(object sender, EventArgs e)
        {
            ctlProtocolError.Text = "";
            ctlStdOut.Text = "";
            ctlStdErr.Text = "";

            Cursor.Current = Cursors.WaitCursor;

            if (objSsh.IsSessionOpened())
            {
                objSsh.CloseSession();
            }
            else
            {
                objSsh.Clear();
                objSsh.Host = ctlHost.Text;
                objSsh.Port = Int16.Parse(ctlPort.Text);
                objSsh.RequireHostVerification = ctlAcceptHostKey.Checked ? true : false;
                objSsh.UserName = ctlUser.Text;
                objSsh.Password = ctlPassword.Text;
                objSsh.PrivateKeyFile = ctlPrivateKeyFile.Text;
                objSsh.ConnectTimeout = Int32.Parse(ctlConnectTimeout.Text);
                objSsh.LogFile = ctlLogFile.Text;

                objSsh.OpenSession();

                ctlResult.Text = objSsh.LastError + ": " + objSsh.GetErrorDescription(objSsh.LastError);
                ctlProtocolError.Text = objSsh.ProtocolError;

                ctlStdOut.Text = objSsh.StdOut.Replace("\n", "\r\n");
                ctlStdErr.Text = objSsh.StdErr.Replace("\n", "\r\n");
            }

            Cursor.Current = Cursors.Default;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            EnableControls();
        }

        private void EnableControls()
        {
            if (objSsh.IsSessionOpened())
            {
                ctlHost.Enabled = false;
                ctlPort.Enabled = false;
                ctlConnectTimeout.Enabled = false;
                ctlUser.Enabled = false;
                ctlPassword.Enabled = false;
                ctlPrivateKeyFile.Enabled = false; 
                ctlBrowse.Enabled = false;
                ctlAcceptHostKey.Enabled = false;
                ctlLogFile.Enabled = false;

                ctlCommand.Enabled = true;
                ctlCommandTimeout.Enabled = true;
                ctlExecuteCommand.Enabled = true;
            }
            else
            {
                ctlHost.Enabled = true;
                ctlPort.Enabled = true;
                ctlConnectTimeout.Enabled = true;
                ctlUser.Enabled = true;
                ctlPassword.Enabled = true;
                ctlPrivateKeyFile.Enabled = true;
                ctlBrowse.Enabled = true; 
                ctlAcceptHostKey.Enabled = true;
                ctlLogFile.Enabled = true;

                ctlCommand.Enabled = false;
                ctlCommandTimeout.Enabled = false;
                ctlExecuteCommand.Enabled = false;
            }

            ctlConnect.Text = objSsh.IsSessionOpened() ? "CloseSession" : "OpenSession";
        }

        private void ctlExecuteCommand_Click(object sender, EventArgs e)
        {
            ctlProtocolError.Text = "";
            ctlStdOut.Text = "";
            ctlStdErr.Text = "";


            objSsh.Command = ctlCommand.Text;
            objSsh.CommandTimeout = Int32.Parse(ctlCommandTimeout.Text);

            Cursor.Current = Cursors.WaitCursor;

            objSsh.ExecuteCommand();

            Cursor.Current = Cursors.Default;

            ctlResult.Text = objSsh.LastError + ": " + objSsh.GetErrorDescription(objSsh.LastError);
            ctlProtocolError.Text = objSsh.ProtocolError;

            ctlStdOut.Text = objSsh.StdOut.Replace("\n", "\r\n");
            ctlStdErr.Text = objSsh.StdErr.Replace("\n", "\r\n");
        }
    }
}