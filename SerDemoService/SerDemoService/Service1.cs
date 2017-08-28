using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace SerDemoService
{
    public partial class SerDemoService : ServiceBase
    {
        public SerDemoService()
        {
            InitializeComponent();

            if (!System.Diagnostics.EventLog.SourceExists("SerDemoServiceSource"))
                System.Diagnostics.EventLog.CreateEventSource("SerDemoServiceSource", "SerDemoServiceLog");

            eventLog1.Source = "SerDemoServiceSource";
            eventLog1.Log = "SerDemoServiceLog";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("Service SerDemoService started..");

            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 6000; // 60 Seconds
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            eventLog1.WriteEntry("Timer Elapsed..", EventLogEntryType.Information);
        }
        
        protected override void OnStop()
        {
            eventLog1.WriteEntry("Service SerDemoService stopped..");
        }

        protected override void OnPause()
        {
            eventLog1.WriteEntry("Service SerDemoService paused..");
        }

        protected override void OnContinue()
        {
            eventLog1.WriteEntry("Service SerDemoService continue..");
        }
    }
}
