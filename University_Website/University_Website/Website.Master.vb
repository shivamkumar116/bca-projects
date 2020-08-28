Public Class Website
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Request.Url.AbsolutePath.EndsWith("index.aspx") Then
            linkHome.Attributes("class") = "active"
        ElseIf Request.Url.AbsolutePath.EndsWith("AboutUs.aspx") Then
            linkAbout.Attributes("class") = "active"

        End If

    End Sub

    Protected Sub btnLogin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogin.Click
        Response.Redirect("~/Login.aspx")
    End Sub

    Protected Sub btnRegister_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRegister.Click
        Response.Redirect("~/studentRegistration.aspx")
    End Sub
End Class