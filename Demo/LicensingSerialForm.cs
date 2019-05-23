using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Demo
{
    public partial class LicensingSerialForm : Form
    {
        public string strSerialKey = string.Empty;

        public LicensingSerialForm()
        {
            InitializeComponent();
        }

        private void LicensingSerialForm_Load(object sender, EventArgs e)
        {
            ctlSerialKey.Text = strSerialKey;
        }

        private void ctlOK_Click(object sender, EventArgs e)
        {
            strSerialKey = ctlSerialKey.Text;
            DialogResult = DialogResult.OK;
            this.Close();		
        }

        private void ctlCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();		
        }
    }
}