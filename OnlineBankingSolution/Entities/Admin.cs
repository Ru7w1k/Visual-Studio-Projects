using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Admin
    {
        private string adminId;
        private string name;
        private string address;
        private string phoneNumber;
        private string userName;

        public string AdminId
        {
            get
            {
                return adminId;
            }

            set
            {
                adminId = value;
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

        //public int AddBranchManager(BranchManager Branchmanager)
        //{
            


        //    }
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
    }
}