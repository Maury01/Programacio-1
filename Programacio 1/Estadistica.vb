Public Class Estadistica
    Dim Media As Double

    Public Function CalcularMedia(Serie() As String)
        Media = 0
        For Each Num In Serie
            Media += Num
        Next
        Return Math.Round(Media / Serie.Length, 2)
    End Function

    Public Function CalcularVarianza(Serie() As String)
        Dim M = CalcularMedia(Serie), Varianza As Double

        For Each X1 In Serie
            Varianza += Math.Pow(X1 - M, 2)
        Next
        Return Varianza / Serie.Length
    End Function

    Public Function CalcularDesvTipica(Serie() As String)
        Dim Var = CalcularVarianza(Serie)
        Return Math.Round(Math.Sqrt(Var), 2)
    End Function
End Class
