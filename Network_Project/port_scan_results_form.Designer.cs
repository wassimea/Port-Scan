namespace Network_Project
{
    partial class port_scan_results_form
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
            this.grid_scan_results = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_scan_results)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_scan_results
            // 
            this.grid_scan_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_scan_results.Location = new System.Drawing.Point(12, 12);
            this.grid_scan_results.Name = "grid_scan_results";
            this.grid_scan_results.Size = new System.Drawing.Size(564, 377);
            this.grid_scan_results.TabIndex = 0;
            // 
            // port_scan_results_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 401);
            this.Controls.Add(this.grid_scan_results);
            this.Name = "port_scan_results_form";
            this.Text = "port_scan_results_form";
            ((System.ComponentModel.ISupportInitialize)(this.grid_scan_results)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_scan_results;
    }
}