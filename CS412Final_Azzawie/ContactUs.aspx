<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="CS412Final_Azzawie.ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Contact US</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid pt-5">
        <div class="row">
            <div class="form-content bordered-card" id="contact-us-block">
                <i class="fa fa-address-card-o" aria-hidden="true"></i>
                <label class="field-lable" for="<%= name.ClientID%>">Name</label>
                <asp:TextBox ID="name" runat="server" CssClass="form-control"></asp:TextBox>

                <i class="fa fa-envelope-o" aria-hidden="true"></i>
                <label class="field-lable" for="<%= email.ClientID%>">Email</label>
                <asp:TextBox ID="email" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>

                <i class="fa fa-phone" aria-hidden="true"></i>
                <label class="field-lable" for="<%= phone.ClientID%>">Phone</label>
                <asp:TextBox ID="phone" runat="server" CssClass="form-control" TextMode="Phone"></asp:TextBox>

                <i class="fa fa-commenting-o" aria-hidden="true"></i>
                <label class="field-lable" for="<%= comment.ClientID%>">Comments</label>
                <asp:TextBox ID="comment" runat="server" CssClass="form-control" TextMode="Email" Rows="5"></asp:TextBox>

                <asp:Panel ID="panelContactUs" runat="server" CssClass="submit-btn-container">
                    <asp:Button ID="btnContactUs" runat="server" Text="Send" CssClass="btn submit-btn" OnClick="btnContactUs_Click" />
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
