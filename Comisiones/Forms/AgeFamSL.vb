Public Class AgeFamSL
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim CR1 As New ComSlAgeFam
        Me.CrystalReportViewer1.ReportSource = CR1
        Me.CrystalReportViewer1.LogOnInfo.Item(0).ConnectionInfo.UserID = "sa"
        Me.CrystalReportViewer1.LogOnInfo.Item(0).ConnectionInfo.Password = "S$colorim%2022"
    End Sub
End Class