using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Transaction
    {
        private string transactionId;
        private string accountNumber;
        private string benificiaryId;
        private double amount;
        private DateTime transactionOn;

        public string TransactionId
        {
            get { return transactionId; }
            set { transactionId = value; }
        }        

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        
        public string BenificiaryId
        {
            get { return benificiaryId; }
            set { benificiaryId = value; }
        }

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public DateTime TransactionOn
        {
            get { return transactionOn; }
            set { transactionOn = value; }
        }        
    }
}
