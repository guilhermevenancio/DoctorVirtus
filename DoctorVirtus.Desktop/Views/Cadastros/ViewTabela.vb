Imports System.ComponentModel
Imports System.Data.Entity
Imports DoctorVirtus.Desktop.HandleDynamic
Imports DoctorVirtus.Model

Public Class ViewTabela

    Private ViewModelTabela As New BindingSource With {.DataSource = GetType(ViewModelTabela)}

    Dim Tabela As New HandleDynamic.HandleDynamic

    Private Sub ViewOperadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim Frm As New Forms
            Frm.AddHandler_Dynamic(Me)


            TxtDescricao.DataBindings.Add(New Binding("Text", ViewModelTabela, "Tabela.Descricao", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtValorCHUCO.DataBindings.Add(New Binding("DoubleValue", ViewModelTabela, "Tabela.ValorCH_UCO", True, DataSourceUpdateMode.OnPropertyChanged))

            Call BtnLimpar_Click(Nothing, Nothing)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        Try

            ViewModelTabela.DataSource = New ViewModelTabela()
            TxtTabelaID.Text = Nothing

            TxtDescricao.Select()

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Try

            Cursor.Current = Cursors.WaitCursor

            If CType(Me.ViewModelTabela.DataSource, ViewModelTabela).Tabela.Descricao = "" Then
                MsgBox("Informe a descrição!", vbExclamation, "Atenção")
                TxtDescricao.Focus()
                Exit Sub
            End If

            Dim ViewModelTabela As ViewModelTabela = Me.ViewModelTabela.DataSource

            ViewModelTabela.Tabela.TabelaID = TxtTabelaID.IntegerValue

            Using Contexto As New _ContextoBD()
                Contexto.Entry(ViewModelTabela.Tabela).State = IIf(ViewModelTabela.Tabela.TabelaID = 0, EntityState.Added, EntityState.Modified)
                Contexto.SaveChanges()
            End Using

            TxtTabelaID.Text = ViewModelTabela.Tabela.TabelaID

            MsgBox("Operadora " & TxtTabelaID.Text & " salvo com sucesso!", vbInformation)

            Call BtnLimpar_Click(Nothing, Nothing)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub TxtTabelaID_Leave(sender As Object, e As EventArgs) Handles TxtTabelaID.Leave
        Try

            If Not IsNumeric(TxtTabelaID.Text) Then
                Exit Sub
            End If

            Call ProcurarTabela(TxtTabelaID.Text)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub BtnProcurar_Click(sender As Object, e As EventArgs) Handles BtnProcurar.Click
        Try

            Dim TabelaID As String = TelaProcurar("Tabela")

            Call ProcurarTabela(TabelaID)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub ProcurarTabela(TabelaID As String)

        If IsNothing(TabelaID) Then
            Exit Sub
        End If

        Using Contexto As New _ContextoBD()

            Dim Tabela As Tabela = Contexto.Tabela.FirstOrDefault(Function(c) c.TabelaID = TabelaID And c.Ativo = True)

            If IsNothing(Tabela) Then
                MsgBox("Tabela não encontrada!", vbExclamation, "Atenção")
                Call BtnLimpar_Click(Nothing, Nothing)
                Exit Sub
            End If

            TxtTabelaID.Text = TabelaID

            CType(ViewModelTabela.DataSource, ViewModelTabela).Tabela = Tabela

            TxtDescricao.Select()

        End Using
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        Try
            If MsgBox("Tem certeza que deseja excluir?", vbYesNo + vbExclamation) = MsgBoxResult.No Then
                Exit Sub
            End If

            Using Contexto As New _ContextoBD()
                Dim ViewModelTabela As ViewModelTabela = Me.ViewModelTabela.DataSource

                ViewModelTabela.Tabela.Ativo = False

                Contexto.Entry(ViewModelTabela.Tabela).State = EntityState.Modified
                Contexto.SaveChanges()

                MsgBox("Excluído com sucesso!", vbInformation)

                Call BtnLimpar_Click(Nothing, Nothing)

            End Using
        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub
End Class

Public Class ViewModelTabela
    Implements INotifyPropertyChanged

    Private _Tabela As New Tabela

    Public Property Tabela As Tabela
        Get
            Return _Tabela
        End Get
        Set(value As Tabela)
            _Tabela = value
            OnPropertyChanged("Tabela")
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private Sub OnPropertyChanged(ByVal PropertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(PropertyName))
    End Sub
End Class