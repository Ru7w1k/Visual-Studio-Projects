using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using UserStatus.Observer;

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

        public void UpdateStatus(string notificationType, string data)
        {
            Clients.All.getData();
        }
    }
}