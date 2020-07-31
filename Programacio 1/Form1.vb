Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblNum1.Click

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles optPotencia.CheckedChanged

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim Num1 As Double
        Dim Num2 As Double
        Num1 = TxtNum1.Text
        Num2 = TxtNum2.Text

        If optSuma.Checked Then
            lblRespuesta.Text = Num1 + Num2
        End If

        If optResta.Checked Then
            lblRespuesta.Text = Num1 - Num2
        End If

        If optMultiplicacion.Checked Then
            lblRespuesta.Text = Num1 * Num2
        End If

        If optDivision.Checked Then
            lblRespuesta.Text = Num1 / Num2
        End If

        If optPotencia.Checked Then
            lblRespuesta.Text = Num1 ^ Num2
        End If

        If optResiduo.Checked Then
            lblRespuesta.Text = Num1 Mod Num2
        End If

        If optPorcentaje.Checked Then
            lblRespuesta.Text = Num1 * (Num2 / 100)
        End If
    End Sub
End Class
