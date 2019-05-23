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
    public partial class SnmpForm : Form
    {
        private SnmpManager objSnmpManager = new SnmpManager();
        private NwConstants objConstants = new NwConstants();
        SnmpAuthenticationForm objSnmpAuthenticationForm = new SnmpAuthenticationForm();
        private bool bOpened = false;

        public SnmpForm()
        {
            InitializeComponent();
        }

        private void SnmpForm_Load(object sender, EventArgs e)
        {
            ctlAgent.Text = System.Environment.MachineName;
            ctlLogFile.Text = System.IO.Path.GetTempPath() + "Snmp.log";

            EnableControls();
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
           
            objSnmpManager.ProtocolVersion = ctlVersion.SelectedIndex + 1;
            objSnmpManager.LoadMibFile(ctlMibFile.Text);
            objSnmpManager.LogFile = ctlLogFile.Text;         

            objSnmpManager.Initialize();

            objSnmpManager.Open(ctlAgent.Text, ctlCommunity.Text, Int16.Parse(ctlPort.Text));

            bOpened = GetResult() == 0;

            EnableControls();

            Cursor.Current = Cursors.Default;

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            objSnmpManager.Close();

            GetResult();
            bOpened = false;
            EnableControls();

            Cursor.Current = Cursors.Default;
        }

        private void ctlBrowse_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Open";
            fdlg.InitialDirectory = "c:\\";
            fdlg.Filter = "All MIB Files|*.mib";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() != DialogResult.OK)
                return;
            ctlMibFile.Text = fdlg.FileName;
        }

        private void ctlGet_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            SnmpObject objSnmpObject;

            objSnmpObject = (SnmpObject)objSnmpManager.Get(ctlOID.Text);

            if (GetResult() == 0)
            {
                ctlValue.Text = objSnmpObject.Value;
                ctlOID.Text = objSnmpObject.OID;
                ctlType.Text = GetValueType(objSnmpObject.Type);
            }

            Cursor.Current = Cursors.Default;			
        }

        private void ctlGetNext_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            SnmpObject objSnmpObject;

            objSnmpObject = (SnmpObject)objSnmpManager.GetNext();

            if (GetResult() == 0)
            {
                ctlValue.Text = objSnmpObject.Value;
                ctlOID.Text = objSnmpObject.OID;
                ctlType.Text = GetValueType(objSnmpObject.Type);
            }

            Cursor.Current = Cursors.Default;
        }

        private void ctlSet_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            SnmpObject objSnmpObject = new SnmpObject();

            objSnmpObject.Clear();
            objSnmpObject.Value = ctlNewValue.Text;
            objSnmpObject.OID = ctlOID.Text;
            objSnmpObject.Type = GetTypeAsLong(ctlType.Text);

            object obj = objSnmpObject;

            objSnmpManager.Set(ref obj);

            GetResult();

            Cursor.Current = Cursors.Default;
        }

        private void ctlView_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(ctlLogFile.Text.ToString()))
            {
                System.Diagnostics.Process.Start(ctlLogFile.Text);
            }
        }

        private int GetResult()
        {
            ctlResult.Text = objSnmpManager.LastError + ": " + objSnmpManager.GetErrorDescription(objSnmpManager.LastError);
            return objSnmpManager.LastError;
        }

        private void EnableControls()
        {
            ctlGet.Enabled = bOpened;
            ctlSet.Enabled = bOpened;
            ctlGetNext.Enabled = bOpened;
            ButtonClose.Enabled = bOpened;
            ButtonOpen.Enabled = !bOpened;
            ctlOID.Enabled = bOpened;
            ctlNewValue.Enabled = bOpened;
            ctlMibFile.Enabled = !bOpened;
            ctlBrowse.Enabled = !bOpened;
            ctlAuthentication.Enabled = !bOpened;
            ctlAuthentication.Visible = (ctlVersion.Text == "V3");            
        }

        private string GetValueType(int lType)
        {
            string strType = string.Empty;

            if (lType == objConstants.nwSNMP_TYPE_BITS) strType = "ASN_BITS";
            if (lType == objConstants.nwSNMP_TYPE_COUNTER32) strType = "ASN_COUNTER32";
            if (lType == objConstants.nwSNMP_TYPE_COUNTER64) strType = "ASN_COUNTER64";
            if (lType == objConstants.nwSNMP_TYPE_TIMETICKS) strType = "ASN_TIMETICKS";
            if (lType == objConstants.nwSNMP_TYPE_OCTETSTRING) strType = "ASN_OCTETSTRING";
            if (lType == objConstants.nwSNMP_TYPE_GAUGE32) strType = "ASN_GAUGE32";
            if (lType == objConstants.nwSNMP_TYPE_IPADDRESS) strType = "ASN_IPADDRESS";
            if (lType == objConstants.nwSNMP_TYPE_OPAQUE) strType = "ASN_OPAQUE";
            if (lType == objConstants.nwSNMP_TYPE_UNSIGNED32) strType = "ASN_UNSIGNED32";
            if (lType == objConstants.nwSNMP_TYPE_OBJECTIDENTIFIER) strType = "ASN_OBJECTIDENTIFIER";
            if (lType == objConstants.nwSNMP_TYPE_NULL) strType = "ASN_NULL";
            if (lType == objConstants.nwSNMP_TYPE_INTEGER) strType = "ASN_INTEGER";
            if (lType == objConstants.nwSNMP_TYPE_INTEGER32) strType = "ASN_INTEGER32";
            if (lType == objConstants.nwSNMP_TYPE_SEQUENCE) strType = "ASN_SEQUENCE";

            return strType;
        }

        private int GetTypeAsLong(string strType)
        {
            int lType = 0;

            switch (strType)
            {
                case "ASN_INTEGER": lType = objConstants.nwSNMP_TYPE_INTEGER; break;
                case "ASN_BUTS": lType = objConstants.nwSNMP_TYPE_BITS; break;
                case "ASN_OCTETSTRING": lType = objConstants.nwSNMP_TYPE_OCTETSTRING; break;
                case "ASN_NULL": lType = objConstants.nwSNMP_TYPE_NULL; break;
                case "ASN_OBJECTIDENTIFIER": lType = objConstants.nwSNMP_TYPE_OBJECTIDENTIFIER; break;
                case "ASN_INTEGER32": lType = objConstants.nwSNMP_TYPE_INTEGER32; break;
                case "ASN_SEQUENCE": lType = objConstants.nwSNMP_TYPE_SEQUENCE; break;
                case "ASN_IPADDRESS": lType = objConstants.nwSNMP_TYPE_IPADDRESS; break;
                case "ASN_COUNTER32": lType = objConstants.nwSNMP_TYPE_COUNTER32; break;
                case "ASN_GAUGE32": lType = objConstants.nwSNMP_TYPE_GAUGE32; break;
                case "ASN_TIMETICKS": lType = objConstants.nwSNMP_TYPE_TIMETICKS; break;
                case "ASN_OPAQUE": lType = objConstants.nwSNMP_TYPE_OPAQUE; break;
                case "ASN_COUNTER64": lType = objConstants.nwSNMP_TYPE_COUNTER64; break;
                case "ASN_UNSIGNED32": lType = objConstants.nwSNMP_TYPE_UNSIGNED32; break;
            }

            return lType;
        }

        private void ctlVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableControls();
        }

        private void btnAuthentication_Click(object sender, EventArgs e)
        {
            if (objSnmpAuthenticationForm.ShowDialog() == DialogResult.OK)
            {
                objSnmpManager.AuthPassword = objSnmpAuthenticationForm.AuthPassword;
                objSnmpManager.AuthProtocol = objSnmpAuthenticationForm.AuthProtocol;
                objSnmpManager.AuthUsername = objSnmpAuthenticationForm.AuthUsername;

                objSnmpManager.PrivPassword = objSnmpAuthenticationForm.PrivacyPassword;
                objSnmpManager.PrivProtocol = objSnmpAuthenticationForm.PrivacyProtocol;

                objSnmpManager.ContextName = objSnmpManager.ContextName;
            }
        }
    }
}