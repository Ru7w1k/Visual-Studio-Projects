using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Benificiary
    {
        private string benificiaryID;
        private string accountNumber;
        private string name;
        private string bAccountNumber;
        private double transactionLimit;

        public double TransactionLimit
        {
            get { return transactionLimit; }
            set { transactionLimit = value; }
        }
        
        public string BaccountNumber
        {
            get { return bAccountNumber; }
            set { bAccountNumber = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string BenificiaryID
        {
            get { return benificiaryID; }
            set { benificiaryID = value; }
        }

    }
}
