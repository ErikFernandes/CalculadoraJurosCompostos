Module ModuloUm

    Public Sub FiltroCampo(sender As Object, e As KeyPressEventArgs)

        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 44 Then

            e.Handled = True


        End If

    End Sub

End Module
