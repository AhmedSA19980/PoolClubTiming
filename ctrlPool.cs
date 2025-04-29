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
    public partial class ctrlPool : UserControl
    {

        
        private int _MatchDuration =  0 ;

       
        private int _CountUptime;
        public string _TablePlayer = "Player"; 

        public event EventHandler<PoolEventArgs> OnGameCompeleted; 
        public void RaisedOnTableComplete(string TimeText ,int Matchduration ,float RatePerHour,float TotalFees  )
        {
            RaisedOnTableComplete(new PoolEventArgs(TimeText, Matchduration, RatePerHour , TotalFees));  
        }
        protected virtual void RaisedOnTableComplete(PoolEventArgs e)
        {
            OnGameCompeleted?.Invoke(this, e); 
        }


     

        public class PoolEventArgs : EventArgs
        {
           public  string TimeIntext {  get; set; }    
            public int MatchDuration { get; set; }
            public float  TotalFees { get; set; }  
            public float RatePerHour { get; set; }  


            
            public PoolEventArgs(string TimeInText, int MatchDuration ,float RatePerHour,float TotalFees)
            {
                this.TimeIntext = TimeInText;   
                this.MatchDuration = MatchDuration; 
                this.RatePerHour = RatePerHour; 
                this.TotalFees = TotalFees; 
            } 
        
        }

        private string _PlayerName = "Player";
        // The Category attribute tells the designer to display  
        // it in the Flash grouping.
        // The Description attribute provides a description of  
        // the property.
        [
        Category("Pool Config"),
        Description("The table Name.")
        ]
        // The public property EndColor accesses endColor.  
        public string PlayerName { get { return _PlayerName; }
            set {
               // lblplayer.Text = _PlayerName;
                _PlayerName = value;    

            } }


        float  _RatePerHour = 10.00F;
        [
        Category("Pool Config"),
        Description("The table Name.")
        ]
        public float RatePerHour
        {
            get { return _RatePerHour ; }
            set
            {
                _RatePerHour = value;

            }
        }


        string _TableTitle = "Table";
        [
        Category("Pool Config"),
        Description("The table Name.")
        ]
        public string TableTitle
        {
            get { return _TableTitle; }
            set
            {
                gbTable.Text = _TableTitle;
                _TableTitle = value;

            }
        }



        public void Start()
        {
          //  _co = MatchDurationTime;
            poolTimer.Start();


        }

        public void Stop()
        {
            poolTimer.Stop();

        }
        public ctrlPool()
        {
            InitializeComponent();
        }

        private void poolTimer_Tick(object sender, EventArgs e)
        {
            _CountUptime++;

            TimeSpan time = TimeSpan.FromSeconds(_CountUptime);
            string str = time.ToString(@"hh\:mm\:ss");
            lblCountUpTime.Text = str;
          
            lblCountUpTime.Refresh();
            _MatchDuration = _CountUptime;
        }

        public enum enMatchCase {start = 1 , stop = 2 , end = 3 };
        public enMatchCase _CurrentMatchCase =  enMatchCase.start;
  

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if(_CurrentMatchCase == enMatchCase.start)
            {
                btnStartStop.Text = "Stop";
                _CurrentMatchCase = enMatchCase.stop;   
                Start();
            }
            else if(_CurrentMatchCase == enMatchCase.stop)
            {
                _CurrentMatchCase = enMatchCase.start;
                btnStartStop.Text = "Start";
                Stop();
            }
         
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            _CurrentMatchCase = enMatchCase.end;
            btnStartStop.Text = "Start";
            Stop();
            float TotalFees = ((float)_MatchDuration / 60 / 60) * _RatePerHour;

            RaisedOnTableComplete(lblCountUpTime.Text, _MatchDuration, RatePerHour , TotalFees);
           
            gbTable.Text = "Table";
            lblplayer.Text = "Player";
            lblCountUpTime.Text = "00:00:00";
            btnStartStop.Text = "Start";
            _MatchDuration = 0;
            _CurrentMatchCase = enMatchCase.start;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            lblplayer.Text = _PlayerName;
            gbTable.Text = _TableTitle;
        }
    }
}
