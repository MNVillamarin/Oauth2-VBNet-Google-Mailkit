Imports System.Threading
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Auth.OAuth2.Flows
Imports Google.Apis.Util
Imports Google.Apis.Util.Store
Imports MailKit
Imports MailKit.Net.Imap
Imports MailKit.Net.Smtp
Imports MailKit.Security
Imports MimeKit

Public Class Mail
    
    Dim GMailAccount = "XXXXXXXXX@gmail.com"
    Dim ClientId = "XXXXXXXXXXXXXX.apps.googleusercontent.com"
    Dim ClientSecret = "XXXXXXXXXXXXXXXXX"


    
    Dim secrets As New ClientSecrets() With {
        .ClientId = ClientId,
        .ClientSecret = ClientSecret}


    Dim codeFlow As New GoogleAuthorizationCodeFlow(New GoogleAuthorizationCodeFlow.Initializer() With {
    .DataStore = New FileDataStore("CredentialCacheFolder", False),
    .Scopes = New String() {"https://mail.google.com/"},
    .ClientSecrets = secrets
    })


    Dim codeReceiver As New LocalServerCodeReceiver()
    Dim authCode As New AuthorizationCodeInstalledApp(codeFlow, codeReceiver)



    Private Function GetMessageTest() As MimeMessage

        Dim message As New MimeMessage()
        message.From.Add(New MailboxAddress("XXXX Test", "XXXXXXXX@gmail.com"))
        message.To.Add(New MailboxAddress("XXXXX Test", "XXXXXXXXXXX@gmail.com"))
        message.Subject = "Test"
        message.Body = New TextPart("plain") With {
            .Text = "This is a test"
        }

        Return message

    End Function

    Public Async Sub SendMailTest()

        Dim credential = Await authCode.AuthorizeAsync(GMailAccount, CancellationToken.None)

        If (credential.Token.IsExpired(SystemClock.Default)) Then
            Await credential.RefreshTokenAsync(CancellationToken.None)
        End If

        Dim oauth2 As New SaslMechanismOAuth2(credential.UserId, credential.Token.AccessToken)


        With New SmtpClient()
            Await .ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls)
            Await .AuthenticateAsync(oauth2, CancellationToken.None)
            Await .SendAsync(GetMessageTest())
            Await .DisconnectAsync(True)
        End With

        Console.WriteLine ("Correo enviado")

    End Sub

    Public Async Sub ImapTest()
        
        Dim credential = Await authCode.AuthorizeAsync(GMailAccount, CancellationToken.None)

        If (credential.Token.IsExpired(SystemClock.Default)) Then
            Await credential.RefreshTokenAsync(CancellationToken.None)
        End If

        Dim oauth2 As New SaslMechanismOAuth2(credential.UserId, credential.Token.AccessToken)

        With New ImapClient()
            Await .ConnectAsync("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect)
            Await .AuthenticateAsync(oauth2, CancellationToken.None)

            Dim inbox = .Inbox
            Await inbox.OpenAsync(FolderAccess.ReadWrite, CancellationToken.None)
            Dim message = inbox.GetMessage (inbox.Count - 1)
            Console.WriteLine ("Ultimo Mensaje de su bandeja: " + message.Subject)

            Await .DisconnectAsync(True)

        End With
        
    End Sub
            
     

End Class
