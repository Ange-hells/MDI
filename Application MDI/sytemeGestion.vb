Public Module sytemeGestion

#Region "MajAccessibiliterMenu"
    Dim MDItext As String = "application MDI"
    Sub MajAccessibiliterMenu(ByVal MDI As MDI)
        If MDI.MdiChildren.Length = 0 Then
            With MDI
                .Text = MDItext
                .MenuFermer.Enabled = False
                .TSM_Fenêtre.Enabled = False
                .TSB_Vertical.Enabled = False
                .TSB_Fermer.Enabled = False
                .TSB_FermerAll.Enabled = False
                .TSB_Cascade.Enabled = False
                .TSB_Horisontal.Enabled = False
                .TSB_Vertical.Enabled = False
                .Nb_fenêtreFille.Enabled = False
            End With
        Else
            If MDI.MdiChildren.Length >= 1 Then
                With MDI
                    .MenuFermer.Enabled = True
                    .TSM_Fenêtre.Enabled = True
                    .TSB_Vertical.Enabled = True
                    .TSB_Fermer.Enabled = True
                    .TSB_FermerAll.Enabled = True
                    .TSB_Cascade.Enabled = True
                    .TSB_Horisontal.Enabled = True
                    .TSB_Vertical.Enabled = True
                    .Nb_fenêtreFille.Enabled = True
                    .Text = MDItext & " - " & MDI.ActiveMdiChild.Name
                End With
            End If
        End If

    End Sub

    Sub Majstatu(ByVal MDI As MDI)

        Dim i As UShort
        i = 0
        If MDI.ActiveMdiChild Is Nothing Then
            MDI.Nb_fenêtreFille.Text = "Aucune fenetre fille n'est ouverte"
            For Each n As ToolStripItem In MDI.ToolStrip1.Items
                If TypeOf n Is ToolStripButton Or TypeOf n Is ToolStripSplitButton Then
                    If n.Name.Contains("Fermer") Or n.Name.Contains("Ranger") Then
                        n.Enabled = False
                    End If
                End If
            Next
            MDI.TSM_Fenêtre.Enabled = False
            ' MDI.Fermer.Enabled = False
        Else
            For Each n As ToolStripItem In MDI.ToolStrip1.Items
                If TypeOf n Is ToolStripButton Or TypeOf n Is ToolStripSplitButton Then
                    If n.Name.Contains("Fermer") Or n.Name.Contains("Ranger") Then
                        n.Enabled = True
                        MDI.Nb_fenêtreFille.Text = CStr(MDI.MdiChildren.Length) & " fenetre(s) ouverte(s)"
                    End If
                End If
            Next
            MDI.TSM_Fenêtre.Enabled = True
            ' MDI.Fermer.Enabled = True
        End If

    End Sub

#End Region

#Region "ouvertur des fenetre fille"
    Sub ouvrirForm1(ByVal MDI As MDI)
        Dim ouvrir As New Form1
        ouvrir.MdiParent = MDI
        ouvrir.Show()
        sytemeGestion.MajAccessibiliterMenu(MDI)
        sytemeGestion.Majstatu(MDI)
    End Sub
    Sub ouvrirForm2(ByVal MDI As MDI)
        Dim ouvrir As New Form2
        ouvrir.MdiParent = MDI
        ouvrir.Show()
        sytemeGestion.MajAccessibiliterMenu(MDI)
        sytemeGestion.Majstatu(MDI)
    End Sub
    Sub ouvrirCalcul(ByVal MDI As MDI)
        Dim ouvrir As New Calcul
        ouvrir.MdiParent = MDI
        ouvrir.Show()
        sytemeGestion.MajAccessibiliterMenu(MDI)
        sytemeGestion.Majstatu(MDI)
    End Sub
    Sub ouvrirPalindrome(ByVal MDI As MDI)
        Dim ouvrir As New Palindrome
        ouvrir.MdiParent = MDI
        ouvrir.Show()
        sytemeGestion.MajAccessibiliterMenu(MDI)
        sytemeGestion.Majstatu(MDI)
    End Sub
    Sub ouvrirMemory(ByVal MDI As MDI)
        Dim ouvrir As New Memoy
        ouvrir.MdiParent = MDI
        ouvrir.Show()
        sytemeGestion.MajAccessibiliterMenu(MDI)
        sytemeGestion.Majstatu(MDI)
    End Sub
    Sub ouvrirFactoriel(ByVal MDI As MDI)
        Dim ouvrir As New Factoriel
        ouvrir.MdiParent = MDI
        ouvrir.Show()
        sytemeGestion.MajAccessibiliterMenu(MDI)
        sytemeGestion.Majstatu(MDI)
    End Sub
    Sub ouvrirEvasion(ByVal MDI As MDI)
        Dim ouvrir As New Evasion
        ouvrir.MdiParent = MDI
        ouvrir.Show()
        sytemeGestion.MajAccessibiliterMenu(MDI)
        sytemeGestion.Majstatu(MDI)
    End Sub
    Sub ouvrirEvasionV2(ByVal MDI As MDI)
        Dim ouvrir As New Evasion_V2
        ouvrir.MdiParent = MDI
        ouvrir.Show()
        sytemeGestion.MajAccessibiliterMenu(MDI)
        sytemeGestion.Majstatu(MDI)
    End Sub

    Sub ouvrirPersonalTheque(ByVal MDI As MDI)
        Dim ouvrir As New PersonalTheque
        ouvrir.MdiParent = MDI
        ouvrir.Show()
        sytemeGestion.MajAccessibiliterMenu(MDI)
        sytemeGestion.Majstatu(MDI)
    End Sub

    Sub ouvrirSudoku(ByVal MDI As MDI)
        Dim ouvrir As New Sudoku
        ouvrir.MdiParent = MDI
        ouvrir.Show()
        sytemeGestion.MajAccessibiliterMenu(MDI)
        sytemeGestion.Majstatu(MDI)
    End Sub
    Sub ouvrirQuiz(ByVal MDI As MDI)
        Dim ouvrir As New Form3
        ouvrir.MdiParent = MDI
        ouvrir.Show()
        sytemeGestion.MajAccessibiliterMenu(MDI)
        sytemeGestion.Majstatu(MDI)
    End Sub
#End Region

#Region "fermetur des fenetre fille"
    Sub FermerFenetreFille(ByVal MDI As MDI)
        MDI.ActiveMdiChild.Close()
        sytemeGestion.MajAccessibiliterMenu(MDI)
    End Sub
    Sub FermerAllFille(ByVal MDI As MDI)
        Dim form As Form
        For Each form In MDI.MdiChildren
            form.Close()
        Next
        sytemeGestion.MajAccessibiliterMenu(MDI)
    End Sub
#End Region

#Region "layout"
    Sub Layout(ByVal valeur As Short, ByVal MDI As MDI)
        If valeur = 1 Then
            MDI.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade)
        ElseIf valeur = 2 Then
            MDI.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical)
        ElseIf valeur = 3 Then
            MDI.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal)
        End If
    End Sub
#End Region

#Region "langue"
    Public Sub SelectLangue(ByVal Langue As String, MDI As MDI)
        If Langue = "Français" Then
            With MDI
                .FichierToolStripMenuItem.Text = "Fichier"
                .TSM_Fenêtre.Text = "Fênetre"
                .TSM_About.Text = "A Propos"
                .QuiterToolStripMenuItem.Text = "Quitter"
                .ParametreToolStripMenuItem.Text = "Parametre"
                .MenuFermer.Text = "Fermer"
                .OuvrirToolStripMenuItem.Text = "Ouvrir"
                .MenuCascade.Text = "Cascade"
                .MenuVertical.Text = "Vertical"
                .MenuHorisontal.Text = "Horizontal"
            End With
            MDItext = "application MDI"
        ElseIf Langue = "Espagnol" Then
            With MDI
                .FichierToolStripMenuItem.Text = "Archivos"
                .TSM_Fenêtre.Text = "Ventana"
                .TSM_About.Text = "Acerca de"
                .QuiterToolStripMenuItem.Text = "Cerca"
                .ParametreToolStripMenuItem.Text = "Parámetro"
                .MenuFermer.Text = "Salir"
                .OuvrirToolStripMenuItem.Text = "abrir"
                .MenuCascade.Text = "Cascada"
                .MenuVertical.Text = "Vertical"
                .MenuHorisontal.Text = "Horizontal"
            End With
            MDItext = "solicitud MDI"
        ElseIf Langue = "Anglais" Then
            With MDI
                .FichierToolStripMenuItem.Text = "Files"
                .TSM_Fenêtre.Text = "Windows"
                .TSM_About.Text = "About"
                .QuiterToolStripMenuItem.Text = "Shut"
                .ParametreToolStripMenuItem.Text = "Setting"
                .MenuFermer.Text = "Close"
                .OuvrirToolStripMenuItem.Text = "Open"
                .MenuCascade.Text = "Cascade"
                .MenuVertical.Text = "Vertical"
                .MenuHorisontal.Text = "Horizontal"
            End With
            MDItext = "application MDI"
        End If
    End Sub

#End Region
End Module