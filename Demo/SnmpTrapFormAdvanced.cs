using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Demo
{
    public partial class SnmpTrapFormAdvanced : Form
    {
        public string strMibFile = string.Empty;
        public System.Int32 numPort = 162;

        public SnmpTrapFormAdvanced()
        {
            InitializeComponent();
        }

        private void SnmpTrapFormAdvanced_Load(object sender, EventArgs e)
        {
            ctlMibFile.Text = strMibFile;
            ctlPort.Text = numPort.ToString();
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            strMibFile = ctlMibFile.Text;
            numPort = Int32.Parse(ctlPort.Text);

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}