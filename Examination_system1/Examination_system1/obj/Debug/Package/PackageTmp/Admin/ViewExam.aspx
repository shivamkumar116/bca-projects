﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Admin/Dashboard.Master" CodeBehind="ViewExam.aspx.vb" Inherits="Examination_system1.ViewExam" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <div class="box">
           <div class="box-top">
         Edit Student Information
           </div>
           <div class ="box-panel">
           <table cellspacing ="0px" style =" padding-top : 5PX">
        <tr>
            <td>
               Select Exam Code
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
                &nbsp; 
                <asp:Button ID="Button1" runat="server" Text="Search" class="btn btn-primary " Height="30px"/>
            </td>
          
           
        </tr>
    
    </table>
    <br />
               <asp:GridView ID="GridView1" runat="server" BackColor="White" 
                   BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                   <FooterStyle BackColor="White" ForeColor="#000066" />
                   <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                   <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                   <RowStyle ForeColor="#000066" />
                   <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                   <SortedAscendingCellStyle BackColor="#F1F1F1" />
                   <SortedAscendingHeaderStyle BackColor="#007DBB" />
                   <SortedDescendingCellStyle BackColor="#CAC9C9" />
                   <SortedDescendingHeaderStyle BackColor="#00547E" />
               </asp:GridView>
               </div> 
               </div> 
              

</asp:Content>
