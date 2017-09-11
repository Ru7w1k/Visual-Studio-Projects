<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="EbankingWeb.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="row">
        <div class="col-lg-4"></div>
        <div class="col-lg-4" style="align-items:center">
            <div class="panel panel-primary">
                <div class="panel-heading">Sign Up</div>
                <div class="panel-body">
                    <table style="border:none; align-items:flex-start">
                        <tr>
                            <td>Account Number: </td>
                            <td style="width:5px; white-space:pre">     </td>
                            <td><asp:Label ID="LabelAccountNumber" runat="server"></asp:Label></td>
                        </tr>

                        <tr>
                            <td>Username :</td>
                            <td style="width:5px; white-space:pre">     </td>
                            <td><asp:TextBox ID="TextBoxUsername" CssClass="form-control" runat="server"></asp:TextBox></td>
                        </tr>
                        
                        <tr>
                            <td>Password :</td>
                            <td style="width:5px; white-space:pre">     </td>
                            <td><asp:TextBox ID="Password" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox></td>
                        </tr>
                        
                        <tr>
                            <td>Confirm Password :</td>
                            <td style="width:5px; white-space:pre">     </td>
                            <td><asp:TextBox ID="ConfirmPass" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox></td>
                        </tr>
                    </table>
                </div>
                <div class="panel-footer">
                    <div class="btn-group btn-group-justified">
                        <div class="btn-group"><asp:Button ID="ButtonSignUp" CssClass="btn btn-primary btn-block" Text="Sign Up" runat="server" OnClick="ButtonSignUp_Click"  /></div>
                        <div class="btn-group"><asp:Button ID="ButtonCancel" CssClass="btn btn-primary btn-block" Text="Cancel" runat="server" OnClick="ButtonCancel_Click" /></div>
                    </div>
                </div>
            <center><asp:Label ID="LabelStatus" runat="server"></asp:Label></center>
            </div>
        </div>
        <div class="col-lg-4"></div>
    </div>
</asp:Content>
