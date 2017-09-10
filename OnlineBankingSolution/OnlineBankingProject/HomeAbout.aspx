<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="HomeAbout.aspx.cs" Inherits="OnlineBankingProject.HomeAbout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <div class="col-md-1"></div>
        <div class="col-md-2">
            <div class="panel panel-info" align="center">
                <div class="panel-body">
                   <div class="btn-group btn-group-large">
                        <asp:Button ID="ButtonLogin" CssClass="btn btn-primary btn-block" runat="server" Text="Login" OnClick="login_Click"/> 
                        <asp:Button ID="ButtonRegister" CssClass="btn btn-primary btn-block" runat="server" Text="Register for OB" OnClick="ButtonRegister_Click"/>
                        <asp:Button ID="ButtonStatus" CssClass="btn btn-primary btn-block" runat="server" Text="Status" OnClick="ButtonStatus_Click"/>
                    </div>
                </div>
            </div>
        </div>
    </div>
   </div>
  <div class="jumbotron">
  <div class="container">
    <div class="row">
        <div class="col-md-1"></div>
        <div class="col-md-7">
            <div class="panel panel-primary"><p>This Application is developed by Rutwik Chaughule, 
                Atharva Madgulkar and 
                Jenny Dalave
                who are persuing their Computer Engineering Degree from Marathwada Mitra Mandal's College Of Engineering,Pune.</p></div>
        </div>
        </div>
      </div>
     
        <div class="col-md-1"></div>
    </div>
</asp:Content>
