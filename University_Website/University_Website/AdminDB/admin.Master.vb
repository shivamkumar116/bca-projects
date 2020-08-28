Public Class admin
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("Admin") Is Nothing Then
            Response.Redirect("~/Login.aspx")
        End If

    End Sub
   


    Protected Sub lnkbtnLogOut_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lnkbtnLogOut.Click
        Session.RemoveAll()
        Response.Redirect("~/Login.aspx")
    End Sub
End Class