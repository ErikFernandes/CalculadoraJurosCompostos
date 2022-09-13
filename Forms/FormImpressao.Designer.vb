<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormImpressao
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ResultValorT = New System.Windows.Forms.TextBox()
        Me.ResultJuros = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(147, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Valor Total"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(129, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Valor dos Juros"
        '
        'ResultValorT
        '
        Me.ResultValorT.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ResultValorT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ResultValorT.Font = New System.Drawing.Font("Courier New", 15.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ResultValorT.Location = New System.Drawing.Point(30, 147)
        Me.ResultValorT.Name = "ResultValorT"
        Me.ResultValorT.ReadOnly = True
        Me.ResultValorT.Size = New System.Drawing.Size(344, 24)
        Me.ResultValorT.TabIndex = 0
        Me.ResultValorT.TabStop = False
        Me.ResultValorT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ResultJuros
        '
        Me.ResultJuros.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ResultJuros.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ResultJuros.Font = New System.Drawing.Font("Courier New", 15.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ResultJuros.Location = New System.Drawing.Point(30, 57)
        Me.ResultJuros.Name = "ResultJuros"
        Me.ResultJuros.ReadOnly = True
        Me.ResultJuros.Size = New System.Drawing.Size(344, 24)
        Me.ResultJuros.TabIndex = 0
        Me.ResultJuros.TabStop = False
        Me.ResultJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FormImpressao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(405, 213)
        Me.Controls.Add(Me.ResultJuros)
        Me.Controls.Add(Me.ResultValorT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormImpressao"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Valor do Retorno"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ResultValorT As TextBox
    Friend WithEvents ResultJuros As TextBox
End Class
