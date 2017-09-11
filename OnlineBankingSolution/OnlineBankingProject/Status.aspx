<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Status.aspx.cs" Inherits="EbankingWeb.Status" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-4"></div>
        <div class="col-lg-4" style="align-items:center">
            <div class="panel panel-primary">
                <div class="panel-heading">Check Status</div>
                <div class="panel-body">
                    <table style="border:none; align-items:flex-start">
                        <tr>
                            <td>Request Id:</td>
                            <td style="width:5px; white-space:pre">     </td>
                            <td><asp:TextBox ID="TextBoxRequestId" TextMode="Number" CssClass="form-control" runat="server" ></asp:TextBox></td>
                        </tr>

                        <tr>
                            <td>Registered Mobile No:</td>
                            <td style="width:5px; white-space:pre">     </td>
                            <td><asp:TextBox ID="TextBoxRegMobNo" TextMode="Number" CssClass="form-control" runat="server" ></asp:TextBox></td>
                        </tr>
                    </table>
                </div>
                <div class="panel-footer">
                    <div class="btn-group btn-group-justified">
                        <div class="btn-group"><asp:Button ID="ButtonCheck" CssClass="btn btn-primary btn-block" Text="Check" runat="server" OnClick="ButtonCheck_Click" /></div>
                        <div class="btn-group"><asp:Button ID="ButtonCancel" CssClass="btn btn-primary btn-block" Text="Cancel" runat="server" OnClick="ButtonCancel_Click" /></div>
                    </div>
                </div>
            <center><asp:Label ID="LabelStatus" runat="server"></asp:Label></center>
            </div>
        </div>
        <div class="col-lg-4"></div>
    </div>
</asp:Content>
