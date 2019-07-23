Imports System.Configuration
Imports System.IO
Imports System.Net
Imports DoctorVirtus.Model

Module App

    Public UsuarioLogado As New Usuario


    Public Database As New DB.Database()
    Public Parse As New AtlantaSistemas.Utils2.Class.Parse

    Public ConnectionString As String = ""
    Public NewEmpresaLogada As New Prestador


    Sub Main()

        Call CarregarDlls()

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        Application.Run(New ViewLogin())

    End Sub

    Private Sub CarregarDlls()

        'Newtonsoft
        EmbeddedAssembly.Load("Atlanta_Sistemas.Newtonsoft.Json.dll", "Newtonsoft.Json.dll")

        'RicherTextBox
        EmbeddedAssembly.Load("Atlanta_Sistemas.RicherTextBox.dll", "RicherTextBox.dll")

        'Syncfusion
        EmbeddedAssembly.Load("Atlanta_Sistemas.Syncfusion.Compression.Base.dll", "Syncfusion.Compression.Base.dll")
        EmbeddedAssembly.Load("Atlanta_Sistemas.Syncfusion.Core.WinForms.dll", "Syncfusion.Core.WinForms.dll")
        EmbeddedAssembly.Load("Atlanta_Sistemas.Syncfusion.DataSource.WinForms.dll", "Syncfusion.DataSource.WinForms.dll")
        EmbeddedAssembly.Load("Atlanta_Sistemas.Syncfusion.DocIO.Base.dll", "Syncfusion.DocIO.Base.dll")
        EmbeddedAssembly.Load("Atlanta_Sistemas.Syncfusion.Grid.Grouping.Base.dll", "Syncfusion.Grid.Grouping.Base.dll")
        EmbeddedAssembly.Load("Atlanta_Sistemas.Syncfusion.Grid.Grouping.Windows.dll", "Syncfusion.Grid.Grouping.Windows.dll")
        EmbeddedAssembly.Load("Atlanta_Sistemas.Syncfusion.Grid.Windows.dll", "Syncfusion.Grid.Windows.dll")
        EmbeddedAssembly.Load("Atlanta_Sistemas.Syncfusion.GridCommon.WinForms.dll", "Syncfusion.GridCommon.WinForms.dll")
        EmbeddedAssembly.Load("Atlanta_Sistemas.Syncfusion.GridHelperClasses.Windows.dll", "Syncfusion.GridHelperClasses.Windows.dll")
        EmbeddedAssembly.Load("Atlanta_Sistemas.Syncfusion.Grouping.Base.dll", "Syncfusion.Grouping.Base.dll")
        EmbeddedAssembly.Load("Atlanta_Sistemas.Syncfusion.Licensing.dll", "Syncfusion.Licensing.dll")
        EmbeddedAssembly.Load("Atlanta_Sistemas.Syncfusion.Pdf.Base.dll", "Syncfusion.Pdf.Base.dll")
        EmbeddedAssembly.Load("Atlanta_Sistemas.Syncfusion.PdfViewer.Windows.dll", "Syncfusion.PdfViewer.Windows.dll")
        EmbeddedAssembly.Load("Atlanta_Sistemas.Syncfusion.SfInput.WinForms.dll", "Syncfusion.SfInput.WinForms.dll")
        EmbeddedAssembly.Load("Atlanta_Sistemas.Syncfusion.SfListView.WinForms.dll", "Syncfusion.SfListView.WinForms.dll")
        EmbeddedAssembly.Load("Atlanta_Sistemas.Syncfusion.Shared.Base.dll", "Syncfusion.Shared.Base.dll")
        EmbeddedAssembly.Load("Atlanta_Sistemas.Syncfusion.Shared.Windows.dll", "Syncfusion.Shared.Windows.dll")
        EmbeddedAssembly.Load("Atlanta_Sistemas.Syncfusion.Tools.Base.dll", "Syncfusion.Tools.Base.dll")
        EmbeddedAssembly.Load("Atlanta_Sistemas.Syncfusion.Tools.Windows.dll", "Syncfusion.Tools.Windows.dll")

        AddHandler AppDomain.CurrentDomain.AssemblyResolve, New ResolveEventHandler(AddressOf CurrentDomain_AssemblyResolve)

    End Sub

    Private Function CurrentDomain_AssemblyResolve(ByVal sender As Object, ByVal args As ResolveEventArgs) As System.Reflection.Assembly
        Return EmbeddedAssembly.[Get](args.Name)
    End Function

    Public Function VerificaVersao() As Boolean

        Try

            Dim row As DataRow = Database.Execute("SELECT TOP 1 Versao, URL_Versao FROM Empresa").Tables(0).Rows(0)

            If Parse.ToInt(row("Versao")) < Convert.ToInt32(My.Application.Info.Version.Major.ToString & My.Application.Info.Version.MinorRevision.ToString.PadLeft(2, Convert.ToChar("0"))) Then
                Dim FrmAtualizacaoDatabase As New FrmAtualizacaoDatabase
                FrmAtualizacaoDatabase.ShowDialog()
            End If

            If New StreamReader(WebRequest.Create(Parse.ToString(row("URL_Versao"))).GetResponse().GetResponseStream).ReadToEnd <> My.Application.Info.Version.Major.ToString & "." & My.Application.Info.Version.MinorRevision.ToString Then
                Dim Frm As New FrmAtualizacaoSistema
                Frm.ShowDialog()
            End If

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Sub VerificaVersaoAsync()

        Task.Run(Sub()
                     Call VerificaVersao()
                 End Sub)

    End Sub

    Public Sub SetConnectionString(ConnectionString As String)

        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        config.ConnectionStrings.ConnectionStrings.Remove("DoctorVirtus")
        config.ConnectionStrings.ConnectionStrings.Add(New ConnectionStringSettings("DoctorVirtus", ConnectionString, "System.Data.SqlClient"))
        config.Save(ConfigurationSaveMode.Modified, True)
        ConfigurationManager.RefreshSection("connectionStrings")

    End Sub
End Module