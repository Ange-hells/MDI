<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonalTheque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PersonalTheque))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BT_SUPPRIMER = New System.Windows.Forms.Button()
        Me.BT_NOUVELLE_FICHE = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LBL_NOTE = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.VScrollBar2 = New System.Windows.Forms.VScrollBar()
        Me.LBL_AVIS_PERSONNEL = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.LBL_SYNOPSIS = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LBL_ACTEURS = New System.Windows.Forms.ListBox()
        Me.LBL_GENRE2 = New System.Windows.Forms.ComboBox()
        Me.LBL_GENRE1 = New System.Windows.Forms.ComboBox()
        Me.LBL_REALISATEUR = New System.Windows.Forms.ComboBox()
        Me.LBL_DATE_SORTIE = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBL_TITRE = New System.Windows.Forms.TextBox()
        Me.IMG_AFFICHE = New System.Windows.Forms.PictureBox()
        Me.BT_MAJ_FICHE = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BT_EFFACER_RECHERCHE = New System.Windows.Forms.Button()
        Me.BT_RECHERCHE = New System.Windows.Forms.Button()
        Me.DDL_ANNEE = New System.Windows.Forms.ComboBox()
        Me.DDL_GENRE = New System.Windows.Forms.ComboBox()
        Me.DDL_REALISATEUR = New System.Windows.Forms.ComboBox()
        Me.DDL_ACTEUR = New System.Windows.Forms.ComboBox()
        Me.TXT_TITRE = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LB_LISTE_FILMS = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LBL_NOTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMG_AFFICHE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BT_SUPPRIMER)
        Me.GroupBox1.Controls.Add(Me.BT_NOUVELLE_FICHE)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.LBL_NOTE)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.VScrollBar2)
        Me.GroupBox1.Controls.Add(Me.LBL_AVIS_PERSONNEL)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.VScrollBar1)
        Me.GroupBox1.Controls.Add(Me.LBL_SYNOPSIS)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.LBL_ACTEURS)
        Me.GroupBox1.Controls.Add(Me.LBL_GENRE2)
        Me.GroupBox1.Controls.Add(Me.LBL_GENRE1)
        Me.GroupBox1.Controls.Add(Me.LBL_REALISATEUR)
        Me.GroupBox1.Controls.Add(Me.LBL_DATE_SORTIE)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LBL_TITRE)
        Me.GroupBox1.Controls.Add(Me.IMG_AFFICHE)
        Me.GroupBox1.Controls.Add(Me.BT_MAJ_FICHE)
        Me.GroupBox1.Location = New System.Drawing.Point(228, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 531)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fiche détaillée"
        '
        'BT_SUPPRIMER
        '
        Me.BT_SUPPRIMER.Location = New System.Drawing.Point(89, 497)
        Me.BT_SUPPRIMER.Name = "BT_SUPPRIMER"
        Me.BT_SUPPRIMER.Size = New System.Drawing.Size(111, 28)
        Me.BT_SUPPRIMER.TabIndex = 67
        Me.BT_SUPPRIMER.Text = "Supprimer la fiche"
        Me.BT_SUPPRIMER.UseVisualStyleBackColor = True
        '
        'BT_NOUVELLE_FICHE
        '
        Me.BT_NOUVELLE_FICHE.Location = New System.Drawing.Point(212, 497)
        Me.BT_NOUVELLE_FICHE.Name = "BT_NOUVELLE_FICHE"
        Me.BT_NOUVELLE_FICHE.Size = New System.Drawing.Size(112, 28)
        Me.BT_NOUVELLE_FICHE.TabIndex = 66
        Me.BT_NOUVELLE_FICHE.Text = "Créée nouvelle fiche"
        Me.BT_NOUVELLE_FICHE.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(93, 454)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 13)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "/20"
        '
        'LBL_NOTE
        '
        Me.LBL_NOTE.Location = New System.Drawing.Point(51, 452)
        Me.LBL_NOTE.Name = "LBL_NOTE"
        Me.LBL_NOTE.Size = New System.Drawing.Size(36, 20)
        Me.LBL_NOTE.TabIndex = 64
        Me.LBL_NOTE.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 454)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Label8"
        '
        'VScrollBar2
        '
        Me.VScrollBar2.Location = New System.Drawing.Point(418, 364)
        Me.VScrollBar2.Name = "VScrollBar2"
        Me.VScrollBar2.Size = New System.Drawing.Size(20, 82)
        Me.VScrollBar2.TabIndex = 59
        '
        'LBL_AVIS_PERSONNEL
        '
        Me.LBL_AVIS_PERSONNEL.FormattingEnabled = True
        Me.LBL_AVIS_PERSONNEL.Location = New System.Drawing.Point(6, 364)
        Me.LBL_AVIS_PERSONNEL.Name = "LBL_AVIS_PERSONNEL"
        Me.LBL_AVIS_PERSONNEL.Size = New System.Drawing.Size(432, 82)
        Me.LBL_AVIS_PERSONNEL.TabIndex = 62
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 348)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Label7"
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(418, 250)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(20, 95)
        Me.VScrollBar1.TabIndex = 58
        '
        'LBL_SYNOPSIS
        '
        Me.LBL_SYNOPSIS.FormattingEnabled = True
        Me.LBL_SYNOPSIS.Location = New System.Drawing.Point(6, 250)
        Me.LBL_SYNOPSIS.Name = "LBL_SYNOPSIS"
        Me.LBL_SYNOPSIS.Size = New System.Drawing.Size(432, 95)
        Me.LBL_SYNOPSIS.TabIndex = 60
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Label6"
        '
        'LBL_ACTEURS
        '
        Me.LBL_ACTEURS.FormattingEnabled = True
        Me.LBL_ACTEURS.Location = New System.Drawing.Point(272, 162)
        Me.LBL_ACTEURS.Name = "LBL_ACTEURS"
        Me.LBL_ACTEURS.Size = New System.Drawing.Size(166, 56)
        Me.LBL_ACTEURS.TabIndex = 56
        '
        'LBL_GENRE2
        '
        Me.LBL_GENRE2.FormattingEnabled = True
        Me.LBL_GENRE2.Location = New System.Drawing.Point(317, 135)
        Me.LBL_GENRE2.Name = "LBL_GENRE2"
        Me.LBL_GENRE2.Size = New System.Drawing.Size(121, 21)
        Me.LBL_GENRE2.TabIndex = 55
        '
        'LBL_GENRE1
        '
        Me.LBL_GENRE1.FormattingEnabled = True
        Me.LBL_GENRE1.Location = New System.Drawing.Point(317, 108)
        Me.LBL_GENRE1.Name = "LBL_GENRE1"
        Me.LBL_GENRE1.Size = New System.Drawing.Size(121, 21)
        Me.LBL_GENRE1.TabIndex = 54
        '
        'LBL_REALISATEUR
        '
        Me.LBL_REALISATEUR.FormattingEnabled = True
        Me.LBL_REALISATEUR.Location = New System.Drawing.Point(317, 81)
        Me.LBL_REALISATEUR.Name = "LBL_REALISATEUR"
        Me.LBL_REALISATEUR.Size = New System.Drawing.Size(121, 21)
        Me.LBL_REALISATEUR.TabIndex = 53
        '
        'LBL_DATE_SORTIE
        '
        Me.LBL_DATE_SORTIE.Location = New System.Drawing.Point(238, 51)
        Me.LBL_DATE_SORTIE.Name = "LBL_DATE_SORTIE"
        Me.LBL_DATE_SORTIE.Size = New System.Drawing.Size(200, 20)
        Me.LBL_DATE_SORTIE.TabIndex = 52
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(153, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Acteur : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(153, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Genre 2 : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(153, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Genre 1 : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(153, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Realisateur : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Date de sortie : "
        '
        'LBL_TITRE
        '
        Me.LBL_TITRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TITRE.Location = New System.Drawing.Point(153, 19)
        Me.LBL_TITRE.Name = "LBL_TITRE"
        Me.LBL_TITRE.Size = New System.Drawing.Size(285, 26)
        Me.LBL_TITRE.TabIndex = 46
        '
        'IMG_AFFICHE
        '
        Me.IMG_AFFICHE.Location = New System.Drawing.Point(6, 19)
        Me.IMG_AFFICHE.Name = "IMG_AFFICHE"
        Me.IMG_AFFICHE.Size = New System.Drawing.Size(141, 199)
        Me.IMG_AFFICHE.TabIndex = 45
        Me.IMG_AFFICHE.TabStop = False
        '
        'BT_MAJ_FICHE
        '
        Me.BT_MAJ_FICHE.Location = New System.Drawing.Point(330, 497)
        Me.BT_MAJ_FICHE.Name = "BT_MAJ_FICHE"
        Me.BT_MAJ_FICHE.Size = New System.Drawing.Size(108, 28)
        Me.BT_MAJ_FICHE.TabIndex = 44
        Me.BT_MAJ_FICHE.Text = "Metre a jour la fiche"
        Me.BT_MAJ_FICHE.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BT_EFFACER_RECHERCHE)
        Me.GroupBox2.Controls.Add(Me.BT_RECHERCHE)
        Me.GroupBox2.Controls.Add(Me.DDL_ANNEE)
        Me.GroupBox2.Controls.Add(Me.DDL_GENRE)
        Me.GroupBox2.Controls.Add(Me.DDL_REALISATEUR)
        Me.GroupBox2.Controls.Add(Me.DDL_ACTEUR)
        Me.GroupBox2.Controls.Add(Me.TXT_TITRE)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(210, 208)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Recherche"
        '
        'BT_EFFACER_RECHERCHE
        '
        Me.BT_EFFACER_RECHERCHE.Location = New System.Drawing.Point(43, 173)
        Me.BT_EFFACER_RECHERCHE.Name = "BT_EFFACER_RECHERCHE"
        Me.BT_EFFACER_RECHERCHE.Size = New System.Drawing.Size(75, 23)
        Me.BT_EFFACER_RECHERCHE.TabIndex = 13
        Me.BT_EFFACER_RECHERCHE.Text = "Reinitialiser"
        Me.BT_EFFACER_RECHERCHE.UseVisualStyleBackColor = True
        '
        'BT_RECHERCHE
        '
        Me.BT_RECHERCHE.Location = New System.Drawing.Point(124, 173)
        Me.BT_RECHERCHE.Name = "BT_RECHERCHE"
        Me.BT_RECHERCHE.Size = New System.Drawing.Size(75, 23)
        Me.BT_RECHERCHE.TabIndex = 12
        Me.BT_RECHERCHE.Text = "Recherche"
        Me.BT_RECHERCHE.UseVisualStyleBackColor = True
        '
        'DDL_ANNEE
        '
        Me.DDL_ANNEE.FormattingEnabled = True
        Me.DDL_ANNEE.Location = New System.Drawing.Point(78, 135)
        Me.DDL_ANNEE.Name = "DDL_ANNEE"
        Me.DDL_ANNEE.Size = New System.Drawing.Size(121, 21)
        Me.DDL_ANNEE.TabIndex = 11
        '
        'DDL_GENRE
        '
        Me.DDL_GENRE.FormattingEnabled = True
        Me.DDL_GENRE.Location = New System.Drawing.Point(78, 108)
        Me.DDL_GENRE.Name = "DDL_GENRE"
        Me.DDL_GENRE.Size = New System.Drawing.Size(121, 21)
        Me.DDL_GENRE.TabIndex = 10
        '
        'DDL_REALISATEUR
        '
        Me.DDL_REALISATEUR.FormattingEnabled = True
        Me.DDL_REALISATEUR.Location = New System.Drawing.Point(78, 81)
        Me.DDL_REALISATEUR.Name = "DDL_REALISATEUR"
        Me.DDL_REALISATEUR.Size = New System.Drawing.Size(121, 21)
        Me.DDL_REALISATEUR.TabIndex = 9
        '
        'DDL_ACTEUR
        '
        Me.DDL_ACTEUR.FormattingEnabled = True
        Me.DDL_ACTEUR.Location = New System.Drawing.Point(78, 54)
        Me.DDL_ACTEUR.Name = "DDL_ACTEUR"
        Me.DDL_ACTEUR.Size = New System.Drawing.Size(121, 21)
        Me.DDL_ACTEUR.TabIndex = 8
        '
        'TXT_TITRE
        '
        Me.TXT_TITRE.Location = New System.Drawing.Point(78, 17)
        Me.TXT_TITRE.Name = "TXT_TITRE"
        Me.TXT_TITRE.Size = New System.Drawing.Size(121, 20)
        Me.TXT_TITRE.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 138)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Année : "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 111)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Genre : "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 84)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Réalisateur : "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Acteur : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Titre : "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LB_LISTE_FILMS)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 226)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(210, 317)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Liste des films"
        '
        'LB_LISTE_FILMS
        '
        Me.LB_LISTE_FILMS.FormattingEnabled = True
        Me.LB_LISTE_FILMS.Location = New System.Drawing.Point(6, 20)
        Me.LB_LISTE_FILMS.Name = "LB_LISTE_FILMS"
        Me.LB_LISTE_FILMS.Size = New System.Drawing.Size(198, 290)
        Me.LB_LISTE_FILMS.TabIndex = 0
        '
        'PersonalTheque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 549)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(707, 588)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(707, 588)
        Me.Name = "PersonalTheque"
        Me.Text = "PersonalTheque"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LBL_NOTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMG_AFFICHE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents LBL_NOTE As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents VScrollBar2 As VScrollBar
    Friend WithEvents LBL_AVIS_PERSONNEL As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents LBL_SYNOPSIS As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LBL_ACTEURS As ListBox
    Friend WithEvents LBL_GENRE2 As ComboBox
    Friend WithEvents LBL_GENRE1 As ComboBox
    Friend WithEvents LBL_REALISATEUR As ComboBox
    Friend WithEvents LBL_DATE_SORTIE As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LBL_TITRE As TextBox
    Friend WithEvents IMG_AFFICHE As PictureBox
    Friend WithEvents BT_MAJ_FICHE As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LB_LISTE_FILMS As ListBox
    Friend WithEvents BT_EFFACER_RECHERCHE As Button
    Friend WithEvents BT_RECHERCHE As Button
    Friend WithEvents DDL_ANNEE As ComboBox
    Friend WithEvents DDL_GENRE As ComboBox
    Friend WithEvents DDL_REALISATEUR As ComboBox
    Friend WithEvents DDL_ACTEUR As ComboBox
    Friend WithEvents TXT_TITRE As TextBox
    Friend WithEvents BT_SUPPRIMER As Button
    Friend WithEvents BT_NOUVELLE_FICHE As Button
End Class
