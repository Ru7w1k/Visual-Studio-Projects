using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace SerBackupService
{
    public partial class SerBackupService : ServiceBase
    {
        private string _BackupPath = @"D:\Buffer\BackupFolder\";
        private string _MainPath = @"D:\FolderToSync\";
        private string SHARED_MUTEX_NAME = "MUTEX_FILEIO";
        private Mutex mtx;

        public SerBackupService()
        {
            InitializeComponent();

            if (!System.Diagnostics.EventLog.SourceExists("SerBackupServiceSource"))
                System.Diagnostics.EventLog.CreateEventSource("SerBackupServiceSource", "SerBackupServiceLog");

            eventLog1.Source = "SerBackupServiceSource";
            eventLog1.Log = "SerBackupServiceLog";
            mtx = new Mutex(false, SHARED_MUTEX_NAME);
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("Backup service started..");

            FileSystemWatcher watcher = new FileSystemWatcher(_MainPath);
            watcher.IncludeSubdirectories = true;

            watcher.Changed += Watcher_Changed;
            watcher.Created += Watcher_Created;
            watcher.Deleted += Watcher_Deleted;
            watcher.Renamed += Watcher_Renamed;

            watcher.EnableRaisingEvents = true;
        }

        private void Watcher_Renamed(object sender, RenamedEventArgs e)
        {            
            eventLog1.WriteEntry(string.Format("Renaming {0} to {1}..", e.OldName, e.Name));

            while(!mtx.WaitOne())
            {
               
            }
            FileStream fs = new FileStream(_MainPath + e.Name, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            using (FileStream fs1 = new FileStream(_BackupPath + e.Name, FileMode.Create, FileAccess.ReadWrite))
            {
                StreamWriter sw = new StreamWriter(fs1);
                StreamReader sr = new StreamReader(fs);
                sw.Write(sr.ReadToEnd());
                sw.Flush();
                sw.Close();
                sr.Close();
            }
            fs.Close();

            File.Delete(_BackupPath + e.OldName);
            mtx.ReleaseMutex();
        }

        private void Watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            eventLog1.WriteEntry(string.Format("Deleted {0}..", e.Name));
        }

        private void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            eventLog1.WriteEntry(string.Format("Created {0}..", e.Name));

            while (!mtx.WaitOne(10000))
            {
                // mutex not available..
            }
            FileStream fs = new FileStream(_MainPath + e.Name, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            
            using (FileStream fs1 = new FileStream(_BackupPath + e.Name, FileMode.Create, FileAccess.ReadWrite))
            {
                StreamWriter sw = new StreamWriter(fs1);
                StreamReader sr = new StreamReader(fs);
                sw.Write(sr.ReadToEnd());
                sw.Flush();
                sw.Close();
                sr.Close();
            }
            fs.Close();
            mtx.ReleaseMutex();
        }

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {            
            eventLog1.WriteEntry(string.Format("Deleted {0}..", e.Name));
            while (!mtx.WaitOne())
            {
                // mutex not available..
            }
            FileStream fs = new FileStream(_MainPath + e.Name, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            using (FileStream fs1 = new FileStream(_BackupPath + e.Name, FileMode.Create, FileAccess.ReadWrite))
            {
                StreamWriter sw = new StreamWriter(fs1);
                StreamReader sr = new StreamReader(fs);
                sw.Write(sr.ReadToEnd());
                sw.Flush();
                sw.Close();
                sr.Close();
            }
            fs.Close();
            mtx.ReleaseMutex();
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("Backup service stopped..");
        }
    }
}
