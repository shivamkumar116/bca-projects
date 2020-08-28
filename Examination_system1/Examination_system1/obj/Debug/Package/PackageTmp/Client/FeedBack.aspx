<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FeedBack.aspx.vb" Inherits="Examination_system1.FeedBack" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="../CSS/Exam.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/global.css" rel="stylesheet" type="text/css" />
    <link href="../font-awesome/css/font-awesome.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/buttons.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/Input.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/buttons.css" rel="stylesheet" type="text/css" />
    <title>Examination System | Student Feedback</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <div class="logo">
                <a href="#"><i class="fa fa-mortar-board"></i>&nbsp;Examination&nbsp;System</a>
            </div>
        </div>
    <div class="feedback">
   <h4> Hello ! <b>  <asp:Label ID="ClientName" runat="server" Text="{Student Name}" 
            ForeColor="#0099FF"></asp:Label></b>
    <br />
    <br />
    We would like to hear from you about our examination System.</h4>
    <div class ="answer">
    <table >
    <tr>
    <td> Please choose one of the following:-</td></tr>
    <tr>
    <td>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" CellPadding="10" 
            CellSpacing="10">
            <asp:ListItem>Very Good</asp:ListItem>
            <asp:ListItem>Good</asp:ListItem>
            <asp:ListItem>Average</asp:ListItem>
            <asp:ListItem>Bad</asp:ListItem>
            <asp:ListItem>Very Bad</asp:ListItem>
        </asp:RadioButtonList>
        </td>
    <td> &nbsp;</td>
        </tr>
        <tr>
        <td>
        &nbsp;</td>
        <td> <asp:Button ID="Button1" runat="server" Text="Exit" class="btn btn-info" /></td>
        </tr> 
        </table>
       
       
       
    </div>
    </div>
    <div class="footer">
    </div>
    </form>
</body>
</html>
