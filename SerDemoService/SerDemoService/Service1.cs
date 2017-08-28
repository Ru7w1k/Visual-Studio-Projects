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
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("Service SerDemoService stopped..");
        }
    }
}
