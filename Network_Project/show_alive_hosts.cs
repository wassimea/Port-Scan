using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
namespace Network_Project
{
    public partial class show_alive_hosts : Form
    {
        DataTable port_scan_table = new DataTable();
        public show_alive_hosts()
        {
            InitializeComponent();
        }

        public void set_grid_source(DataTable table)
        {
            grid_alive_hosts.DataSource = table;
        }

        private void scan_btn_Click(object sender, EventArgs e)
        {
            pictureBox.Image = Properties.Resources.Animation;
            backgroundWorker1.RunWorkerAsync();
        }
        int percentage = 0;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (percentage == 0)
            {
                this.backgroundWorker1.ReportProgress(percentage, string.Format("Processing..."));  //show that we are still alive
            }

            string selected_ip = "";    //ip of selected datagridview row

            int selectedrowindex = grid_alive_hosts.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = grid_alive_hosts.Rows[selectedrowindex];
            selected_ip = Convert.ToString(selectedRow.Cells[0].Value);

            //create table to store port scan results

            port_scan_table = new DataTable();
            port_scan_table.Columns.Add("Port Number");
            port_scan_table.Columns.Add("Process ID");
            port_scan_table.Columns.Add("Process Name");
            port_scan_table.Columns.Add("Process Port Description");
            port_scan_table.Columns.Add("Protocol");

            //get active ports using ProcessPorts

            List<ProcessPort> netstat_ports = ProcessPorts.ProcessPortMap(selected_ip);

            //fill table with data from netstat_ports

            for (int i = 0; i < netstat_ports.Count; i++)
            {
                DataRow row = port_scan_table.NewRow();
                row[0] = netstat_ports[i].PortNumber.ToString();
                row[1] = netstat_ports[i].ProcessId.ToString();
                row[2] = netstat_ports[i].ProcessName;
                row[3] = netstat_ports[i].ProcessPortDescription.ToString();
                row[4] = netstat_ports[i].Protocol.ToString();
                port_scan_table.Rows.Add(row);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.pictureBox.Image = null;
            if (e.Error != null)    //if an error occured
            {
                this.progressLabel.Text = "Operation failed: " + e.Error.Message;   //report error
                this.pictureBox.Image = Properties.Resources.Error; //show error icon
            }
            else    //if no error occured
            {
                this.progressLabel.Text = "Operation completed successfuly";
                this.pictureBox.Image = Properties.Resources.Information;   //show information icon
            }

            port_scan_results_form results = new port_scan_results_form();
            results.set_grid_source(port_scan_table);
            results.Show();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState is String)
            {
                this.progressLabel.Text = (String)e.UserState;  //update progressLabel
            }
        }

        private void show_alive_hosts_Load(object sender, EventArgs e)
        {
            pictureBox.Image = Properties.Resources.ready;
            grid_alive_hosts.MultiSelect = false;
        }
    }
}
