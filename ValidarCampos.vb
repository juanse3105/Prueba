Public Class ValidarCampos

    Class ValidarCampos()

    End Class
    Public Function numeros(e As KeyPressEventArgs) As KeyPressEventArgs
        If ((e.KeyChar < "0" Or e.KeyChar > "9") And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 8) Then
            e.KeyChar = vbNullString
        End If
        numeros = e
    End Function

    Public Function Enter(e As KeyEventArgs) As KeyEventArgs
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
        Enter = e
    End Function
End Class
