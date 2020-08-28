<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Website.Master"
    CodeBehind="gallery.aspx.vb" Inherits="University_Website.gallery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <h2 id="logo" class="h2">
            Gallery</h2>
        <hr />
    </div>
    <div class="row" style="height: 500px;">
        <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
            </HeaderTemplate>
            <ItemTemplate>
                <asp:Image ID="imgPhoto" class="img-thumbnail" runat="server" ImageUrl='<%#Eval("ImageUrl") %>'
                    Height="200px" Width="200px" />&nbsp;
            </ItemTemplate>
            <FooterTemplate>
            </FooterTemplate>
        </asp:Repeater>
    </div>
    
   
</asp:Content>
