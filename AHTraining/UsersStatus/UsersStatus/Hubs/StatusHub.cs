using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using UserStatus.Observer;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using Newtonsoft.Json;
using static ServiceBrokerListener.Domain.SqlDependencyEx;
using ServiceBrokerListener.Domain;

namespace UsersStatus.Hubs
{
    public class StatusHub : Hub
    {
        private Observer _Observer = null;

        public StatusHub()
        {
            _Observer = Observer.GetInstance();
            _Observer.AddListener(UpdateStatus);
        }

        public void UpdateStatus(List<TableChangedEventArgs> data)
        {
            if(data.Any())
                Clients.All.getData(data);
        }
    }
}