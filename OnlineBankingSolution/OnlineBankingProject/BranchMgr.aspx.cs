using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using Entities;
using System.Data.SqlClient;

namespace EbankingWeb
{
    public partial class BranchMgr : System.Web.UI.Page
    {
        DataSet pendingRequests;
        protected void Page_Load(object sender, EventArgs e)
        {
            string userName = (string)Session["user"];
            if (string.IsNullOrEmpty(userName) || !Equals(Session["ut"], "BRMGR"))
            {
                Response.Redirect("Login.aspx");
            }

            string username = (string) Session["user"];
            BranchMgrBAL branchMgrBL = new BranchMgrBAL();
            BranchManager branchMgr = branchMgrBL.GetBranchManagerFromUserName(username);

            LabelBMID.Text = branchMgr.BMId1;
            LabelName.Text = branchMgr.Name;
            LabelAddress.Text = branchMgr.Address;
            LabelPhoneNumber.Text = branchMgr.PhoneNumber;
            LabelBranchCode.Text = branchMgr.BranchCode;
            
            RequestBL rbl = new RequestBL();
            if (branchMgr != null)
            {
                pendingRequests = rbl.GetAllPendingRequest(branchMgr.BranchCode);
                PendingReq.DataSource = pendingRequests;
                PendingReq.DataBind();
            }
            //RequestBL rbl2 = new RequestBL();
            //StatusReq.DataSource = rbl2.GetAllAcceptRequest(new DateTime(1900,01,01), DateTime.Now, "ACCE);
            //StatusReq.DataBind();
            
        }

        protected void PendingReq_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void StatusReq_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        protected void StatusBm_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void PendingReq_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            RequestBL rbl = new RequestBL();
            int index = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Accept")
            {
               
                rbl.EditRequest(pendingRequests.Tables[0].Rows[index][0].ToString() ,"ACCEPT");
                Response.Redirect("BranchMgr.aspx");
            }
            else if(e.CommandName == "Reject")
            {
                //Label1.Text = "Reject " + index;
                rbl.EditRequest(pendingRequests.Tables[0].Rows[index][0].ToString(), "REJECT");
                Response.Redirect("BranchMgr.aspx");
            }
        }

        protected void Logout_Click(object sender, EventArgs e)
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

            var from = TextBoxFrom.Text.Split('-');
            var to = TextBoxTo.Text.Split('-');
            RequestBL rbl2 = new RequestBL();
            StatusReq.DataSource = rbl2.GetAllAcceptRequest(
                new DateTime(Convert.ToInt32(from[0]), Convert.ToInt32(from[1]), Convert.ToInt32(from[2])),
                new DateTime(Convert.ToInt32(to[0]), Convert.ToInt32(to[1]), Convert.ToInt32(to[2])),
                StatusBm.SelectedItem.Text);
            StatusReq.DataBind();
            
        }

        protected void ButtonClear_Click(object sender, EventArgs e)
        {

        }
    }
}