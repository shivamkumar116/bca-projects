﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.studentDBDataSet = New Student_Management_System.studentDBDataSet()
        Me.basicDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.basicDetailsTableAdapter = New Student_Management_System.studentDBDataSetTableAdapters.basicDetailsTableAdapter()
        CType(Me.studentDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.basicDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.basicDetailsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Student_Management_System.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(766, 478)
        Me.ReportViewer1.TabIndex = 0
        '
        'studentDBDataSet
        '
        Me.studentDBDataSet.DataSetName = "studentDBDataSet"
        Me.studentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'basicDetailsBindingSource
        '
        Me.basicDetailsBindingSource.DataMember = "basicDetails"
        Me.basicDetailsBindingSource.DataSource = Me.studentDBDataSet
        '
        'basicDetailsTableAdapter
        '
        Me.basicDetailsTableAdapter.ClearBeforeFill = True
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 478)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        CType(Me.studentDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.basicDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents basicDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents studentDBDataSet As Student_Management_System.studentDBDataSet
    Friend WithEvents basicDetailsTableAdapter As Student_Management_System.studentDBDataSetTableAdapters.basicDetailsTableAdapter
End Class
