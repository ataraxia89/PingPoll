using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace PingPoll
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer pingTimer;
        private System.Timers.Timer ipTimer;
        private System.Net.NetworkInformation.Ping ping;
        private bool pingSuccess;
        private string currentIP;
        private int interval;
        private DateTime requestTime;
        private DateTime responseTime;
        private TimeSpan pingTimeSpan;
        private string responseTimeString;
        private DateTime? offlineTimestamp;
        private DateTime onlineTimestamp;

        public Form1()
        {
            InitializeComponent();

            ping = new System.Net.NetworkInformation.Ping();

            interval = 500;

            pingTimer = new System.Timers.Timer(interval);
            pingTimer.Elapsed += pingTimer_Elapsed;

            ipTimer = new System.Timers.Timer(interval);
            ipTimer.Elapsed += ipTimer_Elapsed;

            lblCurrentIP.Text = "";
        }

        private void pingTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            pingTimer.Enabled = false;

            if (txtPingURL.Text.Contains("http://"))
                txtPingURL.Text = txtPingURL.Text.Replace("http://", "");

            try
            {
                requestTime = DateTime.Now;
                pingSuccess = false;
                try { pingSuccess = ping.Send(txtPingURL.Text).Status == System.Net.NetworkInformation.IPStatus.Success; }
                catch { }

                responseTime = DateTime.Now;

                pingTimeSpan = responseTime - requestTime;

                if (pingTimeSpan.TotalSeconds > 60)
                    responseTimeString = $"response received in {pingTimeSpan.Minutes} minute{(pingTimeSpan.Minutes != 1 ? "s" : "")} {pingTimeSpan.Seconds} second{(pingTimeSpan.Seconds != 1 ? "s" : "")}";
                else if (pingTimeSpan.TotalMilliseconds > 1000)
                    responseTimeString = $"response received in {pingTimeSpan.Seconds} second{(pingTimeSpan.Seconds != 1 ? "s" : "")}";
                else
                    responseTimeString = $"response received in {pingTimeSpan.Milliseconds} milliseconds";

                if (!pingSuccess)
                {
                    if (offlineTimestamp == null)
                        offlineTimestamp = DateTime.Now;

                    AddEventLog(dgvEvents, "Offline");
                }
                else
                {
                    if (offlineTimestamp != null)
                    {
                        onlineTimestamp = DateTime.Now;
                        AddOfflineLog(dgvOffline, (DateTime)offlineTimestamp, onlineTimestamp);
                        offlineTimestamp = null;
                    }

                    AddEventLog(dgvEvents, $"Online ({responseTimeString})");
                }
            }
            catch (Exception ex)
            {
                AddEventLog(dgvEvents, $"Error attempting ping: {ex.Message}");
            }

            pingTimer.Enabled = true;
        }

        private void ipTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            ipTimer.Enabled = false;

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

            ipTimer.Enabled = true;
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPingInterval.Text, out interval))
            {
                pingTimer.Interval = interval;
                ipTimer.Interval = interval;
            }

            if (pingTimer.Enabled || ipTimer.Enabled)
            {
                pingTimer.Enabled = false;
                ipTimer.Enabled = false;
                btnStartStop.Text = "Start";
                btnStartStop.BackColor = Color.Green;
                txtPingInterval.Enabled = true;
                txtPingURL.Enabled = true;
            }
            else
            {
                btnStartStop.Text = "Stop";
                btnStartStop.BackColor = Color.Red;
                txtPingInterval.Enabled = false;
                txtPingURL.Enabled = false;
                pingTimer.Enabled = true;
                ipTimer.Enabled = true;
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
                Update();
            }
        }

        private delegate void AddOfflineLogDelegate(DataGridView dgv, DateTime timeOffline, DateTime timeOnline);

        private void AddOfflineLog(DataGridView dgv, DateTime timeOffline, DateTime timeOnline)
        {
            if (dgv.InvokeRequired)
                dgv.Invoke(new AddOfflineLogDelegate(AddOfflineLog), dgv, timeOffline, timeOnline);
            else
            {
                TimeSpan duration = timeOnline - timeOffline;
                dgv.Rows.Add(timeOffline.ToString("yyyy-MM-dd HH:mm:ss.fff"), timeOnline.ToString("yyyy-MM-dd HH:mm:ss.fff"), $"{(duration.Hours > 0 ? duration.TotalHours : 0).ToString("00")}:{duration.Minutes.ToString("00")}:{duration.Seconds.ToString("00")}.{duration.Milliseconds.ToString("000")}");

                dgv.ClearSelection();
                dgv.Rows[dgv.Rows.Count - 1].Selected = true;
                dgv.FirstDisplayedScrollingRowIndex = dgv.Rows.Count - 1;
                Update();
            }
        }

        private delegate void UpdateCurrentIPDelegate(Label lbl, string newIP);

        private void UpdateCurrentIP(Label lbl, string newIP)
        {
            if (lbl.InvokeRequired)
                lbl.Invoke(new UpdateCurrentIPDelegate(UpdateCurrentIP), lbl, newIP);
            else
            {
                lbl.Text = newIP;
                Update();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvEvents.Rows.Clear();
            dgvOffline.Rows.Clear();
        }
    }
}
