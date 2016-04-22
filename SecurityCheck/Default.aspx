<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"  CodeBehind="Default.aspx.cs" Inherits="SecurityCheck._Default" Title="無題のページ" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1>既定のページ</h1>
<p>
    <span>ログイン時間</span>
    <asp:Label ID="LoginDateTime" runat="server"></asp:Label>
</p>

</asp:Content>
