<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Transfer.aspx.cs" Inherits="EbankingWeb.Transfer" EnableViewState="true"%>
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
                <div class="panel-heading" style="align-content:center">
                    Transfer Funds
                </div>
                <div class="panel-body">
                    <table style="align-items:flex-start; padding:4px">
                        <tr class="spaceUnder">
                            <td >Benificiary Account Numer : </td>
                            <td style="width:5px; white-space:pre">     </td>
                            <td ><asp:DropDownList ID="DropDownBeneficiaryAccountNummber" runat="server" Width="230%" AutoPostBack="True" OnSelectedIndexChanged="DropDownBeneficiaryAccountNummber_SelectedIndexChanged"></asp:DropDownList></td>
                        </tr>
                        <tr class="spaceUnder">
                            <td >Benificiary Name : </td>
                            <td style="width:5px; white-space:pre">     </td>
                            <td ><asp:Label ID="LabelBeneficiaryName" runat="server" Width="230%"></asp:Label></td>
                        </tr>
                        <tr class="spaceUnder">
                            <td >Amount : </td>
                            <td style="width:5px; white-space:pre">     </td>
                            <td ><asp:TextBox ID="TextBoxAmount" runat="server" Width="230%" TextMode="Number" required></asp:TextBox></td>
                        </tr>        
                    </table>
                </div>
                <div class="panel-footer">
                     <div class="btn-group btn-group-justified">
                        <div class="btn-group"><asp:Button ID="ButtonTransfer" CssClass="btn btn-primary btn-block" Text="Transfer" runat="server" OnClick="ButtonTransfer_Click"  /></div>
                        <div class="btn-group"><asp:Button ID="ButtonCancel" CssClass="btn btn-primary btn-block" Text="Cancel" runat="server" OnClick="ButtonCancel_Click" /></div>
                    </div>
                </div>

            </div>
            <center><asp:Label ID="LabelStatus" runat="server" Text=""></asp:Label></center>
        </div>
        <div class="col-lg-1"></div>
        <div class="col-lg-2">
            <div class="btn-group btn-group-justified">
                <asp:Button ID="ButtonLogout" runat="server" CssClass="btn btn-primary btn-block" Text="Log Out" OnClick="ButtonLogout_Click" />               
            </div>
        </div>
        <div class="col-lg-1"></div>
    </div>
</asp:Content>
