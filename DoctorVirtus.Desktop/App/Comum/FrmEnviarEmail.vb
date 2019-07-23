Imports System.IO
Imports System.Net
Imports System.Net.Mail

Public Class FrmEnviarEmail

    Public dtViewArquivos As New DataTable
    Public Email As String

    Friend WithEvents RicherTextBox1 As RicherTextBox.RicherTextBox

    Private Sub FrmEnviarEmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call MontaGridArquivos()
        Call RicherTextBox()

        TxtDestinatario.Text = Email
        'TxtAssunto.Text = EmpresaLogada.Parametros.Vendas.PropostaAssunto
        'RicherTextBox1.Text = EmpresaLogada.Parametros.Vendas.PropostaMensagem
        GridArquivos.DataSource = dtViewArquivos
        LblArquivosAnexados.Text = "(" & dtViewArquivos.Rows.Count & ") arquivos anexados"

    End Sub

    Private Sub RicherTextBox()

        Me.RicherTextBox1 = New RicherTextBox.RicherTextBox()
        Me.Controls.Add(Me.RicherTextBox1)

        Me.RicherTextBox1.AlignCenterVisible = True
        Me.RicherTextBox1.AlignLeftVisible = True
        Me.RicherTextBox1.AlignRightVisible = True
        Me.RicherTextBox1.Anchor = CType((((AnchorStyles.Top Or AnchorStyles.Bottom) _
            Or AnchorStyles.Left) _
            Or AnchorStyles.Right), AnchorStyles)
        Me.RicherTextBox1.BoldVisible = True
        Me.RicherTextBox1.BulletsVisible = True
        Me.RicherTextBox1.ChooseFontVisible = True
        Me.RicherTextBox1.FindReplaceVisible = True
        Me.RicherTextBox1.SetFontFamily(FontFamily.GenericSansSerif)
        Me.RicherTextBox1.FontColorVisible = True
        Me.RicherTextBox1.FontFamilyVisible = True
        Me.RicherTextBox1.FontSizeVisible = True
        Me.RicherTextBox1.GroupAlignmentVisible = True
        Me.RicherTextBox1.GroupBoldUnderlineItalicVisible = True
        Me.RicherTextBox1.GroupFontColorVisible = True
        Me.RicherTextBox1.GroupFontNameAndSizeVisible = True
        Me.RicherTextBox1.GroupIndentationAndBulletsVisible = True
        Me.RicherTextBox1.GroupInsertVisible = True
        Me.RicherTextBox1.GroupSaveAndLoadVisible = True
        Me.RicherTextBox1.GroupZoomVisible = False
        Me.RicherTextBox1.IndentVisible = True
        Me.RicherTextBox1.InsertPictureVisible = True
        Me.RicherTextBox1.ItalicVisible = True
        Me.RicherTextBox1.LoadVisible = True
        Me.RicherTextBox1.Location = New Point(6, 110)
        Me.RicherTextBox1.Name = "RicherTextBox1"
        Me.RicherTextBox1.OutdentVisible = True
        Me.RicherTextBox1.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\deflang1046{\fonttbl{\f0\fnil\fcharset204 Microsoft" &
    " Sans Serif;}}" & ChrW(13) & ChrW(10) & "\viewkind4\uc1\pard\f0\fs18\par" & ChrW(13) & ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RicherTextBox1.SaveVisible = True
        Me.RicherTextBox1.SeparatorAlignVisible = True
        Me.RicherTextBox1.SeparatorBoldUnderlineItalicVisible = True
        Me.RicherTextBox1.SeparatorFontColorVisible = True
        Me.RicherTextBox1.SeparatorFontVisible = True
        Me.RicherTextBox1.SeparatorIndentAndBulletsVisible = True
        Me.RicherTextBox1.SeparatorInsertVisible = True
        Me.RicherTextBox1.SeparatorSaveLoadVisible = True
        Me.RicherTextBox1.Size = New Size(634, 195)
        Me.RicherTextBox1.TabIndex = 6
        Me.RicherTextBox1.ToolStripVisible = True
        Me.RicherTextBox1.UnderlineVisible = True
        Me.RicherTextBox1.WordWrapVisible = True
        Me.RicherTextBox1.ZoomFactorTextVisible = False
        Me.RicherTextBox1.ZoomInVisible = False
        Me.RicherTextBox1.ZoomOutVisible = False

    End Sub

    Private Sub MontaGridArquivos()

        Try

            GridArquivos.AutoGenerateColumns = False
            GridArquivos.ColumnHeadersVisible = False

            With GridArquivos.Columns
                .Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Nome", .DataPropertyName = "Nome", .Visible = True, .ValueType = GetType(String), .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill}) '0
                .Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Diretorio", .DataPropertyName = "Diretorio", .Width = 55, .Visible = False, .ValueType = GetType(String)}) '0
            End With

            'For Each column As DataGridViewColumn In GridArquivos.Columns
            'dtViewArquivos.Columns.Add(column.DataPropertyName, column.ValueType)
            'Next

            GridArquivos.DataSource = dtViewArquivos

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try

    End Sub

    Private Sub LblArquivosAnexados_Click() Handles LblArquivosAnexados.Click
        Panel1.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel1.Visible = False
    End Sub

    Private Sub BtnAnexar_Click(sender As Object, e As EventArgs) Handles BtnAnexar.Click

        Try

            Dim OpenFiles As New OpenFileDialog With {
            .Multiselect = True
        }


            Dim dr As DialogResult = OpenFiles.ShowDialog()

            If dr = DialogResult.OK Then

                For Each arquivo As String In OpenFiles.FileNames

                    Dim rows As DataRow = dtViewArquivos.NewRow

                    rows.Item("Nome") = Path.GetFileNameWithoutExtension(arquivo) & Path.GetExtension(arquivo)
                    rows.Item("Diretorio") = arquivo

                    dtViewArquivos.Rows.Add(rows)

                Next

            End If


            dtViewArquivos.AcceptChanges()
            GridArquivos.DataSource = dtViewArquivos
            LblArquivosAnexados.Text = "(" & dtViewArquivos.Rows.Count & ") arquivos anexados"

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        End Try

    End Sub

    Private Sub GridArquivos_DoubleClick() Handles GridArquivos.DoubleClick

        For Each row As DataGridViewRow In GridArquivos.SelectedRows
            Process.Start(Convert.ToString(row.Cells(1).Value))
        Next

    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click

        Try

            'If UsuarioLogado.SMTP_Servidor = "" Then
            '    MsgBox("SMTP do email não está configurado!", vbExclamation, "Atenção")
            '    Exit Sub
            'End If

            'If Not IsNumeric(UsuarioLogado.SMTP_Porta) Then
            '    MsgBox("Porta do email não está configurada!", vbExclamation, "Atenção")
            '    Exit Sub
            'End If

            'If Not IsValidEmail(UsuarioLogado.SMTP_Usuario) Then
            '    MsgBox("Email válido na configuração!", vbExclamation, "Atenção")
            '    Exit Sub
            'End If

            'If TxtDestinatario.Text = "" Then
            '    MsgBox("Nenhum destinatário informado!", vbExclamation, "Atenção")
            '    Exit Sub
            'End If

            'Cursor.Current = Cursors.WaitCursor

            'Dim mMailMessage As New MailMessage With {
            '    .From = New MailAddress(UsuarioLogado.SMTP_Usuario)
            '}

            'For Each Destinatario As String In TxtDestinatario.Text.ToString.Split(Convert.ToChar(";"))
            '    mMailMessage.To.Add(New MailAddress(Destinatario))
            'Next

            'mMailMessage.Subject = TxtAssunto.Text
            'mMailMessage.Body = ConvertToHTML(RicherTextBox1.Rtf)
            'mMailMessage.IsBodyHtml = True
            'mMailMessage.Priority = MailPriority.Normal

            'For Each anexo As DataRow In dtViewArquivos.Rows
            '    mMailMessage.Attachments.Add(New Attachment(Convert.ToString(anexo.Item("Diretorio")))) 'Adiciona o anexo a envia
            'Next

            'Dim mSmtpClient As New SmtpClient(UsuarioLogado.SMTP_Servidor) With {
            '    .EnableSsl = UsuarioLogado.SMTP_SSL,
            '    .Credentials = New NetworkCredential(UsuarioLogado.SMTP_Usuario, UsuarioLogado.SMTP_Senha),
            '    .Port = Convert.ToInt16(UsuarioLogado.SMTP_Porta)
            '}

            'If UsuarioLogado.SMTP_TLS Then
            '    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
            'End If

            ''Envia o email
            'mSmtpClient.Send(mMailMessage)

            'Close()

            MsgBox("Email enviado com sucesso", vbInformation)

        Catch ex As Exception
            Call GravaLOG(ex, Me.Name, GetCurrentMethodName())
        Finally
            Cursor.Current = Cursors.Default
        End Try

    End Sub

    Public Function ConvertToHTML(Value As String) As String
        Dim Box As New RichTextBox With {
            .Rtf = Value
        }

        ' Takes a RichTextBox control and returns a
        ' simple HTML-formatted version of its contents
        Dim strHTML As String
        Dim strColour As String
        Dim blnBold As Boolean
        Dim blnItalic As Boolean
        Dim strFont As String
        Dim shtSize As Single
        Dim lngOriginalStart As Integer
        Dim lngOriginalLength As Integer
        Dim intCount As Integer

        ' If nothing in the box, exit
        If Box.Text.Length = 0 Then
            Return ""
        End If

        ' Store original selections, then select first character
        lngOriginalStart = 0
        lngOriginalLength = Box.TextLength
        Box.Select(0, 1)
        ' Add HTML header
        strHTML = "<html>"
        ' Set up initial parameters
        strColour = Box.SelectionColor.ToKnownColor.ToString
        blnBold = Box.SelectionFont.Bold
        blnItalic = Box.SelectionFont.Italic
        strFont = Box.SelectionFont.FontFamily.Name
        shtSize = Box.SelectionFont.Size

        ' Include first 'style' parameters in the HTML

        strHTML += "<span style=""font-family: " & strFont &
          "; font-size: " & shtSize & "pt; color: " _
                          & strColour & """>"

        ' Include bold tag, if required

        If blnBold = True Then
            strHTML += "<b>"
        End If

        ' Include italic tag, if required

        If blnItalic = True Then
            strHTML += "<i>"
        End If

        ' Finally, add our first character

        strHTML += Box.Text.Substring(0, 1)

        ' Loop around all remaining characters
        For intCount = 2 To Box.Text.Length
            ' Select current character
            Box.Select(intCount - 1, 1)
            ' If this is a line break, add HTML tag
            If Box.Text.Substring(intCount - 1, 1) = Convert.ToChar(10) Then

                strHTML += "<br>"

            End If

            ' Check/implement any changes in style

            If Box.SelectionColor.ToKnownColor.ToString <>
                strColour Or Box.SelectionFont.FontFamily.Name _
               <> strFont Or Box.SelectionFont.Size <> shtSize _
               Then

                strHTML += "</span><span style=""font-family: " &
                  Box.SelectionFont.FontFamily.Name &
                  "; font-size: " & Box.SelectionFont.Size &
                  "pt; color: " &
                  Box.SelectionColor.ToKnownColor.ToString & """>"
            End If

            ' Check for bold changes
            If Box.SelectionFont.Bold <> blnBold Then

                If Box.SelectionFont.Bold = False Then
                    strHTML += "</b>"
                Else
                    strHTML += "<b>"
                End If

            End If

            ' Check for italic changes
            If Box.SelectionFont.Italic <> blnItalic Then
                If Box.SelectionFont.Italic = False Then
                    strHTML += "</i>"
                Else
                    strHTML += "<i>"
                End If
            End If

            ' Add the actual character
            strHTML += Mid(Box.Text, intCount, 1)

            ' Update variables with current style

            strColour = Box.SelectionColor.ToKnownColor.ToString

            blnBold = Box.SelectionFont.Bold

            blnItalic = Box.SelectionFont.Italic

            strFont = Box.SelectionFont.FontFamily.Name

            shtSize = Box.SelectionFont.Size

        Next

        ' Close off any open bold/italic tags

        If blnBold = True Then strHTML += ""

        If blnItalic = True Then strHTML += ""

        ' Terminate outstanding HTML tags

        strHTML += "</span></html>"

        ' Restore original RichTextBox selection

        Box.Select(lngOriginalStart, lngOriginalLength)

        Return strHTML

    End Function

    Private Sub BtnAdicionarEmail_Click(sender As Object, e As EventArgs) Handles BtnAdicionarEmail.Click

        Dim dtViewEmail As New DataTable
        Dim Emails As String() = Email.Split(New Char() {";"c})

        ' Percorremos as palavras da strings separadas exibindo-as no ListBox
        'Dim palavra As String
        For Each row As String In Emails
            Dim rows As DataRow = dtViewEmail.NewRow
            rows.Item("Email") = row
            dtViewEmail.Rows.Add(rows)
        Next

        'Dim Frm As New FrmEmail(dtViewEmail)
        'Frm.ShowDialog()

        Dim EmailsNew As String = ""

        For Each Email As DataRow In dtViewEmail.Rows
            'EmailsNew &= Parse.ToString(Email("Email")) & ";"
        Next

        TxtDestinatario.Text = EmailsNew.Remove(EmailsNew.Length - 1)

        'Dim Frm As New FrmEmail With {
        '.Emails = TxtDestinatario.Text
        '}

        'Frm.ShowDialog()

        'TxtDestinatario.Text = Frm.Emails

    End Sub

    Private Sub BuscarEmailCadastro_Click(sender As Object, e As EventArgs) Handles BuscarEmailCadastro.Click

        TxtDestinatario.Text = Email

    End Sub
End Class