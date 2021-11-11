using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Windows.Forms;

namespace IpGet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getInfoButton_Click(object sender, EventArgs e)
        {
            loadingIcon.Show();
            getInfoButton.Enabled = false;
            progressBar.Value = 0;
            progressBar.Show();
            SynchronizationContext context = SynchronizationContext.Current;
            Task task = new Task(() => { ShowHostInfoAsync(addressBox.Text, context); });
            task.Start();
        }

        private void addressBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                getInfoButton_Click(this, new EventArgs());
        }

        private void ShowHostInfoAsync(string name, SynchronizationContext context)
        {
            IPHostEntry hostEntry;
            try
            {
                hostEntry = Dns.GetHostEntry(name);
            }
            catch
            {
                context.Post(obj => 
                {
                    ipListBox.DataSource = null;
                    ipListBox.Items.Clear();
                    ipListBox.Items.Add("Unknown host");
                    
                    hostnameListBox.DataSource = null;
                    hostnameListBox.Items.Clear();
                    hostnameListBox.Items.Add("Unknown host");

                    loadingIcon.Hide();
                    getInfoButton.Enabled = true;
                    progressBar.Hide();
                }, default);
                return;
            }

            List<string> ip = new List<string>();
            List<string> hostnames = new List<string>();
            List<IPAddress> raw = new List<IPAddress>(hostEntry.AddressList);
            context.Post(obj =>
            {
                progressBar.Maximum = raw.Count;
            }, default);
            int i = 1;
            foreach (IPAddress addr in raw) 
            {
                ip.Add(addr.ToString());
                try
                {
                    hostnames.Add(Dns.GetHostEntry(addr.ToString()).HostName);
                }
                catch
                {
                    hostnames.Add("Unknown hostname");
                }
                i++;
                context.Post(obj =>
                {
                    if (i < progressBar.Maximum) progressBar.Value = i;
                }, default);
            }
            context.Post(obj => 
            {
                ipListBox.DataSource = ip;
                hostnameListBox.DataSource = hostnames;
                loadingIcon.Hide();
                getInfoButton.Enabled = true;
                progressBar.Hide();
            }, default);
        }
    }
}
