Public Class Fundo

    Public resultTotal As Decimal
    Public vjuros As Decimal
    Public cValor As Decimal
    Public i As Decimal
    Public t As Decimal
    Public cApor As Decimal



    Sub Clean()

        ValorApli.Text = ""
        Rendi.Text = ""
        Tempo.Text = ""

    End Sub

    Private Sub MostrarFormularioImpressao()

        Dim frm As New Form2()
        frm.Owner = Me
        frm.Show()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Try

            cValor = Double.Parse(ValorApli.Text)
            i = Double.Parse(Rendi.Text)
            t = Integer.Parse(Tempo.Text)

            If (valorAport.Text <> "") Then

                i /= 100

                cApor = Double.Parse(valorAport.Text)

                resultTotal = cApor * (((1 + i) ^ t - 1) / i) + cValor * (1 + i) ^ t

                vjuros = resultTotal - (cValor + (cApor * t))

                MostrarFormularioImpressao()

            ElseIf (valorAport.Text = "") Then


                i /= 100

                resultTotal = (cValor * (1 + i) ^ t)
                vjuros = resultTotal - Double.Parse(ValorApli.Text)

                MostrarFormularioImpressao()

            End If


        Catch

            MessageBox.Show("Entrada inválida")
            Clean()

        End Try

    End Sub


End Class
