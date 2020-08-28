<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/AdminDB/admin.Master"
    CodeBehind="studentsDB.aspx.vb" Inherits="University_Website.studentsDB" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <h3>
            Student Applications</h3>
        <hr />
    </div>
    <div class="row" style="margin-top: 20px">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Email"
            DataSourceID="AccessDataSource1" Width="100%">
            <Columns>
                <asp:TemplateField HeaderText="ID">
                    <ItemTemplate>
                        <%# Container.DataItemIndex + 1%>
                    </ItemTemplate>
                    <HeaderStyle />
                </asp:TemplateField>
                <asp:BoundField DataField="StudentName" HeaderText="Student Name" SortExpression="StudentName" />
                <asp:BoundField DataField="DOB" HeaderText="DOB" SortExpression="DOB" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                <asp:HyperLinkField DataNavigateUrlFields="Email" DataNavigateUrlFormatString="displayStudent.aspx?Email={0}"
                    DataTextField="Email" HeaderText="Click Below" />
            </Columns>
        </asp:GridView>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/Database/universityDB.accdb"
            SelectCommand="SELECT DISTINCT [StudentName], [DOB], [Gender], [Email] FROM [stuBasic_Details]">
        </asp:AccessDataSource>
    </div>
</asp:Content>
