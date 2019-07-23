Imports System.ComponentModel
Imports System.Data.Entity
Imports System.IO
Imports System.Net
Imports DoctorVirtus.Desktop.HandleDynamic
Imports Newtonsoft.Json

Public Class ViewLocalAtendimento
    Dim Frm As New Forms

    Private ViewModelLocalAtendimento As New BindingSource With {.DataSource = GetType(ViewModelLocalAtendimento)}

    Dim Tabela As New HandleDynamic.HandleDynamic

    Private Sub ViewLocalAtendimento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Frm.AddHandler_Dynamic(Me)

            TxtCNPJ.DataBindings.Add(New Binding("Text", ViewModelLocalAtendimento, "LocalAtendimento.CNPJ", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtRazaoSocial.DataBindings.Add(New Binding("Text", ViewModelLocalAtendimento, "LocalAtendimento.RazaoSocial", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtNomeFantasia.DataBindings.Add(New Binding("Text", ViewModelLocalAtendimento, "LocalAtendimento.NomeFantasia", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtTelefone1.DataBindings.Add(New Binding("Text", ViewModelLocalAtendimento, "LocalAtendimento.Telefone1", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtTelefone2.DataBindings.Add(New Binding("Text", ViewModelLocalAtendimento, "LocalAtendimento.Telefone2", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtTelefone3.DataBindings.Add(New Binding("Text", ViewModelLocalAtendimento, "LocalAtendimento.Telefone3", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtEmail.DataBindings.Add(New Binding("Text", ViewModelLocalAtendimento, "LocalAtendimento.Email", True, DataSourceUpdateMode.OnPropertyChanged))
            'TxtInscEstadual.DataBindings.Add(New Binding("Text", ViewModelLocalAtendimento, "LocalAtendimento.InscEstadual", True, DataSourceUpdateMode.OnPropertyChanged))
            'TxtInscricaoMunicipal.DataBindings.Add(New Binding("Text", ViewModelLocalAtendimento, "LocalAtendimento.InscMunicipal", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtCEP.DataBindings.Add(New Binding("Text", ViewModelLocalAtendimento, "LocalAtendimento.CEP", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtLogradouro.DataBindings.Add(New Binding("Text", ViewModelLocalAtendimento, "LocalAtendimento.Logradouro", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtNumero.DataBindings.Add(New Binding("Text", ViewModelLocalAtendimento, "LocalAtendimento.Numero", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtComplemento.DataBindings.Add(New Binding("Text", ViewModelLocalAtendimento, "LocalAtendimento.Complemento", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtBairro.DataBindings.Add(New Binding("Text", ViewModelLocalAtendimento, "LocalAtendimento.Bairro", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtMunicipioNome.DataBindings.Add(New Binding("Text", ViewModelLocalAtendimento, "LocalAtendimento.Municipio.Nome", True, DataSourceUpdateMode.OnPropertyChanged))

            Call BtnLimpar_Click(Nothing, Nothing)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        Try

            ViewModelLocalAtendimento.DataSource = New ViewModelLocalAtendimento()

            TxtLocalAtendimentoID.Text = Nothing
            CboUF.SelectedItem = "GO"
            TxtMunicipioID.Text = Nothing

            CType(ViewModelLocalAtendimento.DataSource, ViewModelLocalAtendimento).LocalAtendimento.Municipio = New Municipio()

            TxtRazaoSocial.Select()

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Try

            Cursor.Current = Cursors.WaitCursor

            Dim ViewModelLocalAtendimento As ViewModelLocalAtendimento = Me.ViewModelLocalAtendimento.DataSource

            ViewModelLocalAtendimento.LocalAtendimento.LocalAtendimentoID = TxtLocalAtendimentoID.IntegerValue

            If IsNumeric(TxtMunicipioID.Text) Then
                ViewModelLocalAtendimento.LocalAtendimento.MunicipioID = TxtMunicipioID.Text
                ViewModelLocalAtendimento.LocalAtendimento.Municipio = Nothing
            Else
                ViewModelLocalAtendimento.LocalAtendimento.MunicipioID = Nothing
                ViewModelLocalAtendimento.LocalAtendimento.Municipio = Nothing
            End If

            Using Contexto As New _ContextoBD()
                Contexto.Entry(ViewModelLocalAtendimento.LocalAtendimento).State = IIf(ViewModelLocalAtendimento.LocalAtendimento.LocalAtendimentoID = 0, EntityState.Added, EntityState.Modified)
                Contexto.SaveChanges()
            End Using

            TxtLocalAtendimentoID.Text = ViewModelLocalAtendimento.LocalAtendimento.LocalAtendimentoID

            MsgBox("Local de atendimento " & TxtLocalAtendimentoID.Text & " salvo com sucesso!", vbInformation)

            Call BtnLimpar_Click(Nothing, Nothing)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub BtnReceitaFederal_Click(sender As Object, e As EventArgs) Handles BtnReceitaFederal.Click
        Try

            Cursor = Cursors.WaitCursor

            Call BuscarCNPJ()

        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Atenção")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub BuscarCNPJ()

        If Not IsValidCNPJ(TxtCNPJ.Text) Then
            MsgBox("Informe um CPF inválido!", vbExclamation, "Atenção")
            TxtCNPJ.Focus()
            Exit Sub
        End If

        Dim oWebRequest As WebRequest = WebRequest.Create("https://www.receitaws.com.br/v1/cnpj/" & TxtCNPJ.Text)
        Dim oWebResponse As WebResponse = oWebRequest.GetResponse()

        Using objSR As New StreamReader(oWebResponse.GetResponseStream)
            Dim strBuffer As String = objSR.ReadToEnd
            Dim result As Object = JsonConvert.DeserializeObject(strBuffer)

            TxtRazaoSocial.Text = Convert.ToString(result("nome"))
            TxtNomeFantasia.Text = Convert.ToString(result("fantasia"))
            TxtEmail.Text = Convert.ToString(result("email"))

            TxtCEP.Text = Convert.ToString(result("cep"))

            Call BtnCEP_Click(Nothing, Nothing)

            TxtLogradouro.Text = Parse.ToString(result("logradouro"))
            TxtComplemento.Text = Parse.ToString(result("complemento"))
            TxtNumero.Text = Convert.ToString(result("numero"))
            TxtBairro.Text = Convert.ToString(result("bairro"))

            strBuffer = Nothing
        End Using
    End Sub

    Private Sub TxtLocalAtendimentoID_Leave(sender As Object, e As EventArgs) Handles TxtLocalAtendimentoID.Leave
        Try

            If Not IsNumeric(TxtLocalAtendimentoID.Text) Then
                Exit Sub
            End If

            Call ProcurarLocalAtendimento(TxtLocalAtendimentoID.Text)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub BtnProcurar_Click(sender As Object, e As EventArgs) Handles BtnProcurar.Click
        Try

            Dim LocalAtendimentoID As String = TelaProcurar("LocalAtendimento")

            Call ProcurarLocalAtendimento(LocalAtendimentoID)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub ProcurarLocalAtendimento(LocalAtendimentoID As String)

        If IsNothing(LocalAtendimentoID) Then
            Exit Sub
        End If

        Using Contexto As New _ContextoBD()

            Dim LocalAtendimento As LocalAtendimento = Contexto.LocalAtendimento.Include("Municipio").FirstOrDefault(Function(c) c.LocalAtendimentoID = LocalAtendimentoID And c.Ativo = True)

            Call BtnLimpar_Click(Nothing, Nothing)

            If IsNothing(LocalAtendimento) Then
                MsgBox("Local de atendimento não encontrado!", vbExclamation, "Atenção")
                Call BtnLimpar_Click(Nothing, Nothing)
                Exit Sub
            End If

            TxtLocalAtendimentoID.Text = LocalAtendimentoID

            If IsNumeric(LocalAtendimento.MunicipioID) Then
                CboUF.SelectedItem = LocalAtendimento.Municipio.UF.ToString()
                TxtMunicipioID.Text = LocalAtendimento.MunicipioID.ToString()
            End If

            CType(ViewModelLocalAtendimento.DataSource, ViewModelLocalAtendimento).LocalAtendimento = LocalAtendimento

            TxtRazaoSocial.Select()

        End Using
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        Try
            If MsgBox("Tem certeza que deseja excluir?", vbYesNo + vbExclamation) = MsgBoxResult.No Then
                Exit Sub
            End If

            Using Contexto As New _ContextoBD()
                Dim ViewModelLocalAtendimento As ViewModelLocalAtendimento = Me.ViewModelLocalAtendimento.DataSource

                ViewModelLocalAtendimento.LocalAtendimento.Ativo = False

                Contexto.Entry(ViewModelLocalAtendimento.LocalAtendimento).State = EntityState.Modified
                Contexto.SaveChanges()

                MsgBox("Excluído com sucesso!", vbInformation)

                Call BtnLimpar_Click(Nothing, Nothing)

            End Using
        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub TxtMunicipioID_Leave(sender As Object, e As EventArgs) Handles TxtMunicipioID.Leave
        Try

            Call ProcuraMunicipio("MunicipioID", TxtMunicipioID.Text)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub ProcuraMunicipio(sCampo As String, sCodigo As String)
        Try

            If sCodigo Is Nothing Then
                GoTo Proximo
            End If

            If Not IsNumeric(sCodigo) Then
                GoTo Limpar
            End If

            Dim dt As DataTable = Database.Execute("SELECT MunicipioID, Nome, UF FROM Municipio WHERE " & sCampo & " = @Codigo", {
                {"@Codigo", sCodigo, SqlDbType.NVarChar}
            }).Tables(0)

            If dt.Rows.Count = 0 Then
                MsgBox("Cidade não encontrada!", vbExclamation, "Atenção")
                TxtMunicipioID.Select()
                GoTo Limpar
            Else
                GoTo Preencher
            End If

Preencher:
            CboUF.SelectedItem = Parse.ToString(dt.Rows(0)("UF"))
            TxtMunicipioID.Text = Parse.ToInt(dt.Rows(0)("MunicipioID"))
            TxtMunicipioNome.Text = Parse.ToString(dt.Rows(0)("Nome"))

            GoTo Proximo
Limpar:
            TxtMunicipioID.Text = Nothing
            TxtMunicipioNome.Text = ""

Proximo:
        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub BtnProcurarMunicipio_Click(sender As Object, e As EventArgs) Handles BtnProcurarMunicipio.Click
        Try

            Dim sWhere As String = ""

            If Parse.ToString(CboUF.SelectedItem) <> "" Then
                sWhere &= "UF = '" & Parse.ToString(CboUF.SelectedItem) & "'"
            End If

            Dim sMunicipioID As String = TelaProcurar("Procurar cidade", "Municipio", {{"MunicipioID", "Código:String"}, {"Nome", "Descrição:String"}, {"UF", "UF:String"}}, "Código", "Descrição", "", sWhere)

            Call ProcuraMunicipio("MunicipioID", sMunicipioID)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub BtnCEP_Click(sender As Object, e As EventArgs) Handles BtnCEP.Click
        Try
            Cursor = Cursors.WaitCursor

            If Not IsNumeric(TxtCEP.Text) Then
                MsgBox("Por favor, informe o CEP!", vbExclamation, "Atenção")
                TxtCEP.Focus()
                Exit Sub
            End If

            Dim Result As Object = BuscarCEP.Buscar(TxtCEP.Text)

            If Result("erro") = True Then
                MsgBox("CEP não encontrado!", vbExclamation, Me.Text)
                Exit Sub
            End If

            TxtLogradouro.Text = Convert.ToString(Result("logradouro"))
            TxtComplemento.Text = Result("complemento")
            TxtBairro.Text = Convert.ToString(Result("bairro"))
            Call ProcuraMunicipio("IBGE", Convert.ToString(Result("ibge")))

            TxtNumero.Select()

        Catch ex As Exception
            MsgBox("Não foi possível consultar este CEP!", vbExclamation, "Atenção")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CboUF_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboUF.SelectedIndexChanged
        Try

            TxtMunicipioID.Text = ""
            TxtMunicipioNome.Text = ""

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

End Class

Public Class ViewModelLocalAtendimento
    Implements INotifyPropertyChanged

    Private _LocalAtendimento As New LocalAtendimento

    Public Property LocalAtendimento As LocalAtendimento
        Get
            Return _LocalAtendimento
        End Get
        Set(value As LocalAtendimento)
            _LocalAtendimento = value
            OnPropertyChanged("LocalAtendimento")
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private Sub OnPropertyChanged(ByVal PropertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(PropertyName))
    End Sub
End Class