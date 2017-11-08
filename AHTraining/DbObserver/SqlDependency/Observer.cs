using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading;
using ServiceBrokerListener.Domain;

namespace SqlDependency
{
    class Observer
    {
        static void Main(string[] args)
        {
            string _SqlConn = @"Data Source=rutwik-c\sqlexpress;Initial Catalog=Student.Data.StudentContext;Integrated Security=True";
            SqlConnection _Conn = new SqlConnection(_SqlConn);
            SqlCommand _Cmd = new SqlCommand("SELECT RollNo, Name, Marks, Branch, Year FROM [dbo].[Studs]", _Conn);

            System.Data.SqlClient.SqlDependency listener = new System.Data.SqlClient.SqlDependency(_Cmd);

            listener.OnChange += Listener_OnChange;

            System.Data.SqlClient.SqlDependency.Start(_SqlConn);

            Console.WriteLine("Listening..");
            _Conn.Open();

            _Cmd.ExecuteReader();

            System.Data.SqlClient.SqlDependency.Stop(_SqlConn);
            Console.WriteLine("Stopped!");
            _Conn.Close();

        }

        private static void Listener_OnChange(object sender, SqlNotificationEventArgs e)
        {
            Console.WriteLine("Changed! \nType: {0} \nSource: {1} \nInfo: {2}", e.Type, e.Source, e.Info);
        }
    }
}
