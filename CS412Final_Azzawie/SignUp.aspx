<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="CS412Final_Azzawie.SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Sign Up</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid pt-5">
        <div class="row  bordered-card">
            <div class="col-md-3">
                <div class="form-content">
                    <i class="fa fa-address-card-o" aria-hidden="true"></i>
                    <label id="firstLbl" class="field-lable" for="<%= first.ClientID%>">First Name</label>
                    <asp:TextBox ID="first" runat="server" CssClass="form-control"></asp:TextBox>

                    <i class="fa fa-address-card-o" aria-hidden="true"></i>
                    <label class="field-lable" for="<%= last.ClientID%>">Last Name</label>
                    <asp:TextBox ID="last" runat="server" CssClass="form-control"></asp:TextBox>

                    <i class="fa fa-phone" aria-hidden="true"></i>
                    <label id="phoneLbl" class="field-lable" for="<%= phone.ClientID%>">Phone Number</label>
                    <asp:TextBox ID="phone" runat="server" CssClass="form-control" TextMode="Phone"></asp:TextBox>

                    <i class="fa fa-calendar" aria-hidden="true"></i>
                    <label id="dobLbl" class="field-lable" for="<%= dob.ClientID%>">Date of Birth</label>
                    <asp:TextBox ID="dob" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                </div>
            </div>

            <div class="col-md-3">
                <div class="form-content">
                    <i class="fa fa-envelope-o" aria-hidden="true"></i>
                    <label class="field-lable" for="<%= email.ClientID%>">Email</label>
                    <asp:TextBox ID="email" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>

                    <i class="fa fa-key" aria-hidden="true"></i>
                    <label class="field-lable" for="<%= password.ClientID%>">Password</label>
                    <asp:TextBox ID="password" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>

                    <i class="fa fa-key" aria-hidden="true"></i>
                    <label class="field-lable" for="<%= vpassword.ClientID%>">Verify Password</label>
                    <asp:TextBox ID="vpassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                </div>
            </div>

            <div class="col-md-3">
                <div>
                    <i class='fa fa-building	'></i>
                    <label class="field-lable" for="<%= city.ClientID%>">City</label>
                    <asp:TextBox ID="city" runat="server" CssClass="form-control"></asp:TextBox>

                    <i class="fa fa-flag-o" aria-hidden="true"></i>
                    <label class="field-lable" for="<%= state.ClientID%>">State</label>
                    <asp:TextBox ID="state" runat="server" CssClass="form-control"></asp:TextBox>

                    <i class='fa fa-qrcode'></i>
                    <label class="field-lable" for="<%= zipCode.ClientID%>">Zipcode Number</label>
                    <asp:TextBox ID="zipCode" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="col-md-3">
                <div>
                    <i class="fa fa-map-marker" aria-hidden="true"></i>
                    <label class="field-lable" for="<%= street1.ClientID%>">Address 1</label>
                    <asp:TextBox ID="street1" runat="server" CssClass="form-control"></asp:TextBox>

                    <i class="fa fa-map-marker" aria-hidden="true"></i>
                    <label class="field-lable" for="<%= street2.ClientID%>">Address 2</label>
                    <asp:TextBox ID="street2" runat="server" CssClass="form-control"></asp:TextBox>

                    <i class="fa fa-home"></i>
                    <label class="field-lable" for="<%= unitNumber.ClientID%>">Unit Number</label>
                    <asp:TextBox ID="unitNumber" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

            <asp:Panel ID="panelSignup" runat="server" CssClass="submit-btn-container">
                <asp:Button ID="btnSignup" runat="server" Text="Sign Up" CssClass="btn submit-btn" OnClick="btnSignup_Click" />
            </asp:Panel>
        </div>
        <div class="row">
            <asp:Panel CssClass="error-messages" HorizontalAlign="center" ID="msgPanel" runat="server" Visable="false">
                <asp:Label ID="msgLbl" runat="server"></asp:Label>
            </asp:Panel>
        </div>
    </div>
</asp:Content>
