Public Class Menu

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim Response As MsgBoxResult
        msg = "Esta seguro que desea salir?"
        style = MsgBoxStyle.DefaultButton2 Or
            MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
        title = "Salir"
        Response = MsgBox(msg, style, title)
        If Response = MsgBoxResult.Yes Then
            End
        End If
    End Sub
    Private Sub AgenteFamiliaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgenteFamiliaToolStripMenuItem.Click
        Dim a As New AgeFamMBA
        a.Show()
        Me.FindForm()
    End Sub

    Private Sub AgenteClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgenteClienteToolStripMenuItem.Click
        Dim a As New AgeCliMBA
        a.Show()
        Me.FindForm()
    End Sub

    Private Sub AgenteTipoCobroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgenteTipoCobroToolStripMenuItem.Click
        Dim a As New AgeTipCob
        a.Show()
        Me.FindForm()
    End Sub

    Private Sub AgentesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgentesToolStripMenuItem.Click
        Dim a As New AgeSL
        a.Show()
        Me.FindForm()
    End Sub
End Class