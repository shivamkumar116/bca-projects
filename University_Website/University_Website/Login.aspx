<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Website.Master"
    CodeBehind="Login.aspx.vb" Inherits="University_Website.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row" style="padding-top: 30px">
        <div class="col-md-4"></div>
        <div class="col-md-4" style="padding-bottom: 8%;">
            <div class="card card-container text-center">
                <img id="profile-card" src="Images/login.png" class=" img-circle img-thumbnail img-responsive"
                    height="100px" width="100px" alt ="login png" />
                <div class="form-group" style="margin-top: 5%">
                    <asp:TextBox ID="txtUsername" class="form-control" placeholder="Email address" runat="server"></asp:TextBox>
                    
                </div>
                <div class="form-group" style="margin-top: 5%">
                    <asp:TextBox ID="txtPassword" class="form-control" placeholder="Password" TextMode="Password"
                        runat="server"></asp:TextBox>
                </div>
             
                <div class="form-group" style="margin-top: 5%">
                    <asp:Button ID="btnLogin" runat="server" Text="Sign in" 
                        CssClass="btn btn-primary btn-block" ValidationGroup="A" />
                </div>
                <div class="form-group">
                    <asp:Button ID="btnForgot" runat="server" Text="Forgot the password?" CssClass="btn btn-link btn-sm" />
                </div>
                <div class="form-group" style="margin-top: 5%">
                    <asp:Label ID="lblError" runat="server" Text="{Error Message}" ForeColor="#FF3300"></asp:Label>
                </div>
            </div>
        </div>
        <div class="col-md-4"></div>
        
    </div>

</asp:Content>
