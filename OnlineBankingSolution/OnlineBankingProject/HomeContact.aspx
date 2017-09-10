<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="HomeContact.aspx.cs" Inherits="OnlineBankingProject.HomeContact" %>
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
    <div class="jumbotron">
  <div class="container">
    <div class="row">
        <div class="col-md-1"></div>
        <div class="col-md-7">
            <h1>Contact Us:</h1>
            <table>
                <tr>HEAD OFFICE:
                    <td>Flat no.2,Ronak Apts,Rambaug Colony,Paud Road,Pune-411038</td>
                    <td>020 25455304</td>
                </tr>
                <tr>
                    <td>Rutwik Choughule</td>                 
                    <td>+91 94048 31852</td>
                </tr>
                <tr>
                    <td>Atharva Madgulkar</td>
                    <td>+91 86258 88656</td>
                </tr>
                <tr>
                    <td>Janabai Dalave</td>
                    <td>+91 99606 61401</td>
                </tr>
            </table>
        </div>
        </div>
      </div>

        <div class="col-md-1"></div>
    </div>
</asp:Content>
