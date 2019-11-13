<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sudoku
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sudoku))
        Me.TB_A1 = New System.Windows.Forms.TextBox()
        Me.TB_A9 = New System.Windows.Forms.TextBox()
        Me.TB_A8 = New System.Windows.Forms.TextBox()
        Me.TB_A7 = New System.Windows.Forms.TextBox()
        Me.TB_A6 = New System.Windows.Forms.TextBox()
        Me.TB_A5 = New System.Windows.Forms.TextBox()
        Me.TB_A4 = New System.Windows.Forms.TextBox()
        Me.TB_A3 = New System.Windows.Forms.TextBox()
        Me.TB_A2 = New System.Windows.Forms.TextBox()
        Me.TB_D2 = New System.Windows.Forms.TextBox()
        Me.TB_D3 = New System.Windows.Forms.TextBox()
        Me.TB_D4 = New System.Windows.Forms.TextBox()
        Me.TB_D5 = New System.Windows.Forms.TextBox()
        Me.TB_D6 = New System.Windows.Forms.TextBox()
        Me.TB_D7 = New System.Windows.Forms.TextBox()
        Me.TB_D8 = New System.Windows.Forms.TextBox()
        Me.TB_D9 = New System.Windows.Forms.TextBox()
        Me.TB_D1 = New System.Windows.Forms.TextBox()
        Me.TB_C2 = New System.Windows.Forms.TextBox()
        Me.TB_C3 = New System.Windows.Forms.TextBox()
        Me.TB_C4 = New System.Windows.Forms.TextBox()
        Me.TB_C5 = New System.Windows.Forms.TextBox()
        Me.TB_C6 = New System.Windows.Forms.TextBox()
        Me.TB_C7 = New System.Windows.Forms.TextBox()
        Me.TB_C8 = New System.Windows.Forms.TextBox()
        Me.TB_C9 = New System.Windows.Forms.TextBox()
        Me.TB_C1 = New System.Windows.Forms.TextBox()
        Me.TB_E2 = New System.Windows.Forms.TextBox()
        Me.TB_E3 = New System.Windows.Forms.TextBox()
        Me.TB_E4 = New System.Windows.Forms.TextBox()
        Me.TB_E5 = New System.Windows.Forms.TextBox()
        Me.TB_E6 = New System.Windows.Forms.TextBox()
        Me.TB_E7 = New System.Windows.Forms.TextBox()
        Me.TB_E8 = New System.Windows.Forms.TextBox()
        Me.TB_E9 = New System.Windows.Forms.TextBox()
        Me.TB_E1 = New System.Windows.Forms.TextBox()
        Me.TB_F2 = New System.Windows.Forms.TextBox()
        Me.TB_F3 = New System.Windows.Forms.TextBox()
        Me.TB_F4 = New System.Windows.Forms.TextBox()
        Me.TB_F5 = New System.Windows.Forms.TextBox()
        Me.TB_F6 = New System.Windows.Forms.TextBox()
        Me.TB_F7 = New System.Windows.Forms.TextBox()
        Me.TB_F8 = New System.Windows.Forms.TextBox()
        Me.TB_F9 = New System.Windows.Forms.TextBox()
        Me.TB_F1 = New System.Windows.Forms.TextBox()
        Me.TB_G2 = New System.Windows.Forms.TextBox()
        Me.TB_G3 = New System.Windows.Forms.TextBox()
        Me.TB_G4 = New System.Windows.Forms.TextBox()
        Me.TB_G5 = New System.Windows.Forms.TextBox()
        Me.TB_G6 = New System.Windows.Forms.TextBox()
        Me.TB_G7 = New System.Windows.Forms.TextBox()
        Me.TB_G8 = New System.Windows.Forms.TextBox()
        Me.TB_G9 = New System.Windows.Forms.TextBox()
        Me.TB_G1 = New System.Windows.Forms.TextBox()
        Me.TB_B2 = New System.Windows.Forms.TextBox()
        Me.TB_B3 = New System.Windows.Forms.TextBox()
        Me.TB_B4 = New System.Windows.Forms.TextBox()
        Me.TB_B5 = New System.Windows.Forms.TextBox()
        Me.TB_B6 = New System.Windows.Forms.TextBox()
        Me.TB_B7 = New System.Windows.Forms.TextBox()
        Me.TB_B8 = New System.Windows.Forms.TextBox()
        Me.TB_B9 = New System.Windows.Forms.TextBox()
        Me.TB_B1 = New System.Windows.Forms.TextBox()
        Me.TB_H2 = New System.Windows.Forms.TextBox()
        Me.TB_H3 = New System.Windows.Forms.TextBox()
        Me.TB_H4 = New System.Windows.Forms.TextBox()
        Me.TB_H5 = New System.Windows.Forms.TextBox()
        Me.TB_H6 = New System.Windows.Forms.TextBox()
        Me.TB_H7 = New System.Windows.Forms.TextBox()
        Me.TB_H8 = New System.Windows.Forms.TextBox()
        Me.TB_H9 = New System.Windows.Forms.TextBox()
        Me.TB_H1 = New System.Windows.Forms.TextBox()
        Me.TB_I2 = New System.Windows.Forms.TextBox()
        Me.TB_I3 = New System.Windows.Forms.TextBox()
        Me.TB_I4 = New System.Windows.Forms.TextBox()
        Me.TB_I5 = New System.Windows.Forms.TextBox()
        Me.TB_I6 = New System.Windows.Forms.TextBox()
        Me.TB_I7 = New System.Windows.Forms.TextBox()
        Me.TB_I8 = New System.Windows.Forms.TextBox()
        Me.TB_I9 = New System.Windows.Forms.TextBox()
        Me.TB_I1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TB_A1
        '
        Me.TB_A1.Location = New System.Drawing.Point(12, 12)
        Me.TB_A1.Name = "TB_A1"
        Me.TB_A1.Size = New System.Drawing.Size(20, 20)
        Me.TB_A1.TabIndex = 0
        '
        'TB_A9
        '
        Me.TB_A9.Location = New System.Drawing.Point(220, 12)
        Me.TB_A9.Name = "TB_A9"
        Me.TB_A9.Size = New System.Drawing.Size(20, 20)
        Me.TB_A9.TabIndex = 1
        '
        'TB_A8
        '
        Me.TB_A8.Location = New System.Drawing.Point(194, 12)
        Me.TB_A8.Name = "TB_A8"
        Me.TB_A8.Size = New System.Drawing.Size(20, 20)
        Me.TB_A8.TabIndex = 2
        '
        'TB_A7
        '
        Me.TB_A7.Location = New System.Drawing.Point(168, 12)
        Me.TB_A7.Name = "TB_A7"
        Me.TB_A7.Size = New System.Drawing.Size(20, 20)
        Me.TB_A7.TabIndex = 3
        '
        'TB_A6
        '
        Me.TB_A6.Location = New System.Drawing.Point(142, 12)
        Me.TB_A6.Name = "TB_A6"
        Me.TB_A6.Size = New System.Drawing.Size(20, 20)
        Me.TB_A6.TabIndex = 4
        '
        'TB_A5
        '
        Me.TB_A5.Location = New System.Drawing.Point(116, 12)
        Me.TB_A5.Name = "TB_A5"
        Me.TB_A5.Size = New System.Drawing.Size(20, 20)
        Me.TB_A5.TabIndex = 5
        '
        'TB_A4
        '
        Me.TB_A4.Location = New System.Drawing.Point(90, 12)
        Me.TB_A4.Name = "TB_A4"
        Me.TB_A4.Size = New System.Drawing.Size(20, 20)
        Me.TB_A4.TabIndex = 6
        '
        'TB_A3
        '
        Me.TB_A3.Location = New System.Drawing.Point(64, 12)
        Me.TB_A3.Name = "TB_A3"
        Me.TB_A3.Size = New System.Drawing.Size(20, 20)
        Me.TB_A3.TabIndex = 7
        '
        'TB_A2
        '
        Me.TB_A2.Location = New System.Drawing.Point(38, 12)
        Me.TB_A2.Name = "TB_A2"
        Me.TB_A2.Size = New System.Drawing.Size(20, 20)
        Me.TB_A2.TabIndex = 8
        '
        'TB_D2
        '
        Me.TB_D2.Location = New System.Drawing.Point(38, 90)
        Me.TB_D2.Name = "TB_D2"
        Me.TB_D2.Size = New System.Drawing.Size(20, 20)
        Me.TB_D2.TabIndex = 17
        '
        'TB_D3
        '
        Me.TB_D3.Location = New System.Drawing.Point(64, 90)
        Me.TB_D3.Name = "TB_D3"
        Me.TB_D3.Size = New System.Drawing.Size(20, 20)
        Me.TB_D3.TabIndex = 16
        '
        'TB_D4
        '
        Me.TB_D4.Location = New System.Drawing.Point(90, 90)
        Me.TB_D4.Name = "TB_D4"
        Me.TB_D4.Size = New System.Drawing.Size(20, 20)
        Me.TB_D4.TabIndex = 15
        '
        'TB_D5
        '
        Me.TB_D5.Location = New System.Drawing.Point(116, 90)
        Me.TB_D5.Name = "TB_D5"
        Me.TB_D5.Size = New System.Drawing.Size(20, 20)
        Me.TB_D5.TabIndex = 14
        '
        'TB_D6
        '
        Me.TB_D6.Location = New System.Drawing.Point(142, 90)
        Me.TB_D6.Name = "TB_D6"
        Me.TB_D6.Size = New System.Drawing.Size(20, 20)
        Me.TB_D6.TabIndex = 13
        '
        'TB_D7
        '
        Me.TB_D7.Location = New System.Drawing.Point(168, 90)
        Me.TB_D7.Name = "TB_D7"
        Me.TB_D7.Size = New System.Drawing.Size(20, 20)
        Me.TB_D7.TabIndex = 12
        '
        'TB_D8
        '
        Me.TB_D8.Location = New System.Drawing.Point(194, 90)
        Me.TB_D8.Name = "TB_D8"
        Me.TB_D8.Size = New System.Drawing.Size(20, 20)
        Me.TB_D8.TabIndex = 11
        '
        'TB_D9
        '
        Me.TB_D9.Location = New System.Drawing.Point(220, 90)
        Me.TB_D9.Name = "TB_D9"
        Me.TB_D9.Size = New System.Drawing.Size(20, 20)
        Me.TB_D9.TabIndex = 10
        '
        'TB_D1
        '
        Me.TB_D1.Location = New System.Drawing.Point(12, 90)
        Me.TB_D1.Name = "TB_D1"
        Me.TB_D1.Size = New System.Drawing.Size(20, 20)
        Me.TB_D1.TabIndex = 9
        '
        'TB_C2
        '
        Me.TB_C2.Location = New System.Drawing.Point(38, 64)
        Me.TB_C2.Name = "TB_C2"
        Me.TB_C2.Size = New System.Drawing.Size(20, 20)
        Me.TB_C2.TabIndex = 26
        '
        'TB_C3
        '
        Me.TB_C3.Location = New System.Drawing.Point(64, 64)
        Me.TB_C3.Name = "TB_C3"
        Me.TB_C3.Size = New System.Drawing.Size(20, 20)
        Me.TB_C3.TabIndex = 25
        '
        'TB_C4
        '
        Me.TB_C4.Location = New System.Drawing.Point(90, 64)
        Me.TB_C4.Name = "TB_C4"
        Me.TB_C4.Size = New System.Drawing.Size(20, 20)
        Me.TB_C4.TabIndex = 24
        '
        'TB_C5
        '
        Me.TB_C5.Location = New System.Drawing.Point(116, 64)
        Me.TB_C5.Name = "TB_C5"
        Me.TB_C5.Size = New System.Drawing.Size(20, 20)
        Me.TB_C5.TabIndex = 23
        '
        'TB_C6
        '
        Me.TB_C6.Location = New System.Drawing.Point(142, 64)
        Me.TB_C6.Name = "TB_C6"
        Me.TB_C6.Size = New System.Drawing.Size(20, 20)
        Me.TB_C6.TabIndex = 22
        '
        'TB_C7
        '
        Me.TB_C7.Location = New System.Drawing.Point(168, 64)
        Me.TB_C7.Name = "TB_C7"
        Me.TB_C7.Size = New System.Drawing.Size(20, 20)
        Me.TB_C7.TabIndex = 21
        '
        'TB_C8
        '
        Me.TB_C8.Location = New System.Drawing.Point(194, 64)
        Me.TB_C8.Name = "TB_C8"
        Me.TB_C8.Size = New System.Drawing.Size(20, 20)
        Me.TB_C8.TabIndex = 20
        '
        'TB_C9
        '
        Me.TB_C9.Location = New System.Drawing.Point(220, 64)
        Me.TB_C9.Name = "TB_C9"
        Me.TB_C9.Size = New System.Drawing.Size(20, 20)
        Me.TB_C9.TabIndex = 19
        '
        'TB_C1
        '
        Me.TB_C1.Location = New System.Drawing.Point(12, 64)
        Me.TB_C1.Name = "TB_C1"
        Me.TB_C1.Size = New System.Drawing.Size(20, 20)
        Me.TB_C1.TabIndex = 18
        '
        'TB_E2
        '
        Me.TB_E2.Location = New System.Drawing.Point(38, 116)
        Me.TB_E2.Name = "TB_E2"
        Me.TB_E2.Size = New System.Drawing.Size(20, 20)
        Me.TB_E2.TabIndex = 35
        '
        'TB_E3
        '
        Me.TB_E3.Location = New System.Drawing.Point(64, 116)
        Me.TB_E3.Name = "TB_E3"
        Me.TB_E3.Size = New System.Drawing.Size(20, 20)
        Me.TB_E3.TabIndex = 34
        '
        'TB_E4
        '
        Me.TB_E4.Location = New System.Drawing.Point(90, 116)
        Me.TB_E4.Name = "TB_E4"
        Me.TB_E4.Size = New System.Drawing.Size(20, 20)
        Me.TB_E4.TabIndex = 33
        '
        'TB_E5
        '
        Me.TB_E5.Location = New System.Drawing.Point(116, 116)
        Me.TB_E5.Name = "TB_E5"
        Me.TB_E5.Size = New System.Drawing.Size(20, 20)
        Me.TB_E5.TabIndex = 32
        '
        'TB_E6
        '
        Me.TB_E6.Location = New System.Drawing.Point(142, 116)
        Me.TB_E6.Name = "TB_E6"
        Me.TB_E6.Size = New System.Drawing.Size(20, 20)
        Me.TB_E6.TabIndex = 31
        '
        'TB_E7
        '
        Me.TB_E7.Location = New System.Drawing.Point(168, 116)
        Me.TB_E7.Name = "TB_E7"
        Me.TB_E7.Size = New System.Drawing.Size(20, 20)
        Me.TB_E7.TabIndex = 30
        '
        'TB_E8
        '
        Me.TB_E8.Location = New System.Drawing.Point(194, 116)
        Me.TB_E8.Name = "TB_E8"
        Me.TB_E8.Size = New System.Drawing.Size(20, 20)
        Me.TB_E8.TabIndex = 29
        '
        'TB_E9
        '
        Me.TB_E9.Location = New System.Drawing.Point(220, 116)
        Me.TB_E9.Name = "TB_E9"
        Me.TB_E9.Size = New System.Drawing.Size(20, 20)
        Me.TB_E9.TabIndex = 28
        '
        'TB_E1
        '
        Me.TB_E1.Location = New System.Drawing.Point(12, 116)
        Me.TB_E1.Name = "TB_E1"
        Me.TB_E1.Size = New System.Drawing.Size(20, 20)
        Me.TB_E1.TabIndex = 27
        '
        'TB_F2
        '
        Me.TB_F2.Location = New System.Drawing.Point(38, 142)
        Me.TB_F2.Name = "TB_F2"
        Me.TB_F2.Size = New System.Drawing.Size(20, 20)
        Me.TB_F2.TabIndex = 44
        '
        'TB_F3
        '
        Me.TB_F3.Location = New System.Drawing.Point(64, 142)
        Me.TB_F3.Name = "TB_F3"
        Me.TB_F3.Size = New System.Drawing.Size(20, 20)
        Me.TB_F3.TabIndex = 43
        '
        'TB_F4
        '
        Me.TB_F4.Location = New System.Drawing.Point(90, 142)
        Me.TB_F4.Name = "TB_F4"
        Me.TB_F4.Size = New System.Drawing.Size(20, 20)
        Me.TB_F4.TabIndex = 42
        '
        'TB_F5
        '
        Me.TB_F5.Location = New System.Drawing.Point(116, 142)
        Me.TB_F5.Name = "TB_F5"
        Me.TB_F5.Size = New System.Drawing.Size(20, 20)
        Me.TB_F5.TabIndex = 41
        '
        'TB_F6
        '
        Me.TB_F6.Location = New System.Drawing.Point(142, 142)
        Me.TB_F6.Name = "TB_F6"
        Me.TB_F6.Size = New System.Drawing.Size(20, 20)
        Me.TB_F6.TabIndex = 40
        '
        'TB_F7
        '
        Me.TB_F7.Location = New System.Drawing.Point(168, 142)
        Me.TB_F7.Name = "TB_F7"
        Me.TB_F7.Size = New System.Drawing.Size(20, 20)
        Me.TB_F7.TabIndex = 39
        '
        'TB_F8
        '
        Me.TB_F8.Location = New System.Drawing.Point(194, 142)
        Me.TB_F8.Name = "TB_F8"
        Me.TB_F8.Size = New System.Drawing.Size(20, 20)
        Me.TB_F8.TabIndex = 38
        '
        'TB_F9
        '
        Me.TB_F9.Location = New System.Drawing.Point(220, 142)
        Me.TB_F9.Name = "TB_F9"
        Me.TB_F9.Size = New System.Drawing.Size(20, 20)
        Me.TB_F9.TabIndex = 37
        '
        'TB_F1
        '
        Me.TB_F1.Location = New System.Drawing.Point(12, 142)
        Me.TB_F1.Name = "TB_F1"
        Me.TB_F1.Size = New System.Drawing.Size(20, 20)
        Me.TB_F1.TabIndex = 36
        '
        'TB_G2
        '
        Me.TB_G2.Location = New System.Drawing.Point(38, 168)
        Me.TB_G2.Name = "TB_G2"
        Me.TB_G2.Size = New System.Drawing.Size(20, 20)
        Me.TB_G2.TabIndex = 53
        '
        'TB_G3
        '
        Me.TB_G3.Location = New System.Drawing.Point(64, 168)
        Me.TB_G3.Name = "TB_G3"
        Me.TB_G3.Size = New System.Drawing.Size(20, 20)
        Me.TB_G3.TabIndex = 52
        '
        'TB_G4
        '
        Me.TB_G4.Location = New System.Drawing.Point(90, 168)
        Me.TB_G4.Name = "TB_G4"
        Me.TB_G4.Size = New System.Drawing.Size(20, 20)
        Me.TB_G4.TabIndex = 51
        '
        'TB_G5
        '
        Me.TB_G5.Location = New System.Drawing.Point(116, 168)
        Me.TB_G5.Name = "TB_G5"
        Me.TB_G5.Size = New System.Drawing.Size(20, 20)
        Me.TB_G5.TabIndex = 50
        '
        'TB_G6
        '
        Me.TB_G6.Location = New System.Drawing.Point(142, 168)
        Me.TB_G6.Name = "TB_G6"
        Me.TB_G6.Size = New System.Drawing.Size(20, 20)
        Me.TB_G6.TabIndex = 49
        '
        'TB_G7
        '
        Me.TB_G7.Location = New System.Drawing.Point(168, 168)
        Me.TB_G7.Name = "TB_G7"
        Me.TB_G7.Size = New System.Drawing.Size(20, 20)
        Me.TB_G7.TabIndex = 48
        '
        'TB_G8
        '
        Me.TB_G8.Location = New System.Drawing.Point(194, 168)
        Me.TB_G8.Name = "TB_G8"
        Me.TB_G8.Size = New System.Drawing.Size(20, 20)
        Me.TB_G8.TabIndex = 47
        '
        'TB_G9
        '
        Me.TB_G9.Location = New System.Drawing.Point(220, 168)
        Me.TB_G9.Name = "TB_G9"
        Me.TB_G9.Size = New System.Drawing.Size(20, 20)
        Me.TB_G9.TabIndex = 46
        '
        'TB_G1
        '
        Me.TB_G1.Location = New System.Drawing.Point(12, 168)
        Me.TB_G1.Name = "TB_G1"
        Me.TB_G1.Size = New System.Drawing.Size(20, 20)
        Me.TB_G1.TabIndex = 45
        '
        'TB_B2
        '
        Me.TB_B2.Location = New System.Drawing.Point(38, 38)
        Me.TB_B2.Name = "TB_B2"
        Me.TB_B2.Size = New System.Drawing.Size(20, 20)
        Me.TB_B2.TabIndex = 62
        '
        'TB_B3
        '
        Me.TB_B3.Location = New System.Drawing.Point(64, 38)
        Me.TB_B3.Name = "TB_B3"
        Me.TB_B3.Size = New System.Drawing.Size(20, 20)
        Me.TB_B3.TabIndex = 61
        '
        'TB_B4
        '
        Me.TB_B4.Location = New System.Drawing.Point(90, 38)
        Me.TB_B4.Name = "TB_B4"
        Me.TB_B4.Size = New System.Drawing.Size(20, 20)
        Me.TB_B4.TabIndex = 60
        '
        'TB_B5
        '
        Me.TB_B5.Location = New System.Drawing.Point(116, 38)
        Me.TB_B5.Name = "TB_B5"
        Me.TB_B5.Size = New System.Drawing.Size(20, 20)
        Me.TB_B5.TabIndex = 59
        '
        'TB_B6
        '
        Me.TB_B6.Location = New System.Drawing.Point(142, 38)
        Me.TB_B6.Name = "TB_B6"
        Me.TB_B6.Size = New System.Drawing.Size(20, 20)
        Me.TB_B6.TabIndex = 58
        '
        'TB_B7
        '
        Me.TB_B7.Location = New System.Drawing.Point(168, 38)
        Me.TB_B7.Name = "TB_B7"
        Me.TB_B7.Size = New System.Drawing.Size(20, 20)
        Me.TB_B7.TabIndex = 57
        '
        'TB_B8
        '
        Me.TB_B8.Location = New System.Drawing.Point(194, 38)
        Me.TB_B8.Name = "TB_B8"
        Me.TB_B8.Size = New System.Drawing.Size(20, 20)
        Me.TB_B8.TabIndex = 56
        '
        'TB_B9
        '
        Me.TB_B9.Location = New System.Drawing.Point(220, 38)
        Me.TB_B9.Name = "TB_B9"
        Me.TB_B9.Size = New System.Drawing.Size(20, 20)
        Me.TB_B9.TabIndex = 55
        '
        'TB_B1
        '
        Me.TB_B1.Location = New System.Drawing.Point(12, 38)
        Me.TB_B1.Name = "TB_B1"
        Me.TB_B1.Size = New System.Drawing.Size(20, 20)
        Me.TB_B1.TabIndex = 54
        '
        'TB_H2
        '
        Me.TB_H2.Location = New System.Drawing.Point(38, 194)
        Me.TB_H2.Name = "TB_H2"
        Me.TB_H2.Size = New System.Drawing.Size(20, 20)
        Me.TB_H2.TabIndex = 71
        '
        'TB_H3
        '
        Me.TB_H3.Location = New System.Drawing.Point(64, 194)
        Me.TB_H3.Name = "TB_H3"
        Me.TB_H3.Size = New System.Drawing.Size(20, 20)
        Me.TB_H3.TabIndex = 70
        '
        'TB_H4
        '
        Me.TB_H4.Location = New System.Drawing.Point(90, 194)
        Me.TB_H4.Name = "TB_H4"
        Me.TB_H4.Size = New System.Drawing.Size(20, 20)
        Me.TB_H4.TabIndex = 69
        '
        'TB_H5
        '
        Me.TB_H5.Location = New System.Drawing.Point(116, 194)
        Me.TB_H5.Name = "TB_H5"
        Me.TB_H5.Size = New System.Drawing.Size(20, 20)
        Me.TB_H5.TabIndex = 68
        '
        'TB_H6
        '
        Me.TB_H6.Location = New System.Drawing.Point(142, 194)
        Me.TB_H6.Name = "TB_H6"
        Me.TB_H6.Size = New System.Drawing.Size(20, 20)
        Me.TB_H6.TabIndex = 67
        '
        'TB_H7
        '
        Me.TB_H7.Location = New System.Drawing.Point(168, 194)
        Me.TB_H7.Name = "TB_H7"
        Me.TB_H7.Size = New System.Drawing.Size(20, 20)
        Me.TB_H7.TabIndex = 66
        '
        'TB_H8
        '
        Me.TB_H8.Location = New System.Drawing.Point(194, 194)
        Me.TB_H8.Name = "TB_H8"
        Me.TB_H8.Size = New System.Drawing.Size(20, 20)
        Me.TB_H8.TabIndex = 65
        '
        'TB_H9
        '
        Me.TB_H9.Location = New System.Drawing.Point(220, 194)
        Me.TB_H9.Margin = New System.Windows.Forms.Padding(0)
        Me.TB_H9.Name = "TB_H9"
        Me.TB_H9.Size = New System.Drawing.Size(20, 20)
        Me.TB_H9.TabIndex = 64
        '
        'TB_H1
        '
        Me.TB_H1.Location = New System.Drawing.Point(12, 194)
        Me.TB_H1.Name = "TB_H1"
        Me.TB_H1.Size = New System.Drawing.Size(20, 20)
        Me.TB_H1.TabIndex = 63
        '
        'TB_I2
        '
        Me.TB_I2.Location = New System.Drawing.Point(38, 220)
        Me.TB_I2.Name = "TB_I2"
        Me.TB_I2.Size = New System.Drawing.Size(20, 20)
        Me.TB_I2.TabIndex = 80
        '
        'TB_I3
        '
        Me.TB_I3.Location = New System.Drawing.Point(64, 220)
        Me.TB_I3.Name = "TB_I3"
        Me.TB_I3.Size = New System.Drawing.Size(20, 20)
        Me.TB_I3.TabIndex = 79
        '
        'TB_I4
        '
        Me.TB_I4.Location = New System.Drawing.Point(90, 220)
        Me.TB_I4.Name = "TB_I4"
        Me.TB_I4.Size = New System.Drawing.Size(20, 20)
        Me.TB_I4.TabIndex = 78
        '
        'TB_I5
        '
        Me.TB_I5.Location = New System.Drawing.Point(116, 220)
        Me.TB_I5.Name = "TB_I5"
        Me.TB_I5.Size = New System.Drawing.Size(20, 20)
        Me.TB_I5.TabIndex = 77
        '
        'TB_I6
        '
        Me.TB_I6.Location = New System.Drawing.Point(142, 220)
        Me.TB_I6.Name = "TB_I6"
        Me.TB_I6.Size = New System.Drawing.Size(20, 20)
        Me.TB_I6.TabIndex = 76
        '
        'TB_I7
        '
        Me.TB_I7.Location = New System.Drawing.Point(168, 220)
        Me.TB_I7.Name = "TB_I7"
        Me.TB_I7.Size = New System.Drawing.Size(20, 20)
        Me.TB_I7.TabIndex = 75
        '
        'TB_I8
        '
        Me.TB_I8.Location = New System.Drawing.Point(194, 220)
        Me.TB_I8.Name = "TB_I8"
        Me.TB_I8.Size = New System.Drawing.Size(20, 20)
        Me.TB_I8.TabIndex = 74
        '
        'TB_I9
        '
        Me.TB_I9.Location = New System.Drawing.Point(220, 220)
        Me.TB_I9.Margin = New System.Windows.Forms.Padding(0)
        Me.TB_I9.Name = "TB_I9"
        Me.TB_I9.Size = New System.Drawing.Size(20, 20)
        Me.TB_I9.TabIndex = 73
        '
        'TB_I1
        '
        Me.TB_I1.Location = New System.Drawing.Point(12, 220)
        Me.TB_I1.Name = "TB_I1"
        Me.TB_I1.Size = New System.Drawing.Size(20, 20)
        Me.TB_I1.TabIndex = 72
        '
        'Sudoku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(252, 253)
        Me.Controls.Add(Me.TB_I2)
        Me.Controls.Add(Me.TB_I3)
        Me.Controls.Add(Me.TB_I4)
        Me.Controls.Add(Me.TB_I5)
        Me.Controls.Add(Me.TB_I6)
        Me.Controls.Add(Me.TB_I7)
        Me.Controls.Add(Me.TB_I8)
        Me.Controls.Add(Me.TB_I9)
        Me.Controls.Add(Me.TB_I1)
        Me.Controls.Add(Me.TB_H2)
        Me.Controls.Add(Me.TB_H3)
        Me.Controls.Add(Me.TB_H4)
        Me.Controls.Add(Me.TB_H5)
        Me.Controls.Add(Me.TB_H6)
        Me.Controls.Add(Me.TB_H7)
        Me.Controls.Add(Me.TB_H8)
        Me.Controls.Add(Me.TB_H9)
        Me.Controls.Add(Me.TB_H1)
        Me.Controls.Add(Me.TB_B2)
        Me.Controls.Add(Me.TB_B3)
        Me.Controls.Add(Me.TB_B4)
        Me.Controls.Add(Me.TB_B5)
        Me.Controls.Add(Me.TB_B6)
        Me.Controls.Add(Me.TB_B7)
        Me.Controls.Add(Me.TB_B8)
        Me.Controls.Add(Me.TB_B9)
        Me.Controls.Add(Me.TB_B1)
        Me.Controls.Add(Me.TB_G2)
        Me.Controls.Add(Me.TB_G3)
        Me.Controls.Add(Me.TB_G4)
        Me.Controls.Add(Me.TB_G5)
        Me.Controls.Add(Me.TB_G6)
        Me.Controls.Add(Me.TB_G7)
        Me.Controls.Add(Me.TB_G8)
        Me.Controls.Add(Me.TB_G9)
        Me.Controls.Add(Me.TB_G1)
        Me.Controls.Add(Me.TB_F2)
        Me.Controls.Add(Me.TB_F3)
        Me.Controls.Add(Me.TB_F4)
        Me.Controls.Add(Me.TB_F5)
        Me.Controls.Add(Me.TB_F6)
        Me.Controls.Add(Me.TB_F7)
        Me.Controls.Add(Me.TB_F8)
        Me.Controls.Add(Me.TB_F9)
        Me.Controls.Add(Me.TB_F1)
        Me.Controls.Add(Me.TB_E2)
        Me.Controls.Add(Me.TB_E3)
        Me.Controls.Add(Me.TB_E4)
        Me.Controls.Add(Me.TB_E5)
        Me.Controls.Add(Me.TB_E6)
        Me.Controls.Add(Me.TB_E7)
        Me.Controls.Add(Me.TB_E8)
        Me.Controls.Add(Me.TB_E9)
        Me.Controls.Add(Me.TB_E1)
        Me.Controls.Add(Me.TB_C2)
        Me.Controls.Add(Me.TB_C3)
        Me.Controls.Add(Me.TB_C4)
        Me.Controls.Add(Me.TB_C5)
        Me.Controls.Add(Me.TB_C6)
        Me.Controls.Add(Me.TB_C7)
        Me.Controls.Add(Me.TB_C8)
        Me.Controls.Add(Me.TB_C9)
        Me.Controls.Add(Me.TB_C1)
        Me.Controls.Add(Me.TB_D2)
        Me.Controls.Add(Me.TB_D3)
        Me.Controls.Add(Me.TB_D4)
        Me.Controls.Add(Me.TB_D5)
        Me.Controls.Add(Me.TB_D6)
        Me.Controls.Add(Me.TB_D7)
        Me.Controls.Add(Me.TB_D8)
        Me.Controls.Add(Me.TB_D9)
        Me.Controls.Add(Me.TB_D1)
        Me.Controls.Add(Me.TB_A2)
        Me.Controls.Add(Me.TB_A3)
        Me.Controls.Add(Me.TB_A4)
        Me.Controls.Add(Me.TB_A5)
        Me.Controls.Add(Me.TB_A6)
        Me.Controls.Add(Me.TB_A7)
        Me.Controls.Add(Me.TB_A8)
        Me.Controls.Add(Me.TB_A9)
        Me.Controls.Add(Me.TB_A1)
        Me.Name = "Sudoku"
        Me.Text = "Sudoku"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TB_A1 As TextBox
    Friend WithEvents TB_A9 As TextBox
    Friend WithEvents TB_A8 As TextBox
    Friend WithEvents TB_A7 As TextBox
    Friend WithEvents TB_A6 As TextBox
    Friend WithEvents TB_A5 As TextBox
    Friend WithEvents TB_A4 As TextBox
    Friend WithEvents TB_A3 As TextBox
    Friend WithEvents TB_A2 As TextBox
    Friend WithEvents TB_D2 As TextBox
    Friend WithEvents TB_D3 As TextBox
    Friend WithEvents TB_D4 As TextBox
    Friend WithEvents TB_D5 As TextBox
    Friend WithEvents TB_D6 As TextBox
    Friend WithEvents TB_D7 As TextBox
    Friend WithEvents TB_D8 As TextBox
    Friend WithEvents TB_D9 As TextBox
    Friend WithEvents TB_D1 As TextBox
    Friend WithEvents TB_C2 As TextBox
    Friend WithEvents TB_C3 As TextBox
    Friend WithEvents TB_C4 As TextBox
    Friend WithEvents TB_C5 As TextBox
    Friend WithEvents TB_C6 As TextBox
    Friend WithEvents TB_C7 As TextBox
    Friend WithEvents TB_C8 As TextBox
    Friend WithEvents TB_C9 As TextBox
    Friend WithEvents TB_C1 As TextBox
    Friend WithEvents TB_E2 As TextBox
    Friend WithEvents TB_E3 As TextBox
    Friend WithEvents TB_E4 As TextBox
    Friend WithEvents TB_E5 As TextBox
    Friend WithEvents TB_E6 As TextBox
    Friend WithEvents TB_E7 As TextBox
    Friend WithEvents TB_E8 As TextBox
    Friend WithEvents TB_E9 As TextBox
    Friend WithEvents TB_E1 As TextBox
    Friend WithEvents TB_F2 As TextBox
    Friend WithEvents TB_F3 As TextBox
    Friend WithEvents TB_F4 As TextBox
    Friend WithEvents TB_F5 As TextBox
    Friend WithEvents TB_F6 As TextBox
    Friend WithEvents TB_F7 As TextBox
    Friend WithEvents TB_F8 As TextBox
    Friend WithEvents TB_F9 As TextBox
    Friend WithEvents TB_F1 As TextBox
    Friend WithEvents TB_G2 As TextBox
    Friend WithEvents TB_G3 As TextBox
    Friend WithEvents TB_G4 As TextBox
    Friend WithEvents TB_G5 As TextBox
    Friend WithEvents TB_G6 As TextBox
    Friend WithEvents TB_G7 As TextBox
    Friend WithEvents TB_G8 As TextBox
    Friend WithEvents TB_G9 As TextBox
    Friend WithEvents TB_G1 As TextBox
    Friend WithEvents TB_B2 As TextBox
    Friend WithEvents TB_B3 As TextBox
    Friend WithEvents TB_B4 As TextBox
    Friend WithEvents TB_B5 As TextBox
    Friend WithEvents TB_B6 As TextBox
    Friend WithEvents TB_B7 As TextBox
    Friend WithEvents TB_B8 As TextBox
    Friend WithEvents TB_B9 As TextBox
    Friend WithEvents TB_B1 As TextBox
    Friend WithEvents TB_H2 As TextBox
    Friend WithEvents TB_H3 As TextBox
    Friend WithEvents TB_H4 As TextBox
    Friend WithEvents TB_H5 As TextBox
    Friend WithEvents TB_H6 As TextBox
    Friend WithEvents TB_H7 As TextBox
    Friend WithEvents TB_H8 As TextBox
    Friend WithEvents TB_H9 As TextBox
    Friend WithEvents TB_H1 As TextBox
    Friend WithEvents TB_I2 As TextBox
    Friend WithEvents TB_I3 As TextBox
    Friend WithEvents TB_I4 As TextBox
    Friend WithEvents TB_I5 As TextBox
    Friend WithEvents TB_I6 As TextBox
    Friend WithEvents TB_I7 As TextBox
    Friend WithEvents TB_I8 As TextBox
    Friend WithEvents TB_I9 As TextBox
    Friend WithEvents TB_I1 As TextBox
End Class
