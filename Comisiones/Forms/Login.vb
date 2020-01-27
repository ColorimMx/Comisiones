Public Class Login

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "Colorim" And TextBox2.Text = "C$comision%2017" Then
            Loading.Show()
            Me.Hide()
        Else
            MsgBox("La contraseña es incorrecta", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
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

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class