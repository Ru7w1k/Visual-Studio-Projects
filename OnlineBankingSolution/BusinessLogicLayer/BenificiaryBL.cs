using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer;
using System.Data;

namespace BusinessLogicLayer
{
    public class BenificiaryBL
    {
        public Benificiary GetBenID(string accountNumber, string bAccountNumber)
        {
            BenificiaryDAL benDL = new BenificiaryDAL();
            return benDL.SelectBenificiary(accountNumber, bAccountNumber);
        }

        public DataTable GetAllBenAccountNo(string accountNumber)
        {
            BenificiaryDAL benificiaryDAL = new BenificiaryDAL();
            List<Benificiary> beneficiaries = benificiaryDAL.SelectAllBeneficiary(accountNumber);
            DataTable dt = new DataTable();
            dt.Columns.Add("BAccNo");
            dt.Columns.Add("Name");

            foreach (Benificiary ben in beneficiaries)
            {
                dt.Rows.Add(ben.BaccountNumber, ben.Name);
            }

            return dt;
        }

        public string AddBenificiary(Benificiary benificiary)
        {
            BenificiaryDAL benificiaryDAL = new BenificiaryDAL();

            AccountDAL accountDAL = new AccountDAL();        
            Account account = accountDAL.GetAccount(benificiary.BaccountNumber);

            CustomerDAL customerDAL = new CustomerDAL();
            Customer customer = customerDAL.SelectCustomerByCIF(account.CifNumber);

            if (string.Equals(customer.Name, benificiary.Name))
                return benificiaryDAL.InsertBenificiary(benificiary);
            else
                return "NOBEN";
        }
    }
}
