Public Class Evasion
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TXT_ADRESSE.Text = "http://www.google.fr"
        Me.BT_ADRESSE_Click(Nothing, Nothing)

        Me.BT_SUIVANT.Enabled = False
        Me.BT_PRECEDENT.Enabled = False
        Me.BT_STOP.Enabled = False
    End Sub

    Private Sub WB_NAVIGATEUR_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WB_NAVIGATEUR.DocumentCompleted
        Me.LBL_STATUT.Text = WB_NAVIGATEUR.StatusText
        Me.BT_STOP.Enabled = False
        Me.TXT_ADRESSE.Text = Me.WB_NAVIGATEUR.Url.ToString
    End Sub

    Private Sub WB_NAVIGATEUR_Navigating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles WB_NAVIGATEUR.Navigating
        Me.BT_STOP.Enabled = True
        Me.LBL_STATUT.Text = WB_NAVIGATEUR.StatusText

        If Me.WB_NAVIGATEUR.CanGoForward Then
            Me.BT_SUIVANT.Enabled = True
        Else
            Me.BT_SUIVANT.Enabled = False
        End If
        If Me.WB_NAVIGATEUR.CanGoBack Then
            Me.BT_PRECEDENT.Enabled = True
        Else
            Me.BT_PRECEDENT.Enabled = False
        End If
    End Sub

    Private Sub BT_ADRESSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_ADRESSE.Click
        If Not Me.TXT_ADRESSE Is Nothing Then
            Me.WB_NAVIGATEUR.Navigate(TXT_ADRESSE.Text)
        End If
    End Sub

    Private Sub BT_PRECEDENT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_PRECEDENT.Click
        Me.WB_NAVIGATEUR.GoBack()
    End Sub

    Private Sub BT_SUIVANT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_SUIVANT.Click
        Me.WB_NAVIGATEUR.GoForward()
    End Sub

    Private Sub BT_STOP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_STOP.Click
        Me.BT_STOP.Enabled = False
        Me.WB_NAVIGATEUR.Stop()
    End Sub

    Private Sub BT_REFRESH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_ADRESSE.Click
        Me.WB_NAVIGATEUR.Refresh()
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("Voulez-vous vraiment quitter ce programme ?", 36, "Quitter") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

End Class