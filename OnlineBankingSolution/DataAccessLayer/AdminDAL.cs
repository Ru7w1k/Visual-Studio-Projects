using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
   public class AdminDAL
   {
        public Admin SelectAdminFromUserName(string username)
        {
            Admin admin = null;
            SqlConnection conn = new SqlConnection(@"Data Source=PAVILION\SQLSERVER;Initial Catalog=EBanking;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Admin where UserName = @username", conn);
            cmd.Parameters.AddWithValue("@username", username);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                admin = new Admin();
                admin.AdminId = dr[0].ToString();
                admin.Name = dr[1].ToString();
                admin.Address = dr[2].ToString();
                admin.PhoneNumber = dr[3].ToString();
                admin.UserName = dr[4].ToString();
            }
            conn.Close();
            return admin;
        }

       public string AddBranchManager(BranchManager branchmanager)
       {
           string res = null;
           decimal bmid;

           SqlConnection connection = new SqlConnection(@"Data Source=PAVILION\SQLSERVER;Initial Catalog=EBanking;Integrated Security=True");
           SqlCommand insertRecord = new SqlCommand("insert into BranchMgr values(@name,@address,@phoneNumber,@userName,@branchCode)", connection);
           SqlCommand Login = new SqlCommand("insert into Login values(@username,@password,\'BRMGR\')", connection);
           SqlCommand cmd = new SqlCommand("select BMID from BranchMgr where UserName = @username", connection);

           insertRecord.Parameters.AddWithValue("@name",branchmanager.Name);
           insertRecord.Parameters.AddWithValue("@address", branchmanager.Address);
           insertRecord.Parameters.AddWithValue("@phoneNumber", branchmanager.PhoneNumber);
           insertRecord.Parameters.AddWithValue("@userName", branchmanager.UserName);
           insertRecord.Parameters.AddWithValue("@branchCode", branchmanager.BranchCode);

           Login.Parameters.AddWithValue("@username", branchmanager.UserName);
           Login.Parameters.AddWithValue("@password", branchmanager.Password);

           cmd.Parameters.AddWithValue("@username", branchmanager.UserName);

           connection.Open();
           try
           {
               int row = Login.ExecuteNonQuery();
               int rows = insertRecord.ExecuteNonQuery();
               bmid = (decimal)cmd.ExecuteScalar();
               res = bmid.ToString();
               return res;
           }
           catch (Exception e)
           {
               res = "DUPLICATE";
               return res;
           }
           finally
           {
               connection.Close();
           }
           

          
       }
       public int ModifyRecord(BranchManager branchmanager)
       {
           SqlConnection connection = new SqlConnection(@"Data Source=PAVILION\SQLSERVER;Initial Catalog=EBanking;Integrated Security=True");
           SqlCommand updateRecord = new SqlCommand("update  BranchMgr SET  Name=@name ,Address=@address, PhNo=@phoneNumber WHERE BMID=@BMId", connection);
           updateRecord.Parameters.AddWithValue("@BMId", branchmanager.BMId1);
           updateRecord.Parameters.AddWithValue("@name", branchmanager.Name);
           updateRecord.Parameters.AddWithValue("@address", branchmanager.Address);
           updateRecord.Parameters.AddWithValue("@phoneNumber", branchmanager.PhoneNumber);
           updateRecord.Parameters.AddWithValue("@branchCode", branchmanager.BranchCode);
          
           connection.Open();
           int rows = updateRecord.ExecuteNonQuery();
           // Response.Write("number of rows delete" + rows);
           connection.Close();
           return rows;



       }
       public int DeleteRecord(BranchManager branchmanager)
       {
           SqlConnection connection = new SqlConnection(@"Data Source=PAVILION\SQLSERVER;Initial Catalog=EBanking;Integrated Security=True");                                                   
            SqlCommand deleteRecord = new SqlCommand("delete from BranchMgr where BMID=@BMId", connection);
            SqlCommand deleteLogin = new SqlCommand("delete from Login where UserName = @username", connection);
            deleteRecord.Parameters.AddWithValue("@BMId", branchmanager.BMId1);
            deleteRecord.Parameters.AddWithValue("@name",branchmanager.Name);
            deleteRecord.Parameters.AddWithValue("@address", branchmanager.Address);
            deleteRecord.Parameters.AddWithValue("@phoneNumber", branchmanager.PhoneNumber);

            deleteLogin.Parameters.AddWithValue("@username", branchmanager.UserName);

            connection.Open();
            int rows = deleteRecord.ExecuteNonQuery();
            int row = deleteLogin.ExecuteNonQuery();
            
            
           // Response.Write("number of rows delete" + rows);
            connection.Close();
            return rows;
           
        

       }

     
    }
}
