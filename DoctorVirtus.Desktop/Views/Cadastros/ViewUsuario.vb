Imports System.ComponentModel
Imports System.Data.Entity
Imports DoctorVirtus.Desktop.HandleDynamic
Imports DoctorVirtus.Model

Public Class ViewUsuario
    Dim Frm As New Forms

    Private ViewModelUsuario As New BindingSource With {.DataSource = GetType(ViewModelUsuario)}

    Dim Tabela As New HandleDynamic.HandleDynamic

    Private Sub ViewOperadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Frm.AddHandler_Dynamic(Me)

            TxtUsuario.DataBindings.Add(New Binding("Text", ViewModelUsuario, "Usuario.Login", True, DataSourceUpdateMode.OnPropertyChanged))
            TxtSenha.DataBindings.Add(New Binding("Text", ViewModelUsuario, "Usuario.Senha", True, DataSourceUpdateMode.OnPropertyChanged))
            ChkExpirado.DataBindings.Add(New Binding("Checked", ViewModelUsuario, "Usuario.Expirado", True, DataSourceUpdateMode.OnPropertyChanged))
            ChkAcessaAplicativo.DataBindings.Add(New Binding("Checked", ViewModelUsuario, "Usuario.AcessaAplicativo", True, DataSourceUpdateMode.OnPropertyChanged))
            ChkAcessaSistema.DataBindings.Add(New Binding("Checked", ViewModelUsuario, "Usuario.AcessaSistema", True, DataSourceUpdateMode.OnPropertyChanged))

            Call BtnLimpar_Click(Nothing, Nothing)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        Try

            ViewModelUsuario.DataSource = New ViewModelUsuario()
            TxtUsuarioID.Text = Nothing

            TxtUsuario.Select()

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Try

            Cursor.Current = Cursors.WaitCursor

            If CType(Me.ViewModelUsuario.DataSource, ViewModelUsuario).Usuario.Login = "" Then
                MsgBox("Informe a usuário!", vbExclamation, "Atenção")
                TxtUsuario.Focus()
                Exit Sub
            End If

            Dim ViewModelUsuario As ViewModelUsuario = Me.ViewModelUsuario.DataSource

            ViewModelUsuario.Usuario.UsuarioID = TxtUsuarioID.IntegerValue

            Using Contexto As New _ContextoBD()
                Contexto.Entry(ViewModelUsuario.Usuario).State = IIf(ViewModelUsuario.Usuario.UsuarioID = 0, EntityState.Added, EntityState.Modified)
                Contexto.SaveChanges()
            End Using

            TxtUsuarioID.Text = ViewModelUsuario.Usuario.UsuarioID

            MsgBox("Usuário " & TxtUsuarioID.Text & " salvo com sucesso!", vbInformation)

            Call BtnLimpar_Click(Nothing, Nothing)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub TxtUsuarioID_Leave(sender As Object, e As EventArgs) Handles TxtUsuarioID.Leave
        Try

            If Not IsNumeric(TxtUsuarioID.Text) Then
                Exit Sub
            End If

            Call ProcurarUsuario(TxtUsuarioID.Text)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub BtnProcurar_Click(sender As Object, e As EventArgs) Handles BtnProcurar.Click
        Try

            Dim UsuarioID As String = TelaProcurar("Usuario")

            Call ProcurarUsuario(UsuarioID)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub ProcurarUsuario(UsuarioID As String)

        If IsNothing(UsuarioID) Then
            Exit Sub
        End If

        Using Contexto As New _ContextoBD()

            Dim Usuario As Usuario = Contexto.Usuario.FirstOrDefault(Function(c) c.UsuarioID = UsuarioID And c.Ativo = True)

            If IsNothing(Usuario) Then
                MsgBox("Usuário não encontrada!", vbExclamation, "Atenção")
                Call BtnLimpar_Click(Nothing, Nothing)
                Exit Sub
            End If

            TxtUsuarioID.Text = UsuarioID

            CType(ViewModelUsuario.DataSource, ViewModelUsuario).Usuario = Usuario

            TxtUsuario.Select()

        End Using
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        Try
            If MsgBox("Tem certeza que deseja excluir?", vbYesNo + vbExclamation) = MsgBoxResult.No Then
                Exit Sub
            End If

            Using Contexto As New _ContextoBD()
                Dim ViewModelUsuario As ViewModelUsuario = Me.ViewModelUsuario.DataSource

                ViewModelUsuario.Usuario.Ativo = False

                Contexto.Entry(ViewModelUsuario.Usuario).State = EntityState.Modified
                Contexto.SaveChanges()

                MsgBox("Excluído com sucesso!", vbInformation)

                Call BtnLimpar_Click(Nothing, Nothing)

            End Using
        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub
End Class

Public Class ViewModelUsuario
    Implements INotifyPropertyChanged

    Private _Usuario As New Usuario

    Public Property Usuario As Usuario
        Get
            Return _Usuario
        End Get
        Set(value As Usuario)
            _Usuario = value
            OnPropertyChanged("Usuario")
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private Sub OnPropertyChanged(ByVal PropertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(PropertyName))
    End Sub
End Class