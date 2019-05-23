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
    public partial class SnmpMIBForm : Form
    {
        private SnmpMibBrowser objSnmpMIB = new SnmpMibBrowser(); 
        private NwConstants objConstants = new NwConstants();
        private bool bMibsLoaded = false;


        public SnmpMIBForm()
        {
            InitializeComponent();
        }

        private void SnmpMIBForm_Load(object sender, EventArgs e)
        {
            ClearTree();
            ClearFields();
            objSnmpMIB.Clear();

            ctlLogFile.Text = System.IO.Path.GetTempPath() + "SnmpMIB.log";

            EnableControls();
        }

        private void ctlAddMibFile_Click(object sender, EventArgs e)
        {
            ClearTree();
            ClearFields();

            objSnmpMIB.LogFile = ctlLogFile.Text;
            objSnmpMIB.AddMibFile(ctlFile.Text);

            if (GetResult() != 0L)
            {
                return;
            }

            bMibsLoaded = true;
            BuildMIBTree();
            EnableControls();
        }

        private void ctlUnloadMibFiles_Click(object sender, EventArgs e)
        {
            if (!bMibsLoaded)
                return;

            ClearTree();
            ClearFields();
            objSnmpMIB.Clear();

            bMibsLoaded = false;
            EnableControls();
        }

        private void ctlBrowseFile_Click(object sender, EventArgs e)
        {
            if (bMibsLoaded)
                return;

            System.Windows.Forms.OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Open";
            fdlg.InitialDirectory = "c:\\";
            fdlg.Filter = "All MIB Files|*.mib";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() != DialogResult.OK)
                return;
            ctlFile.Text = fdlg.FileName;

            ctlAddMibFile_Click(null, e);
        }

        private void ctlView_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(ctlLogFile.Text.ToString()))
            {
                System.Diagnostics.Process.Start(ctlLogFile.Text);
            }
        }

        private void ctlMIB_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SnmpObject objSnmp;

            ClearFields();

            if ((objSnmp = (SnmpObject)objSnmpMIB.Get(e.Node.Tag.ToString())) == null)
                return;

            ctlOID.Text = objSnmp.OID.ToString();
            ctlOIDName.Text = objSnmp.OIDName.ToString();
            ctlDescription.Text = objSnmp.Description.ToString().Replace("\n", "\r\n");
            ctlSyntax.Text = objSnmp.Syntax.ToString();

            if (objSnmp.Access == objConstants.nwMIB_ACCESS_NOACCESS)
                ctlAccess.Text = "NOACCESS";
            else if (objSnmp.Access == objConstants.nwMIB_ACCESS_NOTIFY)
                ctlAccess.Text = "NOTIFY";
            else if (objSnmp.Access == objConstants.nwMIB_ACCESS_READONLY)
                ctlAccess.Text = "READONLY";
            else if (objSnmp.Access == objConstants.nwMIB_ACCESS_WRITEONLY)
                ctlAccess.Text = "WRITEONLY";
            else if (objSnmp.Access == objConstants.nwMIB_ACCESS_READWRITE)
                ctlAccess.Text = "READWRITE";
            else if (objSnmp.Access == objConstants.nwMIB_ACCESS_READCREATE)
                ctlAccess.Text = "READCREATE";
            else
                ctlAccess.Text = "n/a";

            if (objSnmp.Status == objConstants.nwMIB_STATUS_CURRENT)
                ctlStatus.Text = "CURRENT";
            else if (objSnmp.Status == objConstants.nwMIB_STATUS_DEPRECATED)
                ctlStatus.Text = "DEPRECATED";
            else if (objSnmp.Status == objConstants.nwMIB_STATUS_OBSOLETE)
                ctlStatus.Text = "OBSOLETE";
            else if (objSnmp.Status == objConstants.nwMIB_STATUS_MANDATORY)
                ctlStatus.Text = "MANDATORY";
            else
                ctlStatus.Text = "n/a";
        }

        private void BuildMIBTree()
        {
            SnmpObject objSnmp;
            TreeNode t1, troot;
            string strParent;
            char[] strTrim1 = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] strTrim2 = { '.' };


            // Start with "iso"
            objSnmp = (SnmpObject)objSnmpMIB.Get("iso.org.dod.internet");

            while (objSnmpMIB.LastError == 0)
            {
                t1 = new TreeNode(objSnmp.OIDNameShort);
                t1.Tag = objSnmp.OID;

                strParent = objSnmp.OID.TrimEnd(strTrim1).TrimEnd(strTrim2);
                troot = FindNodeByValue(ctlMIB.Nodes, strParent);

                t1.ForeColor = objSnmp.IsUserMib ? Color.DarkBlue : Color.Black;
                
                if ((troot = FindNodeByValue(ctlMIB.Nodes, strParent)) != null)
                        troot.Nodes.Add(t1);
                else
                    ctlMIB.Nodes.Add(t1);

                objSnmp = (SnmpObject)objSnmpMIB.GetNext();
            }

            ctlMIB.ExpandAll();

            ctlMIB.HideSelection = false;
            ctlMIB.SelectedNode = ctlMIB.Nodes[0];
        }

        private TreeNode FindNodeByValue(TreeNodeCollection tRoot, string strOid)
        {
            int i;
            string strTag;
            TreeNode t;

            if (tRoot == null)
                return null;

            for (i = 0; i < tRoot.Count; i++)
            {
                strTag = (string)tRoot[i].Tag;
                if (strTag == strOid)
                    return tRoot[i];
                else if ((t = FindNodeByValue(tRoot[i].Nodes, strOid)) != null)
                    return t;
            }

            return null;
        }

        private void ClearTree()
        {
            ctlMIB.Nodes.Clear();
        }

        private void ClearFields()
        {
            ctlOID.Text = string.Empty;
            ctlOIDName.Text = string.Empty;
            ctlDescription.Text = string.Empty;
            ctlSyntax.Text = string.Empty;
            ctlAccess.Text = string.Empty;
            ctlStatus.Text = string.Empty;
        }

        private void EnableControls()
        {
            ctlUnloadMibFiles.Enabled = bMibsLoaded;
            ctlMIB.Enabled = bMibsLoaded;
        }

        private int GetResult()
        {
            ctlResult.Text = objSnmpMIB.LastError.ToString() + ": " + objSnmpMIB.GetErrorDescription(objSnmpMIB.LastError);
            return objSnmpMIB.LastError;
        }


    }
}