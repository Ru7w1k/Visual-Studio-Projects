using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class LoginBL
    {
        public bool CreateLogin(string userName, string password, string accountNumber)
        {
            Request req = new Request();
            req.AccountNumber = accountNumber;

            AccountDAL accountDAL = new AccountDAL();
            Account account = accountDAL.GetAccount(accountNumber);

            CustomerDAL customerDAL = new CustomerDAL();
            Customer customer = customerDAL.SelectCustomerByCIF(account.CifNumber);

            if (! string.IsNullOrEmpty(customer.UserName))
                return false;

            RequestDAL requestDAL = new RequestDAL();
            req = requestDAL.SelectRequestFromAccNo(req);
            req.MobileNumber = customer.PhoneNumber;
            if ((req != null) && string.Equals(req.RequestStatus, "ACCEPT"))
            {
                LoginDAL loginDAL = new LoginDAL();
                if (!loginDAL.CheckIfExist(userName))
                {
                    if(loginDAL.InsertLogin(userName, password, "CUST"))
                    {
                        return customerDAL.InsertUsername(customer, userName);
                    }
                }
            }
            return false;
        }

        public string Login(string username, string password)
        {
            if (username.Length >= 6 && password.Length >= 6)
            {
                LoginDAL login = new LoginDAL();
                return login.IsLoginValid(username, password);
            }
            else
                return "SHORT";
        }
    }
}
