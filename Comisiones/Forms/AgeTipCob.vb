Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class AgeTipCob

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Dim CR2 As New ComAgeTipCob
        Me.CrystalReportViewer1.ReportSource = CR2
        Me.CrystalReportViewer1.LogOnInfo.Item(0).ConnectionInfo.UserID = "ODBC"
        Me.CrystalReportViewer1.LogOnInfo.Item(0).ConnectionInfo.Password = "ODBC"
    End Sub
End Class