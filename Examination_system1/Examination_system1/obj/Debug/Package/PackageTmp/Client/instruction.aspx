<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="instruction.aspx.vb" Inherits="Examination_system1.instruction" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../CSS/buttons.css" rel="stylesheet" type="text/css" />
<link href="../CSS/Exam.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/global.css" rel="stylesheet" type="text/css" />
    <link href="../font-awesome/css/font-awesome.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/Input.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/Content.css "rel="stylesheet" type="text/css" />
    <title>Examination System | Instructions</title>

</head>
<body>
    <form id="form1" runat="server">
     <div>
        <div class="header">
        <div class="logo">
            <a href="#"><i class ="fa fa-mortar-board"></i>&nbsp;Examination&nbsp;System</a>
            </div>
            
    </div>
    </div>
      <div class="box">
           <div class="box-top">
          <center><b>INSTRUCTIONS
              </b></center>
           </div>
           <div style="float : right">
               <asp:Panel ID="Panel1" runat="server" >
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
               </asp:Panel>
           </div> 
           <div class ="box-panel"><b>Please read the following instructions carefully</b>
               <br />
               <br />

How to take the exam?
               <br />
               1.The clock has been set at server and count down timer at the top left corner of the screen will display left out time to closure from where you can monitor time you have to complete the exam.<br />
&nbsp;2.Click one of the answer option buttons to select your answer.<br />
3.To change an answer, simply click the desired option button.<br />
4.In case candidate does not want to attempt the question he I she should
not mouse-click any option.<br />
5.Each question will carry 1 mark.
<br />
6. Attempt all answer as there is  no negative marking
<br />
7. To submit the exam simply press "Submit Exam " Button.<br />
8.After the time left is over you will be automatically redirected to the result page.<br />

</div>
            <br />

            <div>
            Select Exam Code : - 
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </div>
            
         <center>  <button type="button" id="btn" runat ="server"  class="btn btn-warning" >Next</button></center>
            </div>
      <div class="footer">
    </div>
    </form>
</body>
</html>
