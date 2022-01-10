Public Class Login
    Private Sub ButtonIngresar_Click(sender As Object, e As EventArgs) Handles ButtonIngresar.Click
        Try
            LoginS(TextUsuario.Text, TextClave.Text)
            TextUsuario.Text = Nothing
            TextClave.Text = Nothing
            If usuarioLogin <> Nothing And perfilUsuario <> Nothing Then
                Me.Hide()
                Principal.Show()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class