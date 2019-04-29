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
            this.txtPingURL = new System.Windows.Forms.TextBox();
            this.lblPingURL = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCurrentIPTitle = new System.Windows.Forms.Label();
            this.lblCurrentIP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartStop
            // 
            this.btnStartStop.BackColor = System.Drawing.Color.Green;
            this.btnStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartStop.ForeColor = System.Drawing.Color.White;
            this.btnStartStop.Location = new System.Drawing.Point(631, 206);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(231, 49);
            this.btnStartStop.TabIndex = 25;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = false;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(466, 390);
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
            this.EventDetails});
            this.dgvEvents.Location = new System.Drawing.Point(12, 12);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.ReadOnly = true;
            this.dgvEvents.RowHeadersVisible = false;
            this.dgvEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvents.Size = new System.Drawing.Size(613, 372);
            this.dgvEvents.TabIndex = 27;
            // 
            // txtPingURL
            // 
            this.txtPingURL.Location = new System.Drawing.Point(631, 170);
            this.txtPingURL.Name = "txtPingURL";
            this.txtPingURL.Size = new System.Drawing.Size(231, 20);
            this.txtPingURL.TabIndex = 28;
            this.txtPingURL.Text = "www.google.com";
            // 
            // lblPingURL
            // 
            this.lblPingURL.Location = new System.Drawing.Point(631, 148);
            this.lblPingURL.Name = "lblPingURL";
            this.lblPingURL.Size = new System.Drawing.Size(231, 19);
            this.lblPingURL.TabIndex = 30;
            this.lblPingURL.Text = "Ping URL:";
            this.lblPingURL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 55;
            // 
            // EventDetails
            // 
            this.EventDetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EventDetails.HeaderText = "Event Details";
            this.EventDetails.Name = "EventDetails";
            this.EventDetails.ReadOnly = true;
            this.EventDetails.Width = 95;
            // 
            // lblCurrentIPTitle
            // 
            this.lblCurrentIPTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentIPTitle.Location = new System.Drawing.Point(631, 12);
            this.lblCurrentIPTitle.Name = "lblCurrentIPTitle";
            this.lblCurrentIPTitle.Size = new System.Drawing.Size(231, 31);
            this.lblCurrentIPTitle.TabIndex = 31;
            this.lblCurrentIPTitle.Text = "Current IP:";
            this.lblCurrentIPTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentIP
            // 
            this.lblCurrentIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentIP.Location = new System.Drawing.Point(631, 43);
            this.lblCurrentIP.Name = "lblCurrentIP";
            this.lblCurrentIP.Size = new System.Drawing.Size(231, 31);
            this.lblCurrentIP.TabIndex = 32;
            this.lblCurrentIP.Text = "[Current IP]";
            this.lblCurrentIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 433);
            this.Controls.Add(this.lblCurrentIP);
            this.Controls.Add(this.lblCurrentIPTitle);
            this.Controls.Add(this.lblPingURL);
            this.Controls.Add(this.txtPingURL);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btnStartStop;
        internal System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.TextBox txtPingURL;
        private System.Windows.Forms.Label lblPingURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventDetails;
        private System.Windows.Forms.Label lblCurrentIPTitle;
        private System.Windows.Forms.Label lblCurrentIP;
    }
}

