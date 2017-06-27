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
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Network_Project
{
    public partial class Form1 : Form
    {
        List<IPAddress> list_active_ips = new List<IPAddress>();
        List<string> list_final_ips = new List<string>();
        List<string> list_final_hosts = new List<string>();
        DataTable table = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void start_BTN_Click(object sender, EventArgs e)
        {
            list_active_ips.Clear();
            list_final_ips.Clear();
            list_final_hosts.Clear();
            pictureBox.Image = Properties.Resources.Animation;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState is String)
            {
                this.progressLabel.Text = (String)e.UserState;  //update progressLabel
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

            show_alive_hosts show_hosts = new show_alive_hosts();
            show_hosts.set_grid_source(table);  //set data source of show_hosts data grid view to table containing ips and corresponding hosts
            show_hosts.Show();
        }
        int percentage = 0;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            if (percentage == 0)
            {
                this.backgroundWorker1.ReportProgress(percentage, string.Format("Processing..."));  //show that we are still alive
            }
            try
            {
                var start_ip_bytes = new byte[4];   //array stores bytes of start ip
                var end_ip_bytes = new byte[4];     ///array stores bytes of end ip
                start_ip_bytes = start_ip_TB.GetAddressBytes();
                end_ip_bytes = end_ip_TB.GetAddressBytes();
                for (int i = start_ip_bytes[0]; i <= end_ip_bytes[0]; i++)  //from first byte of start ip to first byte of end ip
                {
                    for (int j = start_ip_bytes[1]; j <= end_ip_bytes[1]; j++)  //from second byte of start ip to second byte of end ip
                    {
                        for (int k = start_ip_bytes[2]; k <= end_ip_bytes[2]; k++)  //from third byte of start ip to third byte of end ip
                        {
                            for (int l = start_ip_bytes[3]; l <= end_ip_bytes[3]; l++)  //from fourth byte of start ip to fourth byte of end ip
                            {

                                Ping pinger = new Ping();       //used to send ping
                                var current_ip = new byte[4];   //byte array stores current ip to test if it's alive or not

                                //int values storing every byte of current ip address

                                int current_byte_first = i;
                                int current_byte_second = j;
                                int current_byte_third = k;
                                int current_byte_fourth = l;

                                //put these values in current ip byte array

                                current_ip[0] = (byte)current_byte_first;
                                current_ip[1] = (byte)current_byte_second;
                                current_ip[2] = (byte)current_byte_third;
                                current_ip[3] = (byte)current_byte_fourth;

                                string ip = current_ip[0].ToString() + "." + current_ip[1].ToString() + "." + current_ip[2].ToString() + "." + current_ip[3].ToString();
                                
                                //create ip object from current ip string

                                IPAddress ip1 = IPAddress.Parse(ip);

                                //send ping. 500 ms timeout

                                PingReply reply = pinger.Send(ip1, 500);

                                //if ping successful, add current ip to list of alive ips

                                if (reply.Status == IPStatus.Success)
                                    list_active_ips.Add(ip1);
                            }
                        }
                    }
                }

                //Get host name for every active ip
                foreach (var ip in list_active_ips)
                {
                    try
                    {
                        IPHostEntry host = Dns.GetHostEntry(ip);
                        if (host.HostName != null)  //if we succeeded in getting host name
                        {   
                            list_final_ips.Add(ip.ToString());  //add current ip to list of final ips
                            list_final_hosts.Add(host.HostName);    //add host to list of final hosts
                        }
                    }
                    catch (SocketException exc)
                    {
                    }
                }
            }

            catch (PingException ping)
            {
            }
            
            //create table containing ips and corresponding host name

            table = new DataTable();
            table.Clear(); 
            table.Columns.Add("IP");
            table.Columns.Add("Host Name");
            for (int i = 0; i < list_final_ips.Count; i++)
            {
                DataRow row = table.NewRow();
                row[0] = list_final_ips[i];
                row[1] = list_final_hosts[i];
                table.Rows.Add(row);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox.Image = Properties.Resources.ready;
        }
    }
}
    
