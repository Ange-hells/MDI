<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Palindrome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Palindrome))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BT_verifier = New System.Windows.Forms.Button()
        Me.LB_Resultat = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(246, 20)
        Me.TextBox1.TabIndex = 0
        '
        'BT_verifier
        '
        Me.BT_verifier.Location = New System.Drawing.Point(13, 40)
        Me.BT_verifier.Name = "BT_verifier"
        Me.BT_verifier.Size = New System.Drawing.Size(106, 23)
        Me.BT_verifier.TabIndex = 1
        Me.BT_verifier.Text = "Vérifier"
        Me.BT_verifier.UseVisualStyleBackColor = True
        '
        'LB_Resultat
        '
        Me.LB_Resultat.AutoSize = True
        Me.LB_Resultat.ForeColor = System.Drawing.Color.Red
        Me.LB_Resultat.Location = New System.Drawing.Point(125, 45)
        Me.LB_Resultat.Name = "LB_Resultat"
        Me.LB_Resultat.Size = New System.Drawing.Size(134, 13)
        Me.LB_Resultat.TabIndex = 2
        Me.LB_Resultat.Text = "Ce n'est pas un palindrome"
        '
        'Palindrome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 73)
        Me.Controls.Add(Me.LB_Resultat)
        Me.Controls.Add(Me.BT_verifier)
        Me.Controls.Add(Me.TextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(287, 112)
        Me.MinimumSize = New System.Drawing.Size(287, 112)
        Me.Name = "Palindrome"
        Me.Text = "Palindrome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BT_verifier As Button
    Friend WithEvents LB_Resultat As Label
End Class
