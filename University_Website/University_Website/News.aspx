<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Website.Master"
    CodeBehind="News.aspx.vb" Inherits="University_Website.News1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <h2 id="logo" class="h2">
            News and Events</h2>
        <hr />
    </div>
    <div class="row" style=" height: 350px">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID"
            DataSourceID="AccessDataSource1" Width="100%" GridLines="None" 
            CellPadding="4" ForeColor="#333333">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
               <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="displayNews.aspx?ID={0}"
                    DataTextField="Title">
                    <HeaderStyle CssClass="text-center" />
                </asp:HyperLinkField>
                <asp:TemplateField>
                <ItemTemplate >
                <br />
                </ItemTemplate></asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/Database/universityDB.accdb"
            SelectCommand="SELECT * FROM [News]"></asp:AccessDataSource>
    </div>
</asp:Content>
