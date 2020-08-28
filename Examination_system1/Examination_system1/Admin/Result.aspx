<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Admin/Dashboard.Master" CodeBehind="Result.aspx.vb" Inherits="Examination_system1.Result1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <div class="box">
           <div class="box-top">
         Results
           </div>
           <div class ="box-panel">  <table cellspacing ="0px">
        <tr>
            <td>
                Enter Email-ID</td>
            <td>
                &nbsp; <asp:TextBox ID="TextBox1" runat="server" Height="30px"></asp:TextBox> &nbsp; <asp:Button ID="Button1" runat="server" Text="Search" class="btn" />
            </td>
            <td>
                 &nbsp;
            </td>
           
        </tr>
    
    </table>
    <div>
    <asp:Panel ID="Panel1" runat="server">
        <asp:GridView ID="GridView1" runat="server" Width="100%" CellPadding="4" 
            ForeColor="#333333" GridLines="None" AutoGenerateColumns="False">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
           <Columns >
        <asp:TemplateField HeaderText ="Name">
        <ItemTemplate><%# Eval("UserName")%></ItemTemplate>
        </asp:TemplateField>
         <asp:TemplateField HeaderText ="Score">
        <ItemTemplate><%# Eval("Score")%></ItemTemplate>
        </asp:TemplateField> 
        <asp:TemplateField HeaderText ="Email-ID">
        <ItemTemplate><%# Eval("Email")%></ItemTemplate>
        </asp:TemplateField>
        </Columns> 
 
        </asp:GridView>
    </asp:Panel>
    </div></div>
            </div>
   

</asp:Content>
