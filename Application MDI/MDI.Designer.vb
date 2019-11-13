<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDI))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Nb_fenêtreFille = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuForm1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuForm2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuCalcul = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPalindrome = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuFactorielle = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuJeux = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuEvasion = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuEvasionV2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPersonalTheque = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuFermer = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuFermerActive = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuFermerAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParametreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuiterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_Fenêtre = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuHorisontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_About = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSB_OuvrirF1 = New System.Windows.Forms.ToolStripButton()
        Me.TSB_OuvrirF2 = New System.Windows.Forms.ToolStripButton()
        Me.TSB_Calcul = New System.Windows.Forms.ToolStripButton()
        Me.TSB_Palindrome = New System.Windows.Forms.ToolStripButton()
        Me.TSB_factoriel = New System.Windows.Forms.ToolStripButton()
        Me.TSM_memory = New System.Windows.Forms.ToolStripDropDownButton()
        Me.TSB_memory = New System.Windows.Forms.ToolStripMenuItem()
        Me.SudokuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuizzToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSB_evasion = New System.Windows.Forms.ToolStripButton()
        Me.TSB_evasion_V2 = New System.Windows.Forms.ToolStripButton()
        Me.TSB_PersonalTheque = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSB_Fermer = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSB_Cascade = New System.Windows.Forms.ToolStripButton()
        Me.TSB_Horisontal = New System.Windows.Forms.ToolStripButton()
        Me.TSB_Vertical = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripButton()
        Me.TSB_FermerAll = New System.Windows.Forms.ToolStripButton()
        Me.MenuMemory = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSudoku = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuQuiz = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Nb_fenêtreFille})
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.Name = "StatusStrip1"
        '
        'Nb_fenêtreFille
        '
        Me.Nb_fenêtreFille.Name = "Nb_fenêtreFille"
        resources.ApplyResources(Me.Nb_fenêtreFille, "Nb_fenêtreFille")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.TSM_Fenêtre, Me.TSM_About})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvrirToolStripMenuItem, Me.MenuFermer, Me.ParametreToolStripMenuItem, Me.QuiterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        resources.ApplyResources(Me.FichierToolStripMenuItem, "FichierToolStripMenuItem")
        '
        'OuvrirToolStripMenuItem
        '
        Me.OuvrirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuForm1, Me.MenuForm2, Me.MenuCalcul, Me.MenuPalindrome, Me.MenuFactorielle, Me.MenuJeux, Me.MenuEvasion, Me.MenuEvasionV2, Me.MenuPersonalTheque})
        Me.OuvrirToolStripMenuItem.Image = Global.Application_MDI.My.Resources.Resources.OuvrirForm2
        Me.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        resources.ApplyResources(Me.OuvrirToolStripMenuItem, "OuvrirToolStripMenuItem")
        '
        'MenuForm1
        '
        Me.MenuForm1.Image = Global.Application_MDI.My.Resources.Resources.OuvrirForm2
        Me.MenuForm1.Name = "MenuForm1"
        resources.ApplyResources(Me.MenuForm1, "MenuForm1")
        '
        'MenuForm2
        '
        Me.MenuForm2.Image = Global.Application_MDI.My.Resources.Resources.OuvrirForm1
        Me.MenuForm2.Name = "MenuForm2"
        resources.ApplyResources(Me.MenuForm2, "MenuForm2")
        '
        'MenuCalcul
        '
        Me.MenuCalcul.Image = Global.Application_MDI.My.Resources.Resources.Math_16px
        Me.MenuCalcul.Name = "MenuCalcul"
        resources.ApplyResources(Me.MenuCalcul, "MenuCalcul")
        '
        'MenuPalindrome
        '
        Me.MenuPalindrome.Image = Global.Application_MDI.My.Resources.Resources.Direction_16px
        Me.MenuPalindrome.Name = "MenuPalindrome"
        resources.ApplyResources(Me.MenuPalindrome, "MenuPalindrome")
        '
        'MenuFactorielle
        '
        Me.MenuFactorielle.Image = Global.Application_MDI.My.Resources.Resources.Formula_FX_16px
        Me.MenuFactorielle.Name = "MenuFactorielle"
        resources.ApplyResources(Me.MenuFactorielle, "MenuFactorielle")
        '
        'MenuJeux
        '
        Me.MenuJeux.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuMemory, Me.MenuSudoku, Me.MenuQuiz})
        Me.MenuJeux.Image = Global.Application_MDI.My.Resources.Resources.Cards_16px
        Me.MenuJeux.Name = "MenuJeux"
        resources.ApplyResources(Me.MenuJeux, "MenuJeux")
        '
        'MenuEvasion
        '
        Me.MenuEvasion.Image = Global.Application_MDI.My.Resources.Resources.Globe_16px
        Me.MenuEvasion.Name = "MenuEvasion"
        resources.ApplyResources(Me.MenuEvasion, "MenuEvasion")
        '
        'MenuEvasionV2
        '
        Me.MenuEvasionV2.Image = Global.Application_MDI.My.Resources.Resources.Middle_East_16px
        Me.MenuEvasionV2.Name = "MenuEvasionV2"
        resources.ApplyResources(Me.MenuEvasionV2, "MenuEvasionV2")
        '
        'MenuPersonalTheque
        '
        Me.MenuPersonalTheque.Image = Global.Application_MDI.My.Resources.Resources.Book_Shelf_16px
        Me.MenuPersonalTheque.Name = "MenuPersonalTheque"
        resources.ApplyResources(Me.MenuPersonalTheque, "MenuPersonalTheque")
        '
        'MenuFermer
        '
        Me.MenuFermer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuFermerActive, Me.MenuFermerAll})
        Me.MenuFermer.Image = Global.Application_MDI.My.Resources.Resources.Fermer
        Me.MenuFermer.Name = "MenuFermer"
        resources.ApplyResources(Me.MenuFermer, "MenuFermer")
        '
        'MenuFermerActive
        '
        Me.MenuFermerActive.Image = Global.Application_MDI.My.Resources.Resources.Fermer
        Me.MenuFermerActive.Name = "MenuFermerActive"
        resources.ApplyResources(Me.MenuFermerActive, "MenuFermerActive")
        '
        'MenuFermerAll
        '
        Me.MenuFermerAll.Image = Global.Application_MDI.My.Resources.Resources.Fermer_tout
        Me.MenuFermerAll.Name = "MenuFermerAll"
        resources.ApplyResources(Me.MenuFermerAll, "MenuFermerAll")
        '
        'ParametreToolStripMenuItem
        '
        Me.ParametreToolStripMenuItem.Image = Global.Application_MDI.My.Resources.Resources.icons8_Administrative_Tools_16
        Me.ParametreToolStripMenuItem.Name = "ParametreToolStripMenuItem"
        resources.ApplyResources(Me.ParametreToolStripMenuItem, "ParametreToolStripMenuItem")
        '
        'QuiterToolStripMenuItem
        '
        Me.QuiterToolStripMenuItem.Image = Global.Application_MDI.My.Resources.Resources.Quitter
        Me.QuiterToolStripMenuItem.Name = "QuiterToolStripMenuItem"
        resources.ApplyResources(Me.QuiterToolStripMenuItem, "QuiterToolStripMenuItem")
        '
        'TSM_Fenêtre
        '
        Me.TSM_Fenêtre.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuCascade, Me.MenuVertical, Me.MenuHorisontal})
        Me.TSM_Fenêtre.Name = "TSM_Fenêtre"
        resources.ApplyResources(Me.TSM_Fenêtre, "TSM_Fenêtre")
        '
        'MenuCascade
        '
        Me.MenuCascade.Image = Global.Application_MDI.My.Resources.Resources.TileCascade
        Me.MenuCascade.Name = "MenuCascade"
        resources.ApplyResources(Me.MenuCascade, "MenuCascade")
        '
        'MenuVertical
        '
        Me.MenuVertical.Image = Global.Application_MDI.My.Resources.Resources.TileVertical
        Me.MenuVertical.Name = "MenuVertical"
        resources.ApplyResources(Me.MenuVertical, "MenuVertical")
        '
        'MenuHorisontal
        '
        Me.MenuHorisontal.Image = Global.Application_MDI.My.Resources.Resources.TileHorizontal
        Me.MenuHorisontal.Name = "MenuHorisontal"
        resources.ApplyResources(Me.MenuHorisontal, "MenuHorisontal")
        '
        'TSM_About
        '
        Me.TSM_About.Name = "TSM_About"
        resources.ApplyResources(Me.TSM_About, "TSM_About")
        '
        'ToolStrip1
        '
        resources.ApplyResources(Me.ToolStrip1, "ToolStrip1")
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSB_OuvrirF1, Me.TSB_OuvrirF2, Me.TSB_Calcul, Me.TSB_Palindrome, Me.TSB_factoriel, Me.TSM_memory, Me.TSB_evasion, Me.TSB_evasion_V2, Me.TSB_PersonalTheque, Me.ToolStripSeparator1, Me.TSB_Fermer, Me.TSB_FermerAll, Me.ToolStripSeparator2, Me.TSB_Cascade, Me.TSB_Horisontal, Me.TSB_Vertical, Me.ToolStripSeparator3, Me.QuitterToolStripMenuItem})
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        '
        'TSB_OuvrirF1
        '
        Me.TSB_OuvrirF1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSB_OuvrirF1.Image = Global.Application_MDI.My.Resources.Resources.OuvrirForm2
        resources.ApplyResources(Me.TSB_OuvrirF1, "TSB_OuvrirF1")
        Me.TSB_OuvrirF1.Name = "TSB_OuvrirF1"
        '
        'TSB_OuvrirF2
        '
        Me.TSB_OuvrirF2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSB_OuvrirF2.Image = Global.Application_MDI.My.Resources.Resources.OuvrirForm1
        resources.ApplyResources(Me.TSB_OuvrirF2, "TSB_OuvrirF2")
        Me.TSB_OuvrirF2.Name = "TSB_OuvrirF2"
        '
        'TSB_Calcul
        '
        Me.TSB_Calcul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSB_Calcul.Image = Global.Application_MDI.My.Resources.Resources.Math_16px
        resources.ApplyResources(Me.TSB_Calcul, "TSB_Calcul")
        Me.TSB_Calcul.Name = "TSB_Calcul"
        '
        'TSB_Palindrome
        '
        Me.TSB_Palindrome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSB_Palindrome.Image = Global.Application_MDI.My.Resources.Resources.Direction_16px
        resources.ApplyResources(Me.TSB_Palindrome, "TSB_Palindrome")
        Me.TSB_Palindrome.Name = "TSB_Palindrome"
        '
        'TSB_factoriel
        '
        Me.TSB_factoriel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSB_factoriel.Image = Global.Application_MDI.My.Resources.Resources.Formula_FX_16px
        resources.ApplyResources(Me.TSB_factoriel, "TSB_factoriel")
        Me.TSB_factoriel.Name = "TSB_factoriel"
        '
        'TSM_memory
        '
        Me.TSM_memory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSM_memory.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSB_memory, Me.SudokuToolStripMenuItem, Me.QuizzToolStripMenuItem})
        Me.TSM_memory.Image = Global.Application_MDI.My.Resources.Resources.Cards_16px
        resources.ApplyResources(Me.TSM_memory, "TSM_memory")
        Me.TSM_memory.Name = "TSM_memory"
        '
        'TSB_memory
        '
        Me.TSB_memory.Image = Global.Application_MDI.My.Resources.Resources.Cards_16px
        Me.TSB_memory.Name = "TSB_memory"
        resources.ApplyResources(Me.TSB_memory, "TSB_memory")
        '
        'SudokuToolStripMenuItem
        '
        Me.SudokuToolStripMenuItem.Image = Global.Application_MDI.My.Resources.Resources.Grid_16px
        Me.SudokuToolStripMenuItem.Name = "SudokuToolStripMenuItem"
        resources.ApplyResources(Me.SudokuToolStripMenuItem, "SudokuToolStripMenuItem")
        '
        'QuizzToolStripMenuItem
        '
        Me.QuizzToolStripMenuItem.Image = Global.Application_MDI.My.Resources.Resources.Pass_Fail_16px
        Me.QuizzToolStripMenuItem.Name = "QuizzToolStripMenuItem"
        resources.ApplyResources(Me.QuizzToolStripMenuItem, "QuizzToolStripMenuItem")
        '
        'TSB_evasion
        '
        Me.TSB_evasion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSB_evasion.Image = Global.Application_MDI.My.Resources.Resources.Globe_16px
        resources.ApplyResources(Me.TSB_evasion, "TSB_evasion")
        Me.TSB_evasion.Name = "TSB_evasion"
        '
        'TSB_evasion_V2
        '
        Me.TSB_evasion_V2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSB_evasion_V2.Image = Global.Application_MDI.My.Resources.Resources.Middle_East_16px
        resources.ApplyResources(Me.TSB_evasion_V2, "TSB_evasion_V2")
        Me.TSB_evasion_V2.Name = "TSB_evasion_V2"
        '
        'TSB_PersonalTheque
        '
        Me.TSB_PersonalTheque.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSB_PersonalTheque.Image = Global.Application_MDI.My.Resources.Resources.Book_Shelf_16px
        resources.ApplyResources(Me.TSB_PersonalTheque, "TSB_PersonalTheque")
        Me.TSB_PersonalTheque.Name = "TSB_PersonalTheque"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'TSB_Fermer
        '
        Me.TSB_Fermer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSB_Fermer.Image = Global.Application_MDI.My.Resources.Resources.Fermer
        resources.ApplyResources(Me.TSB_Fermer, "TSB_Fermer")
        Me.TSB_Fermer.Name = "TSB_Fermer"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'TSB_Cascade
        '
        Me.TSB_Cascade.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSB_Cascade.Image = Global.Application_MDI.My.Resources.Resources.TileCascade
        resources.ApplyResources(Me.TSB_Cascade, "TSB_Cascade")
        Me.TSB_Cascade.Name = "TSB_Cascade"
        '
        'TSB_Horisontal
        '
        Me.TSB_Horisontal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSB_Horisontal.Image = Global.Application_MDI.My.Resources.Resources.TileHorizontal
        resources.ApplyResources(Me.TSB_Horisontal, "TSB_Horisontal")
        Me.TSB_Horisontal.Name = "TSB_Horisontal"
        '
        'TSB_Vertical
        '
        Me.TSB_Vertical.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSB_Vertical.Image = Global.Application_MDI.My.Resources.Resources.TileVertical
        resources.ApplyResources(Me.TSB_Vertical, "TSB_Vertical")
        Me.TSB_Vertical.Name = "TSB_Vertical"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        resources.ApplyResources(Me.ToolStripSeparator3, "ToolStripSeparator3")
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.QuitterToolStripMenuItem.Image = Global.Application_MDI.My.Resources.Resources.Quitter
        resources.ApplyResources(Me.QuitterToolStripMenuItem, "QuitterToolStripMenuItem")
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        '
        'TSB_FermerAll
        '
        Me.TSB_FermerAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSB_FermerAll.Image = Global.Application_MDI.My.Resources.Resources.Fermer_tout
        resources.ApplyResources(Me.TSB_FermerAll, "TSB_FermerAll")
        Me.TSB_FermerAll.Name = "TSB_FermerAll"
        '
        'MenuMemory
        '
        Me.MenuMemory.Image = Global.Application_MDI.My.Resources.Resources.Cards_16px
        Me.MenuMemory.Name = "MenuMemory"
        resources.ApplyResources(Me.MenuMemory, "MenuMemory")
        '
        'MenuSudoku
        '
        Me.MenuSudoku.Image = Global.Application_MDI.My.Resources.Resources.Grid_16px
        Me.MenuSudoku.Name = "MenuSudoku"
        resources.ApplyResources(Me.MenuSudoku, "MenuSudoku")
        '
        'MenuQuiz
        '
        Me.MenuQuiz.Image = Global.Application_MDI.My.Resources.Resources.Pass_Fail_16px
        Me.MenuQuiz.Name = "MenuQuiz"
        resources.ApplyResources(Me.MenuQuiz, "MenuQuiz")
        '
        'MDI
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MDI"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSB_OuvrirF1 As ToolStripButton
    Friend WithEvents TSB_OuvrirF2 As ToolStripButton
    Friend WithEvents TSB_Calcul As ToolStripButton
    Friend WithEvents TSB_Palindrome As ToolStripButton
    Friend WithEvents TSB_evasion As ToolStripButton
    Friend WithEvents TSB_evasion_V2 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TSB_Fermer As ToolStripButton
    Friend WithEvents TSB_FermerAll As ToolStripButton
    Friend WithEvents TSB_Cascade As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents TSB_Vertical As ToolStripButton
    Friend WithEvents TSB_Horisontal As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents QuitterToolStripMenuItem As ToolStripButton
    Friend WithEvents Nb_fenêtreFille As ToolStripStatusLabel
    Friend WithEvents OuvrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuForm1 As ToolStripMenuItem
    Friend WithEvents MenuForm2 As ToolStripMenuItem
    Friend WithEvents MenuFermer As ToolStripMenuItem
    Friend WithEvents QuiterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSM_Fenêtre As ToolStripMenuItem
    Friend WithEvents MenuCascade As ToolStripMenuItem
    Friend WithEvents MenuVertical As ToolStripMenuItem
    Friend WithEvents MenuHorisontal As ToolStripMenuItem
    Friend WithEvents TSM_About As ToolStripMenuItem
    Friend WithEvents MenuCalcul As ToolStripMenuItem
    Friend WithEvents MenuPalindrome As ToolStripMenuItem
    Friend WithEvents MenuJeux As ToolStripMenuItem
    Friend WithEvents MenuEvasion As ToolStripMenuItem
    Friend WithEvents MenuEvasionV2 As ToolStripMenuItem
    Friend WithEvents MenuFermerActive As ToolStripMenuItem
    Friend WithEvents MenuFermerAll As ToolStripMenuItem
    Friend WithEvents TSB_PersonalTheque As ToolStripButton
    Friend WithEvents BT_OuvrirFactoriel As ToolStripButton
    Friend WithEvents TSB_factoriel As ToolStripButton
    Friend WithEvents MenuFactorielle As ToolStripMenuItem
    Friend WithEvents ParametreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuPersonalTheque As ToolStripMenuItem
    Friend WithEvents TSM_memory As ToolStripDropDownButton
    Friend WithEvents TSB_memory As ToolStripMenuItem
    Friend WithEvents SudokuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuizzToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuMemory As ToolStripMenuItem
    Friend WithEvents MenuSudoku As ToolStripMenuItem
    Friend WithEvents MenuQuiz As ToolStripMenuItem
End Class
