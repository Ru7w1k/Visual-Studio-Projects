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
    public partial class ModifyDeleteBMD : System.Web.UI.Page
    {

        protected void RefreshDropDown()
        {
            BranchMgrBAL branchbal = new BranchMgrBAL();
            TextBoxBMID.DataSource = branchbal.SelectBMID();
            TextBoxBMID.DataTextField = "BMID";
            TextBoxBMID.DataValueField = "BMID";
            TextBoxBMID.DataBind();

            BranchBAL branchBAL = new BranchBAL();
            TextBoxBranchCode.DataSource = branchBAL.SelectAllBranchCode();
            TextBoxBranchCode.DataTextField = "BranchCode";
            TextBoxBranchCode.DataValueField = "BranchCode";
            TextBoxBranchCode.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string userName = (string)Session["user"];
            if (string.IsNullOrEmpty(userName) || !Equals(Session["ut"], "ADMIN"))
            {
                Response.Redirect("Login.aspx");
            }

            if (!IsPostBack)
            {
                RefreshDropDown();
            }

        }

        protected void ButtonModify_Click(object sender, EventArgs e)
        {
            if (TextBoxBMID.Text.Length<=0 || TextBoxName.Text .Length <= 0 || TextBoxAddress.Text .Length <=0 || TextBoxPhoneNumber.Text.Length != 10 || Decimal.Parse(TextBoxPhoneNumber.Text) <= 0)
            {
                LabelStatus.Text = "Enter valid information!";
                return;
            }
            AdminBAL adminbal = new AdminBAL();
            BranchManager branchmanager = new BranchManager();
            branchmanager.BMId1 = TextBoxBMID.SelectedItem.Text;
            branchmanager.Name = TextBoxName.Text;
            branchmanager.Address = TextBoxAddress.Text;
            branchmanager.PhoneNumber = TextBoxPhoneNumber.Text;
            branchmanager.BranchCode = TextBoxBranchCode.Text;
            if (adminbal.ModifyRecord(branchmanager )==1)
            {
                LabelStatus.Text = "Modified Successfully!";
            }

        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            AdminBAL adminbal = new AdminBAL();
            BranchManager branchmanager = new BranchManager();
            branchmanager.BMId1 = TextBoxBMID.SelectedItem.Text;
            branchmanager.Name = TextBoxName.Text;
            branchmanager.Address = TextBoxAddress.Text;
            branchmanager.PhoneNumber = TextBoxPhoneNumber.Text;
            branchmanager.BranchCode = TextBoxBranchCode.Text;
            branchmanager.UserName = (string)Session["user"];
            if (1 == adminbal.DeleteRecord(branchmanager))
            {
                LabelStatus.Text = "Branch Manager Deleted!";
                RefreshDropDown();
            }
            else
            {

            }
        }

        protected void ButtonClear_Click(object sender, EventArgs e)
        {TextBoxBranchCode.ClearSelection();
            TextBoxName.Text = string.Empty;
            TextBoxAddress.Text = string.Empty;
            TextBoxPhoneNumber.Text = string.Empty;
            TextBoxBranchCode.ClearSelection();
        }

        protected void TextBoxBMID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BranchMgrBAL branchbal = new BranchMgrBAL();
            BranchManager branchmanager = branchbal.GetBranchManager(TextBoxBMID.SelectedItem.Text);
            TextBoxName.Text = branchmanager.Name;
            TextBoxAddress.Text = branchmanager.Address;
            TextBoxPhoneNumber.Text = branchmanager.PhoneNumber;
            TextBoxBranchCode.Text = branchmanager.BranchCode;
        }

        protected void TextBoxBranchCode_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHome.aspx");
        }
    }
}