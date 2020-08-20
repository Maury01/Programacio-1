Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        'DSADA
    End Sub

    Private Sub btnConvertirMoneda_Click(sender As Object, e As EventArgs) Handles btnConvertirMoneda.Click
        Dim Cant = txtCantMoneda.Text, Valor As Double

        Select Case cboMoneda1.SelectedIndex
            Case 1 'Dolar estadonidense a
                'Dolar estadonidense
                If cboMoneda2.SelectedIndex = 1 Then
                    Valor = Cant * 1
                    txtResultadoMoneda.Text = (Valor)
                End If
                'Euro
                If cboMoneda2.SelectedIndex = 2 Then
                    Valor = Cant * 0.84458
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yen
                If cboMoneda2.SelectedIndex = 3 Then
                    Valor = Cant * 106.129
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Colon de El Salvador
                If cboMoneda2.SelectedIndex = 4 Then
                    Valor = Cant * 8.747063
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Bitcoin
                If cboMoneda2.SelectedIndex = 5 Then
                    Valor = Cant * 0.000085
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Sol Peruano
                If cboMoneda2.SelectedIndex = 6 Then
                    Valor = Cant * 3.565875
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Peso Mexicano
                If cboMoneda2.SelectedIndex = 7 Then
                    Valor = Cant * 22.14568
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Libra Esterlina
                If cboMoneda2.SelectedIndex = 8 Then
                    Valor = Cant * 0.76276
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Dolar Canadiense
                If cboMoneda2.SelectedIndex = 9 Then
                    Valor = Cant * 1.32155
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yuan
                If cboMoneda2.SelectedIndex = 10 Then
                    Valor = Cant * 6.9207
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If

            Case 2 'Euro a
                'Dolar Estadounidense
                If cboMoneda2.SelectedIndex = 1 Then
                    Valor = Cant * 1.184195
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Euro
                If cboMoneda2.SelectedIndex = 2 Then
                    Valor = Cant * 1
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yen
                If cboMoneda2.SelectedIndex = 3 Then
                    Valor = Cant * 125.5955003
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Colon de El Salvador
                If cboMoneda2.SelectedIndex = 4 Then
                    Valor = Cant * 10.35796585
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Bitcoin
                If cboMoneda2.SelectedIndex = 5 Then
                    Valor = Cant * 0.0001
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Sol Peruano
                If cboMoneda2.SelectedIndex = 6 Then
                    Valor = Cant * 4.223600643
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Peso Mexicano
                If cboMoneda2.SelectedIndex = 7 Then
                    Valor = Cant * 26.21389206
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Libra Esterlina
                If cboMoneda2.SelectedIndex = 8 Then
                    Valor = Cant * 0.90314
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Dolar Canadiense
                If cboMoneda2.SelectedIndex = 9 Then
                    Valor = Cant * 1.564775
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yuan
                If cboMoneda2.SelectedIndex = 10 Then
                    Valor = Cant * 8.1961
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
            Case 3 'Yen a
                'Dolar Estadounidense
                If cboMoneda2.SelectedIndex = 1 Then
                    Valor = Cant * 0.00941565
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Euro
                If cboMoneda2.SelectedIndex = 2 Then
                    Valor = Cant * 0.00796
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yen
                If cboMoneda2.SelectedIndex = 3 Then
                    Valor = Cant * 1
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Colon de El Salvador
                If cboMoneda2.SelectedIndex = 4 Then
                    Valor = Cant * 0.0830478319
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Bitcoin
                If cboMoneda2.SelectedIndex = 5 Then
                    Valor = Cant * 0.0000008003
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Sol Peruano
                If cboMoneda2.SelectedIndex = 6 Then
                    Valor = Cant * 0.0338534852
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Peso Mexicano
                If cboMoneda2.SelectedIndex = 7 Then
                    Valor = Cant * 0.2094891
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Libra Esterlina
                If cboMoneda2.SelectedIndex = 8 Then
                    Valor = Cant * 0.0071943966
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Dolar Canadiense
                If cboMoneda2.SelectedIndex = 9 Then
                    Valor = Cant * 0.012459
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yuan
                If cboMoneda2.SelectedIndex = 10 Then
                    Valor = Cant * 0.0651749
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
        End Select
    End Sub
End Class
