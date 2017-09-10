using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using DataAccessLayer;
using System.Data;

namespace BusinessLogicLayer
{
   public class BranchBAL
    {
       public DataSet SelectAllColumn()
       {
            BranchDAL bdl = new BranchDAL();
            return bdl.SelectAllColumn();


        }

       public DataSet GetDataFromDataBase(string columnName, string searchtext)
       {
           BranchDAL bdl = new BranchDAL();
          return bdl.SelectDataFromDataBase(columnName, searchtext);
         
       }
       public DataSet SelectAllBranchCode()
       {
           BranchDAL bdl = new BranchDAL();
           return bdl.SelectAllBranchCode();
       }

    }
}
