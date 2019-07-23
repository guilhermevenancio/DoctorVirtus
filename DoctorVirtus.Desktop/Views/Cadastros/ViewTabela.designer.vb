<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewTabela
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewTabela))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtEmbalagem = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.BtnProcurar = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.ChkPermiteFracionar = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnProcurarFormaPagamento = New System.Windows.Forms.Button()
        Me.TxtFormaPagamentoID = New System.Windows.Forms.TextBox()
        Me.TxtFormaPagamentoDescricao = New System.Windows.Forms.TextBox()
        Me.LblFormaPagamento = New System.Windows.Forms.Label()
        Me.AutoLabel15 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.TxtTabelaID = New Syncfusion.Windows.Forms.Tools.IntegerTextBox()
        Me.TxtDescricao = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.AutoLabel19 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.AutoLabel20 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.TxtValorCHUCO = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.GroupBox6.SuspendLayout()
        CType(Me.TxtTabelaID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDescricao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtValorCHUCO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(92, 147)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 16)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Embalag."
        '
        'TxtEmbalagem
        '
        Me.TxtEmbalagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEmbalagem.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.TxtEmbalagem.Location = New System.Drawing.Point(95, 166)
        Me.TxtEmbalagem.Name = "TxtEmbalagem"
        Me.TxtEmbalagem.Size = New System.Drawing.Size(73, 23)
        Me.TxtEmbalagem.TabIndex = 33
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Enabled = False
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(491, 262)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(26, 23)
        Me.Button3.TabIndex = 29
        Me.Button3.TabStop = False
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(245, 243)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(175, 16)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Código barras (EAN / GTIN)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(7, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Estoque"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(189, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 16)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Venda (R$)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(7, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Custo (R$)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(396, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Unidade Medida"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.BtnProcurar)
        Me.GroupBox6.Controls.Add(Me.BtnExcluir)
        Me.GroupBox6.Controls.Add(Me.BtnLimpar)
        Me.GroupBox6.Controls.Add(Me.BtnSalvar)
        Me.GroupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox6.Location = New System.Drawing.Point(-2, -4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox6.Size = New System.Drawing.Size(499, 43)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        '
        'BtnProcurar
        '
        Me.BtnProcurar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnProcurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnProcurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProcurar.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.BtnProcurar.ForeColor = System.Drawing.Color.White
        Me.BtnProcurar.Image = CType(resources.GetObject("BtnProcurar.Image"), System.Drawing.Image)
        Me.BtnProcurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProcurar.Location = New System.Drawing.Point(97, 10)
        Me.BtnProcurar.Name = "BtnProcurar"
        Me.BtnProcurar.Size = New System.Drawing.Size(81, 28)
        Me.BtnProcurar.TabIndex = 2
        Me.BtnProcurar.TabStop = False
        Me.BtnProcurar.Text = "Procurar"
        Me.BtnProcurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnProcurar.UseVisualStyleBackColor = False
        '
        'BtnExcluir
        '
        Me.BtnExcluir.BackColor = System.Drawing.Color.Red
        Me.BtnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExcluir.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.BtnExcluir.ForeColor = System.Drawing.Color.White
        Me.BtnExcluir.Image = CType(resources.GetObject("BtnExcluir.Image"), System.Drawing.Image)
        Me.BtnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExcluir.Location = New System.Drawing.Point(273, 10)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(81, 28)
        Me.BtnExcluir.TabIndex = 4
        Me.BtnExcluir.TabStop = False
        Me.BtnExcluir.Text = "Excluir"
        Me.BtnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExcluir.UseVisualStyleBackColor = False
        '
        'BtnLimpar
        '
        Me.BtnLimpar.BackColor = System.Drawing.Color.Gray
        Me.BtnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpar.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.BtnLimpar.ForeColor = System.Drawing.Color.White
        Me.BtnLimpar.Image = CType(resources.GetObject("BtnLimpar.Image"), System.Drawing.Image)
        Me.BtnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpar.Location = New System.Drawing.Point(12, 10)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(81, 28)
        Me.BtnLimpar.TabIndex = 1
        Me.BtnLimpar.TabStop = False
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpar.UseVisualStyleBackColor = False
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvar.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.BtnSalvar.ForeColor = System.Drawing.Color.White
        Me.BtnSalvar.Image = CType(resources.GetObject("BtnSalvar.Image"), System.Drawing.Image)
        Me.BtnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalvar.Location = New System.Drawing.Point(184, 10)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(81, 28)
        Me.BtnSalvar.TabIndex = 3
        Me.BtnSalvar.TabStop = False
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalvar.UseVisualStyleBackColor = False
        '
        'ChkPermiteFracionar
        '
        Me.ChkPermiteFracionar.AutoSize = True
        Me.ChkPermiteFracionar.Checked = True
        Me.ChkPermiteFracionar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkPermiteFracionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkPermiteFracionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.ChkPermiteFracionar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ChkPermiteFracionar.Location = New System.Drawing.Point(532, 205)
        Me.ChkPermiteFracionar.Name = "ChkPermiteFracionar"
        Me.ChkPermiteFracionar.Size = New System.Drawing.Size(128, 20)
        Me.ChkPermiteFracionar.TabIndex = 20
        Me.ChkPermiteFracionar.Text = "Permite fracionar"
        Me.ChkPermiteFracionar.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label12.Location = New System.Drawing.Point(120, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 16)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Markup"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(7, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Comercialização"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label26.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label26.Location = New System.Drawing.Point(171, 192)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(151, 14)
        Me.Label26.TabIndex = 141
        Me.Label26.Text = "Limite de estoque em dias"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label25.Location = New System.Drawing.Point(242, 147)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(36, 16)
        Me.Label25.TabIndex = 139
        Me.Label25.Text = "Máx."
        '
        'TextBox7
        '
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.TextBox7.Location = New System.Drawing.Point(245, 166)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(65, 23)
        Me.TextBox7.TabIndex = 140
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label24.Location = New System.Drawing.Point(171, 147)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(32, 16)
        Me.Label24.TabIndex = 137
        Me.Label24.Text = "Min."
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.TextBox6.Location = New System.Drawing.Point(174, 166)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(65, 23)
        Me.TextBox6.TabIndex = 138
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CheckBox1.Location = New System.Drawing.Point(305, 100)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(95, 20)
        Me.CheckBox1.TabIndex = 135
        Me.CheckBox1.Text = "Markup (%)"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(323, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 21)
        Me.Button1.TabIndex = 133
        Me.Button1.TabStop = False
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.TextBox1.Location = New System.Drawing.Point(287, 33)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(62, 23)
        Me.TextBox1.TabIndex = 132
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox2.Location = New System.Drawing.Point(348, 33)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(10)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(208, 23)
        Me.TextBox2.TabIndex = 134
        Me.TextBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(284, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "Categoria"
        '
        'BtnProcurarFormaPagamento
        '
        Me.BtnProcurarFormaPagamento.BackColor = System.Drawing.SystemColors.Control
        Me.BtnProcurarFormaPagamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProcurarFormaPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProcurarFormaPagamento.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BtnProcurarFormaPagamento.Image = CType(resources.GetObject("BtnProcurarFormaPagamento.Image"), System.Drawing.Image)
        Me.BtnProcurarFormaPagamento.Location = New System.Drawing.Point(46, 34)
        Me.BtnProcurarFormaPagamento.Name = "BtnProcurarFormaPagamento"
        Me.BtnProcurarFormaPagamento.Size = New System.Drawing.Size(25, 21)
        Me.BtnProcurarFormaPagamento.TabIndex = 129
        Me.BtnProcurarFormaPagamento.TabStop = False
        Me.BtnProcurarFormaPagamento.UseVisualStyleBackColor = False
        '
        'TxtFormaPagamentoID
        '
        Me.TxtFormaPagamentoID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFormaPagamentoID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFormaPagamentoID.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.TxtFormaPagamentoID.Location = New System.Drawing.Point(10, 33)
        Me.TxtFormaPagamentoID.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtFormaPagamentoID.Name = "TxtFormaPagamentoID"
        Me.TxtFormaPagamentoID.Size = New System.Drawing.Size(62, 23)
        Me.TxtFormaPagamentoID.TabIndex = 128
        '
        'TxtFormaPagamentoDescricao
        '
        Me.TxtFormaPagamentoDescricao.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TxtFormaPagamentoDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFormaPagamentoDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFormaPagamentoDescricao.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.TxtFormaPagamentoDescricao.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtFormaPagamentoDescricao.Location = New System.Drawing.Point(71, 33)
        Me.TxtFormaPagamentoDescricao.Margin = New System.Windows.Forms.Padding(10)
        Me.TxtFormaPagamentoDescricao.Name = "TxtFormaPagamentoDescricao"
        Me.TxtFormaPagamentoDescricao.ReadOnly = True
        Me.TxtFormaPagamentoDescricao.Size = New System.Drawing.Size(209, 23)
        Me.TxtFormaPagamentoDescricao.TabIndex = 130
        Me.TxtFormaPagamentoDescricao.TabStop = False
        '
        'LblFormaPagamento
        '
        Me.LblFormaPagamento.AutoSize = True
        Me.LblFormaPagamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.LblFormaPagamento.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LblFormaPagamento.Location = New System.Drawing.Point(7, 14)
        Me.LblFormaPagamento.Name = "LblFormaPagamento"
        Me.LblFormaPagamento.Size = New System.Drawing.Size(45, 16)
        Me.LblFormaPagamento.TabIndex = 127
        Me.LblFormaPagamento.Text = "Grupo"
        '
        'AutoLabel15
        '
        Me.AutoLabel15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoLabel15.ForeColor = System.Drawing.Color.Black
        Me.AutoLabel15.Location = New System.Drawing.Point(8, 46)
        Me.AutoLabel15.Name = "AutoLabel15"
        Me.AutoLabel15.Size = New System.Drawing.Size(45, 15)
        Me.AutoLabel15.TabIndex = 5
        Me.AutoLabel15.Text = "Código"
        '
        'TxtTabelaID
        '
        Me.TxtTabelaID.AllowNull = True
        Me.TxtTabelaID.BackGroundColor = System.Drawing.Color.Bisque
        Me.TxtTabelaID.BeforeTouchSize = New System.Drawing.Size(86, 25)
        Me.TxtTabelaID.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.TxtTabelaID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTabelaID.FocusBorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtTabelaID.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TxtTabelaID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtTabelaID.IntegerValue = CType(0, Long)
        Me.TxtTabelaID.Location = New System.Drawing.Point(10, 64)
        Me.TxtTabelaID.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TxtTabelaID.Name = "TxtTabelaID"
        Me.TxtTabelaID.NullString = ""
        Me.TxtTabelaID.NumberGroupSeparator = ""
        Me.TxtTabelaID.Size = New System.Drawing.Size(60, 25)
        Me.TxtTabelaID.TabIndex = 6
        '
        'TxtDescricao
        '
        Me.TxtDescricao.BackColor = System.Drawing.Color.White
        Me.TxtDescricao.BeforeTouchSize = New System.Drawing.Size(86, 25)
        Me.TxtDescricao.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.TxtDescricao.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescricao.FocusBorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtDescricao.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TxtDescricao.ForeColor = System.Drawing.Color.Black
        Me.TxtDescricao.Location = New System.Drawing.Point(76, 64)
        Me.TxtDescricao.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TxtDescricao.Name = "TxtDescricao"
        Me.TxtDescricao.Size = New System.Drawing.Size(410, 25)
        Me.TxtDescricao.TabIndex = 8
        '
        'AutoLabel19
        '
        Me.AutoLabel19.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoLabel19.ForeColor = System.Drawing.Color.Black
        Me.AutoLabel19.Location = New System.Drawing.Point(73, 46)
        Me.AutoLabel19.Name = "AutoLabel19"
        Me.AutoLabel19.Size = New System.Drawing.Size(59, 15)
        Me.AutoLabel19.TabIndex = 7
        Me.AutoLabel19.Text = "Descrição"
        '
        'AutoLabel20
        '
        Me.AutoLabel20.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoLabel20.ForeColor = System.Drawing.Color.Black
        Me.AutoLabel20.Location = New System.Drawing.Point(10, 105)
        Me.AutoLabel20.Name = "AutoLabel20"
        Me.AutoLabel20.Size = New System.Drawing.Size(82, 15)
        Me.AutoLabel20.TabIndex = 9
        Me.AutoLabel20.Text = "Valor CH/UCO"
        '
        'TxtValorCHUCO
        '
        Me.TxtValorCHUCO.BeforeTouchSize = New System.Drawing.Size(86, 25)
        Me.TxtValorCHUCO.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.TxtValorCHUCO.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtValorCHUCO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtValorCHUCO.DoubleValue = 0R
        Me.TxtValorCHUCO.FocusBorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtValorCHUCO.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TxtValorCHUCO.Location = New System.Drawing.Point(13, 123)
        Me.TxtValorCHUCO.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TxtValorCHUCO.MinValue = 0R
        Me.TxtValorCHUCO.Name = "TxtValorCHUCO"
        Me.TxtValorCHUCO.NullString = ""
        Me.TxtValorCHUCO.Size = New System.Drawing.Size(86, 25)
        Me.TxtValorCHUCO.TabIndex = 10
        Me.TxtValorCHUCO.Text = "0,00"
        Me.TxtValorCHUCO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ViewTabela
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 159)
        Me.Controls.Add(Me.AutoLabel20)
        Me.Controls.Add(Me.TxtValorCHUCO)
        Me.Controls.Add(Me.TxtDescricao)
        Me.Controls.Add(Me.AutoLabel19)
        Me.Controls.Add(Me.TxtTabelaID)
        Me.Controls.Add(Me.AutoLabel15)
        Me.Controls.Add(Me.GroupBox6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewTabela"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Tabela"
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.TxtTabelaID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDescricao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtValorCHUCO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Private WithEvents BtnProcurar As Button
    Private WithEvents BtnExcluir As Button
    Private WithEvents BtnLimpar As Button
    Private WithEvents BtnSalvar As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtEmbalagem As TextBox
    Friend WithEvents ChkPermiteFracionar As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnProcurarFormaPagamento As Button
    Friend WithEvents TxtFormaPagamentoID As TextBox
    Friend WithEvents TxtFormaPagamentoDescricao As TextBox
    Friend WithEvents LblFormaPagamento As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label25 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents AutoLabel15 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents TxtTabelaID As Syncfusion.Windows.Forms.Tools.IntegerTextBox
    Friend WithEvents TxtDescricao As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents AutoLabel19 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents AutoLabel20 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents TxtValorCHUCO As Syncfusion.Windows.Forms.Tools.DoubleTextBox
End Class
