using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class LoginDAL
    {
        public bool InsertLogin(string userName, string password, string userType)
        {
            bool result = false;
            SqlConnection conn = new SqlConnection(@"Data Source=PAVILION\SQLSERVER;Initial Catalog=EBanking;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into Login values (@username, @password, 'CUST')", conn);
            cmd.Parameters.AddWithValue("@username", userName);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@usertype", userType);
            conn.Open();
            int row = cmd.ExecuteNonQuery();
            if (row == 1)
                result = true;
            conn.Close();
            return result;
        }

        public bool CheckIfExist(string userName)
        {
            bool result = true;
            SqlConnection conn = new SqlConnection(@"Data Source=PAVILION\SQLSERVER;Initial Catalog=EBanking;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Login where UserName = @username", conn);
            cmd.Parameters.AddWithValue("@username", userName);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if(!dr.HasRows)
            {
                result = false;
            }
            conn.Close();
            return result;                 
        }

        public string IsLoginValid(string username, string password)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=PAVILION\SQLSERVER;Initial Catalog=EBanking;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select UserType from Login where UserName = @username and Password=@password", conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            conn.Open();
            string userType = (string) cmd.ExecuteScalar();
            conn.Close();
            if (!String.IsNullOrEmpty(userType))
            {
                return userType;
            }
            else
            {
                return "FALSE";
            }

        }
    }
}
