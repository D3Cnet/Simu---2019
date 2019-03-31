Option Explicit On
Option Strict On

Public Class principale
    Private opcs As OPC
    Private adresseOPC As String = "127.0.0.1"
    Public gestionDB As GestionDB = New GestionDB

    Private Sub principale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        remplirTableau()
        opcs = New OPC
        AddHandler opcs.GroupeAJour, AddressOf SurGroupeAJour
        AddHandler opcs.GroupeChange, AddressOf SurGroupeAJour
        AddHandler opcs.OPCComm, AddressOf SurConnexion

        gestionDB.OpenDataBase()
    End Sub


    Private Sub principale_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        gestionDB.CloseDatabase()
    End Sub

    Private Sub majBarreEtat(message As String)
        ToolStripStatusLabel_info.Text = $"{message}"
    End Sub

    Private Sub SurGroupeAJour(sender As Object, e As EventArgs)
        Dim monOPC As OPC
        Dim boucle As Integer

        monOPC = CType(sender, OPC)

        If monOPC.DonneesOPC.Count = listeDesLabels.Count Then
            For boucle = 0 To listeDesLabels.Count - 1
                If monOPC.DonneesOPC(boucle).Count <> 0 Then
                    listeDesLabels(boucle).Text = monOPC.DonneesOPC(boucle)(0)
                End If
            Next
        End If

    End Sub

    Private Sub SurConnexion(sender As Object, e As EventArgs)
        majBarreEtat("Connexion réalisée")
    End Sub


    Private Sub AjouterLesClesDeSupervision()
        Dim boucle As Integer

        For boucle = 0 To listeDesCles.Count - 1
            opcs.Souscrire(listeDesCles(boucle), boucle)
        Next
        majBarreEtat("Ajout des clés à superviser terminé.")

    End Sub

    Private Sub Button_connect_Click(sender As Object, e As EventArgs) Handles Button_connect.Click
        If opcs.Serveurs.Count = 0 Then
            MsgBox("Aucun serveur N'est disponible.")
            Exit Sub
        End If

        Try
            majBarreEtat($"Connexion en cours à kepServer@{opcs.Adresse}")
            If opcs.Connect(0) Then
                majBarreEtat("Connexion réussie")
            End If
        Catch ex As Exception
            majBarreEtat($"Erreur de connexion :  {ex.Message}")
        End Try
    End Sub

    Private Sub Button_surveiller_Click(sender As Object, e As EventArgs) Handles Button_surveiller.Click
        AjouterLesClesDeSupervision()
        CheckBox_capture.Enabled = True
        NumericUpDown_capture.Enabled = True
        Label9.Enabled = True
    End Sub

    Private Sub TimerDB_Tick(sender As Object, e As EventArgs) Handles Timer_DB.Tick
        If CheckBox_capture.Checked Then
            PictureBox1.Visible = True
            Timer_icon.Enabled = True

            majBarreEtat("Enregistrement en cours.")
            ' Permet à l'affichage de se réaliser
            Application.DoEvents()

            gestionDB.ajouterEvenementDB(listeDesCles, listeDesLabels)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_afficherBD.Click
        With New AffichageData
            .ShowDialog()
        End With
    End Sub

    Private Sub NumericUpDown_capture_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_capture.ValueChanged
        Timer_DB.Interval = 1000 * CInt(NumericUpDown_capture.Value)
    End Sub

    Private Sub CheckBox_capture_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_capture.CheckedChanged
        Timer_DB.Enabled = CheckBox_capture.Checked
    End Sub

    Private Sub Timer_icon_Tick(sender As Object, e As EventArgs) Handles Timer_icon.Tick
        PictureBox1.Visible = False
        Timer_icon.Enabled = False
        majBarreEtat("Réception des données...")
    End Sub
End Class
