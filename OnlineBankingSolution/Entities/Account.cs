using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Account
    {
        private string accountNumber;
        private string cifNumber;
        private string branchCode;
        private string requestId;
        private double balance;
        private string status;
        private string type;
        private string phoneNumber;

        private DateTime createdOn;
        private List<Benificiary> benificiaries;

        public Account()
        {
            benificiaries = new List<Benificiary>();           
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public List<Benificiary> Benificiaries
        {
            get { return benificiaries; }
            set { benificiaries = value; }
        }

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        
        public string CifNumber
        {
            get { return cifNumber; }
            set { cifNumber = value; }
        }
        
        public string BranchCode
        {
            get { return branchCode; }
            set { branchCode = value; }
        }
        
        public string RequestId
        {
            get { return requestId; }
            set { requestId = value; }
        }
                
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        
        public DateTime CreatedOn
        {
            get { return createdOn; }
            set { createdOn = value; }
        }

        public bool Withdraw(double amount)
        {
            if (amount <= 0 || (Balance-amount) < 0)
            {
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

        public bool Transfer(Benificiary benificiary, Account account, double amount)
        {
            if (Benificiaries.Contains(benificiary))
            {
                if (this.Withdraw(amount))
                {
                    return account.Deposite(amount);
                }
                else
                    return false;
            }
            else
            {
                return false;
            }
        }

        public bool Deposite(double amount)
        {
            Balance += amount;
            return true;
        }

        public bool AddBenificiary(Benificiary benificiary)
        {
            Benificiaries.Add(benificiary);
            return true;
        }
                
        public bool RemoveBenificiary(Benificiary benificiary)
        {
            return Benificiaries.Remove(benificiary);
        }
    }
}
