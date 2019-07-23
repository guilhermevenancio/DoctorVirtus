<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEnviarEmail
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEnviarEmail))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnAdicionarEmail = New System.Windows.Forms.Button()
        Me.LblPara = New System.Windows.Forms.Label()
        Me.TxtDestinatario = New System.Windows.Forms.TextBox()
        Me.BuscarEmailCadastro = New System.Windows.Forms.Button()
        Me.LblAssunto = New System.Windows.Forms.Label()
        Me.TxtAssunto = New System.Windows.Forms.TextBox()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.BtnAnexar = New System.Windows.Forms.Button()
        Me.LblArquivosAnexados = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GridArquivos = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.GridArquivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnAdicionarEmail
        '
        Me.BtnAdicionarEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAdicionarEmail.BackColor = System.Drawing.SystemColors.Control
        Me.BtnAdicionarEmail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdicionarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdicionarEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnAdicionarEmail.Image = CType(resources.GetObject("BtnAdicionarEmail.Image"), System.Drawing.Image)
        Me.BtnAdicionarEmail.Location = New System.Drawing.Point(582, 27)
        Me.BtnAdicionarEmail.Name = "BtnAdicionarEmail"
        Me.BtnAdicionarEmail.Size = New System.Drawing.Size(26, 23)
        Me.BtnAdicionarEmail.TabIndex = 2
        Me.BtnAdicionarEmail.TabStop = False
        Me.BtnAdicionarEmail.UseVisualStyleBackColor = False
        '
        'LblPara
        '
        Me.LblPara.AutoSize = True
        Me.LblPara.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LblPara.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LblPara.Location = New System.Drawing.Point(3, 9)
        Me.LblPara.Name = "LblPara"
        Me.LblPara.Size = New System.Drawing.Size(30, 14)
        Me.LblPara.TabIndex = 0
        Me.LblPara.Text = "Para"
        '
        'TxtDestinatario
        '
        Me.TxtDestinatario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDestinatario.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TxtDestinatario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDestinatario.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtDestinatario.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.TxtDestinatario.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtDestinatario.Location = New System.Drawing.Point(6, 27)
        Me.TxtDestinatario.Margin = New System.Windows.Forms.Padding(10)
        Me.TxtDestinatario.Name = "TxtDestinatario"
        Me.TxtDestinatario.ReadOnly = True
        Me.TxtDestinatario.Size = New System.Drawing.Size(577, 23)
        Me.TxtDestinatario.TabIndex = 1
        Me.TxtDestinatario.TabStop = False
        '
        'BuscarEmailCadastro
        '
        Me.BuscarEmailCadastro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BuscarEmailCadastro.BackColor = System.Drawing.SystemColors.Control
        Me.BuscarEmailCadastro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BuscarEmailCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BuscarEmailCadastro.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BuscarEmailCadastro.Location = New System.Drawing.Point(614, 27)
        Me.BuscarEmailCadastro.Name = "BuscarEmailCadastro"
        Me.BuscarEmailCadastro.Size = New System.Drawing.Size(26, 23)
        Me.BuscarEmailCadastro.TabIndex = 3
        Me.BuscarEmailCadastro.TabStop = False
        Me.BuscarEmailCadastro.Text = "="
        Me.BuscarEmailCadastro.UseVisualStyleBackColor = False
        '
        'LblAssunto
        '
        Me.LblAssunto.AutoSize = True
        Me.LblAssunto.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LblAssunto.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LblAssunto.Location = New System.Drawing.Point(3, 60)
        Me.LblAssunto.Name = "LblAssunto"
        Me.LblAssunto.Size = New System.Drawing.Size(51, 14)
        Me.LblAssunto.TabIndex = 4
        Me.LblAssunto.Text = "Assunto"
        '
        'TxtAssunto
        '
        Me.TxtAssunto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtAssunto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TxtAssunto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAssunto.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.TxtAssunto.Location = New System.Drawing.Point(6, 77)
        Me.TxtAssunto.Name = "TxtAssunto"
        Me.TxtAssunto.Size = New System.Drawing.Size(634, 23)
        Me.TxtAssunto.TabIndex = 5
        '
        'BtnEnviar
        '
        Me.BtnEnviar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnEnviar.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnEnviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnviar.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnEnviar.ForeColor = System.Drawing.Color.White
        Me.BtnEnviar.Image = CType(resources.GetObject("BtnEnviar.Image"), System.Drawing.Image)
        Me.BtnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEnviar.Location = New System.Drawing.Point(5, 311)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(81, 28)
        Me.BtnEnviar.TabIndex = 7
        Me.BtnEnviar.TabStop = False
        Me.BtnEnviar.Text = "Enviar"
        Me.BtnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEnviar.UseVisualStyleBackColor = False
        '
        'BtnAnexar
        '
        Me.BtnAnexar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnAnexar.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnAnexar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAnexar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAnexar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAnexar.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnAnexar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BtnAnexar.Image = CType(resources.GetObject("BtnAnexar.Image"), System.Drawing.Image)
        Me.BtnAnexar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAnexar.Location = New System.Drawing.Point(103, 311)
        Me.BtnAnexar.Name = "BtnAnexar"
        Me.BtnAnexar.Size = New System.Drawing.Size(81, 28)
        Me.BtnAnexar.TabIndex = 8
        Me.BtnAnexar.TabStop = False
        Me.BtnAnexar.Text = "Anexar"
        Me.BtnAnexar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAnexar.UseVisualStyleBackColor = False
        '
        'LblArquivosAnexados
        '
        Me.LblArquivosAnexados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblArquivosAnexados.AutoSize = True
        Me.LblArquivosAnexados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblArquivosAnexados.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LblArquivosAnexados.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LblArquivosAnexados.Location = New System.Drawing.Point(199, 318)
        Me.LblArquivosAnexados.Name = "LblArquivosAnexados"
        Me.LblArquivosAnexados.Size = New System.Drawing.Size(127, 14)
        Me.LblArquivosAnexados.TabIndex = 9
        Me.LblArquivosAnexados.Text = "(0) arquivos anexados"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.GridArquivos)
        Me.Panel1.Location = New System.Drawing.Point(6, 208)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(320, 97)
        Me.Panel1.TabIndex = 10
        Me.Panel1.Visible = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Brown
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(290, -1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(25, 22)
        Me.Button3.TabIndex = 12
        Me.Button3.TabStop = False
        Me.Button3.Text = "x"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(0, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 14)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Arquivos"
        '
        'GridArquivos
        '
        Me.GridArquivos.AllowUserToAddRows = False
        Me.GridArquivos.AllowUserToDeleteRows = False
        Me.GridArquivos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridArquivos.BackgroundColor = System.Drawing.Color.White
        Me.GridArquivos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridArquivos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.GridArquivos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridArquivos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GridArquivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridArquivos.ColumnHeadersVisible = False
        Me.GridArquivos.GridColor = System.Drawing.SystemColors.ControlLight
        Me.GridArquivos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GridArquivos.Location = New System.Drawing.Point(3, 22)
        Me.GridArquivos.MultiSelect = False
        Me.GridArquivos.Name = "GridArquivos"
        Me.GridArquivos.ReadOnly = True
        Me.GridArquivos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray
        Me.GridArquivos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GridArquivos.RowHeadersVisible = False
        Me.GridArquivos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.GridArquivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridArquivos.Size = New System.Drawing.Size(312, 71)
        Me.GridArquivos.TabIndex = 13
        Me.GridArquivos.TabStop = False
        '
        'FrmEnviarEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 345)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblArquivosAnexados)
        Me.Controls.Add(Me.BtnAnexar)
        Me.Controls.Add(Me.BtnEnviar)
        Me.Controls.Add(Me.TxtAssunto)
        Me.Controls.Add(Me.LblAssunto)
        Me.Controls.Add(Me.BuscarEmailCadastro)
        Me.Controls.Add(Me.BtnAdicionarEmail)
        Me.Controls.Add(Me.LblPara)
        Me.Controls.Add(Me.TxtDestinatario)
        Me.MinimizeBox = False
        Me.Name = "FrmEnviarEmail"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enviar email"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridArquivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAdicionarEmail As Button
    Friend WithEvents LblPara As Label
    Friend WithEvents TxtDestinatario As TextBox
    Friend WithEvents BuscarEmailCadastro As Button
    Private WithEvents BtnEnviar As Button
    Private WithEvents BtnAnexar As Button
    Friend WithEvents Panel1 As Panel
    Private WithEvents GridArquivos As DataGridView
    Friend WithEvents Label3 As Label
    Private WithEvents Button3 As Button
    Private WithEvents LblAssunto As Label
    Private WithEvents TxtAssunto As TextBox
    Private WithEvents LblArquivosAnexados As Label
End Class
