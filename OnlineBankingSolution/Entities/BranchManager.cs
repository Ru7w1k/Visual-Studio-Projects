using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class BranchManager
    {
        private string BMId;
        private string name;
        private string address;
        private string phoneNumber;
        private string userName;
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string branchCode;

        public string BMId1
        {
            get
            {
                return BMId;
            }

            set
            {
                BMId = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string BranchCode
        {
            get
            {
                return branchCode;
            }

            set
            {
                branchCode = value;
            }
        }

        public BranchManager()
        {

        }

        public BranchManager(  string  BMId,
         string name,
         string address,
         string phoneNumber,
         string userName,
         string password,
         string branchCode)
        {
            this.BMId = BMId;
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.userName = userName;
            this.branchCode = branchCode;
            this.password = password;
        }


    }
}
