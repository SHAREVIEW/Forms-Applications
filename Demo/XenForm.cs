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
    public partial class XenForm : Form
    {
        public class XenCounter
        {
            public XenCounter(int nCounter, string strDescription, string strContext)
            {
                m_nCounter = nCounter;
                m_strDescription = strDescription;
                m_strContext = strContext;
            }

            public int m_nCounter;
            public string m_strDescription;
            public string m_strContext;
        }

        IList<XenCounter> lstCounters = new List<XenCounter>();
        List<string> lstVMs = new List<string>();

        Xen objXen = new Xen();

        NwConstants objConstants = new NwConstants();

        bool bConnected = false;
        bool bMonitorHost = true;

        public XenForm()
        {
            InitializeComponent();
        }

        private void XenForm_Load(object sender, EventArgs e)
        {
            objXen.Initialize();
            objXen.Clear();

            LoadCounters();
            ShowCounters();

            textLogFile.Text = System.IO.Path.GetTempPath() + "Xen.log";

            UpdateControls();

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (bConnected == false)
                DoConnect();
            else
                DoDisconnect();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(textLogFile.Text.ToString()))
            {
                System.Diagnostics.Process.Start(textLogFile.Text);
            }
        }

        private void DoConnect()
        {
            Cursor cur = Cursor.Current;

            Cursor.Current = Cursors.WaitCursor;

            objXen.LogFile = textLogFile.Text;
            objXen.Server = textHost.Text;
            objXen.ServerAccount = textAccount.Text;
            objXen.ServerPassword = textPassword.Text;

            objXen.Connect();

            textResult.Text = objXen.LastError.ToString() + ": " + objXen.GetErrorDescription(objXen.LastError);

            bConnected = objXen.LastError == 0;

            if (objXen.LastError == 0)
                LoadVirtualMachines();

            UpdateControls();
            Cursor.Current = cur;
        }

        private void DoDisconnect()
        {
            objXen.Disconnect();

            textResult.Text = objXen.LastError.ToString() + ": " + objXen.GetErrorDescription(objXen.LastError);
            bConnected = false;

            comboVMs.Items.Clear();
            lstVMs.Clear();

            UpdateControls();
        }

        private void UpdateCounters()
        {
            if (!bConnected) return;
            String strValue = string.Empty;

            int nValue = 0;

            foreach (ListViewItem objItem in listCounters.Items)
            {
                XenCounter objCounter = (XenCounter)objItem.Tag;

                if (bMonitorHost == false)
                    nValue = objXen.GetPerfData(lstVMs[comboVMs.SelectedIndex], objCounter.m_nCounter, objCounter.m_strContext);
                else
                    nValue = objXen.GetPerfData(string.Empty, objCounter.m_nCounter, objCounter.m_strContext);

                if (objXen.LastError != 0L)
                    strValue = objXen.GetErrorDescription(objXen.LastError);
                else
                    strValue = objXen.TranslatePerfData(objCounter.m_nCounter, nValue);

                objItem.SubItems[2].Text = strValue;
            }
        }

        private void ShowCounters()
        {
            foreach (XenCounter objCounter in lstCounters)
            {
                ListViewItem item = new ListViewItem(objCounter.m_strDescription);

                item.SubItems.Add(objCounter.m_strContext);
                item.SubItems.Add("n/a");

                item.Tag = (object)objCounter;

                listCounters.Items.Insert(0, item);
            }
        }

        private void LoadCounters()
        {
            lstCounters.Add(new XenCounter(objConstants.nwXEN_CPU_USAGE, "CPU Usage Overall", ""));
            lstCounters.Add(new XenCounter(objConstants.nwXEN_CPU_USAGE, "CPU Usage CPU#0", "0"));
            lstCounters.Add(new XenCounter(objConstants.nwXEN_CPU_USAGE, "CPU Usage CPU#1", "1"));
            lstCounters.Add(new XenCounter(objConstants.nwXEN_MEMORY_USAGE, "Memory Usage", ""));
            lstCounters.Add(new XenCounter(objConstants.nwXEN_MEMORY_USED, "Memory Used", ""));
            lstCounters.Add(new XenCounter(objConstants.nwXEN_MEMORY_AVAILABLE, "Memory Available", ""));
            lstCounters.Add(new XenCounter(objConstants.nwXEN_POWER_STATE, "Power State", ""));
            lstCounters.Add(new XenCounter(objConstants.nwXEN_GUESTTOOLS, "Guest Tools", ""));
            lstCounters.Add(new XenCounter(objConstants.nwXEN_DISK_USAGE, "Disk Usage (%)", "2"));
            lstCounters.Add(new XenCounter(objConstants.nwXEN_DISK_USED, "Disk Used (MB)", "2"));
            lstCounters.Add(new XenCounter(objConstants.nwXEN_DISK_AVAILABLE, "Disk Available (MB)", "2"));
 
        }

        private void LoadVirtualMachines()
        {
            string strHost = string.Empty;
            string strSystem = string.Empty;

            comboVMs.Items.Clear();
            lstVMs.Clear();

            strHost = objXen.GetFirstVirtualMachine();
            

            while (objXen.LastError == 0)
            {
                lstVMs.Add(strHost);
                strSystem = objXen.GetOperatingSystem(strHost);

                if (strSystem.Length != 0L)
                {
                    strHost = string.Format("{0} - {1}", strHost, strSystem);
                }
                
                comboVMs.Items.Add(strHost);

                strHost = objXen.GetNextVirtualMachine();
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
