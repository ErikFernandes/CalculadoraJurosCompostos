Public Class Fundo

    Public resultTotal As Decimal
    Public vjuros As Decimal
    Public cValor As Decimal
    Public i As Decimal
    Public t As Decimal
    Public cApor As Decimal

    Private Sub ValorApli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ValorApli.KeyPress

        FiltroCampo(sender, e)

    End Sub

    Private Sub Rendi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Rendi.KeyPress

        FiltroCampo(sender, e)

    End Sub

    Private Sub ValorAport_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ValorAport.KeyPress

        FiltroCampo(sender, e)

    End Sub

    Private Sub Tempo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tempo.KeyPress

        FiltroCampo(sender, e)

    End Sub



    Sub Clean()

        ValorApli.Text = ""
        Rendi.Text = ""
        Tempo.Text = ""
        ValorAport.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Try

            cValor = Double.Parse(ValorApli.Text)
            i = Double.Parse(Rendi.Text)
            t = Integer.Parse(Tempo.Text)

            If (ValorAport.Text <> "") Then

                i /= 100

                cApor = Double.Parse(ValorAport.Text)

                resultTotal = cApor * (((1 + i) ^ t - 1) / i) + cValor * (1 + i) ^ t

                vjuros = resultTotal - (cValor + (cApor * t))

                Using F As New FormImpressao()

                    F.ShowDialog()

                End Using

            ElseIf (ValorAport.Text = "") Then


                i /= 100

                resultTotal = (cValor * (1 + i) ^ t)
                vjuros = resultTotal - Double.Parse(ValorApli.Text)

                Using F As New FormImpressao()

                    F.ShowDialog()

                End Using

            End If


        Catch

            MessageBox.Show("Entrada inválida")
            Clean()

        End Try

    End Sub


End Class
