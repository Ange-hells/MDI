<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factoriel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Factoriel))
        Me.Calculer = New System.Windows.Forms.Button()
        Me.jhdytjty = New System.Windows.Forms.Label()
        Me.Detail = New System.Windows.Forms.Label()
        Me.Result = New System.Windows.Forms.Label()
        Me.Detaile = New System.Windows.Forms.Label()
        Me.nb_textbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Calculer
        '
        Me.Calculer.Location = New System.Drawing.Point(197, 36)
        Me.Calculer.Name = "Calculer"
        Me.Calculer.Size = New System.Drawing.Size(75, 21)
        Me.Calculer.TabIndex = 0
        Me.Calculer.Text = "Calculer"
        Me.Calculer.UseVisualStyleBackColor = True
        '
        'jhdytjty
        '
        Me.jhdytjty.AutoSize = True
        Me.jhdytjty.Location = New System.Drawing.Point(12, 73)
        Me.jhdytjty.Name = "jhdytjty"
        Me.jhdytjty.Size = New System.Drawing.Size(64, 13)
        Me.jhdytjty.TabIndex = 1
        Me.jhdytjty.Text = "RESULTAT"
        '
        'Detail
        '
        Me.Detail.AutoSize = True
        Me.Detail.Location = New System.Drawing.Point(12, 101)
        Me.Detail.Name = "Detail"
        Me.Detail.Size = New System.Drawing.Size(45, 13)
        Me.Detail.TabIndex = 2
        Me.Detail.Text = "DETAIL"
        '
        'Result
        '
        Me.Result.AutoSize = True
        Me.Result.Location = New System.Drawing.Point(152, 73)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(39, 13)
        Me.Result.TabIndex = 3
        Me.Result.Text = "Label3"
        '
        'Detaile
        '
        Me.Detaile.AutoSize = True
        Me.Detaile.Location = New System.Drawing.Point(152, 101)
        Me.Detaile.Name = "Detaile"
        Me.Detaile.Size = New System.Drawing.Size(39, 13)
        Me.Detaile.TabIndex = 4
        Me.Detaile.Text = "Label4"
        '
        'nb_textbox
        '
        Me.nb_textbox.Location = New System.Drawing.Point(12, 37)
        Me.nb_textbox.Name = "nb_textbox"
        Me.nb_textbox.Size = New System.Drawing.Size(179, 20)
        Me.nb_textbox.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Valeur a calculer"
        '
        'Factoriel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 135)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.nb_textbox)
        Me.Controls.Add(Me.Detaile)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.Detail)
        Me.Controls.Add(Me.jhdytjty)
        Me.Controls.Add(Me.Calculer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(300, 174)
        Me.MinimumSize = New System.Drawing.Size(300, 174)
        Me.Name = "Factoriel"
        Me.Text = "Factoriel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Calculer As Button
    Friend WithEvents jhdytjty As Label
    Friend WithEvents Detail As Label
    Friend WithEvents Result As Label
    Friend WithEvents Detaile As Label
    Friend WithEvents nb_textbox As TextBox
    Friend WithEvents Label5 As Label
End Class
