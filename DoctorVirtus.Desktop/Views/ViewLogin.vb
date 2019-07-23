Public Class ViewLogin

    Dim Frm As New HandleDynamic.Forms

    Private Sub ViewLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Frm.AddHandler_Dynamic(Me)

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjcwOTVAMzEzNjJlMzQyZTMwZ1JIdEFKY3BSc0REV04rb1ZqV0tBa3g1SGVsWml5Vi91MzZkaFEzK0N0QT0=")

            Call CarregarConexao()

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try

    End Sub

    Private Async Sub CarregarConexao()

        Dim connectionString = "Data Source=doctorvirtus.database.windows.net;Initial Catalog=DoctorVirtus;User ID=user;Password=@Rped94ft;Min Pool Size=3;Max Pool Size=3;Connection Reset=True;Connection Lifetime=0;Connect Timeout=30;Current Language=Portuguese;"
        'Dim connectionString = "Data Source=C:\DoctorVirtus\Database.sdf;Password=@Rped94ft"

        Dim iTentativa As Integer = 0

        Try

            Carregando.Visible = True

            Database.Conexao = connectionString
            Call SetConnectionString(connectionString)

            Dim Result As Boolean = Await Task.Run(Function() As Boolean
TentaNovamente:
                                                       iTentativa += 1

                                                       Try

                                                           Using Contexto As New _ContextoBD()
                                                               Contexto.Atualizar()
                                                               Contexto.Database.ExecuteSqlCommand("SELECT 1;")
                                                           End Using

                                                           Return True
                                                       Catch ex As Exception
                                                           If iTentativa <= 2 Then GoTo TentaNovamente
                                                           Call GravaLOG(ex, Me.Name, GetCurrentMethodName(), False)
                                                           Return False
                                                       End Try

                                                   End Function)

            If Result Then
                LblOnline.ForeColor = Color.Green
                LblOnline.Text = "Online"
            Else
                LblOnline.ForeColor = Color.Red
                LblOnline.Text = "Offline"
            End If

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        Finally
            Carregando.Visible = False
        End Try

    End Sub

    Private Async Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles BtnEntrar.Click

        Try

            Cursor = Cursors.WaitCursor

            If LblOnline.Text = "Offline" Then
                MsgBox("O banco está offline!", vbExclamation, "Atenção")
                Exit Sub
            End If

            If TxtUsuario.Text = "" Then
                MsgBox("Por favor, informe o seu usuário!", vbExclamation, "Atenção")
                TxtUsuario.Select()
                Exit Sub
            End If

            If TxtSenha.Text = "" Then
                MsgBox("Por favor, informe a sua senha!", vbExclamation, "Atenção")
                TxtSenha.Select()
                Exit Sub
            End If

            Call VerificaVersao()

            Using Contexto As New _ContextoBD()

                'Após a primeira verificação, o sistema irá verificar a cada 10 minutos automaticamente
                'Dim VerificaVersaoAutomatico As New Timers.Timer(600000)
                'AddHandler VerificaVersaoAutomatico.Elapsed, AddressOf VerificaVersaoAsync
                'VerificaVersaoAutomatico.Enabled = True

                Dim Usuario As Usuario = Await Task.Run(Function() As Usuario
                                                            Return Contexto.Usuario.FirstOrDefault(Function(c) c.Login = TxtUsuario.Text And c.Senha = TxtSenha.Text)
                                                        End Function)

                If IsNothing(Usuario) Then
                    MsgBox("Usuário ou senha errado!", vbExclamation, "Atenção")
                    TxtSenha.Text = ""
                    TxtSenha.Focus()
                    Exit Sub
                End If

                'If Usuario.Expirado Then
                '    MsgBox("Usuário expirado, verifique com o administrador do sistema!", vbExclamation, "Atenção")
                '    Exit Sub
                'End If

                UsuarioLogado = Usuario

            End Using

            Hide()
            ViewSaude.Show()

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        Finally
            Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Try

            Application.Exit()

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub TxtSenha_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSenha.KeyDown

        Try

            If e.KeyCode = Keys.Enter Then
                Call BtnEntrar_Click(Nothing, Nothing)
            End If

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try

    End Sub

End Class