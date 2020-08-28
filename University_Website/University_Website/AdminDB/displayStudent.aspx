<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/AdminDB/admin.Master"
    CodeBehind="displayStudent.aspx.vb" Inherits="University_Website.displayStudent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <h3>
            Student Detail</h3>
        <hr />
    </div>
    <div class="row" style="margin-top: 20px">
        <asp:Label ID="lblStat" runat="server" Text="{{lblStatus}}"></asp:Label>
    <br />
    <br />
        <asp:DetailsView ID="DetailsView1" runat="server" Height="100px" Width="100%" AutoGenerateRows="False"
            CellPadding="4" DataSourceID="AccessDataSource1" ForeColor="#333333">
            <AlternatingRowStyle BackColor="White" />
            <CommandRowStyle BackColor="#FFFFC0" Font-Bold="True" />
            <FieldHeaderStyle BackColor="#FFFF99" Font-Bold="True" />
            <Fields>
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="StudentName" HeaderText="StudentName" 
                    SortExpression="StudentName" />
                <asp:BoundField DataField="FatherName" HeaderText="FatherName" 
                    SortExpression="FatherName" />
                <asp:BoundField DataField="MotherName" HeaderText="MotherName" 
                    SortExpression="MotherName" />
                <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                <asp:BoundField DataField="DOB" HeaderText="DOB" SortExpression="DOB" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                <asp:BoundField DataField="Mobile" HeaderText="Mobile" SortExpression="Mobile" />
                <asp:BoundField DataField="Category" HeaderText="Category" SortExpression="Category" />
                <asp:BoundField DataField="PercentageTenth" HeaderText="PercentageTenth" 
                    SortExpression="PercentageTenth" />
                <asp:BoundField DataField="BoardTenth" HeaderText="BoardTenth" 
                    SortExpression="BoardTenth" />
                <asp:BoundField DataField="SchoolTenth" HeaderText="SchoolTenth" 
                    SortExpression="SchoolTenth" />
                <asp:BoundField DataField="PassingYearTenth" HeaderText="PassingYearTenth" 
                    SortExpression="PassingYearTenth" />
                <asp:BoundField DataField="PercentageTwelth" HeaderText="PercentageTwelth" 
                    SortExpression="PercentageTwelth" />
                <asp:BoundField DataField="BoardTwelth" HeaderText="BoardTwelth" 
                    SortExpression="BoardTwelth" />
                <asp:BoundField DataField="SchoolTwelth" HeaderText="SchoolTwelth" 
                    SortExpression="SchoolTwelth" />
                <asp:BoundField DataField="PassingYearTwelth" HeaderText="PassingYearTwelth" 
                    SortExpression="PassingYearTwelth" />
                <asp:BoundField DataField="CourseOpt" HeaderText="CourseOpt" SortExpression="CourseOpt" />
            </Fields>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        </asp:DetailsView>
        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/Database/universityDB.accdb"
            
            SelectCommand="SELECT DISTINCT stuBasic_Details.Email, stuBasic_Details.StudentName, stuBasic_Details.FatherName, stuBasic_Details.MotherName, stuBasic_Details.Address, stuBasic_Details.DOB, stuBasic_Details.Gender, stuBasic_Details.Mobile, stuBasic_Details.Category, stuQualification_Details.PercentageTenth, stuQualification_Details.BoardTenth, stuQualification_Details.SchoolTenth, stuQualification_Details.PassingYearTenth, stuQualification_Details.PercentageTwelth, stuQualification_Details.BoardTwelth, stuQualification_Details.SchoolTwelth, stuQualification_Details.PassingYearTwelth, stuQualification_Details.CourseOpt FROM (stuBasic_Details INNER JOIN stuQualification_Details ON stuBasic_Details.Email = stuQualification_Details.Email) WHERE stuBasic_Details.Email=?">
            <SelectParameters>
                <asp:QueryStringParameter DefaultValue="" Name="?" QueryStringField="Email" />
            </SelectParameters>
        </asp:AccessDataSource>
    </div>
    <div class="row text-center " style="margin-top: 10px">
        <asp:Button ID="btnApprove" runat="server" CssClass="btn btn-sm btn-success " Text="Approve" />&nbsp;<asp:Button
            ID="btnReject" runat="server" CssClass ="btn btn-danger btn-sm " Text="Reject" />
   <br />
        <asp:Label ID="lblMsg" runat="server" Text="{{lblMessage}}"></asp:Label>
    </div>
</asp:Content>
