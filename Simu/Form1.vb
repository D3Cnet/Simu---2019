Option Explicit On
Option Strict On

Public Class principale
    Private opcs As OPC
    Private adresseOPC As String = "127.0.0.1"
    Private _gestionDB As GestionDB = New GestionDB

    Private Sub principale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        remplirTableau()
        opcs = New OPC
        AddHandler opcs.GroupeAJour, AddressOf SurGroupeAJour
        AddHandler opcs.GroupeChange, AddressOf SurGroupeAJour
        AddHandler opcs.OPCComm, AddressOf SurConnexion

        _gestionDB.OpenDataBase()
    End Sub


    Private Sub principale_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        _gestionDB.CloseDatabase()
    End Sub

    Private Sub majBarreEtat(message As String)
        ToolStripStatusLabel_info.Text = $"{message}"
    End Sub

    Private Sub SurGroupeAJour(sender As Object, e As EventArgs)
        Dim monOPC As OPC
        Dim boucle As Integer

        PictureBox1.Visible = True
        Timer1.Enabled = True

        monOPC = CType(sender, OPC)

        If monOPC.DonneesOPC.Count = listeDesLabels.Count Then
            For boucle = 0 To listeDesLabels.Count - 1
                If monOPC.DonneesOPC(boucle).Count <> 0 Then
                    listeDesLabels(boucle).Text = monOPC.DonneesOPC(boucle)(0)
                End If
            Next

            If CheckBox_capture.Checked Then
                _gestionDB.ajouterEvenementDB(listeDesCles, listeDesLabels)
            End If
        End If

    End Sub

    Private Sub SurConnexion(sender As Object, e As EventArgs)
        majBarreEtat("Connexion réalisée")
    End Sub


    Private Sub AjouterLesClesDeSupervision()
        Dim boucle As Integer

        For boucle = 0 To listeDesCles.Count - 1
            opcs.Souscrire(listeDesCles(boucle), boucle)
            majBarreEtat($"Supervision de la clé {listeDesCles(boucle)} ajoutée")
        Next

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
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Visible = False
        Timer1.Enabled = False
    End Sub


End Class
