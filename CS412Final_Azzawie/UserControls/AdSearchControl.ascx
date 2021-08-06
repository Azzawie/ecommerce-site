<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdSearchControl.ascx.cs" Inherits="CS412Final_Azzawie.UserControls.AdSearchControl" %>

<asp:Panel ID="AdSearch" runat="server" CssClass="adSearchElement d-none">
    <asp:Label ID="BlankAd" runat="server" Text="Label" CssClass="d-none blankAdElement"></asp:Label>
    <asp:Panel ID="AdList" runat="server"></asp:Panel>
</asp:Panel>