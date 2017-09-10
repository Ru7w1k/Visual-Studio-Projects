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
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {            
            if(!IsPostBack)
                LabelAccountNumber.Text = Request.QueryString["accNo"];
        }

        protected void ButtonSignUp_Click(object sender, EventArgs e)
        {
            if(TextBoxUsername.Text.Length < 6)
            {
                LabelStatus.Text = "Username must be 6 or more characters long!";
            }
            else if(Password.Text.Length < 6)
            {
                Password.Text = "";
                ConfirmPass.Text = "";
                LabelStatus.Text = "Password must be 6 or more characters long!";
            }
            else if(! string.Equals(Password.Text, ConfirmPass.Text))
            {
                Password.Text = "";
                ConfirmPass.Text = "";
                LabelStatus.Text = "Password does not match!";
            }
            else
            {
                LoginBL loginbl = new LoginBL();
                if (loginbl.CreateLogin(TextBoxUsername.Text, Password.Text, LabelAccountNumber.Text))
                {
                    LabelStatus.Text = "User Created Successfully!";
                    
                    Response.Redirect("Login.aspx?usr=created");
                }
                else
                    LabelStatus.Text = "Cannot Create Username";
            }
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Status.aspx");
        }
    }
}