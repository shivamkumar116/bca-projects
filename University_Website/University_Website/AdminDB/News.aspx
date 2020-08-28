<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/AdminDB/admin.Master"
    CodeBehind="News.aspx.vb" Inherits="University_Website.News" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <h3>
            News and Events</h3>
        <hr />
    </div>
    <div class="row" style="margin-top: 20px">
        <div class="col-lg-1 ">
        </div>
        <div class="col-lg-8 ">
            <div class="form-group">
                <label>
                    Title</label>
                <asp:TextBox ID="txtTitle" CssClass="form-control " runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>
                    Description</label>
                <asp:TextBox ID="txtDesc" CssClass="form-control " runat="server" Rows="5" 
                    TextMode="MultiLine"></asp:TextBox>
            </div>
            <div class="form-group ">
                <asp:Button ID="btnSubmit"  CssClass ="btn btn-sm btn-success " runat="server" Text="Submit" />
                 <asp:Button ID="btnDiscard"  CssClass ="btn btn-sm btn-danger " runat="server" Text="Discard" />
            </div>
            <div class="form-group ">
                <asp:Label ID="lblError" runat="server" Text="{{lblMessage}}"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
