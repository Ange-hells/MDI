Public Class Chifumi

    Dim O_scor As Byte = 3
    Dim J_scor As Byte = 3
    Dim O_coup As Byte
    Dim J_coup As Byte
    'Dim Coup As Array

    Public Sub PlayChifumi(J_coup)
        While O_scor <> 0 And J_scor <> 0
            O_coup = O_Alea_Coup()
            If O_coup <> J_coup Then
                If (O_coup = 0 And J_coup = 1) Or (O_coup = 1 And J_coup = 2) Or (O_coup = 2 And J_coup = 0) Then
                    J_scor += 1
                ElseIf (J_coup = 0 And O_coup = 1) Or (J_coup = 1 And O_coup = 2) Or (J_coup = 2 And O_coup = 0) Then
                    O_scor += 1
                End If
            End If

        End While

    End Sub

    Private Function O_Alea_Coup()
        Dim numO_coup As Byte
        Randomize()

        Return numO_coup
    End Function

    Private Sub BT_Pierre_Click(sender As Object, e As EventArgs) Handles BT_Pierre.Click
        J_coup = 0
    End Sub

    Private Sub BT_Papier_Click(sender As Object, e As EventArgs) Handles BT_Papier.Click
        J_coup = 1
    End Sub

    Private Sub BT_Ciseau_Click(sender As Object, e As EventArgs) Handles BT_Ciseau.Click
        J_coup = 2
    End Sub
End Class