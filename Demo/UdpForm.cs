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
    public partial class UdpForm : Form
    {
        /********************************************************************************/

        private Udp objClient = new Udp();
        private Udp objServer = new Udp();

        /********************************************************************************/

        public UdpForm()
        {
            InitializeComponent();
        }

        /********************************************************************************/

        private void UdpForm_Load(object sender, EventArgs e)
        {
            ctlLogFile.Text = System.IO.Path.GetTempPath() + "Udp.log";
        }

        /********************************************************************************/

        private void ctlServerListenStart_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            objServer.Clear();
            objServer.LogFile = ctlLogFile.Text;

            objServer.IOTimeout = 100;
            objServer.Open("localhost", System.Int32.Parse(ctlServerPort.Text), true, ctlServerVersion.Checked ? true : false );

            if (GetServerResult() == 0)
            {
                ctlServerListenStart.Enabled = false;
                ctlServerListenStop.Enabled = true;
                ctlServerPort.Enabled = false;
                ctlServerVersion.Enabled = false;
                Timer.Enabled = true;
            }

            Cursor.Current = Cursors.Default;
        }

        /********************************************************************************/

        private void ctlServerListenStop_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            objServer.Close();

            if (GetServerResult() == 0)
            {
                ctlServerListenStart.Enabled = true;
                ctlServerListenStop.Enabled = false;
                ctlServerPort.Enabled = true;
                ctlServerVersion.Enabled = true;
                Timer.Enabled = false;
            }

            Cursor.Current = Cursors.Default;
        }

        /********************************************************************************/

        private void ctlClientOpen_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            objClient.Clear();
            objClient.LogFile = ctlLogFile.Text;
            objClient.Open(ctlClientHost.Text, System.Int32.Parse(ctlClientPort.Text), false, ctlServerVersion.Checked ? true : false );

            if (GetClientResult() == 0)
            {
                ctlClientSend.Enabled = true;
                ctlClientClose.Enabled = true;
                ctlClientOpen.Enabled = false;
                ctlClientCommand.Enabled = true;
                ctlClientHost.Enabled = false;
                ctlClientPort.Enabled = false;
            }

            Cursor.Current = Cursors.Default;
        }

        /********************************************************************************/

        private void ctlClientClose_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            objClient.Close();

            if (GetClientResult() == 0)
            {
                ctlClientSend.Enabled = false;
                ctlClientClose.Enabled = false;
                ctlClientOpen.Enabled = true;
                ctlClientCommand.Enabled = false;
                ctlClientHost.Enabled = true;
                ctlClientPort.Enabled = true;
            }

            Cursor.Current = Cursors.Default;
        }

        /********************************************************************************/

        private void ctlClientSend_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            objClient.SendString(ctlClientCommand.Text);

            Cursor.Current = Cursors.Default;
        }

        /********************************************************************************/

        private void Timer_Tick(object sender, EventArgs e)
        {
            String strTemp;

           strTemp = objServer.ReceiveString();

            if (strTemp.Length > 0)
            {
                ctServerResponse.Text = ctServerResponse.Text + strTemp + "\r\n";
            }
        }

        /********************************************************************************/

        private void ctlView_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(ctlLogFile.Text.ToString()))
            {
                System.Diagnostics.Process.Start(ctlLogFile.Text);
            }
        }

        /********************************************************************************/
        
        private long GetClientResult()
        {
            ctlClientResult.Text = objClient.LastError.ToString() + ": " + objClient.GetErrorDescription(objClient.LastError);
            return objClient.LastError;
        }

        /********************************************************************************/

        private long GetServerResult()
        {
            ctlServerResult.Text = objServer.LastError.ToString() + ": " + objServer.GetErrorDescription(objServer.LastError);
            return objServer.LastError;
        }

        /********************************************************************************/
    }
}