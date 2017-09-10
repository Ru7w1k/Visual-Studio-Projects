using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BranchDAL
    {
        public DataSet SelectDataFromDataBase(string columnName, string searchtext)
        {
            string query = null;
            if (columnName == "BranchCode" || columnName == "PinCode" || columnName == "IFSCCode")
                query = "select * from Branch where " + columnName + " = " + searchtext;
            else
                query = "select * from Branch where " + columnName + " like '%" + searchtext + "%'";
            DataSet table = new DataSet();
            SqlConnection connection = new SqlConnection(@"Data Source=PAVILION\SQLSERVER;Initial Catalog=EBanking;Integrated Security=True");
            SqlDataAdapter objda = new SqlDataAdapter(query, connection);
            //objda.SelectCommand.Parameters.AddWithValue("@col", columnName);
            //objda.SelectCommand.Parameters.AddWithValue("@val", searchtext);
            try
            {
                objda.Fill(table);
            }
            catch (Exception e)
            {
                return null;

            }
            return table;
        }

        public DataSet SelectAllColumn()
        {
            DataSet ds = new DataSet();
            SqlConnection conn = new SqlConnection(@"Data Source=PAVILION\SQLSERVER;Initial Catalog=EBanking;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select name from sys.columns where object_id = OBJECT_ID('dbo.Branch')", conn);
            da.Fill(ds);
            return ds;
        }

        public DataSet SelectAllBranchCode()
        {
            DataSet ds = new DataSet();
            SqlConnection conn = new SqlConnection(@"Data Source=PAVILION\SQLSERVER;Initial Catalog=EBanking;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select BranchCode from Branch", conn);
            da.Fill(ds);
            return ds;
        }
    }
}
