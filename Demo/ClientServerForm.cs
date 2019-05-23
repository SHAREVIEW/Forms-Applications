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
    public partial class ClientServerForm : Form
    {
        private Tcp objSocketServer = new Tcp();
        private Tcp objSocketClient = new Tcp();

        private NwConstants objConstants = new NwConstants();

        public ClientServerForm()
        {
            InitializeComponent();
        }

        private void ClientServerForm_Load(object sender, EventArgs e)
        {
            ctlLogFile.Text = System.IO.Path.GetTempPath() + "ClientServer.log";
            timer.Enabled = true;

            UpdateControls();
        }

        private void ctlServerListenStart_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            objSocketServer.Clear();
            objSocketServer.LogFile = ctlLogFile.Text;

            objSocketServer.StartListening(Int32.Parse(ctlServerPort.Text), ctlServerVersion.Checked ? true : false );
            ShowServerResult();
            UpdateControls();

            Cursor.Current = Cursors.Default;
        }

        private void ctlServerListenStop_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ctlServerReceived.Text = "";
            objSocketServer.StopListening();
            ShowServerResult();
            UpdateControls();
        }

        private void ctlServerDisconnect_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ctlServerResult.Text = "";           
            objSocketServer.Disconnect();
            ShowServerResult();
            UpdateControls();

            Cursor.Current = Cursors.Default;
        }

        private void ctlClientConnect_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            objSocketClient.Clear();
            objSocketClient.LogFile = ctlLogFile.Text;

            objSocketClient.Connect(ctlClientHost.Text, Int32.Parse(ctlClientPort.Text));
            ShowClientResult();
            UpdateControls();

            Cursor.Current = Cursors.Default;
        }

        private void ctlClientDisconnect_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            objSocketClient.Disconnect();
            ShowClientResult();
            UpdateControls();

            Cursor.Current = Cursors.Default;
        }

        private void ctlClientSend_Click(object sender, EventArgs e)
        {
            objSocketClient.SendString(ctlClientCommand.Text);
            ShowClientResult();
            UpdateControls();
        }

        private void ctlView_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(ctlLogFile.Text.ToString()))
            {
                System.Diagnostics.Process.Start(ctlLogFile.Text);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (objSocketServer.ConnectionState == objConstants.nwSOCKET_CONNSTATE_CONNECTED)
            {
                while (objSocketServer.HasData() )
                {
                    ctlServerReceived.Text = ctlServerReceived.Text + "[" + objSocketServer.RemoteAddress + "] " + objSocketServer.ReceiveString() + "\r\n";
                }
            }
        }

        private long ShowServerResult()
        {
            ctlServerResult.Text = objSocketServer.LastError.ToString() + ": " + objSocketServer.GetErrorDescription(objSocketServer.LastError);
            return objSocketServer.LastError;
        }

        private long ShowClientResult()
        {
            ctlClientResult.Text = objSocketClient.LastError.ToString() + ": " + objSocketClient.GetErrorDescription(objSocketClient.LastError);
            return objSocketClient.LastError;
        }

        private void UpdateControls()
        {
            ctlServerListenStart.Enabled = objSocketServer.ConnectionState == objConstants.nwSOCKET_CONNSTATE_DISCONNECTED;
            ctlServerListenStop.Enabled = objSocketServer.ConnectionState == objConstants.nwSOCKET_CONNSTATE_LISTENING;
            ctlServerDisconnect.Enabled = objSocketServer.ConnectionState == objConstants.nwSOCKET_CONNSTATE_CONNECTED;
            ctlServerVersion.Enabled = objSocketServer.ConnectionState == objConstants.nwSOCKET_CONNSTATE_DISCONNECTED;
            ctlServerPort.Enabled = objSocketServer.ConnectionState == objConstants.nwSOCKET_CONNSTATE_DISCONNECTED;

            ctlClientConnect.Enabled = objSocketClient.ConnectionState == objConstants.nwSOCKET_CONNSTATE_DISCONNECTED;
            ctlClientDisconnect.Enabled = objSocketClient.ConnectionState != objConstants.nwSOCKET_CONNSTATE_DISCONNECTED;
            ctlClientSend.Enabled = objSocketClient.ConnectionState == objConstants.nwSOCKET_CONNSTATE_CONNECTED;
        }
    }
}