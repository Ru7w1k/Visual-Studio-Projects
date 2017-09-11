<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Statement.aspx.cs" Inherits="EbankingWeb.Statement" EnableViewState="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
                            <td>From :</td> <td style="width:5px; white-space:pre">      </td> 
                            <td> <asp:TextBox ID="TextBoxFrom" CssClass="form-control" TextMode="Date" runat="server"></asp:TextBox></td>
                            <td style="width:5px; white-space:pre">      </td>                        
                            <td>To : </td><td style="width:5px; white-space:pre">      </td>  <td><asp:TextBox ID="TextBoxTo" CssClass="form-control" TextMode="Date" runat="server"></asp:TextBox></td>
                            <td style="width:5px; white-space:pre">      </td>
                            <td><asp:Button ID="ButtonGo" CssClass="btn btn-default" runat="server" Text="Go" OnClick="ButtonGo_Click"/></td>
                            <td style="width:5px; white-space:pre">      </td>
                            <td><asp:Button ID="ButtonClear" CssClass="btn btn-default" runat="server" Text="Clear" OnClick="ButtonClear_Click"/></td>
                        </tr>
                    </table>
                </center>
                </div>
                <div class="panel-body">
                    <center>
                    <asp:GridView ID="GridViewTransactions" runat="server" CellPadding="4" ForeColor="Black" GridLines="Horizontal" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" >
                        <Columns>
                            <asp:BoundField DataField="Date" HeaderText="Date">
                            <ItemStyle Width="100px" HorizontalAlign="Left"/>
                            </asp:BoundField>
                            <asp:BoundField DataField="Narration" HeaderText="Narration">
                            <ItemStyle Width="300px" HorizontalAlign="Left"/>
                            </asp:BoundField>
                            <asp:BoundField DataField="Debit" HeaderText="Debit">
                            <ItemStyle Width="100px" HorizontalAlign="Right"/>
                            </asp:BoundField>
                            <asp:BoundField DataField="Credit" HeaderText="Credit">
                            <ItemStyle Width="100px" HorizontalAlign="Right"/>
                            </asp:BoundField>
                        </Columns>
                        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" HorizontalAlign="Center"/>                       
                        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F7F7F7" />
                        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                        <SortedDescendingCellStyle BackColor="#E5E5E5" />
                        <SortedDescendingHeaderStyle BackColor="#242121" />
                    </asp:GridView>
                    </center>
                </div>
            </div>
        </div>
        <div class="col-lg-1"></div>
        <div class="col-lg-2">
            <div class="btn-group btn-group-justified">
                <asp:Button ID="ButtonLogout" runat="server" CssClass="btn btn-primary btn-block" Text="Log Out" OnClick="ButtonLogout_Click" />                
                <asp:Button ID="ButtonPrint" runat="server" CssClass="btn btn-primary btn-block" Text="Print" OnClientClick="javascript:window.print()"/>
                <asp:Button ID="ButtonBack" runat="server" CssClass="btn btn-primary btn-block" Text="Back" OnClick="ButtonBack_Click" />
            </div>
        </div>
        <div class="col-lg-1"></div>
    </div>
</asp:Content>
