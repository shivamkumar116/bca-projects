<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Admin/Dashboard.Master" CodeBehind="Reports.aspx.vb" Inherits="Examination_system1.Reporte" Debug ="true" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>

    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" 
        Font-Size="8pt" InteractiveDeviceInfos="(Collection)" 
        WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="100%">
        <LocalReport ReportPath="Admin\Report1.rdlc">
            <DataSources>
                <rsweb:ReportDataSource DataSourceId="AccessDataSource1" Name="DataSet1" />
            </DataSources>
        </LocalReport>
    </rsweb:ReportViewer>
    <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
        DataFile="~/Db/ExamDb.accdb" SelectCommand="SELECT * FROM [Result]">
    </asp:AccessDataSource>
    </asp:Content>
