using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using BusinessLogicLayer;

namespace EbankingWeb
{
    public partial class Transfer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userName = (string)Session["user"];
            string accountNumber = (string)Session["accNo"];
            if (string.IsNullOrEmpty(userName) || !Equals(Session["ut"], "CUST"))
            {
                Response.Redirect("Login.aspx");
            }

            if (!IsPostBack)
            {
                BenificiaryBL benificiaryBL = new BenificiaryBL();
                DropDownBeneficiaryAccountNummber.DataSource = benificiaryBL.GetAllBenAccountNo(accountNumber);
                DropDownBeneficiaryAccountNummber.DataTextField = "BAccNo";
                DropDownBeneficiaryAccountNummber.DataValueField = "Name";
                DropDownBeneficiaryAccountNummber.DataBind();
                DropDownBeneficiaryAccountNummber.ClearSelection();
                DropDownBeneficiaryAccountNummber.Items.Insert(0, new ListItem("-- Please select --", ""));
            }
        }

        protected void DropDownBeneficiaryAccountNummber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownBeneficiaryAccountNummber.SelectedIndex != 0)
                LabelBeneficiaryName.Text = DropDownBeneficiaryAccountNummber.SelectedItem.Value;
            else
                LabelBeneficiaryName.Text = "";
        }

        protected void ButtonTransfer_Click(object sender, EventArgs e)
        {            
            double amount;
            if(double.TryParse(TextBoxAmount.Text, out amount) && amount>=0 && amount <= 25000)
            {
                AccountBL accountBl = new AccountBL();
                Account from = accountBl.GetAccountByAccNo((string) Session["accNo"]);
                Account to = accountBl.GetAccountByAccNo(DropDownBeneficiaryAccountNummber.SelectedItem.Text);

                BenificiaryBL benBL = new BenificiaryBL();
                Benificiary ben = benBL.GetBenID(from.AccountNumber, to.AccountNumber);

                if(from.Withdraw(amount))
                {
                    if(to.Deposite(amount))
                    {
                        if (accountBl.ChangeAmount(from) && accountBl.ChangeAmount(to))
                        {
                            Transaction transaction = new Transaction();
                            transaction.AccountNumber = from.AccountNumber;
                            transaction.BenificiaryId = ben.BenificiaryID;
                            transaction.Amount = amount;
                            transaction.TransactionOn = DateTime.Now;

                            TransactionBL transactionBL = new TransactionBL();
                            transactionBL.AddTransaction(transaction);

                            LabelStatus.Text = "Transfer Successful!";
                        }
                    }
                    else
                    {
                        from.Withdraw(amount);
                        LabelStatus.Text = "Transfer Failed!";
                    }
                }
                else
                {
                    LabelStatus.Text = "Transfer Failed!";
                }

            }
            else
            {
                LabelStatus.Text = "Enter Valid Amount!";
            }
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customer.aspx");
        }

        protected void ButtonLogout_Click(object sender, EventArgs e)
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
    }
}