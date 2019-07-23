Imports System.ComponentModel
Imports System.Data.Entity
Imports System.IO
Imports System.Net
Imports DoctorVirtus.Desktop.HandleDynamic
Imports Newtonsoft.Json
Imports Syncfusion.GridHelperClasses
Imports Syncfusion.Windows.Forms.Grid.Grouping

Public Class ViewPrestador

    Dim Frm As New Forms

    Private ViewModelPrestador As New BindingSource With {.DataSource = GetType(ViewModelPrestador)}

    Dim Usuario As New HandleDynamic.HandleDynamic

    Private Sub FrmPrestador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Frm.AddHandler_Dynamic(Me)

            Usuario.AddHandler_Dynamic(eTipoCampo.Usuario, TxtUsuarioID, TxtUsuarioDescricao, BtnProcurarUsuario)

            CboTipoPessoa.DataBindings.Add(New Binding("SelectedIndex", ViewModelPrestador, "Prestador.TipoPessoa", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtCNPJ.DataBindings.Add(New Binding("Text", ViewModelPrestador, "Prestador.CNPJ", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtRazaoSocial.DataBindings.Add(New Binding("Text", ViewModelPrestador, "Prestador.RazaoSocial", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtNomeFantasia.DataBindings.Add(New Binding("Text", ViewModelPrestador, "Prestador.NomeFantasia", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtUsuarioDescricao.DataBindings.Add(New Binding("Text", ViewModelPrestador, "Prestador.Usuario.Login", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtTelefone1.DataBindings.Add(New Binding("Text", ViewModelPrestador, "Prestador.Telefone1", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtTelefone2.DataBindings.Add(New Binding("Text", ViewModelPrestador, "Prestador.Telefone2", True, DataSourceUpdateMode.OnPropertyChanged))
            'TxtTelefone3.DataBindings.Add(New Binding("Text", ViewModelPrestador, "Prestador.Telefone3", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtEmail.DataBindings.Add(New Binding("Text", ViewModelPrestador, "Prestador.Email", True, DataSourceUpdateMode.OnPropertyChanged))

            TxtNumeroINSS.DataBindings.Add(New Binding("Text", ViewModelPrestador, "Prestador.NumeroINSS", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtNumeroCRM.DataBindings.Add(New Binding("Text", ViewModelPrestador, "Prestador.NumeroCRM", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtNumeroCNES.DataBindings.Add(New Binding("Text", ViewModelPrestador, "Prestador.NumeroCNES", True, DataSourceUpdateMode.OnPropertyChanged))

            DtpAbertura.DataBindings.Add(New Binding("Value", ViewModelPrestador, "Prestador.Abertura", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtInscEstadual.DataBindings.Add(New Binding("Text", ViewModelPrestador, "Prestador.InscEstadual", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtInscricaoMunicipal.DataBindings.Add(New Binding("Text", ViewModelPrestador, "Prestador.InscMunicipal", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtCEP.DataBindings.Add(New Binding("Text", ViewModelPrestador, "Prestador.CEP", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtLogradouro.DataBindings.Add(New Binding("Text", ViewModelPrestador, "Prestador.Logradouro", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtNumero.DataBindings.Add(New Binding("Text", ViewModelPrestador, "Prestador.Numero", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtComplemento.DataBindings.Add(New Binding("Text", ViewModelPrestador, "Prestador.Complemento", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtBairro.DataBindings.Add(New Binding("Text", ViewModelPrestador, "Prestador.Bairro", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtMunicipioNome.DataBindings.Add(New Binding("Text", ViewModelPrestador, "Prestador.Municipio.Nome", True, DataSourceUpdateMode.OnPropertyChanged))

            Call MontaGridNegociacao()

            Call BtnLimpar_Click(Nothing, Nothing)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub MontaGridNegociacao()

        ActiveControl = GridNegociacao.TableControl
        GridNegociacao.WantTabKey = False

        Dim GridGroupingFilter As New GridExcelFilter With {
            .EnableStackedColumnFilterIcon = True
        }

        GridGroupingFilter.WireGrid(Me.GridNegociacao)

        With GridNegociacao
            .TableDescriptor.Columns.Add(New GridColumnDescriptor() With {.MappingName = "LocalAtendimento.RazaoSocial", .HeaderText = "Local de atendimento", .Width = 170, .AllowFilter = True})
            .TableDescriptor.Columns.Add(New GridColumnDescriptor() With {.MappingName = "Operadora.Descricao", .HeaderText = "Operadora", .Width = 150, .AllowFilter = True})
            .TableDescriptor.Columns.Add(New GridColumnDescriptor() With {.MappingName = "Tabela.Descricao", .HeaderText = "Tabela", .Width = 150, .AllowFilter = True})
            .TableDescriptor.Columns.Add(New GridColumnDescriptor() With {.MappingName = "ValorCH_UCO", .HeaderText = "Valor CH/UCO", .Width = 100, .AllowFilter = True})
            .TableDescriptor.Columns.Add(New GridColumnDescriptor() With {.MappingName = "ValorFilmeM2", .HeaderText = "Valor Filme m²", .Width = 100, .AllowFilter = True})
        End With

    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        Try

            ViewModelPrestador.DataSource = New ViewModelPrestador()

            TxtPrestadorID.Text = Nothing
            TxtUsuarioID.Text = Nothing
            CboUF.SelectedItem = "GO"
            TxtMunicipioID.Text = Nothing

            CType(ViewModelPrestador.DataSource, ViewModelPrestador).Prestador.Negociacao = New List(Of Negociacao)
            CType(ViewModelPrestador.DataSource, ViewModelPrestador).Prestador.Usuario = New Usuario()
            CType(ViewModelPrestador.DataSource, ViewModelPrestador).Prestador.Municipio = New Municipio()

            GridNegociacao.DataSource = CType(ViewModelPrestador.DataSource, ViewModelPrestador).Prestador.Negociacao.ToList()

            TxtRazaoSocial.Select()

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub CboTipoPessoa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboTipoPessoa.SelectedIndexChanged

        Try

            If CboTipoPessoa.SelectedIndex = 1 Then
                CType(ViewModelPrestador.DataSource, ViewModelPrestador).Prestador.TipoPessoa = 1
                LblCNPJ.Text = "CNPJ"
                TxtCNPJ.Mask = "##,###,###/####-##"
                'BtnReceitaFederal.Visible = True
                LblRazaoSocial.Text = "Razão social"
                LblNomeFantasia.Text = "Nome fantasia"
                LblInscEstadual.Text = "Insc. Estadual"
                LblNascimento.Text = "Abertura"
            Else
                CType(ViewModelPrestador.DataSource, ViewModelPrestador).Prestador.TipoPessoa = 0
                LblCNPJ.Text = "CPF"
                TxtCNPJ.Mask = "###,###,###-##"
                'BtnReceitaFederal.Visible = False
                LblRazaoSocial.Text = "Nome completo"
                LblNomeFantasia.Text = "Apelido"
                LblInscEstadual.Text = "RG"
                LblNascimento.Text = "Nascimento"
            End If

            TxtCNPJ.Select()

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try

    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Try

            Cursor.Current = Cursors.WaitCursor

            Dim ViewModelPrestador As ViewModelPrestador = Me.ViewModelPrestador.DataSource

            ViewModelPrestador.Prestador.PrestadorID = TxtPrestadorID.IntegerValue

            If IsNumeric(TxtUsuarioID.Text) Then
                ViewModelPrestador.Prestador.UsuarioID = TxtUsuarioID.Text
                ViewModelPrestador.Prestador.Usuario = Nothing
            Else
                ViewModelPrestador.Prestador.UsuarioID = Nothing
                ViewModelPrestador.Prestador.Usuario = Nothing
            End If

            ViewModelPrestador.Prestador.Abertura = DtpAbertura.Value

            If IsNumeric(TxtMunicipioID.Text) Then
                ViewModelPrestador.Prestador.MunicipioID = TxtMunicipioID.Text
                ViewModelPrestador.Prestador.Municipio = Nothing 'New Municipio With {.MunicipioID = TxtMunicipioID.Text, .Nome = TxtMunicipioNome.Text}
            Else
                ViewModelPrestador.Prestador.MunicipioID = Nothing
                ViewModelPrestador.Prestador.Municipio = Nothing
            End If

            Using Contexto As New _ContextoBD()

                Dim Negociacao As List(Of Negociacao) = ViewModelPrestador.Prestador.Negociacao.ToList()

                ViewModelPrestador.Prestador.Negociacao.Clear()

                If ViewModelPrestador.Prestador.PrestadorID = 0 Then
                    Contexto.Prestador.Add(ViewModelPrestador.Prestador)
                Else
                    Contexto.Prestador.Attach(ViewModelPrestador.Prestador)
                    Contexto.Entry(ViewModelPrestador.Prestador).State = EntityState.Modified
                End If

                'Contexto.Entry(ViewModelPrestador.Prestador).State = IIf(ViewModelPrestador.Prestador.PrestadorID = 0, EntityState.Added, EntityState.Modified)
                Contexto.SaveChanges()


                For Each Row In Negociacao
                    Row.PrestadorID = ViewModelPrestador.Prestador.PrestadorID
                    Row.Prestador = Nothing
                    Row.LocalAtendimento = Nothing
                    Row.Operadora = Nothing
                    Row.Tabela = Nothing
                Next

                Contexto.Negociacao.RemoveRange(Contexto.Negociacao.Where(Function(c) c.PrestadorID = ViewModelPrestador.Prestador.PrestadorID))
                Contexto.Negociacao.AddRange(Negociacao)

                Contexto.SaveChanges()

            End Using

            TxtPrestadorID.Text = ViewModelPrestador.Prestador.PrestadorID

            MsgBox("Prestador " & TxtPrestadorID.Text & " salvo com sucesso!", vbInformation)

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

            If CboTipoPessoa.SelectedIndex = 0 Then
                Call BuscarCPF()
            Else
                Call BuscarCNPJ()
            End If

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
            DtpAbertura.Value = Convert.ToString(result("abertura"))
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

    Private Sub BuscarCPF()

        If Not IsValidCPF(TxtCNPJ.Text) Then
            MsgBox("Informe um CPF inválido!", vbExclamation, "Atenção")
            TxtCNPJ.Focus()
            Exit Sub
        End If

        Dim oWebRequest As WebRequest = WebRequest.Create("https://vestibular.unoparead.com.br/searchPessoaPorCpf?cpf=" & Parse.ToString(TxtCNPJ.Text))
        Dim oWebResponse As WebResponse = oWebRequest.GetResponse()

        Using objSR As New StreamReader(oWebResponse.GetResponseStream)
            Dim strBuffer As String = objSR.ReadToEnd
            Dim result = JsonConvert.DeserializeObject(strBuffer)

            TxtRazaoSocial.Text = Convert.ToString(result(0)("nome").Value)
            TxtNomeFantasia.Text = Convert.ToString(result(0)("nome").Value)

            strBuffer = Nothing

        End Using
    End Sub

    Private Sub TxtPrestadorID_Leave(sender As Object, e As EventArgs) Handles TxtPrestadorID.Leave
        Try

            If Not IsNumeric(TxtPrestadorID.Text) Then
                Exit Sub
            End If

            Call ProcurarPrestador(TxtPrestadorID.Text)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub BtnProcurar_Click(sender As Object, e As EventArgs) Handles BtnProcurar.Click
        Try

            Dim PrestadorID As String = TelaProcurar("Prestador")

            Call ProcurarPrestador(PrestadorID)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub ProcurarPrestador(PrestadorID As String)

        If IsNothing(PrestadorID) Then
            Exit Sub
        End If

        Using Contexto As New _ContextoBD()

            Dim Prestador As Prestador = Contexto.Prestador.Include("Usuario").Include("Municipio").Include("Negociacao").Include("Negociacao.LocalAtendimento").Include("Negociacao.Operadora").Include("Negociacao.Tabela").FirstOrDefault(Function(c) c.PrestadorID = PrestadorID And c.Ativo = True)

            If IsNothing(Prestador) Then
                MsgBox("Prestador não encontrado!", vbExclamation, "Atenção")
                Call BtnLimpar_Click(Nothing, Nothing)
                Exit Sub
            End If

            Call BtnLimpar_Click(Nothing, Nothing)

            TxtPrestadorID.Text = PrestadorID

            If IsNumeric(Prestador.UsuarioID) Then
                TxtUsuarioID.Text = Prestador.UsuarioID.ToString()
            End If

            If IsNumeric(Prestador.MunicipioID) Then
                CboUF.SelectedItem = Prestador.Municipio.UF.ToString()
                TxtMunicipioID.Text = Prestador.MunicipioID.ToString()
            End If

            CType(ViewModelPrestador.DataSource, ViewModelPrestador).Prestador = Prestador
            GridNegociacao.DataSource = CType(ViewModelPrestador.DataSource, ViewModelPrestador).Prestador.Negociacao.ToList()

            TxtRazaoSocial.Select()

        End Using
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        Try
            If MsgBox("Tem certeza que deseja excluir?", vbYesNo + vbExclamation) = MsgBoxResult.No Then
                Exit Sub
            End If

            Using Contexto As New _ContextoBD()
                Dim ViewModelPrestador As ViewModelPrestador = Me.ViewModelPrestador.DataSource

                ViewModelPrestador.Prestador.Ativo = False

                Contexto.Entry(ViewModelPrestador.Prestador).State = EntityState.Modified
                Contexto.SaveChanges()

                MsgBox("Excluído com sucesso!", vbInformation)

                Call BtnLimpar_Click(Nothing, Nothing)

            End Using
        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub BtnNovaNegociacao_Click(sender As Object, e As EventArgs) Handles BtnNovaNegociacao.Click
        Try

            Dim ViewNegociacao As New ViewNegociacao
            ViewNegociacao.ShowDialog()

            If Not ViewNegociacao.Salvou Then Exit Sub

            Dim Negociacao As New Negociacao With {
                .PrestadorID = TxtPrestadorID.Text,
                .Prestador = New Prestador With {.PrestadorID = TxtPrestadorID.Text, .RazaoSocial = TxtRazaoSocial.Text},
                .LocalAtendimentoID = ViewNegociacao.TxtLocalAtendimentoID.Text,
                .LocalAtendimento = New LocalAtendimento With {.LocalAtendimentoID = ViewNegociacao.TxtLocalAtendimentoID.Text, .RazaoSocial = ViewNegociacao.TxtLocalAtendimentoDescricao.Text},
                .OperadoraID = ViewNegociacao.TxtOperadoraID.Text,
                .Operadora = New Operadora With {.OperadoraID = ViewNegociacao.TxtOperadoraID.Text, .Descricao = ViewNegociacao.TxtOperadoraDescricao.Text},
                .TabelaID = ViewNegociacao.TxtTabelaID.Text,
                .Tabela = New Tabela With {.TabelaID = ViewNegociacao.TxtTabelaID.Text, .Descricao = ViewNegociacao.TxtTabelaDescricao.Text},
                .ValorCH_UCO = ViewNegociacao.TxtCHUCO.DoubleValue,
                .Deflator = ViewNegociacao.TxtDeflator.DoubleValue,
                .Acrescimo = ViewNegociacao.TxtAcrescimo.DoubleValue,
                .DiaFaturamento = ViewNegociacao.TxtEnvioFaturamento.DoubleValue,
                .DiaPagamento = ViewNegociacao.TxtDiaPagamento.DoubleValue,
                .DataVencimento = ViewNegociacao.DtpVencimento.Value
            }

            CType(ViewModelPrestador.DataSource, ViewModelPrestador).Prestador.Negociacao.Add(Negociacao)
            GridNegociacao.DataSource = CType(ViewModelPrestador.DataSource, ViewModelPrestador).Prestador.Negociacao.ToList()

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub BtnRemoverNegociacao_Click(sender As Object, e As EventArgs) Handles BtnRemoverNegociacao.Click
        Try

            If MsgBox("Tem certeza que deseja remover?", vbExclamation + vbYesNo, "Atenção") = MsgBoxResult.No Then Exit Sub

            If GridNegociacao.Table.SelectedRecords.Count > 0 Then
                For Each selectedRecord As Syncfusion.Grouping.SelectedRecord In GridNegociacao.Table.SelectedRecords
                    CType(ViewModelPrestador.DataSource, ViewModelPrestador).Prestador.Negociacao.Remove(selectedRecord.Record.GetData())
                Next
            End If

            GridNegociacao.DataSource = CType(ViewModelPrestador.DataSource, ViewModelPrestador).Prestador.Negociacao.ToList()

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

Public Class ViewModelPrestador
    Implements INotifyPropertyChanged

    Private _Prestador As New Prestador

    Public Property Prestador As Prestador
        Get
            Return _Prestador
        End Get
        Set(value As Prestador)
            _Prestador = value
            OnPropertyChanged("Prestador")
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private Sub OnPropertyChanged(ByVal PropertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(PropertyName))
    End Sub
End Class

'Option Strict Off

'Imports System.Data.SqlClient
'Imports System.IO
'Imports System.Net
'Imports System.Text
'Imports AtlantaSistemas.Model
'Imports Newtonsoft.Json

'Public Class FrmPrestador

'    Public bRetornaParceiro As Boolean = False

'    Dim FrmTelefone As New FrmTelefone

'    Dim dtViewHistorico As New DataTable

'    Dim bCarregouTelefones As Boolean = False
'    Dim bCarregouHistorico As Boolean = False


'    Public Sub New()
'        InitializeComponent()
'    End Sub

'    Private Sub FrmEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'        Try

'            Dim Form As New HandleDynamic.Forms
'            Form.AddHandler_Dynamic(Me)

'            Call MontaGridTelefone()
'            Call MontaGridHistorico()

'            If Not IsNothing(EmpresaLogada.EmpresaID) Then
'                Call ProcurarEmpresa(EmpresaLogada.EmpresaID)
'            Else
'                Call BtnLimpar_Click(Nothing, Nothing)
'            End If

'            'If bRetornaParceiro Then
'            '    Call ProcurarEmpresa(TxtEmpresaID.Text)
'            'Else
'            '    Call BtnLimpar_Click(Nothing, Nothing)
'            'End If

'        Catch ex As Exception
'            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'        End Try

'    End Sub

'    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
'        Try

'            Using Contexto As New _ContextoBD()
'                If Contexto.Empresa.Count = 0 Then
'                    MsgBox("Para utilizar o sistema é necessário cadastrar a sua empresa!", vbExclamation, "Atenção")
'                    e.Cancel = True
'                End If
'            End Using

'        Catch ex As Exception
'            e.Cancel = True
'        End Try
'    End Sub

'    Private Sub MontaGridHistorico()

'        Try

'            GridHistorico.AutoGenerateColumns = False

'            With GridHistorico.Columns
'                .Add(New DataGridViewTextBoxColumn() With {.HeaderText = "HistoricoID", .DataPropertyName = "HistoricoID"})
'                .Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Usuário", .DataPropertyName = "Usuario", .Width = 180})
'                .Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Data", .DataPropertyName = "Data", .Width = 140})
'                .Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Descricao", .DataPropertyName = "Descricao", .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill})
'                .Add(New DataGridViewTextBoxColumn() With {.HeaderText = "PC", .DataPropertyName = "PC", .Width = 200})
'            End With

'            For Each column As DataGridViewColumn In GridHistorico.Columns
'                dtViewHistorico.Columns.Add(column.DataPropertyName)
'            Next

'            GridHistorico.Columns(0).Visible = False

'            GridHistorico.DataSource = dtViewHistorico

'        Catch ex As Exception
'            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'        End Try

'    End Sub

'    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click

'        Dim da As New SqlDataAdapter
'        Dim dt As New DataTable

'        Try

'            Cursor.Current = Cursors.WaitCursor

'            If TxtCNPJ.Text <> "" Then
'                If CboTipoPessoa.SelectedIndex = 0 Then
'                    If Not IsValidCPF(TxtCNPJ.Text) Then
'                        MsgBox("Informe um CPF inválido!", vbExclamation, "Atenção")
'                        TxtCNPJ.Focus()
'                        Exit Sub
'                    End If
'                Else
'                    If Not IsValidCNPJ(TxtCNPJ.Text) Then
'                        MsgBox("Informe um CNPJ inválido!", vbExclamation, "Atenção")
'                        TxtCNPJ.Focus()
'                        Exit Sub
'                    End If
'                End If
'            End If

'            If Parse.ToString(TxtRazaoSocial.Text) = "" Then
'                MsgBox("Informe " & IIf(CboTipoPessoa.SelectedIndex = 0, "o nome completo", "a razão social") & "!", vbExclamation, "Atenção")
'                TxtRazaoSocial.Select()
'                Exit Sub
'            End If

'            If Parse.ToString(TxtNomeFantasia.Text) = "" Then
'                MsgBox("Informe o " & LblNomeFantasia.Text.ToLower & "!", vbExclamation, "Atenção")
'                TxtNomeFantasia.Select()
'                Exit Sub
'            End If

'            'If Not VerificaConexao() Then
'            '    Exit Sub
'            'End If

'            If TxtEmpresaID.Text = "" Then
'                dt = Database.Execute("SELECT TOP 1 1 FROM Empresa WHERE CNPJ = @CNPJ", {
'                    {"@CNPJ", TxtCNPJ.Text, SqlDbType.NVarChar}
'                }).Tables(0)

'                If dt.Rows.Count = 1 Then
'                    MsgBox("CNPJ já esta cadastrado para outro parceiro!", vbExclamation, "Atenção")
'                    Exit Sub
'                End If
'            End If


'            Using cn As New SqlConnection(Database.Conexao)
'                Using cmd As New SqlCommand("spEmpresa", cn)
'                    Try
'                        With cmd
'                            .Connection.Open()

'                            .CommandType = CommandType.StoredProcedure

'                            .Parameters.AddWithValue("@EmpresaID", Parse.IsEmpty(TxtEmpresaID.Text)).SqlDbType = SqlDbType.Int


'                            .Parameters.AddWithValue("@UsuarioIDAlterou", Parse.IsEmpty(UsuarioLogado.UsuarioID)).SqlDbType = SqlDbType.Int
'                            .Parameters.AddWithValue("@CNPJ", Parse.IsEmpty(TxtCNPJ.Text)).SqlDbType = SqlDbType.NVarChar
'                            .Parameters.AddWithValue("@RazaoSocial", Parse.IsEmpty(TxtRazaoSocial.Text)).SqlDbType = SqlDbType.NVarChar
'                            .Parameters.AddWithValue("@NomeFantasia", Parse.IsEmpty(TxtNomeFantasia.Text)).SqlDbType = SqlDbType.NVarChar
'                            .Parameters.AddWithValue("@TipoPessoa", Parse.IsEmpty(CboTipoPessoa.SelectedIndex)).SqlDbType = SqlDbType.Int
'                            .Parameters.AddWithValue("@InscEstadual", Parse.IsEmpty(TxtInscEstadual.Text)).SqlDbType = SqlDbType.NVarChar
'                            .Parameters.AddWithValue("@Email", Parse.IsEmpty(TxtEmail.Text)).SqlDbType = SqlDbType.NVarChar
'                            .Parameters.AddWithValue("@Abertura", Parse.IsEmpty(DtpNascimento.Value)).SqlDbType = SqlDbType.Date
'                            .Parameters.AddWithValue("@Responsavel", Parse.IsEmpty(TxtResponsavel.Text)).SqlDbType = SqlDbType.NVarChar
'                            .Parameters.AddWithValue("@Contato", Parse.IsEmpty(TxtContato.Text)).SqlDbType = SqlDbType.NVarChar
'                            .Parameters.AddWithValue("@TelefonePrincipal", Parse.IsEmpty(TxtTelefone.Text)).SqlDbType = SqlDbType.NVarChar

'                            'Endereco
'                            .Parameters.AddWithValue("@Endereco_CEP", Parse.IsEmpty(TxtCEP.Text)).SqlDbType = SqlDbType.NVarChar
'                            .Parameters.AddWithValue("@Endereco_Logradouro", Parse.IsEmpty(TxtLogradouro.Text)).SqlDbType = SqlDbType.NVarChar
'                            .Parameters.AddWithValue("@Endereco_Complemento", Parse.IsEmpty(TxtComplemento.Text)).SqlDbType = SqlDbType.NVarChar
'                            .Parameters.AddWithValue("@Endereco_Numero", Parse.IsEmpty(TxtNumero.Text)).SqlDbType = SqlDbType.NVarChar
'                            .Parameters.AddWithValue("@Endereco_Bairro", Parse.IsEmpty(TxtBairro.Text)).SqlDbType = SqlDbType.NVarChar
'                            .Parameters.AddWithValue("@Endereco_MunicipioID", Parse.IsEmpty(TxtMunicipioID.Text)).SqlDbType = SqlDbType.Int

'                            'Parameters OUT
'                            .Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output

'                            .ExecuteNonQuery()

'                            TxtEmpresaID.Text = Parse.ToString(.Parameters("@ID").Value)
'                            MsgBox("Empresa " & TxtEmpresaID.Text & " salvo com sucesso!", vbInformation, "")

'                            'If bRetornaParceiro Then
'                            '    Me.Close()
'                            'Else
'                            '    Call BtnNovo_Click()
'                            'End If

'                        End With
'                    Catch ex As Exception
'                        Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'                    End Try
'                End Using
'            End Using

'            Call CarregarParametros()

'        Catch ex As Exception
'            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'        End Try

'    End Sub

'    Private Function Valida() As Boolean

'        Try

'            'If ApenasNumero(TxtCNPJ.Text) <> "" Then
'            If CboTipoPessoa.SelectedIndex = 0 Then
'                'If Not TxtCNPJ.Text.IsCPF() Then
'                'MsgBox("CPF inválido!", vbExclamation, "Atenção")
'                'LblCNPJ.Select()
'                'Return False
'                'End If
'            Else
'                'If Not TxtCNPJ.Text.IsCNPJ() Then
'                MsgBox("CNPJ inválido!", vbExclamation, "Atenção")
'                LblCNPJ.Select()
'                Return False
'                'End If
'            End If
'            'End If

'            If TxtRazaoSocial.Text = "" Then
'                MsgBox("Informe o " & LblRazaoSocial.Text.ToLower & "!", vbExclamation, "Atenção")
'                TxtRazaoSocial.Focus()
'                Return False
'            End If

'            'If txtNomeFantasia.Text = "" Then
'            'MsgBox("Informe a " & lblNomeFantasia.Text.ToLower & "!", vbExclamation, "Atenção")
'            'txtNomeFantasia.Focus()
'            'Return False
'            'End If

'            Return True

'        Catch ex As Exception
'            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'            Return False
'        End Try

'    End Function

'    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click

'        Try

'            Call LimparCampos(Me)

'            BtnExcluir.Visible = False

'            CboTipoPessoa.SelectedIndex = 1
'            DtpNascimento.Value = Convert.ToDateTime("01/01/2000")
'            ChkPeriodo.Checked = False
'            FrmTelefone.dtViewTelefone.Clear()
'            dtViewHistorico.Clear()
'            DtpHistoticoInicio.Value = Now
'            DtpHistoticoFinal.Value = Now

'            TabPrincipal.SelectedIndex = 0

'            TxtCNPJ.Select()

'        Catch ex As Exception
'            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'        End Try

'    End Sub

'    Private Sub BtnReceitaFederal_Click() Handles BtnReceitaFederal.Click

'        Try

'            If CboTipoPessoa.SelectedIndex = 0 Then
'                Call BuscarCPF()
'            Else
'                Call BuscarCNPJ()
'            End If

'        Catch ex As Exception
'            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'        End Try

'    End Sub

'    Private Sub BuscarCNPJ()

'        Try

'            Cursor = Cursors.WaitCursor

'            If Parse.ToString(TxtCNPJ.Text) = "" Then
'                MsgBox("Por favor, informe o CNPJ!", vbExclamation, "Atenção")
'                TxtCNPJ.Focus()
'                Exit Sub
'            End If

'            If Not IsValidCNPJ(TxtCNPJ.Text) Then
'                MsgBox("Informe um CPF inválido!", vbExclamation, "Atenção")
'                TxtCNPJ.Focus()
'                Exit Sub
'            End If


'            Dim oWebRequest As WebRequest = WebRequest.Create("https://www.receitaws.com.br/v1/cnpj/" & TxtCNPJ.Text)
'            Dim oWebResponse As WebResponse = oWebRequest.GetResponse()
'            'Le a resposta do web site e armazena em uma stream
'            Dim objSR As StreamReader = New StreamReader(oWebResponse.GetResponseStream)
'            Dim strBuffer As String = objSR.ReadToEnd

'            Dim result As Object = JsonConvert.DeserializeObject(strBuffer)


'            TxtRazaoSocial.Text = Convert.ToString(result("nome"))
'            TxtNomeFantasia.Text = Convert.ToString(result("fantasia"))
'            DtpNascimento.Value = Convert.ToString(result("abertura"))
'            TxtEmail.Text = Convert.ToString(result("email"))

'            TxtCEP.Text = Convert.ToString(result("cep"))

'            Call BtnCEP_Click()

'            TxtLogradouro.Text = Parse.ToString(result("logradouro"))
'            TxtComplemento.Text = Parse.ToString(result("complemento"))
'            TxtNumero.Text = Convert.ToString(result("numero"))
'            TxtBairro.Text = Convert.ToString(result("bairro"))

'            strBuffer = Nothing
'            objSR = Nothing

'        Catch ex As Exception
'            MsgBox("Não foi possível consultar este CNPJ!", vbExclamation, "Atenção")
'        Finally
'            BtnReceitaFederal.Enabled = True
'            Cursor = Cursors.Default
'        End Try

'    End Sub

'    Private Sub BuscarCPF()

'        Try

'            Cursor = Cursors.WaitCursor

'            If Parse.ToString(TxtCNPJ.Text) = "" Then
'                MsgBox("Por favor, informe o CPF!", vbExclamation, "Atenção")
'                TxtCNPJ.Focus()
'                Exit Sub
'            End If

'            If Not IsValidCPF(TxtCNPJ.Text) Then
'                MsgBox("Informe um CPF inválido!", vbExclamation, "Atenção")
'                TxtCNPJ.Focus()
'                Exit Sub
'            End If

'            Dim oWebRequest As WebRequest = WebRequest.Create("https://vestibular.unoparead.com.br/searchPessoaPorCpf?cpf=" & Parse.ToString(TxtCNPJ.Text))
'            Dim oWebResponse As WebResponse = oWebRequest.GetResponse()
'            Dim objSR As StreamReader = New StreamReader(oWebResponse.GetResponseStream)
'            Dim strBuffer As String = objSR.ReadToEnd

'            Dim result = JsonConvert.DeserializeObject(strBuffer)

'            TxtRazaoSocial.Text = Convert.ToString(result(0)("nome").Value)
'            TxtNomeFantasia.Text = Convert.ToString(result(0)("nome").Value)


'            strBuffer = Nothing
'            objSR = Nothing

'        Catch ex As Exception
'            MsgBox("Não foi possível consultar este CPF!", vbExclamation, "Atenção")
'        Finally
'            BtnReceitaFederal.Enabled = True
'            Cursor = Cursors.Default
'        End Try

'    End Sub

'    Private Sub CboTipoPessoa_SelectedIndexChanged() Handles CboTipoPessoa.SelectedIndexChanged

'        Try

'            If CboTipoPessoa.SelectedIndex = 1 Then
'                LblCNPJ.Text = "CNPJ"
'                TxtCNPJ.Mask = "##,###,###/####-##"
'                'BtnReceitaFederal.Visible = True
'                LblRazaoSocial.Text = "Razão social"
'                LblNomeFantasia.Text = "Nome fantasia"
'                LblInscEstadual.Text = "Insc. Estadual"
'                LblNascimento.Text = "Abertura"
'                ChkIsento.Visible = True
'            Else
'                LblCNPJ.Text = "CPF"
'                TxtCNPJ.Mask = "###,###,###-##"
'                'BtnReceitaFederal.Visible = False
'                LblRazaoSocial.Text = "Nome completo"
'                LblNomeFantasia.Text = "Apelido"
'                LblInscEstadual.Text = "RG"
'                LblNascimento.Text = "Nascimento"
'                ChkIsento.Visible = False
'                ChkIsento.Checked = False
'            End If

'            TxtCNPJ.Select()

'        Catch ex As Exception
'            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'        End Try

'    End Sub

'    Private Sub BtnCEP_Click() Handles BtnCEP.Click

'        Try

'            Cursor = Cursors.WaitCursor

'            If Not IsNumeric(TxtCEP.Text) Then
'                MessageBox.Show("Por favor, informe o CEP!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
'                TxtCEP.Focus()
'                Exit Sub
'            End If

'            Dim oWebRequest As WebRequest = WebRequest.Create("https://viacep.com.br/ws/" & TxtCEP.Text & "/json/")
'            Dim oWebResponse As WebResponse = oWebRequest.GetResponse()

'            'Le a resposta do web site e armazena em uma stream
'            Dim objSR As StreamReader = New StreamReader(oWebResponse.GetResponseStream)
'            Dim strBuffer As String = objSR.ReadToEnd

'            Dim result As Object = JsonConvert.DeserializeObject(strBuffer)

'            If result("erro") = True Then
'                MsgBox("CEP não encontrado!", vbExclamation, Me.Text)
'                Exit Sub
'            End If

'            TxtLogradouro.Text = Convert.ToString(result("logradouro"))
'            TxtComplemento.Text = result("complemento")
'            TxtBairro.Text = Convert.ToString(result("bairro"))

'            Call ProcuraMunicipio("IBGE", Convert.ToString(result("ibge")))

'            TxtNumero.Select()

'            strBuffer = Nothing
'            objSR = Nothing

'        Catch ex As Exception
'            'Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'            MsgBox("Não foi possível consultar este CEP!", vbExclamation, "Atenção")
'        Finally
'            BtnCEP.Enabled = True
'            Cursor = Cursors.Default
'        End Try

'    End Sub

'    Private Sub ProcurarEmpresa(sEmpresaID As String)

'        Dim da As New SqlDataAdapter
'        Dim dt As New DataTable

'        Dim sSQL As New StringBuilder

'        Try

'            If sEmpresaID Is Nothing Then
'                GoTo Proximo
'            End If

'            If Not IsNumeric(sEmpresaID) Then
'                GoTo Limpar
'            End If

'            sSQL.AppendLine("SELECT")
'            'sSQL.AppendLine("     Parceiro.UsuarioIDAlterou")

'            sSQL.AppendLine("     CAST(Empresa.UsuarioIDCadastrou AS NVARCHAR(6)) + ' - ' + UsuarioCadastrou.Nome AS UsuarioCadastrou")
'            sSQL.AppendLine("   , Empresa.DataCadatro")

'            sSQL.AppendLine("   , CAST(Empresa.UsuarioIDAlterou AS NVARCHAR(6)) + ' - ' + UsuarioAlterou.Nome AS UsuarioAlterou")
'            sSQL.AppendLine("   , Empresa.DataAlteracao")

'            sSQL.AppendLine("   , Empresa.EmpresaID")
'            sSQL.AppendLine("   , Empresa.RazaoSocial")
'            sSQL.AppendLine("   , Empresa.NomeFantasia")
'            sSQL.AppendLine("   , Empresa.TipoPessoa")
'            sSQL.AppendLine("   , Empresa.Email")
'            sSQL.AppendLine("   , Telefone.Numero")
'            sSQL.AppendLine("   , Empresa.CNPJ")
'            sSQL.AppendLine("   , Empresa.InscEstadual")

'            sSQL.AppendLine("   , Empresa.Responsavel")
'            sSQL.AppendLine("   , Empresa.Contato")

'            sSQL.AppendLine("   , Endereco.CEP")
'            sSQL.AppendLine("   , Endereco.Logradouro")
'            sSQL.AppendLine("   , Endereco.Numero AS Endereco_Numero")
'            sSQL.AppendLine("   , Endereco.Complemento")
'            sSQL.AppendLine("   , Endereco.Bairro")
'            sSQL.AppendLine("   , Municipio.MunicipioID")
'            sSQL.AppendLine("   , Municipio.Nome AS MunicipioNome")
'            sSQL.AppendLine("   , Municipio.UF")

'            sSQL.AppendLine("FROM Empresa")
'            sSQL.AppendLine("LEFT JOIN Usuario AS UsuarioCadastrou ON UsuarioCadastrou.UsuarioID = Empresa.UsuarioIDCadastrou")
'            sSQL.AppendLine("LEFT JOIN Usuario AS UsuarioAlterou ON UsuarioAlterou.UsuarioID = Empresa.UsuarioIDAlterou")
'            sSQL.AppendLine("LEFT JOIN Telefone ON Telefone.EmpresaID = Empresa.EmpresaID AND Telefone.Principal = 1")
'            sSQL.AppendLine("LEFT JOIN Endereco ON Endereco.EmpresaID = Empresa.EmpresaID AND Endereco.Principal = 1 ")
'            sSQL.AppendLine("LEFT JOIN Municipio ON Endereco.MunicipioID = Municipio.MunicipioID")
'            sSQL.AppendLine("WHERE   Empresa.EmpresaID = @EmpresaID")
'            sSQL.AppendLine("AND Empresa.Ativo = 1")


'            If Not VerificaConexao() Then
'                Exit Sub
'            End If

'            Using cn As New SqlConnection(Database.Conexao)
'                Using cmd As New SqlCommand("", cn)
'                    Try
'                        With cmd
'                            .Connection.Open()
'                            .CommandText = sSQL.ToString()

'                            .Parameters.AddWithValue("@EmpresaID", Parse.IsEmpty(sEmpresaID)).SqlDbType = SqlDbType.Int

'                            da = New SqlDataAdapter(cmd)
'                            da.Fill(dt)

'                            If dt.Rows.Count = 0 Then
'                                MsgBox("Empresa não encontrada!", vbExclamation, "Atenção")
'                                TxtEmpresaID.Select()
'                                GoTo Limpar
'                            Else
'                                GoTo Preencher
'                            End If

'                        End With
'                    Catch ex As Exception
'                        Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'                        GoTo Limpar
'                    End Try
'                End Using
'            End Using

'Preencher:

'            TabPrincipal.SelectedIndex = 0

'            BtnExcluir.Visible = True
'            TxtEmpresaID.Text = Parse.ToString(dt.Rows(0)("EmpresaID"))
'            TxtRazaoSocial.Text = Parse.ToString(dt.Rows(0)("RazaoSocial"))
'            TxtTelefone.Text = Parse.ToString(dt.Rows(0)("Numero"))
'            TxtEmail.Text = Parse.ToString(dt.Rows(0)("Email"))
'            TxtNomeFantasia.Text = Parse.ToString(dt.Rows(0)("NomeFantasia"))
'            CboTipoPessoa.SelectedIndex = Convert.ToInt16(Parse.ToInt(dt.Rows(0)("TipoPessoa")))
'            TxtCNPJ.Text = Parse.ToString(dt.Rows(0)("CNPJ"))
'            TxtResponsavel.Text = Parse.ToString(dt.Rows(0)("Responsavel"))
'            TxtContato.Text = Parse.ToString(dt.Rows(0)("Contato"))
'            TxtInscEstadual.Text = Parse.ToString(dt.Rows(0)("InscEstadual"))

'            If Parse.ToString(dt.Rows(0)("InscEstadual")) = "ISENTO" Then
'                ChkIsento.Checked = True
'            Else
'                ChkIsento.Checked = False
'            End If

'            TxtCEP.Text = Parse.ToString(dt.Rows(0)("CEP"))
'            TxtLogradouro.Text = Parse.ToString(dt.Rows(0)("Logradouro"))
'            TxtNumero.Text = Parse.ToString(dt.Rows(0)("Endereco_Numero"))
'            TxtComplemento.Text = Parse.ToString(dt.Rows(0)("Complemento"))
'            TxtBairro.Text = Parse.ToString(dt.Rows(0)("Bairro"))
'            CboUF.SelectedItem = Parse.ToString(dt.Rows(0)("UF"))
'            TxtMunicipioID.IntegerValue = Parse.ToInt(dt.Rows(0)("MunicipioID"))
'            TxtMunicipioNome.Text = Parse.ToString(dt.Rows(0)("MunicipioNome"))
'            TxtUsuarioCadastrou.Text = Parse.ToString(dt.Rows(0)("UsuarioCadastrou"))
'            TxtCadastradoEm.Text = Parse.ToString(dt.Rows(0)("DataCadatro"))
'            TxtAlteradoPor.Text = Parse.ToString(dt.Rows(0)("UsuarioAlterou"))
'            TxtDataAlteracao.Text = Parse.ToString(dt.Rows(0)("DataAlteracao"))

'            bCarregouTelefones = False
'            bCarregouHistorico = False

'            GoTo Proximo
'Limpar:
'            Call BtnLimpar_Click(Nothing, Nothing)

'            TxtEmpresaID.Select()

'Proximo:

'        Catch ex As Exception
'            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'        End Try

'    End Sub

'    Private Sub CarregarGridTelefone()

'        Dim da As New SqlDataAdapter
'        Dim sSQL As New StringBuilder

'        Try

'            If Parse.ToString(TxtEmpresaID.Text) = "" Then
'                Exit Sub
'            End If

'            Cursor.Current = Cursors.WaitCursor

'            sSQL.AppendLine("SELECT Numero FROM Telefone WHERE ParceiroID = @ParceiroID AND Principal = 0")


'            If Not VerificaConexao() Then
'                Exit Sub
'            End If

'            Using cn As New SqlConnection(Database.Conexao)
'                Using cmd As New SqlCommand("", cn)
'                    Try
'                        With cmd
'                            .Connection.Open()

'                            .CommandText = sSQL.ToString()

'                            .Parameters.AddWithValue("@ParceiroID", Parse.IsEmpty(TxtEmpresaID.Text)).SqlDbType = SqlDbType.Int

'                            FrmTelefone.dtViewTelefone.Clear()

'                            da = New SqlDataAdapter(cmd)
'                            da.Fill(FrmTelefone.dtViewTelefone)

'                            bCarregouTelefones = True

'                        End With
'                    Catch ex As Exception
'                        Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'                    End Try
'                End Using
'            End Using

'        Catch ex As Exception
'            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'        Finally
'            Cursor.Current = Cursors.Default
'        End Try

'    End Sub

'    Private Sub CarregarGridHistorico()

'        Dim da As New SqlDataAdapter
'        Dim sSQL As New StringBuilder

'        Try

'            If Parse.ToString(TxtEmpresaID.Text) = "" Then
'                Exit Sub
'            End If

'            Cursor.Current = Cursors.WaitCursor

'            sSQL.AppendLine("SELECT")
'            sSQL.AppendLine("     HistoricoID")
'            sSQL.AppendLine("   , CAST(Usuario.UsuarioID AS NVARCHAR(6)) + ' - ' + Usuario.Nome AS Usuario")
'            sSQL.AppendLine("   , Data")
'            sSQL.AppendLine("   , CASE WHEN AcaoID = 1 THEN 'Cadastrou' WHEN AcaoID = 2 THEN 'Alterou os dados' ELSE '' END AS Descricao")
'            sSQL.AppendLine("   , Historico.Host AS PC")
'            sSQL.AppendLine("FROM Historico")
'            sSQL.AppendLine("LEFT JOIN Usuario ON Usuario.UsuarioID = Historico.UsuarioID")
'            sSQL.AppendLine("WHERE AcessoID = 11 AND TabelaID = @ParceiroID")

'            If Parse.ToString(TxtHistoricoUsuarioID.Text) <> "" Then
'                sSQL.AppendLine(" AND Historico.UsuarioID = @UsuarioID")
'            End If

'            If ChkPeriodo.Checked = True Then
'                sSQL.AppendLine(" AND Data BETWEEN @DataInicial AND @DataFinal")
'            End If

'            If Parse.ToString(TxtHistoricoCampo.Text) <> "" Then
'                sSQL.AppendLine(" AND HistoricoID IN (SELECT HistoricoID FROM HistoricoDetalhe WHERE Campo = @HistoricoCampo)")
'            End If

'            sSQL.AppendLine("ORDER BY Data DESC")

'            If Not VerificaConexao() Then
'                Exit Sub
'            End If

'            Using cn As New SqlConnection(Database.Conexao)
'                Using cmd As New SqlCommand("", cn)
'                    Try
'                        With cmd
'                            .Connection.Open()

'                            .CommandText = sSQL.ToString()

'                            .Parameters.AddWithValue("@ParceiroID", Parse.IsEmpty(TxtEmpresaID.Text)).SqlDbType = SqlDbType.Int
'                            .Parameters.AddWithValue("@UsuarioID", Parse.IsEmpty(TxtHistoricoUsuarioID.Text)).SqlDbType = SqlDbType.Int

'                            .Parameters.AddWithValue("@HistoricoCampo", Parse.IsEmpty(TxtHistoricoCampo.Text)).SqlDbType = SqlDbType.NVarChar


'                            .Parameters.AddWithValue("@DataInicial", Parse.IsEmpty(Format(DtpHistoticoInicio.Value, "dd/MM/yyyy 00:00:00"))).SqlDbType = SqlDbType.DateTime
'                            .Parameters.AddWithValue("@DataFinal", Parse.IsEmpty(Format(DtpHistoticoFinal.Value, "dd/MM/yyyy 23:59:59"))).SqlDbType = SqlDbType.DateTime

'                            dtViewHistorico.Clear()

'                            da = New SqlDataAdapter(cmd)
'                            da.Fill(dtViewHistorico)

'                            GridHistorico.Columns(0).Visible = False

'                            bCarregouHistorico = True

'                        End With
'                    Catch ex As Exception
'                        Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'                    End Try
'                End Using
'            End Using

'        Catch ex As Exception
'            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'        Finally
'            Cursor.Current = Cursors.Default
'        End Try

'    End Sub

'    Private Sub TxtMunicipioID_Leave() Handles TxtMunicipioID.Leave

'        Try

'            Call ProcuraMunicipio("MunicipioID", TxtMunicipioID.Text)

'        Catch ex As Exception
'            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'        End Try

'    End Sub

'    Private Sub ProcuraMunicipio(sCampo As String, sCodigo As String)

'        Dim da As New SqlDataAdapter
'        Dim dt As New DataTable

'        Try

'            If sCodigo Is Nothing Then
'                GoTo Proximo
'            End If

'            If Not IsNumeric(sCodigo) Then
'                GoTo Limpar
'            End If

'            Using cn As New SqlConnection(Database.Conexao)
'                Using cmd As New SqlCommand("", cn)
'                    Try
'                        With cmd
'                            .Connection.Open()
'                            .CommandText = "SELECT MunicipioID, Nome, UF FROM Municipio WHERE " & sCampo & " = @Codigo"

'                            .Parameters.AddWithValue("@Codigo", Parse.IsEmpty(sCodigo)).SqlDbType = SqlDbType.NVarChar

'                            da = New SqlDataAdapter(cmd)
'                            da.Fill(dt)

'                            If dt.Rows.Count = 0 Then
'                                MsgBox("Cidade não encontrada!", vbExclamation, "Atenção")
'                                TxtEmpresaID.Select()
'                                GoTo Limpar
'                            Else
'                                GoTo Preencher
'                            End If

'                        End With
'                    Catch ex As Exception
'                        Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'                    End Try
'                End Using
'            End Using

'Preencher:

'            CboUF.SelectedItem = Parse.ToString(dt.Rows(0)("UF"))
'            TxtMunicipioID.IntegerValue = Parse.ToInt(dt.Rows(0)("MunicipioID"))
'            TxtMunicipioNome.Text = Parse.ToString(dt.Rows(0)("Nome"))

'            GoTo Proximo
'Limpar:
'            TxtMunicipioID.Text = Nothing
'            TxtMunicipioNome.Text = ""

'Proximo:

'        Catch ex As Exception
'            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'        End Try

'    End Sub

'    Private Sub BtnProcurarMunicipio_Click() Handles BtnProcurarMunicipio.Click

'        Try

'            Dim sWhere As String = ""

'            If Parse.ToString(CboUF.SelectedItem) <> "" Then
'                sWhere &= "UF = '" & Parse.ToString(CboUF.SelectedItem) & "'"
'            End If

'            Dim sMunicipioID As String = TelaProcurar("Procurar cidade", "Municipio", {{"MunicipioID", "Código:String"}, {"Nome", "Descrição:String"}, {"UF", "UF:String"}}, "Código", "Descrição", "", sWhere)

'            Call ProcuraMunicipio("MunicipioID", sMunicipioID)

'        Catch ex As Exception
'            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'        End Try

'    End Sub

'    Private Sub BtnProcurar_Click(sender As Object, e As EventArgs) Handles BtnProcurar.Click

'        Try

'            Dim sEmpresaID As String = TelaProcurar("Empresa")

'            Call ProcurarEmpresa(sEmpresaID)

'        Catch ex As Exception
'            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'        End Try

'    End Sub

'    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
'        Try

'            If MessageBox.Show("Tem certeza que excluir esse parceiro?", "Atlanta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
'                Exit Sub
'            End If

'            If Not VerificaConexao() Then
'                Exit Sub
'            End If

'            Using cn As New SqlConnection(Database.Conexao)
'                Using cmd As New SqlCommand("", cn)
'                    Try
'                        With cmd
'                            .Connection.Open()
'                            .CommandText = "UPDATE Parceiro SET Ativo = 0 WHERE ParceiroID = @ParceiroID"

'                            .Parameters.AddWithValue("@ParceiroID", Parse.IsEmpty(TxtEmpresaID.Text)).SqlDbType = SqlDbType.Int

'                            .ExecuteNonQuery()

'                            Call BtnLimpar_Click(Nothing, Nothing)

'                            MsgBox("Cliente excluído com sucesso!", vbInformation)

'                        End With
'                    Catch ex As Exception
'                        Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'                    End Try
'                End Using
'            End Using

'        Catch ex As Exception
'            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'        End Try
'    End Sub

'    Private Sub BtnAdicionarTelefone_Click() Handles BtnAdicionarTelefone.Click

'        Try

'            If Not bCarregouTelefones Then
'                Call CarregarGridTelefone()
'            End If

'            FrmTelefone.ShowDialog()

'        Catch ex As Exception
'            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'        End Try

'    End Sub

'    Private Sub CboUF_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles CboUF.KeyPress

'        Try
'            e.Handled = True
'        Catch ex As Exception
'            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'        End Try

'    End Sub

'    Private Sub CboUF_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CboUF.SelectionChangeCommitted

'        Try

'            TxtMunicipioID.Text = Nothing
'            TxtMunicipioNome.Text = ""

'        Catch ex As Exception
'            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'        End Try

'    End Sub

'    Public Sub TxtParceiroID_Leave() Handles TxtEmpresaID.Leave

'        Try

'            If Not IsNumeric(TxtEmpresaID.Text) Then
'                Exit Sub
'            End If

'            'If TxtParceiroID.ReadOnly And Not bRetornaParceiro Then
'            '    Exit Sub
'            'End If

'            'TxtParceiroID.ReadOnly = True
'            'TxtParceiroID.BackColor = Color.Bisque

'            Call ProcurarEmpresa(TxtEmpresaID.Text)

'        Catch ex As Exception
'            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'        End Try

'    End Sub

'    'Private Sub TxtParceiroID_DoubleClick(sender As Object, e As EventArgs) Handles TxtParceiroID.DoubleClick

'    '    Try

'    '        TxtParceiroID.ReadOnly = False
'    '        TxtParceiroID.BackColor = Color.White

'    '    Catch ex As Exception
'    '        Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'    '    End Try

'    'End Sub

'    Private Sub ChkIsento_CheckedChanged(sender As Object, e As EventArgs)

'        Try

'            If ChkIsento.Checked Then
'                TxtInscEstadual.Text = "ISENTO"
'                TxtInscEstadual.ReadOnly = True
'                TxtInscEstadual.BackColor = Color.Gainsboro
'            Else
'                TxtInscEstadual.Text = ""
'                TxtInscEstadual.ReadOnly = False
'                TxtInscEstadual.BackColor = Color.White
'                TxtInscEstadual.Select()

'            End If

'        Catch ex As Exception
'            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'        End Try

'    End Sub

'    Private Sub MontaGridTelefone()

'        Try

'            FrmTelefone.DataGridView1.AutoGenerateColumns = False

'            With FrmTelefone.DataGridView1.Columns
'                .Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Número", .DataPropertyName = "Numero", .Visible = True, .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill})
'            End With

'            For Each column As DataGridViewColumn In FrmTelefone.DataGridView1.Columns
'                FrmTelefone.dtViewTelefone.Columns.Add(column.DataPropertyName)
'            Next

'            FrmTelefone.DataGridView1.DataSource = FrmTelefone.dtViewTelefone

'        Catch ex As Exception
'            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'        End Try

'    End Sub

'    Private Sub GridHistorico_DoubleClick() Handles GridHistorico.DoubleClick

'        Try

'            Dim i As Integer = GridHistorico.CurrentRow.Index

'            Dim Frm As New FrmParceiroHistoricoDetalhe With {
'                .HistoricoID = Parse.ToString(GridHistorico.Item(0, i).Value)
'            }

'            Frm.LblData.Text = Parse.ToString(GridHistorico.Item(2, i).Value)
'            Frm.LblUsuario.Text = Parse.ToString(GridHistorico.Item(1, i).Value)

'            Frm.ShowDialog()

'        Catch ex As Exception
'            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'        End Try

'    End Sub

'    Private Sub ChkPeriodo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPeriodo.CheckedChanged

'        Try

'            If ChkPeriodo.Checked Then
'                DtpHistoticoInicio.Enabled = True
'                DtpHistoticoFinal.Enabled = True
'            Else
'                DtpHistoticoInicio.Enabled = False
'                DtpHistoticoFinal.Enabled = False
'            End If

'        Catch ex As Exception
'            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'        End Try

'    End Sub

'    Private Sub BtnPesquisarHistorico_Click(sender As Object, e As EventArgs) Handles BtnPesquisarHistorico.Click

'        Try

'            Call CarregarGridHistorico()

'        Catch ex As Exception
'            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'        End Try

'    End Sub

'    Private Sub BtnProcurarHistoricoCampo_Click(sender As Object, e As EventArgs) Handles BtnProcurarHistoricoCampo.Click

'        Try

'            Dim sHistoricoCampo As String = TelaProcurar("Procurar campo", "HistoricoDetalhe", {{"Campo", "Campo:String"}}, "Campo", "Campo", "", "HistoricoID IN (SELECT HistoricoID FROM Historico WHERE AcessoID = 100)", "", "Campo")

'            TxtHistoricoCampo.Text = sHistoricoCampo

'        Catch ex As Exception
'            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'        End Try

'    End Sub

'    Private Sub BtnHistoricoUsuario_Click(sender As Object, e As EventArgs) Handles BtnHistoricoUsuario.Click

'        Try

'            Dim sUsuarioID As String = TelaProcurar("Procurar responsável", "Usuario", {{"UsuarioID", "Código:String"}, {"Nome", "Nome:String"}}, "Código", "Nome", sWhere:="Vendedor = 1")

'            Call ProcurarUsuario(sUsuarioID)

'        Catch ex As Exception
'            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'        End Try

'    End Sub

'    Private Sub ProcurarUsuario(sUsuarioID As String)

'        Dim da As New SqlDataAdapter
'        Dim dt As New DataTable

'        Dim sSQL As New StringBuilder

'        Try

'            If sUsuarioID Is Nothing Then
'                GoTo Proximo
'            End If

'            If Not IsNumeric(sUsuarioID) Then
'                GoTo Limpar
'            End If

'            Using cn As New SqlConnection(Database.Conexao)
'                Using cmd As New SqlCommand("", cn)
'                    Try
'                        With cmd
'                            .Connection.Open()
'                            .CommandText = "SELECT TOP 1 UsuarioID, Nome FROM Usuario WHERE UsuarioID = @UsuarioID AND Ativo = 1"

'                            .Parameters.AddWithValue("@UsuarioID", Parse.IsEmpty(sUsuarioID)).SqlDbType = SqlDbType.Int

'                            da = New SqlDataAdapter(cmd)
'                            da.Fill(dt)

'                            If dt.Rows.Count = 0 Then
'                                MsgBox("Usuário não entrado!", vbExclamation, "Atenção")
'                                TxtHistoricoUsuarioID.Select()
'                                GoTo Limpar
'                            Else
'                                GoTo Preencher
'                            End If

'                        End With
'                    Catch ex As Exception
'                        Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'                    End Try
'                End Using
'            End Using

'Preencher:
'            TxtHistoricoUsuarioID.Text = Parse.ToString(dt.Rows(0)("UsuarioID"))
'            TxtHistoricoParceiroDescricao.Text = Parse.ToString(dt.Rows(0)("Nome"))
'            GoTo Proximo
'Limpar:
'            TxtHistoricoUsuarioID.Text = ""
'            TxtHistoricoParceiroDescricao.Text = ""
'Proximo:

'        Catch ex As Exception
'            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'        End Try

'    End Sub

'    Private Sub TxtHistoricoUsuarioID_Leave(sender As Object, e As EventArgs) Handles TxtHistoricoUsuarioID.Leave

'        Try

'            Call ProcurarUsuario(TxtHistoricoUsuarioID.Text)

'        Catch ex As Exception
'            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'        End Try

'    End Sub

'    Private Sub Historico_Enter(sender As Object, e As EventArgs) Handles Arquivos.Enter

'        Try

'            If Not bCarregouHistorico Then
'                Call CarregarGridHistorico()
'            End If

'        Catch ex As Exception
'            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
'        End Try

'    End Sub

'    Private Sub BtnAdicionarEmail_Click(sender As Object, e As EventArgs)

'        'Dim Frm As New FrmEmail With {
'        '.Emails = TxtEmail.Text
'        '}

'        'Frm.ShowDialog()

'        'TxtEmail.Text = Frm.Emails

'    End Sub

'End Class

