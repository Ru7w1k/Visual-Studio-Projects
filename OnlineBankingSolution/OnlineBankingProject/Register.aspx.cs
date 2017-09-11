using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using Entities;

namespace EbankingWeb
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                RequestBL requestBl = new RequestBL();
                DropDownListBrachCode.DataSource = requestBl.GetAllBranchCode();
                DropDownListBrachCode.DataTextField = "BranchCode";
                DropDownListBrachCode.DataValueField = "BranchCode";
                DropDownListBrachCode.DataBind();
            }
        }

        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            if (TextBoxCIFNumber.Text.Length <= 0 
                || TextBoxRegMobNo.Text.Length <= 0 
                || TextBoxSBAccountNumber.Text.Length <= 0 
                || TextBoxRegMobNo.Text.Any(x => !char.IsDigit(x)) )
            {
                LabelStatus.Text = "Enter Valid Details!";
                return;
            }

            Request request = new Request();
            request.AccountNumber = TextBoxSBAccountNumber.Text;
            request.BranchCode = DropDownListBrachCode.SelectedItem.Text;
            request.RegisteredOn = DateTime.Now;
            request.MobileNumber = TextBoxRegMobNo.Text;
            
            RequestBL requestBL = new RequestBL();
            if (requestBL.IsValidRequest(request, TextBoxCIFNumber.Text))
            {
                string response = requestBL.AddRequest(request);
                if (string.Equals(response, "NULL"))
                {
                    LabelStatus.Text = "Request Unsuccessful..";
                }
                else
                {
                    LabelStatus.Text = "Request Successfull! Request ID is : " + response;
                }
            }
            else
            {
                LabelStatus.Text = "Invalid Details!";
            }
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}