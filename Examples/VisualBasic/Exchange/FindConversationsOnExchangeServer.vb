﻿Imports System.Net
Imports Aspose.Email.Exchange
Imports Aspose.Email.Mail

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Email for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Email.Examples.VisualBasic.Email.Exchange
	Class FindConversationsOnExchangeServer
		Public Shared Sub Run()
			Const  mailboxUri As String = "https://exchange/ews/exchange.asmx"
			Const  domain As String = ""
			Const  username As String = "username@ASE305.onmicrosoft.com"
			Const  password As String = "password"
			Dim credentials As New NetworkCredential(username, password, domain)
			Dim client As IEWSClient = EWSClient.GetEWSClient(mailboxUri, credentials)
			Console.WriteLine("Connected to Exchange 2010")
			' ExStart:FindConversationsOnExchangeServer
			' Find Conversation Items in the Inbox folder
			Dim conversations As ExchangeConversation() = client.FindConversations(client.MailboxInfo.InboxUri)
			' Show all conversations
			For Each conversation As ExchangeConversation In conversations
				' Display conversation properties like Id and Topic
				Console.WriteLine("Topic: " + conversation.ConversationTopic)
				Console.WriteLine("Flag Status: " + conversation.FlagStatus.ToString())
				Console.WriteLine()
			Next
			' ExEnd:FindConversationsOnExchangeServer
		End Sub
	End Class
End Namespace