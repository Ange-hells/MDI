<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Evasion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Evasion))
        Me.BT_ADRESSE = New System.Windows.Forms.Button()
        Me.TXT_ADRESSE = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LBL_STATUT = New System.Windows.Forms.ToolStripStatusLabel()
        Me.WB_NAVIGATEUR = New System.Windows.Forms.WebBrowser()
        Me.BT_PRECEDENT = New System.Windows.Forms.Button()
        Me.BT_SUIVANT = New System.Windows.Forms.Button()
        Me.BT_REFRESH = New System.Windows.Forms.Button()
        Me.BT_STOP = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BT_ADRESSE
        '
        Me.BT_ADRESSE.Location = New System.Drawing.Point(339, 41)
        Me.BT_ADRESSE.Name = "BT_ADRESSE"
        Me.BT_ADRESSE.Size = New System.Drawing.Size(75, 20)
        Me.BT_ADRESSE.TabIndex = 1
        Me.BT_ADRESSE.Text = "Recherche"
        Me.BT_ADRESSE.UseVisualStyleBackColor = True
        '
        'TXT_ADRESSE
        '
        Me.TXT_ADRESSE.Location = New System.Drawing.Point(12, 41)
        Me.TXT_ADRESSE.Name = "TXT_ADRESSE"
        Me.TXT_ADRESSE.Size = New System.Drawing.Size(321, 20)
        Me.TXT_ADRESSE.TabIndex = 6
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LBL_STATUT})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LBL_STATUT
        '
        Me.LBL_STATUT.Name = "LBL_STATUT"
        Me.LBL_STATUT.Size = New System.Drawing.Size(120, 17)
        Me.LBL_STATUT.Text = "ToolStripStatusLabel1"
        '
        'WB_NAVIGATEUR
        '
        Me.WB_NAVIGATEUR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WB_NAVIGATEUR.Location = New System.Drawing.Point(12, 67)
        Me.WB_NAVIGATEUR.MinimumSize = New System.Drawing.Size(200, 200)
        Me.WB_NAVIGATEUR.Name = "WB_NAVIGATEUR"
        Me.WB_NAVIGATEUR.Size = New System.Drawing.Size(776, 358)
        Me.WB_NAVIGATEUR.TabIndex = 9
        '
        'BT_PRECEDENT
        '
        Me.BT_PRECEDENT.Location = New System.Drawing.Point(12, 12)
        Me.BT_PRECEDENT.Name = "BT_PRECEDENT"
        Me.BT_PRECEDENT.Size = New System.Drawing.Size(75, 23)
        Me.BT_PRECEDENT.TabIndex = 10
        Me.BT_PRECEDENT.Text = "Précédent"
        Me.BT_PRECEDENT.UseVisualStyleBackColor = True
        '
        'BT_SUIVANT
        '
        Me.BT_SUIVANT.Location = New System.Drawing.Point(93, 12)
        Me.BT_SUIVANT.Name = "BT_SUIVANT"
        Me.BT_SUIVANT.Size = New System.Drawing.Size(75, 23)
        Me.BT_SUIVANT.TabIndex = 11
        Me.BT_SUIVANT.Text = "Suivant"
        Me.BT_SUIVANT.UseVisualStyleBackColor = True
        '
        'BT_REFRESH
        '
        Me.BT_REFRESH.Location = New System.Drawing.Point(174, 12)
        Me.BT_REFRESH.Name = "BT_REFRESH"
        Me.BT_REFRESH.Size = New System.Drawing.Size(75, 23)
        Me.BT_REFRESH.TabIndex = 12
        Me.BT_REFRESH.Text = "Raffraîchir"
        Me.BT_REFRESH.UseVisualStyleBackColor = True
        '
        'BT_STOP
        '
        Me.BT_STOP.Location = New System.Drawing.Point(255, 12)
        Me.BT_STOP.Name = "BT_STOP"
        Me.BT_STOP.Size = New System.Drawing.Size(75, 23)
        Me.BT_STOP.TabIndex = 13
        Me.BT_STOP.Text = "Stop"
        Me.BT_STOP.UseVisualStyleBackColor = True
        '
        'Evasion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BT_STOP)
        Me.Controls.Add(Me.BT_REFRESH)
        Me.Controls.Add(Me.BT_SUIVANT)
        Me.Controls.Add(Me.BT_PRECEDENT)
        Me.Controls.Add(Me.WB_NAVIGATEUR)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TXT_ADRESSE)
        Me.Controls.Add(Me.BT_ADRESSE)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Evasion"
        Me.Text = "Evasion"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BT_ADRESSE As Button
    Friend WithEvents TXT_ADRESSE As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents WB_NAVIGATEUR As WebBrowser
    Friend WithEvents BT_PRECEDENT As Button
    Friend WithEvents BT_SUIVANT As Button
    Friend WithEvents BT_REFRESH As Button
    Friend WithEvents BT_STOP As Button
    Friend WithEvents LBL_STATUT As ToolStripStatusLabel
End Class
