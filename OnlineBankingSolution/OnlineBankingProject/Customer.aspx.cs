using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using BusinessLogicLayer;

namespace EbankingWeb
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userName = (string) Session["user"];
            if(string.IsNullOrEmpty(userName) || !Equals(Session["ut"], "CUST"))
            {
                Response.Redirect("Login.aspx");
            }
  

            CustomerBL customerBL = new CustomerBL();
            Entities.Customer customer = customerBL.GetCustomerFromUserName(userName);

            AccountBL accountBL = new AccountBL();
            Account account = accountBL.GetAccountByAccNo(customer.AccountNumber.ToString());

            LabelName.Text          = customer.Name;
            LabelAddress.Text       = customer.Address;
            LabelPhoneNumber.Text   = customer.PhoneNumber;
            LabelAccountNumber.Text = customer.AccountNumber.ToString();
            LabelcifNumber.Text     = customer.CifNumber;
            LabelBranchCode.Text    = account.BranchCode;
            LabelBalance.Text       = account.Balance.ToString();
            LabelType.Text          = account.Type;
            LabelCreatedOn.Text     = account.CreatedOn.ToString();
            LabelStatus.Text        = account.Status;            
        }

        protected void ButtonLogOut_Click(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Session.Clear();//clear session
                Session.Abandon();//Abandon session
                Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.Cache.SetNoStore();
            }
            Response.Redirect("HomePage.aspx");
        }

        protected void ButtonPrintStatement_Click(object sender, EventArgs e)
        {
            Session["accNo"] = LabelAccountNumber.Text;
            Response.Redirect("Statement.aspx");
        }

        protected void ButtonAddBenificiary_Click(object sender, EventArgs e)
        {
            Session["accNo"] = LabelAccountNumber.Text;
            Response.Redirect("AddBenificiary.aspx");
        }

        protected void ButtonTransfer_Click(object sender, EventArgs e)
        {
            Session["accNo"] = LabelAccountNumber.Text;
            Response.Redirect("Transfer.aspx");
        }
    }
}