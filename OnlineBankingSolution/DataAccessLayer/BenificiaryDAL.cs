using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class BenificiaryDAL
    {
        public List<Benificiary> SelectAllBeneficiary(string accountNumber)
        {
            List<Benificiary> beneficiaries = new List<Benificiary>();
            SqlConnection conn = new SqlConnection(@"Data Source=PAVILION\SQLSERVER;Initial Catalog=EBanking;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from beneficiary where Acc_No = @accountNumber", conn);
            cmd.Parameters.AddWithValue("@accountNumber", accountNumber);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Benificiary ben = new Benificiary();
                ben.BenificiaryID = dr[0].ToString();
                ben.AccountNumber = dr[1].ToString();
                ben.Name = dr[2].ToString();
                ben.BaccountNumber = dr[3].ToString();
                ben.TransactionLimit = Convert.ToInt64(dr[4].ToString());
                beneficiaries.Add(ben);
            }
            conn.Close();
            return beneficiaries;
        }

        public string InsertBenificiary(Benificiary benificiary)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=PAVILION\SQLSERVER;Initial Catalog=EBanking;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into beneficiary values (@accNo, @benName, @benAccNo, 25000)", conn);
            cmd.Parameters.AddWithValue("@accNo", benificiary.AccountNumber);
            cmd.Parameters.AddWithValue("@benName", benificiary.Name);
            cmd.Parameters.AddWithValue("@benAccNo", benificiary.BaccountNumber);
            Benificiary newBenificiary = null;
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                newBenificiary = SelectBenificiary(benificiary.AccountNumber, benificiary.BaccountNumber);
                if (newBenificiary != null)
                    return newBenificiary.BenificiaryID;
            }
            catch
            {
                return "NOBEN";
            }
            finally
            {
                conn.Close();
            }
            return "NULL";
        }

        public Benificiary SelectBenificiary(string accountNumber, string bAccountNumber)
        {
            Benificiary benificiary = new Benificiary();
            SqlConnection conn = new SqlConnection(@"Data Source=PAVILION\SQLSERVER;Initial Catalog=EBanking;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from beneficiary where Acc_No = @accNo and BAcc_No = @bAccNo", conn);
            cmd.Parameters.AddWithValue("@accNo", accountNumber);
            cmd.Parameters.AddWithValue("@bAccNo", bAccountNumber);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                benificiary.BenificiaryID = dr[0].ToString();
                benificiary.AccountNumber = dr[1].ToString();
                benificiary.Name = dr[2].ToString();
                benificiary.BaccountNumber = dr[3].ToString();
                benificiary.TransactionLimit = Convert.ToInt64(dr[4].ToString());
            }
            return benificiary;
        }
    }
}
