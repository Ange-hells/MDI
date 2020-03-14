Public Class MDI

    Private Sub MDI_Load(sender As Object, e As EventArgs) Handles Me.Load
        sytemeGestion.MajAccessibiliterMenu(Me)
        sytemeGestion.Majstatu(Me)
    End Sub

#Region "ouvrir"
    Public Sub OuvrirForm1(sender As Object, e As EventArgs) Handles TSB_OuvrirF1.Click, MenuForm1.Click
        sytemeGestion.ouvrirForm1(Me)
    End Sub

    Public Sub OuvrirForm2(sender As Object, e As EventArgs) Handles TSB_OuvrirF2.Click, MenuForm2.Click
        sytemeGestion.ouvrirForm2(Me)
    End Sub

    Private Sub OuvrirAPropos(sender As Object, e As EventArgs) Handles TSM_About.Click
        A_Propos.ShowDialog()
        sytemeGestion.MajAccessibiliterMenu(Me)
    End Sub

    Private Sub OuvrirCalcul(sender As Object, e As EventArgs) Handles TSB_Calcul.Click, MenuCalcul.Click
        sytemeGestion.ouvrirCalcul(Me)
    End Sub

    Private Sub OuvrirPalindrome(sender As Object, e As EventArgs) Handles TSB_Palindrome.Click, MenuPalindrome.Click
        sytemeGestion.ouvrirPalindrome(Me)
    End Sub

    Private Sub Ouvrirmemory(sender As Object, e As EventArgs) Handles TSB_memory.Click, MenuJeux.Click
        sytemeGestion.ouvrirMemory(Me)
    End Sub

    Public Sub OuvrirFactoriel(sender As Object, e As EventArgs) Handles TSB_factoriel.Click, MenuFactorielle.Click
        sytemeGestion.ouvrirFactoriel(Me)
    End Sub

    Private Sub Ouvrirevasion(sender As Object, e As EventArgs) Handles TSB_evasion.Click, MenuEvasion.Click
        sytemeGestion.ouvrirEvasion(Me)
    End Sub

    Private Sub Ouvrirevasion_V2(sender As Object, e As EventArgs) Handles TSB_evasion_V2.Click, MenuEvasionV2.Click
        sytemeGestion.ouvrirEvasionV2(Me)
    End Sub

    Private Sub OuvrirPersonalTheque(sender As Object, e As EventArgs) Handles TSB_PersonalTheque.Click, MenuPersonalTheque.Click
        sytemeGestion.ouvrirPersonalTheque(Me)
    End Sub

    Private Sub OuvrirParametre(sender As Object, e As EventArgs) Handles ParametreToolStripMenuItem.Click
        Setting.ShowDialog()
        sytemeGestion.MajAccessibiliterMenu(Me)
    End Sub

    Private Sub SudokuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SudokuToolStripMenuItem.Click, MenuSudoku.Click
        sytemeGestion.ouvrirSudoku(Me)
    End Sub
    Private Sub QuizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuizzToolStripMenuItem.Click, MenuQuiz.Click
        sytemeGestion.ouvrirQuiz(Me)
    End Sub
    Private Sub ChifumiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChifumiToolStripMenuItem.Click
        sytemeGestion.ouvrirChifumi(Me)
    End Sub

    Private Sub _007ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles _007ToolStripMenuItem.Click
        sytemeGestion.ouvrir007(Me)
    End Sub

#End Region

#Region "fermer"
    Private Sub FermerFilleActive(sender As Object, e As EventArgs) Handles TSB_Fermer.Click
        sytemeGestion.FermerFenetreFille(Me)
    End Sub

    Private Sub MenuFermerFilleActive(sender As Object, e As EventArgs) Handles MenuFermerActive.Click
        sytemeGestion.FermerFenetreFille(Me)
    End Sub

    Private Sub TSB_FermerAll_Click(sender As Object, e As EventArgs) Handles TSB_FermerAll.Click
        sytemeGestion.FermerAllFille(Me)
    End Sub

    Private Sub MenuFermerAll_Click(sender As Object, e As EventArgs) Handles MenuFermerAll.Click
        sytemeGestion.FermerAllFille(Me)
    End Sub
#End Region

#Region "layout"
    Private Sub TSB_Cascade_Click(sender As Object, e As EventArgs) Handles TSB_Cascade.Click, MenuCascade.Click
        Dim valeur As Short
        valeur = 1
        sytemeGestion.Layout(valeur, Me)
    End Sub

    Private Sub TSB_Vertical_Click(sender As Object, e As EventArgs) Handles TSB_Vertical.Click, MenuVertical.Click
        Dim valeur As Short
        valeur = 2
        sytemeGestion.Layout(valeur, Me)
    End Sub

    Private Sub TSB_Horisontal_Click(sender As Object, e As EventArgs) Handles TSB_Horisontal.Click, MenuHorisontal.Click
        Dim valeur As Short
        valeur = 3
        sytemeGestion.Layout(valeur, Me)
    End Sub

#End Region

End Class