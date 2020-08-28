<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Admin/Dashboard.Master"
    CodeBehind="AddStudent.aspx.vb" Inherits="Examination_system1.AddStudent" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div class="box">
        <div class="box-top">
            <center>
                Hello Admin, Kindly provide the following details to add a student</center>
        </div>
        <div class="box-panel">
       
               <table cellpadding="7px">
              
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
                   <asp:TextBox ID="TextBox3" runat="server" TextMode="Date"></asp:TextBox></td></tr>
               <tr><td>Email-ID</td><td>
                   <asp:TextBox ID="TextBox4" runat="server" TextMode="Email"></asp:TextBox></td></tr>
                    <tr><td>Mobile Number</td><td>
                   <asp:TextBox ID="TextBox5" runat="server" TextMode="Number" MaxLength="10"></asp:TextBox></td></tr>
               <tr><td>Class</td><td>
                   <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td></tr>
               <tr><td>Roll Number</td><td>
                   <asp:TextBox ID="TextBox7" runat="server" TextMode="Number"></asp:TextBox></td></tr>
               
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
    <tr>
    <td>
    </td>
    <td>
        <asp:Label ID="Txtsave" runat="server" Text="Label" ForeColor="#33CC33" 
            Font-Size="12pt"></asp:Label></td></tr>
   
</table>

            
        </div>
    </div>
</asp:Content>
