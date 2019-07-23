Imports System.ComponentModel
Imports System.Data.Entity
Imports DoctorVirtus.Desktop.HandleDynamic
Imports Syncfusion.GridHelperClasses
Imports Syncfusion.Windows.Forms.Grid.Grouping

Public Class ViewProcedimento

    Private Frm As New Forms
    Private Tabela As New HandleDynamic.HandleDynamic

    Private ViewModelProcedimento As New BindingSource With {.DataSource = GetType(ViewModelProcedimento)}

    Private Sub FrmProcedimento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Frm.AddHandler_Dynamic(Me)
            Tabela.AddHandler_Dynamic(eTipoCampo.Tabela, TxtTabelaID, TxtTabelaDescricao, BtnProcurarTabela)

            TxtDescricao.DataBindings.Add(New Binding("Text", ViewModelProcedimento, "Procedimento.Descricao", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtCodigoTUSS.DataBindings.Add(New Binding("Text", ViewModelProcedimento, "Procedimento.CodigoTUSS", True, DataSourceUpdateMode.OnPropertyChanged))

            Call MontaGridNegociacao()

            Call BtnLimpar_Click(Nothing, Nothing)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub MontaGridNegociacao()

        ActiveControl = GridDePara.TableControl
        GridDePara.WantTabKey = False

        Dim GridGroupingFilter As New GridExcelFilter With {
            .EnableStackedColumnFilterIcon = True
        }

        GridGroupingFilter.WireGrid(Me.GridDePara)

        With GridDePara
            .TableDescriptor.Columns.Add(New GridColumnDescriptor() With {.MappingName = "Referencia", .HeaderText = "Referência", .Width = 90, .AllowFilter = True})
            .TableDescriptor.Columns.Add(New GridColumnDescriptor() With {.MappingName = "Tabela.Descricao", .HeaderText = "Tabela", .Width = 90, .AllowFilter = True})
            .TableDescriptor.Columns.Add(New GridColumnDescriptor() With {.MappingName = "QuantidadeCH_UCO", .HeaderText = "CH/UCO", .Width = 85, .AllowFilter = True})
            .TableDescriptor.Columns.Add(New GridColumnDescriptor() With {.MappingName = "QuantidadeFilmeM2", .HeaderText = "Filme m²", .Width = 85, .AllowFilter = True})
        End With

    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        Try

            ViewModelProcedimento.DataSource = New ViewModelProcedimento()
            TxtProcedimentoID.Text = Nothing

            Call LimparProcedimento()

            CType(ViewModelProcedimento.DataSource, ViewModelProcedimento).Procedimento.ProcedimentoItem = New List(Of ProcedimentoItem)
            GridDePara.DataSource = CType(ViewModelProcedimento.DataSource, ViewModelProcedimento).Procedimento.ProcedimentoItem.ToList()

            TxtCodigoTUSS.Select()

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Try

            Cursor.Current = Cursors.WaitCursor

            If CType(Me.ViewModelProcedimento.DataSource, ViewModelProcedimento).Procedimento.Descricao = "" Then
                MsgBox("Informe a descrição!", vbExclamation, "Atenção")
                TxtDescricao.Focus()
                Exit Sub
            End If

            Dim ViewModelProcedimento As ViewModelProcedimento = Me.ViewModelProcedimento.DataSource

            ViewModelProcedimento.Procedimento.ProcedimentoID = TxtProcedimentoID.IntegerValue

            Using Contexto As New _ContextoBD()

                Dim ProcedimentoItem As List(Of ProcedimentoItem) = ViewModelProcedimento.Procedimento.ProcedimentoItem.ToList()

                ViewModelProcedimento.Procedimento.ProcedimentoItem.Clear()

                If ViewModelProcedimento.Procedimento.ProcedimentoID = 0 Then
                    Contexto.Procedimento.Add(ViewModelProcedimento.Procedimento)
                Else
                    Contexto.Procedimento.Attach(ViewModelProcedimento.Procedimento)
                    Contexto.Entry(ViewModelProcedimento.Procedimento).State = EntityState.Modified
                End If

                Contexto.SaveChanges()

                For Each Row In ProcedimentoItem
                    Row.ProcedimentoID = ViewModelProcedimento.Procedimento.ProcedimentoID
                    Row.Tabela = Nothing
                Next

                Contexto.ProcedimentoItem.RemoveRange(Contexto.ProcedimentoItem.Where(Function(c) c.ProcedimentoID = ViewModelProcedimento.Procedimento.ProcedimentoID))
                Contexto.ProcedimentoItem.AddRange(ProcedimentoItem)

                Contexto.SaveChanges()

            End Using

            TxtProcedimentoID.Text = ViewModelProcedimento.Procedimento.ProcedimentoID

            MsgBox("Procedimento " & TxtProcedimentoID.Text & " salvo com sucesso!", vbInformation)

            Call BtnLimpar_Click(Nothing, Nothing)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub TxtProdutoID_Leave(sender As Object, e As EventArgs) Handles TxtProcedimentoID.Leave
        Try

            If Not IsNumeric(TxtProcedimentoID.Text) Then
                Exit Sub
            End If

            Call ProcurarProcedimento(TxtProcedimentoID.Text)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub BtnProcurar_Click(sender As Object, e As EventArgs) Handles BtnProcurar.Click
        Try

            Dim sProdutoID As String = TelaProcurar("Procedimento")

            Call ProcurarProcedimento(sProdutoID)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub ProcurarProcedimento(ProcedimentoID As String)

        If IsNothing(ProcedimentoID) Then
            Exit Sub
        End If

        Using Contexto As New _ContextoBD()

            Dim Procedimento As Procedimento = Contexto.Procedimento.Include("ProcedimentoItem").Include("ProcedimentoItem.Tabela").FirstOrDefault(Function(c) c.ProcedimentoID = ProcedimentoID And c.Ativo = True)

            If IsNothing(Procedimento) Then
                MsgBox("Procedimento não encontrado!", vbExclamation, "Atenção")
                Call BtnLimpar_Click(Nothing, Nothing)
                Exit Sub
            End If

            TxtProcedimentoID.Text = ProcedimentoID

            CType(ViewModelProcedimento.DataSource, ViewModelProcedimento).Procedimento = Procedimento
            GridDePara.DataSource = CType(ViewModelProcedimento.DataSource, ViewModelProcedimento).Procedimento.ProcedimentoItem.OrderBy(Function(c) c.Tabela.Descricao).ToList()
            TxtDescricao.Select()

        End Using

    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        Try
            If MsgBox("Tem certeza que deseja excluir?", vbYesNo + vbExclamation) = MsgBoxResult.No Then
                Exit Sub
            End If

            Dim ViewModelProcedimento As ViewModelProcedimento = Me.ViewModelProcedimento.DataSource

            ViewModelProcedimento.Procedimento.Ativo = False

            Using Contexto As New _ContextoBD()
                Contexto.Entry(ViewModelProcedimento.Procedimento).State = EntityState.Modified
                Contexto.SaveChanges()
            End Using

            MsgBox("Excluído com sucesso!", vbInformation)

            Call BtnLimpar_Click(Nothing, Nothing)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub BtnAdicionarProcedimento_Click(sender As Object, e As EventArgs) Handles BtnAdicionarProcedimento.Click
        Try

            If TxtReferencia.Text.Trim() = "" Then
                MsgBox("Informe a referência!", vbExclamation, "Atenção")
                TxtReferencia.Select()
                Exit Sub
            End If

            If Not IsNumeric(TxtTabelaID.Text) Then
                MsgBox("Informe a tabela!", vbExclamation, "Atenção")
                TxtTabelaID.Select()
                Exit Sub
            End If

            Dim ProcedimentoItem As New ProcedimentoItem With {
                .Referencia = TxtReferencia.Text,
                .TabelaID = TxtTabelaID.Text,
                .Tabela = New Tabela With {.TabelaID = TxtTabelaID.Text, .Descricao = TxtTabelaDescricao.Text},
                .QuantidadeCH_UCO = TxtCHUCO.DoubleValue,
                .QuantidadeFilmeM2 = TxtFilmeM2.DoubleValue
            }

            Call LimparProcedimento()

            CType(ViewModelProcedimento.DataSource, ViewModelProcedimento).Procedimento.ProcedimentoItem.Add(ProcedimentoItem)
            GridDePara.DataSource = CType(ViewModelProcedimento.DataSource, ViewModelProcedimento).Procedimento.ProcedimentoItem.OrderBy(Function(c) c.Tabela.Descricao).ToList()

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub BtnRemoverProcedimento_Click(sender As Object, e As EventArgs) Handles BtnRemoverProcedimento.Click
        Try

            If MsgBox("Tem certeza que deseja remover?", vbExclamation + vbYesNo, "Atenção") = MsgBoxResult.No Then Exit Sub

            If GridDePara.Table.SelectedRecords.Count > 0 Then
                For Each selectedRecord As Syncfusion.Grouping.SelectedRecord In GridDePara.Table.SelectedRecords
                    CType(ViewModelProcedimento.DataSource, ViewModelProcedimento).Procedimento.ProcedimentoItem.Remove(selectedRecord.Record.GetData())
                Next
            End If

            GridDePara.DataSource = CType(ViewModelProcedimento.DataSource, ViewModelProcedimento).Procedimento.ProcedimentoItem.ToList()

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub LimparProcedimento()
        Try

            TxtReferencia.Text = Nothing
            TxtTabelaID.Text = Nothing
            TxtTabelaDescricao.Text = Nothing
            TxtCHUCO.DoubleValue = 0
            TxtFilmeM2.DoubleValue = 0

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub
End Class

Public Class ViewModelProcedimento
    Implements INotifyPropertyChanged

    Private _Procedimento As New Procedimento

    Public Property Procedimento As Procedimento
        Get
            Return _Procedimento
        End Get
        Set(value As Procedimento)
            _Procedimento = value
            OnPropertyChanged("Procedimento")
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private Sub OnPropertyChanged(ByVal PropertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(PropertyName))
    End Sub
End Class