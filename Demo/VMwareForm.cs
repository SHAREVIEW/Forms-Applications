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
    public partial class VMwareForm : Form
    {
        public class VMwareCounter
        {
            public VMwareCounter(int nCounter, string strDescription, string strContext)
            {
                m_nCounter = nCounter;
                m_strDescription = strDescription;
                m_strContext = strContext;
            }
            
            public int m_nCounter;
            public string m_strDescription;
            public string m_strContext;
        }

        IList<VMwareCounter> lstCounters = new List<VMwareCounter>();
        List<string> lstVMs = new List<string>();


        VMware objVMware = new VMware ();
        NwConstants objConstants = new NwConstants();

        bool bConnected = false;
        bool bMonitorHost = true;
     
        public VMwareForm()
        {
            InitializeComponent();
        }

        private void VMwareForm_Load(object sender, EventArgs e)
        {
            objVMware.Initialize();
            objVMware.Clear();
            

            LoadCounters();
            ShowCounters();

            textLogFile.Text = System.IO.Path.GetTempPath() + "VMware.log";

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

            objVMware.LogFile = textLogFile.Text;
            objVMware.Server = textHost.Text;
            objVMware.ServerAccount = textAccount.Text;
            objVMware.ServerPassword = textPassword.Text;

            objVMware.Connect();

            textResult.Text = objVMware.LastError.ToString() + ": " + objVMware.GetErrorDescription(objVMware.LastError);

            bConnected = objVMware.LastError == 0;

            if (objVMware.LastError == 0)
                LoadVirtualMachines();

          UpdateControls();
          Cursor.Current = cur;
        }

        private void DoDisconnect()
        {
            objVMware.Disconnect();

            textResult.Text = objVMware.LastError.ToString() + ": " + objVMware.GetErrorDescription(objVMware.LastError);
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
                VMwareCounter objCounter = (VMwareCounter)objItem.Tag;

                String strValue = "n/a";

                if (bMonitorHost == false)
                {
                    nValue = objVMware.GetPerfData (lstVMs[comboVMs.SelectedIndex], objCounter.m_nCounter, objCounter.m_strContext);
                }
                else
                {
                    nValue = objVMware.GetPerfData (string.Empty, objCounter.m_nCounter, objCounter.m_strContext);
                }

                if (objVMware.LastError != 0L)
                    strValue = objVMware.GetErrorDescription(objVMware.LastError);
                else
                    strValue = objVMware.TranslatePerfData(objCounter.m_nCounter, nValue);
            
                objItem.SubItems[2].Text = strValue;
            }
        }

        private void ShowCounters ()
        {
            foreach (VMwareCounter objCounter in lstCounters )
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
            lstCounters.Add(new VMwareCounter(objConstants.nwVMWARE_CPU_USAGE, "CPU Usage Overall'(%)", ""));
            lstCounters.Add(new VMwareCounter(objConstants.nwVMWARE_CPU_USAGE, "CPU Usage CPU#0 (%)", "0"));
            lstCounters.Add(new VMwareCounter(objConstants.nwVMWARE_CPU_USAGE, "CPU Usage CPU#1 (%)", "1"));
            lstCounters.Add(new VMwareCounter(objConstants.nwVMWARE_MEMORY_USAGE, "Memory Usage (%)", ""));
            lstCounters.Add(new VMwareCounter(objConstants.nwVMWARE_MEMORY_USED, "Memory Used", ""));
            lstCounters.Add(new VMwareCounter(objConstants.nwVMWARE_MEMORY_AVAILABLE, "Memory Available", ""));
            lstCounters.Add(new VMwareCounter(objConstants.nwVMWARE_POWER_STATE, "Power State", ""));
            lstCounters.Add(new VMwareCounter(objConstants.nwVMWARE_MACHINE_STATE, "Machine State", "" ));
            lstCounters.Add(new VMwareCounter(objConstants.nwVMWARE_GUESTTOOLS, "Guest Tools", "" ));
            lstCounters.Add(new VMwareCounter(objConstants.nwVMWARE_DISK_USAGE, "Disk Usage (%)", "0"));
            lstCounters.Add(new VMwareCounter(objConstants.nwVMWARE_DISK_USED, "Disk Used (MB)", "0"));
            lstCounters.Add(new VMwareCounter(objConstants.nwVMWARE_DISK_AVAILABLE, "Disk Available (MB)", "0"));
        }
        
        private void LoadVirtualMachines()
        {
            string strHost = string.Empty;
            string strSystem = string.Empty;

            comboVMs.Items.Clear();
            lstVMs.Clear();

            strHost = objVMware.GetFirstVirtualMachine();            

            while (objVMware.LastError == 0)
            {
                lstVMs.Add(strHost);
                strSystem = objVMware.GetOperatingSystem(strHost);

                if (strSystem.Length != 0L)
                {
                    strHost = string.Format("{0} - {1}", strHost, strSystem);
                }

                comboVMs.Items.Add(strHost);

                strHost = objVMware.GetNextVirtualMachine();
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
