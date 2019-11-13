<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class favoris_liste
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
        Me.Panel_favori = New System.Windows.Forms.Panel()
        Me.BT_return = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Panel_favori
        '
        Me.Panel_favori.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_favori.Location = New System.Drawing.Point(12, 40)
        Me.Panel_favori.Name = "Panel_favori"
        Me.Panel_favori.Size = New System.Drawing.Size(364, 398)
        Me.Panel_favori.TabIndex = 0
        '
        'BT_return
        '
        Me.BT_return.Location = New System.Drawing.Point(301, 11)
        Me.BT_return.Name = "BT_return"
        Me.BT_return.Size = New System.Drawing.Size(75, 23)
        Me.BT_return.TabIndex = 0
        Me.BT_return.Text = "Retour"
        Me.BT_return.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "selectionner le favori que vous voulez atteindre"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'favoris_liste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel_favori)
        Me.Controls.Add(Me.BT_return)
        Me.Name = "favoris_liste"
        Me.Text = "favoris"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel_favori As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BT_return As Button
End Class
