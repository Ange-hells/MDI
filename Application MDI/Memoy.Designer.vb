<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Memoy
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Memoy))
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BT_generer = New System.Windows.Forms.Button()
        Me.Panelpioche = New System.Windows.Forms.Panel()
        Me.Paneltapis = New System.Windows.Forms.Panel()
        Me.LB_resultat = New System.Windows.Forms.Label()
        Me.BT_Option = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ProgressBar
        '
        Me.ProgressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar.Location = New System.Drawing.Point(12, 0)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(610, 23)
        Me.ProgressBar.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 1
        '
        'BT_generer
        '
        Me.BT_generer.BackgroundImage = CType(resources.GetObject("BT_generer.BackgroundImage"), System.Drawing.Image)
        Me.BT_generer.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BT_generer.Location = New System.Drawing.Point(73, 56)
        Me.BT_generer.Name = "BT_generer"
        Me.BT_generer.Size = New System.Drawing.Size(61, 23)
        Me.BT_generer.TabIndex = 2
        Me.BT_generer.Text = "Générer"
        Me.BT_generer.UseVisualStyleBackColor = True
        '
        'Panelpioche
        '
        Me.Panelpioche.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panelpioche.BackColor = System.Drawing.Color.Transparent
        Me.Panelpioche.Location = New System.Drawing.Point(140, 29)
        Me.Panelpioche.Name = "Panelpioche"
        Me.Panelpioche.Size = New System.Drawing.Size(482, 117)
        Me.Panelpioche.TabIndex = 4
        '
        'Paneltapis
        '
        Me.Paneltapis.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Paneltapis.BackColor = System.Drawing.Color.Transparent
        Me.Paneltapis.Location = New System.Drawing.Point(12, 152)
        Me.Paneltapis.Name = "Paneltapis"
        Me.Paneltapis.Size = New System.Drawing.Size(610, 447)
        Me.Paneltapis.TabIndex = 5
        '
        'LB_resultat
        '
        Me.LB_resultat.AutoSize = True
        Me.LB_resultat.BackColor = System.Drawing.Color.Transparent
        Me.LB_resultat.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_resultat.ForeColor = System.Drawing.Color.Chartreuse
        Me.LB_resultat.Location = New System.Drawing.Point(8, 99)
        Me.LB_resultat.Name = "LB_resultat"
        Me.LB_resultat.Size = New System.Drawing.Size(127, 29)
        Me.LB_resultat.TabIndex = 6
        Me.LB_resultat.Text = "GAGNER !"
        '
        'BT_Option
        '
        Me.BT_Option.BackgroundImage = CType(resources.GetObject("BT_Option.BackgroundImage"), System.Drawing.Image)
        Me.BT_Option.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BT_Option.Location = New System.Drawing.Point(13, 56)
        Me.BT_Option.Name = "BT_Option"
        Me.BT_Option.Size = New System.Drawing.Size(54, 23)
        Me.BT_Option.TabIndex = 7
        Me.BT_Option.Text = "Option"
        Me.BT_Option.UseVisualStyleBackColor = True
        '
        'Memoy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Application_MDI.My.Resources.Resources.I_Moyenne_204613_tapis_de_jeux_a_broder_broderie_toile_imprimee_marie_coeur_net
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(634, 611)
        Me.Controls.Add(Me.LB_resultat)
        Me.Controls.Add(Me.BT_Option)
        Me.Controls.Add(Me.Paneltapis)
        Me.Controls.Add(Me.Panelpioche)
        Me.Controls.Add(Me.BT_generer)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ProgressBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(650, 650)
        Me.MinimumSize = New System.Drawing.Size(650, 650)
        Me.Name = "Memoy"
        Me.Text = "Memory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BT_generer As Button
    Friend WithEvents Panelpioche As Panel
    Friend WithEvents Paneltapis As Panel
    Friend WithEvents LB_resultat As Label
    Friend WithEvents BT_Option As Button
    Friend WithEvents Timer1 As Timer
End Class
