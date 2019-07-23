Imports System.Text
Imports Syncfusion.Windows.Forms.Tools

Namespace HandleDynamic

    Public Enum eTipoCampo
        Usuario
        Prestador
        Procedimento
        Tabela
        Operadora
        LocalAtendimento
    End Enum

    Public Class HandleDynamic
        Public OldValue As String = ""

        Public sLeftJoin As String = ""
        Public sWhere As String = ""
        Public Dados As New DataTable

        Public TextBoxID As TextBox
        Public ButtonProcurar As Button
        Private TextBoxDescricao As TextBox

        Public TipoCampo As eTipoCampo
        Public HandleCampo As String

        Public Overridable Function QualTelaProcurar() As String

            If TipoCampo = eTipoCampo.Usuario Then
                Return TelaProcurar("Usuario")
            End If

            If TipoCampo = eTipoCampo.Prestador Then
                Return TelaProcurar("Prestador")
            End If

            If TipoCampo = eTipoCampo.Procedimento Then
                Return TelaProcurar("Procedimento")
            End If

            If TipoCampo = eTipoCampo.Tabela Then
                Return TelaProcurar("Tabela")
            End If

            If TipoCampo = eTipoCampo.Operadora Then
                Return TelaProcurar("Operadora")
            End If

            If TipoCampo = eTipoCampo.LocalAtendimento Then
                Return TelaProcurar("LocalAtendimento")
            End If

            Return Nothing

        End Function

        Private Function MontaQuery() As String

            Dim sSQL As New StringBuilder

            If TipoCampo = eTipoCampo.Usuario Then
                Return "SELECT TOP 1 Usuario.UsuarioID AS ID, Usuario.Login AS Descricao FROM Usuario WHERE Usuario.UsuarioID = @ID AND Usuario.Ativo = 1"
            End If

            If TipoCampo = eTipoCampo.Prestador Then
                Return "SELECT TOP 1 Prestador.PrestadorID AS ID, Prestador.RazaoSocial AS Descricao FROM Prestador WHERE Prestador.PrestadorID = @ID AND Prestador.Ativo = 1"
            End If

            If TipoCampo = eTipoCampo.Procedimento Then
                Return "SELECT TOP 1 Procedimento.ProcedimentoID AS ID, Procedimento.Descricao AS Descricao FROM Procedimento WHERE Procedimento.ProcedimentoID = @ID AND Procedimento.Ativo = 1"
            End If

            If TipoCampo = eTipoCampo.Tabela Then
                Return "SELECT TOP 1 Tabela.TabelaID AS ID, Tabela.Descricao AS Descricao FROM Tabela WHERE Tabela.TabelaID = @ID AND Tabela.Ativo = 1"
            End If

            If TipoCampo = eTipoCampo.Operadora Then
                Return "SELECT TOP 1 Operadora.OperadoraID AS ID, Operadora.Descricao AS Descricao FROM Operadora WHERE Operadora.OperadoraID = @ID AND Operadora.Ativo = 1"
            End If

            If TipoCampo = eTipoCampo.LocalAtendimento Then
                Return "SELECT TOP 1 LocalAtendimento.LocalAtendimentoID AS ID, LocalAtendimento.RazaoSocial AS Descricao FROM LocalAtendimento WHERE LocalAtendimento.LocalAtendimentoID = @ID AND LocalAtendimento.Ativo = 1"
            End If

            Return ""

        End Function

        Public Sub AddHandler_Dynamic(TipoCampo As eTipoCampo, TextBoxID As TextBox, TextBoxDescricao As TextBox, ButtonProcurar As Button, Optional sWhere As String = "")

            Me.TipoCampo = TipoCampo
            Me.TextBoxID = TextBoxID
            Me.ButtonProcurar = ButtonProcurar
            Me.TextBoxDescricao = TextBoxDescricao
            Me.sWhere = sWhere

            Call SelectTipoCampo(Me.TipoCampo)

            AddHandler TextBoxID.Enter, AddressOf TextBoxID_Enter
            AddHandler TextBoxID.Leave, AddressOf TextBoxID_Leave
            AddHandler TextBoxID.KeyDown, AddressOf TextBoxID_KeyDown

            AddHandler ButtonProcurar.Click, AddressOf ButtonProcurar_Click

        End Sub

        Public Overridable Sub SelectTipoCampo(TipoCampo As eTipoCampo)
            Select Case TipoCampo
                Case eTipoCampo.Usuario
                    HandleCampo = "Usuário"
                Case eTipoCampo.Prestador
                    HandleCampo = "Prestador"
                Case eTipoCampo.Procedimento
                    HandleCampo = "Procedimento"
                Case eTipoCampo.Tabela
                    HandleCampo = "Tabela"
                Case eTipoCampo.Tabela
                    HandleCampo = "Operadora"
                Case eTipoCampo.LocalAtendimento
                    HandleCampo = "Local de atendimento"

            End Select
        End Sub

        Public Overridable Sub TextBoxID_KeyDown(sender As Object, e As KeyEventArgs)

            Try

                If e.KeyCode = Keys.F2 Then
                    Call ButtonProcurar_Click(Nothing, Nothing)
                End If

            Catch ex As Exception
                Call GravaLOG(ex, "HandleDynamic", GetCurrentMethodName())
            End Try

        End Sub

        Public Overridable Function HandleDynamic_TelaProcurar() As String

            Try

                Cursor.Current = Cursors.WaitCursor

                Dim ID As String = QualTelaProcurar()

                Call Procurar(ID)

                Return ID

            Catch ex As Exception
                Call GravaLOG(ex, "HandleDynamic", GetCurrentMethodName())
                Return Nothing
            Finally
                Cursor.Current = Cursors.Default
            End Try

        End Function

        Public Overridable Sub TextBoxID_Enter(ByVal sender As Object, ByVal e As EventArgs)
            Try

                OldValue = TextBoxID.Text

            Catch ex As Exception
                Call GravaLOG(ex, "HandleDynamic", GetCurrentMethodName())
            End Try
        End Sub

        Public Overridable Sub TextBoxID_Leave(ByVal sender As Object, ByVal e As EventArgs)

            Try

                Cursor.Current = Cursors.WaitCursor

                If OldValue <> TextBoxID.Text Then
                    Call Procurar(TextBoxID.Text)
                End If

            Catch ex As Exception
                Call GravaLOG(ex, "HandleDynamic", GetCurrentMethodName())
            Finally
                Cursor.Current = Cursors.Default
            End Try

        End Sub

        Public Overridable Sub ButtonProcurar_Click(sender As Object, e As EventArgs)

            Try

                If Not IsNothing(HandleDynamic_TelaProcurar()) Then
                    SendKeys.Send("{TAB}")
                Else
                    TextBoxID.Select()
                End If

            Catch ex As Exception
                Call GravaLOG(ex, "HandleDynamic", GetCurrentMethodName())
            End Try

        End Sub

        Public Overridable Sub Procurar(ID As String)

            Try

                Cursor.Current = Cursors.WaitCursor

                If ID Is Nothing Then
                    GoTo Proximo
                End If

                If Not IsNumeric(ID) Then
                    GoTo Limpar
                End If

                Dados = Database.Execute(MontaQuery(), {
                    {"@ID", ID, SqlDbType.Int}
                }).Tables(0)

                If Dados.Rows.Count = 0 Then
                    MsgBox(HandleCampo & " não encontrado(a)!", vbExclamation, "Atenção")
                    TextBoxID.Select()
                    GoTo Limpar
                Else
                    GoTo Preencher
                End If

Preencher:
                TextBoxID.Text = Parse.ToString(Dados.Rows(0)("ID"))
                TextBoxDescricao.Text = Parse.ToString(Dados.Rows(0)("Descricao"))

                GoTo Proximo
Limpar:
                TextBoxID.Text = ""
                TextBoxDescricao.Text = ""

Proximo:

            Catch ex As Exception
                Call GravaLOG(ex, "HandleDynamic", GetCurrentMethodName())
            Finally
                Cursor.Current = Cursors.Default
            End Try

        End Sub

    End Class

    Public Class HandleDynamicExtends
        Inherits HandleDynamic

        Private Campos(,) As Object

        Private Function MontaQuery() As String

            Dim sSQL As New StringBuilder

            For i As Integer = 0 To Campos.GetUpperBound(0)
                sSQL.AppendLine(Campos(i, 0) & " ,")
            Next

            If TipoCampo = eTipoCampo.Usuario Then
                Return "SELECT TOP 1 " & sSQL.ToString() & " Usuario.UsuarioID AS ID FROM Usuario " & sLeftJoin & " WHERE Usuario.UsuarioID = @ID AND Usuario.Ativo = 1"
            End If

            If TipoCampo = eTipoCampo.Prestador Then
                Return "SELECT TOP 1 " & sSQL.ToString() & " Prestador.PrestadorID AS ID FROM Prestador " & sLeftJoin & " WHERE Prestador.PrestadorID = @ID AND Prestador.Ativo = 1"
            End If

            If TipoCampo = eTipoCampo.Procedimento Then
                Return "SELECT TOP 1 " & sSQL.ToString() & " Procedimento.ProcedimentoID AS ID FROM Procedimento " & sLeftJoin & " WHERE Procedimento.ProcedimentoID = @ID AND Procedimento.Ativo = 1"
            End If

            If TipoCampo = eTipoCampo.Tabela Then
                Return "SELECT TOP 1 " & sSQL.ToString() & " Procedimento.TabelaID AS ID FROM Tabela " & sLeftJoin & " WHERE Tabela.TabelaID = @ID AND Tabela.Ativo = 1"
            End If

            If TipoCampo = eTipoCampo.Operadora Then
                Return "SELECT TOP 1 " & sSQL.ToString() & " Operadora.OperadoraID AS ID FROM Operadora " & sLeftJoin & " WHERE Operadora.OperadoraID = @ID AND Operadora.Ativo = 1"
            End If

            If TipoCampo = eTipoCampo.LocalAtendimento Then
                Return "SELECT TOP 1 " & sSQL.ToString() & " LocalAtendimento.LocalAtendimentoID AS ID FROM LocalAtendimento " & sLeftJoin & " WHERE LocalAtendimento.LocalAtendimentoID = @ID AND LocalAtendimento.Ativo = 1"
            End If

            Return ""

        End Function

        Public Sub AddHandler_Dynamic2(TipoCampo As eTipoCampo, TextBoxID As TextBox, ButtonProcurar As Button, Campos(,) As Object, Optional sLeftJoin As String = "", Optional sWhere As String = "")

            Me.TipoCampo = TipoCampo
            Me.TextBoxID = TextBoxID
            Me.ButtonProcurar = ButtonProcurar
            Me.Campos = Campos
            Me.sLeftJoin = sLeftJoin
            Me.sWhere = sWhere

            Call SelectTipoCampo(Me.TipoCampo)

            AddHandler TextBoxID.Enter, AddressOf TextBoxID_Enter
            AddHandler TextBoxID.Leave, AddressOf TextBoxID_Leave
            AddHandler TextBoxID.KeyDown, AddressOf TextBoxID_KeyDown

            AddHandler ButtonProcurar.Click, AddressOf ButtonProcurar_Click

        End Sub

        Public Overrides Sub Procurar(ID As String)

            Try

                Cursor.Current = Cursors.WaitCursor

                If ID Is Nothing Then
                    GoTo Proximo
                End If

                If Not IsNumeric(ID) Then
                    GoTo Limpar
                End If

                Dados = Database.Execute(MontaQuery(), {
                    {"@ID", ID, SqlDbType.Int}
                }).Tables(0)

                If Dados.Rows.Count = 0 Then
                    MsgBox(HandleCampo & " não encontrado(a)!", vbExclamation, "Atenção")
                    TextBoxID.Select()
                    GoTo Limpar
                Else
                    GoTo Preencher
                End If

Preencher:
                TextBoxID.Text = Parse.ToString(Dados.Rows(0)("ID"))

                For i As Integer = 0 To Campos.GetUpperBound(0)

                    Dim Coluna As String = Campos(i, 0).Substring(Campos(i, 0).LastIndexOf("AS ") + 3)

                    If TypeOf Campos(i, 1) Is TextBox Then
                        CType(Campos(i, 1), TextBox).Text = Parse.ToString(Dados.Rows(0)(Coluna))
                    End If

                    If TypeOf (Campos(i, 1)) Is MaskedTextBox Then
                        CType(Campos(i, 1), MaskedTextBox).Text = Parse.ToString(Dados.Rows(0)(Coluna))
                    End If

                    'If TypeOf (Campos(i, 1)) Is MaskedEditBox Then
                    '    CType(Campos(i, 1), MaskedEditBox).Text = Parse.ToString(Dados.Rows(0)(Coluna))
                    'End If

                    If TypeOf (Campos(i, 1)) Is IntegerTextBox Then
                        CType(Campos(i, 1), IntegerTextBox).Text = Parse.ToString(Dados.Rows(0)(Coluna))
                    End If

                    If TypeOf (Campos(i, 1)) Is DoubleTextBox Then
                        CType(Campos(i, 1), DoubleTextBox).Text = Parse.ToString(Dados.Rows(0)(Coluna))
                    End If

                Next

                GoTo Proximo
Limpar:
                TextBoxID.Text = ""


                For i As Integer = 0 To Campos.GetUpperBound(0)

                    Dim Coluna As String = Campos(i, 0).Substring(Campos(i, 0).LastIndexOf("AS ") + 3)

                    If TypeOf Campos(i, 1) Is TextBox Then
                        CType(Campos(i, 1), TextBox).Text = Nothing
                    End If

                    If TypeOf (Campos(i, 1)) Is MaskedTextBox Then
                        CType(Campos(i, 1), MaskedTextBox).Text = Nothing
                    End If

                    'If TypeOf (Campos(i, 1)) Is MaskedEditBox Then
                    '    CType(Campos(i, 1), MaskedEditBox).Text = Nothing
                    'End If

                    If TypeOf (Campos(i, 1)) Is IntegerTextBox Then
                        CType(Campos(i, 1), IntegerTextBox).Text = Nothing
                    End If

                    If TypeOf (Campos(i, 1)) Is DoubleTextBox Then
                        CType(Campos(i, 1), DoubleTextBox).Text = Nothing
                    End If

                Next

Proximo:
            Catch ex As Exception
                Call GravaLOG(ex, "HandleDynamic2", GetCurrentMethodName())
            Finally
                Cursor.Current = Cursors.Default
            End Try

        End Sub

    End Class

    Public Class Forms

        Private Form As Form

        Public Sub AddHandler_Dynamic(Form As Form)

            Me.Form = Form

            AddHandler Me.Form.KeyPress, AddressOf KeyPress
            AddHandler Me.Form.KeyUp, AddressOf KeyUp

        End Sub

        Private Sub KeyUp(sender As Object, e As KeyEventArgs)

            Try

                If e.KeyCode = Keys.F1 Then
                    Try
                        Call AcessoRemoto()
                    Catch ex As Exception
                        MsgBox("Não foi possível abrir o acesso remoto!", vbCritical, "Atenção")
                    End Try
                End If

            Catch ex As Exception
                Call GravaLOG(ex, Form.Name, GetCurrentMethodName())
            End Try

        End Sub

        Private Sub KeyPress(sender As Object, e As KeyPressEventArgs)

            Try

                If Asc(e.KeyChar) = Keys.Enter Then
                    SendKeys.Send("{TAB}")
                    e.Handled = True
                End If

                If Asc(e.KeyChar) = Keys.Escape Then
                    If MessageBox.Show("Tem certeza que deseja SAIR?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                        Exit Sub
                    End If

                    Form.Close()
                End If

            Catch ex As Exception
                Call GravaLOG(ex, Form.Name, GetCurrentMethodName())
            End Try

        End Sub

    End Class

End Namespace