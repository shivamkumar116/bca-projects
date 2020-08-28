<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/AdminDB/admin.Master"
    CodeBehind="galleryDB.aspx.vb" Inherits="University_Website.galleryDB" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <h3>
            Gallery</h3>
        <hr />
    </div>
    <div class="row">
        <div class="col-lg-6">
            <span>Select image to upload</span>
            <br />
            <br />
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
            <asp:Button ID="btnUpload" CssClass="btn btn-sm btn-primary" runat="server" Text="Upload" />
            <br />
            <asp:Label ID="lblError" runat="server" Text="{{Error Message}}"></asp:Label>
        </div>
    </div>
    <div class="row" style="margin-top: 4%;">
        <div class="col-lg-6 text-center">
            <asp:Image ID="uploadImage" CssClass="img-responsive upload-image " runat="server" /></div>
    </div>
</asp:Content>
