Public Class AjoutEditionFilm
    Private _FilmAModifier As Film

    Sub New(ByVal FilmAModifier As Film)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

        'Récupère le film à modifier
        _FilmAModifier = FilmAModifier

    End Sub

    Private Sub AjoutEditionFilm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If _FilmAModifier Is Nothing Then
            'S'il ne contient rien, on en crée un nouveau
        Else
            'Sinon on recupère les infos et on les entre dans les cases correspondantes
            Me.TXT_ACTEURS.Text = _FilmAModifier.Acteurs
            Me.TXT_AVIS_PERSONNEL.Text = _FilmAModifier.RemarquePerso
            Me.TXT_NOM.Text = _FilmAModifier.Nom
            Me.TXT_SYNOPSIS.Text = _FilmAModifier.Synopsis
            Me.DDL_GENRE1.Text = _FilmAModifier.Genre1
            Me.DDL_GENRE2.Text = _FilmAModifier.Genre2
            Me.DDL_REALISATEUR.Text = _FilmAModifier.Realisateur
            Me.NUM_NOTE.Value = _FilmAModifier.NotePerso
            Me.DT_DATE_SORTIE.Value = _FilmAModifier.DateSortie
        End If

    End Sub

    Private Sub BT_SAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_SAVE.Click

        If _FilmAModifier Is Nothing Then
            'Enregistre notre film
            Dim MonFilm As New Film(Me.TXT_NOM.Text, Me.DT_DATE_SORTIE.Value, Me.DDL_REALISATEUR.Text, Me.DDL_GENRE1.Text, Me.DDL_GENRE2.Text, Me.TXT_ACTEURS.Text, Me.TXT_SYNOPSIS.Text, Me.TXT_AVIS_PERSONNEL.Text, Me.NUM_NOTE.Value)
            'On l'ajoute à la liste
            PersonalTheque.ListeFilms.Add(MonFilm)
            MsgBox("Fiche correctement crée", vbOKOnly, "Confirmation")
        Else
            'Sinon on le modifie en récupérant son index dans la liste de la fenêtre parent
            PersonalTheque.ListeFilms(PersonalTheque.ListeFilms.IndexOf(_FilmAModifier)).Update(Me.TXT_NOM.Text, Me.DT_DATE_SORTIE.Value, Me.DDL_REALISATEUR.Text, Me.DDL_GENRE1.Text, Me.DDL_GENRE2.Text, Me.TXT_ACTEURS.Text, Me.TXT_SYNOPSIS.Text, Me.TXT_AVIS_PERSONNEL.Text, Me.NUM_NOTE.Value)
        End If

        'MAJ de la liste dans la fenêtre parent
        PersonalTheque.UpdateListe()
        'Ferme la fenêtre d'édition
        Me.Close()
    End Sub

    Private Sub IMG_AFFICHE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IMG_AFFICHE.Click
        'Ultérieur ; possibilité d'ajouter une fiche.
    End Sub

End Class