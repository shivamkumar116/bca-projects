<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/AdminDB/admin.Master"
    CodeBehind="displayQuery.aspx.vb" Inherits="University_Website.displayQuery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <h3>
            Detail of query</h3>
        <hr />
    </div>
    <div class="row">
        <asp:DetailsView ID="DetailsView1" runat="server" Height="150px" Width="100%" AutoGenerateRows="False"
            CellPadding="4" CellSpacing="5" DataKeyNames="id" DataSourceID="AccessDataSource1"
            ForeColor="#333333" GridLines="both">
            <AlternatingRowStyle BackColor="White" />
            <CommandRowStyle BackColor="#FFFFC0" Font-Bold="True" />
            <FieldHeaderStyle BackColor="#FFFF99" Font-Bold="True" />
            <Fields>
                <asp:BoundField DataField="PersonName" HeaderText="Person Name" SortExpression="PersonName">
                    <HeaderStyle />
                </asp:BoundField>
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Subject" HeaderText="Subject" SortExpression="Subject" />
                <asp:BoundField DataField="Message" HeaderText="Message" SortExpression="Message" />
            </Fields>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        </asp:DetailsView>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/Database/universityDB.accdb"
            SelectCommand="SELECT * FROM [contactQuery] WHERE ([id] = ?)">
            <SelectParameters>
                <asp:QueryStringParameter Name="id" QueryStringField="id" Type="Int32" />
            </SelectParameters>
        </asp:AccessDataSource>
    </div>
    <div class="row" style="margin-top: 50px">
        <div class="col-lg-7">
            <div class="form-group ">
                <label>
                    Your Reply</label>
                <asp:TextBox runat="server" CssClass="form-control" TextMode="MultiLine" 
                    ID="txtReply" Rows="10"></asp:TextBox>
            </div>
            <div class="form-group ">
                <asp:Button ID="btnReply" runat="server" CssClass ="btn btn-sm btn-success  " Text="send" />&nbsp;<asp:Label
                    ID="lblMessage" runat="server" Text="{{lblMessage}}"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
