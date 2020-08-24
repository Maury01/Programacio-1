Public Class Form1
    Dim objEstadistica As New Estadistica
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        lblRespuestaMedia.Text = objEstadistica.CalcularMedia(txtSerie.Text.Split(","))
        lblRespuetaVarianza.Text = objEstadistica.CalcularVarianza(txtSerie.Text.Split(","))
        lblRespuestaDesvTipica.Text = objEstadistica.CalcularDesvTipica(txtSerie.Text.Split(","))
    End Sub

    Private Sub grdEstadistica_KeyUp(sender As Object, e As KeyEventArgs) Handles grdEstadistica.KeyUp
        Dim NFilas = grdEstadistica.Rows.Count - 1,
            TotalF1 = 0,
            TotalX1xF1 = 0.0,
            TotalX21xF1 = 0.0
        Dim Fila As New DataGridViewRow

        For i = 0 To NFilas - 1
            Fila = grdEstadistica.Rows(i)
            Dim X1 = 0, F1 = 0
            If Fila.Cells("X1").Value <> "" Then
                X1 = Integer.Parse(Fila.Cells("X1").Value.ToString())
            End If
            If Fila.Cells("F1").Value <> "" Then
                F1 = Integer.Parse(Fila.Cells("F1").Value.ToString())
            End If
            TotalF1 += F1
            TotalX1xF1 += X1 * F1
            TotalX21xF1 += X1 ^ 2 * F1

            Fila.Cells("N1").Value = TotalF1.ToString()
            Fila.Cells("X1xF1").Value = (X1 * F1).ToString()
            Fila.Cells("X21xF1").Value = (X1 ^ 2 * F1).ToString()
        Next

        lblTotalF1.Text = TotalF1.ToString()
        lblTotalX1xF1.Text = TotalX1xF1.ToString()
        lblTotalX21xF1.Text = TotalX21xF1.ToString()

        Dim Media = Math.Round(TotalX1xF1 / TotalF1),
            Varianza = Math.Round(TotalX21xF1 / TotalF1 - Media ^ 2)
        lblRespuestaMedia.Text = Media.ToString()
        lblRespuetaVarianza.Text = Varianza.ToString()
        lblRespuestaDesvTipica.Text = Math.Round(Math.Sqrt(Varianza), 2).ToString()
    End Sub
End Class
