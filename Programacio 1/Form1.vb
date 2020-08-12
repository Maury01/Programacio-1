Public Class Form1

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblNTabla.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNTabla.TextChanged

    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim NTabla, i As Int64
        NTabla = txtNTabla.Text

        lstTabla.Items.Clear()

        Do While i <= 10
            lstTabla.Items.Add(NTabla.ToString() + " X " + i.ToString() + " = " + (NTabla * i).ToString())
            i = i + 1
        Loop

    End Sub
End Class
