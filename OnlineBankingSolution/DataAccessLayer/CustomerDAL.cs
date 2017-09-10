using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class CustomerDAL
    {
        public Customer SelectCustomerByUserName(string userName)
        {
            Customer customer = new Customer();
            SqlConnection conn = new SqlConnection(@"Data Source = PAVILION\SQLSERVER; Initial Catalog = EBanking; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("select * from Customer where UserName = @username", conn);
            cmd.Parameters.AddWithValue("@username", userName);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                customer.CifNumber = dr[0].ToString();
                customer.Name = dr[1].ToString();
                customer.Address = dr[2].ToString();
                customer.PhoneNumber = dr[3].ToString();
                customer.UserName = userName;
                customer.AccountNumber = Convert.ToInt64(dr[5].ToString());
            }
            conn.Close();
            return customer;
        }

        public bool InsertUsername(Customer customer, string userName)
        {
            SqlConnection conn = new SqlConnection(@"Data Source = PAVILION\SQLSERVER; Initial Catalog = EBanking; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("update Customer set UserName = @username where CIFNo = @cifNumber", conn);
            cmd.Parameters.AddWithValue("@username", userName);
            cmd.Parameters.AddWithValue("@cifNumber", customer.CifNumber);
            conn.Open();
            int row = cmd.ExecuteNonQuery();
            conn.Close();
            if (row == 1)
                return true;
            return false;
        }

        public Customer SelectCustomerByCIF(string cifNumber)
        {
            Customer customer = new Customer();
            SqlConnection conn = new SqlConnection(@"Data Source = PAVILION\SQLSERVER; Initial Catalog = EBanking; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("select * from Customer where CIFNo = @cifNo",conn);
            cmd.Parameters.AddWithValue("@cifNo", cifNumber);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                customer.CifNumber = cifNumber;
                customer.Name = dr[1].ToString();
                customer.Address = dr[2].ToString();
                customer.PhoneNumber = dr[3].ToString();
                if(! string.IsNullOrEmpty(dr[4].ToString()))
                    customer.UserName = dr[4].ToString();
                customer.AccountNumber = Convert.ToInt64(dr[5].ToString());
            }
            conn.Close();
            return customer;
        }
    }
}
