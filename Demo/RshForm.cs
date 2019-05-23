using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Demo
{
    public partial class RshForm : Form
    {
        private AxNetwork.RSh objRsh = new AxNetwork.RSh();

        public RshForm()
        {
            InitializeComponent();
        }

        private void RshForm_Load(object sender, EventArgs e)
        {
            objRsh.Clear();
            ctlLogFile.Text = System.IO.Path.GetTempPath() + "Rsh.log";
        }

        private void ctlRun_Click(object sender, EventArgs e)
        {
            objRsh.Clear();
            objRsh.Command = ctlCommand.Text;
            objRsh.Host = ctlHost.Text;
            objRsh.UserName = ctlUser.Text;
            objRsh.ScriptTimeOut = Int32.Parse(ctlTimeout.Text);
            objRsh.LogFile = ctlLogFile.Text;

            Cursor.Current = Cursors.WaitCursor;

            objRsh.Run();

            Cursor.Current = Cursors.Default;

            ctlResult.Text = objRsh.LastError.ToString() + ": " + objRsh.GetErrorDescription(objRsh.LastError);

            ctlStdOut.Text = objRsh.StdOut.Replace("\n", "\r\n");
            ctlStdErr.Text = objRsh.StdErr.Replace("\n", "\r\n");

        }

        private void ctlView_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(ctlLogFile.Text.ToString()))
            {
                System.Diagnostics.Process.Start(ctlLogFile.Text);
            }
        }
    }
}