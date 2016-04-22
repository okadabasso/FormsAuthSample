<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="SecurityCheck.Account.LoginForm" Title="無題のページ" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Login ID="LoginUser" runat="server" OnAuthenticate="Login1_Authenticate">
    </asp:Login>

</asp:Content>
