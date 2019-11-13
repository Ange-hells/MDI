Public Class Memoy

    Dim ListeCartesTapis As ArrayList
    Dim ListeCartesPioche As ArrayList
    Dim ListeCartesJeu As ImageList
    Dim nbcartesmax As Byte = 20

    Private Sub Lancer(sender As System.Object, e As System.EventArgs) Handles BT_generer.Click
        LB_resultat.Text = ""
        Initialiser()
        SelectionnerCartes(CByte(TextBox1.Text))
        AfficherTapis(CByte(TextBox1.Text))
        AfficherPioche()
        GererEvtCartesTapis()
        GererEvtCartesSommetPioche()
        VisualiserImages()
        RetournerCarteSommetPioche()
    End Sub

    Private Sub Chargement(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        LB_resultat.Text = ""
        Me.BT_generer.Enabled = False
        'bt_triche.Enabled = False
        ListeCartesTapis = New ArrayList
        ListeCartesPioche = New ArrayList
        ListeCartesJeu = New ImageList
        ListeCartesJeu.ImageSize = New System.Drawing.Size(71, 106)

        For Each fichier As String In My.Computer.FileSystem.GetFiles("../../../../images/memory/cartes")
            If fichier.Substring(fichier.Length - 4) = ".bmp" And fichier.Substring(fichier.Length - 7) <> "dos.bmp" Then
                ListeCartesJeu.Images.Add(Image.FromFile(fichier))
            End If
        Next
    End Sub

    Private Sub ContrôleSaisie(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        If Asc(e.KeyChar) <> Keys.Back Then
            If Char.IsDigit(e.KeyChar) = False Then
                e.Handled = True
            ElseIf CInt(sender.text + CStr(e.KeyChar) = 0) Or (Int(sender.text + CStr(e.KeyChar) > nbcartesmax)) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Initialiser()
        ListeCartesTapis.Clear()
        ListeCartesPioche.Clear()
        Panelpioche.Controls.Clear()
        Paneltapis.Controls.Clear()

    End Sub

    Private Sub SelectionnerCartes(nbcartes As Byte)
        Dim nb As Byte
        For i As Byte = 0 To nbcartes - 1 Step 1
            Do
                nb = nbaleatoire(ListeCartesJeu.Images.Count - 1)
            Loop While ListeCartesTapis.Contains(nb)
            ListeCartesTapis.Add(nb)
        Next

        ListeCartesPioche = melangercartes(ListeCartesTapis.Clone)

    End Sub

    Private Sub AfficherTapis(ByVal NbCartes As Byte)
        Dim Hauteur As Byte = 106
        Dim Largeur As Byte = 71
        Dim Espacement As Byte = 10
        Dim NbCartesMaxParLigne As Byte = Math.Floor(Paneltapis.Width / (Largeur + Espacement))

        For i As Byte = 0 To NbCartes - 1 Step 1
            Dim unePictureBox As New PictureBox
            With unePictureBox
                .Name = i.ToString
                .Height = Hauteur
                .Width = Largeur
                .Top = Math.Floor(i / NbCartesMaxParLigne) * (Espacement + Hauteur) + 10
                .Left = (Largeur + Espacement) * (i - NbCartesMaxParLigne * Math.Floor(i / NbCartesMaxParLigne))
                .Image = Image.FromFile("../../../../images/memory/cartes\dos.bmp")
                .Enabled = False
                .AllowDrop = True
            End With
            Paneltapis.Controls.Add(unePictureBox)
            Attendre(100)
        Next
    End Sub

    Private Sub AfficherPioche()
        Dim Hauteur As Byte = 106
        Dim Largeur As Byte = 71
        Dim Espacement As Byte = 10

        For i As Byte = 0 To Paneltapis.Controls.Count - 1 Step 1
            Dim unePictureBox As New PictureBox
            With unePictureBox
                .Name = i.ToString
                .Height = Hauteur
                .Width = Largeur
                .Top = 10
                .Left = Espacement * i
                .Image = Image.FromFile("../../../../images/memory/cartes\dos.bmp")
                .Enabled = False
            End With
            Panelpioche.Controls.Add(unePictureBox)
            Panelpioche.Controls.Item(i).BringToFront()
            Attendre(100)
        Next

    End Sub

    Private Sub GererEvtCartesTapis()
        For Each controle As PictureBox In Paneltapis.Controls
            AddHandler controle.DoubleClick, AddressOf EvtTapisDoubleClick
        Next
    End Sub

    Private Sub GererEvtCartesSommetPioche()

    End Sub

    Private Sub EvtTapisDoubleClick(sender As PictureBox, e As System.EventArgs)
        RetournerImage(sender, ListeCartesTapis.Item(CInt(sender.Name)), ListeCartesPioche.Item(0))
    End Sub

    Private Sub RetournerImage(picture As PictureBox, nbtapis As Integer, nbpioche As Integer)
        picture.Image = ListeCartesJeu.Images.Item(ListeCartesTapis.Item(CInt(picture.Name)))
        If nbtapis <> nbpioche Then
            Attendre(1000)
            picture.Image = Image.FromFile("../../../../images/memory/cartes\dos.bmp")
            'If bt_triche.Enabled = False Then
            '    bt_triche.Enabled = True
            'End If
        Else
            Attendre(1000)
            Panelpioche.Controls.RemoveAt(0)
            ListeCartesPioche.RemoveAt(0)
            picture.Hide()
            If ListeCartesPioche.Count <> 0 Then
                RetournerCarteSommetPioche()
            Else
                LB_resultat.Text = "GAGNER !"
            End If
        End If
    End Sub

    Private Sub VisualiserImages()
        Attendre(1000)
        For i As Byte = 0 To Paneltapis.Controls.Count - 1
            CType(Paneltapis.Controls.Item(i), PictureBox).Image = ListeCartesJeu.Images.Item(ListeCartesTapis.Item(i))
        Next
        Attendre(4000)
        For Each controle As PictureBox In Paneltapis.Controls
            controle.Image = Image.FromFile("../../../../images/memory/cartes\dos.bmp")
            controle.Enabled = True
        Next
        Attendre(1000)
    End Sub

    Private Sub RetournerCarteSommetPioche()
        CType(Panelpioche.Controls.Item(0), PictureBox).Image = ListeCartesJeu.Images.Item(ListeCartesPioche.Item(0))
    End Sub

    Private Sub tb_nb_TextChanged(sender As Object, e As System.EventArgs) Handles TextBox1.KeyUp
        BT_generer.Enabled = Not (TextBox1.TextLength = 0)
    End Sub

    Private Function nbaleatoire(ByVal bornesup As UShort, Optional ByVal borneinf As UShort = 0) As Integer
        Randomize()
        Return CInt(Int((bornesup - borneinf + 1) * Rnd() + borneinf))
    End Function

    Private Function melangercartes(ByVal tableau As ArrayList)
        Dim indicevert, temp As Byte

        For indicerouge As Byte = 0 To tableau.Count - 1 Step 1
            indicevert = nbaleatoire(tableau.Count - 1)
            temp = tableau.Item(indicerouge)
            tableau.Item(indicerouge) = tableau.Item(indicevert)
            tableau.Item(indicevert) = temp
        Next
        Return tableau
    End Function

    Private Sub Attendre(ByVal pInterval As Integer)
        Dim Sw As New Stopwatch
        Sw.Start()
        Do While Sw.ElapsedMilliseconds < pInterval
            Application.DoEvents()  ' Allows UI to remain responsive
        Loop
        Sw.Stop()
    End Sub

    'Private Sub bt_triche_Click(sender As Object, e As System.EventArgs) Handles bt_triche.Click
    '    For Each controle As PictureBox In Panel_Tapis.Controls
    '        controle.Enabled = False
    '    Next
    '    For i As Byte = 0 To Panel_Tapis.Controls.Count - 1
    '        CType(Panel_Tapis.Controls.Item(i), PictureBox).Image = ListeCartesJeu.Images.Item(ListeCartesTapis.Item(i))
    '    Next
    '    Attendre(5000)
    '    For Each controle As PictureBox In Panel_Tapis.Controls
    '        controle.Image = Image.FromFile("..\..\cartes\dos.bmp")
    '        controle.Enabled = True
    '    Next
    'End Sub

End Class