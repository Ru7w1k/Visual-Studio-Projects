using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceBrokerListener.Domain;

namespace UserStatus.Observer
{
    public class Observer
    {
        private static Observer _Observer = null;
        private SqlDependencyEx _Dependency;
        private TableChangeHandler _Event = null;

        public delegate void TableChangeHandler(string notificationType, string data);

        private Observer()
        {
            _Dependency = new SqlDependencyEx(
                @"Data Source=rutwik-c\sqlexpress;Initial Catalog=UserStatus.Data.UserContext;Integrated Security=True",
                "UserStatus.Data.UserContext",
                "Users");
            _Dependency.TableChanged += _Dependency_TableChanged;
            _Dependency.Start();
        }

        private void _Dependency_TableChanged(object sender, SqlDependencyEx.TableChangedEventArgs e)
        {
            _Event.Invoke(e.NotificationType.ToString(), e.Data.ToString());
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
            _Event += handler;
        }
    }
}
