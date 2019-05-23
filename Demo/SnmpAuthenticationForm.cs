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
    public partial class SnmpAuthenticationForm : Form
    {
        private NwConstants objConstants;
        private string strAuthUsername, strAuthPassword;
        private int nAuthProtocol, nPrivacyProtocol;
        private string strPrivacyPassword;        
        private string strContextName, strEngineID;

        public string AuthUsername
        {
            get { return strAuthUsername; }
        }
        public string AuthPassword
        {
            get { return strAuthPassword; }
        }
        public int AuthProtocol
        {
            get { return nAuthProtocol; }
        }

        public string PrivacyPassword
        {
            get { return strPrivacyPassword; }
        }
        public int PrivacyProtocol
        {
            get { return nPrivacyProtocol; }
        }
        public string ContextName
        {
            get { return strContextName; }
        }

        public string EngineID
        {
            get { return strEngineID; }
        }

        public SnmpAuthenticationForm()
        {
            InitializeComponent();
            objConstants = new NwConstants();
            cbxPrivacyProtocol.SelectedIndex = 0;          
            cbxAuthProtocol.SelectedIndex = 0;

            updateComboBoxToProtocol();
        }

        private void updateProtocolToComboBox()
        {
            if (nAuthProtocol == objConstants.nwSNMP_AUTH_SHA1)
            {
                cbxAuthProtocol.SelectedIndex = 0;
            }
            else if (nAuthProtocol == objConstants.nwSNMP_AUTH_MD5)
            {
                cbxAuthProtocol.SelectedIndex = 1;
            }

            if (nPrivacyProtocol == objConstants.nwSNMP_PRIV_DES)
            {
                cbxPrivacyProtocol.SelectedIndex = 0;
            }
            else if (nPrivacyProtocol == objConstants.nwSNMP_PRIV_AES)
            {
                cbxPrivacyProtocol.SelectedIndex = 1;
            }
        }

        private void updateComboBoxToProtocol()
        {
            switch (cbxPrivacyProtocol.Text)
            {
                case "DES":
                    nPrivacyProtocol = objConstants.nwSNMP_PRIV_DES;
                    break;
                case "AES":
                    nPrivacyProtocol = objConstants.nwSNMP_PRIV_AES;
                    break;
            }

            switch (cbxAuthProtocol.Text)
            {
                case "SHA1":
                    nAuthProtocol = objConstants.nwSNMP_AUTH_SHA1;
                    break;
                case "MD5":
                    nAuthProtocol = objConstants.nwSNMP_AUTH_MD5;
                    break;
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            strAuthUsername = txtAuthUsername.Text;
            strAuthPassword = txtAuthPassword.Text;
            updateComboBoxToProtocol();

            strPrivacyPassword = txtPrivacyPassword.Text;
            strContextName = txtContextName.Text;
            strEngineID = txtEngineID.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtAuthUsername.Text = strAuthUsername;
            txtAuthPassword.Text = strAuthPassword;

            updateProtocolToComboBox();

            txtPrivacyPassword.Text = strPrivacyPassword;
  
            txtContextName.Text = strContextName;
            txtEngineID.Text = strEngineID;
            DialogResult = DialogResult.Cancel;
            this.Close();
        }        
    }
}
