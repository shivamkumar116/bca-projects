<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/AdminDB/admin.Master"
    CodeBehind="studentRegistered.aspx.vb" Inherits="University_Website.studentRegistered" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="row">
        <h3>
          Total Student Registered</h3>
        <hr />
    </div>

    <div class="row" style="margin-top: 20px">
    <div class="col-lg-2 "></div>
    <div class="col-lg-8 text-center ">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="Email" DataSourceID="AccessDataSource1" CellPadding="4" 
            ForeColor="#333333" GridLines="Both" Width="100%">
            <AlternatingRowStyle BackColor="White" />
            <Columns >
                <asp:TemplateField HeaderText="ID">
      <ItemTemplate>
                        <%# Container.DataItemIndex + 1%>
                    </ItemTemplate>
                    <HeaderStyle CssClass ="text-center" />
                </asp:TemplateField>
                <asp:BoundField DataField="Email" HeaderStyle-CssClass ="text-center" HeaderText="Email" ReadOnly="True" 
                    SortExpression="Email" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle  BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
            DataFile="~/Database/universityDB.accdb" 
            SelectCommand="SELECT [Email] FROM [studentReg]"></asp:AccessDataSource>
    </div>
    </div>
</asp:Content>
