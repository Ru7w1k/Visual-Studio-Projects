<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="EbankingWeb.Register" %>
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
                            <td>SB Account Number: </td>
                            <td style="width:5px; white-space:pre">     </td>
                            <td><asp:TextBox CssClass="form-control" ID="TextBoxSBAccountNumber" runat="server" ></asp:TextBox></td>
                        </tr>

                        <tr>
                            <td>CIF Number :</td>
                            <td style="width:5px; white-space:pre">     </td>
                            <td><asp:TextBox CssClass="form-control" ID="TextBoxCIFNumber" runat="server" ></asp:TextBox></td>
                        </tr>
                        
                        <tr>    
                            <td>Branch code :</td>
                            <td style="width:5px; white-space:pre">     </td>
                            <td><asp:DropDownList CssClass="form-control" ID="DropDownListBrachCode" runat="server" ></asp:DropDownList></td>
                        </tr>
                        
                        <tr>
                            <td>Registered Mobile No :</td>
                            <td style="width:5px; white-space:pre">     </td>
                            <td> <asp:TextBox CssClass="form-control" ID="TextBoxRegMobNo" runat="server" TextMode="Number" ></asp:TextBox></td>
                        </tr>
                    </table>
                </div>
                <div class="panel-footer">
                    <div class="btn-group btn-group-justified">
                        <asp:Button ID="ButtonRegister" CssClass="btn btn-block btn-primary" runat="server" Text="Register" OnClick="ButtonRegister_Click" />
                        <asp:Button ID="ButtonCancel" CssClass="btn btn-block btn-primary" runat="server" Text="Cancel" OnClick="ButtonCancel_Click" />
                    </div>
                </div>
            <center><asp:Label ID="LabelStatus" runat="server"></asp:Label></center>
            </div>
        </div>
        <div class="col-lg-4"></div>
    </div>


</asp:Content>
