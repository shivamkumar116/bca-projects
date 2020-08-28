<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Website.Master"
    CodeBehind="studentRegistration.aspx.vb" Inherits="University_Website.studentRegistration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row" style="height: 480px;">
        <h2 id="logo" class="h2">
            Student Registration</h2>
        <hr />
        <div class="col-lg-4">
        </div>
        <div class="col-lg-4">
            <div class="card card-container ">
                <div class="form-group">
                    <label>
                        Email ID</label>
                    <asp:TextBox ID="txtEmail" CssClass="form-control " runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ErrorMessage="Please enter a valid email address" ControlToValidate="txtEmail" 
                        Display="Dynamic" ForeColor="#FF3300" SetFocusOnError="True" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                        ValidationGroup="A"></asp:RegularExpressionValidator>
                </div>
                <div class="form-group">
                    <label>
                        Password</label>
                    <asp:TextBox ID="txtPassword" CssClass="form-control " runat="server" TextMode="Password"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label>
                        Confirm Password</label>
                    <asp:TextBox ID="txtConfirmPassword" CssClass="form-control " runat="server" TextMode="Password"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Button ID="btnRegister" CssClass="btn btn-primary  " runat="server" 
                        Text="Register Me" ValidationGroup="A" />
                    <asp:Button ID="btnCancel" CssClass="btn btn-danger  " runat="server" Text="Discard" />
                </div>
                <div class="form-group text-center">
                    <asp:Label ID="lblEror" runat="server" Text="{{ErrorMessage}" ForeColor="#FF3300"></asp:Label>
                </div>
            </div>
        </div>
        <div class="col-lg-4">
        </div>
    </div>
</asp:Content>
