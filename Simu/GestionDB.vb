Imports System.Data.SQLite
Imports System.IO

Public Class GestionDB
    ' Gestion de la base de données
    ' Code trouvé sur le site https://codes-sources.commentcamarche.net/source/54387-tutorial-utilisation-sqlite-avec-visual-basic-net-2010-express

    'Chemin vers le fichier sqlite contenant la base de données. La constante est définie dans le module constantes.vb
    Private _Database As String = CHEMINDB
    Dim CON As New SQLiteConnection
    '

    Public Sub New()
        If Not File.Exists(_Database) Then
            ' Création du fichier
            If Not DbCreation() Then
                ' TODO : générer notre propre exception et la gérer.
                Throw New FileNotFoundException($"Fichier de données SQLite {_Database} non trouvé")
            End If
        End If
    End Sub


    Private Function DbCreation() As Boolean
        Try
            SQLiteConnection.CreateFile(_Database)
        Catch e As SQLiteException
            ' TODO : gérer le fait que la base de données ne pourra pas être utilisée.
            MsgBox(e.ToString)
            Return False
        End Try

        Using Query As New SQLiteCommand()
            CON.ConnectionString = $"DataSource={_Database};Version=3;New=False;Compress=True;"
            CON.Open()
            With Query
                .Connection = CON
                .CommandText = "
CREATE TABLE cle (idCle INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, nomCle TEXT NOT NULL UNIQUE);
CREATE TABLE cleevenement (idCle INTEGER, idEvent INTEGER, valeur TEXT, PRIMARY KEY (idCle, idEvent));
CREATE TABLE evenement (idEvent INTEGER NOT NULL PRIMARY KEY, dateHeure DATETIME NOT NULL);
CREATE UNIQUE INDEX cleevent ON cleevenement (idCle, idEvent);
CREATE INDEX iCle ON cle (idCle);
CREATE INDEX iCleEvent ON cleevenement (idCle, idEvent);
CREATE UNIQUE INDEX iNomCle ON cle (nomCle);
INSERT INTO cle (idCle, nomCle) VALUES (1, '_System._DateTime');
INSERT INTO cle (idCle, nomCle) VALUES (2, 'Jol.A1.Blancs');
INSERT INTO cle (idCle, nomCle) VALUES (3, 'Jol.A2.Blancs');
INSERT INTO cle (idCle, nomCle) VALUES (4, 'Jol.A3.Blancs');
INSERT INTO cle (idCle, nomCle) VALUES (5, 'Jol.A4.Blancs');
INSERT INTO cle (idCle, nomCle) VALUES (6, 'Jol.A5.Blancs');
INSERT INTO cle (idCle, nomCle) VALUES (7, 'Jol.A6.Blancs');
INSERT INTO cle (idCle, nomCle) VALUES (8, 'Jol.A1.Noirs');
INSERT INTO cle (idCle, nomCle) VALUES (9, 'Jol.A2.Noirs');
INSERT INTO cle (idCle, nomCle) VALUES (10, 'Jol.A3.Noirs');
INSERT INTO cle (idCle, nomCle) VALUES (11, 'Jol.A4.Noirs');
INSERT INTO cle (idCle, nomCle) VALUES (12, 'Jol.A5.Noirs');
INSERT INTO cle (idCle, nomCle) VALUES (13, 'Jol.A6.Noirs');
"
            End With
            Query.ExecuteNonQuery()
            CON.Close()
        End Using

        Return True
    End Function



    Public Sub OpenDataBase()
        Try
            CON.ConnectionString = $"DataSource={_Database};Version=3;New=False;Compress=True;"
            CON.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '
    Public Sub CloseDatabase()
        CON.Close()
    End Sub


    Public Sub ajouterEvenementDB(listeVar As List(Of String), listeLabel As List(Of Label))
        Dim strSQL As String
        Dim cmd As SQLiteCommand
        Dim idEvenement As Integer
        Dim idCle As Integer

        idEvenement = nouvelIdentifiantEventUniqueDB()

        Try
            strSQL = "INSERT INTO evenement VALUES (@idEvent,@dateHeure)"
            cmd = New SQLiteCommand(strSQL, CON)
            cmd.Parameters.AddWithValue("@idEvent", idEvenement)
            If listeVar.IndexOf("_System._DateTime") = -1 Then
                cmd.Parameters.AddWithValue("@dateHeure", Now)
            Else
                cmd.Parameters.AddWithValue("@dateHeure", listeLabel(listeVar.IndexOf("_System._DateTime")).Text)
            End If
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            For boucle = 0 To listeVar.Count - 1
                idCle = rechercherIdCle(listeVar(boucle))

                strSQL = "INSERT INTO cleEvenement VALUES (@idCle,@idEvent,@valeur)"
                cmd = New SQLiteCommand(strSQL, CON)
                cmd.Parameters.AddWithValue("@idCle", idCle)
                cmd.Parameters.AddWithValue("@idEvent", idEvenement)
                cmd.Parameters.AddWithValue("@valeur", listeLabel(boucle).Text)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Public Sub listeEventDB(ByRef maCollection As ComboBox.ObjectCollection)
        Dim cmd = New SQLiteCommand("SELECT dateHeure FROM evenement", CON)
        Dim DR As SQLiteDataReader = cmd.ExecuteReader
        maCollection.Clear()
        While (DR.Read())
            maCollection.Add(DR("dateHeure"))
        End While
        DR.Close()
    End Sub


    Public Function listeClesParEvent(nomEvent As String) As DataSet
        Dim donnees As DataSet = New DataSet
        Dim idEvent As Integer

        idEvent = rechercherIdEvent(nomEvent)

        Dim cmd = New SQLiteCommand("SELECT nomCle, valeur FROM cle, cleEvenement WHERE cleevenement.idCle=cle.idCle AND idEvent=" & idEvent, CON)
        Dim Adaptateur As New SQLiteDataAdapter(cmd)
        Adaptateur.Fill(donnees, "ListeValeurCle")
        Return donnees
    End Function

    'Public Function LitSQL(requete As String, table As String) As DataSet
    '    Dim donnees As DataSet = New DataSet
    '    Dim connexion As New SQLiteConnection(CON)
    '    Dim Commande As New SQLiteCommand(requete, connexion)
    '    Dim Adaptateur As New SQLiteDataAdapter(Commande)
    '    Adaptateur.Fill(donnees, table)
    '    Return donnees
    'End Function


    Public Function nouvelIdentifiantEventUniqueDB() As Integer
        Dim NewID As Integer = 1
        Dim cmd = New SQLiteCommand("SELECT MAX(idEvent) FROM evenement", CON)
        Try
            Dim DR As SQLiteDataReader = cmd.ExecuteReader
            While (DR.Read())
                NewID = DR(0)
            End While
            DR.Close()
            Return NewID + 1
        Catch ex As Exception
            Return NewID
        End Try
    End Function

    Private Function rechercherIdCle(laCle As String) As Integer
        Dim NewID As Integer = -1
        Dim cmd = New SQLiteCommand("SELECT idCle FROM cle WHERE nomCle=""" & laCle & """", CON)
        Try
            Dim DR As SQLiteDataReader = cmd.ExecuteReader
            While (DR.Read())
                NewID = DR(0)
            End While
            DR.Close()
            Return NewID
        Catch ex As Exception
            Return NewID
        End Try
    End Function

    Private Function rechercherIdEvent(laValeur As String) As Integer
        Dim NewID As Integer = -1
        Dim cmd = New SQLiteCommand("SELECT idEvent FROM evenement WHERE dateHeure=""" & laValeur & """", CON)
        Try
            Dim DR As SQLiteDataReader = cmd.ExecuteReader
            While (DR.Read())
                NewID = DR(0)
            End While
            DR.Close()
            Return NewID
        Catch ex As Exception
            Return NewID
        End Try
    End Function


End Class
