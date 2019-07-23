Imports System.ComponentModel
Imports System.Data.Entity
Imports DoctorVirtus.Desktop.HandleDynamic
Imports DoctorVirtus.Model

Public Class ViewOperadora
    Dim Frm As New Forms

    Private ViewModelOperadora As New BindingSource With {.DataSource = GetType(ViewModelOperadora)}

    Dim Tabela As New HandleDynamic.HandleDynamic

    Private Sub ViewOperadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Frm.AddHandler_Dynamic(Me)

            TxtDescricao.DataBindings.Add(New Binding("Text", ViewModelOperadora, "Operadora.Descricao", True, DataSourceUpdateMode.OnPropertyChanged))
            CboVersaoXML.DataBindings.Add(New Binding("SelectedIndex", ViewModelOperadora, "Operadora.VersaoXML", True, DataSourceUpdateMode.OnPropertyChanged))

            Call BtnLimpar_Click(Nothing, Nothing)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        Try

            ViewModelOperadora.DataSource = New ViewModelOperadora()
            TxtOperadoraID.Text = Nothing

            TxtDescricao.Select()

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Try

            Cursor.Current = Cursors.WaitCursor

            If CType(Me.ViewModelOperadora.DataSource, ViewModelOperadora).Operadora.Descricao = "" Then
                MsgBox("Informe a descrição!", vbExclamation, "Atenção")
                TxtDescricao.Focus()
                Exit Sub
            End If

            Dim ViewModelOperadora As ViewModelOperadora = Me.ViewModelOperadora.DataSource

            ViewModelOperadora.Operadora.OperadoraID = TxtOperadoraID.IntegerValue

            Using Contexto As New _ContextoBD()
                Contexto.Entry(ViewModelOperadora.Operadora).State = IIf(ViewModelOperadora.Operadora.OperadoraID = 0, EntityState.Added, EntityState.Modified)
                Contexto.SaveChanges()
            End Using

            TxtOperadoraID.Text = ViewModelOperadora.Operadora.OperadoraID

            MsgBox("Operadora " & TxtOperadoraID.Text & " salvo com sucesso!", vbInformation)

            Call BtnLimpar_Click(Nothing, Nothing)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub TxtOperadoraID_Leave(sender As Object, e As EventArgs) Handles TxtOperadoraID.Leave
        Try

            If Not IsNumeric(TxtOperadoraID.Text) Then
                Exit Sub
            End If

            Call ProcurarOperadora(TxtOperadoraID.Text)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub BtnProcurar_Click(sender As Object, e As EventArgs) Handles BtnProcurar.Click
        Try

            Dim OperadoraID As String = TelaProcurar("Operadora")

            Call ProcurarOperadora(OperadoraID)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub ProcurarOperadora(OperadoraID As String)

        If IsNothing(OperadoraID) Then
            Exit Sub
        End If

        Using Contexto As New _ContextoBD()

            Dim Operadora As Operadora = Contexto.Operadora.FirstOrDefault(Function(c) c.OperadoraID = OperadoraID And c.Ativo = True)

            If IsNothing(Operadora) Then
                MsgBox("Operadora não encontrada!", vbExclamation, "Atenção")
                Call BtnLimpar_Click(Nothing, Nothing)
                Exit Sub
            End If

            TxtOperadoraID.Text = OperadoraID

            CType(ViewModelOperadora.DataSource, ViewModelOperadora).Operadora = Operadora

            TxtDescricao.Select()

        End Using
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        Try
            If MsgBox("Tem certeza que deseja excluir?", vbYesNo + vbExclamation) = MsgBoxResult.No Then
                Exit Sub
            End If

            Using Contexto As New _ContextoBD()
                Dim ViewModelOperadora As ViewModelOperadora = Me.ViewModelOperadora.DataSource

                ViewModelOperadora.Operadora.Ativo = False

                Contexto.Entry(ViewModelOperadora.Operadora).State = EntityState.Modified
                Contexto.SaveChanges()

                MsgBox("Excluído com sucesso!", vbInformation)

                Call BtnLimpar_Click(Nothing, Nothing)

            End Using
        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub
End Class

Public Class ViewModelOperadora
    Implements INotifyPropertyChanged

    Private _Operadora As New Operadora

    Public Property Operadora As Operadora
        Get
            Return _Operadora
        End Get
        Set(value As Operadora)
            _Operadora = value
            OnPropertyChanged("Operadora")
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private Sub OnPropertyChanged(ByVal PropertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(PropertyName))
    End Sub
End Class