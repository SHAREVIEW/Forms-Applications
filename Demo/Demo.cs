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
    public partial class Demo : Form
    {
        private ClientServerForm objClientServerForm = new ClientServerForm();
        private HttpForm objHttpForm = new HttpForm();
        private IcmpForm objIcmpForm = new IcmpForm();
        private NtpForm objNtpForm = new NtpForm();
        private SshForm objSshForm = new SshForm();
        private RshForm objRshForm = new RshForm();
        private SnmpForm objSnmpForm = new SnmpForm();
        private SnmpMIBForm objSnmpMIBForm = new SnmpMIBForm();
        private SnmpTrapForm objSnmpTrapForm = new SnmpTrapForm();
        private TelnetForm objTelnetForm = new TelnetForm();
        private WolForm objWolForm = new WolForm();
        private FtpForm objFtpForm = new FtpForm();
        private UdpForm objUdpForm = new UdpForm();
        private HttpPostForm objHttpPostForm = new HttpPostForm();
        private IPtoCountryForm objIPtoCountryForm = new IPtoCountryForm();
        private DnsForm objDnsForm = new DnsForm();
        private SFtpForm objSFtpForm = new SFtpForm();
        private ScpForm objScpForm = new ScpForm();
        private TftpForm objTftpForm = new TftpForm();
        private LicensingForm objLicensingForm = new LicensingForm();
        private Tcp objSocket = new Tcp();
        private VERDEForm objVerdeForm = new VERDEForm();
        private VMwareForm objVmwForm = new VMwareForm();
        private XenForm objXenForm = new XenForm();
        private RadiusForm objRadiusForm = new RadiusForm();
        private TraceRouteForm objTraceRouteForm = new TraceRouteForm();
        
        public Demo()
        {
            InitializeComponent();
        }

        private void Demo_Load(object sender, EventArgs e)
        {
            ctlBuild.Text = string.Format("{0}; Build {1}; Module: {2}", objSocket.Version, objSocket.Build, objSocket.Module);

        }

        private void ctlServerClient_Click(object sender, EventArgs e)
        {
            objClientServerForm.ShowDialog();
        }

        private void ctlTelnet_Click(object sender, EventArgs e)
        {
            objTelnetForm.ShowDialog();
        }

        private void ctlHttp_Click(object sender, EventArgs e)
        {
            objHttpForm.ShowDialog();
        }

        private void ctlHttpPost_Click(object sender, EventArgs e)
        {
            objHttpPostForm.ShowDialog();
        }

        private void ctlIcmp_Click(object sender, EventArgs e)
        {
            objIcmpForm.ShowDialog();
        }

        private void ctlFtp_Click(object sender, EventArgs e)
        {
            objFtpForm.ShowDialog();
        }

        private void ctlSnmp_Click(object sender, EventArgs e)
        {
            objSnmpForm.ShowDialog();
        }

        private void ctlSnmpMibBrowse_Click(object sender, EventArgs e)
        {
            objSnmpMIBForm.ShowDialog();
        }

        private void ctlSnmpTraps_Click(object sender, EventArgs e)
        {
            objSnmpTrapForm.ShowDialog();
        }

        private void ctlDns_Click(object sender, EventArgs e)
        {
            objDnsForm.ShowDialog();
        }

        private void ctlSsh_Click(object sender, EventArgs e)
        {
            objSshForm.ShowDialog();
        }

        private void ctlRsh_Click(object sender, EventArgs e)
        {
            objRshForm.ShowDialog();
        }

        private void ctlIPtoCountry_Click(object sender, EventArgs e)
        {
            objIPtoCountryForm.ShowDialog();
        }

        private void ctlUdp_Click(object sender, EventArgs e)
        {
            objUdpForm.ShowDialog();
        }

        private void ctlWol_Click(object sender, EventArgs e)
        {
            objWolForm.ShowDialog();
        }

        private void ctlNtp_Click(object sender, EventArgs e)
        {
            objNtpForm.ShowDialog();
        }

        private void ctlLicensing_Click(object sender, EventArgs e)
        {
            objLicensingForm.ShowDialog();		
        }

        private void ctlSftp_Click(object sender, EventArgs e)
        {
            objSFtpForm.ShowDialog();
        }

        private void ctlScp_Click(object sender, EventArgs e)
        {
            objScpForm.ShowDialog();
        }

        private void ctlTftp_Click(object sender, EventArgs e)
        {
            objTftpForm.ShowDialog();
        }

        private void ctlVMware_Click(object sender, EventArgs e)
        {
            objVmwForm.ShowDialog();
        }

        private void ctlXen_Click(object sender, EventArgs e)
        {
            objXenForm.ShowDialog();
        }

        private void ctlRadius_Click(object sender, EventArgs e)
        {
            objRadiusForm.ShowDialog();
        }

        private void ctlTraceRoute_Click(object sender, EventArgs e)
        {
            objTraceRouteForm.ShowDialog();
        }

        private void ctlVERDE_Click_1(object sender, EventArgs e)
        {
            objVerdeForm.ShowDialog();
        }
    }
}