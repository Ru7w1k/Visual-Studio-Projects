using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Entities;


namespace BusinessLogicLayer
{
     public class BranchMgrBAL
    {
        public BranchManager GetBranchManagerFromUserName(string username)
        {
            BranchMgrDAL branchMgrDAL = new BranchMgrDAL();
            return branchMgrDAL.SelectBranchMgrFromUserName(username);
        }

         public DataSet SelectBMID ()
         {
             BranchMgrDAL bdl = new BranchMgrDAL();
             return bdl.SelectBMID();


         }

         public BranchManager GetBranchManager(string bmid)
         {
             BranchMgrDAL bdl = new BranchMgrDAL();
             return bdl.SelectBranchMgr(bmid);

         }
    }
}
