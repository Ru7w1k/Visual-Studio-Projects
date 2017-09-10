using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class TransactionDAL
    {
        public bool InsertTransaction(Transaction transaction)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=PAVILION\SQLSERVER;Initial Catalog=EBanking;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into Transact_ion values(@accNo, @bid, @amount, @transOn)", conn);
            cmd.Parameters.AddWithValue("@accNo", transaction.AccountNumber);
            cmd.Parameters.AddWithValue("@bid", transaction.BenificiaryId);
            cmd.Parameters.AddWithValue("@amount", transaction.Amount);
            cmd.Parameters.Add("@transOn", SqlDbType.DateTime).Value = transaction.TransactionOn;

            conn.Open();
            int row = cmd.ExecuteNonQuery();
            conn.Close();
            if (row == 1)
                return true;
            return false;
        }

        public List<Transaction> SelectAllTransactionCredit(DateTime from, DateTime to, string accountNumber)
        {
            List<Transaction> transactions = new List<Transaction>();
            SqlConnection conn = new SqlConnection(@"Data Source=PAVILION\SQLSERVER;Initial Catalog=EBanking;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select Beneficiary.Acc_No, Beneficiary.BID, Amt, Trans_On from Transact_ion INNER JOIN Beneficiary on Transact_ion.BID=Beneficiary.BID where BAcc_No= @bAccNo and Trans_On >= @from and Trans_On <= @to", conn);
            cmd.Parameters.AddWithValue("@bAccNo", accountNumber);
            cmd.Parameters.Add("@from", SqlDbType.DateTime).Value = from;
            cmd.Parameters.Add("@to", SqlDbType.DateTime).Value = to;

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Transaction transaction = new Transaction();
                transaction.AccountNumber = dr[0].ToString();
                transaction.BenificiaryId = dr[1].ToString();
                transaction.Amount = Convert.ToInt64(dr[2].ToString());
                transaction.TransactionOn = DateTime.Parse(dr[3].ToString());
                transactions.Add(transaction);
            }
            conn.Close();

            return transactions;
        }

        public List<Transaction> SelectAllTransaction(DateTime from, DateTime to, string accountNumber)
        {
            List<Transaction> transactions = new List<Transaction>();
            SqlConnection conn = new SqlConnection(@"Data Source=PAVILION\SQLSERVER;Initial Catalog=EBanking;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select Acc_No, BID, Amt, Trans_On from Transact_ion where Acc_No = @account and Trans_On >= @from and Trans_On <= @to",conn);
            cmd.Parameters.AddWithValue("@account", accountNumber);
            cmd.Parameters.Add("@from",SqlDbType.DateTime).Value = from;
            cmd.Parameters.Add("@to", SqlDbType.DateTime).Value = to;

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Transaction transaction = new Transaction();
                transaction.AccountNumber = dr[0].ToString();
                transaction.BenificiaryId = dr[1].ToString();
                transaction.Amount = Convert.ToInt64(dr[2].ToString());
                transaction.TransactionOn = DateTime.Parse(dr[3].ToString());
                transactions.Add(transaction);
            }
            conn.Close();

            return transactions;
        }
    }
}
