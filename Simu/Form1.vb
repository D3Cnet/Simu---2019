Option Explicit On
Option Strict On

Public Class principale
    Private opcs As OPC
    Private adresseOPC As String = "127.0.0.1"

    Private Sub principale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        remplirTableau()
        opcs = New OPC
        AddHandler opcs.GroupeAJour, AddressOf SurGroupeAJour
        AddHandler opcs.GroupeChange, AddressOf SurGroupeAJour
        AddHandler opcs.OPCComm, AddressOf SurConnexion
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
            majBarreEtat($"Supervision de la clé {listeDesCles(boucle)} ajoutée")
        Next

        'opcs.Souscrire("Jol.A1.Blancs", 0)
        'opcs.Souscrire("Jol.A2.Blancs", 0)
        'opcs.Souscrire("Jol.A3.Blancs", 0)
        'opcs.Souscrire("Jol.A4.Blancs", 0)
        'opcs.Souscrire("Jol.A5.Blancs", 0)
        'opcs.Souscrire("Jol.A1.Noirs", 0)
        'opcs.Souscrire("Jol.A2.Noirs", 0)
        'opcs.Souscrire("Jol.A3.Noirs", 0)
        'opcs.Souscrire("Jol.A4.Noirs", 0)
        'opcs.Souscrire("Jol.A5.Noirs", 0)

    End Sub

    Private Sub Button_connect_Click(sender As Object, e As EventArgs) Handles Button_connect.Click
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

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
