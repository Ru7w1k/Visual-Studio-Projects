using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Branch
    {
        private string branchCode;
        private string state;
        private string city;
        private string pinCode;
        private string ifscCode;

        public string BranchCode
        {
            get { return branchCode; }
            set { branchCode = value; }
        }
        
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        
        public string PinCode
        {
            get { return pinCode; }
            set { pinCode = value; }
        }

        public string IfscCode
        {
            get { return ifscCode; }
            set { ifscCode = value; }
        }

    }
}
