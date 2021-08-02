<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CS412Final_Azzawie.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>MarketPlace</title>
    <script src="Scripts/Home.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-2 search-bar">
        <asp:TextBox class="searchField" ID="adTitle" runat="server" placeholder = "Search by title"></asp:TextBox>
        <AdControl:AdSearchControl runat="server" ID="AdSearchControl" />
    </div>

    <div class="card-deck">
        <asp:Repeater ID="publicAds" runat="server" OnItemDataBound="publicAds_ItemDataBound">
            <ItemTemplate>
                <asp:HiddenField ID="adId" Value="" runat="server" />
                <a href="ShowAd.aspx?id=<%# Eval("Id")%>" class="a-ad-click">
                    <div class="card">
                        <span class="custom-badge">
                            <asp:Label ID="conition" runat="server" Text="Label"></asp:Label>
                        </span>
                        <div class="card-body">
                            <h5 class="card-title">
                                <asp:Label ID="title" runat="server" Text="Label"></asp:Label>
                            </h5>
                            <p class="card-text">
                                <asp:Label ID="desc" runat="server" Text="Label"></asp:Label>
                            </p>
                        </div>

                        <div class="card-footer">
                            <small class="text-muted">$
                            <asp:Label ID="price" runat="server" Text="Label"></asp:Label>
                            </small>
                        </div>
                    </div>
                </a>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
