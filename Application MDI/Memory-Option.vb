Public Class Memory_Option

    Public Sub ChoixStyleDeCarte(sender As Object, e As EventArgs) Handles CB_CarteStyle.SelectedIndexChanged
        'Memoy.listeImages = New ImageList
        'Memoy.listeTapis = New ArrayList
        'Memoy.listePioche = New ArrayList
        Dim largeur As Integer
        Dim hauteur As Integer

        For Each unFichier As String In My.Computer.FileSystem.GetFiles("../../../../images/memory" & CB_CarteStyle.SelectedItem)
            If Not unFichier.Contains("dos") And Not unFichier Like "*.db" Then
                'Memoy.listeImages.Images.Add(Image.FromFile(unFichier))
            ElseIf unFichier.Contains("dos") Then
                hauteur = Image.FromFile(unFichier).Height
                largeur = Image.FromFile(unFichier).Width

                'Memoy.listeImages.ImageSize = New Size(hauteur, largeur)
            End If
        Next
        Debug.WriteLine(hauteur)
        Debug.WriteLine(largeur)

    End Sub

End Class