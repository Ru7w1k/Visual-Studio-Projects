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
    public partial class Statement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userName = (string)Session["user"];
            string accountNumber = (string)Session["accNo"];
            if (string.IsNullOrEmpty(userName) || !Equals(Session["ut"], "CUST"))
            {
                Response.Redirect("Login.aspx");
            }

            

            //TextBoxFrom.Text = DateTime.Now.Day + "-" +DateTime.Now.Month + "-" + DateTime.Now.Year;
            //TextBoxTo.Text   = DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year;
            if (!IsPostBack)
            {
                TransactionBL transactionBL = new TransactionBL();
                GridViewTransactions.DataSource = transactionBL.GetAllTransaction(new DateTime(1900, 1, 1), DateTime.Now, accountNumber);
                GridViewTransactions.DataBind();
                GridViewTransactions.HeaderRow.Height = 40;
                GridViewTransactions.FooterRow.Height = 40;
            }
                    
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
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

        protected void ButtonGo_Click(object sender, EventArgs e)
        {
            if (TextBoxFrom.Text.Length <= 0 || TextBoxTo.Text.Length <= 0)
                return;

            TransactionBL transactionBL = new TransactionBL();

            var from = TextBoxFrom.Text.Split('-');
            var to = TextBoxTo.Text.Split('-');

            GridViewTransactions.DataSource = transactionBL.GetAllTransaction(
                new DateTime(Convert.ToInt32(from[0]), Convert.ToInt32(from[1]), Convert.ToInt32(from[2])),
                new DateTime(Convert.ToInt32(to[0]), Convert.ToInt32(to[1]), Convert.ToInt32(to[2])),
                (string)Session["accNo"]);
            GridViewTransactions.DataBind();
            GridViewTransactions.HeaderRow.Height = 40;
            GridViewTransactions.FooterRow.Height = 40;
        }

        protected void ButtonClear_Click(object sender, EventArgs e)
        {
            TransactionBL transactionBL = new TransactionBL();
            GridViewTransactions.DataSource = transactionBL.GetAllTransaction(new DateTime(1900, 1, 1), DateTime.Now, (string)Session["accNo"]);
            GridViewTransactions.DataBind();
            GridViewTransactions.HeaderRow.Height = 40;
            GridViewTransactions.FooterRow.Height = 40;
        }
    }
}