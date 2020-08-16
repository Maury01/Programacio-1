Public Class Form1
    Private Sub lstEjercicios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstEjercicios.SelectedIndexChanged

    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        lstEjercicios.Items.Clear()

        lstEjercicios.Items.Add("Números pares 1 - 20")
        For i = 2 To 20 Step 2
            lstEjercicios.Items.Add(i)
        Next

        lstEjercicios.Items.Add("")
        lstEjercicios.Items.Add("Números impares 1 - 20")
        For i = 1 To 20 Step 2
            lstEjercicios.Items.Add(i)
        Next
    End Sub

    Private Sub btnParImpar_Click(sender As Object, e As EventArgs) Handles btnParImpar.Click
        Dim Num = txtNumero.Text

        If Num Mod 2 = 0 Then
            MessageBox.Show("El número " + Num + " es par")
        Else
            MessageBox.Show("El número " + Num + " es impar")
        End If
    End Sub

    Private Sub btnPrimo_Click(sender As Object, e As EventArgs) Handles btnPrimo.Click
        Dim Num = txtNumero.Text, i = 0, Acu = 1

        While i < 3 And Acu <= Num
            If Num Mod Acu = 0 Then
                i += 1
            End If
            Acu += 1
        End While

        If i <= 2 Then
            MessageBox.Show("Es primo")
        Else
            MessageBox.Show("NO es primo")
        End If
    End Sub

    Private Sub btnCajero_Click(sender As Object, e As EventArgs) Handles btnCajero.Click
        Dim Monedas() = {100, 50, 20, 10, 5, 1, 0.5, 0.25, 0.01}, Valor = txtNumero.Text, Cantidad = 0
        Dim Denomina As String

        lstEjercicios.Items.Clear()

        For Each Moneda In Monedas
            While Valor > 0 And Moneda <= Valor
                Valor = Math.Round(Valor - Moneda, 2)
                Cantidad += 1
            End While

            If Cantidad > 0 Then
                If Moneda <= 1 Then
                    Denomina = "Moneda de "
                Else
                    Denomina = "Billete de "
                End If
            End If
            lstEjercicios.Items.Add(Cantidad.ToString() + Denomina + Moneda.ToString())
            Cantidad = 0
        Next
    End Sub
End Class
