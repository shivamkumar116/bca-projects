<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Website.Master"
    CodeBehind="displayNews.aspx.vb" Inherits="University_Website.displayNews" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="row">
            <h2 id="logo" class="h2">
                <asp:Label ID="lblTitle" runat="server" Text="{{NewsTitle}}"></asp:Label></h2>
            <hr />
        </div>
        <div class="row" style="height: 380px">
            <div class="form-group ">
                Dated:
                <label>
                    <asp:Label ID="lblDate" runat="server" Text="{{lblDate}}"></asp:Label></label>
            </div>
            <div class="form-group ">
            <label >Description : </label>
                <asp:Label ID="lblDesc" runat="server" Text="{{lbldescription}}"></asp:Label>
            </div>
            <div class="form-group ">
                <asp:Button ID="btnBack" CssClass ="btn btn-xs btn-info " runat="server" Text="Back" />
            </div>
        </div>
    </div>
</asp:Content>
