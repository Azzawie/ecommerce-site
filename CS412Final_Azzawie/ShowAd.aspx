<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="ShowAd.aspx.cs" Inherits="CS412Final_Azzawie.ShowAd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid pt-5">
        <div class="row">
            <div class="form-content bordered-card" id="contact-us-block">
            </div>

            <div class="row">
                <asp:Panel CssClass="msgs-panel" HorizontalAlign="center" ID="msgPanel" runat="server" Visable="false">
                    <asp:Label ID="msgLbl" runat="server"></asp:Label>
                </asp:Panel>
            </div>
        </div>
    </div>
</asp:Content>
