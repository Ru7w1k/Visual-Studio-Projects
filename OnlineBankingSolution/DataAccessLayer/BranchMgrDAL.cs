using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Entities;
namespace DataAccessLayer
{
   public class BranchMgrDAL
    {
        public BranchManager SelectBranchMgrFromUserName(string username)
        {
            BranchManager branchMgr = null;
            SqlConnection connection = new SqlConnection(@"Data Source=PAVILION\SQLSERVER;Initial Catalog=EBanking;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from BranchMgr where UserName = @username", connection);
            cmd.Parameters.AddWithValue("@username", username);

            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if( dr.Read())
            {
                branchMgr = new BranchManager();
                branchMgr.BMId1 = dr[0].ToString();
                branchMgr.Name = dr[1].ToString();
                branchMgr.Address = dr[2].ToString();
                branchMgr.PhoneNumber = dr[3].ToString();
                branchMgr.UserName = dr[4].ToString();
                branchMgr.BranchCode = dr[5].ToString();                    
            }

            connection.Close();
            return branchMgr;
        }


        public DataSet SelectBMID()
       {
         
           DataSet table = new DataSet();
           SqlConnection connection = new SqlConnection(@"Data Source=PAVILION\SQLSERVER;Initial Catalog=EBanking;Integrated Security=True");
           SqlDataAdapter objda = new SqlDataAdapter("select BMID from BranchMgr", connection);         

           objda.Fill(table);
           return table;
       }

       public BranchManager SelectBranchMgr(string bmid)
       {
           SqlConnection connection = new SqlConnection(@"Data Source=PAVILION\SQLSERVER;Initial Catalog=EBanking;Integrated Security=True");
           SqlCommand  objda = new SqlCommand("select * from BranchMgr where BMID=@bmid", connection);
           objda.Parameters.AddWithValue("@bmid", bmid);

           connection.Open();
           SqlDataReader dr = objda.ExecuteReader();
           BranchManager branchmanager = new BranchManager();
           if (dr.Read())

           {
              
               branchmanager.BMId1 = dr[0].ToString();
               branchmanager.Name = dr[1].ToString();
               branchmanager.Address = dr[2].ToString();
               branchmanager.PhoneNumber=dr[3].ToString();
               branchmanager.UserName = dr[4].ToString();
               branchmanager.BranchCode = dr[5].ToString();

              
           }
           connection.Close();
           return branchmanager;  
       }
    }
}
