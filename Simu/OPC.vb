Imports OPCAutomation

Public Class OPC
    Private _adresseServeur As String = "127.0.0.1"
    Private _listeOPC As New List(Of StrOPCServer)
    Private _listeNomsOPC As List(Of String) = New List(Of String)
    Private _handles As List(Of Integer) = New List(Of Integer)
    Private _noeudCourant As Integer = Nothing
    Private _arbreDonnees As SortedList
    ' TODO : à revoir.
    Public MyOPCGroup As OPCGroup
    Private _frequence As Integer = 1000
    Private _donneesOPC As List(Of List(Of String)) = New List(Of List(Of String))

    Public Event GroupeAJour As EventHandler
    Public Event GroupeChange As EventHandler
    Public Event OPCComm As EventHandler

    Structure StrOPCServer
        Dim nom As String
        Dim opc As OPCServer
        Dim groupe
        Dim items As OPCItems
        Dim ServerHandles As Array
        Dim erreurs As Array
        Dim valeurs As Array
        Dim MonCount As Integer
    End Structure

    Private Sub ListeServeurs()
        Dim i As Integer = 0
        Dim serveursOPC As New OPCServer

        For Each nomServeur In serveursOPC.GetOPCServers(_adresseServeur)
            _listeNomsOPC.Add(nomServeur)
            Dim serveur = New StrOPCServer
            serveur.nom = nomServeur
            serveur.opc = New OPCServer
            Dim Dims() As Integer = New Integer() {1000}
            Dim Bounds() As Integer = New Integer() {1}
            serveur.ServerHandles = Array.CreateInstance(GetType(Integer), Dims, Bounds)
            serveur.erreurs = Array.CreateInstance(GetType(Integer), Dims, Bounds)
            serveur.valeurs = Array.CreateInstance(GetType(Integer), Dims, Bounds)
            _listeOPC.Add(serveur)
        Next
    End Sub


    'FIXME: Fusion des Collectes. Prévoir un *vrai* Arbre !
    Private Sub CollecteFeuilles3(branche() As String, browser As OPCBrowser)
        browser.MoveTo(branche)
        browser.ShowLeafs()
        If browser.Count > 0 Then
            _arbreDonnees(branche(1))(branche(2))(branche(3)) = New SortedList
            For j = 1 To browser.Count
                _arbreDonnees(branche(1))(branche(2))(branche(3)).Add(browser.Item(j), Nothing)
            Next
        End If
    End Sub

    Private Sub CollecteFeuilles2(branche() As String, browser As OPCBrowser)
        'MsgBox($"{branche(1)} - {branche(2)}")
        browser.MoveTo(branche)
        browser.ShowLeafs()
        If browser.Count > 0 Then
            _arbreDonnees(branche(1))(branche(2)) = New SortedList
            For j = 1 To browser.Count
                _arbreDonnees(branche(1))(branche(2)).Add(browser.Item(j), Nothing)
            Next
        End If
    End Sub

    Private Sub CollecteBranches2(branche() As String, browser As OPCBrowser)
        browser.MoveTo(branche)
        browser.ShowBranches()
        If browser.Count > 0 Then
            _arbreDonnees(branche(1))(branche(2)) = New SortedList
            For j = 1 To browser.Count
                browser.MoveTo(branche)
                browser.ShowBranches()
                Dim brancheLocale(3) As String
                brancheLocale(1) = branche(1)
                brancheLocale(2) = branche(2)
                brancheLocale(3) = browser.Item(j)
                _arbreDonnees(branche(1))(branche(2)).Add(brancheLocale(3), New SortedList)
                CollecteFeuilles3(brancheLocale, browser)
            Next
        End If
    End Sub

    Private Sub CollecteBranches(branche() As String, browser As OPCBrowser)
        browser.MoveTo(branche)
        browser.ShowBranches()
        If browser.Count > 0 Then
            _arbreDonnees(branche(1)) = New SortedList
            For j = 1 To browser.Count
                browser.MoveTo(branche)
                browser.ShowBranches()
                Dim brancheLocale(3) As String
                brancheLocale(1) = branche(1)
                brancheLocale(2) = browser.Item(j)
                _arbreDonnees(branche(1)).Add(brancheLocale(2), New SortedList)
                CollecteBranches2(brancheLocale, browser)
                CollecteFeuilles2(brancheLocale, browser)
            Next
        End If
    End Sub

    Private Sub CollecteFeuilles(branche() As String, browser As OPCBrowser)
        browser.MoveTo(branche)
        browser.ShowLeafs()
        If browser.Count > 0 Then
            _arbreDonnees(branche(1)) = New SortedList
            For j = 1 To browser.Count
                _arbreDonnees(branche(1)).Add(browser.Item(j), Nothing)
            Next
        End If
    End Sub

    Private Sub CollecteData()
        Dim hash As SortedList = New SortedList
        Dim browser As OPCBrowser = _listeOPC.Item(_noeudCourant).opc.CreateBrowser

        ' Parcours des branches.
        browser.MoveToRoot()
        browser.ShowBranches()

        If browser.Count = 0 Then _arbreDonnees = Nothing

        ' Niveau 1.
        For i = 1 To browser.Count
            Dim noeud = browser.Item(i)
            hash(noeud) = Nothing
        Next
        _arbreDonnees = hash.Clone

        ' Niveau 2.
        ' WARN : On ne peut pas parcourir les clés si on modifie la liste en même temps.
        For Each entree In hash.Keys
            Dim branche(3) As String
            branche(1) = entree
            CollecteFeuilles(branche, browser)
            CollecteBranches(branche, browser)
        Next
    End Sub

    Public Property Adresse As String
        Get
            Return _adresseServeur
        End Get
        Set(value As String)
            _adresseServeur = value
        End Set
    End Property

    Public Function Connect(i As Integer) As Boolean
        Dim e As EventArgs = New EventArgs
        Dim serveur = _listeOPC.Item(i)
        serveur.opc.Connect(serveur.nom, _adresseServeur)
        If serveur.opc.ServerState = 1 Then
            RaiseEvent OPCComm(Me, e)
            _noeudCourant = i
            MyOPCGroup = serveur.opc.OPCGroups.Add("MyOPC_" & i)
            MyOPCGroup.IsActive = False
            MyOPCGroup.IsSubscribed = True
            MyOPCGroup.UpdateRate = _frequence

            AddHandler MyOPCGroup.DataChange, AddressOf MyOPCGroup_DataChange
            AddHandler MyOPCGroup.AsyncReadComplete, AddressOf MyOPCGroup_AsyncReadComplete
            'AddHandler MyOPCGroup.AsyncWriteComplete, AddressOf MyOPCGroup_AsyncWriteComplete

            CollecteData()
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Donnees() As SortedList
        Return _arbreDonnees
    End Function

    Public Function Serveurs() As List(Of String)
        Return _listeNomsOPC
    End Function

    Public Sub Souscrire(donnee As String, ligne As Integer)
        If _listeOPC(_noeudCourant).opc.ServerState = 1 Then
            MyOPCGroup.IsActive = True
        End If
        Dim tempList = New List(Of String)
        _donneesOPC.Add(tempList)
        ' WARN: dès qu'on ajoute l'item, il peut apparaître dans un événement de résultats ! Son emplacement mémoire doit être prêt avant.
        Dim monItem As OPCItem
        monItem = MyOPCGroup.OPCItems.AddItem(donnee, ligne)
        _handles.Add(monItem.ServerHandle)
        '_listeOPC(_noeudCourant).ServerHandles(ligne) = monItem.ServerHandle
    End Sub

    ' Vu sur : http://hadiscada.blogspot.fr/2013/07/my-opc-client.html#.WOSjMG_yi9J
    ' My OPC CLient v4
    Public Sub Ecrire(donnee As String, ligne As Integer) '_listeOPC(_noeudCourant).Errors
        Dim ServerHandlesLocal(ligne) As Integer
        'Dim Errors(ligne) As Integer
        ServerHandlesLocal(1) = _handles(ligne)
        Dim Data(ligne)
        Data(1) = donnee
        MyOPCGroup.AsyncWrite(1, ServerHandlesLocal, Data, _listeOPC(_noeudCourant).erreurs, Second(Now), Second(Now))
    End Sub

    Public Sub New()
        ListeServeurs()
    End Sub

    'Private Sub MyOPCGroup_AsyncWriteComplete(ByVal TransactionID As Integer, ByVal NumItems As Integer, ByRef ClientHandles As Array, ByRef Errors As Array)

    'End Sub

    Public Sub MyOPCGroup_AsyncReadComplete(TransactionID As Integer, NumItems As Integer, ByRef ClientHandles As Array, ByRef ItemValues As Array, ByRef Qualities As Array, ByRef TimeStamps As Array, ByRef Errors As Array)
        For i = 1 To NumItems
            Dim iHandles As Integer = ClientHandles(i)
            'dataOPC.Item(1, iHandles - 1).Value = ItemValues(i)
        Next
        Dim e As EventArgs = New EventArgs
        RaiseEvent GroupeAJour(Me, e)
    End Sub
    Private Sub MyOPCGroup_DataChange(TransactionID As Integer, NumItems As Integer, ByRef ClientHandles As Array, ByRef ItemValues As Array, ByRef Qualities As Array, ByRef TimeStamps As Array)
        For i = 1 To NumItems
            Dim tempList = New List(Of String)
            Dim iHandles As Integer = ClientHandles(i)
            'dataOPC.Item(1, iHandles - 1).Value = ItemValues(i)
            Dim typeItem As String = ItemValues(i).GetType.ToString
            Dim finChaine As String = typeItem.Substring(typeItem.Length - 2, 2)
            If finChaine <> "[]" Then
                tempList.Add(ItemValues(i))
            Else
                'tempList.Add(Join(ItemValues(i), ", "))
                tempList.Add(ItemValues(i)(0) + "...")
            End If
            'tempList.Add(finChaine)
            tempList.Add(Traduit(Qualities(i)))
            tempList.Add(TimeStamps(i))
            tempList.Add(typeItem)
            _donneesOPC(iHandles) = tempList
        Next
        Dim e As EventArgs = New EventArgs
        RaiseEvent GroupeChange(Me, e)
    End Sub
    Private Function Traduit(value As Integer) As String
        ' http://opcsupport.com/link/portal/4164/4590/Article/5/What-are-the-OPC-Quality-Codes
        ' http://support.softwaretoolbox.com/app/answers/detail/a_id/414/~/what-do-the-quality-codes-mean%3F-like-192
        Select Case value
            Case 0 To 63
                Return $"Bad {value}"
            Case 64 To 191
                Return $"Uncertain {value}"
            Case 192 To 255
                Return $"Good {value}"
            Case Else
                Return $"Cas inconnu {value}"
        End Select
    End Function

    Public Function Actuel() As String
        Return _listeOPC(_noeudCourant).nom
    End Function

    Public Function DonneesOPC() As List(Of List(Of String))
        Return _donneesOPC
    End Function
End Class
