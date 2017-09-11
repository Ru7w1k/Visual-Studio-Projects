using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class AccountDAL
    {
        public bool UpdateAccount(Account account)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=PAVILION\SQLSERVER;Initial Catalog=EBanking;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("update Account set Balance = @balance where Acc_No = @accountNumber", conn);
            cmd.Parameters.AddWithValue("@balance", account.Balance);
            cmd.Parameters.AddWithValue("@accountNumber", account.AccountNumber);

            conn.Open();
            int row = cmd.ExecuteNonQuery();
            conn.Close();
            if(row == 1)
            {
                return true;
            }
            return false;           
        }

        public Account GetAccount(string accountNumber)
        {
            Account account = new Account();
            SqlConnection conn = new SqlConnection(@"Data Source=PAVILION\SQLSERVER;Initial Catalog=EBanking;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Account where Acc_No = @accountNumber", conn);
            cmd.Parameters.AddWithValue("@accountNumber", accountNumber);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                account.AccountNumber = accountNumber;
                account.CifNumber = dr[1].ToString();
                account.BranchCode = dr[2].ToString();
                account.RequestId = dr[3].ToString();
                account.Balance = Convert.ToDouble(dr[4].ToString());
                account.Status = dr[5].ToString();
                account.Type = dr[6].ToString();
                account.CreatedOn = DateTime.Parse(dr[7].ToString());
            }
            conn.Close();
            return account;
        }
    }
}
