<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CS412Final_Azzawie.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br/>
    <div class="row">
        <div class="col">
            <div class="number-info">
                <div class="site-title">Ads Count: <span class="number-text">4</span></div>
            </div>
        </div>
        <div class="col">
            <div class="number-info">
                <div class="site-title">Your Ads: <span class="number-text">2</span></div>
            </div>
        </div>
    </div>
    <hr />
    <div class="row">
        <div class="col">
            <div class="data-content">
                <table class="table table-sm table-striped">
                    <thead>
                        <tr>
                            <th>Title</th>
                            <th>Short disc.</th>
                            <th>Price</th>
                            <th>Published at</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td><a href="#">New Iphone</a></td>
                            <td>New Iphone for sell</td>
                            <td>$150.00</td>
                            <td>05/30/2021</td>
                        </tr>
                        <tr>
                            <td><a href="#">New Samsung</a></td>
                            <td>New Samsung for sell</td>
                            <td>$120.00</td>
                            <td>05/28/2021</td>
                        </tr>
                        <tr>
                            <td><a href="#">FitBit</a></td>
                            <td>Used FitBit for sell</td>
                            <td>$90.00</td>
                            <td>05/01/2021</td>
                        </tr>
                        <tr>
                            <td><a href="#">Piano for sell</a></td>
                            <td>Piano for sell</td>
                            <td>$1200.00</td>
                            <td>05/22/2021</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>


</asp:Content>
