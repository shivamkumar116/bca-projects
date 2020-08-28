<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Website.Master"
    CodeBehind="Contact.aspx.vb" Inherits="University_Website.Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <h2 id="logo" class="h2">
            Contact Us</h2>
        <hr />
    </div>
    <div class="row" style="margin-top: 1%;">
        <div class="col-lg-5">
            <p class="lead">
                Quick Enquiry</p>
            <div class="form-group">
                <label>
                    Name</label>
                <asp:TextBox ID="txtName" class="form-control " runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>
                    Email</label>
                <asp:TextBox ID="txtEmail" class="form-control" runat="server"></asp:TextBox><asp:RegularExpressionValidator
                    ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter valid email address"
                    ControlToValidate="txtEmail" ForeColor="#FF3300" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                    SetFocusOnError="True" ValidationGroup="A"></asp:RegularExpressionValidator>
            </div>
            <div class="form-group">
                <label>
                    Subject</label>
                <asp:TextBox ID="txtSubject" class="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>
                    Message</label>
                <asp:TextBox ID="txtMessage" class="form-control" TextMode="MultiLine" runat="server"></asp:TextBox>
            </div>
            <div class="form-group ">
                <asp:Button ID="btnSend" runat="server" Text="Send" 
                    class="btn btn-success btn-sm" ValidationGroup="A" />
                <asp:Button ID="btnDiscard" runat="server" Text="Discard" class="btn btn-danger btn-sm" />
                <input type="reset" class="btn btn-default btn-sm">
            </div>
            <div class="form-group">
                <asp:Label ID="lblMsg" runat="server" Text="{{lblMessage}}"></asp:Label>
            </div>
        </div>
        <div class="col-lg-3">
            &nbsp;</div>
        <div class="col-lg-4 text-justify">
            <p class="lead">
                Address
            </p>
            <p style="text-transform: uppercase">
                University of Palampur<br />
                Palamput Distt. Kangra<br />
                Himachal Pardesh<br />
                Email:- Principal@gmail.com<br />
                Fax:-01892473292<br />
                Mobile:-9876543210<br />
            </p>
            <br />
            <br />
            <p class="lead">
                Social Media
            </p>
            <span class="fa fa-2x fa-facebook-square" style ="color: #3a5998"></span>&nbsp;
            <span class="fa fa-2x fa-twitter-square "  style ="color: #00aced">&nbsp;
            </span>
            <span class="fa fa-2x fa-google-plus-square " style ="color: #dd4b39"></span>&nbsp;
            <span class="fa fa-2x fa-reddit-square " style ="color: #ff4031">&nbsp;
            </span>
        </div>
    </div>
</asp:Content>
