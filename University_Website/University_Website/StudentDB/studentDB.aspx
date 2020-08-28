<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="studentDB.aspx.vb" Inherits="University_Website.studentDB" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../bootstrap-3.3.7/dist/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="../font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <link href="../Css/master.css" rel="stylesheet" type="text/css" />
    <title>E-Admission Portal | University of Palampur</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container-fluid " style="height: 800px">
        <div class="container ">
            <div class="row">
                <div class="col-lg-2 ">
                </div>
                <div class="col-lg-8">
                    <img src="../Images/logo.png" alt="University Logo" height="80px" width="80px" />
                    &nbsp;
                    <h2 class="h2" id="logo1">
                        E-Admission Portal (University Of Palampur)<br />
                    </h2>
                </div>
                <div class="col-lg-2 text-right " style="padding-top: 30px">
                    <asp:Button ID="btnLogout" Text="Logout" CssClass="btn btn-xs btn-info  " runat="server" />
                </div>
            </div>
            <hr />
            <div class="row text-center">
                <label>
                    Please fill out the following details to complete the admission process</label></div>
            <div class="row" style="margin-top: 3%">
                <asp:MultiView ID="MultiView1" runat="server">
                    <asp:View ID="View1" runat="server">
                        <div class="col-md-12">
                            <fieldset>
                                <legend>Personal Information </legend>
                                <div class="col-md-4">
                                    <div class="form-group ">
                                        <label>
                                            Name
                                        </label>
                                        <asp:TextBox ID="txtName" CssClass="form-control" runat="server" ></asp:TextBox>
                                    </div>
                                    <div class="form-group ">
                                        <label>
                                            Father's Name
                                        </label>
                                        <asp:TextBox ID="txtFatherName" CssClass="form-control" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="form-group ">
                                        <label>
                                            Mother's Name
                                        </label>
                                        <asp:TextBox ID="txtMotherName" CssClass="form-control" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="form-group ">
                                        <label>
                                            Email ID
                                        </label>
                                        <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server" ReadOnly="True"></asp:TextBox>
                                    </div>
                                    <div class="form-group ">
                                        <label>
                                            Address
                                        </label>
                                        <asp:TextBox ID="TxtAddress" TextMode="MultiLine" CssClass="form-control" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="form-group ">
                                        <asp:Label ID="lblMessage" runat="server" Text="{{Message}}"></asp:Label>
                                    </div>
                                </div>
                                <div class="col-md-1">
                                </div>
                                <div class="col-md-4">
                                    <div class="form-group ">
                                        <label>
                                            Date of Birth
                                        </label>
                                        <asp:TextBox ID="txtBirth" CssClass="form-control" runat="server"></asp:TextBox>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                                            ErrorMessage="Invalid date. Date format dd/mm/yyyy" 
                                            ControlToValidate="txtBirth" ForeColor="#FF3300" 
                                            SetFocusOnError="True" 
                                            ValidationExpression="(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$"></asp:RegularExpressionValidator>
                                    </div>
                                    <div class="form-group ">
                                        <label>
                                            Gender</label>
                                        <asp:DropDownList ID="dropDownGender" runat="server" class="form-control">
                                            <asp:ListItem>Male</asp:ListItem>
                                            <asp:ListItem>Female</asp:ListItem>
                                            <asp:ListItem>Other</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="form-group ">
                                        <label>
                                            Mobile
                                        </label>
                                        <asp:TextBox ID="txtMobile" CssClass="form-control" runat="server" MaxLength="10"></asp:TextBox>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                            ErrorMessage="Only numbers are allowed" ControlToValidate="txtMobile" 
                                            ValidationExpression="\d+" ForeColor="Red"></asp:RegularExpressionValidator>
                                    </div>
                                    <div class="form-group ">
                                        <label>
                                            Category
                                        </label>
                                        <asp:DropDownList ID="dropDownCategory" runat="server" class="form-control  ">
                                            <asp:ListItem>GENERAL</asp:ListItem>
                                            <asp:ListItem>SC</asp:ListItem>
                                            <asp:ListItem>ST</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </fieldset>
                            <div class="row text-center " style="margin-top: 3%">
                                <div class="col-lg-4">
                                    <asp:Button ID="btnNext" runat="server" CssClass="btn btn-success btn-block " Text="Next" /></div>
                                <div class="col-lg-4">
                                </div>
                                <div class="col-lg-4">
                                </div>
                            </div>
                        </div>
                    </asp:View>
                    <asp:View ID="View2" runat="server">
                        <fieldset>
                            <legend>Education Qualification</legend>
                            <div class="form-inline ">
                                <table >
                                    <tr>
                                        <td>
                                            <label>
                                                10<sup>TH</sup></label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtPercentage10" CssClass="form-control " runat="server" placeholder="Percentage"></asp:TextBox>
                                       </td>
                                        <td>
                                            <asp:TextBox ID="txtBoard10" CssClass="form-control" runat="server" placeholder="Board"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtSchool10" CssClass="form-control" runat="server" placeholder="School"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtYear10" CssClass="form-control" runat="server" placeholder="Year of Passing"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                    <td>&nbsp;</td></tr>
                                    <tr>
                                        <td>
                                            <label>
                                                12<sup>TH</sup></label>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtPercentage12" CssClass="form-control " runat="server" placeholder="Percentage"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtBoard12" CssClass="form-control" runat="server" placeholder="Board"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtSchool12" CssClass="form-control" runat="server" placeholder="School"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtYear12" CssClass="form-control" runat="server" placeholder="Year of Passing"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </fieldset>
                        <br />
                        <br />
                        <fieldset>
                            <legend>University Course Selection</legend>
                            <div class="form-inline">
                                <div class="form-group">
                                    <label>
                                        Select course you are applying for :
                                    </label>
                                    <asp:DropDownList ID="dropDownCourse" CssClass="form-control" runat="server" AppendDataBoundItems="True"
                                        AutoPostBack="True">
                                        <asp:ListItem Text="Please Select" Value=""></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <asp:Label ID="lblFees" runat="server" Text="{{course Fee}}" ForeColor="#FF3300"></asp:Label>
                        </fieldset>
                        <div class="row text-center" style="margin-top: 3%">
                            <asp:Button ID="btnSendForm" runat="server" CssClass="btn btn-primary " Text="Submit Application" />
                        </div>
                    </asp:View>
                </asp:MultiView>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
