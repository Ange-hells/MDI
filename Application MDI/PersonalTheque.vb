Imports System.Xml.Serialization
Imports System.IO

Public Class PersonalTheque
    Private _FenetreAjout As AjoutEditionFilm
    Private _FilmEnVisualisation As Film
    Private _ListeFilms As List(Of Film)

    Public Property ListeFilms As List(Of Film)
        Get
            Return _ListeFilms
        End Get
        Set(ByVal value As List(Of Film))
            _ListeFilms = value
        End Set
    End Property

    Private Sub ListeFilms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Instancie une nouvelle liste
        _ListeFilms = New List(Of Film)

        'Récupère les infos
        Deserialisation()

        'MAJ la liste de films
        UpdateListe()

    End Sub

    Private Sub ListeFilms_FormClosing(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        'Sérialise les films lors de la fermeture
        Serialisation()
    End Sub

    Private Sub LB_LISTE_FILMS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB_LISTE_FILMS.SelectedIndexChanged

        'On vérifie qu'on a sélectionné quelque chose
        If Not Me.LB_LISTE_FILMS.SelectedItem Is Nothing Then
            'Retrouve le film avec ce nom
            For Each FilmALister As Film In _ListeFilms
                If FilmALister.Nom = LB_LISTE_FILMS.SelectedItem.ToString Then
                    'L'insère dans une variable globale
                    Me._FilmEnVisualisation = FilmALister
                End If
            Next

            'On MAJ les infos de la fiche
            Me.LBL_TITRE.Text = Me._FilmEnVisualisation.Nom
            Me.LBL_DATE_SORTIE.Text = Me._FilmEnVisualisation.DateSortie.ToShortDateString 'La date seule
            Me.LBL_REALISATEUR.Text = Me._FilmEnVisualisation.Genre1
            Me.LBL_GENRE1.Text = Me._FilmEnVisualisation.Genre2
            Me.LBL_REALISATEUR.Text = Me._FilmEnVisualisation.Realisateur
            Me.LBL_ACTEURS.Text = Me._FilmEnVisualisation.Acteurs
            Me.LBL_SYNOPSIS.Text = Me._FilmEnVisualisation.Synopsis
            Me.LBL_AVIS_PERSONNEL.Text = Me._FilmEnVisualisation.RemarquePerso
            Me.LBL_NOTE.Text = Me._FilmEnVisualisation.NotePerso

        End If

    End Sub

    Public Sub UpdateListe()
        'On vide la liste et on la reremplit
        Me.LB_LISTE_FILMS.Items.Clear()
        'Parcourt les films de la bibliothèque
        For Each FilmALister As Film In _ListeFilms
            'Remplit la liste en se basant sur le nom (vu que j'ai surchargé ToString)
            'A le même effet que FilmALister.Nom sans la surcharge.
            Me.LB_LISTE_FILMS.Items.Add(FilmALister)
        Next
    End Sub

#Region "Boutons modif fiche"

    Private Sub BT_SUPPRIMER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_SUPPRIMER.Click

        'Confirmation
        If MsgBox("Etes vous certain de vouloir supprimer ce film ?", vbYesNo, "Confirmation") Then
            'On le retire de la liste
            Me._ListeFilms.Remove(_FilmEnVisualisation)
        End If

        'MAJ
        UpdateListe()

    End Sub

    Private Sub BT_NOUVELLE_FICHE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_NOUVELLE_FICHE.Click
        'Si nouveau film, on passe nothing
        _FenetreAjout = New AjoutEditionFilm(Nothing)
        _FenetreAjout.Show()

    End Sub

    Private Sub BT_MAJ_FICHE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_MAJ_FICHE.Click
        'Si une MAJ, on passe le paramètre du film actuel
        _FenetreAjout = New AjoutEditionFilm(_FilmEnVisualisation)
        _FenetreAjout.Show()
    End Sub

#End Region

#Region "Sauvegarde et récupération"

    Private Sub Deserialisation()
        If File.Exists("BibliothequeFilm.xml") Then
            'On ouvre le fichier et récupère son flux
            Dim FluxDeFichier As Stream = File.OpenRead("BibliothequeFilm.xml")
            Dim Deserialiseur As New XmlSerializer(GetType(List(Of Film)))
            'Désérialisation et conversion de ce qu'on récupère dans le type « Film »
            _ListeFilms = Deserialiseur.Deserialize(FluxDeFichier)
            'Fermeture du flux
            FluxDeFichier.Close()
        End If
    End Sub

    Private Sub Serialisation()
        'On crée le fichier et récupère son flux
        Dim FluxDeFichier As FileStream = File.Create("BibliothequeFilm.xml")
        Dim Serialiseur As New XmlSerializer(GetType(List(Of Film)))
        'Sérialisation et écriture
        Serialiseur.Serialize(FluxDeFichier, _ListeFilms)
        'Fermeture du fichier
        FluxDeFichier.Close()
    End Sub

#End Region

#Region "Section recherche"

    Private Sub RemplissageChampsRecherche()
        'Fonction utilisée plus tard pour préremplir les DDL de genres, réalisateurs…
    End Sub

    Private Sub BT_RECHERCHE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_RECHERCHE.Click
        Recherche()
    End Sub

    Private Sub BT_EFFACER_RECHERCHE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_EFFACER_RECHERCHE.Click
        Me.TXT_TITRE.Text = ""
        Me.DDL_ACTEUR.Text = ""
        Me.DDL_ANNEE.Text = ""
        Me.DDL_GENRE.Text = ""
        Me.LBL_REALISATEUR.Text = ""

        UpdateListe()
    End Sub

    Private Sub Recherche()

        'On vide la liste et on la reremplit
        Me.LB_LISTE_FILMS.Items.Clear()
        'Parcourt les films de la bibliothèque
        For Each FilmALister As Film In _ListeFilms

            If Me.TXT_TITRE.Text <> "" Then
                If FilmALister.Nom.Contains(Me.TXT_TITRE.Text) Then
                    Me.LB_LISTE_FILMS.Items.Add(FilmALister)
                End If
            End If

            If Me.DDL_ACTEUR.Text <> "" Then
                If FilmALister.Acteurs.Contains(Me.DDL_ACTEUR.Text) Then
                    Me.LB_LISTE_FILMS.Items.Add(FilmALister)
                End If
            End If

            If Me.DDL_ANNEE.Text <> "" Then
                If CDate(FilmALister.DateSortie).Year = Me.DDL_ANNEE.Text Then
                    Me.LB_LISTE_FILMS.Items.Add(FilmALister)
                End If
            End If

            If Me.DDL_GENRE.Text <> "" Then
                If FilmALister.Genre1.Contains(Me.DDL_GENRE.Text) Or FilmALister.Genre2.Contains(Me.DDL_GENRE.Text) Then
                    Me.LB_LISTE_FILMS.Items.Add(FilmALister)
                End If
            End If

            If Me.LBL_REALISATEUR.Text <> "" Then
                If FilmALister.Realisateur.Contains(Me.LBL_REALISATEUR.Text) Then
                    Me.LB_LISTE_FILMS.Items.Add(FilmALister)
                End If
            End If

        Next

    End Sub

#End Region

End Class