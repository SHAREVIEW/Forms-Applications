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
    public partial class SnmpTrapForm : Form
    {
        private SnmpTrapManager objSnmpTrapManagerI = new SnmpTrapManager();
        private SnmpTrapManager objSnmpTrapManagerO = new SnmpTrapManager();
        private NwConstants objConstants = new NwConstants();
        private SnmpAuthenticationForm objSnmpAuthenticationForm = new SnmpAuthenticationForm();
        private bool bListening = false;
        private SnmpTrapFormAdvanced objAdvancedForm = new SnmpTrapFormAdvanced();

        public SnmpTrapForm()
        {
            InitializeComponent();
        }

        private void SnmpTrapForm_Load(object sender, EventArgs e)
        {
            ctlAgent.Text = System.Environment.MachineName;

            objSnmpTrapManagerI.Initialize();
            objSnmpTrapManagerI.Clear();

            objSnmpTrapManagerO.Initialize();
            objSnmpTrapManagerO.Clear();

            ctlVersion.Items.Clear();
            ctlVersion.Items.Add("v1");
            ctlVersion.Items.Add("v2c");
            ctlVersion.Items.Add("v3");
            ctlVersion.SelectedIndex = 1;

            ctlType.Items.Clear();
            ctlType.Items.Add("ASN_INTEGER");
            ctlType.Items.Add("ASN_BITS");
            ctlType.Items.Add("ASN_OCTETSTRING");
            ctlType.Items.Add("ASN_NULL");
            ctlType.Items.Add("ASN_OBJECTIDENTIFIER");
            ctlType.Items.Add("ASN_INTEGER32");
            ctlType.Items.Add("ASN_SEQUENCE");
            ctlType.Items.Add("ASN_IPADDRESS");
            ctlType.Items.Add("ASN_COUNTER32");
            ctlType.Items.Add("ASN_GAUGE32");
            ctlType.Items.Add("ASN_TIMETICKS");
            ctlType.Items.Add("ASN_OPAQUE");
            ctlType.Items.Add("ASN_COUNTER64");
            ctlType.Items.Add("ASN_UNSIGNED32");
            ctlType.SelectedIndex = 2;

            ctlGenericV1Trap.Items.Clear();
            ctlGenericV1Trap.Items.Add("Cold Start");
            ctlGenericV1Trap.Items.Add("Warm Start");
            ctlGenericV1Trap.Items.Add("Link Down");
            ctlGenericV1Trap.Items.Add("Link Up");
            ctlGenericV1Trap.Items.Add("Authentication Failure");
            ctlGenericV1Trap.Items.Add("egpNeighborLoss");
            ctlGenericV1Trap.Items.Add("Enterprise Specific");
            ctlGenericV1Trap.Items.Add(string.Empty);
            ctlGenericV1Trap.SelectedIndex = 0;

            bListening = false;

            ctlLogFile.Text = System.IO.Path.GetTempPath() + "SnmpTrap.log";

            EnableControls();
        }

        private void ctlSend_Click(object sender, EventArgs e)
        {
            SnmpTrap objSnmpTrap = new SnmpTrap();
            SnmpObject objSnmpObject = new SnmpObject();

            Cursor.Current = Cursors.WaitCursor;

            objSnmpObject.OID = ctlOID.Text;
            objSnmpObject.Type = GetTypeAsLong(ctlType.Text);
            objSnmpObject.Value = ctlValue.Text;

            object obj = objSnmpObject;

            objSnmpTrap.Host = ctlAgent.Text;
            objSnmpTrap.Port = objAdvancedForm.numPort;
            objSnmpTrap.Community = ctlCommunity.Text;
            objSnmpTrap.AddObject(ref obj);

            if (ctlVersion.Text == "v1")
            {
                objSnmpTrap.GenericTrap = ctlGenericV1Trap.SelectedIndex;
                objSnmpTrap.SpecificTrap = Int32.Parse(ctlSpecificV1Value.Text);
            }
            objSnmpTrap.Enterprise = ctlEnterpriseOID.Text;

            obj = objSnmpTrap;

            objSnmpTrapManagerO.LogFile = ctlLogFile.Text;
            if (objAdvancedForm.strMibFile != string.Empty)
                objSnmpTrapManagerO.LoadMibFile(objAdvancedForm.strMibFile);
            objSnmpTrapManagerO.ProtocolVersion = ctlVersion.SelectedIndex + 1;
            objSnmpTrapManagerO.Send(ref obj);

            Cursor.Current = Cursors.Default;

            ShowResultO();
        }

        private void ctlStartListening_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

              objSnmpTrapManagerI.LogFile = ctlLogFile.Text;
            if (objAdvancedForm.strMibFile != string.Empty)
                objSnmpTrapManagerI.LoadMibFile(objAdvancedForm.strMibFile);
            objSnmpTrapManagerI.StartListening(ctlCommunityIn.Text, objAdvancedForm.numPort);

            if (ShowResultI() == 0)
            {
                timer.Enabled = true;
                bListening = true;
                EnableControls();
            }

            Cursor.Current = Cursors.Default;
        }

        private void ctlStopListening_Click(object sender, EventArgs e)
        {
			Cursor.Current = Cursors.WaitCursor;
			
			objSnmpTrapManagerI.StopListening();
        
			if (ShowResultI() == 0)
			{
				timer.Enabled = false;
				bListening = false;
				EnableControls();
			}

			Cursor.Current = Cursors.Default;
        }

        private void ctlClearList_Click(object sender, EventArgs e)
        {
            ctlReceivedTraps.Items.Clear();
        }

        private void ctlView_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(ctlLogFile.Text.ToString()))
            {
                System.Diagnostics.Process.Start(ctlLogFile.Text);
            }
        }

        private void ctlAdvanced_Click(object sender, EventArgs e)
        {
            objAdvancedForm.ShowDialog();
        }

        private void ctlVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableControls();
        }

        private void ctlGenericV1Trap_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableControls();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            SnmpTrap objSnmpTrap;
            SnmpObject objSnmpObject;

            objSnmpTrap = (SnmpTrap)objSnmpTrapManagerI.GetFirstTrap();

            while (ShowResultI() == 0)
            {
                objSnmpObject = (SnmpObject)objSnmpTrap.GetFirstObject();

                while (objSnmpTrap.LastError == 0)
                {
                    ListViewItem objItem;

                    objItem = ctlReceivedTraps.Items.Add(objSnmpTrap.Host);              // Add data to list control

                    objItem.SubItems.Add(objSnmpObject.OID);
                    objItem.SubItems.Add(GetTypeString(objSnmpObject.Type));
                    objItem.SubItems.Add(objSnmpObject.Value);

                    objSnmpObject = (SnmpObject)objSnmpTrap.GetNextObject();
                }

                objSnmpTrap = (SnmpTrap)objSnmpTrapManagerI.GetNextTrap();
            }                  
        }

        private void EnableControls()
        {
            ctlStartListening.Enabled = !bListening;
            ctlStopListening.Enabled = bListening;

            btnAuthentication.Visible = ctlVersion.Text == "v3";

            if (ctlVersion.Text != "v1")
            {
                ctlLabelGenericV1Trap.Hide();
                ctlGenericV1Trap.Hide();
                ctlLabelSpecificV1Value.Hide();
                ctlSpecificV1Value.Hide();
            }   
            else if (ctlVersion.Text == "v1") 
            {
                ctlLabelGenericV1Trap.Show();
                ctlGenericV1Trap.Show();
                if (ctlGenericV1Trap.Text == "Enterprise Specific")
                {
                    ctlLabelSpecificV1Value.Show();
                    ctlSpecificV1Value.Show();
                }
                else
                {
                    ctlLabelSpecificV1Value.Hide();
                    ctlSpecificV1Value.Hide();
                }
            }
        }

        string GetTypeString(int lType)
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

        int GetTypeAsLong(string strType)
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

        private long ShowResultO()
        {
            ctlResult.Text = objSnmpTrapManagerO.LastError + ": " + objSnmpTrapManagerO.GetErrorDescription(objSnmpTrapManagerO.LastError);

            if (objSnmpTrapManagerO.LastError == 22240) // For an explanation of result code 22240, see: https://www.activexperts.com/support/errorcodes
            {
                ctlResult.Text = "0: Success";
            }

            return objSnmpTrapManagerO.LastError;
        }

        private long ShowResultI()
        {
            ctlResult.Text = objSnmpTrapManagerI.LastError + ": " + objSnmpTrapManagerI.GetErrorDescription(objSnmpTrapManagerI.LastError);

            if (objSnmpTrapManagerI.LastError == 22240) // For an explanation of result code 22240, see: https://www.activexperts.com/support/errorcodes
            {
                ctlResult.Text = "0: Success";
            }

            return objSnmpTrapManagerI.LastError;
        }

        private void btnAuthentication_Click(object sender, EventArgs e)
        {
            if (objSnmpAuthenticationForm.ShowDialog() == DialogResult.OK)
            {
                objSnmpTrapManagerI.AuthPassword = objSnmpAuthenticationForm.AuthPassword;
                objSnmpTrapManagerI.AuthProtocol = objSnmpAuthenticationForm.AuthProtocol;
                objSnmpTrapManagerI.AuthUsername = objSnmpAuthenticationForm.AuthUsername;

                objSnmpTrapManagerI.PrivPassword = objSnmpAuthenticationForm.PrivacyPassword;
                objSnmpTrapManagerI.PrivProtocol = objSnmpAuthenticationForm.PrivacyProtocol;

                objSnmpTrapManagerI.ContextName = objSnmpTrapManagerI.ContextName;
                objSnmpTrapManagerI.EngineId = objSnmpTrapManagerI.EngineId;

                objSnmpTrapManagerO.AuthPassword = objSnmpAuthenticationForm.AuthPassword;
                objSnmpTrapManagerO.AuthProtocol = objSnmpAuthenticationForm.AuthProtocol;
                objSnmpTrapManagerO.AuthUsername = objSnmpAuthenticationForm.AuthUsername;

                objSnmpTrapManagerO.PrivPassword = objSnmpAuthenticationForm.PrivacyPassword;
                objSnmpTrapManagerO.PrivProtocol = objSnmpAuthenticationForm.PrivacyProtocol;

                objSnmpTrapManagerO.ContextName = objSnmpTrapManagerI.ContextName;
                objSnmpTrapManagerO.EngineId = objSnmpTrapManagerI.EngineId;
            }
        }
    }
}