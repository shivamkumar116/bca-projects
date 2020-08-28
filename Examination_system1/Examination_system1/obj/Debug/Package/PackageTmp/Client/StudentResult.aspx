<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="StudentResult.aspx.vb" Inherits="Examination_system1.StudentResult" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="../CSS/Exam.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/buttons.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/global.css" rel="stylesheet" type="text/css" />
    <link href="../font-awesome/css/font-awesome.css" rel="stylesheet" type="text/css" />
    <title>Examination System | Result</title>
</head>
<body>
    <form id="form1" runat="server">
    
        <div class="header">
        <div class="logo">
            <a href="#"><i class ="fa fa-mortar-board"></i>&nbsp;Examination&nbsp;System</a>
            </div>
            </div>
              <div class="feedback">
              <p style ="text-align: center; font-size : x-large; font-weight : bold ;  ">Result</p><br />
              <br />
   <h4> Hello ! <b>  <asp:Label ID="ClientName" runat="server" Text="{Student Name}" 
            ForeColor="#0099FF"></asp:Label></b></h4> 
    <br />
                  <asp:Image ID="Image1" runat="server" ImageUrl=""  Width="100px" />
    <br />
  
<br />
Total Marks : <asp:Label ID="Label1" runat="server" Text="{Marks}" ForeColor="#0066FF"></asp:Label>
<br /><br />
                  <asp:Button ID="Button1" runat="server" Text="End Exam" class="btn btn-info" />
</div> 
    <div class="footer">
    </div>
    </form>
</body>
</html>
 
