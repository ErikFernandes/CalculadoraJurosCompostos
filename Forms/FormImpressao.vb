Public Class FormImpressao
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ResultJuros.Text = String.Format("R${0:N2}", Fundo.vjuros)

        ResultValorT.Text = String.Format("R${0:N2}", Fundo.resultTotal)

    End Sub

End Class