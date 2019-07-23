Option Strict Off
Imports System.IO

Module Office

    Public Sub ExportToExcel(dtTemp As DataTable, Nome As String)

        If dtTemp.Rows.Count = 0 Then
            MsgBox("Não há dados para exportar!", vbExclamation, "Atenção")
            Exit Sub
        End If

        Dim ArquivoDestino As String

        ArquivoDestino = Application.StartupPath & "\TEMP\" & Nome & Format(Now, "HHmmssfff") & Format(Now, "ddMMyy") & ".xlsx"

        If Not Directory.Exists(Application.StartupPath & "\TEMP") Then
            Directory.CreateDirectory(Application.StartupPath & "\TEMP")
        End If

        If File.Exists(ArquivoDestino) Then
            File.Delete(ArquivoDestino)
        End If


        Dim _excel As New Object
        Dim wBook As Object
        Dim wSheet As Object

        _excel = CreateObject("Excel.Application")

        wBook = _excel.Workbooks.Add()
        wSheet = wBook.ActiveSheet()

        Dim dt As DataTable = dtTemp
        Dim dc As DataColumn
        Dim dr As DataRow

        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 0
        'If CheckBox1.Checked Then
        For Each dc In dt.Columns
            colIndex = colIndex + 1
            wSheet.Cells(1, colIndex) = dc.ColumnName
        Next
        'End If
        For Each dr In dt.Rows
            rowIndex = rowIndex + 1
            colIndex = 0
            For Each dc In dt.Columns
                colIndex = colIndex + 1
                wSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
            Next
        Next
        wSheet.Columns.AutoFit()
        wBook.SaveAs(ArquivoDestino)

        _excel.Visible = True

        _excel = Nothing

    End Sub

    Public Sub ExportToExcel(dgvDados As DataGridView, Nome As String)

        If dgvDados.Rows.Count = 0 Then
            MsgBox("Não há dados para exportar!", vbExclamation, "Atenção")
            Exit Sub
        End If

        Dim ArquivoDestino As String

        ArquivoDestino = Application.StartupPath & "\TEMP\" & Nome & Format(Now, "HHmmssfff") & Format(Now, "ddMMyy") & ".xlsx"

        If Not Directory.Exists(Application.StartupPath & "\TEMP") Then
            Directory.CreateDirectory(Application.StartupPath & "\TEMP")
        End If

        If File.Exists(ArquivoDestino) Then
            File.Delete(ArquivoDestino)
        End If


        Dim _excel As New Object
        Dim wBook As Object
        Dim wSheet As Object

        _excel = CreateObject("Excel.Application")

        wBook = _excel.Workbooks.Add()
        wSheet = wBook.ActiveSheet()

        For i As Integer = 1 To dgvDados.Columns.Count
            wSheet.Cells(1, i) = dgvDados.Columns(i - 1).HeaderText
        Next

        For i As Integer = 0 To dgvDados.Rows.Count - 1
            For j As Integer = 0 To dgvDados.Columns.Count - 1
                wSheet.Cells(i + 2, j + 1) = Parse.ToString(dgvDados.Rows(i).Cells(j).Value)
            Next
        Next

        wSheet.Columns.AutoFit()
        wBook.SaveAs(ArquivoDestino)

        _excel.Visible = True

        _excel = Nothing

    End Sub
End Module
