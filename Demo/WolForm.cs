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
    public partial class WolForm : Form
    {
        private WOL objWol = new WOL();

        public WolForm()
        {
            InitializeComponent();
        }

        private void WolForm_Load(object sender, EventArgs e)
        {
            objWol.Clear();
            textLogFile.Text = System.IO.Path.GetTempPath() + "WakeOnLan.log";
        }

        private void ctlWake_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            objWol.Clear();
            objWol.LogFile = textLogFile.Text;
            objWol.WakeUp(ctlMAC.Text);

            Cursor.Current = Cursors.Default;

            ctlResult.Text = objWol.LastError.ToString() + ": " + objWol.GetErrorDescription(objWol.LastError);
        }

        private void ctlView_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(textLogFile.Text.ToString()))
            {
                System.Diagnostics.Process.Start(textLogFile.Text);
            }
        }
    }
}