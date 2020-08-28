<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Website.Master"
    CodeBehind="ForgotPassword.aspx.vb" Inherits="University_Website.ForgotPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row" style="height: 480px;">
        <div class="row">
            <h2 id="logo" class="h2">
                Forgot Password</h2>
            <hr />
            <div class="col-lg-12">
                Hey there! Did you forgot your password? Don't worry, We're here to help you
            </div>
        </div>
        <div class="row" style="margin-top: 3%">
            <div class="col-lg-4">
                <label>
                    Enter your email address :
                </label>
                <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ErrorMessage="Please enter a valid email address" ControlToValidate="txtEmail" 
                    ForeColor="#FF3300" SetFocusOnError="True" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    ValidationGroup="A"></asp:RegularExpressionValidator> <br />
                <asp:Button ID="btnSend" CssClass="btn btn-info" runat="server" Text="Send" 
                    ValidationGroup="A" />
            </div>
        </div>
        <div class="row" style="margin-top: 2%">
            <asp:Label ID="lblMsg" runat="server" Text="{{lblMessage}}"></asp:Label>
        </div>
    </div>
</asp:Content>
