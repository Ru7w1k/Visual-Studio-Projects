<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="AddBranchMgrDetails.aspx.cs" Inherits="EbankingWeb.AddBranchMgrDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
        tr.spaceUnder > td {
            padding-bottom: 1em;
        }
    </style>
    </asp:Content>
    <asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="row">
        <div class="col-lg-1"></div>
        <div class="col-lg-7">
            <div class="panel panel-primary">
                <div class="panel-heading" style="align-content:center">
                    Branch Manger Details
                </div>
                <div class="panel-body">
                    <table style="align-items:flex-start; padding:4px">
                         <tr class="spaceUnder">
                            <td >BMID : </td>
                            <td style="width:5px; white-space:pre">     </td>
                            <td ><asp:Label ID="LabelBranchManagerID" runat="server" ></asp:Label></td>
                        </tr>
                                     
                        <tr class="spaceUnder">
                            <td > Name : </td>
                            <td style="width:5px; white-space:pre">     </td>
                            <td ><asp:TextBox ID="TextBoxName" CssClass="form-control" runat="server" Width="230%"></asp:TextBox></td>
                        </tr>
                        <tr class="spaceUnder">
                            <td > Address : </td>
                            <td style="width:5px; white-space:pre">     </td>
                            <td ><asp:TextBox ID="TextBoxAddress" CssClass="form-control" runat="server" Width="230%"></asp:TextBox></td>
                        </tr>
                        <tr class="spaceUnder">
                            <td >PhoneNumber : </td>
                             <td style="width:5px; white-space:pre">     </td>
                            <td ><asp:TextBox ID="TextBoxPhoneNumber" TextMode="Number" CssClass="form-control" runat="server" Width="230%"></asp:TextBox></td>
                        </tr>
                                <tr class="spaceUnder">
                            <td >UserName : </td>
                             <td style="width:5px; white-space:pre">     </td>
                            <td ><asp:TextBox ID="TextBoxUserName" CssClass="form-control" runat="server" Width="230%"></asp:TextBox></td>
                        </tr>  
                         <tr class="spaceUnder">
                            <td >Password : </td>
                            <td style="width:5px; white-space:pre">     </td>
                            <td ><asp:TextBox ID="TextBoxPassword" TextMode="Password" CssClass="form-control" runat="server" Width="230%"></asp:TextBox></td>
                        </tr> 
                         <tr class="spaceUnder">
                            <td >BranchCode : </td>
                            <td style="width:5px; white-space:pre">     </td>
                            <td ><asp:DropDownList ID="TextBoxBranchCode" CssClass="form-control" runat="server" ></asp:DropDownList></td>
                        </tr>          
                    </table>
                </div>
                <div class="panel-footer">
                                <div class="btn-group btn-group-justified">
                <div class="btn-group"><asp:Button ID="ButtonAdd" runat="server" CssClass="btn btn-primary btn-block" Text="Add" OnClick="ButtonAdd_Click" />               </div>
                <div class="btn-group"><asp:Button ID="ButtonClear" runat="server" CssClass="btn btn-primary btn-block" Text="Clear" OnClick="ButtonClear_Click" /></div>
                <div class="btn-group"><asp:Button ID="ButtonBack" runat="server" CssClass="btn btn-primary btn-block" Text="Back" OnClick="ButtonBack_Click" /></div>

                 </div>
            <center><asp:Label ID="LabelStatus" runat="server"></asp:Label></center>
                </div>
           </div>
            </div>
        <div class="col-lg-1"></div>
        <div class="col-lg-2">

        </div>
        <div class="col-lg-1"></div>
    </div>

        </asp:Content>
