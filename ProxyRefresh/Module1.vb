Module Module1

    Sub Main()
        'Programme d'actualisation de la connexion avec le proxy d'Alstom
        'afin d'éviter les coupures fréquentes sur le réseau lors de
        'l'utilisation d'un autre navigateur internet

        Console.SetWindowSize(32, 8)
        Console.SetBufferSize(32, 8)
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.Title = "ALSTOM - Proxy Refresh"
        Console.Clear()
        Console.WriteLine("Initialisation interface web...")
        Dim clt As HttpClient = New HttpClient()
        Thread.Sleep(1000)
        Console.WriteLine("Paramétrage de la connexion...")
        clt.Timeout = TimeSpan.FromSeconds(3)
        clt.BaseAddress = New Uri("http://www.google.com/")
        Thread.Sleep(500)
        Console.WriteLine("...")
        Thread.Sleep(750)
        Console.WriteLine("...")
        Thread.Sleep(200)
        Console.WriteLine("...")
        Thread.Sleep(1000)
        Console.WriteLine("Activation des proxocoupleur...")
        Console.WriteLine("NE PAS FERMER LA FENETRE !")

        While True
            Dim req = clt.GetAsync("http://www.google.com/")
            Thread.Sleep(5000)
            req.Dispose()
        End While
    End Sub
End Module
