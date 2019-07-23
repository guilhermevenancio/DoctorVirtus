Imports System.IO
Imports System.Media
Imports System.Text
Imports System.Text.RegularExpressions
Imports Syncfusion.WinForms.ListView

Module Sistema

    Private Declare Auto Function GetPrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Auto Function WritePrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer

    Public FiltroItem As String = Nothing

    Public Sub GravaLOG(ex As Exception, name As String, Optional funcao As String = "", Optional MostrarMensagem As Boolean = True)

        Dim sInfo As String = ""
        Dim sDetalhes As String = ""

        Dim Frm As New FrmErro

        Try

            SystemSounds.Beep.Play()

            sInfo = ex.Message
            sDetalhes = funcao & " - Linha: " & ex.LineNumber & " - " & name

            Using sw As StreamWriter = New StreamWriter(Application.StartupPath & "\LOG_ERRO.txt", True)
                sw.WriteLine("--------------------------------------------")
                'sw.WriteLine("Usuário: " & UsuarioLogado.UsuarioID & " - " & UsuarioLogado.Nome & " - Data: " & Format(Now, "dd/MM/yyyy HH:mm"))
                sw.WriteLine("Info: " & sInfo)
                sw.WriteLine(sDetalhes)
            End Using

            If MostrarMensagem Then
                Frm.sInfo = sInfo
                Frm.sDetalhes = sDetalhes
                Frm.ShowDialog()
            End If

        Catch ez As Exception
            Frm.sInfo = "Não foi possível identificar"
            Frm.sDetalhes = ez.Message
            Frm.ShowDialog()
        End Try

    End Sub

    Function GetCurrentMethodName() As String

        Try

            Dim stack As New StackFrame(1)

            Return stack.GetMethod().Name

        Catch ex As Exception
            Call GravaLOG(ex, "Sistema", GetCurrentMethodName())
            Return ""
        End Try

    End Function

    Public Sub AcessoRemoto()

        Try
            Process.Start(Application.StartupPath & "\remoto.exe")
        Catch ex As Exception
            MsgBox("Não foi possível abrir o acesso remoto!", vbExclamation, "Atenção")
        End Try

    End Sub

    Public Function VerificaConexao(Optional Frm As Form = Nothing, Optional iTentativas As Integer = 0) As Boolean
TentaNovamente:

        Try

            iTentativas += 1
            Database.Execute("SELECT 1;")
            Return True

        Catch ex As Exception
            If iTentativas < 3 Then GoTo TentaNovamente

            If IsNothing(Frm) Then
                FrmReconectandoMaskedDialog.ShowDialogs(ViewSaude, New FrmReconectando)
            Else
                FrmReconectandoMaskedDialog.ShowDialogs(Frm, New FrmReconectando)
            End If

            Return False
        End Try

    End Function

    Public Function TelaProcurar(sCaption As String, sTabela As String, sColunas(,) As String, sRetorno As String, sCampoPesquisa As String, Optional sLeftInner As String = "", Optional sWhere As String = "", Optional sOrdenarPor As String = "", Optional sGroupBy As String = "", Optional sHideColumns() As String = Nothing, Optional sCampoCalculaTotal1 As String = "", Optional bPermiteCadastrar As Boolean = False, Optional Size As Point = Nothing, Optional QueryPersonalizada As String = "") As String
        Try

            Cursor.Current = Cursors.WaitCursor

            FiltroItem = Nothing

            Dim Frm As New FrmPesquisa With {
                .sCaption = sCaption,
                .sTabela = sTabela,
                .sColunas = sColunas,
                .sLeftInner = sLeftInner,
                .sWhere = sWhere,
                .sRetorno = sRetorno,
                .sCampoPesquisa = sCampoPesquisa,
                .sOrdenarPor = sOrdenarPor,
                .sGroupBy = sGroupBy,
                .sHideColumns = sHideColumns,
                .sCampoCalculaTotal1 = sCampoCalculaTotal1,
                .bPermiteCadastrar = bPermiteCadastrar,
                .QueryPersonalizada = QueryPersonalizada
            }

            If Size <> New Point(0, 0) Then
                Frm.Size = Size
            End If


            Frm.ShowDialog()

            Return FiltroItem

        Catch ex As Exception
            Call GravaLOG(ex, "Modulo", GetCurrentMethodName())
            Return Nothing
        Finally
            Cursor.Current = Cursors.Default
        End Try

    End Function

    Public Function TelaProcurar(sTabela As String, Optional sWhere As String = "") As String
        Try

            If sWhere = "" Then
                sWhere = sWhere & " 1=1 "
            End If

            Select Case sTabela
                Case "Usuario"
                    Return TelaProcurar("Procurar usuário", "Usuario", {{"Usuario.UsuarioID", "Código:String"}, {"Usuario.Login", "Descrição:String"}}, "Código", "Descrição", "", sWhere:="Usuario.Ativo = 1")
                Case "Prestador"
                    Return TelaProcurar("Procurar prestador", "Prestador", {{"Prestador.PrestadorID", "Código:String"}, {"Prestador.NomeFantasia", "Nome Fantasia:String"}, {"Prestador.RazaoSocial", "Razão Social:String"}, {"Prestador.Telefone1", "Telefone:String"}, {"Prestador.Telefone2", "Celular:String"}, {"Prestador.CNPJ", "CNPJ:String"}, {"Prestador.Logradouro", "Logradouro:String"}, {"Prestador.Complemento", "Complemento:String"}, {"Prestador.Numero", "Número:String"}, {"Prestador.Bairro", "Bairro:String"}, {"Municipio.Nome", "Cidade:String"}, {"Municipio.UF", "UF:String"}}, "Código", "Nome Fantasia", "LEFT JOIN Municipio ON Municipio.MunicipioID = Prestador.MunicipioID", sWhere & " AND Ativo = 1", bPermiteCadastrar:=False)
                Case "Procedimento"

                    Dim sSQL As String = "DECLARE @cols AS NVARCHAR(MAX) = '', @sql AS NVARCHAR(MAX)
                                                SELECT @cols += N'' + QUOTENAME(Descricao) + ', ' FROM (SELECT DISTINCT Descricao FROM Tabela WHERE TabelaID <> 1 AND Ativo = 1) a
	                        
                                                SET @cols = LEFT(@cols, LEN(@cols) - 1)
                                                SET @sql = N'SELECT TOP <@TOP> * FROM (
	                                                SELECT Procedimento.ProcedimentoID, CodigoTUSS AS ''Código TUSS'', Procedimento.Descricao AS Descrição, Referencia, Tabela.Descricao AS Tabela
	                                                FROM Procedimento
	                                                LEFT JOIN ProcedimentoItem ON Procedimento.ProcedimentoID = ProcedimentoItem.ProcedimentoID
	                                                LEFT JOIN Tabela ON ProcedimentoItem.TabelaID = Tabela.TabelaID
                                                ) AS P
                                                PIVOT (MAX(Referencia) FOR Tabela IN (' + @cols + ')) AS Pvt
                                                <@Where>
                                                ORDER BY ''Código TUSS'''

                                                EXEC Sp_executesql @sql"

                    Return TelaProcurar("Procurar procedimento", Nothing, Nothing, "ProcedimentoID", "Código TUSS", QueryPersonalizada:=sSQL, sHideColumns:={"ProcedimentoID"})
                Case "Tabela"
                    Return TelaProcurar("Procurar tabela", "Tabela", {{"Tabela.TabelaID", "Código:String"}, {"Tabela.Descricao", "Descrição:String"}}, "Código", "Descrição", "", sWhere:="Tabela.Ativo = 1")
                Case "Operadora"
                    Return TelaProcurar("Procurar operadora", "Operadora", {{"Operadora.OperadoraID", "Código:String"}, {"Operadora.Descricao", "Descrição:String"}}, "Código", "Descrição", "", sWhere:="Operadora.Ativo = 1")
                Case "LocalAtendimento"
                    Return TelaProcurar("Procurar local de atendimento", "LocalAtendimento", {{"LocalAtendimento.LocalAtendimentoID", "Código:String"}, {"LocalAtendimento.NomeFantasia", "Nome Fantasia:String"}, {"LocalAtendimento.RazaoSocial", "Razão Social:String"}, {"LocalAtendimento.Telefone1", "Telefone:String"}, {"LocalAtendimento.Telefone2", "Celular:String"}, {"LocalAtendimento.CNPJ", "CNPJ:String"}, {"LocalAtendimento.Logradouro", "Logradouro:String"}, {"LocalAtendimento.Complemento", "Complemento:String"}, {"LocalAtendimento.Numero", "Número:String"}, {"LocalAtendimento.Bairro", "Bairro:String"}, {"Municipio.Nome", "Cidade:String"}, {"Municipio.UF", "UF:String"}}, "Código", "Nome Fantasia", "LEFT JOIN Municipio ON Municipio.MunicipioID = LocalAtendimento.MunicipioID", sWhere & " AND Ativo = 1", bPermiteCadastrar:=False)
            End Select

            Return Nothing

        Catch ex As Exception
            Call GravaLOG(ex, "Modulo", GetCurrentMethodName())
            Return Nothing
        End Try
    End Function

    Public Function ConvertFileToByteArray(filePath As String) As Byte()
        Using stream As FileStream = New FileStream(filePath, FileMode.Open)
            Dim array As Byte() = New Byte(CInt(stream.Length) - 1) {}
            stream.Read(array, 0, Convert.ToInt32(stream.Length))

            Return array
        End Using
    End Function

    Public Sub ConvertByteArrayToFile(file As Byte(), diretorio As String, filename As String)

        If Not Directory.Exists(diretorio) Then
            Directory.CreateDirectory(diretorio)
        End If

        If IsNothing(file) Then
            Exit Sub
        End If

        Using stream = New FileStream(diretorio & filename, FileMode.Create, FileAccess.Write)
            stream.Write(file, 0, Convert.ToInt32(file.Length))
        End Using

    End Sub

    Public Function IsValidEmail(ByVal email As String) As Boolean

        Try
            If email = String.Empty Then Return False
            ' Compruebo si el formato de la dirección es correcto.
            Dim re As Regex = New Regex("^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,5}$")
            Dim m As Match = re.Match(email)
            Return (m.Captures.Count <> 0)
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function IsValidTelefone(ByVal telefone As String) As Boolean

        Dim padraoRegex As String = "^[0-9]{2}-[0-9]{4}-[0-9]{4}$"
            Dim verifica As New Regex(padraoRegex)
            Dim valida As Boolean = False
            If telefone = "" Then
                valida = False
            Else
                valida = verifica.IsMatch(telefone, 0)
            End If
            Return valida

    End Function

    Public Function IsValidCPF(ByVal CPF As String) As Boolean

        CPF = Mid(CPF, 1, 3) & "." & Mid(CPF, 4, 3) & "." & Mid(CPF, 7, 3) & "-" & Mid(CPF, 10, 2)

            Dim dadosArray() As String = {"111.111.111-11", "222.222.222-22", "333.333.333-33", "444.444.444-44",
                                              "555.555.555-55", "666.666.666-66", "777.777.777-77", "888.888.888-88", "999.999.999-99"}
            Dim i, x, n1, n2 As Double

            CPF = CPF.Trim
            For i = 0 To dadosArray.Length - 1
                If CPF.Length <> 14 Or dadosArray(CInt(i)).Equals(CPF) Then
                    Return False
                End If
            Next
            'remove a maskara
            CPF = CPF.Substring(0, 3) + CPF.Substring(4, 3) + CPF.Substring(8, 3) + CPF.Substring(12)
            For x = 0 To 1
                n1 = 0
                For i = 0 To 8 + x
                    n1 = n1 + Val(CPF.Substring(CInt(i), 1)) * (10 + x - i)
                Next
                n2 = 11 - (n1 - (Int(n1 / 11) * 11))
                If n2 = 10 Or n2 = 11 Then n2 = 0

                If n2 <> Val(CPF.Substring(CInt(9 + x), 1)) Then
                    Return False
                End If
            Next

            Return True

    End Function

    Public Function IsValidCNPJ(ByVal value As String) As Boolean

        Dim multiplier1() As Integer = New Integer() {5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2}
            Dim multiplier2() As Integer = New Integer() {6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2}
            Dim sum As Integer = 0
            Dim leftOver As Integer
            Dim digit As String
            value = value.Trim()
            value = value.Replace(".", "")
            value = value.Replace("/", "")
            value = value.Replace("-", "")
            Dim tempCPF As String = value
            If Not value.Length = 14 Then
                Return False ' Maior/Menor que 14 dígitos
            End If
            tempCPF = tempCPF.Substring(0, 12)
            For i As Integer = 0 To 11
                sum = sum + Integer.Parse(CType(CInt(tempCPF(i).ToString) * multiplier1(i), String))
            Next
            leftOver = sum Mod 11
            If leftOver < 2 Then
                leftOver = 0
            Else
                leftOver = 11 - leftOver
            End If
            digit = leftOver.ToString
            tempCPF = tempCPF + digit
            sum = 0
            For i As Integer = 0 To 12
                sum = sum + Integer.Parse(CType(CInt(tempCPF(i).ToString) * multiplier2(i), String))
            Next
            leftOver = sum Mod 11
            If leftOver < 2 Then
                leftOver = 0
            Else
                leftOver = 11 - leftOver
            End If
            digit = digit + leftOver.ToString

            Return value.EndsWith(digit)

    End Function

    Public Function UltimoDiaMes(value As Date) As String

        value = DateAdd("m", 1, DateSerial(Year(value), Month(value), 1))
        value = DateAdd("d", -1, value)
        Return Format(value, "dd")

    End Function

    Public Sub LayoutGrid(Grid As DataGridView)

        Grid.AllowUserToAddRows = False
        Grid.AllowUserToDeleteRows = False
        Grid.BackgroundColor = Color.White
        Grid.BorderStyle = BorderStyle.Fixed3D
        Grid.CellBorderStyle = DataGridViewCellBorderStyle.Single
        Grid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        Grid.GridColor = Color.FromKnownColor(KnownColor.ControlLight)

    End Sub

    Public Function ApenasNumeros(Value As Object) As String
        If IsNothing(Value) Then
            Return Nothing
        Else
            Return String.Join(Nothing, Regex.Split(Value, "[^\d]"))
        End If
    End Function

    Public Sub ComboBoxAdd(ComboBox As SfComboBox, sRows(,) As Object)

        Dim dt As DataTable = New DataTable()

        dt.Columns.Add(New DataColumn("Text", GetType(String)))
        dt.Columns.Add(New DataColumn("Value", GetType(String)))

        For index0 = 0 To sRows.GetUpperBound(0)

            Dim dr As DataRow = dt.NewRow()

            dr("Value") = sRows(index0, 0)
            dr("Text") = sRows(index0, 1)

            dt.Rows.Add(dr)

        Next

        ComboBox.DataSource = dt

    End Sub

End Module
