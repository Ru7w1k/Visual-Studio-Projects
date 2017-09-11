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
    public partial class AddBranchMgrDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userName = (string)Session["user"];
            if (string.IsNullOrEmpty(userName) || !Equals(Session["ut"], "ADMIN"))
            {
                Response.Redirect("Login.aspx");
            }

            if (!IsPostBack)
            {

                BranchBAL branchBAL = new BranchBAL();
                TextBoxBranchCode.DataSource = branchBAL.SelectAllBranchCode();
                TextBoxBranchCode.DataTextField = "BranchCode";
                TextBoxBranchCode.DataValueField = "BranchCode";
                TextBoxBranchCode.DataBind();

            }
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {

            if ( TextBoxName.Text.Length <= 0 
                || TextBoxAddress.Text.Length <= 0 
                || TextBoxPhoneNumber.Text.Length<=0 
                || TextBoxUserName.Text.Length <= 0 
                || TextBoxPassword.Text.Length <= 0)
            {                
                LabelStatus.Text = "Enter valid information!";
                return;
            }
            else
            {
                if (Convert.ToInt64(TextBoxPhoneNumber.Text) <= 0)
                {

                    LabelStatus.Text = "Enter valid information!";
                    return;
                }
            }

            AdminBAL adminbal = new AdminBAL();
            BranchManager branchmanager = new BranchManager();
            branchmanager.Name=TextBoxName.Text;
            branchmanager.Address = TextBoxAddress.Text;
            branchmanager.PhoneNumber = TextBoxPhoneNumber.Text;
            branchmanager.BranchCode = TextBoxBranchCode.SelectedItem.Text;
            branchmanager.UserName = TextBoxUserName.Text;
            branchmanager.Password = TextBoxPassword.Text;

            string bmid = adminbal.AddBranchManager(branchmanager);
            if (bmid == "DUPLICATE")
            {
                LabelStatus.Text = "Username already exist!";
            }
            else if(!string.IsNullOrEmpty(bmid))
            {
                LabelStatus.Text = "Added Successfully!";
                LabelBranchManagerID.Text = bmid;
            }


        }

        protected void ButtonClear_Click(object sender, EventArgs e)
        {
            
            TextBoxName.Text = string.Empty;
            TextBoxAddress.Text = string.Empty;
            TextBoxPhoneNumber.Text = string.Empty;
            TextBoxUserName.Text = string.Empty;
            TextBoxPassword.Text = string.Empty;
            TextBoxBranchCode.ClearSelection();
            LabelBranchManagerID.Text = "";
            LabelStatus.Text = "";
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHome.aspx");
        }
    }
}