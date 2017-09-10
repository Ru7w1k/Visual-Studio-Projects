using System;
using System.Data;
using System.Data.OleDb;
using Entities;
using BusinessLogicLayer;
using System.Data.SqlClient;
using System.Web;

namespace ProjectDemo_Asp.et
{
    public partial class Default : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {            
              string userName = (string) Session["user"];
            if(string.IsNullOrEmpty(userName) || !Equals(Session["ut"], "ADMIN"))
            {
                Response.Redirect("Login.aspx");
            }

            if (!IsPostBack)
            {
                BranchBAL branchbal = new BranchBAL();
                DropDownSerchByName.DataSource = branchbal.SelectAllColumn();
                DropDownSerchByName.DataTextField = "name";
                DropDownSerchByName.DataValueField = "name";
                DropDownSerchByName.DataBind();

            }
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text.Length <= 0)
            {
                LabelStatus.Text = "Enter Valid Keyword!";
                return;
            }
            LabelStatus.Text = "";

            BranchBAL branchBAL = new BranchBAL();
            GridViewSearch.DataSource = branchBAL.GetDataFromDataBase(DropDownSerchByName.SelectedItem.Text, txtsearch.Text);
            GridViewSearch.DataBind();
            
        }


        protected void DropDownSerchByName_SelectedIndexChanged(object sender, EventArgs e)
        {   

        }

        protected void GridViewSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void txtsearch_TextChanged(object sender, EventArgs e)
        {
          
        }

        protected void ButtonLogout_Click(object sender, EventArgs e)
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

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHome.aspx");
        }
    }
}