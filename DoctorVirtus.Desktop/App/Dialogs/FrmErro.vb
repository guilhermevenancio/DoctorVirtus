Public Class FrmErro

    Public sInfo As String
    Public sDetalhes As String

    Private Sub FrmErro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Size = New Size(366, 190)

        TxtInfo.Text = sInfo
        LblDetalhe.Text = sDetalhes

    End Sub

    Private Sub BtnDetalhes_Click(sender As Object, e As EventArgs) Handles BtnDetalhes.Click

        'MsgBox("Ops! ocorreu uma não conformidade no sistema" & vbCrLf & "entre em contato com o suporte técnico!", vbExclamation, "Atenção")

        If BtnDetalhes.Text = "Detalhes" Then
            LblDetalhe.Visible = True
            TxtInfo.Visible = True
            BtnDetalhes.Text = "Ocultar"
            Me.Size = New Size(366, 300)
        Else
            LblDetalhe.Visible = False
            TxtInfo.Visible = False
            BtnDetalhes.Text = "Detalhes"
            Me.Size = New Size(366, 190)
        End If

    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        Me.Close()
    End Sub

End Class
