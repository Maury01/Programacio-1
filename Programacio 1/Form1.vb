Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim NTabla, i As SByte
        NTabla = txtNTabla.Text

        lstTabla.Items.Clear()
        If NTabla <= 12 Then
            For i = 1 To 10
                lstTabla.Items.Add(NTabla.ToString() + " X " + i.ToString() + " = " + (NTabla * i).ToString())
            Next
        Else
            lstTabla.Items.Add("Solo tablas menores a 12.")
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
End Class
