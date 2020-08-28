<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Admin/Dashboard.Master" CodeBehind="SetExam.aspx.vb" Inherits="Examination_system1.SetExam1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="box">
           <div class="box-top">
         Set Exam
           </div>
           <div class ="box-panel"> <asp:Panel ID="Panel1" runat="server">
        <table style="width: 100%;">
           <tr><td>Exam Code</td>
           <td><asp:TextBox ID="TxtExamCode" runat="server"  ReadOnly="True"></asp:TextBox></td></tr>
            <tr>
                
                <td>
                   Question 
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Height="41px" TextMode="MultiLine" 
                        Width="284px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                   Option A
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td>
                    Option B
                </td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                
            </tr>
             <tr>
                <td>
                    Option C
                </td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                </tr>
                
 <tr>
                <td>
                    Option D
                </td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
                </tr> 
                
 <tr>
                <td>
                    Answer
                </td>
                <td>
                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="A" 
                        Text="OptionA" />
                    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="A" 
                        Text="OptionB" />
                    <asp:RadioButton ID="RadioButton3" runat="server" GroupName="A" 
                        Text="OptionC" />
                    <asp:RadioButton ID="RadioButton4" runat="server" GroupName="D" 
                        Text="OptionD" />
                </td>
                

            </tr>
            <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Save & Next" class="btn btn-info" />&nbsp; <asp:Button ID="Button2" runat="server" Text="Finish" class="btn btn-success"/>

            </td></tr>
          
        </table>
    </asp:Panel></div>
            </div>
 
   
</asp:Content>
