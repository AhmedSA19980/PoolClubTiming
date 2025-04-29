using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoolClub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ctrlPool1_OnGameCompeleted(object sender, ctrlPool.PoolEventArgs e)
        {

            string TableResults = "";

            TableResults = "Time Consumed " + e.TimeIntext;
            TableResults = TableResults + ", Total Seconds= " + e.MatchDuration;
            TableResults = TableResults + ", HourlyRate=" + e.RatePerHour.ToString();
            TableResults = TableResults + ", Total Fees=" + e.TotalFees.ToString();

            TableResults = TableResults + ", Total Fees=" + e.TotalFees.ToString();
            MessageBox.Show(TableResults);
        }
    }
}
