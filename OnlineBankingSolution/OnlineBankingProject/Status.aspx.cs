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
    public partial class Status : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCheck_Click(object sender, EventArgs e)
        {
            if (TextBoxRegMobNo.Text.Length <= 0 || TextBoxRequestId.Text.Length <= 0)
            {
                LabelStatus.Text = "Enter Valid Information!";
                return;
            }

            Request request = new Request();

            request.RequestId = TextBoxRequestId.Text;
            request.MobileNumber = TextBoxRegMobNo.Text;
            

            RequestBL requestBL = new RequestBL();
            request = requestBL.CheckRequestStatus(request);

            if (request == null)
            {
                LabelStatus.Text = "No Such Request Found!";
            }
            else if(string.Equals(request.RequestStatus, "PENDING"))
            {
                LabelStatus.Text = "Your Request is still Pending!";
            }
            else if(string.Equals(request.RequestStatus, "REJECT"))
            {
                LabelStatus.Text = "Your Request is Rejected!";
            }
            else if(string.Equals(request.RequestStatus, "ACCEPT"))
            {
                // LabelStatus.Text = request.AccountNumber;
                Response.Redirect("SignUp.aspx?accNo=" + request.AccountNumber);

            }
            
            
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}