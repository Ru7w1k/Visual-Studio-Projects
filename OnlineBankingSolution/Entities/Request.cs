using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Request
    {
        private string requestId;
        private string requestStatus;
        private string accountNumber;
        private DateTime registeredOn;
        private string branchCode;
        private string mobileNumber;

        public string RequestId
        {
            get { return requestId; }
            set { requestId = value; }
        }

        public string RequestStatus
        {
            get { return requestStatus; }
            set { requestStatus = value; }
        }

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public DateTime RegisteredOn
        {
            get { return registeredOn; }
            set { registeredOn = value; }
        }
        
        public string BranchCode
        {
            get { return branchCode; }
            set { branchCode = value; }
        }

        public string MobileNumber
        {
            get
            {
                return mobileNumber;
            }

            set
            {
                mobileNumber = value;
            }
        }
    }
}
