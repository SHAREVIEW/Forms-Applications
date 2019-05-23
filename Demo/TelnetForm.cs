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
    public partial class TelnetForm : Form
    {
        private Tcp objSocket = new Tcp();
        private NwConstants objConstants = new NwConstants();

        public TelnetForm()
        {
            InitializeComponent();
        }

        private void TelnetForm_Load(object sender, EventArgs e)
        {
            objSocket.Protocol = objConstants.nwSOCKET_PROTOCOL_TELNET;

            ctlLogFile.Text = System.IO.Path.GetTempPath() + "Telnet.log";

            EnableControls();

            timer1.Enabled = true;
        }

        private void ctlConnect_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            objSocket.Clear();
            objSocket.LogFile = ctlLogFile.Text;
            objSocket.Connect(ctlHost.Text, Int32.Parse(ctlPort.Text));
            Cursor.Current = Cursors.Default;

            GetResult();
            EnableControls();
        }

        private void ctlDisconnect_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            objSocket.Disconnect();
            Cursor.Current = Cursors.Default;

            GetResult();
            EnableControls();
        }

        private void ctlSend_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            objSocket.SendString(ctlCommand.Text);
            Cursor.Current = Cursors.Default;

            GetResult();
            EnableControls();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (objSocket.ConnectionState == objConstants.nwSOCKET_CONNSTATE_CONNECTED)
            {
                while (objSocket.HasData() )
                {
                    ctlResponse.Text = ctlResponse.Text + objSocket.ReceiveString() + "\r\n";
                }
            }
        }

        private void ctlView_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(ctlLogFile.Text.ToString()))
            {
                System.Diagnostics.Process.Start(ctlLogFile.Text);
            }
        }

        private void EnableControls()
        {
            if (objSocket.ConnectionState == objConstants.nwSOCKET_CONNSTATE_CONNECTED)
            {
                ctlDisconnect.Enabled = true;
                ctlConnect.Enabled = false;
                ctlSend.Enabled = true;
                ctlResponse.Enabled = true;
                ctlCommand.Enabled = true;
            }
            else
            {
                ctlDisconnect.Enabled = false;
                ctlConnect.Enabled = true;
                ctlSend.Enabled = false;
                ctlResponse.Enabled = false;
                ctlCommand.Enabled = false;
            }
        }

        private long GetResult()
        {
            ctlResult.Text = objSocket.LastError + ": " + objSocket.GetErrorDescription(objSocket.LastError);
            return objSocket.LastError;
        }
    }
}