<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="ShowAd.aspx.cs" Inherits="CS412Final_Azzawie.ShowAd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid pt-5">
        <div class="row">
            <div class="text-center">
                <div class="card-header">
                    <h5>
                        <asp:Label ID="title" runat="server"></asp:Label></h5>
                </div>
                <span class="custom-badge">
                    <asp:Label ID="condition" runat="server"></asp:Label>
                </span>
                <div class="card-body">
                    <p class="card-text">
                        <asp:Label ID="description" runat="server"></asp:Label>
                    </p>

                </div>
                <div class="card-footer text-muted">
                    $<asp:Label ID="price" runat="server"></asp:Label>
                </div>

                <div>
                    <asp:Panel ID="panelLogin" runat="server" CssClass="submit-btn-container">
                        <asp:Button ID="btnEdit" runat="server" Text="Edit" CssClass="btn submit-btn" OnClick="btnEdit_Click" />
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="btn submit-btn" OnClick="btnDelete_Click" />
                    </asp:Panel>
                </div>
            </div>

            <div class="row">
                <asp:Panel CssClass="msgs-panel" HorizontalAlign="center" ID="msgPanel" runat="server" Visable="false">
                    <asp:Label ID="msgLbl" runat="server"></asp:Label>
                </asp:Panel>
            </div>
        </div>
    </div>
</asp:Content>
