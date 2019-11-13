<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Setting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Setting))
        Me.LB_language = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BT_Log = New System.Windows.Forms.Button()
        Me.BT_Valider = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LB_language
        '
        Me.LB_language.AutoSize = True
        Me.LB_language.Location = New System.Drawing.Point(13, 13)
        Me.LB_language.Name = "LB_language"
        Me.LB_language.Size = New System.Drawing.Size(55, 13)
        Me.LB_language.TabIndex = 0
        Me.LB_language.Text = "Language"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 29)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'BT_Log
        '
        Me.BT_Log.Location = New System.Drawing.Point(12, 57)
        Me.BT_Log.Name = "BT_Log"
        Me.BT_Log.Size = New System.Drawing.Size(56, 23)
        Me.BT_Log.TabIndex = 2
        Me.BT_Log.Text = "Log"
        Me.BT_Log.UseVisualStyleBackColor = True
        '
        'BT_Valider
        '
        Me.BT_Valider.Location = New System.Drawing.Point(75, 57)
        Me.BT_Valider.Name = "BT_Valider"
        Me.BT_Valider.Size = New System.Drawing.Size(58, 23)
        Me.BT_Valider.TabIndex = 3
        Me.BT_Valider.Text = "Valider"
        Me.BT_Valider.UseVisualStyleBackColor = True
        '
        'Setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(144, 91)
        Me.Controls.Add(Me.BT_Valider)
        Me.Controls.Add(Me.BT_Log)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.LB_language)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Setting"
        Me.Text = "Setting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LB_language As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BT_Log As Button
    Friend WithEvents BT_Valider As Button
End Class
