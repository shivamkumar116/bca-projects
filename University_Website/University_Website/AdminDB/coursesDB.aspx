<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/AdminDB/admin.Master"
    CodeBehind="coursesDB.aspx.vb" Inherits="University_Website.courses" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="row">
        <h3>
            Courses</h3>
        <hr />
    </div>

    <div class="row" id="newCourse">
        <h4>
            Add New course</h4>
        <div class="col-lg-4">
            <div class="form-group">
                <label>
                    Course Title</label>
                <asp:TextBox ID="txtTitle" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>
                    Course Fee(Per Semester)</label>
                <asp:TextBox ID="txtFee" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="col-lg-4">
            <div class="form-group">
                <label>
                    Number of seats</label>
                <asp:TextBox ID="txtSeats" CssClass="form-control" runat="server"></asp:TextBox>
           
            </div>
            <div class="form-group">
                <label>
                    Duration</label>
                <asp:TextBox ID="txtDuration" CssClass="form-control" runat="server"></asp:TextBox>
            
            </div>
        </div>
  
        <div class="col-lg-5">
            <asp:Button ID="btnSave" CssClass="btn btn-success" runat="server" Text="Add Course" />&nbsp;
            <asp:Button ID="Button2" CssClass="btn btn-danger" runat="server" Text="Discard" />
            <br />
            <br />
            <asp:Label ID="lblMsg" runat="server" Text="{{Message}}"></asp:Label>
        </div>
    </div>
        <div class="row" style="margin-top: 4%">
        <p>Check out the complete list of courses here - 
            <asp:Button ID="btnLink" runat="server" CssClass="btn btn-info btn-xs" Text="All courses" /></p>
       
    </div>
</asp:Content>
