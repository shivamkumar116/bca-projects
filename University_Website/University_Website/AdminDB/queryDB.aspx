<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/AdminDB/admin.Master"
    CodeBehind="queryDB.aspx.vb" Inherits="University_Website.queryDB" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <h3>
            Contact Us Queries</h3>
        <hr />
    </div>
    <div class="row text-center " style="margin-top: 20px">
    <div class="col-lg-2"></div>
       <div class="col-lg-8"> <asp:GridView ID="GridView1" runat="server" 
               AutoGenerateColumns="False" CellPadding="4"
            DataKeyNames="id" DataSourceID="AccessDataSource1"
            PageSize="20" Width="100%" BackColor="White" BorderColor="#CC9966" 
            BorderStyle="None" BorderWidth="1px">
            <Columns>
                <asp:TemplateField HeaderText="ID">
                
                <ItemTemplate>
                <%# Container.DataItemIndex + 1%>
                </ItemTemplate>
                    <HeaderStyle CssClass="text-center" />
                </asp:TemplateField>

                <asp:HyperLinkField DataNavigateUrlFields="id" DataNavigateUrlFormatString="displayQuery.aspx?id={0}"
                    DataTextField="Subject" HeaderText="Subject" >
                <HeaderStyle CssClass="text-center" />
                </asp:HyperLinkField>
            </Columns>
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC"
                Font-Size="Large" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <SortedAscendingCellStyle BackColor="#FEFCEB" />
            <SortedAscendingHeaderStyle BackColor="#AF0101" />
            <SortedDescendingCellStyle BackColor="#F6F0C0" />
            <SortedDescendingHeaderStyle BackColor="#7E0000" />
        </asp:GridView>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/Database/universityDB.accdb"
            SelectCommand="SELECT [id], [PersonName], [Subject] FROM [contactQuery]"></asp:AccessDataSource></div>
       
       
    </div>
</asp:Content>
