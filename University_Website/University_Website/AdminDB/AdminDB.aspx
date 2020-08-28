<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/AdminDB/admin.Master"
    CodeBehind="AdminDB.aspx.vb" Inherits="University_Website.AdminDB" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="jumbotron" style="margin-top: 2%;">
            <h3>
               Welcome Administrator !</h3>
             
        </div>
    </div>
    <div class="row" style="margin-top: 3%;">
        <div class="col-lg-5">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <div class="row">
                        <div class="col-xs-3">
                            <span class="fa fa-5x fa-child"></span>
                        </div>
                        <div class="col-xs-9 text-right">
                            <div class="h2">
                                <asp:Label ID="lblStudentCount" runat="server" Text="{{26}}"></asp:Label>
                            </div>
                            <div>
                                Students Registered</div>
                        </div>
                    </div>
                </div>
                <a href="studentRegistered.aspx">
                    <div class="panel-footer" style="padding: 20px;">
                        <span class="pull-left" style="padding-bottom: 50px;">View Details </span><span class="pull-right">
                            <i class="fa fa-arrow-circle-right"></i></span>
                    </div>
                </a>
            </div>
        </div>
        <div class="col-lg-5">
            <div class="panel panel-success ">
                <div class="panel-heading">
                    <div class="row">
                        <div class="col-xs-3">
                            <span class="fa fa-5x fa-tasks"></span>
                        </div>
                        <div class="col-xs-9 text-right">
                            <div class="h2">
                                <asp:Label ID="lblCourseCount" runat="server" Text="{{26}}"></asp:Label>
                            </div>
                            <div>
                                courses offered</div>
                        </div>
                    </div>
                </div>
                <a href="allCourses.aspx">
                    <div class="panel-footer" style="padding: 20px;">
                        <span class="pull-left" style="padding-bottom: 50px;">View Details </span><span class="pull-right">
                            <i class="fa fa-arrow-circle-right"></i></span>
                    </div>
                </a>
            </div>
        </div>
    </div>
</asp:Content>
