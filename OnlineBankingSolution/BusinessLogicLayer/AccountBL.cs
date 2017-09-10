using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class AccountBL
    {
        public Account GetAccountByAccNo(string accountNumber)
        {
            AccountDAL accountDAL = new AccountDAL();
            return accountDAL.GetAccount(accountNumber);
        }

        public bool ChangeAmount(Account account)
        {
            AccountDAL accountDAL = new AccountDAL();
            return accountDAL.UpdateAccount(account);
        }
    }
}
