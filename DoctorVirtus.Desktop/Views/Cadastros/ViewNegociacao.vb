Imports DoctorVirtus.Desktop.HandleDynamic

Public Class ViewNegociacao
    Dim Frm As New Forms
    Public Salvou As Boolean = False

    Dim LocalAtendimento As New HandleDynamic.HandleDynamic
    Dim Operadora As New HandleDynamic.HandleDynamic
    Dim Tabela As New HandleDynamic.HandleDynamic

    Private Sub ViewCegociacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Frm.AddHandler_Dynamic(Me)

            Salvou = False

            LocalAtendimento.AddHandler_Dynamic(eTipoCampo.LocalAtendimento, TxtLocalAtendimentoID, TxtLocalAtendimentoDescricao, BtnProcurarLocalAtendimento)
            Operadora.AddHandler_Dynamic(eTipoCampo.Operadora, TxtOperadoraID, TxtOperadoraDescricao, BtnProcurarOperadora)
            Tabela.AddHandler_Dynamic(eTipoCampo.Tabela, TxtTabelaID, TxtTabelaDescricao, BtnProcurarTabela)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try
    End Sub

    Public Sub Limpar()

    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Salvou = True
        Me.Close()
    End Sub

End Class