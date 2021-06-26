<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="CreateAd.aspx.cs" Inherits="CS412Final_Azzawie.CreateAd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid pt-5">
        <div class="row">
            <div class="form-content bordered-card" id="contact-us-block">
                <!-- We might include a field for up load a picture -->
                <i class="fa fa-at" aria-hidden="true"></i>
                <label class="field-lable" for="<%= title.ClientID %>">Title</label>
                <asp:TextBox ID="title" runat="server" CssClass="form-control"></asp:TextBox>

                <i class="fa fa-money" aria-hidden="true"></i>
                <label class="field-lable" for="<%= price.ClientID %>">Price</label>
                <asp:TextBox ID="price" runat="server" CssClass="form-control"></asp:TextBox>

                <i class="fa fa-gift" aria-hidden="true"></i>
                <label class="field-lable" for="<%= condition.ClientID %>">Condition</label>

                <asp:DropDownList ID="condition" runat="server" CssClass="form-control">
                    <asp:ListItem Value="new" Text="New"></asp:ListItem>
                    <asp:ListItem Value="used" Text="Used"></asp:ListItem>
                    <asp:ListItem Value="damage" Text="Damage"></asp:ListItem>
                </asp:DropDownList>

                <i class="fa fa-list" aria-hidden="true"></i>
                <label class="field-lable" for="<%= description.ClientID %>">Description</label>
                <asp:TextBox ID="description" runat="server" CssClass="form-control" Rows="5"></asp:TextBox>

                <asp:Panel ID="panelCreateAd" runat="server" CssClass="submit-btn-container">
                    <asp:Button ID="btnCreateAd" runat="server" Text="Publish" CssClass="btn submit-btn" OnClick="btnCreateAd_Click" />
                </asp:Panel>
            </div>

            <div class="row">
                <asp:Panel CssClass="error-messages" HorizontalAlign="center" ID="msgPanel" runat="server" Visable="false">
                    <asp:Label ID="msgLbl" runat="server"></asp:Label>
                </asp:Panel>
            </div>
        </div>
    </div>
</asp:Content>
