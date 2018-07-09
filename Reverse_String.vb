    'Skapad av Markus Nordin
    'Utmaning: Skapa ett program som vänder ordningen på bokstäver i en string
    Sub Main()
        Dim orgString As String = "Forrest Gump"
        Dim Buffer() As Char = orgString.ToCharArray
        Array.Reverse(Buffer)
        Console.WriteLine(orgString)
        Console.WriteLine(Buffer)
        Console.ReadKey()
    End Sub