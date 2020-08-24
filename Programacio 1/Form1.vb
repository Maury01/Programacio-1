Public Class Form1


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

            Case 4 'Colon de El Salvador a
                'Dolar Estadounidense
                If cboMoneda2.SelectedIndex = 1 Then
                    Valor = Cant * 0.1134721
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Euro
                If cboMoneda2.SelectedIndex = 2 Then
                    Valor = Cant * 0.0958459113
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yen
                If cboMoneda2.SelectedIndex = 3 Then
                    Valor = Cant * 12.04160251
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Colon de El Salvador
                If cboMoneda2.SelectedIndex = 4 Then
                    Valor = Cant * 1
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Bitcoin
                If cboMoneda2.SelectedIndex = 5 Then
                    Valor = Cant * 0.0000096
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Sol Peruano
                If cboMoneda2.SelectedIndex = 6 Then
                    Valor = Cant * 0.4078704706
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Peso Mexicano
                If cboMoneda2.SelectedIndex = 7 Then
                    Valor = Cant * 2.523381212
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Libra Esterlina
                If cboMoneda2.SelectedIndex = 8 Then
                    Valor = Cant * 0.0866285726
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Dolar Canadiense
                If cboMoneda2.SelectedIndex = 9 Then
                    Valor = Cant * 0.150063448
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yuan
                If cboMoneda2.SelectedIndex = 10 Then
                    Valor = Cant * 0.7856921676
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If

            Case 5 'Bitcoin a
                'Dolar Estadounidense
                If cboMoneda2.SelectedIndex = 1 Then
                    Valor = Cant * 11865.4
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Euro
                If cboMoneda2.SelectedIndex = 2 Then
                    Valor = Cant * 10003.06614
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yen
                If cboMoneda2.SelectedIndex = 3 Then
                    Valor = Cant * 1255216.935
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Colon de El Salvador
                If cboMoneda2.SelectedIndex = 4 Then
                    Valor = Cant * 103893.7627
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Bitcoin
                If cboMoneda2.SelectedIndex = 5 Then
                    Valor = Cant * 1
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Sol Peruano
                If cboMoneda2.SelectedIndex = 6 Then
                    Valor = Cant * 42305.62094
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Peso Mexicano
                If cboMoneda2.SelectedIndex = 7 Then
                    Valor = Cant * 261877.4679
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Libra Esterlina
                If cboMoneda2.SelectedIndex = 8 Then
                    Valor = Cant * 8975.670585
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Dolar Canadiense
                If cboMoneda2.SelectedIndex = 9 Then
                    Valor = Cant * 15640.61925
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yuan
                If cboMoneda2.SelectedIndex = 10 Then
                    Valor = Cant * 82026.03195
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If

            Case 6 'Sol Peruano a
                'Dolar Estadounidense
                If cboMoneda2.SelectedIndex = 1 Then
                    Valor = Cant * 0.2805695
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Euro
                If cboMoneda2.SelectedIndex = 2 Then
                    Valor = Cant * 0.2365481454
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yen
                If cboMoneda2.SelectedIndex = 3 Then
                    Valor = Cant * 29.68285025
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Colon de El Salvador
                If cboMoneda2.SelectedIndex = 4 Then
                    Valor = Cant * 2.456674117
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Bitcoin
                If cboMoneda2.SelectedIndex = 5 Then
                    Valor = Cant * 0.000024
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Sol Peruano
                If cboMoneda2.SelectedIndex = 6 Then
                    Valor = Cant * 1
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Peso Mexicano
                If cboMoneda2.SelectedIndex = 7 Then
                    Valor = Cant * 6.207569
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Libra Esterlina
                If cboMoneda2.SelectedIndex = 8 Then
                    Valor = Cant * 0.212227
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Dolar Canadiense
                If cboMoneda2.SelectedIndex = 9 Then
                    Valor = Cant * 0.3697278
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yuan
                If cboMoneda2.SelectedIndex = 10 Then
                    Valor = Cant * 1.940390605
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If

            Case 7 'Peso Mexicano a
                'Dolar Estadounidense
                If cboMoneda2.SelectedIndex = 1 Then
                    Valor = Cant * 0.0452965
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Euro
                If cboMoneda2.SelectedIndex = 2 Then
                    Valor = Cant * 0.038178627
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yen
                If cboMoneda2.SelectedIndex = 3 Then
                    Valor = Cant * 4.791259177
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Colon de El Salvador
                If cboMoneda2.SelectedIndex = 4 Then
                    Valor = Cant * 0.3965517068
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Bitcoin
                If cboMoneda2.SelectedIndex = 5 Then
                    Valor = Cant * 0.0000038
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Sol Peruano
                If cboMoneda2.SelectedIndex = 6 Then
                    Valor = Cant * 0.161404854
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Peso Mexicano
                If cboMoneda2.SelectedIndex = 7 Then
                    Valor = Cant * 1
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Libra Esterlina
                If cboMoneda2.SelectedIndex = 8 Then
                    Valor = Cant * 0.0342515
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Dolar Canadiense
                If cboMoneda2.SelectedIndex = 9 Then
                    Valor = Cant * 0.0596825
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yuan
                If cboMoneda2.SelectedIndex = 10 Then
                    Valor = Cant * 0.3130784359
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If

            Case 8 'Libra Esterlina a
                'Dolar Estadounidense
                If cboMoneda2.SelectedIndex = 1 Then
                    Valor = Cant * 1.3216
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Euro
                If cboMoneda2.SelectedIndex = 2 Then
                    Valor = Cant * 1.11397664
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yen
                If cboMoneda2.SelectedIndex = 3 Then
                    Valor = Cant * 139.8175
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Colon de El Salvador
                If cboMoneda2.SelectedIndex = 4 Then
                    Valor = Cant * 0.3965517068
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Bitcoin
                If cboMoneda2.SelectedIndex = 5 Then
                    Valor = Cant * 0.00011
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Sol Peruano
                If cboMoneda2.SelectedIndex = 6 Then
                    Valor = Cant * 4.711757
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Peso Mexicano
                If cboMoneda2.SelectedIndex = 7 Then
                    Valor = Cant * 29.19641703
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Libra Esterlina
                If cboMoneda2.SelectedIndex = 8 Then
                    Valor = Cant * 1
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Dolar Canadiense
                If cboMoneda2.SelectedIndex = 9 Then
                    Valor = Cant * 1.742714349
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yuan
                If cboMoneda2.SelectedIndex = 10 Then
                    Valor = Cant * 9.14074503
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If

            Case 9 'Dolar Canadiense a
                'Dolar Estadounidense
                If cboMoneda2.SelectedIndex = 1 Then
                    Valor = Cant * 0.758445
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Euro
                If cboMoneda2.SelectedIndex = 2 Then
                    Valor = Cant * 0.6394
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yen
                If cboMoneda2.SelectedIndex = 3 Then
                    Valor = Cant * 80.2424931
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Colon de El Salvador
                If cboMoneda2.SelectedIndex = 4 Then
                    Valor = Cant * 6.641008678
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Bitcoin
                If cboMoneda2.SelectedIndex = 5 Then
                    Valor = Cant * 0.000064
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Sol Peruano
                If cboMoneda2.SelectedIndex = 6 Then
                    Valor = Cant * 2.704223895
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Peso Mexicano
                If cboMoneda2.SelectedIndex = 7 Then
                    Valor = Cant * 16.74665184
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Libra Esterlina
                If cboMoneda2.SelectedIndex = 8 Then
                    Valor = Cant * 0.573915
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Dolar Canadiense
                If cboMoneda2.SelectedIndex = 9 Then
                    Valor = Cant * 1
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yuan
                If cboMoneda2.SelectedIndex = 10 Then
                    Valor = Cant * 5.245477637
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If

            Case 10 'Yuan a
                'Dolar Estadounidense
                If cboMoneda2.SelectedIndex = 1 Then
                    Valor = Cant * 0.14459434
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Euro
                If cboMoneda2.SelectedIndex = 2 Then
                    Valor = Cant * 0.1218919586
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yen
                If cboMoneda2.SelectedIndex = 3 Then
                    Valor = Cant * 15.29779198
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Colon de El Salvador
                If cboMoneda2.SelectedIndex = 4 Then
                    Valor = Cant * 1.266071945
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Bitcoin
                If cboMoneda2.SelectedIndex = 5 Then
                    Valor = Cant * 0.000012
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Sol Peruano
                If cboMoneda2.SelectedIndex = 6 Then
                    Valor = Cant * 0.51554548
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Peso Mexicano
                If cboMoneda2.SelectedIndex = 7 Then
                    Valor = Cant * 3.192136947
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Libra Esterlina
                If cboMoneda2.SelectedIndex = 8 Then
                    Valor = Cant * 0.1094094762
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Dolar Canadiense
                If cboMoneda2.SelectedIndex = 9 Then
                    Valor = Cant * 0.1906404075
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
                'Yuan
                If cboMoneda2.SelectedIndex = 10 Then
                    Valor = Cant * 1
                    txtResultadoMoneda.Text = Math.Round(Valor, 2)
                End If
        End Select
    End Sub

    Private Sub btnConvertirVolumen_Click(sender As Object, e As EventArgs) Handles btnConvertirVolumen.Click
        Dim Cant = txtCantVolumen.Text, Valor

        Select Case cboVolumen1.SelectedIndex
            Case 1 'Cucharadita EEUU a
                If cboVolumen2.SelectedIndex = 1 Then 'Cucharadita EEUU
                    Valor = Cant * 1
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 2 Then 'Cucharada EEUU
                    Valor = Cant * 0.333333
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 3 Then 'Pulgada Cubica
                    Valor = Cant * 0.300781
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 4 Then 'Taza EEUU
                    Valor = Cant * 0.020537156237482691
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 5 Then 'Onza Liquida EEUU
                    Valor = Cant * 0.16666
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 6 Then 'Mililitro
                    Valor = Cant * 4.92892
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 7 Then 'Litro
                    Valor = Cant * 0.00492892
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 8 Then 'Pie Cubico
                    Valor = Cant * 0.000174063
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 9 Then 'Galon EEUU
                    Valor = Cant * 0.00130208
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 10 Then 'Metro Cubico
                    Valor = Cant * 0.0000049289
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If

            Case 2 'Cucharada EEUU a
                If cboVolumen2.SelectedIndex = 1 Then 'Cucharadita EEUU
                    Valor = Cant * 3
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 2 Then 'Cucharada EEUU
                    Valor = Cant * 1
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 3 Then 'Pulgada Cubica
                    Valor = Cant * 0.902344
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 4 Then 'Taza EEUU
                    Valor = Cant * 0.0616115
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 5 Then 'Onza Liquida EEUU
                    Valor = Cant * 0.5
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 6 Then 'Mililitro
                    Valor = Cant * 14.7868
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 7 Then 'Litro
                    Valor = Cant * 0.0147868
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 8 Then 'Pie Cubico
                    Valor = Cant * 0.00052219
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 9 Then 'Galon EEUU
                    Valor = Cant * 0.00390625
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 10 Then 'Metro Cubico
                    Valor = Cant * 0.000014787
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If

            Case 3 'Pulgada Cubica a
                If cboVolumen2.SelectedIndex = 1 Then 'Cucharadita EEUU
                    Valor = Cant * 3.32468
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 2 Then 'Cucharada EEUU
                    Valor = Cant * 1.10823
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 3 Then 'Pulgada Cubica
                    Valor = Cant * 1
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 4 Then 'Taza EEUU
                    Valor = Cant * 0.0682794
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 5 Then 'Onza Liquida EEUU
                    Valor = Cant * 0.554113
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 6 Then 'Mililitro
                    Valor = Cant * 16.3871
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 7 Then 'Litro
                    Valor = Cant * 0.0163871
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 8 Then 'Pie Cubico
                    Valor = Cant * 0.000578704
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 9 Then 'Galon EEUU
                    Valor = Cant * 0.000578704
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 10 Then 'Metro Cubico
                    Valor = Cant * 0.000014787
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If

            Case 4 'Taza EEUU a
                If cboVolumen2.SelectedIndex = 1 Then 'Cucharadita EEUU
                    Valor = Cant * 48.6922
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 2 Then 'Cucharada EEUU
                    Valor = Cant * 16.2307
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 3 Then 'Pulgada Cubica
                    Valor = Cant * 14.6457
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 4 Then 'Taza EEUU
                    Valor = Cant * 1
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 5 Then 'Onza Liquida EEUU
                    Valor = Cant * 8.11537
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 6 Then 'Mililitro
                    Valor = Cant * 240
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 7 Then 'Litro
                    Valor = Cant * 0.24
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 8 Then 'Pie Cubico
                    Valor = Cant * 0.00847552
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 9 Then 'Galon EEUU
                    Valor = Cant * 0.0634013
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 10 Then 'Metro Cubico
                    Valor = Cant * 0.00024
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If

            Case 5 'Onza Liquida EEUU a
                If cboVolumen2.SelectedIndex = 1 Then 'Cucharadita EEUU
                    Valor = Cant * 6
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 2 Then 'Cucharada EEUU
                    Valor = Cant * 2
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 3 Then 'Pulgada Cubica
                    Valor = Cant * 1.80469
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 4 Then 'Taza EEUU
                    Valor = Cant * 0.123223
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 5 Then 'Onza Liquida EEUU
                    Valor = Cant * 1
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 6 Then 'Mililitro
                    Valor = Cant * 29.5735
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 7 Then 'Litro
                    Valor = Cant * 0.0295735
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 8 Then 'Pie Cubico
                    Valor = Cant * 0.00104438
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 9 Then 'Galon EEUU
                    Valor = Cant * 0.0078125
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 10 Then 'Metro Cubico
                    Valor = Cant * 0.000029574
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If

            Case 6 'Mililitro a
                If cboVolumen2.SelectedIndex = 1 Then 'Cucharadita EEUU
                    Valor = Cant * 0.202884
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 2 Then 'Cucharada EEUU
                    Valor = Cant * 0.067628
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 3 Then 'Pulgada Cubica
                    Valor = Cant * 0.0610237
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 4 Then 'Taza EEUU
                    Valor = Cant * 0.00416667
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 5 Then 'Onza Liquida EEUU
                    Valor = Cant * 0.033814
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 6 Then 'Mililitro
                    Valor = Cant * 1
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 7 Then 'Litro
                    Valor = Cant * 0.001
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 8 Then 'Pie Cubico
                    Valor = Cant * 0.000035315
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 9 Then 'Galon EEUU
                    Valor = Cant * 0.000264172
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 10 Then 'Metro Cubico
                    Valor = Cant * 0.000001
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If

            Case 7 'Litro a
                If cboVolumen2.SelectedIndex = 1 Then 'Cucharadita EEUU
                    Valor = Cant * 202.884
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 2 Then 'Cucharada EEUU
                    Valor = Cant * 67.628
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 3 Then 'Pulgada Cubica
                    Valor = Cant * 61.0237
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 4 Then 'Taza EEUU
                    Valor = Cant * 4.16667
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 5 Then 'Onza Liquida EEUU
                    Valor = Cant * 33.814
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 6 Then 'Mililitro
                    Valor = Cant * 1000
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 7 Then 'Litro
                    Valor = Cant * 1
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 8 Then 'Pie Cubico
                    Valor = Cant * 0.0353147
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 9 Then 'Galon EEUU
                    Valor = Cant * 0.264172
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 10 Then 'Metro Cubico
                    Valor = Cant * 0.001
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If

            Case 8 'Pie Cubico a
                If cboVolumen2.SelectedIndex = 1 Then 'Cucharadita EEUU
                    Valor = Cant * 5745.04
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 2 Then 'Cucharada EEUU
                    Valor = Cant * 1915.01
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 3 Then 'Pulgada Cubica
                    Valor = Cant * 1728
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 4 Then 'Taza EEUU
                    Valor = Cant * 117.987
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 5 Then 'Onza Liquida EEUU
                    Valor = Cant * 957.506
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 6 Then 'Mililitro
                    Valor = Cant * 28316.8
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 7 Then 'Litro
                    Valor = Cant * 28.3168
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 8 Then 'Pie Cubico
                    Valor = Cant * 1
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 9 Then 'Galon EEUU
                    Valor = Cant * 7.48052
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 10 Then 'Metro Cubico
                    Valor = Cant * 0.0283168
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If

            Case 9 'Galon EEUU a
                If cboVolumen2.SelectedIndex = 1 Then 'Cucharadita EEUU
                    Valor = Cant * 769
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 2 Then 'Cucharada EEUU
                    Valor = Cant * 256
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 3 Then 'Pulgada Cubica
                    Valor = Cant * 231
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 4 Then 'Taza EEUU
                    Valor = Cant * 15.7725
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 5 Then 'Onza Liquida EEUU
                    Valor = Cant * 128
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 6 Then 'Mililitro
                    Valor = Cant * 3785.41
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 7 Then 'Litro
                    Valor = Cant * 3.78541
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 8 Then 'Pie Cubico
                    Valor = Cant * 0.133681
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 9 Then 'Galon EEUU
                    Valor = Cant * 1
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 10 Then 'Metro Cubico
                    Valor = Cant * 0.00378541
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If

            Case 10 'Metro Cubico a
                If cboVolumen2.SelectedIndex = 1 Then 'Cucharadita EEUU
                    Valor = Cant * 202884
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 2 Then 'Cucharada EEUU
                    Valor = Cant * 67628
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 3 Then 'Pulgada Cubica
                    Valor = Cant * 61023.7
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 4 Then 'Taza EEUU
                    Valor = Cant * 4166.67
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 5 Then 'Onza Liquida EEUU
                    Valor = Cant * 33814
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 6 Then 'Mililitro
                    Valor = Cant * 1000000.0
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 7 Then 'Litro
                    Valor = Cant * 1000
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 8 Then 'Pie Cubico
                    Valor = Cant * 35.3147
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 9 Then 'Galon EEUU
                    Valor = Cant * 264.172
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
                If cboVolumen2.SelectedIndex = 10 Then 'Metro Cubico
                    Valor = Cant * 1
                    txtResultadoVolumen.Text = Math.Round(Valor, 2)
                End If
        End Select
    End Sub

    Private Sub btnConvertirAlmacenamiento_Click(sender As Object, e As EventArgs) Handles btnConvertirAlmacenamiento.Click
        Dim Cant, Valor As Long
        Cant = txtCantAlmacenamiento.Text
        Select Case cboAlmacenamiento1.SelectedIndex
            Case 1 'Bit a
                If cboAlmacenamiento2.SelectedIndex = 1 Then 'Bit
                    Valor = Cant * 1
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 2 Then 'Byte
                    Valor = Cant * 0.125
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 3 Then 'Kilobyte
                    Valor = Cant * 0.0001220703125
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 4 Then 'Megabyte
                    Valor = Cant * 0.00000011920928955
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 5 Then 'Gigabyte
                    Valor = Cant * 0.00000000011641532183
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 6 Then 'Terabyte
                    Valor = Cant * 0.00000000000011368683772
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 7 Then 'Petabyte
                    Valor = Cant * 0.00000000000000011102230246
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 8 Then 'Exabyte
                    Valor = Cant * 1.0842021725E-19
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 9 Then 'Zettabyte
                    Valor = Cant * 1.25E-22
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 10 Then 'Yottabyte
                    Valor = Cant * 1.25E-25
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If

            Case 2 'Byte a
                If cboAlmacenamiento2.SelectedIndex = 1 Then 'Bit
                    Valor = Cant * 8
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 2 Then 'Byte
                    Valor = Cant * 1
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 3 Then 'Kilobyte
                    Valor = Cant * 0.0009765625
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 4 Then 'Megabyte
                    Valor = Cant * 0.00000095367431641
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 5 Then 'Gigabyte
                    Valor = Cant * 0.00000000093132257462
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 6 Then 'Terabyte
                    Valor = Cant * 0.00000000000090949470177
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 7 Then 'Petabyte
                    Valor = Cant * 0.0000000000000008881784197
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 8 Then 'Exabyte
                    Valor = Cant * 8.6736173799E-19
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 9 Then 'Zettabyte
                    Valor = Cant * 1.0E-21
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 10 Then 'Yottabyte
                    Valor = Cant * 1.0E-24
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If

            Case 3 'Kilobyte a
                If cboAlmacenamiento2.SelectedIndex = 1 Then 'Bit
                    Valor = Cant * 8192
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 2 Then 'Byte
                    Valor = Cant * 1024
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 3 Then 'Kilobyte
                    Valor = Cant * 1
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 4 Then 'Megabyte
                    Valor = Cant * 0.0009765625
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 5 Then 'Gigabyte
                    Valor = Cant * 0.00000095367431641
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 6 Then 'Terabyte
                    Valor = Cant * 0.00000000093132257462
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 7 Then 'Petabyte
                    Valor = Cant * 0.00000000000090949470177
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 8 Then 'Exabyte
                    Valor = Cant * 0.0000000000000008881784197
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 9 Then 'Zettabyte
                    Valor = Cant * 1.0E-18
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 10 Then 'Yottabyte
                    Valor = Cant * 1.0E-21
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If

            Case 4 'Megabyte a
                If cboAlmacenamiento2.SelectedIndex = 1 Then 'Bit
                    Valor = Cant * 8388608
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 2 Then 'Byte
                    Valor = Cant * 1048576
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 3 Then 'Kilobyte
                    Valor = Cant * 1024
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 4 Then 'Megabyte
                    Valor = Cant * 1
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 5 Then 'Gigabyte
                    Valor = Cant * 0.0009765625
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 6 Then 'Terabyte
                    Valor = Cant * 0.00000095367431641
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 7 Then 'Petabyte
                    Valor = Cant * 0.00000000093132257462
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 8 Then 'Exabyte
                    Valor = Cant * 0.00000000000090949470177
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 9 Then 'Zettabyte
                    Valor = Cant * 0.000000000000001
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 10 Then 'Yottabyte
                    Valor = Cant * 1.0E-18
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If

            Case 5 'Gigabyte a
                If cboAlmacenamiento2.SelectedIndex = 1 Then 'Bit
                    Valor = Cant * 8589934592
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 2 Then 'Byte
                    Valor = Cant * 1073741824
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 3 Then 'Kilobyte
                    Valor = Cant * 1048576
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 4 Then 'Megabyte
                    Valor = Cant * 1024
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 5 Then 'Gigabyte
                    Valor = Cant * 1
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 6 Then 'Terabyte
                    Valor = Cant * 0.0009765625
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 7 Then 'Petabyte
                    Valor = Cant * 0.00000095367431641
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 8 Then 'Exabyte
                    Valor = Cant * 0.00000000093132257462
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 9 Then 'Zettabyte
                    Valor = Cant * 0.00000000000090949470177
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 10 Then 'Yottabyte
                    Valor = Cant * 0.0000000000000008881784197
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If

            Case 6 'Terabyte a
                If cboAlmacenamiento2.SelectedIndex = 1 Then 'Bit
                    Valor = Cant * 8796093022200
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 2 Then 'Byte
                    Valor = Cant * 1099511627800
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 3 Then 'Kilobyte
                    Valor = Cant * 1073741824
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 4 Then 'Megabyte
                    Valor = Cant * 1048576
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 5 Then 'Gigabyte
                    Valor = Cant * 1024
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 6 Then 'Terabyte
                    Valor = Cant * 1
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 7 Then 'Petabyte
                    Valor = Cant * 0.0009765625
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 8 Then 'Exabyte
                    Valor = Cant * 0.00000095367431641
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 9 Then 'Zettabyte
                    Valor = Cant * 0.00000000093132257462
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 10 Then 'Yottabyte
                    Valor = Cant * 0.00000000000090949470177
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If

            Case 7 'Petabyte a
                If cboAlmacenamiento2.SelectedIndex = 1 Then 'Bit
                    Valor = Cant * 9007199254700000
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 2 Then 'Byte
                    Valor = Cant * 1125899906800000
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 3 Then 'Kilobyte
                    Valor = Cant * 1099511627800
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 4 Then 'Megabyte
                    Valor = Cant * 1073741824
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 5 Then 'Gigabyte
                    Valor = Cant * 1048576
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 6 Then 'Terabyte
                    Valor = Cant * 1024
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 7 Then 'Petabyte
                    Valor = Cant * 1
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 8 Then 'Exabyte
                    Valor = Cant * 0.0009765625
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 9 Then 'Zettabyte
                    Valor = Cant * 0.00000095367431641
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 10 Then 'Yottabyte
                    Valor = Cant * 0.00000000093132257462
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If

            Case 8 'Exatabyte a
                If cboAlmacenamiento2.SelectedIndex = 1 Then 'Bit
                    Dim ExabyteABite As Decimal
                    ExabyteABite = 8.0E+18
                    Valor = Cant * ExabyteABite
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 2 Then 'Byte
                    Valor = Cant * 1152921504600000000
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 3 Then 'Kilobyte
                    Valor = Cant * 1125899906800000
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 4 Then 'Megabyte
                    Valor = Cant * 1099511627800
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 5 Then 'Gigabyte
                    Valor = Cant * 1073741824
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 6 Then 'Terabyte
                    Valor = Cant * 1048576
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 7 Then 'Petabyte
                    Valor = Cant * 1024
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 8 Then 'Exabyte
                    Valor = Cant * 1
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 9 Then 'Zettabyte
                    Valor = Cant * 0.0009765625
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 10 Then 'Yottabyte
                    Valor = Cant * 0.00000095367431641
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If

            Case 9 'Zetabyte a
                If cboAlmacenamiento2.SelectedIndex = 1 Then 'Bit
                    Dim ZetabyteABite As Decimal
                    Try
                        ZetabyteABite = 9.671406556917E+24
                        Valor = Cant * ZetabyteABite
                        txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                    Catch ex As Exception
                        txtResultadoAlmacenamiento.Text = ("Desbordamiento")
                    End Try
                End If
                If cboAlmacenamiento2.SelectedIndex = 2 Then 'Byte
                    Dim ZetabyteAByte As Decimal
                    Try
                        ZetabyteAByte = 1.2089258196146E+24
                        Valor = Cant * ZetabyteAByte
                        txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                    Catch ex As Exception
                        txtResultadoAlmacenamiento.Text = ("Desbordamiento")
                    End Try
                End If
                If cboAlmacenamiento2.SelectedIndex = 3 Then 'Kilobyte
                    Dim ZetabyteAKilobyte As Decimal
                    Try
                        ZetabyteAKilobyte = 1.15292150468E+18
                        Valor = Cant * ZetabyteAKilobyte
                        txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                    Catch ex As Exception
                        txtResultadoAlmacenamiento.Text = ("Desbordamiento")
                    End Try
                End If
                If cboAlmacenamiento2.SelectedIndex = 4 Then 'Megabyte
                    Valor = Cant * 1.1258999068426E+15
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 5 Then 'Gigabyte
                    Valor = Cant * 1099511627800
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 6 Then 'Terabyte
                    Valor = Cant * 1073741824
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 7 Then 'Petabyte
                    Valor = Cant * 1048576
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 8 Then 'Exabyte
                    Valor = Cant * 1024
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 9 Then 'Zettabyte
                    Valor = Cant * 1
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 10 Then 'Yottabyte
                    Valor = Cant * 0.0009765625
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If

            Case 10 'Yottabyte a
                If cboAlmacenamiento2.SelectedIndex = 1 Then 'Bit
                    Dim YottabyteABite As Decimal
                    Try
                        YottabyteABite = 9.671406556917E+24
                        Valor = Cant * YottabyteABite
                        txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                    Catch ex As Exception
                        txtResultadoAlmacenamiento.Text = ("Desbordamiento")
                    End Try
                End If
                If cboAlmacenamiento2.SelectedIndex = 2 Then 'Byte
                    Dim YottabyteAByte As Decimal
                    Try
                        YottabyteAByte = 1.2089258196146E+24
                        Valor = Cant * YottabyteAByte
                        txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                    Catch ex As Exception
                        txtResultadoAlmacenamiento.Text = ("Desbordamiento")
                    End Try
                End If
                If cboAlmacenamiento2.SelectedIndex = 3 Then 'Kilobyte
                    Dim YottabyteAKilobyte As Decimal
                    Try
                        YottabyteAKilobyte = 1.1805916207174E+21
                        Valor = Cant * YottabyteAKilobyte
                        txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                    Catch ex As Exception
                        txtResultadoAlmacenamiento.Text = ("Desbordamiento")
                    End Try
                End If
                If cboAlmacenamiento2.SelectedIndex = 4 Then 'Megabyte
                    Dim YottabyteAMegabyte As Decimal
                    Try
                        YottabyteAMegabyte = 1.1529215046068E+18
                        Valor = Cant * YottabyteAMegabyte
                        txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                    Catch ex As Exception
                        txtResultadoAlmacenamiento.Text = ("Desbordamiento")
                    End Try
                End If
                If cboAlmacenamiento2.SelectedIndex = 5 Then 'Gigabyte
                    Valor = Cant * 1.1258999068426E+15
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 6 Then 'Terabyte
                    Valor = Cant * 1099511627800
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 7 Then 'Petabyte
                    Valor = Cant * 1073741824
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 8 Then 'Exabyte
                    Valor = Cant * 104857
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 9 Then 'Zettabyte
                    Valor = Cant * 1024
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 10 Then 'Yottabyte
                    Valor = Cant * 1
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
        End Select
    End Sub

    'Medida de masa
    Private Sub btnConvertirMasa_Click(sender As Object, e As EventArgs) Handles btnConvertirMasa.Click
        Dim Cant = txtCantAlmacenamiento.Text, Valor As Double
        Select Case cboAlmacenamiento1.SelectedIndex
            Case 1 'tonelada a
                If cboAlmacenamiento2.SelectedIndex = 1 Then 'Tonelada
                    Valor = Cant * 1
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 2 Then 'Tonelada larga 
                    Valor = Cant * 0.984207
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 3 Then 'Tonelada corta
                    Valor = Cant * 1.10231
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 4 Then 'Stone
                    Valor = Cant * 157.473
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 5 Then 'Onza
                    Valor = Cant * 35274
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 6 Then 'Kilograma
                    Valor = Cant * 1000
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 7 Then 'Libra
                    Valor = Cant * 2204.62
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 8 Then 'Gramo  
                    Valor = Cant * 1000000.0
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 9 Then 'Miligramo
                    Valor = Cant * 1000000000.0
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 10 Then 'Microgramo
                    Valor = Cant * 1000000000000.0
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If

            Case 2 'tonelada larga a
                If cboAlmacenamiento2.SelectedIndex = 1 Then 'Tonelada
                    Valor = Cant * 1.01605
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 2 Then 'Tonelada larga 
                    Valor = Cant * 1
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 3 Then 'Tonelada corta
                    Valor = Cant * 1.12
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 4 Then 'Stone
                    Valor = Cant * 160
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 5 Then 'Onza
                    Valor = Cant * 35840
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 6 Then 'Kilograma
                    Valor = Cant * 1016.05
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 7 Then 'Libra
                    Valor = Cant * 2240
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 8 Then 'Gramo  
                    Valor = Cant * 1016000.0
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 9 Then 'Miligramo
                    Valor = Cant * 1016000000.0
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 10 Then 'Microgramo
                    Valor = Cant * 1016000000000.0
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If

            Case 3 'tonelada corta a
                If cboAlmacenamiento2.SelectedIndex = 1 Then 'Tonelada
                    Valor = Cant * 0.907185
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 2 Then 'Tonelada larga 
                    Valor = Cant * 0.892857
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 3 Then 'Tonelada corta
                    Valor = Cant * 1
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 4 Then 'Stone
                    Valor = Cant * 142.857
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 5 Then 'Onza
                    Valor = Cant * 32000
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 6 Then 'Kilograma
                    Valor = Cant * 907.185
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 7 Then 'Libra
                    Valor = Cant * 2000
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 8 Then 'Gramo  
                    Valor = Cant * 907185
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 9 Then 'Miligramo
                    Valor = Cant * 907200000.0
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 10 Then 'Microgramo
                    Valor = Cant * 907200000000.0
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If

            Case 4 'stone a
                If cboAlmacenamiento2.SelectedIndex = 1 Then 'Tonelada
                    Valor = Cant * 0.00635029
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 2 Then 'Tonelada larga 
                    Valor = Cant * 0.00625
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 3 Then 'Tonelada corta
                    Valor = Cant * 0.007
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 4 Then 'Stone
                    Valor = Cant * 1
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 5 Then 'Onza
                    Valor = Cant * 224
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 6 Then 'Kilograma
                    Valor = Cant * 6.35029
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 7 Then 'Libra
                    Valor = Cant * 14
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 8 Then 'Gramo  
                    Valor = Cant * 6350.29
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 9 Then 'Miligramo
                    Valor = Cant * 6350000.0
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 10 Then 'Microgramo
                    Valor = Cant * 6350000.0
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If

            Case 5 'onza a
                If cboAlmacenamiento2.SelectedIndex = 1 Then 'Tonelada
                    Valor = Cant * 0.00002835
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 2 Then 'Tonelada larga 
                    Valor = Cant * 0.000027902
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 3 Then 'Tonelada corta
                    Valor = Cant * 0.00003125
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 4 Then 'Stone
                    Valor = Cant * 0.00446429
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 5 Then 'Onza
                    Valor = Cant * 1
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 6 Then 'Kilograma
                    Valor = Cant * 0.0283495
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 7 Then 'Libra
                    Valor = Cant * 0.0625
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 8 Then 'Gramo  
                    Valor = Cant * 28.3495
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 9 Then 'Miligramo
                    Valor = Cant * 28349.5
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 10 Then 'Microgramo
                    Valor = Cant * 28350000.0
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If

            Case 6 'kilogramo a
                If cboAlmacenamiento2.SelectedIndex = 1 Then 'Tonelada
                    Valor = Cant * 0.001
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 2 Then 'Tonelada larga 
                    Valor = Cant * 0.000984207
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 3 Then 'Tonelada corta
                    Valor = Cant * 0.00110231
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 4 Then 'Stone
                    Valor = Cant * 0.157473
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 5 Then 'Onza
                    Valor = Cant * 35.274
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 6 Then 'Kilograma
                    Valor = Cant * 1
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 7 Then 'Libra
                    Valor = Cant * 2.20462
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 8 Then 'Gramo  
                    Valor = Cant * 1000
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 9 Then 'Miligramo
                    Valor = Cant * 1000000.0
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 10 Then 'Microgramo
                    Valor = Cant * 1000000000.0
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If

            Case 7 'libra a
                If cboAlmacenamiento2.SelectedIndex = 1 Then 'Tonelada
                    Valor = Cant * 0.000453592
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 2 Then 'Tonelada larga 
                    Valor = Cant * 0.000446429
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 3 Then 'Tonelada corta
                    Valor = Cant * 0.0005
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 4 Then 'Stone
                    Valor = Cant * 0.0714286
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 5 Then 'Onza
                    Valor = Cant * 16
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 6 Then 'Kilograma
                    Valor = Cant * 0.453592
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 7 Then 'Libra
                    Valor = Cant * 1
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 8 Then 'Gramo  
                    Valor = Cant * 453.592
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 9 Then 'Miligramo
                    Valor = Cant * 453592
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 10 Then 'Microgramo
                    Valor = Cant * 453600000.0
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If

            Case 8 'gramo a
                If cboAlmacenamiento2.SelectedIndex = 1 Then 'Tonelada
                    Valor = Cant * 0.000001
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 2 Then 'Tonelada larga 
                    Valor = Cant * 0.00000098421
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 3 Then 'Tonelada corta
                    Valor = Cant * 0.0000011023
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 4 Then 'Stone
                    Valor = Cant * 0.000157473
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 5 Then 'Onza
                    Valor = Cant * 0.035274
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 6 Then 'Kilograma
                    Valor = Cant * 0.001
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 7 Then 'Libra
                    Valor = Cant * 0.00220462
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 8 Then 'Gramo  
                    Valor = Cant * 1
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 9 Then 'Miligramo
                    Valor = Cant * 1000
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 10 Then 'Microgramo
                    Valor = Cant * 1000000.0
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If

            Case 9 'Miligramo a
                If cboAlmacenamiento2.SelectedIndex = 1 Then 'Tonelada
                    Valor = Cant * 0.000000001
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 2 Then 'Tonelada larga 
                    Valor = Cant * 0.00000000098421
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 3 Then 'Tonelada corta
                    Valor = Cant * 0.0000000011023
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 4 Then 'Stone
                    Valor = Cant * 0.00000015747
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 5 Then 'Onza
                    Valor = Cant * 0.000035274
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 6 Then 'Kilograma
                    Valor = Cant * 0.000001
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 7 Then 'Libra
                    Valor = Cant * 0.0000022046
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 8 Then 'Gramo  
                    Valor = Cant * 0.001
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 9 Then 'Miligramo
                    Valor = Cant * 1
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 10 Then 'Microgramo
                    Valor = Cant * 1000000.0
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If

            Case 10 'Microgramo a
                If cboAlmacenamiento2.SelectedIndex = 1 Then 'Tonelada
                    Valor = Cant * 0.000000000001
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 2 Then 'Tonelada larga 
                    Valor = Cant * 0.00000000000098421
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 3 Then 'Tonelada corta
                    Valor = Cant * 0.0000000000011023
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 4 Then 'Stone
                    Valor = Cant * 0.00000000015747
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 5 Then 'Onza
                    Valor = Cant * 0.000000035274
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 6 Then 'Kilograma
                    Valor = Cant * 0.000000001
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 7 Then 'Libra
                    Valor = Cant * 0.0000000022046
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 8 Then 'Gramo  
                    Valor = Cant * 0.000001
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 9 Then 'Miligramo
                    Valor = Cant * 0.001
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If
                If cboAlmacenamiento2.SelectedIndex = 10 Then 'Microgramo
                    Valor = Cant * 1
                    txtResultadoAlmacenamiento.Text = Math.Round(Valor, 2)
                End If

        End Select
    End Sub

    Private Sub btnConvertirTiempo_Click(sender As Object, e As EventArgs) Handles btnConvertirTiempo.Click
        Dim Cant = txtCantTiempo.Text, Valor
        Select Case cboTiempo1.SelectedIndex
            Case 1 'Década a
                If cboTiempo2.SelectedIndex = 1 Then 'decada
                    Valor = Cant * 1
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 2 Then 'Año natural
                    Valor = Cant * 10
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 3 Then 'MesS
                    Valor = Cant * 120
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 4 Then 'Semana
                    Valor = Cant * 521.429
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 5 Then 'Dia
                    Valor = Cant * 3650.0030003
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 6 Then 'Hora
                    Valor = Cant * 87600.0720072
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 7 Then 'Minuto
                    Valor = Cant * 5256004.320432
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 8 Then 'Segundo
                    Valor = Cant * 315360259.22591996
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 9 Then 'Milisegundos
                    Valor = Cant * 315360259225.92
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 10 Then 'Microsegundo
                    Valor = Cant * 315360259225920
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If

            Case 2 'Año natural
                If cboTiempo2.SelectedIndex = 1 Then 'decada
                    Valor = Cant * 0.1
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 2 Then 'Año natural
                    Valor = Cant * 1
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 3 Then 'Mes
                    Valor = Cant * 12
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 4 Then 'Semana
                    Valor = Cant * 52.1429
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 5 Then 'Dia
                    Valor = Cant * 365
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 6 Then 'Hora
                    Valor = Cant * 8760
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 7 Then 'Minuto
                    Valor = Cant * 525600
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 8 Then 'Segundo
                    Valor = Cant * 31540000.0
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 9 Then 'Milisegundos
                    Valor = Cant * 31540000000.0
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 10 Then 'Microsegundo
                    Valor = Cant * 31540000000000.0
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If

            Case 3 'Mes
                If cboTiempo2.SelectedIndex = 1 Then 'decada
                    Valor = Cant * 0.00833334
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 2 Then 'Año natural
                    Valor = Cant * 0.0833334
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 3 Then 'Mes
                    Valor = Cant * 1
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 4 Then 'Semana
                    Valor = Cant * 4.34524
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 5 Then 'Dia
                    Valor = Cant * 30.4167
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 6 Then 'Hora
                    Valor = Cant * 730.001
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 7 Then 'Minuto
                    Valor = Cant * 43800
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 8 Then 'Segundo
                    Valor = Cant * 2628000.0
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 9 Then 'Milisegundos
                    Valor = Cant * 2628000000.0
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 10 Then 'Microsegundo
                    Valor = Cant * 2628000000.0
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If

            Case 4 'Semana
                If cboTiempo2.SelectedIndex = 1 Then 'decada
                    Valor = Cant * 0.00191781
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 2 Then 'Año natural
                    Valor = Cant * 0.019178099999991784
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 3 Then 'Mes
                    Valor = Cant * 0.230137
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 4 Then 'Semana
                    Valor = Cant * 1
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 5 Then 'Dia
                    Valor = Cant * 7
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 6 Then 'Hora
                    Valor = Cant * 168
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 7 Then 'Minuto
                    Valor = Cant * 10080
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 8 Then 'Segundo
                    Valor = Cant * 604800
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 9 Then 'Milisegundos
                    Valor = Cant * 604800000.0
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 10 Then 'Microsegundo
                    Valor = Cant * 604800000000.0
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If

            Case 5 'dia
                If cboTiempo2.SelectedIndex = 1 Then 'decada
                    Valor = Cant * 0.000273973
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 2 Then 'Año natural
                    Valor = Cant * 0.00273973
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 3 Then 'Mes
                    Valor = Cant * 0.0328767
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 4 Then 'Semana
                    Valor = Cant * 0.142857
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 5 Then 'Dia
                    Valor = Cant * 1
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 6 Then 'Hora
                    Valor = Cant * 24
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 7 Then 'Minuto
                    Valor = Cant * 1440
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 8 Then 'Segundo
                    Valor = Cant * 86400
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 9 Then 'Milisegundos
                    Valor = Cant * 86400000.0
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 10 Then 'Microsegundo
                    Valor = Cant * 86400000000.0
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If

            Case 6 'hora
                If cboTiempo2.SelectedIndex = 1 Then 'decada
                    Valor = Cant * 0.000011416
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 2 Then 'Año natural
                    Valor = Cant * 0.000114155
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 3 Then 'Mes
                    Valor = Cant * 0.00136986
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 4 Then 'Semana
                    Valor = Cant * 0.00595238
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 5 Then 'Dia
                    Valor = Cant * 0.0416667
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 6 Then 'Hora
                    Valor = Cant * 1
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 7 Then 'Minuto
                    Valor = Cant * 60
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 8 Then 'Segundo
                    Valor = Cant * 3600
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 9 Then 'Milisegundos
                    Valor = Cant * 3600000.0
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 10 Then 'Microsegundo
                    Valor = Cant * 3600000000.0
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If

            Case 7 'minuto
                If cboTiempo2.SelectedIndex = 1 Then 'decada
                    Valor = Cant * 0.00000019026
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 2 Then 'Año natural
                    Valor = Cant * 0.0000019026
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 3 Then 'Mes
                    Valor = Cant * 0.000022831
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 4 Then 'Semana
                    Valor = Cant * 0.000099206
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 5 Then 'Dia
                    Valor = Cant * 0.000694444
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 6 Then 'Hora
                    Valor = Cant * 0.0166667
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 7 Then 'Minuto
                    Valor = Cant * 1
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 8 Then 'Segundo
                    Valor = Cant * 60
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 9 Then 'Milisegundos
                    Valor = Cant * 60000
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 10 Then 'Microsegundo
                    Valor = Cant * 60000000.0
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If

            Case 8 'segundo
                If cboTiempo2.SelectedIndex = 1 Then 'decada
                    Valor = Cant * 0.000000003171
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 2 Then 'Año natural
                    Valor = Cant * 0.00000003171
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 3 Then 'Mes
                    Valor = Cant * 0.00000038052
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 4 Then 'Semana
                    Valor = Cant * 0.0000016534
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 5 Then 'Dia
                    Valor = Cant * 0.000011574
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 6 Then 'Hora
                    Valor = Cant * 0.000277778
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 7 Then 'Minuto
                    Valor = Cant * 0.0166667
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 8 Then 'Segundo
                    Valor = Cant * 1
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 9 Then 'Milisegundos
                    Valor = Cant * 1000
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 10 Then 'Microsegundo
                    Valor = Cant * 1000000.0
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If

            Case 9 'Milisegundos
                If cboTiempo2.SelectedIndex = 1 Then 'decada
                    Valor = Cant * 0.000000000003171
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 2 Then 'Año natural
                    Valor = Cant * 0.00000000003171
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 3 Then 'Mes
                    Valor = Cant * 0.00000038052
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 4 Then 'Semana
                    Valor = Cant * 0.0000000016534
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 5 Then 'Dia
                    Valor = Cant * 0.000000011574
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 6 Then 'Hora
                    Valor = Cant * 0.00000027778
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 7 Then 'Minuto
                    Valor = Cant * 0.000016667
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 8 Then 'Segundo
                    Valor = Cant * 0.001
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 9 Then 'Milisegundos
                    Valor = Cant * 1
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 10 Then 'Microsegundo
                    Valor = Cant * 1000
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If

            Case 10 'Microsegundo
                If cboTiempo2.SelectedIndex = 1 Then 'decada
                    Valor = Cant * 0.000000000000003171
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 2 Then 'Año natural
                    Valor = Cant * 0.00000000000003171
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 3 Then 'Mes
                    Valor = Cant * 0.00000000000038052
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 4 Then 'Semana
                    Valor = Cant * 0.0000000000016534
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 5 Then 'Dia
                    Valor = Cant * 0.000000000011574
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 6 Then 'Hora
                    Valor = Cant * 0.00000000027778
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 7 Then 'Minuto
                    Valor = Cant * 0.000000016667
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 8 Then 'Segundo
                    Valor = Cant * 0.000001
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 9 Then 'Milisegundos
                    Valor = Cant * 0.001
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If
                If cboTiempo2.SelectedIndex = 10 Then 'Microsegundo
                    Valor = Cant * 1
                    txtResultadoTiempo.Text = Math.Round(Valor, 2)
                End If

        End Select
    End Sub

    'Medida de longitud
    Private Sub btmConvertirLongitud_Click(sender As Object, e As EventArgs) Handles btmConvertirLongitud.Click
        Dim Cant = txtCantLongitud.Text, Valor As Double
        Select Case cboLongitud1.SelectedIndex
            Case 1 'Milla nautica
                If cboLongitud2.SelectedIndex = 1 Then 'Milla nautica
                    Valor = Cant * 1
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 2 Then 'Milla 
                    Valor = Cant * 1.15078
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 3 Then 'Kilometro
                    Valor = Cant * 1.852
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 4 Then 'Metro
                    Valor = Cant * 1852
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 5 Then 'Yarda
                    Valor = Cant * 2025.37
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 6 Then 'Pie
                    Valor = Cant * 6076.12
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 7 Then 'Pulgada
                    Valor = Cant * 72913.4
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 8 Then 'Centimetro  
                    Valor = Cant * 185200
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 9 Then 'Milimetro
                    Valor = Cant * 1852000.0
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 10 Then 'Micrometro
                    Valor = Cant * 1852000000.0
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If

            Case 2 'Milla
                If cboLongitud2.SelectedIndex = 1 Then 'Milla nautica
                    Valor = Cant * 0.868976
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 2 Then 'Milla 
                    Valor = Cant * 1
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 3 Then 'Kilometro
                    Valor = Cant * 1.60934
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 4 Then 'Metro
                    Valor = Cant * 1609.34
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 5 Then 'Yarda
                    Valor = Cant * 1760
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 6 Then 'Pie
                    Valor = Cant * 5280
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 7 Then 'Pulgada
                    Valor = Cant * 63360
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 8 Then 'Centimetro  
                    Valor = Cant * 160934
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 9 Then 'Milimetro
                    Valor = Cant * 1609000.0
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 10 Then 'Micrometro
                    Valor = Cant * 1609000000.0
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If

            Case 3 'Kilometro
                If cboLongitud2.SelectedIndex = 1 Then 'Milla nautica
                    Valor = Cant * 0.539957
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 2 Then 'Milla 
                    Valor = Cant * 0.621371
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 3 Then 'Kilometro
                    Valor = Cant * 1
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 4 Then 'Metro
                    Valor = Cant * 1000
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 5 Then 'Yarda
                    Valor = Cant * 1093.61
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 6 Then 'Pie
                    Valor = Cant * 3280.84
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 7 Then 'Pulgada
                    Valor = Cant * 39370.1
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 8 Then 'Centimetro  
                    Valor = Cant * 100000
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 9 Then 'Milimetro
                    Valor = Cant * 1000000.0
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 10 Then 'Micrometro
                    Valor = Cant * 1000000000.0
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If

            Case 4 'Metro
                If cboLongitud2.SelectedIndex = 1 Then 'Milla nautica
                    Valor = Cant * 0.000539957
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 2 Then 'Milla 
                    Valor = Cant * 0.000621371
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 3 Then 'Kilometro
                    Valor = Cant * 0.001
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 4 Then 'Metro
                    Valor = Cant * 1
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 5 Then 'Yarda
                    Valor = Cant * 1.09361
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 6 Then 'Pie
                    Valor = Cant * 3.28084
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 7 Then 'Pulgada
                    Valor = Cant * 39.3701
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 8 Then 'Centimetro  
                    Valor = Cant * 100
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 9 Then 'Milimetro
                    Valor = Cant * 1000
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 10 Then 'Micrometro
                    Valor = Cant * 1000000.0
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If

            Case 5 'Yarda
                If cboLongitud2.SelectedIndex = 1 Then 'Milla nautica
                    Valor = Cant * 0.000493737
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 2 Then 'Milla 
                    Valor = Cant * 0.000568182
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 3 Then 'Kilometro
                    Valor = Cant * 0.0009144
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 4 Then 'Metro
                    Valor = Cant * 0.9144
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 5 Then 'Yarda
                    Valor = Cant * 1
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 6 Then 'Pie
                    Valor = Cant * 3
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 7 Then 'Pulgada
                    Valor = Cant * 36
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 8 Then 'Centimetro  
                    Valor = Cant * 91.44
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 9 Then 'Milimetro
                    Valor = Cant * 914.4
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 10 Then 'Micrometro
                    Valor = Cant * 914400
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If

            Case 6 'Pie
                If cboLongitud2.SelectedIndex = 1 Then 'Milla nautica
                    Valor = Cant * 0.000164579
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 2 Then 'Milla 
                    Valor = Cant * 0.000189394
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 3 Then 'Kilometro
                    Valor = Cant * 0.0003048
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 4 Then 'Metro
                    Valor = Cant * 0.3048
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 5 Then 'Yarda
                    Valor = Cant * 0.333333
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 6 Then 'Pie
                    Valor = Cant * 1
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 7 Then 'Pulgada
                    Valor = Cant * 12
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 8 Then 'Centimetro  
                    Valor = Cant * 30.48
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 9 Then 'Milimetro
                    Valor = Cant * 304.8
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 10 Then 'Micrometro
                    Valor = Cant * 304800
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If

            Case 7 'Pulgada
                If cboLongitud2.SelectedIndex = 1 Then 'Milla nautica
                    Valor = Cant * 0.000013715
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 2 Then 'Milla 
                    Valor = Cant * 0.000015783
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 3 Then 'Kilometro
                    Valor = Cant * 0.0000254
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 4 Then 'Metro
                    Valor = Cant * 0.0254
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 5 Then 'Yarda
                    Valor = Cant * 0.0277778
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 6 Then 'Pie
                    Valor = Cant * 0.0833333
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 7 Then 'Pulgada
                    Valor = Cant * 1
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 8 Then 'Centimetro  
                    Valor = Cant * 2.54
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 9 Then 'Milimetro
                    Valor = Cant * 25.4
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 10 Then 'Micrometro
                    Valor = Cant * 25400
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If

            Case 8 '8.	Centimetro
                If cboLongitud2.SelectedIndex = 1 Then 'Milla nautica
                    Valor = Cant * 0.0000053996
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 2 Then 'Milla 
                    Valor = Cant * 0.0000062137
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 3 Then 'Kilometro
                    Valor = Cant * 0.00001
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 4 Then 'Metro
                    Valor = Cant * 0.01
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 5 Then 'Yarda
                    Valor = Cant * 0.0109361
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 6 Then 'Pie
                    Valor = Cant * 0.0328084
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 7 Then 'Pulgada
                    Valor = Cant * 0.3937008
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 8 Then 'Centimetro  
                    Valor = Cant * 1
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 9 Then 'Milimetro
                    Valor = Cant * 10
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 10 Then 'Micrometro
                    Valor = Cant * 10000
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If

            Case 9 'Milimetro
                If cboLongitud2.SelectedIndex = 1 Then 'Milla nautica
                    Valor = Cant * 0.00000053996
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 2 Then 'Milla 
                    Valor = Cant * 0.00000062137
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 3 Then 'Kilometro
                    Valor = Cant * 0.000001
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 4 Then 'Metro
                    Valor = Cant * 0.001
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 5 Then 'Yarda
                    Valor = Cant * 0.00109361
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 6 Then 'Pie
                    Valor = Cant * 0.00328084
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 7 Then 'Pulgada
                    Valor = Cant * 0.0393701
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 8 Then 'Centimetro  
                    Valor = Cant * 0.1
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 9 Then 'Milimetro
                    Valor = Cant * 1
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 10 Then 'Micrometro
                    Valor = Cant * 1000
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If

            Case 10 'Micrometro
                If cboLongitud2.SelectedIndex = 1 Then 'Milla nautica
                    Valor = Cant * 0.00000000053996
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 2 Then 'Milla 
                    Valor = Cant * 0.00000000062137
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 3 Then 'Kilometro
                    Valor = Cant * 0.000000001
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 4 Then 'Metro
                    Valor = Cant * 0.000001
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 5 Then 'Yarda
                    Valor = Cant * 0.0000010936
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 6 Then 'Pie
                    Valor = Cant * 0.0000032808
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 7 Then 'Pulgada
                    Valor = Cant * 0.00003937
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 8 Then 'Centimetro  
                    Valor = Cant * 0.0001
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 9 Then 'Milimetro
                    Valor = Cant * 0.001
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If
                If cboLongitud2.SelectedIndex = 10 Then 'Micrometro
                    Valor = Cant * 1
                    txtResultadoLongitud.Text = Math.Round(Valor, 2)
                End If

        End Select
    End Sub

End Class
