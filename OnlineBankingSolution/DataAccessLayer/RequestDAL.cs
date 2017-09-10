using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class RequestDAL
    {
        public DataSet SelectAllPendingRequest(string BranchCode)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=PAVILION\SQLSERVER;Initial Catalog=EBanking;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select Req_Id, Name, Request.Acc_No, Req_On from Request inner join Customer on Request.Acc_No = Customer.Acc_No where Status = 'PENDING' and Branch_Code = @BranchCode", connection);
            da.SelectCommand.Parameters.AddWithValue("@BranchCode", BranchCode);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }

        public DataSet SelectAllAcceptRequest(DateTime from, DateTime to, string request)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=PAVILION\SQLSERVER;Initial Catalog=EBanking;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select Req_Id, Name, Request.Acc_No from Request inner join Customer on Request.Acc_No = Customer.Acc_No where Status = @request  and Req_On >= @from and Req_On <= @to", connection);
            da.SelectCommand.Parameters.AddWithValue("@request", request);
            da.SelectCommand.Parameters.Add("@from", SqlDbType.DateTime).Value = from;
            da.SelectCommand.Parameters.Add("@to", SqlDbType.DateTime).Value = to;

            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }
        public bool UpdateReq(string Req_Id, string Status)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=PAVILION\SQLSERVER;Initial Catalog=EBanking;Integrated Security=True");
            SqlCommand updateRecord = new SqlCommand("update Request set Status = @Status where Req_Id = @Req_Id", connection);
            updateRecord.Parameters.AddWithValue("@Status", Status);
            updateRecord.Parameters.Add("@Req_Id", SqlDbType.Decimal).Value = Convert.ToDecimal(Req_Id);

            connection.Open();
            int rows = updateRecord.ExecuteNonQuery();
            connection.Close();

            if (rows == 1)
            {
                return true;
            }
            return false;
        }

        public Request SelectRequestFromAccNo(Request request)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=PAVILION\SQLSERVER;Initial Catalog=EBanking;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select Status, Req_Id from Request where Acc_No = @accountNo", conn);
            cmd.Parameters.AddWithValue("@accountNo", request.AccountNumber);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                request.RequestStatus = dr[0].ToString();
                request.RequestId = dr[1].ToString();
                dr.Close();
                conn.Close();
                return request;
            }
            conn.Close();
            return null;
        }

        public Request SelectRequest(Request request)
        {
            string status, accountId;
            SqlConnection conn = new SqlConnection(@"Data Source=PAVILION\SQLSERVER;Initial Catalog=EBanking;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select Status, Acc_No from Request where Req_Id = @requestId", conn);
            cmd.Parameters.AddWithValue("@requestId", request.RequestId);

            SqlCommand cmd1 = new SqlCommand("select PhNo from Customer where Acc_No = @accNo", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                status = dr[0].ToString();
                accountId = dr[1].ToString();
                dr.Close();
                cmd1.Parameters.AddWithValue("@accNo", accountId);
                string phoneNo = Convert.ToString((long)cmd1.ExecuteScalar());
                if (Equals(phoneNo, request.MobileNumber))
                {
                    request.RequestStatus = status;
                    request.AccountNumber = accountId;
                    conn.Close();
                    return request;
                }
                conn.Close();
                return null;
            }
            else
            {
                conn.Close();
                return null;
            }
        }

        public string InsertRequest(Request request)
        {
            string requestId = "NULL";
            SqlConnection conn = new SqlConnection(@"Data Source=PAVILION\SQLSERVER;Initial Catalog=EBanking;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into Request values('PENDING', @accountNumber, @requestOn, @branchCode)", conn);
            cmd.Parameters.AddWithValue("@accountNumber", request.AccountNumber);
            cmd.Parameters.AddWithValue("@requestOn", request.RegisteredOn);
            cmd.Parameters.AddWithValue("@branchCode", request.BranchCode);

            SqlCommand cmd1 = new SqlCommand("select Req_Id from Request where Acc_No = @accountNumber", conn);
            cmd1.Parameters.AddWithValue("@accountNumber", request.AccountNumber);

            SqlCommand cmd2 = new SqlCommand("update Account set Req_Id = @reqID where Acc_No = @accNo", conn);
            cmd2.Parameters.AddWithValue("@accNo", request.AccountNumber);

            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                requestId = Convert.ToString((decimal) cmd1.ExecuteScalar());
                cmd2.Parameters.AddWithValue("@reqID", requestId);
                if(cmd2.ExecuteNonQuery() != 1)
                {
                    requestId = "NULL";
                }
            }            
            conn.Close();
            return requestId;
        }

        public bool CheckRequest(Request request, string cifNo)
        {
            bool result = false;
            SqlConnection conn = new SqlConnection(@"Data Source=PAVILION\SQLSERVER;Initial Catalog=EBanking;Integrated Security=True");
            SqlCommand cmd1 = new SqlCommand("select CIFNo, BranchCode from Account where Acc_No = @accountNumber", conn);
            SqlCommand cmd2 = new SqlCommand("select PhNo from Customer where CIFNo = @cifNo", conn);
            SqlCommand cmd3 = new SqlCommand("select * from Request where Acc_No = @accountNo", conn);

            cmd1.Parameters.AddWithValue("@accountNumber", request.AccountNumber);
            cmd2.Parameters.AddWithValue("@cifNo", cifNo);
            cmd3.Parameters.AddWithValue("@accountNo", request.AccountNumber);

            conn.Open();
            SqlDataReader dr0 = cmd3.ExecuteReader();
            if (!dr0.Read())
            {
                dr0.Close();
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    if (string.Equals(dr[0].ToString(), cifNo) && string.Equals(dr[1].ToString(), request.BranchCode))
                    {
                        dr.Close();
                        SqlDataReader dr2 = cmd2.ExecuteReader();
                        if (dr2.Read())
                        {
                            if (string.Equals(dr2[0].ToString(), request.MobileNumber))
                                result = true;
                        }
                    }
                }
            }
            conn.Close();
            return result;
        }
    }
}
