using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Project
{
    public partial class port_scan_results_form : Form
    {
        public port_scan_results_form()
        {
            InitializeComponent();
        }

        public void set_grid_source(DataTable table)
        {
            grid_scan_results.DataSource = table;
            grid_scan_results.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}
