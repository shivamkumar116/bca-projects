
Public Class Dashboard1
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Admin") Is Nothing Then
            Response.Redirect("~/Login.aspx")





        End If



        If (Request.Url.AbsolutePath.EndsWith("Dashboard.aspx")) Then
            LinkDb.Attributes("class") = "active"
        ElseIf (Request.Url.AbsolutePath.EndsWith("AddStudent.aspx")) Then
            LinkAddStudent.Attributes("class") = "active"
        ElseIf (Request.Url.AbsolutePath.EndsWith("Update.aspx")) Then
            LinkEdit.Attributes("class") = "active"
        ElseIf (Request.Url.AbsolutePath.EndsWith("SetExam.aspx")) Then
            LinkExam.Attributes("class") = "active"
        ElseIf (Request.Url.AbsolutePath.EndsWith("ExamInstruction1.aspx")) Then
            LinkExam.Attributes("class") = "active"
        ElseIf (Request.Url.AbsolutePath.EndsWith("ViewExam.aspx")) Then
            ViewExam.Attributes("class") = "active"
        ElseIf (Request.Url.AbsolutePath.EndsWith("Result.aspx")) Then
            LinkResult.Attributes("class") = "active"
        ElseIf (Request.Url.AbsolutePath.EndsWith("Reports.aspx")) Then
            LinkReport.Attributes("class") = "active"

        End If


    End Sub
    Protected Sub BtnLogout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnLogout.Click
        Session.RemoveAll()
        Response.Redirect("~/Login.aspx")
    End Sub
End Class