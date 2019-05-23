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
    public partial class NtpForm : Form
    {
        private AxNetwork.Ntp objNtp = new AxNetwork.Ntp();

        public NtpForm()
        {
            InitializeComponent();
        }

        private void NtpForm_Load(object sender, EventArgs e)
        {
			ctlLogFile.Text = System.IO.Path.GetTempPath() + "Ntp.log"; 
        }

        private void ButtonQuery_Click(object sender, EventArgs e)
        {
			Cursor.Current = Cursors.WaitCursor;

            objNtp.Clear();
			objNtp.LogFile = ctlLogFile.Text;
			objNtp.GetTime(ctlServer.Text);

			Cursor.Current = Cursors.Default;

			if (objNtp.LastError == 0)
			{
				ctlResult.Text = objNtp.Year.ToString ( "0000/" ) +  objNtp.Month.ToString ( "00/" ) + objNtp.Day.ToString ( "00" ) + " " + objNtp.Hour.ToString ( "00:" ) + objNtp.Minute.ToString ( "00:" ) + objNtp.Second.ToString ( "00" ) + " UTC";
			}
			else
			{
				ctlResult.Text = objNtp.LastError + ": " + objNtp.GetErrorDescription(objNtp.LastError);
			}        
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