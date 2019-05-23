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
    public partial class DnsForm : Form
    {
        private AxNetwork.DnsServer objDnsServer = new AxNetwork.DnsServer();
        private AxNetwork.NwConstants objConstants = new AxNetwork.NwConstants();

        public DnsForm()
        {
            InitializeComponent();
        }

        private void DnsForm_Load(object sender, EventArgs e)
        {
            objDnsServer.Clear();

            ctlType.Items.Clear();
            ctlType.Items.Add("A Record");
            ctlType.Items.Add("NS Record");
            ctlType.Items.Add("CNAME Record");
            ctlType.Items.Add("SOA Record");
            ctlType.Items.Add("PTR Record");
            ctlType.Items.Add("MX Record");
            ctlType.Items.Add("AAAA Record");
            ctlType.Items.Add("ANY Record");
            ctlType.SelectedIndex = 7;

            ctlLogFile.Text = System.IO.Path.GetTempPath() + "Dns.log";
        }

        private void ctlLookup_Click(object sender, EventArgs e)
        {
            int nType = objConstants.nwDNS_TYPE_ANY;

            switch (ctlType.SelectedIndex)
            {
                case 0: nType = objConstants.nwDNS_TYPE_A; break;
                case 1: nType = objConstants.nwDNS_TYPE_NS; break;
                case 2: nType = objConstants.nwDNS_TYPE_CNAME; break;
                case 3: nType = objConstants.nwDNS_TYPE_SOA; break;
                case 4: nType = objConstants.nwDNS_TYPE_PTR; break;
                case 5: nType = objConstants.nwDNS_TYPE_MX; break;
                case 6: nType = objConstants.nwDNS_TYPE_AAAA; break;
                case 7: nType = objConstants.nwDNS_TYPE_ANY; break;
                default: nType = objConstants.nwDNS_TYPE_ANY; break;
            }

            ctlQueryResults.Text = string.Empty;

            objDnsServer.LogFile = ctlLogFile.Text;
            objDnsServer.Server = ctlServer.Text;
            objDnsServer.Lookup(ctlHost.Text, nType);

            if( GetResult() != 0)
                return;

            {
                DnsRecord objDnsRecord = (DnsRecord)objDnsServer.GetFirstRecord();

                while (GetResult() == 0)
                {
                    if (objDnsRecord.Type == objConstants.nwDNS_TYPE_A)
                    {
                        ctlQueryResults.Text += "Type: A\r\n";
                        ctlQueryResults.Text += "\tName: " + objDnsRecord.Name + "\r\n";
                        ctlQueryResults.Text += "\tAddress: " + objDnsRecord.Address + "\r\n";
                    }

                    if (objDnsRecord.Type == objConstants.nwDNS_TYPE_AAAA)
                    {
                        ctlQueryResults.Text += "Type: AAAA\r\n";
                        ctlQueryResults.Text += "\tName: " + objDnsRecord.Name + "\r\n";
                        ctlQueryResults.Text += "\tAddress: " + objDnsRecord.Address + "\r\n";
                    }

                    if (objDnsRecord.Type == objConstants.nwDNS_TYPE_CNAME)
                    {
                        ctlQueryResults.Text += "Type: CNAME\r\n";
                        ctlQueryResults.Text += "\tName: " + objDnsRecord.Name;
                        ctlQueryResults.Text += "\tAlias: " + objDnsRecord.Address;
                    }

                    if (objDnsRecord.Type == objConstants.nwDNS_TYPE_NS)
                    {
                        ctlQueryResults.Text += "Type: NS\r\n";
                        ctlQueryResults.Text += "\tName: " + objDnsRecord.Name + "\r\n";
                        ctlQueryResults.Text += "\tNameServer: " + objDnsRecord.NameServer + "\r\n";
                    }

                    if (objDnsRecord.Type == objConstants.nwDNS_TYPE_MX)
                    {
                        ctlQueryResults.Text += "Type: MX\r\n";
                        ctlQueryResults.Text += "\tName: " + objDnsRecord.Name;
                        ctlQueryResults.Text += "\tPreference: " + objDnsRecord.Preference;
                        ctlQueryResults.Text += "\tMailExchange: " + objDnsRecord.MailExchange;
                    }

                    if (objDnsRecord.Type == objConstants.nwDNS_TYPE_PTR)
                    {
                        ctlQueryResults.Text += "Type: PTR\r\n";
                        ctlQueryResults.Text += "\tName: " + objDnsRecord.Name;
                        ctlQueryResults.Text += "\tAddress: " + objDnsRecord.Address;
                    }

                    if (objDnsRecord.Type == objConstants.nwDNS_TYPE_SOA)
                    {
                        ctlQueryResults.Text += "Type: SOA\r\n";
                        ctlQueryResults.Text += "\tName: " + objDnsRecord.Name + "\r\n";
                        ctlQueryResults.Text += "\tName Server: " + objDnsRecord.NameServer + "\r\n";
                        ctlQueryResults.Text += "\tMailBox: " + objDnsRecord.MailBox + "\r\n";
                        ctlQueryResults.Text += "\tSerial: " + objDnsRecord.SerialNumber + "\r\n";
                        ctlQueryResults.Text += "\tRefresh: " + objDnsRecord.RefreshInterval + "\r\n";
                        ctlQueryResults.Text += "\tRetry Interval: " + objDnsRecord.RetryInterval + "\r\n";
                        ctlQueryResults.Text += "\tExpiration Limit: " + objDnsRecord.ExpirationLimit + "\r\n";
                        ctlQueryResults.Text += "\tMinimum TTL: " + objDnsRecord.MinimumTTL + "\r\n";
                    }

                    objDnsRecord = (DnsRecord)objDnsServer.GetNextRecord();
                }
            }
        }

        private void ctlView_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(ctlLogFile.Text.ToString()))
            {
                System.Diagnostics.Process.Start(ctlLogFile.Text);
            }
        }

        private long GetResult()
        {
            long lResult = objDnsServer.LastError;

            if (lResult == 22355)   // For an explanation of result code 22355, see: https://www.activexperts.com/support/errorcodes
            {
                ctlResult.Text = "0: Success";
            }
            else
            {
                ctlResult.Text = objDnsServer.LastError.ToString() + ": " + objDnsServer.GetErrorDescription((int)lResult);
            }

            return lResult;
        }
    }
}