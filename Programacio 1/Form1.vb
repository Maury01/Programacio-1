Public Class Form1
    Dim objRomano = New ConversorRomanos

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        lblRespuesta.Text = objRomano.Convertir(txtNumero.Text)
    End Sub
End Class

Class ConversorRomanos
    Dim Romanos()() As String = {
        New String() {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"},'0->Unidades
        New String() {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"},'1->Decenas
        New String() {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"} '2->Centenas
    }

    Dim U, D, C, Temp As Integer

    Public Function Convertir(ByVal Num As Integer)
        U = Num Mod 10
        C = Num \ 100
        Temp = Num Mod 100
        D = Temp \ 10

        Return Romanos(2)(C) + Romanos(1)(D) + Romanos(0)(U)
    End Function
End Class
