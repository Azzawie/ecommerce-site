<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="UserAds.aspx.cs" Inherits="CS412Final_Azzawie.UserAds" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card-deck">
        <asp:Repeater ID="publicAds" runat="server" OnItemDataBound="publicAds_ItemDataBound">
            <ItemTemplate>
                <a href="ShowAd.aspx?id=<%#adId+1%>" class="a-ad-click">
                    <div class="card">
                        <!-- <img src="..." class="card-img-top" alt="...">-->

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
