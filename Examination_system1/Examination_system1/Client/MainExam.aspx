<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="MainExam.aspx.vb" Inherits="Examination_system1.MainExam" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Examination System | Exam</title>
    <link href="../CSS/buttons.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/Content.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/Exam.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/global.css" rel="stylesheet" type="text/css" />
    <link href="../font-awesome/css/font-awesome.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/Input.css" rel="stylesheet" type="text/css" />
</head>
<script>

    function startCountdown(timeLeft) {
        var interval = setInterval(countdown, 1000);
        update();

        function countdown() {
            if (--timeLeft > 0) {
                update();
            } else {
                clearInterval(interval);
                update();
                completed();
            }
        }

        function update() {
            hours = Math.floor(timeLeft / 3600);
            minutes = Math.floor((timeLeft % 3600) / 60);
            seconds = timeLeft % 60;

            document.getElementById('time').innerHTML = 'Time Left '+'' + hours + ':' + minutes + ':' + seconds;
        }

        function completed() {
           
            window.location="StudentResult.aspx"
        }
    }
</script>

<body  onload="startCountdown(1800);">
    <form id="form1" runat="server">
    <div>
        <div class="header">
            <div class="logo">
                <a href="#"><i class="fa fa-mortar-board"></i>&nbsp;Examination&nbsp;System</a>
            </div>
        </div>
    </div>
  <center>
    <div>
  <h3>Exam Name: <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></h3> &nbsp;
        <h3>Set By : <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></h3> 
        <br />
        
   </div>
     </center>
        <br />
        <br />
        <div style="float : right; position :fixed ; "> 
            <asp:Label ID="time" runat="server" Text="Label" ForeColor="#999999" Font-Size="16pt"></asp:Label>
            </div>
        
        
        <div class="questions">
           
        <center>  
            
           
           <asp:GridView runat="server" id="grd" AutoGenerateColumns="False" Width="50%" 
                BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" 
                CellPadding="1" CellSpacing="1" Font-Size="15pt" 
                AllowPaging="True" GridLines="None" PageSize="100">
        <Columns>
        <asp:TemplateField HeaderText="Question">
        <ItemTemplate>
           <asp:Label ID="qstn" runat="server" Text='<%#Eval("Question") %>'></asp:Label><br /><br />
            <asp:RadioButton ID="rad1" runat="server" Text='<%#Eval("Choice1") %>' GroupName="A" /><br />
            <asp:RadioButton ID="rad2" runat="server" Text='<%#Eval("Choice2") %>' GroupName="A" /><br />
            <asp:RadioButton ID="rad3" runat="server" Text='<%#Eval("Choice3") %>' GroupName="A" /><br />
            <asp:RadioButton ID="rad4" runat="server" Text='<%#Eval("Choice4") %>' GroupName="A" /><br />
           <asp:HiddenField ID="hf" runat ="server" value ='<%#Eval("Answer") %>' />
        </ItemTemplate>
        </asp:TemplateField>
        </Columns>
               <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
               <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
               <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
               <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
               <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
               <SortedAscendingCellStyle BackColor="#F1F1F1" />
               <SortedAscendingHeaderStyle BackColor="#594B9C" />
               <SortedDescendingCellStyle BackColor="#CAC9C9" />
               <SortedDescendingHeaderStyle BackColor="#33276A" />
        </asp:GridView>
            
            </center> 
            <br />
            <center >
        <asp:Button ID="btn" runat="server" Text="Submit Exam" OnClick="btn_Click" class="btn btn-info" /></center>
        </div>
        
    </form>
   
</body>
</html>
