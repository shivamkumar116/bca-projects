<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="Examination_system1.ClientLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../CSS/Exam.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/global.css" rel="stylesheet" type="text/css" />
    <link href="../font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/buttons.css" rel="stylesheet" type="text/css" />
    <link href="CSS/Input.css" rel="stylesheet" type="text/css" />
    <title>Examination System | Login</title>
 
   
       <script type="text/javascript">
//document.onkeydown = function (e) 
  //  return false;


</script>

</head>
<body>
    <form id="form1" runat="server">
    
    
    <div class="header">
        <div class="logo"><a href="#"><i class ="fa fa-mortar-board"></i>&nbsp;Examination&nbsp;System</a>
       
       
    </div>
   </div> 
      <div class="Login">
         <table cellpadding="1px" cellspacing="10px" style="width: 350px;">
    <tr>
    <td colspan ="2"><h2>LOGIN</h2></td></tr>
     <tr>
         <td>
             <b> <asp:Label ID="Label1" runat="server" Text="EMAIL-ID"></asp:Label></b>
         </td>
         <td>
             <asp:TextBox ID="TxtUser" runat="server" Width="190px"></asp:TextBox> &nbsp;   
             </td>
     </tr>
     <tr>
         <td>
             <b><asp:Label ID="Label2" runat="server" Text="PASSWORD"></asp:Label></b>
         </td>
         <td>
             <asp:TextBox ID="TxtPassword" runat="server" Width="189px" Font-Bold="True" 
                 TextMode="Password"></asp:TextBox> &nbsp;
             </td>
     </tr>
     <tr>
         <td>
         </td>
         <td>
             <asp:Button ID="Button1" runat="server" Text="Log In" class="btn"  />
&nbsp;</td>
     </tr>
     <tr>
     <td colspan ="2" style="background-color:#2980b9">&nbsp;</td></tr>
     <tr>
       
         <td colspan ="2" style ="text-align :center ">
       If don't have an account&nbsp;<a href="StudentReg.aspx" >Click Here!</a><br />
             <asp:Label ID="LoginError" runat="server" ForeColor="#FF3300" 
                 Text="{Login Error}"></asp:Label>
         </td>
     </tr>
     
 </table>
     </div> 
      <div class="footer">
    </div>
    </form>
</body>
</html>
