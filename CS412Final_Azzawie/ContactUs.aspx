<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="CS412Final_Azzawie.ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Contact US</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid pt-5">
        <div class="row">
            <div class="form-content bordered-card" id="contact-us-block">
                <i class="fa fa-address-card-o" aria-hidden="true"></i>
                <label class="field-lable" for="name">Name</label>
                <input type="text" id="name" class="form-control" />

                <i class="fa fa-envelope-o" aria-hidden="true"></i>
                <label class="field-lable" for="email">Email</label>
                <input type="email" id="email" class="form-control" />

                <i class="fa fa-phone" aria-hidden="true"></i>
                <label class="field-lable" for="phone">Phone</label>
                <input type="tel" id="phone" class="form-control" />

                <i class="fa fa-commenting-o" aria-hidden="true"></i>
                <label class="field-lable" for="comment">Comments</label>
                <textarea id="comment" rows="5" class="form-control"></textarea>

                <div class="submit-btn-container">
                    <input type="submit" value="Send" class="btn submit-btn" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
