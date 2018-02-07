using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceBrokerListener.Domain;
using PubnubApi;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using static ServiceBrokerListener.Domain.SqlDependencyEx;
using System.Timers;

namespace UserStatus.Observer
{
    public class Observer
    {
        private static Observer _Observer = null;
        private SqlDependencyEx _Dependency;
        private TableChangeHandler _Event = null;
        //private Pubnub _Pubnub = new Pubnub(new PNConfiguration
        //{
        //    PublishKey = "pub-c-9e3c5ea8-aa06-4040-b054-9a5e783c3a30",
        //    SubscribeKey = "sub-c-b95bc812-ca8e-11e7-ad03-722f9b71d63a",
        //    SecretKey = "sec-c-ZGI5YzQ4ZDktYWEwNC00YjQ1LWEwZWEtNGI0ZjgxNzYyODRl",
        //});
        private List<TableChangedEventArgs> _TableArgs = null;
        private Timer _Timer = null;
        private static int count = 0;

        public delegate void TableChangeHandler(List<TableChangedEventArgs> data);

        private Observer()
        {
            _TableArgs = new List<TableChangedEventArgs>();
            _Dependency = new SqlDependencyEx(
                @"Data Source=rutwik-c\sqlexpress;Initial Catalog=UserStatus.Data.UserContext;Integrated Security=True",
                "UserStatus.Data.UserContext",
                "Users",
                listenerType: NotificationTypes.Update);
            _Dependency.TableChanged += _Dependency_TableChanged;
            _Dependency.Start();
            _Timer = new Timer(2000);
            _Timer.Start();
            _Timer.Elapsed += _Timer_Elapsed;
        }

        private void _Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            lock (_TableArgs)
            {
                if (_TableArgs.Any())
                {
                    var data = _TableArgs.ToList();
                    count += data.Count;

                    // SignalR
                    _Event.Invoke(data);

                    // PubNub
                    //_Pubnub.Publish()
                    //    .Message(data)
                    //    .Channel("channel1")
                    //    .Async(new PNPublishResultExt(
                    //        (result, status) => { }
                    //    ));

                    _TableArgs.Clear();
                }
            }
        }

        private void _Dependency_TableChanged(object sender, TableChangedEventArgs e)
        {
            lock (_TableArgs)
            {
                _TableArgs.Add(e);
            }
            
            // Dont Invoke Event immidiately
            //_Event.Invoke(e.NotificationType.ToString(), e);

            //_Pubnub.Publish()
            //    .Message(e)
            //    .Channel("channel1")
            //    .Async(new PNPublishResultExt(
            //        (result, status) => {
            //            //Console.WriteLine(result.Timetoken.ToString());
            //            //Console.WriteLine(status.StatusCode.ToString());
            //        }
            //    ));
        }

        public static Observer GetInstance()
        {
            if(_Observer == null)
            {
                _Observer = new Observer();
            }
            return _Observer;
        }

        public void AddListener(TableChangeHandler handler)
        {
            if(_Event == null)
                _Event += handler;
        }
    }
}
