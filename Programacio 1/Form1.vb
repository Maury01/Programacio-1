Public Class Form1
    Dim objInteres As New Interes()
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        objInteres.Inter = txtInteres.Text
        objInteres.Tiempo = txtTiempo.Text
        objInteres.Monto = txtCapital.Text
        lblInteresSimple.Text = "Interes Simple: $" & objInteres.InteresSimple()
        lblInteresCompuesto.Text = "Interes Compuesto: $" & objInteres.InteresCompuesto()
    End Sub
End Class

Class Interes
    Dim _Interes, Capital As Double, Ntiempo As Int16

    Public Property Inter
        Set(Value)
            If Value >= 0 And Value <= 100 Then
                _Interes = Value
            Else
                MessageBox.Show("El valor del interes no es valido", "Intereses", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Set
        Get
            Return _Interes
        End Get
    End Property

    Public Property Tiempo
        Set(Value)
            If Value >= 1 And Value <= 120 Then
                Ntiempo = Value
            Else
                MessageBox.Show("El Tiempo no es valido", "Tiempo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Set
        Get
            Return Ntiempo
        End Get
    End Property

    Public Property Monto
        Set(Value)
            If Value > 0 Then
                Capital = Value
            Else
                MessageBox.Show("El Capital debe ser mayor a 0", "Capital", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Set
        Get
            Return Capital
        End Get
    End Property

    Public Function InteresSimple()
        Dim IntereSimple = Capital * (_Interes / 100) * (Ntiempo / 12)
        Return Math.Round(IntereSimple, 2)
    End Function

    Public Function InteresCompuesto()
        Dim InterCompuesto = Capital * (1 + _Interes / 100) ^ Ntiempo
        Return Math.Round(InterCompuesto, 2)
    End Function
End Class
