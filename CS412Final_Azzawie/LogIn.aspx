<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="CS412Final_Azzawie.LogIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Login</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid pt-5">
        <div class="row">
            <div class="form-content bordered-card" id="login-block">
                <i class="fa fa-envelope-o" aria-hidden="true"></i>
                <label id="emailLbl" class="field-lable" for="<%= email.ClientID%>">Email</label>
                <asp:TextBox ID="email" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>

                <i class="fa fa-key" aria-hidden="true"></i>
                <label class="field-lable" for="<%= password.ClientID %>">Password</label>
                <asp:TextBox ID="password" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>

                <asp:Panel ID="panelLogin" runat="server" CssClass="submit-btn-container">
                    <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn submit-btn" OnClick="btnLogin_Click" />
                </asp:Panel>
            </div>

            <div class="row">
                <asp:Panel CssClass="error-messages" HorizontalAlign="center" ID="errorsPanel" runat="server" Visable="false">
                    <asp:Label ID="errorsLbl" runat="server"></asp:Label>
                </asp:Panel>
            </div>
        </div>
    </div>
</asp:Content>


