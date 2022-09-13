Public Class FormImpressao
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ResultJuros.Text = String.Format("R${0:N2}", Fundo.vjuros)

        ResultValorT.Text = String.Format("R${0:N2}", Fundo.resultTotal)

    End Sub

    Private Sub FormImpressao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

        If Asc(e.KeyChar) = 27 Then

            Me.Close()

        End If

    End Sub
End Class