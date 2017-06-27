namespace Network_Project
{
    partial class show_alive_hosts
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
            this.grid_alive_hosts = new System.Windows.Forms.DataGridView();
            this.scan_btn = new System.Windows.Forms.Button();
            this.progressLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.instructions_label = new System.Windows.Forms.Label();
            this.instructions_label_1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_alive_hosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_alive_hosts
            // 
            this.grid_alive_hosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_alive_hosts.Location = new System.Drawing.Point(12, 119);
            this.grid_alive_hosts.Name = "grid_alive_hosts";
            this.grid_alive_hosts.Size = new System.Drawing.Size(245, 217);
            this.grid_alive_hosts.TabIndex = 0;
            // 
            // scan_btn
            // 
            this.scan_btn.Location = new System.Drawing.Point(12, 372);
            this.scan_btn.Name = "scan_btn";
            this.scan_btn.Size = new System.Drawing.Size(75, 22);
            this.scan_btn.TabIndex = 1;
            this.scan_btn.Text = "Scan Ports";
            this.scan_btn.UseVisualStyleBackColor = true;
            this.scan_btn.Click += new System.EventHandler(this.scan_btn_Click);
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(74, 63);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(38, 13);
            this.progressLabel.TabIndex = 13;
            this.progressLabel.Text = "Ready";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 63);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 50);
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // instructions_label
            // 
            this.instructions_label.AutoSize = true;
            this.instructions_label.Location = new System.Drawing.Point(7, 9);
            this.instructions_label.Name = "instructions_label";
            this.instructions_label.Size = new System.Drawing.Size(290, 13);
            this.instructions_label.TabIndex = 15;
            this.instructions_label.Text = "Select IP then click the Scan Ports button to perform a port";
            // 
            // instructions_label_1
            // 
            this.instructions_label_1.AutoSize = true;
            this.instructions_label_1.Location = new System.Drawing.Point(7, 31);
            this.instructions_label_1.Name = "instructions_label_1";
            this.instructions_label_1.Size = new System.Drawing.Size(294, 13);
            this.instructions_label_1.TabIndex = 16;
            this.instructions_label_1.Text = "scan to get active ports and what processes are using them";
            // 
            // show_alive_hosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 417);
            this.Controls.Add(this.instructions_label_1);
            this.Controls.Add(this.instructions_label);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.scan_btn);
            this.Controls.Add(this.grid_alive_hosts);
            this.Name = "show_alive_hosts";
            this.Text = "show_alive_hosts";
            this.Load += new System.EventHandler(this.show_alive_hosts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_alive_hosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_alive_hosts;
        private System.Windows.Forms.Button scan_btn;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label instructions_label;
        private System.Windows.Forms.Label instructions_label_1;
    }
}