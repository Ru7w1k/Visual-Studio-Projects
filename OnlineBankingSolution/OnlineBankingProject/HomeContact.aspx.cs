using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineBankingProject
{
    public partial class HomeContact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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