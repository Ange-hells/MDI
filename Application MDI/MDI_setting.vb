Public Class Setting
    Private Sub MDI_setting(sender As Object, e As EventArgs) Handles Me.Load
        ComboBox1.Items.Add("Anglais")
        ComboBox1.Items.Add("Français")
        ComboBox1.Items.Add("Espagnol")
        ComboBox1.SelectedIndex = 2
    End Sub

    Private Sub BT_Valider_Click(sender As Object, e As EventArgs) Handles BT_Valider.Click
        sytemeGestion.SelectLangue(ComboBox1.Text, MDI)
    End Sub

End Class