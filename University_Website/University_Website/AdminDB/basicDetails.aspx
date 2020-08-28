<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/AdminDB/admin.Master"
    CodeBehind="basicDetails.aspx.vb" Inherits="University_Website.basicDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <h3>
            Basic Details</h3>
        <hr />
    </div>
    <div class="row" style="margin-top: 3%">
        <div class="col-md-6">
            <div class="form-group">
                <label>
                    Username</label>
                <asp:TextBox ID="txtUserName" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>
                    Password</label>
                <asp:TextBox ID="txtPassword" CssClass="form-control" runat="server" 
                    TextMode="Password"></asp:TextBox>
                <asp:CheckBox ID="chkPassword" CssClass ="checkbox-inline " runat="server" 
                    Text="Show Password" AutoPostBack="True" />
            </div>
            <div class="form-group">
                <asp:Button ID="btnUpdate" runat="server" CssClass ="btn btn-info btn-sm" Text="Update" />&nbsp;
                <asp:Button ID="btnDiscard" runat="server" Text="Discard" CssClass ="btn btn-danger btn-sm" />
           <br />
                <asp:Label ID="lblMessage" runat="server" Text="{{Message}}"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
