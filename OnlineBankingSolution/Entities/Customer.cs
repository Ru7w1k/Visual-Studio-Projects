using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customer
    {
        private string cifNumber;
        private string name;
        private string address;
        private string phoneNumber;
        private string userName;
        private long accountNumber;

        public string CifNumber
        {
            get { return cifNumber; }
            set { cifNumber = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        
        public long AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

    }
}
