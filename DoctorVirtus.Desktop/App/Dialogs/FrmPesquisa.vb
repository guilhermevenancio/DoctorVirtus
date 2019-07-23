Option Strict Off

Imports System.Threading
Imports Syncfusion.GridHelperClasses
Imports Syncfusion.Windows.Forms.Grid.Grouping

Public Class FrmPesquisa

    Private bCarregandoTela As Boolean = True

    Public sTabela As String
    Public sColunas(,) As String
    Public sRetorno As String
    Public sCampoPesquisa As String
    Public sCaption As String
    Public sLeftInner As String
    Public sWhere As String
    Public sOrdenarPor As String
    Public sGroupBy As String
    Public bPermiteCadastrar As Boolean
    Public sHideColumns() As String

    Private bSelecionou As Boolean = False

    Public QueryPersonalizada As String = ""

    Public sCampoCalculaTotal1 As String = ""
    Private Total1 As Double = 0


    Private Sub FrmPesquisar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            bCarregandoTela = True

            BtnCadastrar.Visible = bPermiteCadastrar

            If sCampoCalculaTotal1 = "" Then
                TxtCampoCalculaTotal1.Visible = False
                LblCampoCalculaTotal1.Visible = False
            End If


            Me.ActiveControl = Me.GridGroupingControl2.TableControl
            GridGroupingControl2.WantTabKey = False

            Dim GridGroupingFilter As New GridExcelFilter With {
                .EnableStackedColumnFilterIcon = True
            }


            GridGroupingFilter.WireGrid(Me.GridGroupingControl2)

            DtInicio.Value = Now
            DtFim.Value = Now

            Me.Text = sCaption

            If Not IsNothing(sColunas) Then
                Dim Campos As String()
                Dim indice As Integer = 0

                Dim dt As DataTable = New DataTable()

                dt.Columns.Add(New DataColumn("Text"))
                dt.Columns.Add(New DataColumn("Value"))

                Dim index As Integer

                For index0 = 0 To sColunas.GetUpperBound(0)
                    For index1 = 0 To sColunas.GetUpperBound(1)
                        If index1 = 1 Then

                            Campos = sColunas(index0, index1).ToString().Split(CChar(":"))

                            Dim dr As DataRow = dt.NewRow()

                            dr("Text") = Campos(0)
                            dr("Value") = Campos(1)

                            dt.Rows.Add(dr)

                            If sCampoPesquisa = Campos(0) Then
                                index = indice
                            End If
                            indice = indice + 1
                        End If
                    Next
                Next

                SfComboBox1.DataSource = dt
                SfComboBox1.SelectedIndex = index
                SfComboBox1.DisplayMember = "Text"
                SfComboBox1.ValueMember = "Value"
            Else
                PanelString.Visible = True
                TxtPesquisar.Select()

                Call BtnPesquisar_Click()
            End If

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try

    End Sub

    Private Async Sub Pesquisar(sSQL As String)

        Try

            Dim dt As DataTable = Await Task.Run(Function() As DataTable
                                                     Try

                                                         If Not VerificaConexao() Then
                                                             Return Nothing
                                                         End If


                                                         '.SetText(sSQL)

                                                         Return Database.Execute(sSQL).Tables(0)

                                                     Catch ex As Exception
                                                         Return Nothing
                                                     End Try
                                                 End Function)


            If IsNothing(dt) Then
                Exit Sub
            End If

            If InvokeRequired Then
                Invoke(New Action(Sub()
                                      PreencherResultado(dt)
                                  End Sub))
            Else
                PreencherResultado(dt)
            End If

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try

    End Sub

    Private Sub PreencherResultado(dt As DataTable)

        GridGroupingControl2.Visible = True
        GridGroupingControl2.DataSource = dt

        Panel1.Visible = False

        For Each col As GridColumnDescriptor In GridGroupingControl2.TableDescriptor.Columns
            col.AllowFilter = True
        Next

        If GridGroupingControl2.Table.FilteredRecords.Count = 0 Then
            Exit Sub
        End If

        GridGroupingControl2.Table.SelectedRecords.Clear()
        GridGroupingControl2.Table.Records(0).SetSelected(True)
        GridGroupingControl2.TableControl.CurrentCell.MoveTo(0, 0, Syncfusion.Windows.Forms.Grid.GridSetCurrentCellOptions.SetFocus)

        If sCampoCalculaTotal1 <> "" Then
            For Each row As DataRow In dt.Rows
                Total1 += row.Item(sCampoCalculaTotal1)
            Next
        End If

        TxtCampoCalculaTotal1.DoubleValue = Total1

        If IsNothing(sColunas) And bCarregandoTela Then
            Dim indice As Integer = 0
            Dim index As Integer

            Dim dt_col As DataTable = New DataTable()

            dt_col.Columns.Add(New DataColumn("Text"))
            dt_col.Columns.Add(New DataColumn("Value"))

            For Each row In GridGroupingControl2.TableDescriptor.Columns
                Dim dr As DataRow = dt_col.NewRow()

                dr("Text") = row.Name
                dr("Value") = row.Name

                dt_col.Rows.Add(dr)

                If sCampoPesquisa = row.Name Then
                    index = indice
                End If
                indice = indice + 1
            Next

            SfComboBox1.DataSource = dt_col
            SfComboBox1.SelectedIndex = index
            SfComboBox1.DisplayMember = "Text"
            SfComboBox1.ValueMember = "Value"
        End If

        If Not IsNothing(sHideColumns) Then
            For Each column As String In sHideColumns
                GridGroupingControl2.TableDescriptor.VisibleColumns.Remove(column)
            Next
        End If


        bCarregandoTela = False

    End Sub

    Private Function MontaQuery() As String
        Try

            If QueryPersonalizada = "" Then
                Dim sSQL As String = "SELECT TOP " & TxtRegistros.Text & " "
                Dim Campos As String()

                Dim sCampoFiltro As String = ""

                For index0 = 0 To sColunas.GetUpperBound(0)
                    For index1 = 0 To sColunas.GetUpperBound(1)
                        If index1 = 1 Then
                            sSQL &= " AS '"
                        End If

                        Campos = sColunas(index0, index1).ToString().Split(CChar(":"))

                        sSQL &= Campos(0)

                        If index1 = 1 Then
                            sSQL &= "', "
                        End If
                    Next
                Next

                sSQL = sSQL.Remove(sSQL.Length - 2)
                sSQL &= " FROM " & sTabela & " "

                sSQL &= sLeftInner

                sSQL &= " WHERE 1=1 "

                For index0 = 0 To sColunas.GetUpperBound(0)
                    For index1 = 0 To sColunas.GetUpperBound(1)
                        If index1 = 1 Then

                            Campos = sColunas(index0, index1).ToString().Split(CChar(":"))

                            If Campos(0) = SfComboBox1.Text Then

                                sCampoFiltro = sColunas(index0, 0).ToString()

                                If Campos(1) = "String" Then

                                    If Trim(TxtPesquisar.Text) <> "" Then
                                        sSQL &= " AND " & sCampoFiltro & " LIKE '%" & Replace(Replace(TxtPesquisar.Text, "'", "''"), " ", "%") & "%' "
                                    End If
                                End If

                                If Campos(1) = "Datetime" Then
                                    sSQL &= " AND " & sCampoFiltro & " BETWEEN '" & Format(DtInicio.Value, "dd/MM/yyyy") & " 00:00:00' AND '" & Format(DtFim.Value, "dd/MM/yyyy") & " 23:59:59'"
                                End If

                            End If
                        End If
                    Next
                Next

                If sWhere <> "" Then
                    sSQL &= " AND " & sWhere
                End If

                If sGroupBy <> "" Then
                    sSQL &= " GROUP BY " & sGroupBy
                End If

                If sOrdenarPor = "" Then
                    sSQL &= " ORDER BY " & sCampoFiltro & " ASC "
                Else
                    sSQL &= " ORDER BY " & sOrdenarPor
                End If

                Return sSQL

            Else
                Dim sCampoFiltro As String = ""
                Dim sWherePersonalizado As String = "WHERE 1=1 "

                For Each row In GridGroupingControl2.TableDescriptor.Columns

                    If row.Name = SfComboBox1.Text Then
                        sCampoFiltro = row.Name
                        If Trim(TxtPesquisar.Text) <> "" Then
                            sWherePersonalizado &= " AND [" & sCampoFiltro & "] LIKE ''%" & Replace(Replace(TxtPesquisar.Text, "'", "''"), " ", "%") & "%'' "
                        End If
                    End If
                Next

                If sWhere <> "" Then
                    sWherePersonalizado &= " AND " & sWhere
                End If

                Return Replace(Replace(QueryPersonalizada, "<@TOP>", TxtRegistros.Text), "<@Where>", sWherePersonalizado)
            End If

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        Return ""
        End Try

    End Function

    Private Sub BtnPesquisar_Click() Handles BtnPesquisar.Click

        Try

            Dim trdPesquisar As New Thread(AddressOf Pesquisar) With {
                .IsBackground = True
            }
            trdPesquisar.Start(MontaQuery())

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try

    End Sub

    Private Sub GridGroupingControl2_DoubleClick(sender As Object, e As EventArgs) Handles GridGroupingControl2.TableControlCellDoubleClick

        Try

            If GridGroupingControl2.Table.FilteredRecords.Count = 0 Then
                Exit Sub
            End If

            Dim index As Integer = 0
            If GridGroupingControl2.Table.SelectedRecords.Count > 0 Then
                For Each selectedRecord As Syncfusion.Grouping.SelectedRecord In GridGroupingControl2.Table.SelectedRecords
                    index = selectedRecord.Record.GetSourceIndex()
                Next
            End If


            Dim currentRecord As Syncfusion.Grouping.Record = GridGroupingControl2.Table.Records(index)

            bSelecionou = True
            FiltroItem = currentRecord(sRetorno)

            Me.Close()

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try

    End Sub

    Private Sub FrmPesquisa_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        Try

            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If

            If e.KeyCode = Keys.Enter Then
                e.Handled = True
                Call GridGroupingControl2_DoubleClick(Nothing, Nothing)
            End If

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try

    End Sub

    Private Sub TxtPesquisar_KeyUp(sender As Object, e As EventArgs) Handles TxtPesquisar.KeyUp

        Try

            Call BtnPesquisar_Click()

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try

    End Sub

    Private Sub TxtPesquisar_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPesquisar.KeyDown

        Try

            e.Handled = True

            If GridGroupingControl2.Table.FilteredRecords.Count = 0 Then
                Exit Sub
            End If

            Dim index As Integer = 0

            If e.KeyCode = Keys.Down Then
                GridGroupingControl2.Table.SelectedRecords.Clear()
                GridGroupingControl2.Table.Records(index).SetSelected(True)
                index = GridGroupingControl2.Table.Records(0).GetRowIndex()
                GridGroupingControl2.TableControl.CurrentCell.MoveTo(index + 1, 0, Syncfusion.Windows.Forms.Grid.GridSetCurrentCellOptions.SetFocus)
                GridGroupingControl2.Focus()
            End If

            If e.KeyCode = Keys.Up Then
                GridGroupingControl2.Table.SelectedRecords.Clear()
                GridGroupingControl2.Table.Records(index).SetSelected(True)
                index = GridGroupingControl2.Table.Records(0).GetRowIndex()
                GridGroupingControl2.TableControl.CurrentCell.MoveTo(index - 1, 0, Syncfusion.Windows.Forms.Grid.GridSetCurrentCellOptions.SetFocus)
                GridGroupingControl2.Focus()
            End If

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try

    End Sub

    Private Sub DtInicio_KeyUp(sender As Object, e As KeyEventArgs) Handles DtInicio.KeyDown

        Try

            e.Handled = True

            If GridGroupingControl2.Table.FilteredRecords.Count = 0 Then
                Exit Sub
            End If

            Dim index As Integer = 0

            If e.KeyCode = Keys.Down Then
                GridGroupingControl2.Table.SelectedRecords.Clear()
                GridGroupingControl2.Table.Records(index).SetSelected(True)
                index = GridGroupingControl2.Table.Records(0).GetRowIndex()
                GridGroupingControl2.TableControl.CurrentCell.MoveTo(index + 1, 0, Syncfusion.Windows.Forms.Grid.GridSetCurrentCellOptions.SetFocus)
                GridGroupingControl2.Focus()
            End If

            If e.KeyCode = Keys.Up Then
                GridGroupingControl2.Table.SelectedRecords.Clear()
                GridGroupingControl2.Table.Records(index).SetSelected(True)
                index = GridGroupingControl2.Table.Records(0).GetRowIndex()
                GridGroupingControl2.TableControl.CurrentCell.MoveTo(index - 1, 0, Syncfusion.Windows.Forms.Grid.GridSetCurrentCellOptions.SetFocus)
                GridGroupingControl2.Focus()
            End If

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try

    End Sub

    Private Sub SfComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles SfComboBox1.SelectedValueChanged

        Try

            If QueryPersonalizada = "" Then
                PanelDate.Visible = False
                PanelString.Visible = False

                If SfComboBox1.SelectedValue = "String" Then
                    PanelString.Visible = True
                    TxtPesquisar.Select()
                End If

                If SfComboBox1.SelectedValue = "Datetime" Then
                    PanelDate.Visible = True
                    DtInicio.Select()
                End If

                Call BtnPesquisar_Click()
            End If

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try

    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        Try

            Call GridGroupingControl2_DoubleClick(Nothing, Nothing)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        Try

            Me.Close()

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try

    End Sub

    Private Sub BtnCadastrar_Click(sender As Object, e As EventArgs) Handles BtnCadastrar.Click

        ''CADASTRAR PARCEIRO
        'If sTabela = "Parceiro" Then
        '    Dim Frm As New ViewParceiro With {
        '        .bRetornaParceiro = True
        '    }
        '    Frm.ShowDialog()
        '    If Frm.TxtParceiroID.Text <> "" Then
        '        bSelecionou = True
        '        FiltroItem = Frm.TxtParceiroID.Text
        '        Me.Close()
        '    End If
        'End If

        ''CADASTRAR CONTA
        'If sTabela = "Conta" Then
        '    Dim Frm As New FrmConta With {
        '        .bRetornaConta = True
        '    }
        '    Frm.ShowDialog()
        '    If Frm.TxtContaID.Text <> "" Then
        '        bSelecionou = True
        '        FiltroItem = Frm.TxtContaID.Text
        '        Me.Close()
        '    End If
        'End If

        ''CADASTRAR CAIXA
        'If sTabela = "Caixa" Then
        '    Dim Frm As New FrmCaixa With {
        '        .bRetornaConta = True
        '    }
        '    Frm.ShowDialog()
        '    If Frm.TxtCaixaID.Text <> "" Then
        '        bSelecionou = True
        '        FiltroItem = Frm.TxtCaixaID.Text
        '        Me.Close()
        '    End If
        'End If


    End Sub
End Class