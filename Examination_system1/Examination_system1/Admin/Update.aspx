<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Admin/Dashboard.Master" CodeBehind="Update.aspx.vb" Inherits="Examination_system1.Update" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="box">
           <div class="box-top">
         Edit Student Information
           </div>
           <div class ="box-panel">
           <table cellspacing ="0px" style =" padding-top : 5PX">
        <tr>
            <td>
               Seacrh by 
            </td>
            <td>
               <asp:DropDownList ID="DropDownList1" runat="server">
   
                    <asp:ListItem>Roll number</asp:ListItem>
                    <asp:ListItem>Email-ID</asp:ListItem>
                 
               </asp:DropDownList>
                &nbsp; <asp:TextBox ID="TextBox1" runat="server" Height="30px"></asp:TextBox> &nbsp;
                <asp:Button ID="Button1" runat="server" Text="Search" class="btn btn-primary " Height="30px"/>
            </td>
          
           
        </tr>
    
    </table>
    <br />
   
    <asp:Panel ID="Panel1" runat="server">
        <table style="width: 100%;border: 1px solid #ddd;padding: 15px;">
            <tr>
                <td>
                    Name
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
               
            </tr>
            <tr>
                <td>
                   Address
                </td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Height="70px" TextMode="MultiLine"></asp:TextBox>
                </td>
                
                
            </tr>
            <tr>
                <td>
                    State
                </td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                
            </tr>
             <tr>
                <td>
                    Date of Birth
                </td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
               
            </tr>
            <tr>
                <td>
                   Email-ID
                </td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
                
                
            </tr>
            <tr>
                <td>
                    Mobile
                </td>
                <td>
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td>
                
            </tr>
             <tr>
                <td>
                    Class
                </td>
                <td>
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                </td>
               
            </tr>
            <tr>
                <td>
                 Roll Number
                </td>
                <td>
                    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                </td>
                
                
            </tr>
            <tr>
                <td>
                    Password
                </td>
                <td>
                    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                </td>
                
            </tr>
             <tr>
                <td>
                    Gender
                </td>
                <td>
                    <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                </td>
                
            </tr>
          <tr>
          <td>&nbsp;</td>
          <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
           
                <asp:Button ID="Button3" runat="server" Text="Delete" class="btn btn-danger" /></td>
          
          </tr>
               <tr>
               <td>
               <td>
            <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="#00CC00" 
                       Font-Size="14pt"></asp:Label></td></td></tr>
        </table>
         
    </asp:Panel></div>
            </div>
   


</asp:Content>
