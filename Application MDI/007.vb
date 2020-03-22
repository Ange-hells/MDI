Public Class _007

    Dim O_vie As Byte = 3
    Dim J_vie As Byte = 3
    Dim O_coup As Byte
    Dim J_coup As Byte
    Dim O_charge As Byte
    Dim J_charge As Byte

    Public Sub Play007()
        While O_vie <> 0 And J_vie <> 0
            If O_charge < 1 Then
                BT_Tirer.Enabled = False
            End If
            If J_charge < 1 Then
                BT_Tirer.Enabled = False
            End If
            AleaSelctOCoup()
            If J_coup = 0 And O_coup = 0 Then
                O_charge += 1
                J_charge += 1
            ElseIf J_coup = 0 And O_coup = 1 Then
                J_charge += 1
                O_charge -= 1
                J_vie -= 1
            ElseIf J_coup = 0 And O_coup = 2 Then
                J_charge += 1
            ElseIf J_coup = 1 And O_coup = 0 Then
                O_charge += 1
                J_charge -= 1
                O_vie -= 1
            ElseIf J_coup = 1 And O_coup = 1 Then
                J_charge -= 1
                O_charge -= 1
                J_vie -= 1
                O_vie -= 1
            ElseIf J_coup = 1 And O_coup = 2 Then
                J_charge -= 1
            ElseIf J_coup = 2 And O_coup = 0 Then
                O_charge += 1
            ElseIf J_coup = 2 And O_coup = 1 Then
                O_charge -= 1
            ElseIf J_coup = 2 And O_coup = 2 Then

            End If

        End While

    End Sub

    Private Sub _007_Load(sender As Object, e As EventArgs) Handles Me.Load
        Play007()
    End Sub

    Public Function AleaSelctOCoup()


        Return O_coup
    End Function
End Class