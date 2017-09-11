<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="AddBenificiary.aspx.cs" Inherits="EbankingWeb.AddBenificiary" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
        tr.spaceUnder > td {
            padding-bottom: 1em;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="row">
        <div class="col-lg-1"></div>
        <div class="col-lg-7">
            <div class="panel panel-warning">
                <div class="panel-heading" style="align-content:center">
                    Add Benificiary
                </div>
                <div class="panel-body">
                    <table style="align-items:flex-start; padding:4px">
                        <tr class="spaceUnder">
                            <td >Benificiary Name : </td>
                            <td style="width:5px; white-space:pre">     </td>
                            <td ><asp:TextBox ID="TextBoxName" CssClass="form-control" runat="server" Width="230%"></asp:TextBox></td>
                        </tr>
                        <tr class="spaceUnder">
                            <td >Benificiary Account Number : </td>
                            <td style="width:5px; white-space:pre">     </td>
                            <td ><asp:TextBox ID="TextBoxBenAccountNumber" TextMode="Number" CssClass="form-control" runat="server" Width="230%"></asp:TextBox></td>
                        </tr>
                        <tr class="spaceUnder">
                            <td >Transfer Limit : </td>
                            <td style="width:5px; white-space:pre">     </td>
                            <td ><asp:Label ID="LabelTransferLimit" runat="server" Text="25000"></asp:Label></td>
                        </tr>
                                           
                    </table>
                </div>
                <div class="panel-footer">
                     <div class="btn-group btn-group-justified">
                        <div class="btn-group"><asp:Button ID="ButtonAdd" CssClass="btn btn-primary btn-block" Text="Add" runat="server" OnClick="ButtonAdd_Click"  /></div>
                        <div class="btn-group"><asp:Button ID="ButtonCancel" CssClass="btn btn-primary btn-block" Text="Cancel" runat="server" OnClick="ButtonCancel_Click" /></div>
                    </div>
                </div>

            </div>
            <center><asp:Label ID="LabelStatus" runat="server"></asp:Label></center>
        </div>
        <div class="col-lg-1"></div>
        <div class="col-lg-2">
            <div class="btn-group btn-group-justified">
                <asp:Button ID="ButtonLogout" runat="server" CssClass="btn btn-primary btn-block" Text="Log Out"  CausesValidation="false" OnClick="ButtonLogout_Click" />               
                <asp:Button ID="ButtonPrint" runat="server" CssClass="btn btn-primary btn-block" Text="Print" OnClick="ButtonPrint_Click" />
            </div>
        </div>
        <div class="col-lg-1"></div>
    </div>
</asp:Content>
