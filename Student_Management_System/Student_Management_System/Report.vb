﻿Public Class Report


    Private Sub Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'studentDBDataSet.basicDetails' table. You can move, or remove it, as needed.
        Me.basicDetailsTableAdapter.Fill(Me.studentDBDataSet.basicDetails)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class