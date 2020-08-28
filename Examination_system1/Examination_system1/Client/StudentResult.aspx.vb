Public Class StudentResult
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Email") Is Nothing Then
            Response.Redirect("~/Login.aspx")
        Else
            ClientName.Text = Session("Email").ToString()
        End If
        Label1.Text = Request.QueryString("Score")

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Response.Redirect("~/Client/Feedback.aspx")
    End Sub
End Class