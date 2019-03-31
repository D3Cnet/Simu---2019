Public Class AffichageData
    Private Sub AffichageData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        principale.gestionDB.listeEventDB(ComboBox_evenement.Items)
    End Sub

    Private Sub ComboBox_evenement_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_evenement.SelectedIndexChanged
        If ComboBox_evenement.Text <> "" Then
            DataGridView_event.DataSource = principale.gestionDB.listeClesParEvent(ComboBox_evenement.Text).Tables("ListeValeurCle")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class