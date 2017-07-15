using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Repository;

namespace MailSenderService
{
    public partial class Service1 : ServiceBase
    {

        private static System.Timers.Timer aTimer;

        public Service1()
        {
            InitializeComponent();
        }

        public void OnStart()
        {
            Debugger.Break();
            aTimer = new System.Timers.Timer(10000);

            // Hook up the Elapsed event for the timer.
            aTimer.Elapsed += new ElapsedEventHandler(timer1_Tick);

            // Set the Interval to 2 seconds (2000 milliseconds).
            aTimer.Interval = 2000;
            aTimer.Enabled = true;

            //MessageBox.Show("Press the Enter key to exit the program.");
        }

        protected override void OnStop()
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("Timer");
           MailRepository repository = new MailRepository();
           repository.GetAllPeriopContent();
        }
    }
}
