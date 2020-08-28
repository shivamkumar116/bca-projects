<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Website.Master"
    CodeBehind="courses.aspx.vb" Inherits="University_Website.courses1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <h2 id="logo" class="h2">
            COURSES</h2>
        <hr />
    </div>
    <div class="row" style="height: 500px;">
        <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate>
                <table class="table table-bordered table-condensed table-hover table-responsive" width ="100%">
                    <tr>
                        <th>
                        TITLE
                        </th>
                        <th>
                            FEES
                        </th>
                        <th>
                            SEATS
                        </th>
                        <th>
                            DURATION
                        </th>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                   
                    <td> <asp:Label ID="lblTitle" runat="server" Text='<%#Eval("Title") %>'></asp:Label>
                    </td>
                    <td> <asp:Label ID="lblFees" runat="server" Text='<%#Eval("Fees") %>'></asp:Label>
                    </td>
                    <td> <asp:Label ID="lblSeats" runat="server" Text='<%#Eval("Seats") %>'></asp:Label>
                    </td>
                    <td> <asp:Label ID="lblDuration" runat="server" Text='<%#Eval("Duration") %>'></asp:Label>
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
