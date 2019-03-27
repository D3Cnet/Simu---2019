Module Constantes

    '  Public listeDesCles As Dictionary(Of String, Label) = New Dictionary(Of String, Label)

    Public listeDesCles As New List(Of String)
    Public listeDesLabels As New List(Of Label)

    Sub remplirTableau()

        listeDesCles.Add("_System._DateTime")
        listeDesCles.Add("Jol.A1.Blancs")
        listeDesCles.Add("Jol.A2.Blancs")
        listeDesCles.Add("Jol.A3.Blancs")
        listeDesCles.Add("Jol.A4.Blancs")
        listeDesCles.Add("Jol.A5.Blancs")
        listeDesCles.Add("Jol.A6.Blancs")
        listeDesCles.Add("Jol.A1.Noirs")
        listeDesCles.Add("Jol.A2.Noirs")
        listeDesCles.Add("Jol.A3.Noirs")
        listeDesCles.Add("Jol.A4.Noirs")
        listeDesCles.Add("Jol.A5.Noirs")
        listeDesCles.Add("Jol.A6.Noirs")

        listeDesLabels.Add(principale.dateHeure)
        listeDesLabels.Add(principale.A2Blanc)
        listeDesLabels.Add(principale.A3Blanc)
        listeDesLabels.Add(principale.A1Blanc)
        listeDesLabels.Add(principale.A5Blanc)
        listeDesLabels.Add(principale.A5Blanc)
        listeDesLabels.Add(principale.A6Blanc)
        listeDesLabels.Add(principale.A1Noir)
        listeDesLabels.Add(principale.A2Noir)
        listeDesLabels.Add(principale.A3Noir)
        listeDesLabels.Add(principale.A4Noir)
        listeDesLabels.Add(principale.A5Noir)
        listeDesLabels.Add(principale.A6Noir)
    End Sub

End Module
