<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AjoutEditionFilm
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NUM_NOTE = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.VScrollBar2 = New System.Windows.Forms.VScrollBar()
        Me.TXT_AVIS_PERSONNEL = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_ACTEURS = New System.Windows.Forms.ListBox()
        Me.DDL_GENRE2 = New System.Windows.Forms.ComboBox()
        Me.DDL_GENRE1 = New System.Windows.Forms.ComboBox()
        Me.DDL_REALISATEUR = New System.Windows.Forms.ComboBox()
        Me.DT_DATE_SORTIE = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_NOM = New System.Windows.Forms.TextBox()
        Me.IMG_AFFICHE = New System.Windows.Forms.PictureBox()
        Me.BT_SAVE = New System.Windows.Forms.Button()
        Me.TXT_SYNOPSIS = New System.Windows.Forms.TextBox()
        CType(Me.NUM_NOTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMG_AFFICHE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(101, 464)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 13)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "/20"
        '
        'NUM_NOTE
        '
        Me.NUM_NOTE.Location = New System.Drawing.Point(59, 462)
        Me.NUM_NOTE.Name = "NUM_NOTE"
        Me.NUM_NOTE.Size = New System.Drawing.Size(36, 20)
        Me.NUM_NOTE.TabIndex = 42
        Me.NUM_NOTE.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 464)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Label8"
        '
        'VScrollBar2
        '
        Me.VScrollBar2.Location = New System.Drawing.Point(452, 373)
        Me.VScrollBar2.Name = "VScrollBar2"
        Me.VScrollBar2.Size = New System.Drawing.Size(20, 82)
        Me.VScrollBar2.TabIndex = 37
        '
        'TXT_AVIS_PERSONNEL
        '
        Me.TXT_AVIS_PERSONNEL.FormattingEnabled = True
        Me.TXT_AVIS_PERSONNEL.Location = New System.Drawing.Point(12, 373)
        Me.TXT_AVIS_PERSONNEL.Name = "TXT_AVIS_PERSONNEL"
        Me.TXT_AVIS_PERSONNEL.Size = New System.Drawing.Size(460, 82)
        Me.TXT_AVIS_PERSONNEL.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 356)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Avis Personnel : "
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(452, 254)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(20, 95)
        Me.VScrollBar1.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Synopsis : "
        '
        'TXT_ACTEURS
        '
        Me.TXT_ACTEURS.FormattingEnabled = True
        Me.TXT_ACTEURS.Location = New System.Drawing.Point(306, 156)
        Me.TXT_ACTEURS.Name = "TXT_ACTEURS"
        Me.TXT_ACTEURS.Size = New System.Drawing.Size(166, 56)
        Me.TXT_ACTEURS.TabIndex = 34
        '
        'DDL_GENRE2
        '
        Me.DDL_GENRE2.FormattingEnabled = True
        Me.DDL_GENRE2.Location = New System.Drawing.Point(351, 129)
        Me.DDL_GENRE2.Name = "DDL_GENRE2"
        Me.DDL_GENRE2.Size = New System.Drawing.Size(121, 21)
        Me.DDL_GENRE2.TabIndex = 33
        '
        'DDL_GENRE1
        '
        Me.DDL_GENRE1.FormattingEnabled = True
        Me.DDL_GENRE1.Location = New System.Drawing.Point(351, 102)
        Me.DDL_GENRE1.Name = "DDL_GENRE1"
        Me.DDL_GENRE1.Size = New System.Drawing.Size(121, 21)
        Me.DDL_GENRE1.TabIndex = 32
        '
        'DDL_REALISATEUR
        '
        Me.DDL_REALISATEUR.FormattingEnabled = True
        Me.DDL_REALISATEUR.Location = New System.Drawing.Point(351, 75)
        Me.DDL_REALISATEUR.Name = "DDL_REALISATEUR"
        Me.DDL_REALISATEUR.Size = New System.Drawing.Size(121, 21)
        Me.DDL_REALISATEUR.TabIndex = 31
        '
        'DT_DATE_SORTIE
        '
        Me.DT_DATE_SORTIE.Location = New System.Drawing.Point(272, 46)
        Me.DT_DATE_SORTIE.Name = "DT_DATE_SORTIE"
        Me.DT_DATE_SORTIE.Size = New System.Drawing.Size(200, 20)
        Me.DT_DATE_SORTIE.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(184, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Acteur : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(184, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Genre 2 : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(184, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Genre 1 : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Realisateur : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(184, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Date de sortie : "
        '
        'TXT_NOM
        '
        Me.TXT_NOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NOM.Location = New System.Drawing.Point(187, 14)
        Me.TXT_NOM.Name = "TXT_NOM"
        Me.TXT_NOM.Size = New System.Drawing.Size(285, 26)
        Me.TXT_NOM.TabIndex = 24
        '
        'IMG_AFFICHE
        '
        Me.IMG_AFFICHE.Location = New System.Drawing.Point(12, 13)
        Me.IMG_AFFICHE.Name = "IMG_AFFICHE"
        Me.IMG_AFFICHE.Size = New System.Drawing.Size(168, 217)
        Me.IMG_AFFICHE.TabIndex = 23
        Me.IMG_AFFICHE.TabStop = False
        '
        'BT_SAVE
        '
        Me.BT_SAVE.Location = New System.Drawing.Point(376, 500)
        Me.BT_SAVE.Name = "BT_SAVE"
        Me.BT_SAVE.Size = New System.Drawing.Size(96, 28)
        Me.BT_SAVE.TabIndex = 22
        Me.BT_SAVE.Text = "sauvegarder"
        Me.BT_SAVE.UseVisualStyleBackColor = True
        '
        'TXT_SYNOPSIS
        '
        Me.TXT_SYNOPSIS.Location = New System.Drawing.Point(12, 254)
        Me.TXT_SYNOPSIS.Name = "TXT_SYNOPSIS"
        Me.TXT_SYNOPSIS.Size = New System.Drawing.Size(460, 20)
        Me.TXT_SYNOPSIS.TabIndex = 44
        '
        'AjoutEditionFilm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 543)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.TXT_SYNOPSIS)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.NUM_NOTE)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.VScrollBar2)
        Me.Controls.Add(Me.TXT_AVIS_PERSONNEL)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXT_ACTEURS)
        Me.Controls.Add(Me.DDL_GENRE2)
        Me.Controls.Add(Me.DDL_GENRE1)
        Me.Controls.Add(Me.DDL_REALISATEUR)
        Me.Controls.Add(Me.DT_DATE_SORTIE)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_NOM)
        Me.Controls.Add(Me.IMG_AFFICHE)
        Me.Controls.Add(Me.BT_SAVE)
        Me.Name = "AjoutEditionFilm"
        Me.Text = "AjoutEditionFilm"
        CType(Me.NUM_NOTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMG_AFFICHE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents NUM_NOTE As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents VScrollBar2 As VScrollBar
    Friend WithEvents TXT_AVIS_PERSONNEL As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_ACTEURS As ListBox
    Friend WithEvents DDL_GENRE2 As ComboBox
    Friend WithEvents DDL_GENRE1 As ComboBox
    Friend WithEvents DDL_REALISATEUR As ComboBox
    Friend WithEvents DT_DATE_SORTIE As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_NOM As TextBox
    Friend WithEvents IMG_AFFICHE As PictureBox
    Friend WithEvents BT_SAVE As Button
    Friend WithEvents TXT_SYNOPSIS As TextBox
End Class
