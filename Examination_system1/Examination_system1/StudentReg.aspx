<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="StudentReg.aspx.vb" Inherits="Examination_system1.StudentReg" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Examination System | Student Registration form</title>
        <link rel="Stylesheet" href="../CSS/global.css" type="text/css" />
     <link rel="Stylesheet" href="../CSS/Content.css" type="text/css" />
    <link href="../font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/buttons.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/Input.css" rel="stylesheet" type="text/css" />
      <link href="CSS/Exam.css" rel="stylesheet" type="text/css" />
    
</head>
<body>
    <form id="form1" runat="server">
 
  
    <div class="header">
        <div class="logo"><a href="Login.aspx"><i class ="fa fa-mortar-board"></i>&nbsp;Examination&nbsp;System</a>
       
       
    </div>
   </div> 

    
    <div class="box">
       <center> <div class="box-top" style ="width : 500px">
            <center>
                Sign Up for free!</center>
        </div> 
        </center>
<center>
        <div class="box-panel" style ="width : 500px;">
               <table cellspacing ="10px" cellpadding="10px">
               <tr><td>Name</td><td>
                   <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td></tr>
               <tr><td>Address</td><td>
                   <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine"></asp:TextBox></td></tr>
               <tr><td>State</td><td><asp:DropDownList ID="DropDownList1" runat="server" Font-Size="10pt" 
                AutoPostBack="True">
                <asp:ListItem>--Select State--</asp:ListItem>
                <asp:ListItem>Andhra Pradesh</asp:ListItem>
                <asp:ListItem>Arunachal Pradesh</asp:ListItem>
                <asp:ListItem>Assam</asp:ListItem>
                <asp:ListItem>Bihar</asp:ListItem>
                <asp:ListItem>Chhattisgarh</asp:ListItem>
                <asp:ListItem>Delhi</asp:ListItem>
                <asp:ListItem>Goa</asp:ListItem>
                <asp:ListItem>Gujarat</asp:ListItem>
                <asp:ListItem>Haryana</asp:ListItem>
                <asp:ListItem>Himachal Pradesh</asp:ListItem>
                <asp:ListItem>Jammu and Kashmir</asp:ListItem>
                <asp:ListItem>Jharkhand</asp:ListItem>
                <asp:ListItem>Karnataka</asp:ListItem>
                <asp:ListItem>Kerala</asp:ListItem>
                <asp:ListItem>Madhya Pradesh</asp:ListItem>
                <asp:ListItem>Maharastra</asp:ListItem>
                <asp:ListItem>Manipur</asp:ListItem>
                <asp:ListItem>Meghalaya</asp:ListItem>
                <asp:ListItem>Mizoram</asp:ListItem>
                <asp:ListItem>Nagaland</asp:ListItem>
                <asp:ListItem>Odisha</asp:ListItem>
                <asp:ListItem>Punjab</asp:ListItem>
                <asp:ListItem>Rajasthan</asp:ListItem>
                <asp:ListItem>Sikkim</asp:ListItem>
                <asp:ListItem>Tamil Nadu</asp:ListItem>
                <asp:ListItem>Telangana</asp:ListItem>
                <asp:ListItem>Tripura</asp:ListItem>
                <asp:ListItem>Uttar Pradesh</asp:ListItem>
                <asp:ListItem>Uttarakhand</asp:ListItem>
                <asp:ListItem>West Bengal</asp:ListItem>
            </asp:DropDownList></td></tr>
               <tr><td>Gender</td><td><asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem>--Select Gender--</asp:ListItem>
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
                <asp:ListItem>Other</asp:ListItem>
            </asp:DropDownList></td></tr>
               <tr><td>Date Of Birth</td><td>
                   <asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox></td></tr>
               <tr><td>Email-ID<br /><span style ="color:green">(Email will be your Username)</span></td><td>
                   <asp:TextBox ID="TextBox4" runat="server" ></asp:TextBox></td></tr>
                    <tr><td>Mobile Number</td><td>
                   <asp:TextBox ID="TextBox5" runat="server"  MaxLength="10"></asp:TextBox></td></tr>
               <tr><td>Class</td><td>
                   <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td></tr>
               <tr><td>Roll Number</td><td>
                   <asp:TextBox ID="TextBox7" runat="server" ></asp:TextBox></td></tr>
               
               <tr><td>Password</td><td>
                   <asp:TextBox ID="TextBox8" runat="server" TextMode="Password"></asp:TextBox></td></tr>
               <tr><td>Confirm Password</td>
                   <td><asp:TextBox ID="TextBox9" runat="server" TextMode="Password"></asp:TextBox></td></tr>
         
    <tr>
    <td>&nbsp;</td>
    <td>
        <asp:Button ID="Button1" runat="server" Text="Save" Font-Size="11pt" class="btn btn-success  " /> &nbsp; 
        <asp:Button ID="Button2" runat="server" Text="Reset" Font-Size="11pt" class="btn" />
    </td>
        
    
    </tr>
   
</table>
            
        </div>
        </center>
        <div class="footer">
    </div>
    </div>
     
    </form>
</body>
</html>
