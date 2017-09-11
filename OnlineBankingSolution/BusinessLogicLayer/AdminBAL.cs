using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using DataAccessLayer;

namespace BusinessLogicLayer
{
   public  class AdminBAL
    {
        public Admin GetAccountByUserName(string username)
        {
            AdminDAL adminDAL = new AdminDAL();
            return adminDAL.SelectAdminFromUserName(username);
        }

       public string AddBranchManager(BranchManager branchmanager)
       {
           AdminDAL adl=new AdminDAL();
           return adl.AddBranchManager(branchmanager);
         

       }
       public int DeleteRecord(BranchManager branchmanager)
       {
           AdminDAL adl = new AdminDAL();
           BranchMgrDAL branchMgrDAL = new BranchMgrDAL();
           branchmanager = branchMgrDAL.SelectBranchMgr(branchmanager.BMId1);
            //branchmanager.UserName = branchManager.UserName;
           return adl.DeleteRecord(branchmanager);


       }
       public int ModifyRecord(BranchManager branchmanager)
       {
           AdminDAL adl = new AdminDAL();
           return adl.ModifyRecord(branchmanager);
       }

       
    }
}
