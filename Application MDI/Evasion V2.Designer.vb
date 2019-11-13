<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Evasion_V2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Evasion_V2))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LBL_STATUT = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar2 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TXT_ADRESSE = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.WB_NAVIGATEUR = New System.Windows.Forms.WebBrowser()
        Me.nouv_onglet = New System.Windows.Forms.TabPage()
        Me.Evasion_Menu = New System.Windows.Forms.ToolStripDropDownButton()
        Me.HistoriqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VoireLhistoriqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuprimerLhistoriqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FavorieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterUnFavorieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VoireLesFavorieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BT_PRECEDENT = New System.Windows.Forms.ToolStripButton()
        Me.BT_SUIVANT = New System.Windows.Forms.ToolStripButton()
        Me.BT_REFRESH = New System.Windows.Forms.ToolStripButton()
        Me.BT_STOP = New System.Windows.Forms.ToolStripButton()
        Me.BT_ADRESSE = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LBL_STATUT, Me.ToolStripProgressBar2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LBL_STATUT
        '
        Me.LBL_STATUT.Name = "LBL_STATUT"
        Me.LBL_STATUT.Size = New System.Drawing.Size(120, 17)
        Me.LBL_STATUT.Text = "ToolStripStatusLabel1"
        '
        'ToolStripProgressBar2
        '
        Me.ToolStripProgressBar2.Name = "ToolStripProgressBar2"
        Me.ToolStripProgressBar2.Size = New System.Drawing.Size(100, 16)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Evasion_Menu, Me.BT_PRECEDENT, Me.BT_SUIVANT, Me.ToolStripSeparator1, Me.BT_REFRESH, Me.BT_STOP, Me.ToolStripSeparator2, Me.TXT_ADRESSE, Me.ToolStripSeparator3, Me.BT_ADRESSE})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TXT_ADRESSE
        '
        Me.TXT_ADRESSE.Name = "TXT_ADRESSE"
        Me.TXT_ADRESSE.Size = New System.Drawing.Size(300, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.nouv_onglet)
        Me.TabControl1.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.TabControl1.Location = New System.Drawing.Point(0, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(800, 397)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.WB_NAVIGATEUR)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(792, 371)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'WB_NAVIGATEUR
        '
        Me.WB_NAVIGATEUR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WB_NAVIGATEUR.Location = New System.Drawing.Point(0, 0)
        Me.WB_NAVIGATEUR.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WB_NAVIGATEUR.Name = "WB_NAVIGATEUR"
        Me.WB_NAVIGATEUR.Size = New System.Drawing.Size(796, 375)
        Me.WB_NAVIGATEUR.TabIndex = 0
        '
        'nouv_onglet
        '
        Me.nouv_onglet.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.nouv_onglet.Location = New System.Drawing.Point(4, 22)
        Me.nouv_onglet.Name = "nouv_onglet"
        Me.nouv_onglet.Padding = New System.Windows.Forms.Padding(3)
        Me.nouv_onglet.Size = New System.Drawing.Size(792, 371)
        Me.nouv_onglet.TabIndex = 1
        Me.nouv_onglet.Text = "new"
        Me.nouv_onglet.UseVisualStyleBackColor = True
        '
        'Evasion_Menu
        '
        Me.Evasion_Menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Evasion_Menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HistoriqueToolStripMenuItem, Me.FavorieToolStripMenuItem, Me.AProposToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.Evasion_Menu.Image = Global.Application_MDI.My.Resources.Resources.Middle_East_16px
        Me.Evasion_Menu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Evasion_Menu.Name = "Evasion_Menu"
        Me.Evasion_Menu.Size = New System.Drawing.Size(29, 22)
        Me.Evasion_Menu.Text = "ToolStripDropDownButton1"
        '
        'HistoriqueToolStripMenuItem
        '
        Me.HistoriqueToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VoireLhistoriqueToolStripMenuItem, Me.SuprimerLhistoriqueToolStripMenuItem})
        Me.HistoriqueToolStripMenuItem.Image = Global.Application_MDI.My.Resources.Resources.icons8_order_history_16
        Me.HistoriqueToolStripMenuItem.Name = "HistoriqueToolStripMenuItem"
        Me.HistoriqueToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HistoriqueToolStripMenuItem.Text = "historique"
        '
        'VoireLhistoriqueToolStripMenuItem
        '
        Me.VoireLhistoriqueToolStripMenuItem.Image = Global.Application_MDI.My.Resources.Resources.icons8_activity_history_16_1_
        Me.VoireLhistoriqueToolStripMenuItem.Name = "VoireLhistoriqueToolStripMenuItem"
        Me.VoireLhistoriqueToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.VoireLhistoriqueToolStripMenuItem.Text = "voire l'historique"
        '
        'SuprimerLhistoriqueToolStripMenuItem
        '
        Me.SuprimerLhistoriqueToolStripMenuItem.Image = Global.Application_MDI.My.Resources.Resources.icons8_activity_history_16
        Me.SuprimerLhistoriqueToolStripMenuItem.Name = "SuprimerLhistoriqueToolStripMenuItem"
        Me.SuprimerLhistoriqueToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.SuprimerLhistoriqueToolStripMenuItem.Text = "effacer l'historique"
        '
        'FavorieToolStripMenuItem
        '
        Me.FavorieToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterUnFavorieToolStripMenuItem, Me.VoireLesFavorieToolStripMenuItem})
        Me.FavorieToolStripMenuItem.Image = Global.Application_MDI.My.Resources.Resources.icons8_star_filled_16
        Me.FavorieToolStripMenuItem.Name = "FavorieToolStripMenuItem"
        Me.FavorieToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FavorieToolStripMenuItem.Text = "favoris"
        '
        'AjouterUnFavorieToolStripMenuItem
        '
        Me.AjouterUnFavorieToolStripMenuItem.Image = Global.Application_MDI.My.Resources.Resources.icons8_add_to_favorites_16
        Me.AjouterUnFavorieToolStripMenuItem.Name = "AjouterUnFavorieToolStripMenuItem"
        Me.AjouterUnFavorieToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.AjouterUnFavorieToolStripMenuItem.Text = "ajouter un favori"
        '
        'VoireLesFavorieToolStripMenuItem
        '
        Me.VoireLesFavorieToolStripMenuItem.Image = Global.Application_MDI.My.Resources.Resources.icons8_search_folder_16
        Me.VoireLesFavorieToolStripMenuItem.Name = "VoireLesFavorieToolStripMenuItem"
        Me.VoireLesFavorieToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.VoireLesFavorieToolStripMenuItem.Text = "voire les favors"
        '
        'AProposToolStripMenuItem
        '
        Me.AProposToolStripMenuItem.Image = Global.Application_MDI.My.Resources.Resources.icons8_info_16
        Me.AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
        Me.AProposToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AProposToolStripMenuItem.Text = "a propos"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Image = Global.Application_MDI.My.Resources.Resources.Quitter
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.QuitterToolStripMenuItem.Text = "quitter"
        '
        'BT_PRECEDENT
        '
        Me.BT_PRECEDENT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_PRECEDENT.Image = Global.Application_MDI.My.Resources.Resources.Left_2_16px
        Me.BT_PRECEDENT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BT_PRECEDENT.Name = "BT_PRECEDENT"
        Me.BT_PRECEDENT.Size = New System.Drawing.Size(23, 22)
        Me.BT_PRECEDENT.Text = "ToolStripButton1"
        '
        'BT_SUIVANT
        '
        Me.BT_SUIVANT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_SUIVANT.Image = Global.Application_MDI.My.Resources.Resources.Right_2_16px
        Me.BT_SUIVANT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BT_SUIVANT.Name = "BT_SUIVANT"
        Me.BT_SUIVANT.Size = New System.Drawing.Size(23, 22)
        Me.BT_SUIVANT.Text = "ToolStripButton2"
        '
        'BT_REFRESH
        '
        Me.BT_REFRESH.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_REFRESH.Image = Global.Application_MDI.My.Resources.Resources.Replay_16px
        Me.BT_REFRESH.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BT_REFRESH.Name = "BT_REFRESH"
        Me.BT_REFRESH.Size = New System.Drawing.Size(23, 22)
        Me.BT_REFRESH.Text = "ToolStripButton3"
        '
        'BT_STOP
        '
        Me.BT_STOP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_STOP.Image = Global.Application_MDI.My.Resources.Resources.Stop_Sign_16px
        Me.BT_STOP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BT_STOP.Name = "BT_STOP"
        Me.BT_STOP.Size = New System.Drawing.Size(23, 22)
        Me.BT_STOP.Text = "ToolStripButton4"
        '
        'BT_ADRESSE
        '
        Me.BT_ADRESSE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_ADRESSE.Image = Global.Application_MDI.My.Resources.Resources.Search_16px
        Me.BT_ADRESSE.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BT_ADRESSE.Name = "BT_ADRESSE"
        Me.BT_ADRESSE.Size = New System.Drawing.Size(23, 22)
        Me.BT_ADRESSE.Text = "ToolStripButton5"
        '
        'Evasion_V2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Evasion_V2"
        Me.Text = "Evasion_V2"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BT_PRECEDENT As ToolStripButton
    Friend WithEvents BT_SUIVANT As ToolStripButton
    Friend WithEvents Evasion_Menu As ToolStripDropDownButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BT_REFRESH As ToolStripButton
    Friend WithEvents BT_STOP As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents TXT_ADRESSE As ToolStripTextBox
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents BT_ADRESSE As ToolStripButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents nouv_onglet As TabPage
    Friend WithEvents ToolStripProgressBar2 As ToolStripProgressBar
    Friend WithEvents WB_NAVIGATEUR As WebBrowser
    Friend WithEvents LBL_STATUT As ToolStripStatusLabel
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistoriqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VoireLhistoriqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuprimerLhistoriqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FavorieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterUnFavorieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VoireLesFavorieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AProposToolStripMenuItem As ToolStripMenuItem
End Class
