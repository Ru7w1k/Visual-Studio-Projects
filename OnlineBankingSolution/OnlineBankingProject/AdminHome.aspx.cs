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
    public partial class AdminHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string userName = (string)Session["user"];
            if (string.IsNullOrEmpty(userName) || !Equals(Session["ut"], "ADMIN"))
            {
                Response.Redirect("Login.aspx");
            }

            AdminBAL adminBAL = new AdminBAL();
            Admin admin = adminBAL.GetAccountByUserName(userName);

            AdminId.Text = admin.AdminId;
            Name.Text = admin.Name;
            Address.Text = admin.Address;
            PhoneNumber.Text = admin.PhoneNumber;

        }

        protected void Search(object sender, EventArgs e)
        {
            Response.Redirect("Search.aspx");
        }

        protected void Add(object sender, EventArgs e)
        {
            Response.Redirect("AddBranchMgrDetails.aspx");
        }

        protected void Modify(object sender, EventArgs e)
        {
            Response.Redirect("ModifyDeleteBMD.aspx");
        }

        protected void Delete(object sender, EventArgs e)
        {
            Response.Redirect("ModifyDeleteBMD.aspx");

        }

        protected void LogOut(object sender, EventArgs e)
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