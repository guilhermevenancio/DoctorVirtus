Imports System.IO
Imports System.Text
Imports System.Threading
Imports Syncfusion.Windows.Forms.Tools

Partial Public Class ViewSaude
    Inherits RibbonForm

    Dim Form As New HandleDynamic.Forms

    Dim FormsAbertos As New List(Of Form)

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            TabPrincipal.SelectedTab = TabItemCadastros


            Form.AddHandler_Dynamic(Me)

            'PRINCIPAL
            AddHandler AtalhoProduto2.Click, Sub() OpenForm(New ViewProcedimento, Nothing)

            AddHandler BtnUsuario.Click, Sub() OpenForm(New ViewUsuario, Nothing)
            AddHandler BtnPrestador.Click, Sub() OpenForm(New ViewPrestador, Nothing)
            AddHandler BtnLocalAtendimento.Click, Sub() OpenForm(New ViewLocalAtendimento, Nothing)
            AddHandler BtnOperadora.Click, Sub() OpenForm(New ViewOperadora, Nothing)
            AddHandler BtnTabela.Click, Sub() OpenForm(New ViewTabela, Nothing)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Private Sub AtalhoAcessoRemoto_Click(sender As Object, e As EventArgs) Handles AtalhoAcessoRemoto.Click

        Try

            Call AcessoRemoto()

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try

    End Sub

    Private Sub AtalhoSairSistema_Click(sender As Object, e As EventArgs) Handles AtalhoSairSistema.Click

        Try

            If MsgBox("Tem certeza que deseja sair do sistema?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Atenção") = vbYes Then
                Application.Exit()
            End If

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try

    End Sub

    Private Sub OpenForm(Frm As Form, iPermissao As Integer?)

        'If Not IsNothing(iPermissao) Then
        '    If Not VerificaPermissao(iPermissao) Then
        '        MsgBox("Usuário sem permissão!", vbExclamation, "Atenção")
        '        Exit Sub
        '    End If
        'End If

        MaskedDialog.ShowDialogs(Me, Frm)

    End Sub

    Private Sub OpenMDI(Form As Form, iPermissao As Integer?)

        'If Not IsNothing(iPermissao) Then
        '    If Not VerificaPermissao(iPermissao) Then
        '        MsgBox("Usuário sem permissão!", vbExclamation, "Atenção")
        '        Exit Sub
        '    End If
        'End If

        For Each Frm As Form In FormsAbertos
            Frm.Visible = False
        Next

        Form.MdiParent = Me
        Form.Top = 0
        Form.Left = 0
        Form.Dock = DockStyle.Fill
        Form.Show()

        FormsAbertos.Add(Form)

    End Sub

End Class