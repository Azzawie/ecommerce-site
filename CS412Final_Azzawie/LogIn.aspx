<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="CS412Final_Azzawie.LogIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<title>Login</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid pt-5">
        <div class="row">

            <div class="form-content bordered-card" id="login-block">
                <i class="fa fa-envelope-o" aria-hidden="true"></i>
                <label class="field-lable" for="email">Email</label>
                <input type="email" id="email" class="form-control" />

                <i class="fa fa-key" aria-hidden="true"></i>
                <label class="field-lable" for="pass">Password</label>
                <input type="password" id="pass" class="form-control" />
                <div class="submit-btn-container">
                    <input type="submit" value="Login" class="btn submit-btn" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
