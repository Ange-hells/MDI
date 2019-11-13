Public Class Calcul
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LB_resultat.Text = CStr((Calculer(CInt(TextBox1.Text))))
    End Sub

    Public Function Calculer(ByVal val As Integer) As Int64
        Dim somme As Int64
        Dim somme2 As Int64
        For i As Integer = 1 To val Step 1
            somme += i
            somme2 += i ^ 2
        Next
        Return somme ^ 2 + somme2
    End Function

End Class