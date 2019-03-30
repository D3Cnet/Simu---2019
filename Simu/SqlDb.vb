Imports System.Data.SQLite
Imports System.IO

Public Class SqlDb
    Private Shared _instance As SqlDb = Nothing
    Private Shared _db As String = ""
    Private _connect As String = ""

    Private Sub New()
        Init()
        If Not File.Exists(_db) Then
            ' Création du fichier
            If Not DbCreation() Then
                ' TODO : générer notre propre exception et la gérer.
                Throw New FileNotFoundException($"Fichier de données SQLite {_db} non trouvé")
            End If
        End If
    End Sub

    Private Sub Init()
        ' Initialisations
        _db = CHEMINDB
        _connect = $"DataSource={_db};Version=3;New=False;Compress=True;"
    End Sub

    Public Shared Function Instance() As SqlDb
        If CHEMINDB <> _db Or IsNothing(_instance) Then
            _instance = New SqlDb
        End If
        Return _instance
    End Function

    Private Function DbCreation() As Boolean
        Dim connexion As SQLiteConnection = New SQLiteConnection
        Try
            SQLiteConnection.CreateFile(_db)
        Catch e As SQLiteException
            ' TODO : gérer le fait que la base de données ne pourra pas être utilisée.
            MsgBox(e.ToString)
            Return False
        End Try

        Using Query As New SQLiteCommand()
            connexion.ConnectionString = _connect
            connexion.Open()
            With Query
                .Connection = connexion
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
            connexion.Close()
        End Using

        Return True
    End Function

    Public Function LitSQL(requete As String, table As String) As DataSet
        Dim donnees As DataSet = New DataSet
        Dim connexion As New SQLiteConnection(_connect)
        Dim Commande As New SQLiteCommand(requete, connexion)
        Dim Adaptateur As New SQLiteDataAdapter(Commande)
        Adaptateur.Fill(donnees, table)
        Return donnees
    End Function

    Public Sub ExecSQL(insertions As List(Of String))
        Using cn As New SQLiteConnection(_connect), cmd As New SQLiteCommand()
            cn.Open()
            For Each insertion As String In insertions
                cmd.CommandText = insertion
                cmd.Connection = cn
                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox($"Erreur d'insertion pour \{insertion}\ : {ex.Message}")
                End Try
            Next
            cn.Close()
        End Using
    End Sub

    Public Sub ExecSQL(insertion As String)
        Dim liste As List(Of String) = New List(Of String)
        liste.Add(insertion)
        ExecSQL(liste)
    End Sub

End Class
