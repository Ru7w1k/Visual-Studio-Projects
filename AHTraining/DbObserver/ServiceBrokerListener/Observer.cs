using ServiceBrokerListener.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBrokerListener
{
    public class Observer
    {
        private TableChangeHandler _Event = null;
        private SqlDependencyEx _Dependency = null;
        //private static Observer _Observer = null;
        private static List<Observer> _Observers = new List<Observer>();

        public delegate void TableChangeHandler(object sender, SqlDependencyEx.TableChangedEventArgs args);

        private Observer(string connectionString, string databaseName, string tableName)
        {
            Console.WriteLine("Creating Observer Instance! {0}", DateTime.Now);
            _Dependency = new SqlDependencyEx(connectionString, databaseName, tableName);
            _Dependency.TableChanged += _Dependency_TableChanged;
            _Dependency.Start();
        }

        private bool Same(string ConnectionString, string DatabaseName, string TableName)
        {
            if (this._Dependency.DatabaseName == DatabaseName)
                if (this._Dependency.ConnectionString == ConnectionString)
                    if (this._Dependency.TableName == TableName)
                        return true;
            return false;
        }
        
        public static Observer GetInstance(string connectionString, string databaseName, string tableName)
        {
            //if (_Observer == null)
            //    _Observer = new Observer(connectionString, databaseName, tableName);

            //return _Observer;

            foreach (Observer item in _Observers)
            {
                if (item.Same(connectionString, databaseName, tableName))
                    return item;
            }
            var tmp = new Observer(connectionString, databaseName, tableName);
            _Observers.Add(tmp);
            return tmp;
        }
        
        public void Stop()
        {
            _Dependency.Stop();
        }

        private void _Dependency_TableChanged(object sender, SqlDependencyEx.TableChangedEventArgs e)
        {
            Console.WriteLine("TableChanged!");
            _Event(sender, e);
        }

        public void AddListener (TableChangeHandler e)
        {
            Console.WriteLine("Event Added {0}", e.Method.Name);
            _Event += e;
        }
    }
}
