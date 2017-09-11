<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Home.Master" CodeBehind="Search.aspx.cs" Inherits="ProjectDemo_Asp.et.Default" %>

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
                <center>
                    <table>
                        <tr>
                            <td>Branch Details :</td> 
                            <td style="width:5px; white-space:pre">      </td> 
                            <td><asp:DropDownList ID="DropDownSerchByName" CssClass="form-control" runat="server" OnSelectedIndexChanged="DropDownSerchByName_SelectedIndexChanged">
                            </asp:DropDownList></td>
                            <td style="width:5px; white-space:pre">      </td>                        
                            <td><asp:TextBox ID="txtsearch" CssClass="form-control" runat="server" OnTextChanged="txtsearch_TextChanged"></asp:TextBox></td>
                            <td style="width:5px; white-space:pre">      </td>
                              <td> <asp:Button ID="ButtonSearch" runat="server" onclick="ButtonSearch_Click" Text="Search" CssClass="form-control" /></td>
                            <td style="width:5px; white-space:pre">      </td>
                           </tr>
                    </table>
                </center>
                </div>
                <div class="panel-body">
                    <center>
                    <asp:GridView ID="GridViewSearch" ShowHeaderWhenEmpty="true" runat="server" AutoGenerateColumns="true" EmptyDataText="There are no data records to display."
                BorderStyle="Solid" style="margin-top: 39px" OnSelectedIndexChanged="GridViewSearch_SelectedIndexChanged" Height="16px" Width="142px">
            <HeaderStyle BackColor="#66CCFF" />
        </asp:GridView>
                    </center>
                </div>
                <div class="panel-footer">
                    <center><asp:Label ID="LabelStatus" runat="server"></asp:Label></center>
                </div>
            </div>
        </div>
        <div class="col-lg-1"></div>
        <div class="col-lg-2">
            <div class="btn-group btn-group-justified">
                <asp:Button ID="ButtonLogout" runat="server" CssClass="btn btn-primary btn-block" Text="Log Out" OnClick="ButtonLogout_Click" />                
                <asp:Button ID="ButtonBack" runat="server" CssClass="btn btn-primary btn-block" Text="Back" OnClick="ButtonBack_Click" />
            </div>
        </div>
        <div class="col-lg-1"></div>
    </div>
</asp:Content>


  
