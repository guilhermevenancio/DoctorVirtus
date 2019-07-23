Imports System.ComponentModel
Imports System.Data.Entity
Imports DoctorVirtus.Desktop.HandleDynamic
Imports DoctorVirtus.Model

Public Class ViewImposto

    Private ViewModelImposto As New BindingSource With {.DataSource = GetType(ViewModelImposto)}

    Dim Tabela As New HandleDynamic.HandleDynamic

    Private Sub ViewOperadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim Frm As New Forms
            Frm.AddHandler_Dynamic(Me)


            TxtDescricao.DataBindings.Add(New Binding("Text", ViewModelImposto, "Imposto.Descricao", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtAliqPF.DataBindings.Add(New Binding("DoubleValue", ViewModelImposto, "Imposto.pAliq_PF", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtAliqPJ.DataBindings.Add(New Binding("DoubleValue", ViewModelImposto, "Imposto.pAliq_PJ", True, DataSourceUpdateMode.OnPropertyChanged))

            Call BtnLimpar_Click(Nothing, Nothing)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        Try

            ViewModelImposto.DataSource = New ViewModelImposto()
            TxtImpostoID.Text = Nothing

            TxtDescricao.Select()

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Try

            Cursor.Current = Cursors.WaitCursor

            If CType(Me.ViewModelImposto.DataSource, ViewModelImposto).Imposto.Descricao = "" Then
                MsgBox("Informe a descrição!", vbExclamation, "Atenção")
                TxtDescricao.Focus()
                Exit Sub
            End If

            Dim ViewModelImposto As ViewModelImposto = Me.ViewModelImposto.DataSource

            ViewModelImposto.Imposto.ImpostoID = TxtImpostoID.IntegerValue

            Using Contexto As New _ContextoBD()
                Contexto.Entry(ViewModelImposto.Imposto).State = IIf(ViewModelImposto.Imposto.ImpostoID = 0, EntityState.Added, EntityState.Modified)
                Contexto.SaveChanges()
            End Using

            TxtImpostoID.Text = ViewModelImposto.Imposto.ImpostoID

            MsgBox("Imposto " & TxtImpostoID.Text & " salvo com sucesso!", vbInformation)

            Call BtnLimpar_Click(Nothing, Nothing)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub TxtImpostoID_Leave(sender As Object, e As EventArgs) Handles TxtImpostoID.Leave
        Try

            If Not IsNumeric(TxtImpostoID.Text) Then
                Exit Sub
            End If

            Call ProcurarImposto(TxtImpostoID.Text)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub BtnProcurar_Click(sender As Object, e As EventArgs) Handles BtnProcurar.Click
        Try

            Dim TabelaID As String = TelaProcurar("Tabela")

            Call ProcurarImposto(TabelaID)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub ProcurarImposto(ImpostoID As String)

        If IsNothing(ImpostoID) Then
            Exit Sub
        End If

        Using Contexto As New _ContextoBD()

            Dim Imposto As Imposto = Contexto.Imposto.FirstOrDefault(Function(c) c.ImpostoID = ImpostoID And c.Ativo = True)

            If IsNothing(Imposto) Then
                MsgBox("Imposto não encontrado!", vbExclamation, "Atenção")
                Call BtnLimpar_Click(Nothing, Nothing)
                Exit Sub
            End If

            TxtImpostoID.Text = ImpostoID

            CType(ViewModelImposto.DataSource, ViewModelImposto).Imposto = Imposto

            TxtDescricao.Select()

        End Using
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        Try
            If MsgBox("Tem certeza que deseja excluir?", vbYesNo + vbExclamation) = MsgBoxResult.No Then
                Exit Sub
            End If

            Using Contexto As New _ContextoBD()
                Dim ViewModelImposto As ViewModelImposto = Me.ViewModelImposto.DataSource

                ViewModelImposto.Imposto.Ativo = False

                Contexto.Entry(ViewModelImposto.Imposto).State = EntityState.Modified
                Contexto.SaveChanges()

                MsgBox("Excluído com sucesso!", vbInformation)

                Call BtnLimpar_Click(Nothing, Nothing)

            End Using
        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub
End Class

Public Class ViewModelImposto
    Implements INotifyPropertyChanged

    Private _Imposto As New Imposto

    Public Property Imposto As Imposto
        Get
            Return _Imposto
        End Get
        Set(value As Imposto)
            _Imposto = value
            OnPropertyChanged("Imposto")
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private Sub OnPropertyChanged(ByVal PropertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(PropertyName))
    End Sub
End Class