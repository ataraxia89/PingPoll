namespace PingPoll
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartStop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.txtPingIPURL = new System.Windows.Forms.TextBox();
            this.lblPingIPURL = new System.Windows.Forms.Label();
            this.lblCurrentIPTitle = new System.Windows.Forms.Label();
            this.lblCurrentIP = new System.Windows.Forms.Label();
            this.lblPingInterval = new System.Windows.Forms.Label();
            this.txtPingInterval = new System.Windows.Forms.TextBox();
            this.dgvOffline = new System.Windows.Forms.DataGridView();
            this.Offline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Online = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkLiveScrolling = new System.Windows.Forms.CheckBox();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportEvents = new System.Windows.Forms.Button();
            this.btnExportDowntime = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffline)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartStop
            // 
            this.btnStartStop.BackColor = System.Drawing.Color.Green;
            this.btnStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartStop.ForeColor = System.Drawing.Color.White;
            this.btnStartStop.Location = new System.Drawing.Point(557, 279);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(231, 49);
            this.btnStartStop.TabIndex = 25;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = false;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(392, 472);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(159, 27);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvEvents
            // 
            this.dgvEvents.AllowUserToAddRows = false;
            this.dgvEvents.AllowUserToDeleteRows = false;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.EventType,
            this.EventDetails});
            this.dgvEvents.Location = new System.Drawing.Point(12, 12);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.ReadOnly = true;
            this.dgvEvents.RowHeadersVisible = false;
            this.dgvEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvents.Size = new System.Drawing.Size(539, 243);
            this.dgvEvents.TabIndex = 27;
            this.dgvEvents.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgv_Scroll);
            // 
            // txtPingIPURL
            // 
            this.txtPingIPURL.Location = new System.Drawing.Point(557, 243);
            this.txtPingIPURL.Name = "txtPingIPURL";
            this.txtPingIPURL.Size = new System.Drawing.Size(231, 20);
            this.txtPingIPURL.TabIndex = 28;
            this.txtPingIPURL.Text = "8.8.8.8";
            // 
            // lblPingIPURL
            // 
            this.lblPingIPURL.Location = new System.Drawing.Point(557, 221);
            this.lblPingIPURL.Name = "lblPingIPURL";
            this.lblPingIPURL.Size = new System.Drawing.Size(231, 19);
            this.lblPingIPURL.TabIndex = 30;
            this.lblPingIPURL.Text = "Ping IP/URL:";
            this.lblPingIPURL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrentIPTitle
            // 
            this.lblCurrentIPTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentIPTitle.Location = new System.Drawing.Point(557, 12);
            this.lblCurrentIPTitle.Name = "lblCurrentIPTitle";
            this.lblCurrentIPTitle.Size = new System.Drawing.Size(231, 31);
            this.lblCurrentIPTitle.TabIndex = 31;
            this.lblCurrentIPTitle.Text = "Current IP:";
            this.lblCurrentIPTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentIP
            // 
            this.lblCurrentIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentIP.Location = new System.Drawing.Point(557, 43);
            this.lblCurrentIP.Name = "lblCurrentIP";
            this.lblCurrentIP.Size = new System.Drawing.Size(231, 31);
            this.lblCurrentIP.TabIndex = 32;
            this.lblCurrentIP.Text = "[Current IP]";
            this.lblCurrentIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPingInterval
            // 
            this.lblPingInterval.Location = new System.Drawing.Point(557, 176);
            this.lblPingInterval.Name = "lblPingInterval";
            this.lblPingInterval.Size = new System.Drawing.Size(231, 19);
            this.lblPingInterval.TabIndex = 34;
            this.lblPingInterval.Text = "Ping Interval (ms):";
            this.lblPingInterval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPingInterval
            // 
            this.txtPingInterval.Location = new System.Drawing.Point(557, 198);
            this.txtPingInterval.Name = "txtPingInterval";
            this.txtPingInterval.Size = new System.Drawing.Size(231, 20);
            this.txtPingInterval.TabIndex = 33;
            this.txtPingInterval.Text = "500";
            // 
            // dgvOffline
            // 
            this.dgvOffline.AllowUserToAddRows = false;
            this.dgvOffline.AllowUserToDeleteRows = false;
            this.dgvOffline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOffline.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Offline,
            this.Online,
            this.Duration});
            this.dgvOffline.Location = new System.Drawing.Point(12, 261);
            this.dgvOffline.Name = "dgvOffline";
            this.dgvOffline.ReadOnly = true;
            this.dgvOffline.RowHeadersVisible = false;
            this.dgvOffline.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOffline.Size = new System.Drawing.Size(539, 205);
            this.dgvOffline.TabIndex = 35;
            this.dgvOffline.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgv_Scroll);
            // 
            // Offline
            // 
            this.Offline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Offline.HeaderText = "Offline";
            this.Offline.Name = "Offline";
            this.Offline.ReadOnly = true;
            this.Offline.Width = 62;
            // 
            // Online
            // 
            this.Online.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Online.HeaderText = "Online";
            this.Online.Name = "Online";
            this.Online.ReadOnly = true;
            this.Online.Width = 62;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // chkLiveScrolling
            // 
            this.chkLiveScrolling.AutoSize = true;
            this.chkLiveScrolling.Checked = true;
            this.chkLiveScrolling.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLiveScrolling.Location = new System.Drawing.Point(628, 146);
            this.chkLiveScrolling.Name = "chkLiveScrolling";
            this.chkLiveScrolling.Size = new System.Drawing.Size(89, 17);
            this.chkLiveScrolling.TabIndex = 36;
            this.chkLiveScrolling.Text = "Live Scrolling";
            this.chkLiveScrolling.UseVisualStyleBackColor = true;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 55;
            // 
            // EventType
            // 
            this.EventType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EventType.HeaderText = "Event Type";
            this.EventType.Name = "EventType";
            this.EventType.ReadOnly = true;
            this.EventType.Width = 87;
            // 
            // EventDetails
            // 
            this.EventDetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EventDetails.HeaderText = "Event Details";
            this.EventDetails.Name = "EventDetails";
            this.EventDetails.ReadOnly = true;
            this.EventDetails.Width = 95;
            // 
            // btnExportEvents
            // 
            this.btnExportEvents.Location = new System.Drawing.Point(593, 344);
            this.btnExportEvents.Name = "btnExportEvents";
            this.btnExportEvents.Size = new System.Drawing.Size(159, 27);
            this.btnExportEvents.TabIndex = 37;
            this.btnExportEvents.Text = "Export Events to CSV";
            this.btnExportEvents.UseVisualStyleBackColor = true;
            this.btnExportEvents.Click += new System.EventHandler(this.btnExportEvents_Click);
            // 
            // btnExportDowntime
            // 
            this.btnExportDowntime.Location = new System.Drawing.Point(593, 377);
            this.btnExportDowntime.Name = "btnExportDowntime";
            this.btnExportDowntime.Size = new System.Drawing.Size(159, 27);
            this.btnExportDowntime.TabIndex = 38;
            this.btnExportDowntime.Text = "Export Downtime to CSV";
            this.btnExportDowntime.UseVisualStyleBackColor = true;
            this.btnExportDowntime.Click += new System.EventHandler(this.btnExportDowntime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 508);
            this.Controls.Add(this.btnExportDowntime);
            this.Controls.Add(this.btnExportEvents);
            this.Controls.Add(this.chkLiveScrolling);
            this.Controls.Add(this.dgvOffline);
            this.Controls.Add(this.lblPingInterval);
            this.Controls.Add(this.txtPingInterval);
            this.Controls.Add(this.lblCurrentIP);
            this.Controls.Add(this.lblCurrentIPTitle);
            this.Controls.Add(this.lblPingIPURL);
            this.Controls.Add(this.txtPingIPURL);
            this.Controls.Add(this.dgvEvents);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.btnClear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PingPoll";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffline)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btnStartStop;
        internal System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.TextBox txtPingIPURL;
        private System.Windows.Forms.Label lblPingIPURL;
        private System.Windows.Forms.Label lblCurrentIPTitle;
        private System.Windows.Forms.Label lblCurrentIP;
        private System.Windows.Forms.Label lblPingInterval;
        private System.Windows.Forms.TextBox txtPingInterval;
        private System.Windows.Forms.DataGridView dgvOffline;
        private System.Windows.Forms.DataGridViewTextBoxColumn Offline;
        private System.Windows.Forms.DataGridViewTextBoxColumn Online;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.CheckBox chkLiveScrolling;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventType;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventDetails;
        internal System.Windows.Forms.Button btnExportEvents;
        internal System.Windows.Forms.Button btnExportDowntime;
    }
}

