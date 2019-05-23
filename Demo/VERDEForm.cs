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
    public partial class VERDEForm : Form
    {
        public class VERDECounter
        {
            public VERDECounter(int nCounter, string strDescription, string strContext)
            {
                m_nCounter = nCounter;
                m_strDescription = strDescription;
                m_strContext = strContext;
            }
            
            public int m_nCounter;
            public string m_strDescription;
            public string m_strContext;
        }

        IList<VERDECounter> lstCounters = new List<VERDECounter>();
        List<string> lstVMs = new List<string>();


        VERDE objVERDE = new VERDE ();
        NwConstants objConstants = new NwConstants();

        bool bConnected = false;
        bool bMonitorHost = true;
     
        public VERDEForm()
        {
            InitializeComponent();
        }

        private void VERDEForm_Load(object sender, EventArgs e)
        {
            objVERDE.Initialize();
            objVERDE.Clear();
            

            LoadCounters();
            ShowCounters();

            textLogFile.Text = System.IO.Path.GetTempPath() + "VERDE.log";

            UpdateControls();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(textLogFile.Text.ToString()))
            {
                System.Diagnostics.Process.Start(textLogFile.Text);
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (bConnected == false)
                DoConnect();
            else
                DoDisconnect();
        }

        private void DoConnect()
        {
            Cursor cur = Cursor.Current;

            Cursor.Current = Cursors.WaitCursor;

            objVERDE.LogFile = textLogFile.Text;
            objVERDE.Server = textHost.Text;
            objVERDE.ServerAccount = textAccount.Text;
            objVERDE.ServerPassword = textPassword.Text;

            objVERDE.Connect();

            textResult.Text = objVERDE.LastError.ToString() + ": " + objVERDE.GetErrorDescription(objVERDE.LastError);

            bConnected = objVERDE.LastError == 0;

            if (objVERDE.LastError == 0)
                LoadImages();

          UpdateControls();
          Cursor.Current = cur;
        }

        private void DoDisconnect()
        {
            objVERDE.Disconnect();

            textResult.Text = objVERDE.LastError.ToString() + ": " + objVERDE.GetErrorDescription(objVERDE.LastError);
            bConnected = false;

            comboVMs.Items.Clear();
            lstVMs.Clear();

            UpdateControls();
        }

        private void UpdateCounters()
        {
            if (!bConnected) return;
            int nValue = 0;

            foreach (ListViewItem objItem in listCounters.Items)
            {
                VERDECounter objCounter = (VERDECounter)objItem.Tag;

                String strValue = "N/A";

                if (bMonitorHost == false)
                {
                    nValue = objVERDE.GetPerfData (lstVMs[comboVMs.SelectedIndex], objCounter.m_nCounter, objCounter.m_strContext);
                }
                else
                {
                    nValue = objVERDE.GetPerfData (string.Empty, objCounter.m_nCounter, objCounter.m_strContext);
                }

                if (objVERDE.LastError != 0L)
                    strValue = objVERDE.GetErrorDescription(objVERDE.LastError);
                else
                    strValue = objVERDE.TranslatePerfData(objCounter.m_nCounter, nValue);
            
                objItem.SubItems[2].Text = strValue;
            }
        }

        private void ShowCounters ()
        {
            foreach (VERDECounter objCounter in lstCounters )
            {
                ListViewItem item = new ListViewItem ( objCounter.m_strDescription);

                item.SubItems.Add ( objCounter.m_strContext );
                item.SubItems.Add ( "n/a");

                item.Tag = ( object ) objCounter;

                listCounters.Items.Insert(0, item);
            }
        }

        private void LoadCounters()
        {
            lstCounters.Add(new VERDECounter(objConstants.nwVERDE_CPU_USAGE, "CPU Usage Overall (%)", ""));
            lstCounters.Add(new VERDECounter(objConstants.nwVERDE_MEMORY_USAGE, "Memory Usage (%)", ""));
            lstCounters.Add(new VERDECounter(objConstants.nwVERDE_EFFICIENCY, "Efficiency (%)", ""));
            lstCounters.Add(new VERDECounter(objConstants.nwVERDE_SESSIONS_CURRENT, "Current Session Count", ""));
            lstCounters.Add(new VERDECounter(objConstants.nwVERDE_SESSIONS_MAXIMUM, "Maximum Session Count", ""));
            lstCounters.Add(new VERDECounter(objConstants.nwVERDE_SESSIONS_RESERVED, "Reserved Session Count", ""));
        }
        
        private void LoadImages()
        {
            string strImage = string.Empty;
            string strSystem = string.Empty;

            comboVMs.Items.Clear();
            lstVMs.Clear();

            strImage = objVERDE.GetFirstImage();            

            while (objVERDE.LastError == 0)
            {
                lstVMs.Add(strImage);

                comboVMs.Items.Add(strImage);

                strImage = objVERDE.GetNextImage();
            }

            comboVMs.SelectedIndex = 0;
        }

        private void UpdateControls()
        {
            if (bConnected == false)
                buttonConnect.Text = "Connect";
            else
                buttonConnect.Text = "Disconnect";

            buttonStart.Enabled = bConnected && !timerUpdate.Enabled;
            buttonStop.Enabled = bConnected && timerUpdate.Enabled;
            textHost.Enabled = !bConnected;
            textAccount.Enabled = !bConnected;
            textPassword.Enabled = !bConnected;
            radioHost.Enabled = bConnected && !timerUpdate.Enabled; ;
            radioVirtual.Enabled = bConnected && !timerUpdate.Enabled; ;
            comboVMs.Enabled = bConnected && !bMonitorHost;

            listCounters.Enabled = bConnected && timerUpdate.Enabled;
        }

        private void radioHost_CheckedChanged(object sender, EventArgs e)
        {
            bMonitorHost = true;

            UpdateControls();
        }

        private void radioVirtual_CheckedChanged(object sender, EventArgs e)
        {
            bMonitorHost = false;

            UpdateControls();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timerUpdate.Enabled = true;

            UpdateControls();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timerUpdate.Enabled = false;

            UpdateControls();
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            UpdateCounters();
        }     
    }
}
