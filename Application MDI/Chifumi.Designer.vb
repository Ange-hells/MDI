<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chifumi
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
        Me.BT_Pierre = New System.Windows.Forms.Button()
        Me.BT_Papier = New System.Windows.Forms.Button()
        Me.BT_Ciseau = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BT_Pierre
        '
        Me.BT_Pierre.Location = New System.Drawing.Point(283, 222)
        Me.BT_Pierre.Name = "BT_Pierre"
        Me.BT_Pierre.Size = New System.Drawing.Size(75, 23)
        Me.BT_Pierre.TabIndex = 0
        Me.BT_Pierre.Text = "Pierre"
        Me.BT_Pierre.UseVisualStyleBackColor = True
        '
        'BT_Papier
        '
        Me.BT_Papier.Location = New System.Drawing.Point(283, 269)
        Me.BT_Papier.Name = "BT_Papier"
        Me.BT_Papier.Size = New System.Drawing.Size(75, 23)
        Me.BT_Papier.TabIndex = 1
        Me.BT_Papier.Text = "Papier"
        Me.BT_Papier.UseVisualStyleBackColor = True
        '
        'BT_Ciseau
        '
        Me.BT_Ciseau.Location = New System.Drawing.Point(283, 314)
        Me.BT_Ciseau.Name = "BT_Ciseau"
        Me.BT_Ciseau.Size = New System.Drawing.Size(75, 23)
        Me.BT_Ciseau.TabIndex = 2
        Me.BT_Ciseau.Text = "Ciseaux"
        Me.BT_Ciseau.UseVisualStyleBackColor = True
        '
        'Chifumi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 486)
        Me.Controls.Add(Me.BT_Ciseau)
        Me.Controls.Add(Me.BT_Papier)
        Me.Controls.Add(Me.BT_Pierre)
        Me.Name = "Chifumi"
        Me.Text = "Chifumi"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BT_Pierre As Button
    Friend WithEvents BT_Papier As Button
    Friend WithEvents BT_Ciseau As Button
End Class
