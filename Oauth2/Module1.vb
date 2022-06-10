Module Module1

    Sub Main(args As String())
        
        Console.WriteLine("Send Mail Test!")

        
        
        Dim email As New Mail()
        
        email.SendMailTest()
        'email.ImapTest()
        
        Console.ReadKey()
        
        
    End Sub

End Module
