Imports System.Globalization
Imports System.IO
Imports System.Reflection
Imports System.Text
Imports AtlantaSistemas.Model
Imports DoctorVirtus.Model

Public Class FrmAtualizacaoDatabase

    Public Async Sub FrmAtualizacaoDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            ImgCarregando.Image = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("Atlanta_Sistemas.carregando.gif"))

            Await Task.Run(Sub()
                               Call Script()
                           End Sub)

            Close()

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try

    End Sub

    Public Sub Script()

        Dim CultureInfo As New CultureInfo("pt-BR")

        Dim Reader As New StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("Atlanta_Sistemas.Atualizacao.sql"), Encoding.GetEncoding(CultureInfo.TextInfo.ANSICodePage))
        Dim Versao As Integer = Convert.ToInt32(My.Application.Info.Version.Major.ToString & My.Application.Info.Version.MinorRevision.ToString.PadLeft(2, Convert.ToChar("0")))
        Dim Querys As String() = Replace(Replace(Reader.ReadToEnd(), "'{Versao}'", Versao), "GO --NEXT", "§").Split(New Char() {"§"c})

        Dim SqlAtualizar As String = ""

        Using Contexto As New _ContextoBD()
            For Each Query As String In Querys
                Call Contexto.Database.ExecuteSqlCommand(Query)
            Next
        End Using

    End Sub

    Public Sub Registros()

        Dim CultureInfo As New CultureInfo("pt-BR")

        Dim Reader As New StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("Atlanta_Sistemas.Registros.sql"), Encoding.GetEncoding(CultureInfo.TextInfo.ANSICodePage))
        Dim Querys As String() = Replace(Reader.ReadToEnd(), "GO --NEXT", "§").Split(New Char() {"§"c})

        Using Contexto As New _ContextoBD()

            'Call Contexto.Database.ExecuteSqlCommand("ALTER DATABASE [Database] COLLATE SQL_Latin1_General_CP1_CI_AI")

            For Each Query As String In Querys
                Call Contexto.Database.ExecuteSqlCommand(Query)
            Next
        End Using

    End Sub

End Class