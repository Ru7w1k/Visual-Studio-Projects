using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Entities;

namespace BusinessLogicLayer
{
    public class TransactionBL
    {
        public bool AddTransaction(Transaction transaction)
        {
            TransactionDAL transactionDAL = new TransactionDAL();
            return transactionDAL.InsertTransaction(transaction);
        }

        public DataTable GetAllTransaction(DateTime from, DateTime to, string accountNumber)
        {
            TransactionDAL transactionDAL = new TransactionDAL();
            
            // these all are debit transcations 
            List<Transaction> transaction = transactionDAL.SelectAllTransaction(from, to, accountNumber);
            DataTable ds = new DataTable("transactions");
            ds.Columns.Add("Date", typeof(string));
            ds.Columns.Add("Narration", typeof(string));
            ds.Columns.Add("Debit", typeof(double));
            ds.Columns.Add("Credit", typeof(double));

            foreach (Transaction t in transaction)
            {
                ds.Rows.Add(t.TransactionOn.ToString(), "To " + t.BenificiaryId, t.Amount, 0);
            }

            transaction.Clear();
            transaction = transactionDAL.SelectAllTransactionCredit(from, to, accountNumber);
            foreach (Transaction t in transaction)
            {
                ds.Rows.Add(t.TransactionOn.ToString(), "From " + t.AccountNumber, 0, t.Amount);
            }

            AccountDAL accountDAL = new AccountDAL();
            Account account = accountDAL.GetAccount(accountNumber);
            ds.Rows.Add("BALANCE", "", 0, account.Balance);

            DataView dv = ds.DefaultView;
            dv.Sort = "Date";
            return dv.ToTable();
        }
    }
}
