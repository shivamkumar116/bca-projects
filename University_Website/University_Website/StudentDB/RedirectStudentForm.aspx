<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="RedirectStudentForm.aspx.vb"
    Inherits="University_Website.RedirectStudentForm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <link href="../bootstrap-3.3.7/dist/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="../font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <link href="../Css/master.css" rel="stylesheet" type="text/css" />
    <title>E-Admission Portal | University of Palampur</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container-fluid " style="height: 800px">
        <div class="container ">
            <div class="row">
                <div class="col-lg-2 ">
                </div>
                <div class="col-lg-8">
                    <img src="../Images/logo.png" alt="University Logo" height="80px" width="80px" />
                    &nbsp;
                    <h2 class="h2" id="logo1">
                        E-Admission Portal (University Of Palampur)<br />
                    </h2>
                </div>
                <div class="col-lg-2 text-right " style="padding-top: 30px">
                    <asp:Button ID="btnLogout" Text="Logout" CssClass="btn btn-xs btn-info  " runat="server" />
                </div>
            </div>
            <hr />
            <div class="row text-center ">
                <asp:Label ID="lblMessage" runat="server" Text="{{lblMessage}}" Font-Bold="True"
                    Font-Size="Medium"></asp:Label>
                <br />
                <br />
                <asp:Button ID="btnDetails" CssClass="btn btn-link " runat="server" Text="Check Details Here" />
            </div>
            <div class="row">
                <asp:Panel ID="Panel1" runat="server">
                    <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="100%" 
                        CellPadding="4" ForeColor="#333333" GridLines="Both">
                        <AlternatingRowStyle BackColor="White" />
                        <CommandRowStyle BackColor="#FFFFC0" Font-Bold="True" />
                        <FieldHeaderStyle BackColor="#FFFF99" Font-Bold="True" />
                        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                    </asp:DetailsView>
                    <div class="row text-center " style="margin-top: 20px">
                    <input id="Button1" type="button" class ="btn btn-xs btn-default " value="Print" onclick ="window.print()" />
                    </div>
                    
                </asp:Panel>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
