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
    public partial class LicensingForm : Form
    {
        private LicensingSerialForm objLicensingSerialForm = new LicensingSerialForm();
        private AxNetwork.Icmp objIcmp = new AxNetwork.Icmp();

        public LicensingForm()
        {
            InitializeComponent();
        }

        private void LicensingForm_Load(object sender, EventArgs e)
        {
            ctlVersion.Text = string.Format("{0}; Build {1}; Module: {2}",objIcmp.Version, objIcmp.Build, objIcmp.Module);
            UpdateLicensingInfo();		
        }

        private void ctlRegister_Click(object sender, EventArgs e)
        {
            objLicensingSerialForm.strSerialKey = objIcmp.LicenseKey;
            if (objLicensingSerialForm.ShowDialog() == DialogResult.OK)
            {
                objIcmp.Activate(objLicensingSerialForm.strSerialKey,true);
                if( objIcmp.LastError == 0 ) 
                    MessageBox.Show( "Activation was successfull.", this.Text, MessageBoxButtons.OK );
                else
                    MessageBox.Show(string.Format("Activation failed, error {0} ({1}).", objIcmp.LastError.ToString(), objIcmp.GetErrorDescription(objIcmp.LastError)), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            UpdateLicensingInfo();
        }

        private void ctlClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctlUrlSupport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.activexperts.com/network-component");
        }

        private void ctlMailSupport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:support@activexperts.com");	
        }

        private void ctlUrlOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.activexperts.com/sales/order#ProductCode=AX001");	
        }

        private void ctlUrlSales_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.activexperts.com/sales");
        }

        private void UpdateLicensingInfo()
        {
            ctlLicenseStatus.Text = objIcmp.LicenseStatus;
            ctlLicenseKey.Text = objIcmp.LicenseKey;
        }

    }
}