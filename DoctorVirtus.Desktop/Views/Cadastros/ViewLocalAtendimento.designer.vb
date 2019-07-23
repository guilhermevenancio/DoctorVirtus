<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewLocalAtendimento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewLocalAtendimento))
        Me.TabPrincipal = New System.Windows.Forms.TabControl()
        Me.Principal = New System.Windows.Forms.TabPage()
        Me.AutoLabel12 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.TxtEmail = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.TxtTelefone3 = New Syncfusion.Windows.Forms.Tools.MaskedEditBox()
        Me.AutoLabel14 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.TxtTelefone2 = New Syncfusion.Windows.Forms.Tools.MaskedEditBox()
        Me.AutoLabel11 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.TxtTelefone1 = New Syncfusion.Windows.Forms.Tools.MaskedEditBox()
        Me.TxtInscricaoMunicipal = New System.Windows.Forms.TextBox()
        Me.AutoLabel3 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.TxtInscEstadual = New System.Windows.Forms.TextBox()
        Me.AutoLabel13 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.LblInscEstadual = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.AutoLabel17 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.AutoLabel10 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.TxtMunicipioNome = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.BtnProcurarMunicipio = New System.Windows.Forms.Button()
        Me.TxtMunicipioID = New Syncfusion.Windows.Forms.Tools.IntegerTextBox()
        Me.AutoLabel9 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.AutoLabel8 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.AutoLabel7 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.AutoLabel6 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.AutoLabel5 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.AutoLabel4 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.TxtCEP = New Syncfusion.Windows.Forms.Tools.MaskedEditBox()
        Me.CboUF = New System.Windows.Forms.ComboBox()
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.TxtBairro = New System.Windows.Forms.TextBox()
        Me.TxtComplemento = New System.Windows.Forms.TextBox()
        Me.TxtLogradouro = New System.Windows.Forms.TextBox()
        Me.BtnCEP = New System.Windows.Forms.Button()
        Me.BtnReceitaFederal = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnProcurar = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.TxtRazaoSocial = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.LblRazaoSocial = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.LblCNPJ = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.TxtNomeFantasia = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.LblNomeFantasia = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.AutoLabel1 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.TxtLocalAtendimentoID = New Syncfusion.Windows.Forms.Tools.IntegerTextBox()
        Me.TxtCNPJ = New Syncfusion.Windows.Forms.Tools.MaskedEditBox()
        Me.TabPrincipal.SuspendLayout()
        Me.Principal.SuspendLayout()
        CType(Me.TxtEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTelefone3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTelefone2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTelefone1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TxtMunicipioNome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMunicipioID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.TxtRazaoSocial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNomeFantasia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtLocalAtendimentoID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCNPJ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabPrincipal
        '
        Me.TabPrincipal.Controls.Add(Me.Principal)
        Me.TabPrincipal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPrincipal.Location = New System.Drawing.Point(10, 101)
        Me.TabPrincipal.Name = "TabPrincipal"
        Me.TabPrincipal.SelectedIndex = 0
        Me.TabPrincipal.Size = New System.Drawing.Size(777, 274)
        Me.TabPrincipal.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabPrincipal.TabIndex = 16
        '
        'Principal
        '
        Me.Principal.BackColor = System.Drawing.SystemColors.Control
        Me.Principal.Controls.Add(Me.GroupBox3)
        Me.Principal.Controls.Add(Me.AutoLabel12)
        Me.Principal.Controls.Add(Me.TxtEmail)
        Me.Principal.Controls.Add(Me.TxtTelefone3)
        Me.Principal.Controls.Add(Me.AutoLabel14)
        Me.Principal.Controls.Add(Me.TxtTelefone2)
        Me.Principal.Controls.Add(Me.AutoLabel11)
        Me.Principal.Controls.Add(Me.TxtTelefone1)
        Me.Principal.Controls.Add(Me.TxtInscricaoMunicipal)
        Me.Principal.Controls.Add(Me.AutoLabel3)
        Me.Principal.Controls.Add(Me.TxtInscEstadual)
        Me.Principal.Controls.Add(Me.AutoLabel13)
        Me.Principal.Controls.Add(Me.LblInscEstadual)
        Me.Principal.ForeColor = System.Drawing.Color.Black
        Me.Principal.Location = New System.Drawing.Point(4, 22)
        Me.Principal.Name = "Principal"
        Me.Principal.Padding = New System.Windows.Forms.Padding(3)
        Me.Principal.Size = New System.Drawing.Size(769, 248)
        Me.Principal.TabIndex = 0
        Me.Principal.Text = "Principal"
        '
        'AutoLabel12
        '
        Me.AutoLabel12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoLabel12.Location = New System.Drawing.Point(339, 11)
        Me.AutoLabel12.Name = "AutoLabel12"
        Me.AutoLabel12.Size = New System.Drawing.Size(36, 15)
        Me.AutoLabel12.TabIndex = 40
        Me.AutoLabel12.Text = "Email"
        '
        'TxtEmail
        '
        Me.TxtEmail.BackColor = System.Drawing.Color.White
        Me.TxtEmail.BeforeTouchSize = New System.Drawing.Size(140, 25)
        Me.TxtEmail.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.TxtEmail.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtEmail.FocusBorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtEmail.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TxtEmail.ForeColor = System.Drawing.Color.Black
        Me.TxtEmail.Location = New System.Drawing.Point(342, 28)
        Me.TxtEmail.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TxtEmail.MinimumSize = New System.Drawing.Size(8, 4)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(315, 25)
        Me.TxtEmail.TabIndex = 41
        '
        'TxtTelefone3
        '
        Me.TxtTelefone3.BeforeTouchSize = New System.Drawing.Size(140, 25)
        Me.TxtTelefone3.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.TxtTelefone3.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtTelefone3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTelefone3.ClipMode = Syncfusion.Windows.Forms.Tools.ClipModes.ExcludeLiterals
        Me.TxtTelefone3.FocusBorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtTelefone3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefone3.HideSelection = False
        Me.TxtTelefone3.Location = New System.Drawing.Point(231, 28)
        Me.TxtTelefone3.Mask = "(##) #########"
        Me.TxtTelefone3.MaxLength = 14
        Me.TxtTelefone3.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TxtTelefone3.Name = "TxtTelefone3"
        Me.TxtTelefone3.Size = New System.Drawing.Size(105, 25)
        Me.TxtTelefone3.TabIndex = 39
        Me.TxtTelefone3.UsageMode = Syncfusion.Windows.Forms.Tools.MaskedUsageMode.Numeric
        '
        'AutoLabel14
        '
        Me.AutoLabel14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoLabel14.Location = New System.Drawing.Point(228, 10)
        Me.AutoLabel14.Name = "AutoLabel14"
        Me.AutoLabel14.Size = New System.Drawing.Size(43, 15)
        Me.AutoLabel14.TabIndex = 38
        Me.AutoLabel14.Text = "Celular"
        '
        'TxtTelefone2
        '
        Me.TxtTelefone2.BeforeTouchSize = New System.Drawing.Size(140, 25)
        Me.TxtTelefone2.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.TxtTelefone2.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtTelefone2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTelefone2.ClipMode = Syncfusion.Windows.Forms.Tools.ClipModes.ExcludeLiterals
        Me.TxtTelefone2.FocusBorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtTelefone2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefone2.HideSelection = False
        Me.TxtTelefone2.Location = New System.Drawing.Point(120, 28)
        Me.TxtTelefone2.Mask = "(##) #########"
        Me.TxtTelefone2.MaxLength = 14
        Me.TxtTelefone2.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TxtTelefone2.Name = "TxtTelefone2"
        Me.TxtTelefone2.Size = New System.Drawing.Size(105, 25)
        Me.TxtTelefone2.TabIndex = 37
        Me.TxtTelefone2.UsageMode = Syncfusion.Windows.Forms.Tools.MaskedUsageMode.Numeric
        '
        'AutoLabel11
        '
        Me.AutoLabel11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoLabel11.Location = New System.Drawing.Point(117, 10)
        Me.AutoLabel11.Name = "AutoLabel11"
        Me.AutoLabel11.Size = New System.Drawing.Size(43, 15)
        Me.AutoLabel11.TabIndex = 36
        Me.AutoLabel11.Text = "Celular"
        '
        'TxtTelefone1
        '
        Me.TxtTelefone1.BeforeTouchSize = New System.Drawing.Size(140, 25)
        Me.TxtTelefone1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.TxtTelefone1.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtTelefone1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTelefone1.ClipMode = Syncfusion.Windows.Forms.Tools.ClipModes.ExcludeLiterals
        Me.TxtTelefone1.FocusBorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtTelefone1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefone1.HideSelection = False
        Me.TxtTelefone1.Location = New System.Drawing.Point(9, 28)
        Me.TxtTelefone1.Mask = "(##) #########"
        Me.TxtTelefone1.MaxLength = 14
        Me.TxtTelefone1.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TxtTelefone1.Name = "TxtTelefone1"
        Me.TxtTelefone1.Size = New System.Drawing.Size(105, 25)
        Me.TxtTelefone1.TabIndex = 35
        Me.TxtTelefone1.UsageMode = Syncfusion.Windows.Forms.Tools.MaskedUsageMode.Numeric
        '
        'TxtInscricaoMunicipal
        '
        Me.TxtInscricaoMunicipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtInscricaoMunicipal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtInscricaoMunicipal.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TxtInscricaoMunicipal.Location = New System.Drawing.Point(159, 82)
        Me.TxtInscricaoMunicipal.MaxLength = 15
        Me.TxtInscricaoMunicipal.Name = "TxtInscricaoMunicipal"
        Me.TxtInscricaoMunicipal.Size = New System.Drawing.Size(144, 25)
        Me.TxtInscricaoMunicipal.TabIndex = 34
        Me.TxtInscricaoMunicipal.Visible = False
        '
        'AutoLabel3
        '
        Me.AutoLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoLabel3.Location = New System.Drawing.Point(156, 64)
        Me.AutoLabel3.Name = "AutoLabel3"
        Me.AutoLabel3.Size = New System.Drawing.Size(88, 15)
        Me.AutoLabel3.TabIndex = 33
        Me.AutoLabel3.Text = "Insc. Municipal"
        Me.AutoLabel3.Visible = False
        '
        'TxtInscEstadual
        '
        Me.TxtInscEstadual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtInscEstadual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtInscEstadual.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TxtInscEstadual.Location = New System.Drawing.Point(9, 82)
        Me.TxtInscEstadual.MaxLength = 15
        Me.TxtInscEstadual.Name = "TxtInscEstadual"
        Me.TxtInscEstadual.Size = New System.Drawing.Size(144, 25)
        Me.TxtInscEstadual.TabIndex = 24
        Me.TxtInscEstadual.Visible = False
        '
        'AutoLabel13
        '
        Me.AutoLabel13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoLabel13.Location = New System.Drawing.Point(6, 10)
        Me.AutoLabel13.Name = "AutoLabel13"
        Me.AutoLabel13.Size = New System.Drawing.Size(52, 15)
        Me.AutoLabel13.TabIndex = 17
        Me.AutoLabel13.Text = "Telefone"
        '
        'LblInscEstadual
        '
        Me.LblInscEstadual.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInscEstadual.Location = New System.Drawing.Point(6, 64)
        Me.LblInscEstadual.Name = "LblInscEstadual"
        Me.LblInscEstadual.Size = New System.Drawing.Size(79, 15)
        Me.LblInscEstadual.TabIndex = 23
        Me.LblInscEstadual.Text = "Insc. Estadual"
        Me.LblInscEstadual.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.AutoLabel17)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.AutoLabel10)
        Me.GroupBox3.Controls.Add(Me.TxtMunicipioNome)
        Me.GroupBox3.Controls.Add(Me.BtnProcurarMunicipio)
        Me.GroupBox3.Controls.Add(Me.TxtMunicipioID)
        Me.GroupBox3.Controls.Add(Me.AutoLabel9)
        Me.GroupBox3.Controls.Add(Me.AutoLabel8)
        Me.GroupBox3.Controls.Add(Me.AutoLabel7)
        Me.GroupBox3.Controls.Add(Me.AutoLabel6)
        Me.GroupBox3.Controls.Add(Me.AutoLabel5)
        Me.GroupBox3.Controls.Add(Me.AutoLabel4)
        Me.GroupBox3.Controls.Add(Me.TxtCEP)
        Me.GroupBox3.Controls.Add(Me.CboUF)
        Me.GroupBox3.Controls.Add(Me.TxtNumero)
        Me.GroupBox3.Controls.Add(Me.TxtBairro)
        Me.GroupBox3.Controls.Add(Me.TxtComplemento)
        Me.GroupBox3.Controls.Add(Me.TxtLogradouro)
        Me.GroupBox3.Controls.Add(Me.BtnCEP)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox3.Location = New System.Drawing.Point(4, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(760, 180)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Endereço"
        '
        'AutoLabel17
        '
        Me.AutoLabel17.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoLabel17.Location = New System.Drawing.Point(492, 75)
        Me.AutoLabel17.Name = "AutoLabel17"
        Me.AutoLabel17.Size = New System.Drawing.Size(62, 15)
        Me.AutoLabel17.TabIndex = 42
        Me.AutoLabel17.Text = "Referência"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TextBox1.Location = New System.Drawing.Point(492, 93)
        Me.TextBox1.MaxLength = 30
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(264, 25)
        Me.TextBox1.TabIndex = 43
        '
        'AutoLabel10
        '
        Me.AutoLabel10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoLabel10.Location = New System.Drawing.Point(489, 125)
        Me.AutoLabel10.Name = "AutoLabel10"
        Me.AutoLabel10.Size = New System.Drawing.Size(43, 15)
        Me.AutoLabel10.TabIndex = 48
        Me.AutoLabel10.Text = "Cidade"
        '
        'TxtMunicipioNome
        '
        Me.TxtMunicipioNome.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TxtMunicipioNome.BeforeTouchSize = New System.Drawing.Size(140, 25)
        Me.TxtMunicipioNome.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.TxtMunicipioNome.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtMunicipioNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMunicipioNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMunicipioNome.FocusBorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtMunicipioNome.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TxtMunicipioNome.ForeColor = System.Drawing.Color.Black
        Me.TxtMunicipioNome.Location = New System.Drawing.Point(555, 143)
        Me.TxtMunicipioNome.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TxtMunicipioNome.Name = "TxtMunicipioNome"
        Me.TxtMunicipioNome.ReadOnly = True
        Me.TxtMunicipioNome.Size = New System.Drawing.Size(201, 25)
        Me.TxtMunicipioNome.TabIndex = 51
        Me.TxtMunicipioNome.TabStop = False
        '
        'BtnProcurarMunicipio
        '
        Me.BtnProcurarMunicipio.BackColor = System.Drawing.SystemColors.Control
        Me.BtnProcurarMunicipio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProcurarMunicipio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProcurarMunicipio.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BtnProcurarMunicipio.Image = CType(resources.GetObject("BtnProcurarMunicipio.Image"), System.Drawing.Image)
        Me.BtnProcurarMunicipio.Location = New System.Drawing.Point(528, 144)
        Me.BtnProcurarMunicipio.Name = "BtnProcurarMunicipio"
        Me.BtnProcurarMunicipio.Size = New System.Drawing.Size(27, 23)
        Me.BtnProcurarMunicipio.TabIndex = 50
        Me.BtnProcurarMunicipio.TabStop = False
        Me.BtnProcurarMunicipio.UseVisualStyleBackColor = False
        '
        'TxtMunicipioID
        '
        Me.TxtMunicipioID.AllowNull = True
        Me.TxtMunicipioID.BeforeTouchSize = New System.Drawing.Size(140, 25)
        Me.TxtMunicipioID.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.TxtMunicipioID.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtMunicipioID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMunicipioID.FocusBorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtMunicipioID.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TxtMunicipioID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtMunicipioID.IntegerValue = CType(0, Long)
        Me.TxtMunicipioID.Location = New System.Drawing.Point(492, 143)
        Me.TxtMunicipioID.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TxtMunicipioID.MinValue = CType(0, Long)
        Me.TxtMunicipioID.Name = "TxtMunicipioID"
        Me.TxtMunicipioID.NullString = ""
        Me.TxtMunicipioID.NumberGroupSeparator = ""
        Me.TxtMunicipioID.Size = New System.Drawing.Size(64, 25)
        Me.TxtMunicipioID.TabIndex = 49
        '
        'AutoLabel9
        '
        Me.AutoLabel9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoLabel9.Location = New System.Drawing.Point(441, 125)
        Me.AutoLabel9.Name = "AutoLabel9"
        Me.AutoLabel9.Size = New System.Drawing.Size(21, 15)
        Me.AutoLabel9.TabIndex = 46
        Me.AutoLabel9.Text = "UF"
        '
        'AutoLabel8
        '
        Me.AutoLabel8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoLabel8.Location = New System.Drawing.Point(4, 125)
        Me.AutoLabel8.Name = "AutoLabel8"
        Me.AutoLabel8.Size = New System.Drawing.Size(38, 15)
        Me.AutoLabel8.TabIndex = 44
        Me.AutoLabel8.Text = "Bairro"
        '
        'AutoLabel7
        '
        Me.AutoLabel7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoLabel7.Location = New System.Drawing.Point(118, 75)
        Me.AutoLabel7.Name = "AutoLabel7"
        Me.AutoLabel7.Size = New System.Drawing.Size(83, 15)
        Me.AutoLabel7.TabIndex = 40
        Me.AutoLabel7.Text = "Complemento"
        '
        'AutoLabel6
        '
        Me.AutoLabel6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoLabel6.Location = New System.Drawing.Point(4, 75)
        Me.AutoLabel6.Name = "AutoLabel6"
        Me.AutoLabel6.Size = New System.Drawing.Size(51, 15)
        Me.AutoLabel6.TabIndex = 38
        Me.AutoLabel6.Text = "Número"
        '
        'AutoLabel5
        '
        Me.AutoLabel5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoLabel5.Location = New System.Drawing.Point(118, 25)
        Me.AutoLabel5.Name = "AutoLabel5"
        Me.AutoLabel5.Size = New System.Drawing.Size(69, 15)
        Me.AutoLabel5.TabIndex = 36
        Me.AutoLabel5.Text = "Logradouro"
        '
        'AutoLabel4
        '
        Me.AutoLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoLabel4.Location = New System.Drawing.Point(4, 25)
        Me.AutoLabel4.Name = "AutoLabel4"
        Me.AutoLabel4.Size = New System.Drawing.Size(27, 15)
        Me.AutoLabel4.TabIndex = 33
        Me.AutoLabel4.Text = "CEP"
        '
        'TxtCEP
        '
        Me.TxtCEP.BeforeTouchSize = New System.Drawing.Size(140, 25)
        Me.TxtCEP.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.TxtCEP.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtCEP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCEP.ClipMode = Syncfusion.Windows.Forms.Tools.ClipModes.ExcludeLiterals
        Me.TxtCEP.FocusBorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtCEP.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCEP.HideSelection = False
        Me.TxtCEP.Location = New System.Drawing.Point(5, 43)
        Me.TxtCEP.Mask = "##,###-###"
        Me.TxtCEP.MaxLength = 10
        Me.TxtCEP.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TxtCEP.Name = "TxtCEP"
        Me.TxtCEP.Size = New System.Drawing.Size(79, 25)
        Me.TxtCEP.TabIndex = 34
        Me.TxtCEP.UsageMode = Syncfusion.Windows.Forms.Tools.MaskedUsageMode.Numeric
        '
        'CboUF
        '
        Me.CboUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboUF.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.CboUF.FormattingEnabled = True
        Me.CboUF.Items.AddRange(New Object() {"AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO"})
        Me.CboUF.Location = New System.Drawing.Point(442, 143)
        Me.CboUF.Name = "CboUF"
        Me.CboUF.Size = New System.Drawing.Size(44, 25)
        Me.CboUF.TabIndex = 47
        '
        'TxtNumero
        '
        Me.TxtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNumero.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TxtNumero.Location = New System.Drawing.Point(5, 93)
        Me.TxtNumero.MaxLength = 30
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(107, 25)
        Me.TxtNumero.TabIndex = 39
        '
        'TxtBairro
        '
        Me.TxtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBairro.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TxtBairro.Location = New System.Drawing.Point(4, 143)
        Me.TxtBairro.MaxLength = 50
        Me.TxtBairro.Name = "TxtBairro"
        Me.TxtBairro.Size = New System.Drawing.Size(432, 25)
        Me.TxtBairro.TabIndex = 45
        '
        'TxtComplemento
        '
        Me.TxtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtComplemento.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TxtComplemento.Location = New System.Drawing.Point(118, 93)
        Me.TxtComplemento.MaxLength = 30
        Me.TxtComplemento.Name = "TxtComplemento"
        Me.TxtComplemento.Size = New System.Drawing.Size(368, 25)
        Me.TxtComplemento.TabIndex = 41
        '
        'TxtLogradouro
        '
        Me.TxtLogradouro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLogradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLogradouro.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TxtLogradouro.Location = New System.Drawing.Point(118, 43)
        Me.TxtLogradouro.MaxLength = 80
        Me.TxtLogradouro.Name = "TxtLogradouro"
        Me.TxtLogradouro.Size = New System.Drawing.Size(638, 25)
        Me.TxtLogradouro.TabIndex = 37
        '
        'BtnCEP
        '
        Me.BtnCEP.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCEP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCEP.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnCEP.Image = CType(resources.GetObject("BtnCEP.Image"), System.Drawing.Image)
        Me.BtnCEP.Location = New System.Drawing.Point(83, 43)
        Me.BtnCEP.Name = "BtnCEP"
        Me.BtnCEP.Size = New System.Drawing.Size(29, 25)
        Me.BtnCEP.TabIndex = 35
        Me.BtnCEP.TabStop = False
        Me.BtnCEP.UseVisualStyleBackColor = False
        '
        'BtnReceitaFederal
        '
        Me.BtnReceitaFederal.BackColor = System.Drawing.SystemColors.Control
        Me.BtnReceitaFederal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReceitaFederal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReceitaFederal.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnReceitaFederal.Image = CType(resources.GetObject("BtnReceitaFederal.Image"), System.Drawing.Image)
        Me.BtnReceitaFederal.Location = New System.Drawing.Point(215, 65)
        Me.BtnReceitaFederal.Name = "BtnReceitaFederal"
        Me.BtnReceitaFederal.Size = New System.Drawing.Size(28, 25)
        Me.BtnReceitaFederal.TabIndex = 11
        Me.BtnReceitaFederal.TabStop = False
        Me.BtnReceitaFederal.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.BtnProcurar)
        Me.GroupBox4.Controls.Add(Me.BtnExcluir)
        Me.GroupBox4.Controls.Add(Me.BtnLimpar)
        Me.GroupBox4.Controls.Add(Me.BtnSalvar)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Location = New System.Drawing.Point(-2, -4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox4.Size = New System.Drawing.Size(795, 43)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
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
        Me.BtnProcurar.Location = New System.Drawing.Point(99, 10)
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
        Me.BtnSalvar.Location = New System.Drawing.Point(186, 10)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(81, 28)
        Me.BtnSalvar.TabIndex = 3
        Me.BtnSalvar.TabStop = False
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalvar.UseVisualStyleBackColor = False
        '
        'TxtRazaoSocial
        '
        Me.TxtRazaoSocial.BackColor = System.Drawing.Color.White
        Me.TxtRazaoSocial.BeforeTouchSize = New System.Drawing.Size(140, 25)
        Me.TxtRazaoSocial.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.TxtRazaoSocial.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtRazaoSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRazaoSocial.FocusBorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtRazaoSocial.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TxtRazaoSocial.ForeColor = System.Drawing.Color.Black
        Me.TxtRazaoSocial.Location = New System.Drawing.Point(249, 65)
        Me.TxtRazaoSocial.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TxtRazaoSocial.MinimumSize = New System.Drawing.Size(8, 4)
        Me.TxtRazaoSocial.Name = "TxtRazaoSocial"
        Me.TxtRazaoSocial.Size = New System.Drawing.Size(280, 25)
        Me.TxtRazaoSocial.TabIndex = 13
        '
        'LblRazaoSocial
        '
        Me.LblRazaoSocial.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRazaoSocial.Location = New System.Drawing.Point(246, 48)
        Me.LblRazaoSocial.Name = "LblRazaoSocial"
        Me.LblRazaoSocial.Size = New System.Drawing.Size(72, 15)
        Me.LblRazaoSocial.TabIndex = 12
        Me.LblRazaoSocial.Text = "Razão social"
        '
        'LblCNPJ
        '
        Me.LblCNPJ.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCNPJ.Location = New System.Drawing.Point(73, 48)
        Me.LblCNPJ.Name = "LblCNPJ"
        Me.LblCNPJ.Size = New System.Drawing.Size(34, 15)
        Me.LblCNPJ.TabIndex = 9
        Me.LblCNPJ.Text = "CNPJ"
        '
        'TxtNomeFantasia
        '
        Me.TxtNomeFantasia.BackColor = System.Drawing.Color.White
        Me.TxtNomeFantasia.BeforeTouchSize = New System.Drawing.Size(140, 25)
        Me.TxtNomeFantasia.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.TxtNomeFantasia.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtNomeFantasia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNomeFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNomeFantasia.FocusBorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtNomeFantasia.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TxtNomeFantasia.ForeColor = System.Drawing.Color.Black
        Me.TxtNomeFantasia.Location = New System.Drawing.Point(535, 65)
        Me.TxtNomeFantasia.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TxtNomeFantasia.Name = "TxtNomeFantasia"
        Me.TxtNomeFantasia.Size = New System.Drawing.Size(239, 25)
        Me.TxtNomeFantasia.TabIndex = 15
        '
        'LblNomeFantasia
        '
        Me.LblNomeFantasia.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNomeFantasia.Location = New System.Drawing.Point(533, 48)
        Me.LblNomeFantasia.Name = "LblNomeFantasia"
        Me.LblNomeFantasia.Size = New System.Drawing.Size(84, 15)
        Me.LblNomeFantasia.TabIndex = 14
        Me.LblNomeFantasia.Text = "Nome fantasia"
        '
        'AutoLabel1
        '
        Me.AutoLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoLabel1.Location = New System.Drawing.Point(9, 48)
        Me.AutoLabel1.Name = "AutoLabel1"
        Me.AutoLabel1.Size = New System.Drawing.Size(45, 15)
        Me.AutoLabel1.TabIndex = 5
        Me.AutoLabel1.Text = "Código"
        '
        'TxtLocalAtendimentoID
        '
        Me.TxtLocalAtendimentoID.AllowNull = True
        Me.TxtLocalAtendimentoID.BackGroundColor = System.Drawing.Color.Bisque
        Me.TxtLocalAtendimentoID.BeforeTouchSize = New System.Drawing.Size(140, 25)
        Me.TxtLocalAtendimentoID.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.TxtLocalAtendimentoID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLocalAtendimentoID.FocusBorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtLocalAtendimentoID.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TxtLocalAtendimentoID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtLocalAtendimentoID.IntegerValue = CType(0, Long)
        Me.TxtLocalAtendimentoID.Location = New System.Drawing.Point(10, 65)
        Me.TxtLocalAtendimentoID.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TxtLocalAtendimentoID.Name = "TxtLocalAtendimentoID"
        Me.TxtLocalAtendimentoID.NullString = ""
        Me.TxtLocalAtendimentoID.NumberGroupSeparator = ""
        Me.TxtLocalAtendimentoID.Size = New System.Drawing.Size(60, 25)
        Me.TxtLocalAtendimentoID.TabIndex = 6
        '
        'TxtCNPJ
        '
        Me.TxtCNPJ.BeforeTouchSize = New System.Drawing.Size(140, 25)
        Me.TxtCNPJ.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.TxtCNPJ.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtCNPJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCNPJ.ClipMode = Syncfusion.Windows.Forms.Tools.ClipModes.ExcludeLiterals
        Me.TxtCNPJ.FocusBorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtCNPJ.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCNPJ.HideSelection = False
        Me.TxtCNPJ.Location = New System.Drawing.Point(76, 65)
        Me.TxtCNPJ.Mask = "##,###,###/####-##"
        Me.TxtCNPJ.MaxLength = 18
        Me.TxtCNPJ.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TxtCNPJ.Name = "TxtCNPJ"
        Me.TxtCNPJ.Size = New System.Drawing.Size(140, 25)
        Me.TxtCNPJ.TabIndex = 10
        Me.TxtCNPJ.UsageMode = Syncfusion.Windows.Forms.Tools.MaskedUsageMode.Numeric
        '
        'ViewLocalAtendimento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 382)
        Me.Controls.Add(Me.TxtCNPJ)
        Me.Controls.Add(Me.TxtLocalAtendimentoID)
        Me.Controls.Add(Me.AutoLabel1)
        Me.Controls.Add(Me.LblNomeFantasia)
        Me.Controls.Add(Me.TxtNomeFantasia)
        Me.Controls.Add(Me.LblCNPJ)
        Me.Controls.Add(Me.LblRazaoSocial)
        Me.Controls.Add(Me.TxtRazaoSocial)
        Me.Controls.Add(Me.TabPrincipal)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.BtnReceitaFederal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewLocalAtendimento"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Local de atendimento"
        Me.TabPrincipal.ResumeLayout(False)
        Me.Principal.ResumeLayout(False)
        Me.Principal.PerformLayout()
        CType(Me.TxtEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTelefone3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTelefone2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTelefone1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.TxtMunicipioNome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMunicipioID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCEP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.TxtRazaoSocial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNomeFantasia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtLocalAtendimentoID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCNPJ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnReceitaFederal As Button
    Friend WithEvents TabPrincipal As TabControl
    Friend WithEvents GroupBox4 As GroupBox
    Private WithEvents BtnSalvar As Button
    Private WithEvents BtnLimpar As Button
    Private WithEvents BtnExcluir As Button
    Private WithEvents BtnProcurar As Button
    Friend WithEvents TxtRazaoSocial As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents LblRazaoSocial As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents LblCNPJ As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents TxtNomeFantasia As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents LblNomeFantasia As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents AutoLabel1 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents TxtLocalAtendimentoID As Syncfusion.Windows.Forms.Tools.IntegerTextBox
    Friend WithEvents Principal As TabPage
    Friend WithEvents AutoLabel13 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents AutoLabel17 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents AutoLabel10 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents TxtMunicipioNome As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents BtnProcurarMunicipio As Button
    Friend WithEvents TxtMunicipioID As Syncfusion.Windows.Forms.Tools.IntegerTextBox
    Friend WithEvents AutoLabel9 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents AutoLabel8 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents AutoLabel7 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents AutoLabel6 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents AutoLabel5 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents AutoLabel4 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents TxtCEP As Syncfusion.Windows.Forms.Tools.MaskedEditBox
    Friend WithEvents CboUF As ComboBox
    Friend WithEvents TxtNumero As TextBox
    Friend WithEvents TxtBairro As TextBox
    Friend WithEvents TxtComplemento As TextBox
    Friend WithEvents TxtLogradouro As TextBox
    Friend WithEvents BtnCEP As Button
    Friend WithEvents TxtCNPJ As Syncfusion.Windows.Forms.Tools.MaskedEditBox
    Friend WithEvents AutoLabel12 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents TxtEmail As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents TxtTelefone3 As Syncfusion.Windows.Forms.Tools.MaskedEditBox
    Friend WithEvents AutoLabel14 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents TxtTelefone2 As Syncfusion.Windows.Forms.Tools.MaskedEditBox
    Friend WithEvents AutoLabel11 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents TxtTelefone1 As Syncfusion.Windows.Forms.Tools.MaskedEditBox
    Friend WithEvents TxtInscricaoMunicipal As TextBox
    Friend WithEvents AutoLabel3 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents TxtInscEstadual As TextBox
    Friend WithEvents LblInscEstadual As Syncfusion.Windows.Forms.Tools.AutoLabel
End Class
