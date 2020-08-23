Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
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

        Select Case cbpOperaciones.SelectedIndex
            Case 1
                lblRespuesta.Text = Num1 + Num2

            Case 2
                lblRespuesta.Text = Num1 - Num2

            Case 3
                lblRespuesta.Text = Num1 * Num2

            Case 4
                lblRespuesta.Text = Num1 / Num2

            Case 5
                lblRespuesta.Text = Num1 ^ Num2

            Case 6
                lblRespuesta.Text = Num1 Mod Num2

            Case 7
                lblRespuesta.Text = Num1 * (Num2 / 100)
        End Select
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbpOperaciones.SelectedIndexChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
