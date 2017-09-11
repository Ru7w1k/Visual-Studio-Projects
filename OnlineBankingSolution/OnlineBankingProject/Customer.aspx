<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="EbankingWeb.Customer" %>
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
        <div class="panel panel-primary">
            <div class="panel-heading">
                User Information
            </div>
            <div class="panel-body">
                <table style="align-items:flex-start; padding:4px">
                    <tr class="spaceUnder">
                        <td >Name : </td>
                        <td style="width:5px; white-space:pre">     </td>
                        <td ><asp:Label ID="LabelName" runat="server"></asp:Label></td>
                    </tr>
                    <tr class="spaceUnder">
                        <td>Address : </td>
                        <td style="width:5px; white-space:pre">     </td>
                        <td><asp:Label ID="LabelAddress" runat="server"></asp:Label></td>
                    </tr>
                    <tr class="spaceUnder">
                        <td>Phone Number : </td>
                        <td style="width:5px; white-space:pre">     </td>
                        <td><asp:Label ID="LabelPhoneNumber" runat="server"></asp:Label></td>
                    </tr>
                    <tr class="spaceUnder">
                        <td>Account Number : </td>
                        <td style="width:5px; white-space:pre">     </td>
                        <td><asp:Label ID="LabelAccountNumber" runat="server"></asp:Label></td>
                    </tr>
                    <tr class="spaceUnder">
                        <td>CIF Number : </td>
                        <td style="width:5px; white-space:pre">     </td>
                        <td><asp:Label ID="LabelcifNumber" runat="server"></asp:Label></td>
                    </tr>
                    <tr class="spaceUnder">
                        <td>Branch Code : </td>
                        <td style="width:5px; white-space:pre">     </td>
                        <td><asp:Label ID="LabelBranchCode" runat="server"></asp:Label></td>
                    </tr>
                    <tr class="spaceUnder">
                        <td>Balance : </td>
                        <td style="width:5px; white-space:pre">     </td>
                        <td><asp:Label ID="LabelBalance" runat="server"></asp:Label></td>
                    </tr>
                    <tr class="spaceUnder">
                        <td>Type : </td>
                        <td style="width:5px; white-space:pre">     </td>
                        <td><asp:Label ID="LabelType" runat="server"></asp:Label></td>
                    </tr>
                    <tr class="spaceUnder">
                        <td>Created On : </td>
                        <td style="width:5px; white-space:pre">     </td>
                        <td><asp:Label ID="LabelCreatedOn" runat="server"></asp:Label></td>
                    </tr>
                    <tr class="spaceUnder">
                        <td>Status : </td>
                        <td style="width:5px; white-space:pre">     </td>
                        <td><asp:Label ID="LabelStatus" runat="server"></asp:Label></td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
    <div class="col-lg-1"></div>
    <div class="col-lg-2">
        <div class="btn-group btn-group-justified">
            <asp:Button ID="ButtonLogOut" CssClass="btn btn-block btn-primary" runat="server" OnClick="ButtonLogOut_Click" Text="Log Out" />
            <asp:Button ID="ButtonPrintStatement" CssClass="btn btn-block btn-primary" runat="server" OnClick="ButtonPrintStatement_Click" Text="Print Statement" />
            <asp:Button ID="ButtonAddBenificiary" CssClass="btn btn-block btn-primary" runat="server" OnClick="ButtonAddBenificiary_Click" Text="Add Benificiary" />
            <asp:Button ID="ButtonTransfer" CssClass="btn btn-block btn-primary" runat="server" OnClick="ButtonTransfer_Click" Text="Transfer Funds" />
        </div>
    </div>
    <div class="col-lg-1"></div>
</div>
    


</asp:Content>
