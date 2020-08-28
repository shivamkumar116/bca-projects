<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Admin/Dashboard.Master" CodeBehind="ExamInstruction1.aspx.vb" Inherits="Examination_system1.ExamInstruction1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
           <div class="box">
           <div class="box-top">
           Choose your Instruction here Admin!!
           </div>
           <div class ="box-panel">
           <span><b>Please set the Instructions</b><br />
               </span>

               <table cellspacing ="10px" cellpadding ="20px">
              <tr>
              <td>Exam Code</td>
                           
              <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                  </td>
              </tr>
              
               <tr>
   
                       <td>
                           Exam Heading</td>
                       <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                       </td>
                   </tr>
                   
                   <tr>
                       <td>
                           Set By </td>
                       <td>
                           <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                       </td>
                   </tr>
                   </table>
               <center>
                   <asp:CheckBox ID="CheckBox1" runat="server" ForeColor="Black" 
                   Text="I agree to set the above instructions in Exam." AutoPostBack="True" /></center>
               <br />
              <center>
                 
                  <asp:Button ID="Button1" runat="server" Text="Next" class="btn btn-info " /></center> 
           </div>
            </div>
</asp:Content>
