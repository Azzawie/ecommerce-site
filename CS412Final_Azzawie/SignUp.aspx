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
                    <label class="field-lable" for="first">First Name</label>
                    <input type="text" id="first" class="form-control" />

                    <i class="fa fa-address-card-o" aria-hidden="true"></i>
                    <label class="field-lable" for="last">Last Name</label>
                    <input type="text" id="last" class="form-control" />

                    <i class="fa fa-phone" aria-hidden="true"></i>
                    <label class="field-lable" for="phone">Phone Number</label>
                    <input type="tel" id="phone" class="form-control" />

                    <i class="fa fa-calendar" aria-hidden="true"></i>
                    <label class="field-lable" for="dob">Date of Birth</label>
                    <input type="date" id="dob" class="form-control" />
                </div>
            </div>

            <div class="col-md-3">
                <div class="form-content">
                    <i class="fa fa-envelope-o" aria-hidden="true"></i>
                    <label class="field-lable" for="email">Email</label>
                    <input type="email" id="email" class="form-control" />

                    <i class="fa fa-key" aria-hidden="true"></i>
                    <label class="field-lable" for="pass">Password</label>
                    <input type="password" id="pass" class="form-control" />

                    <i class="fa fa-key" aria-hidden="true"></i>
                    <label class="field-lable" for="vpass">Verify Password</label>
                    <input type="password" id="vpass" class="form-control" />
                </div>
            </div>
            <div class="col-md-3">
                <div>
                    <i class='fa fa-building	'></i>
                    <label class="field-lable" for="city">City</label>
                    <input type="text" id="city" class="form-control" />

                    <i class="fa fa-flag-o" aria-hidden="true"></i>
                    <label class="field-lable" for="state">State</label>
                    <input type="text" id="state" class="form-control" />

                    <i class='fa fa-qrcode'></i>
                    <label class="field-lable" for="zipCode">Zipcode Number</label>
                    <input type="text" id="zipCode" class="form-control" />
                </div>
            </div>

            <div class="col-md-3">
                <div>
                    <i class="fa fa-map-marker" aria-hidden="true"></i>
                    <label class="field-lable" for="street1">Address 1</label>
                    <input type="text" id="street1" class="form-control" />

                    <i class="fa fa-map-marker" aria-hidden="true"></i>
                    <label class="field-lable" for="street2">Address 2</label>
                    <input type="text" id="street2" class="form-control" />

                    <i class="fa fa-home"></i>
                    <label class="field-lable" for="unitNumber">Unit Number</label>
                    <input type="text" id="unitNumber" class="form-control" />
                </div>
            </div>
            <div class="submit-btn-container">
                <input type="submit" value="Sign Up" class="btn submit-btn" />
            </div>
        </div>
    </div>
</asp:Content>
