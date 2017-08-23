using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConADONET
{
    public class SqlHelper
    {
        private SqlConnection _SqlConnection;
        private SqlCommand _SqlCommand;
        private SqlDataAdapter _SqlDataAdapter;
        private string conString = @"Data Source=.\SQLEXPRESS;Initial Catalog=DemoStudent;Integrated Security=True;Pooling=False";

        public SqlHelper()
        {
            _SqlConnection = new SqlConnection(conString);
            if (_SqlConnection.State == System.Data.ConnectionState.Closed)
                _SqlConnection.Open();
            Console.WriteLine("Connection is Open!");
        }

        public SqlDataReader ExecuteQuery(string sqlQuery)
        {
            _SqlCommand = new SqlCommand(sqlQuery, _SqlConnection);
            return _SqlCommand.ExecuteReader();
        }

        public string ExecuteScalar(string sqlQuery)
        {
            _SqlCommand = new SqlCommand(sqlQuery, _SqlConnection);
            return _SqlCommand.ExecuteScalar().ToString();
        }

        public bool ExecuteNonQuery(string sqlQuery)
        {
            var result = false;
            _SqlCommand = new SqlCommand(sqlQuery, _SqlConnection);
            var count = _SqlCommand.ExecuteNonQuery();
            result = count > 0 ? true : false ;
            return result;
        }

        public DataTable GetDataSet(string sqlQuery)
        {
            var ds = new DataSet();
            _SqlDataAdapter = new SqlDataAdapter(sqlQuery, conString);
            _SqlDataAdapter.Fill(ds, "student");
            return ds.Tables[0];
        }

        public void Update(int rollNo, string name)
        {
            string sqlQuery = string.Format(@"SELECT * FROM [Table] WHERE RollNo = {0}", rollNo);
            var ds = new DataSet();
            _SqlDataAdapter = new SqlDataAdapter(sqlQuery, conString);
            SqlCommandBuilder sb = new SqlCommandBuilder(_SqlDataAdapter);
            _SqlDataAdapter.Fill(ds, "student");
            
            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count > 0)
            {
                dt.Rows[0][0] = rollNo;
                dt.Rows[0][1] = name;
            }
            _SqlDataAdapter.Update(dt);
        }

        public void Delete(int rollNo)
        {
            string sqlQuery = string.Format(@"SELECT * FROM [Table] WHERE RollNo = {0}", rollNo);
            var ds = new DataSet();
            _SqlDataAdapter = new SqlDataAdapter(sqlQuery, conString);
            SqlCommandBuilder sb = new SqlCommandBuilder(_SqlDataAdapter);
            _SqlDataAdapter.Fill(ds, "student");

            DataTable dt = ds.Tables[0];

            foreach (DataRow item in dt.Rows)
            {
                item.Delete();
            }

            _SqlDataAdapter.Update(dt);
        }
    }
}
