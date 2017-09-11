<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="EbankingWeb.AdminHome" %>
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
                Admin Information
            </div>
            <div class="panel-body">
                <table style="align-items:flex-start; padding:4px">
                    <tr class="spaceUnder">
                        <td >AdminId : </td>
                        <td style="width:5px; white-space:pre">     </td>
                        <td ><asp:Label ID="AdminId" runat="server"></asp:Label></td>
                    </tr>
                    <tr class="spaceUnder">
                        <td>Name : </td>
                        <td style="width:5px; white-space:pre">     </td>
                        <td><asp:Label ID="Name" runat="server"></asp:Label></td>
                    </tr>
                    <tr class="spaceUnder">
                        <td>Address : </td>
                        <td style="width:5px; white-space:pre">     </td>
                        <td><asp:Label ID="Address" runat="server"></asp:Label></td>
                    </tr>
                    <tr class="spaceUnder">
                        <td>PhoneNumber : </td>
                        <td style="width:5px; white-space:pre">     </td>
                        <td><asp:Label ID="PhoneNumber" runat="server"></asp:Label></td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
    <div class="col-lg-1"></div>
    <div class="col-lg-2">
        <div class="btn-group btn-group-justified">                     
            <asp:Button ID="ButtonLogOut" CssClass="btn btn-block btn-primary" runat="server" OnClick="LogOut" Text="Log Out" />
            <asp:Button ID="ButtonAdd" CssClass="btn btn-block btn-primary" runat="server" OnClick="Add" Text="Add" />
            <asp:Button ID="ButtonModify" CssClass="btn btn-block btn-primary" runat="server" OnClick="Modify" Text="Modify" />
            <asp:Button ID="ButtonDelete" CssClass="btn btn-block btn-primary" runat="server" OnClick="Delete" Text="Delete" />
            <asp:Button ID="ButtonSearch" CssClass="btn btn-block btn-primary" runat="server" OnClick="Search" Text="Search" />   
        </div>
    </div>
    <div class="col-lg-1"></div>
    </div>

    </asp:Content>