<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginControl1.ascx.cs" Inherits="SecurityCheck.Shared.LoginControl1" %>
<asp:Panel ID="LoginPanel" runat="server" Visible="false">
    ���[�U�[��: <asp:Label ID="UserName" runat="server"></asp:Label>
    <asp:HyperLink ID="DoLogoutLink" runat="server" NavigateUrl="~/Account/LogoutForm.aspx">���O�A�E�g</asp:HyperLink>
</asp:Panel>
<asp:Panel ID="LogoutPanel1" runat="server" Visible="false">
    <asp:HyperLink ID="ForwardToLoginLink" runat="server" NavigateUrl="~/Account/LoginForm.aspx">���O�C��</asp:HyperLink>
</asp:Panel>
