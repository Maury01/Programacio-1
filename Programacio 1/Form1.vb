Public Class Form1

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblNTabla.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNTabla.TextChanged

    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim NTabla, i As SByte
        NTabla = txtNTabla.Text

        lstTabla.Items.Clear()

        If NTabla <= 12 Then
            For i = 1 To 10
                lstTabla.Items.Add(NTabla.ToString() + " X " + i.ToString() + " = " + (NTabla * i).ToString())
            Next
        Else
            lstTabla.Items.Add("El limite es 12.")
        End If
    End Sub
End Class
