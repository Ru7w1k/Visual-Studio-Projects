<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="BranchMgr.aspx.cs" Inherits="EbankingWeb.BranchMgr" %>
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
                Pending Request Details
            </div>
            <div class="panel-body">
                 <asp:GridView ID="PendingReq" runat="server" CellPadding="3" Height="16px"  Width="725px" OnSelectedIndexChanged="PendingReq_SelectedIndexChanged" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" EmptyDataText="-- No Such Request --" OnRowCommand="PendingReq_RowCommand" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Req_Id" HeaderText="Request ID" />
                <asp:BoundField DataField="Name" HeaderText="Name of the Customer" />
                <asp:BoundField DataField="Acc_No" HeaderText="Account Number" />
                <asp:BoundField DataField="Req_On" HeaderText="Requested On" />
                <asp:ButtonField ButtonType="Button" ControlStyle-CssClass="btn-success" CommandName="Accept" Text="Approve" />
                <asp:ButtonField ButtonType="Button" ControlStyle-CssClass="btn-danger" CommandName="Reject" Text="Reject" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
            </div>
        </div>

        <div class="panel panel-primary">
            <div class="panel-heading">
                     <center>
                    <table>
                        <tr>
                            <td>From :</td> <td style="width:5px; white-space:pre">      </td> 
                            <td> <asp:TextBox ID="TextBoxFrom" CssClass="form-control" TextMode="Date" runat="server"></asp:TextBox></td>
                            <td style="width:5px; white-space:pre">      </td>                        
                            <td>To : </td><td style="width:5px; white-space:pre">      </td>  <td><asp:TextBox ID="TextBoxTo" CssClass="form-control" TextMode="Date" runat="server"></asp:TextBox></td>
                            <td style="width:5px; white-space:pre">      </td>
                                 <asp:DropDownList ID="StatusBm" runat="server" CssClass="form-control" OnSelectedIndexChanged="StatusBm_SelectedIndexChanged">
                    <asp:ListItem>ACCEPT</asp:ListItem>
                    <asp:ListItem>REJECT</asp:ListItem>
                </asp:DropDownList><td style="width:5px; white-space:pre">      </td>
                            <td><asp:Button ID="ButtonGo" CssClass="btn btn-default" runat="server" Text="Go" OnClick="ButtonGo_Click"/></td>
                            <td style="width:5px; white-space:pre">      </td>
                            <td><asp:Button ID="ButtonClear" CssClass="btn btn-default" runat="server" Text="Clear" OnClick="ButtonClear_Click"/></td>
                        </tr>
                    </table>
                </center>
           
            </div>
            <div class="panel-body">
                  <asp:GridView ID="StatusReq" runat="server" CellPadding="3"  Width="722px" OnSelectedIndexChanged="StatusReq_SelectedIndexChanged" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" Height="95px" AutoGenerateColumns="False" EmptyDataText="-- No Such Requests --">
            <Columns>
                <asp:BoundField DataField="Req_Id" HeaderText="Request ID" />
                <asp:BoundField DataField="Name" HeaderText="Name of the Customer" />
                <asp:BoundField DataField="Acc_No" HeaderText="Account Number" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
                </div>
            </div>
        </div>

    <div class="col-lg-1"></div>
    <div class="col-lg-2">
        <div class="btn-group btn-group-justified">
            <table style="align-items:flex-start; padding:4px">
                    <tr class="spaceUnder">
                        <td >Branch Manager ID : </td>
                        <td style="width:5px; white-space:pre">     </td>
                        <td ><asp:Label ID="LabelBMID" runat="server"></asp:Label></td>
                    </tr>
                    <tr class="spaceUnder">
                        <td>Name : </td>
                        <td style="width:5px; white-space:pre">     </td>
                        <td><asp:Label ID="LabelName" runat="server"></asp:Label></td>
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
                        <td>Branch Code : </td>
                        <td style="width:5px; white-space:pre">     </td>
                        <td><asp:Label ID="LabelBranchCode" runat="server"></asp:Label></td>
                    </tr>
                </table>
                <asp:Button ID="Logout" runat="server" CssClass="btn btn-block btn-primary" OnClick="Logout_Click" Text="Logout" />
        </div>
    </div>
    <div class="col-lg-1"></div>
</div>
</asp:Content>
