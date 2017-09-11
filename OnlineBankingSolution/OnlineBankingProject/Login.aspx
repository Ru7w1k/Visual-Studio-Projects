<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EbankingWeb.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="row">
    <div class="col-lg-4"></div>
    <div class="col-lg-4" style="align-items:center">
        <div class="panel panel-primary">
            <div class="panel-heading">Register For Online Banking</div>
            <div class="panel-body">
                <table style="border:none; align-items:flex-start">
                    <tr>
                        <td>Username : </td>
                        <td style="width:5px; white-space:pre">     </td>
                        <td><asp:TextBox ID="TextBoxUesrname" Width="120%" CssClass="form-control" runat="server" ></asp:TextBox></td>
                    </tr>

                    <tr>
                        <td>Password :</td>
                        <td style="width:5px; white-space:pre">     </td>
                        <td> <asp:TextBox ID="TextBoxPassword" Width="120%" CssClass="form-control" runat="server" TextMode="Password" ></asp:TextBox></td>
                    </tr>            
           
                </table>
            </div>
            <div class="panel-footer">
                <div class="btn-group btn-group-justified">
                    <asp:Button ID="ButtonLogin" CssClass="btn btn-block btn-primary" runat="server" Text="Login" OnClick="ButtonLogin_Click" />
                    <asp:Button ID="ButtonCancel" CssClass="btn btn-block btn-primary" runat="server" Text="Cancel" CausesValidation="false" OnClick="ButtonCancel_Click" />
                </div>
            </div>
            <center> <asp:Label ID="LabelStatus" runat="server"></asp:Label></center>
        </div>
     </div>
 </div>
</asp:Content>
