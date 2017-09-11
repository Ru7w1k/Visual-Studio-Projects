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
    public partial class AddBenificiary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userName = (string)Session["user"];
            if (string.IsNullOrEmpty(userName) || !Equals(Session["ut"],"CUST"))
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (TextBoxBenAccountNumber.Text.Length <= 0 || TextBoxName.Text.Length <= 0 || Int32.Parse(TextBoxBenAccountNumber.Text) <= 0 )
            {
                LabelStatus.Text = "Enter Valid Information!";
                return;                
            }

            BenificiaryBL benificiaryBL = new BenificiaryBL();
            Benificiary benificiary = new Benificiary();
            benificiary.Name = TextBoxName.Text;
            benificiary.AccountNumber = (string) Session["accNo"];
            benificiary.BaccountNumber = TextBoxBenAccountNumber.Text;
            string benificiaryId = benificiaryBL.AddBenificiary(benificiary);
            if (string.Equals(benificiaryId, "NULL"))
            {
                LabelStatus.Text = "Cannot Add Beneficiary!";
            }
            else if(string.Equals(benificiaryId, "NOBEN"))
            {
                LabelStatus.Text = "No Such Account Exist!";
            }
            else
            {
                LabelStatus.Text = "Beneficiary Added with ID : " + benificiaryId;
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
        
        protected void ButtonPrint_Click(object sender, EventArgs e)
        {

        }
    }
}