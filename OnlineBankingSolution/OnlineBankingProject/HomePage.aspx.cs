using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EbankingWeb
{
    public partial class HomePage : System.Web.UI.Page
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
        }

        protected void login_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void ButtonStatus_Click(object sender, EventArgs e)
        {
            Response.Redirect("Status.aspx");
        }
    }
}