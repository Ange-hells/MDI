Public Class memory_V1
    'Public Class Memoy
    '    Dim listeImages As ImageList
    '    Dim listeTapis As ArrayList
    '    Dim listePioche As ArrayList

    '    Public Sub Demarage(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
    '    BT_Option.Enabled = True
    '        'LB_resultat()

    '        listeImages = New ImageList
    '        listeTapis = New ArrayList
    '        listePioche = New ArrayList
    '    listeImages.ImageSize = New Size(71, 106)
    '    For Each unfichier As String In My.Computer.FileSystem.GetFiles("../../../../images/memory/cartes")
    '        ' MessageBox.Show(unfichier)

    '        If Not unfichier.Substring(unfichier.Length = -7) = "dos.bmp" And Not unfichier Like "*.db" Then
    '            ' MessageBox.Show(CStr(listeImages.Images.Count))
    '            listeImages.Images.Add(Image.FromFile(unfichier))
    '        End If
    '    Next

    'End Sub

    '    Private Sub UserSesiControle(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
    '        Dim nbCarteMax As Integer = 20

    '        If Asc(e.KeyChar) <> Keys.Back Then
    '            If Not Char.IsDigit(e.KeyChar) Then
    '                e.Handled = True
    '            ElseIf CInt(sender.text + CStr(e.KeyChar)) = 0 Then
    '                e.Handled = True
    '            ElseIf CInt(sender.text + (e.KeyChar)) > nbCarteMax Then
    '                e.Handled = True
    '            End If
    '        End If
    '    End Sub

    '    Private Function nbaleatoire(ByVal borneSup As UShort, Optional ByVal borneInf As UShort = 0) As Integer
    '        Randomize()
    '        Return CInt(Int((borneSup - borneInf + 1) * Rnd() + borneInf))
    '    End Function

    '    Private Sub Attendre(ByVal pInterval As Integer)
    '        Dim sw As New Stopwatch
    '        sw.Start()
    '        Do While sw.ElapsedMilliseconds < pInterval
    '            Application.DoEvents()  ' Allows UI to remain responsive
    '        Loop
    '        sw.Stop()
    '    End Sub

    '    Private Function Melanger(ByVal tab As ArrayList) As ArrayList
    '        Dim temp As Byte
    '        Dim nbAlea = nbaleatoire(tab.Count - 1)
    '        For i1 As Byte = 0 To tab.Count - 1 Step 1
    '            temp = tab.Item(i1)
    '            tab.Item(i1) = tab.Item(nbAlea)
    '            tab.Item(nbAlea) = temp
    '        Next

    '        Return tab

    '    End Function

    '    Public Sub Affichertapis(ByVal nb As Byte)
    '#Region "v1"
    '        'V1
    '        'For i As Byte = 0 To nb - 1 Step 1
    '        '    Dim uneimage As New PictureBox
    '        '    Dim PBLargeur As Short
    '        '    Dim PBHauteur As Short
    '        '    With uneimage
    '        '        .Name = CStr(i)
    '        '        .Width = PBLargeur
    '        '        .Height = PBHauteur

    '        '    End With
    '        'Next
    '#End Region      'V2
    '        Dim random As New Random()
    '        Dim nbCarteLigne As Byte
    '        nbCarteLigne = Math.Floor(Paneltapis.Width / (listeImages.ImageSize.Width + 10))
    '        For i = 0 To listeImages.Images.Count - 1
    '            Dim uneimage As New PictureBox()
    '            With uneimage
    '                .Size = New Size(listeImages.ImageSize)
    '                .Left = (uneimage.Width + 10) * Math.Floor(i Mod nbCarteLigne)
    '                .Top = (uneimage.Height + 10) * i Mod nbCarteLigne
    '                .Visible = True
    '                .Image = listeImages.Images(random.Next(0, listeImages.Images.Count - 1))
    '            End With
    '            Paneltapis.Controls.Add(uneimage)
    '        Next
    '    End Sub

    '    Private Sub afficherPioche()
    '        Dim random As New Random()
    '        Dim nbCarteLigne As Byte
    '        nbCarteLigne = Math.Floor(Panelpioche.Width / (listeImages.ImageSize.Width + 10))
    '        For i = 0 To listeImages.Images.Count - 1
    '            Dim uneimage As New PictureBox()
    '            With uneimage
    '                .Size = New Size(listeImages.ImageSize)
    '                .Left = (uneimage.Width + 10) * Math.Floor(i Mod nbCarteLigne)
    '                .Top = (uneimage.Height + 10) * i Mod nbCarteLigne
    '                .BringToFront()
    '                .Visible = True
    '                .Image = listeImages.Images(random.Next(0, listeImages.Images.Count - 1))
    '            End With
    '            Panelpioche.Controls.Add(uneimage)
    '        Next
    '    End Sub

    '    Private Sub Lancer(ByVal sender As Object, ByVal e As EventArgs) Handles BT_generer.Click
    '        'Me.Timer1.Enabled = True
    '        Controls.Clear()

    '        SelectionImages(CByte(TextBox1.Text))
    '        Affichertapis(CByte(TextBox1.Text))
    '        'afficherPioche()
    '        'genererevttapis()
    '        'genererEvtPioche()
    '        Visualiserimages()
    '        'retounerPioche()
    '        'listePioche = melanger(listeTapis.Clone)
    '    End Sub

    '    'Public Sub Initialiser()
    '    '    listePioche.Clear()
    '    '    listeTapis.Clear()
    '    '    Paneltapis.Controls.Clear()
    '    '    Panelpioche.Controls.Clear()
    '    'End Sub

    '    Private Sub SelectionImages(ByVal nb_image As SByte)
    '        Dim nb As Byte

    '        For i As Byte = 0 To nb_image - 1 Step 1
    '            Do
    '                nb = nbaleatoire(listeImages.Images.Count)
    '            Loop While listeTapis.Contains(nb)
    '            listeTapis.Add(nb)
    '        Next

    '        listePioche = Melanger(listeTapis.Clone)

    '    End Sub

    '    Private Sub TIM_TIM_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '        If Me.ProgressBar.Value = 100 Then
    '            Me.Timer1.Enabled = False
    '            Me.BT_generer.Enabled = True
    '        Else
    '            Me.ProgressBar.Value = Me.ProgressBar.Value + 1
    '        End If

    '    End Sub

    '    Private Sub BT_Option_Click(sender As Object, e As EventArgs) Handles BT_Option.Click
    '        Memory_Option.ShowDialog()
    '    End Sub

    '    Private Sub LBresultat()
    '        Dim resultat As String
    '        resultat = ""
    '        If resultat = "gagner" Then
    '            LB_resultat.Text = "GANIER"
    '            LB_resultat.ForeColor = Color.Green
    '        ElseIf resultat = "perdu" Then
    '            LB_resultat.Text = "PERDU"
    '            LB_resultat.ForeColor = Color.Red
    '        ElseIf resultat = "" Then
    '            LB_resultat.Text = ""
    '            LB_resultat.ForeColor = Color.Empty
    '        End If

    '    End Sub

    '    Private Sub Visualiserimages()

    '        For Each uneImage As PictureBox In Paneltapis.Controls
    '            uneImage.Image = listeImages.Images.Item(listeTapis.Item(CByte(uneImage.Name))) 'erreur
    '            Attendre(100)
    '        Next
    '        Attendre(2000)

    '        'For Each uneimage As PictureBox In Paneltapis.Controls
    '        '    uneimage.Image = Image.FromFile("../../../../images/memory")
    '        '    Attendre(100)
    '        'Next
    '        For i As SByte = Paneltapis.Controls.Count - 1 To 0 Step -1
    '            CType(Paneltapis.Controls.Item(i), PictureBox).Image = Image.FromFile("../../../../images/memory")
    '            'uneImage.enabled = True
    '            Attendre(100)
    '        Next
    '        Attendre(1000)

    '    End Sub

    '    Private Sub retounerPioche()
    '        CType(Panelpioche.Controls.Item(0), PictureBox).Image = listeImages.Images.Item(listePioche.Item(Panelpioche.Controls.Count - 1)) 'erreur
    '    End Sub

    '    Private Sub genererevttapis()
    '        For Each uneimages As PictureBox In Paneltapis.Controls
    '            AddHandler uneimages.DoubleClick, AddressOf Gestiondooblelick
    '        Next
    '    End Sub

    '    Private Sub Gestiondooblelick(ByVal sender As PictureBox, ByVal e As EventArgs)
    '        sender.Image = listeImages.Images.Item(listeTapis.Item(CByte(sender.Name)))
    '        If listePioche.Item(Panelpioche.Controls.Count - 1) = listeTapis.Item(CByte(sender.Name)) Then
    '            MessageBox.Show("gagner")
    '        Else
    '            MessageBox.Show("perdu")
    '        End If
    '    End Sub

    'End Class
End Class
