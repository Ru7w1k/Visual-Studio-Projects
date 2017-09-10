   <%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="EbankingWeb.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-lg-1"></div>
        <div class="col-lg-2">
            <div class="panel panel-info" align="center">
                <div class="panel-body">
                   <div class="btn-group btn-group-large">
                        <asp:Button ID="ButtonLogin" CssClass="btn btn-primary btn-block" runat="server" Text="Login" OnClick="login_Click"/> 
                        <asp:Button ID="ButtonRegister" CssClass="btn btn-primary btn-block" runat="server" Text="Register for OB" OnClick="ButtonRegister_Click"/>
                        <asp:Button ID="ButtonStatus" CssClass="btn btn-primary btn-block" runat="server" Text="Status" OnClick="ButtonStatus_Click"/>
                    </div>
                </div>
            </div>
        </div>
    
    <div class="jumbotron">
  <div class="container">
    <div class="row">
        <div class="col-lg-1"></div>
        <div class="col-lg-7">
            <p class="bg-info"><h1>Welcome To Our Bank India Ltd.</h1></p>
           <table>
                	 <h3 style ="color:red;"> READ THIS BEFORE APPLING FOR ONLINE BANKING!!! </h3>
<p>Access your bank website only by typing the URL in the address bar of your browser.
Be aware of downloading any malicious application from mobile application stores
(Google Playstore, Apple App Store, Blackberry App World, Ovi Store, Windows Marketplace etc) that are offering Online Banking.
Kindly check their authenticity before downloading, by contacting your Bank.
Do not click on any links in any e-mail message to access the site.
OBI or any of its representative never sends you email/SMS or calls you over phone to get your personal information, password or one time SMS (high security) password. Any such e-mail/SMS or phone call is an attempt to fraudulently withdraw money from your account through Internet Banking. Never respond to such email/SMS or phone call. Please report immediately on report dot phishing at sbi dot co dot in if you receive any such e-mail/SMS or Phone call. Please lock your user access immediately, if you have accidentally revealed your credentials.
Do not be lured if you receive an e-mail/SMS/phone call promising reward for providing your personal information or for updating your account details in the bank site.
<p style = "color:forestgreen;"> Having the following will improve your internet security: </p>
Newer version of Operating System with latest security patches.
Antivirus signatures applied
Scan your computer regularly with Antivirus to ensure that the system is Virus/Trojan free.
Change your Internet Banking password at periodical intervals.
Always check the last log-in date and time in the post login page.
Avoid accessing Internet banking accounts from cyber cafes or shared PCs.
After you have logged in, you will not be asked to provide your username and login password again. Also, you will not be asked to provide your CREDIT or DEBIT CARD details while using internet banking. If you get a message (such as through a pop-up) asking for such information, please do not provide this information no matter how 'genuine' the page appears to be. Such pop-ups are most likely the result of malwares infecting your computer. 
               Please take immediate steps to disinfect your device.</p>
            </table>
            </div>
            </div>
        </div>
      
        <div class="col-lg-1"></div>
    </div>

</asp:Content>
