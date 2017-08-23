using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConADONET
{
    public class Student
    {
        private SqlHelper _SqlHelper;
        private string sqlQuery;

        public Student()
        {
            _SqlHelper = new SqlHelper();
        }

        public void GetData()
        {
            sqlQuery = @"SELECT * FROM [Table]";
            var sqlReader = _SqlHelper.ExecuteQuery(sqlQuery);

            while (sqlReader.Read())
            {
                Console.WriteLine("{0} {1} {2} {3}", sqlReader[0].ToString(), sqlReader[1].ToString(), sqlReader[2].ToString(), sqlReader[3].ToString());
            }

            sqlReader.Close();
        }

        public void GetData1()
        {
            sqlQuery = @"SELECT COUNT(*) FROM [Table]";
            var result = _SqlHelper.ExecuteScalar(sqlQuery);

            Console.WriteLine("Count: {0}", result);            
        }

        public void SaveData()
        {
            Console.WriteLine("Enter Roll Number: ");
            string rollNo = Console.ReadLine();
            sqlQuery = string.Format(@"INSERT INTO [Table] VALUES ({0}, 'XYZ', 84.17, 9876543210)", int.Parse(rollNo));

            if(_SqlHelper.ExecuteNonQuery(sqlQuery))
                Console.WriteLine("Record Inserted!");
            else
                Console.WriteLine("Error!");
        }

        public void GetDataSet()
        {
            sqlQuery = @"SELECT * FROM [Table]";
            DataTable dt = _SqlHelper.GetDataSet(sqlQuery);
            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine("{0} {1} {2} {3}", 
                    dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }

            dt.WriteXml(@"D:\test.xml");            
        }

        public void Update()
        {
            Console.WriteLine("Enter Roll No to update: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();

            _SqlHelper.Update(number, name);
        }

        public void Delete()
        {
            Console.WriteLine("Enter Roll No to delete: ");
            int number = int.Parse(Console.ReadLine());

            _SqlHelper.Delete(number);
        }
    }
}
