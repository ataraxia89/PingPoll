using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPoll
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer timer;
        private System.Net.NetworkInformation.Ping ping;
        private System.Net.NetworkInformation.PingReply reply;
        private string currentIP;

        public Form1()
        {
            InitializeComponent();

            ping = new System.Net.NetworkInformation.Ping();

            timer = new System.Timers.Timer(500);
            timer.Elapsed += Timer_Elapsed;

            lblCurrentIP.Text = "";
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            timer.Enabled = false;

            if (txtPingURL.Text.Contains("http://"))
                txtPingURL.Text = txtPingURL.Text.Replace("http://", "");

            try
            {
                reply = ping.Send(txtPingURL.Text);

                if (reply.Status != System.Net.NetworkInformation.IPStatus.Success)
                    AddEventLog(dgvEvents, "Offline");
                else
                    AddEventLog(dgvEvents, "Online");
            }
            catch (Exception ex)
            {
                AddEventLog(dgvEvents, $"Error attempting ping: {ex.Message}");
            }

            try
            {
                WebRequest req = WebRequest.Create("http://checkip.dyndns.org");
                WebResponse resp = req.GetResponse();
                System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
                string newIP = sr.ReadToEnd().Trim().Split(':')[1].Substring(1).Split('<')[0];

                UpdateCurrentIP(lblCurrentIP, newIP);

                if (currentIP == null)
                {
                    AddEventLog(dgvEvents, $"IP address set as {newIP}");
                    currentIP = newIP;
                }
                else if (newIP != currentIP)
                {
                    AddEventLog(dgvEvents, $"IP address changed from {currentIP} to {newIP}");
                    currentIP = newIP;
                }
            }
            catch (Exception ex)
            {
                AddEventLog(dgvEvents, $"Error attempting IP check: {ex.Message}");
            }

            timer.Enabled = true;
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Enabled = false;
                btnStartStop.Text = "Start";
                btnStartStop.BackColor = Color.Green;
                txtPingURL.Enabled = true;
            }
            else
            {
                btnStartStop.Text = "Stop";
                btnStartStop.BackColor = Color.Red;
                txtPingURL.Enabled = false;
                timer.Enabled = true;
            }
        }

        private delegate void AddEventLogDelegate(DataGridView dgv, string eventDetails);

        private void AddEventLog(DataGridView dgv, string eventDetails)
        {
            if (dgv.InvokeRequired)
                dgv.Invoke(new AddEventLogDelegate(AddEventLog), dgv, eventDetails);
            else
            {
                dgv.Rows.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), eventDetails);

                dgv.ClearSelection();
                dgv.Rows[dgv.Rows.Count - 1].Selected = true;
                dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - 1;
            }
        }

        private delegate void UpdateCurrentIPDelegate(Label lbl, string newIP);

        private void UpdateCurrentIP(Label lbl, string newIP)
        {
            if (lbl.InvokeRequired)
                lbl.Invoke(new UpdateCurrentIPDelegate(UpdateCurrentIP), lbl, newIP);
            else
                lbl.Text = newIP;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvEvents.Rows.Clear();
        }
    }
}
