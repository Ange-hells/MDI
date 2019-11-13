Public Class Factoriel
    Private Sub Factoriel_Load(sender As Object, e As EventArgs) Handles Me.Load
        Detaile.Text = ""
        Result.Text = ""
    End Sub

    Private Sub BT_Calculer(sender As Object, e As EventArgs) Handles Calculer.Click
        Result.Text = nb_textbox.Text + " !" + " = " + CStr(Fx(CByte(nb_textbox.Text)))

        For x As SByte = CByte(nb_textbox.Text) To 1 Step -1
            If CByte(CStr(x)) >= 1 Then
                Detaile.Text += CStr(x) + " * "
            End If
        Next

    End Sub

    Private Function Fx(ByVal X As Byte) As UInt64
        If X = 0 Then
            Return 1
        Else
            Return X * Fx(X - 1)
        End If
    End Function

End Class