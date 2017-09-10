using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using System.Web.Security;

namespace EbankingWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Session.Clear();//clear session
                Session.Abandon();//Abandon session
                Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.Cache.SetNoStore();
            }

            string userCreated = Request.QueryString["usr"];
            if(string.Equals(userCreated, "created"))
            {
                LabelStatus.Text = "User Successfully Created!";
            }

        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (TextBoxUesrname.Text.Length <= 0 || TextBoxPassword.Text.Length <= 0 )
            {
                LabelStatus.Text = "Enter Valid Information!";
                return;
            }            

            LoginBL loginBL = new LoginBL();
            string userName = TextBoxUesrname.Text;
            string password = TextBoxPassword.Text;
            string response = loginBL.Login(userName, password);
            if (String.Equals(response, "FALSE"))
            {
                LabelStatus.Text = "Invalid username or password!";
            }
            else if(String.Equals(response, "SHORT"))
            {
                LabelStatus.Text = "Username and Password must contain 6 characters!"; 
            }
            else
            {
                if (string.Equals(response, "CUST"))
                {
                    Session["user"] = userName;
                    Session["ut"] = "CUST";
                    Response.Redirect("Customer.aspx");
                }
                else if (string.Equals(response, "ADMIN"))
                {
                    Session["ut"] = "ADMIN";
                    Session["user"] = userName;
                    Response.Redirect("AdminHome.aspx");
                }
                else if (string.Equals(response, "BRMGR"))
                {
                    Session["ut"] = "BRMGR";
                    Session["user"] = userName;
                    Response.Redirect("BranchMgr.aspx");
                }
            }
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}