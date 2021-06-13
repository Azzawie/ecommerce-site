<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="CreateAd.aspx.cs" Inherits="CS412Final_Azzawie.CreateAd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid pt-5">
        <div class="row">
            <div class="form-content bordered-card" id="contact-us-block">
                <!-- We might include a field for up load a picture -->
                <i class="fa fa-at" aria-hidden="true"></i>
                <label class="field-lable" for="title">Title</label>
                <input type="text" id="title" class="form-control" />

                <i class="fa fa-money" aria-hidden="true"></i>
                <label class="field-lable" for="price">Price</label>
                <input type="text" id="price" class="form-control" />

                <i class="fa fa-gift" aria-hidden="true"></i>
                <label class="field-lable" for="condidtion">Condidtion</label>
                <select class="form-control" id="condidtion">
                    <option value="new">New</option>
                    <option value="used">Used</option>
                    <option value="damaged">Damaged</option>
                </select>

                <i class="fa fa-list" aria-hidden="true"></i>
                <label class="field-lable" for="descrition">Descrition</label>
                <textarea id="descrition" rows="5" class="form-control"></textarea>

                <div class="submit-btn-container">
                    <input type="submit" value="Publish" class="btn submit-btn" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
