Public Class Palindrome
    Private Sub Palindrome_Load(sender As Object, e As EventArgs) Handles Me.Load
        LB_Resultat.Text = ""
        LB_Resultat.ForeColor = Color.Empty
    End Sub

    Private Sub Verifier(sender As Object, e As EventArgs) Handles BT_verifier.Click

        Dim chaine As String
        chaine = Me.TextBox1.Text

        If Palin(chaine) = "oui" Then
            LB_Resultat.Text = "C'est un palindrome"
            LB_Resultat.ForeColor = Color.Green

        ElseIf Palin(chaine) = "non" Then
            LB_Resultat.Text = "Ce n'est pas un palindrome"
            LB_Resultat.ForeColor = Color.Red
        ElseIf Palin(chaine) = "" Then
            LB_Resultat.Text = ""
            LB_Resultat.ForeColor = Color.Empty
        End If

    End Sub

    Public Function Palin(ByVal chaine As String)
        Dim resultat As String

        If StrReverse(chaine) = (chaine) Then
            resultat = "oui"
        ElseIf StrReverse(chaine) <> (chaine) Then
            resultat = "non"
        ElseIf (chaine) = Nothing Then
            resultat = ""
        End If
        Return resultat
    End Function


End Class