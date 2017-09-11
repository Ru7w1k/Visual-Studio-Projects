using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class CustomerBL
    {
        public Customer GetCustomerFromCIF(string cifNumber)
        {
            CustomerDAL customerDAL = new CustomerDAL();
            return customerDAL.SelectCustomerByCIF(cifNumber);
        }

        public Customer GetCustomerFromUserName(string userName)
        {
            CustomerDAL customerDAL = new CustomerDAL();
            return customerDAL.SelectCustomerByUserName(userName);
        }
    }
}
