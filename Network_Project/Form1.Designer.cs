namespace Network_Project
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
            this.start_ip_TB = new IPAddressControlLib.IPAddressControl();
            this.end_ip_TB = new IPAddressControlLib.IPAddressControl();
            this.start_ip_label = new System.Windows.Forms.Label();
            this.end_ip_label = new System.Windows.Forms.Label();
            this.start_BTN = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.progressLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // start_ip_TB
            // 
            this.start_ip_TB.AllowInternalTab = false;
            this.start_ip_TB.AutoHeight = true;
            this.start_ip_TB.BackColor = System.Drawing.SystemColors.Window;
            this.start_ip_TB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.start_ip_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.start_ip_TB.Location = new System.Drawing.Point(129, 82);
            this.start_ip_TB.MinimumSize = new System.Drawing.Size(90, 20);
            this.start_ip_TB.Name = "start_ip_TB";
            this.start_ip_TB.ReadOnly = false;
            this.start_ip_TB.Size = new System.Drawing.Size(106, 20);
            this.start_ip_TB.TabIndex = 0;
            this.start_ip_TB.Text = "192.168.201.10";
            // 
            // end_ip_TB
            // 
            this.end_ip_TB.AllowInternalTab = false;
            this.end_ip_TB.AutoHeight = true;
            this.end_ip_TB.BackColor = System.Drawing.SystemColors.Window;
            this.end_ip_TB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.end_ip_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.end_ip_TB.Location = new System.Drawing.Point(129, 122);
            this.end_ip_TB.MinimumSize = new System.Drawing.Size(90, 20);
            this.end_ip_TB.Name = "end_ip_TB";
            this.end_ip_TB.ReadOnly = false;
            this.end_ip_TB.Size = new System.Drawing.Size(106, 20);
            this.end_ip_TB.TabIndex = 2;
            this.end_ip_TB.Text = "192.168.201.15";
            // 
            // start_ip_label
            // 
            this.start_ip_label.AutoSize = true;
            this.start_ip_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_ip_label.Location = new System.Drawing.Point(12, 83);
            this.start_ip_label.Name = "start_ip_label";
            this.start_ip_label.Size = new System.Drawing.Size(62, 19);
            this.start_ip_label.TabIndex = 4;
            this.start_ip_label.Text = "Start IP :";
            // 
            // end_ip_label
            // 
            this.end_ip_label.AutoSize = true;
            this.end_ip_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_ip_label.Location = new System.Drawing.Point(12, 123);
            this.end_ip_label.Name = "end_ip_label";
            this.end_ip_label.Size = new System.Drawing.Size(57, 19);
            this.end_ip_label.TabIndex = 6;
            this.end_ip_label.Text = "End IP :";
            // 
            // start_BTN
            // 
            this.start_BTN.Location = new System.Drawing.Point(160, 192);
            this.start_BTN.Name = "start_BTN";
            this.start_BTN.Size = new System.Drawing.Size(75, 23);
            this.start_BTN.TabIndex = 7;
            this.start_BTN.Text = "Start";
            this.start_BTN.UseVisualStyleBackColor = true;
            this.start_BTN.Click += new System.EventHandler(this.start_BTN_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 30);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 50);
            this.pictureBox.TabIndex = 12;
            this.pictureBox.TabStop = false;
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(67, 32);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(198, 13);
            this.progressLabel.TabIndex = 11;
            this.progressLabel.Text = "Press the Start button to start scanning";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 227);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.start_BTN);
            this.Controls.Add(this.end_ip_label);
            this.Controls.Add(this.start_ip_label);
            this.Controls.Add(this.end_ip_TB);
            this.Controls.Add(this.start_ip_TB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IPAddressControlLib.IPAddressControl start_ip_TB;
        private IPAddressControlLib.IPAddressControl end_ip_TB;
        private System.Windows.Forms.Label start_ip_label;
        private System.Windows.Forms.Label end_ip_label;
        private System.Windows.Forms.Button start_BTN;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label progressLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

