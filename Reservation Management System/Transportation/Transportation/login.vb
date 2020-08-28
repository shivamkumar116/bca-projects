Imports System.Windows.Forms
Imports System.Data.OleDb
Imports System.Data
Public Class login
    Dim con As New ADODB.Connection
    Dim rs As New ADODB.Recordset

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        con.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Project\Reservation Management System\Transportation.accdb")

    End Sub

    Private Sub cmdlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlogin.Click
        rs.Open("select * from Usertab where userid='" & txtuser.Text & "' and password='" & txtpass.Text & "'", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If Not rs.EOF Then
            main.Show()
            Me.Close()
        Else
            MsgBox("Invalid User OR Password ", MsgBoxStyle.Critical, "Invalid Login")

        End If
        rs.Close()
        txtpass.Text = ""
        txtuser.Text = ""
        con.Close()

    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        End


    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Changpass.Show()


    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Changusernm.Show()
    End Sub



End Class