<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPesquisa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPesquisa))
        Me.Gr = New System.Windows.Forms.GroupBox()
        Me.BtnCadastrar = New System.Windows.Forms.Button()
        Me.AutoLabel2 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.TxtRegistros = New Syncfusion.Windows.Forms.Tools.IntegerTextBox()
        Me.SfComboBox1 = New Syncfusion.WinForms.ListView.SfComboBox()
        Me.AutoLabel1 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.BtnPesquisar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelString = New System.Windows.Forms.Panel()
        Me.AutoLabel3 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.TxtPesquisar = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
        Me.PanelDate = New System.Windows.Forms.Panel()
        Me.LblPeriodo = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.DtFim = New Syncfusion.WinForms.Input.SfDateTimeEdit()
        Me.DtInicio = New Syncfusion.WinForms.Input.SfDateTimeEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GridGroupingControl2 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
        Me.LblCampoCalculaTotal1 = New Syncfusion.Windows.Forms.Tools.AutoLabel()
        Me.TxtCampoCalculaTotal1 = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.Gr.SuspendLayout()
        CType(Me.TxtRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SfComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelString.SuspendLayout()
        CType(Me.TxtPesquisar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDate.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GridGroupingControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCampoCalculaTotal1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gr
        '
        Me.Gr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gr.BackColor = System.Drawing.Color.White
        Me.Gr.Controls.Add(Me.BtnCadastrar)
        Me.Gr.Controls.Add(Me.AutoLabel2)
        Me.Gr.Controls.Add(Me.TxtRegistros)
        Me.Gr.Controls.Add(Me.SfComboBox1)
        Me.Gr.Controls.Add(Me.AutoLabel1)
        Me.Gr.Controls.Add(Me.BtnPesquisar)
        Me.Gr.Controls.Add(Me.PictureBox1)
        Me.Gr.Controls.Add(Me.PanelString)
        Me.Gr.Controls.Add(Me.PanelDate)
        Me.Gr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Gr.Location = New System.Drawing.Point(0, -10)
        Me.Gr.Name = "Gr"
        Me.Gr.Size = New System.Drawing.Size(676, 117)
        Me.Gr.TabIndex = 1
        Me.Gr.TabStop = False
        '
        'BtnCadastrar
        '
        Me.BtnCadastrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCadastrar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCadastrar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCadastrar.ForeColor = System.Drawing.Color.White
        Me.BtnCadastrar.Image = CType(resources.GetObject("BtnCadastrar.Image"), System.Drawing.Image)
        Me.BtnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCadastrar.Location = New System.Drawing.Point(564, 23)
        Me.BtnCadastrar.Name = "BtnCadastrar"
        Me.BtnCadastrar.Size = New System.Drawing.Size(101, 29)
        Me.BtnCadastrar.TabIndex = 120
        Me.BtnCadastrar.TabStop = False
        Me.BtnCadastrar.Text = "Cadastrar"
        Me.BtnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCadastrar.UseVisualStyleBackColor = False
        Me.BtnCadastrar.Visible = False
        '
        'AutoLabel2
        '
        Me.AutoLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoLabel2.Location = New System.Drawing.Point(371, 11)
        Me.AutoLabel2.Name = "AutoLabel2"
        Me.AutoLabel2.Size = New System.Drawing.Size(55, 15)
        Me.AutoLabel2.TabIndex = 31
        Me.AutoLabel2.Text = "Registros"
        '
        'TxtRegistros
        '
        Me.TxtRegistros.AllowNull = True
        Me.TxtRegistros.BeforeTouchSize = New System.Drawing.Size(153, 29)
        Me.TxtRegistros.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.TxtRegistros.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRegistros.FocusBorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtRegistros.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TxtRegistros.IntegerValue = CType(500, Long)
        Me.TxtRegistros.Location = New System.Drawing.Point(374, 27)
        Me.TxtRegistros.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TxtRegistros.Name = "TxtRegistros"
        Me.TxtRegistros.NullString = ""
        Me.TxtRegistros.NumberGroupSeparator = ""
        Me.TxtRegistros.Size = New System.Drawing.Size(54, 25)
        Me.TxtRegistros.TabIndex = 34
        Me.TxtRegistros.Text = "500"
        '
        'SfComboBox1
        '
        Me.SfComboBox1.DisplayMember = "Text"
        Me.SfComboBox1.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList
        Me.SfComboBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SfComboBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.SfComboBox1.Location = New System.Drawing.Point(121, 27)
        Me.SfComboBox1.Name = "SfComboBox1"
        Me.SfComboBox1.Size = New System.Drawing.Size(247, 25)
        Me.SfComboBox1.Style.DropDownButtonStyle.BackColor = System.Drawing.Color.LightGray
        Me.SfComboBox1.Style.DropDownButtonStyle.DisabledBackColor = System.Drawing.Color.LightGray
        Me.SfComboBox1.Style.DropDownStyle.GripperBackColor = System.Drawing.Color.White
        Me.SfComboBox1.Style.EditorStyle.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SfComboBox1.Style.EditorStyle.FocusedBorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SfComboBox1.Style.EditorStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SfComboBox1.Style.EditorStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.SfComboBox1.Style.EditorStyle.HoverBorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SfComboBox1.Style.ReadOnlyEditorStyle.BackColor = System.Drawing.Color.White
        Me.SfComboBox1.Style.ReadOnlyEditorStyle.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SfComboBox1.Style.ReadOnlyEditorStyle.FocusedBorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SfComboBox1.Style.ReadOnlyEditorStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SfComboBox1.Style.ReadOnlyEditorStyle.HoverBorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SfComboBox1.Style.ToolTipStyle.BackColor = System.Drawing.Color.LightGray
        Me.SfComboBox1.TabIndex = 16
        Me.SfComboBox1.ValueMember = "Value"
        '
        'AutoLabel1
        '
        Me.AutoLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoLabel1.Location = New System.Drawing.Point(118, 11)
        Me.AutoLabel1.Name = "AutoLabel1"
        Me.AutoLabel1.Size = New System.Drawing.Size(45, 15)
        Me.AutoLabel1.TabIndex = 119
        Me.AutoLabel1.Text = "Campo"
        '
        'BtnPesquisar
        '
        Me.BtnPesquisar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPesquisar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesquisar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnPesquisar.ForeColor = System.Drawing.Color.White
        Me.BtnPesquisar.Image = CType(resources.GetObject("BtnPesquisar.Image"), System.Drawing.Image)
        Me.BtnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPesquisar.Location = New System.Drawing.Point(564, 66)
        Me.BtnPesquisar.Name = "BtnPesquisar"
        Me.BtnPesquisar.Size = New System.Drawing.Size(101, 29)
        Me.BtnPesquisar.TabIndex = 11
        Me.BtnPesquisar.TabStop = False
        Me.BtnPesquisar.Text = "Pesquisar"
        Me.BtnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPesquisar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PanelString
        '
        Me.PanelString.BackColor = System.Drawing.Color.White
        Me.PanelString.Controls.Add(Me.AutoLabel3)
        Me.PanelString.Controls.Add(Me.TxtPesquisar)
        Me.PanelString.Location = New System.Drawing.Point(118, 52)
        Me.PanelString.Name = "PanelString"
        Me.PanelString.Size = New System.Drawing.Size(322, 49)
        Me.PanelString.TabIndex = 2
        '
        'AutoLabel3
        '
        Me.AutoLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoLabel3.Location = New System.Drawing.Point(3, 2)
        Me.AutoLabel3.Name = "AutoLabel3"
        Me.AutoLabel3.Size = New System.Drawing.Size(57, 15)
        Me.AutoLabel3.TabIndex = 120
        Me.AutoLabel3.Text = "Pesquisar"
        '
        'TxtPesquisar
        '
        Me.TxtPesquisar.BackColor = System.Drawing.Color.White
        Me.TxtPesquisar.BeforeTouchSize = New System.Drawing.Size(153, 29)
        Me.TxtPesquisar.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.TxtPesquisar.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPesquisar.FocusBorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtPesquisar.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TxtPesquisar.ForeColor = System.Drawing.Color.Black
        Me.TxtPesquisar.Location = New System.Drawing.Point(5, 18)
        Me.TxtPesquisar.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TxtPesquisar.Name = "TxtPesquisar"
        Me.TxtPesquisar.Size = New System.Drawing.Size(305, 25)
        Me.TxtPesquisar.TabIndex = 28
        '
        'PanelDate
        '
        Me.PanelDate.BackColor = System.Drawing.Color.White
        Me.PanelDate.Controls.Add(Me.LblPeriodo)
        Me.PanelDate.Controls.Add(Me.DtFim)
        Me.PanelDate.Controls.Add(Me.DtInicio)
        Me.PanelDate.Controls.Add(Me.Label5)
        Me.PanelDate.Location = New System.Drawing.Point(118, 52)
        Me.PanelDate.Name = "PanelDate"
        Me.PanelDate.Size = New System.Drawing.Size(322, 49)
        Me.PanelDate.TabIndex = 118
        '
        'LblPeriodo
        '
        Me.LblPeriodo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPeriodo.Location = New System.Drawing.Point(3, 2)
        Me.LblPeriodo.Name = "LblPeriodo"
        Me.LblPeriodo.Size = New System.Drawing.Size(48, 15)
        Me.LblPeriodo.TabIndex = 30
        Me.LblPeriodo.Text = "Período"
        '
        'DtFim
        '
        Me.DtFim.AllowNull = True
        Me.DtFim.BackColor = System.Drawing.Color.White
        Me.DtFim.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom
        Me.DtFim.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtFim.Format = "dd/MM/yyyy"
        Me.DtFim.Location = New System.Drawing.Point(140, 18)
        Me.DtFim.Name = "DtFim"
        Me.DtFim.Size = New System.Drawing.Size(110, 25)
        Me.DtFim.Style.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DtFim.Style.DropDown.BackColor = System.Drawing.Color.White
        Me.DtFim.Style.DropDown.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DtFim.Style.DropDown.HoverBackColor = System.Drawing.Color.White
        Me.DtFim.Style.DropDown.PressedBackColor = System.Drawing.Color.White
        Me.DtFim.Style.FocusedBorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DtFim.Style.HoverBorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DtFim.Style.UpDownForeColor = System.Drawing.Color.Black
        Me.DtFim.Style.UpDownHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.DtFim.TabIndex = 16
        Me.DtFim.ThemeName = Nothing
        Me.DtFim.Watermark = "dd/mm/yyyy"
        '
        'DtInicio
        '
        Me.DtInicio.AllowNull = True
        Me.DtInicio.BackColor = System.Drawing.Color.White
        Me.DtInicio.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom
        Me.DtInicio.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtInicio.Format = "dd/MM/yyyy"
        Me.DtInicio.Location = New System.Drawing.Point(5, 18)
        Me.DtInicio.Name = "DtInicio"
        Me.DtInicio.Size = New System.Drawing.Size(110, 25)
        Me.DtInicio.Style.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DtInicio.Style.DropDown.BackColor = System.Drawing.Color.White
        Me.DtInicio.Style.DropDown.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DtInicio.Style.DropDown.HoverBackColor = System.Drawing.Color.White
        Me.DtInicio.Style.DropDown.PressedBackColor = System.Drawing.Color.White
        Me.DtInicio.Style.FocusedBorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DtInicio.Style.HoverBorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DtInicio.Style.UpDownForeColor = System.Drawing.Color.Black
        Me.DtInicio.Style.UpDownHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.DtInicio.TabIndex = 9
        Me.DtInicio.ThemeName = Nothing
        Me.DtInicio.Watermark = "dd/mm/yyyy"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(121, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "a"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelar.BackColor = System.Drawing.Color.IndianRed
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(575, 585)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(90, 26)
        Me.BtnCancelar.TabIndex = 15
        Me.BtnCancelar.TabStop = False
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnOk
        '
        Me.BtnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOk.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOk.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOk.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnOk.Image = CType(resources.GetObject("BtnOk.Image"), System.Drawing.Image)
        Me.BtnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOk.Location = New System.Drawing.Point(483, 585)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(88, 26)
        Me.BtnOk.TabIndex = 14
        Me.BtnOk.Text = "OK"
        Me.BtnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnOk.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 15)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "Carregando dados"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.Location = New System.Drawing.Point(3, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 18)
        Me.Label7.TabIndex = 118
        Me.Label7.Text = "Aguarde..."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(7, 113)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(163, 50)
        Me.Panel1.TabIndex = 12
        '
        'GridGroupingControl2
        '
        Me.GridGroupingControl2.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GridGroupingControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridGroupingControl2.Appearance.AddNewRecordFieldCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control)
        Me.GridGroupingControl2.ApplyVisualStyles = False
        Me.GridGroupingControl2.BackColor = System.Drawing.SystemColors.Window
        Me.GridGroupingControl2.ChildGroupOptions.CaptionText = "{RecordCount} resultado(s) encontrado(s)"
        Me.GridGroupingControl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridGroupingControl2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GridGroupingControl2.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Office2016
        Me.GridGroupingControl2.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2016White
        Me.GridGroupingControl2.Location = New System.Drawing.Point(7, 91)
        Me.GridGroupingControl2.Name = "GridGroupingControl2"
        Me.GridGroupingControl2.Office2016ScrollBarsColorScheme = Syncfusion.Windows.Forms.ScrollBarOffice2016ColorScheme.White
        Me.GridGroupingControl2.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
        Me.GridGroupingControl2.ShowGroupDropArea = True
        Me.GridGroupingControl2.Size = New System.Drawing.Size(658, 490)
        Me.GridGroupingControl2.TabIndex = 13
        Me.GridGroupingControl2.TableDescriptor.AllowNew = False
        Me.GridGroupingControl2.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI"
        Me.GridGroupingControl2.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GridGroupingControl2.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.GridGroupingControl2.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.GridGroupingControl2.TableDescriptor.Appearance.AnyGroupCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)))
        Me.GridGroupingControl2.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GridGroupingControl2.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.GridGroupingControl2.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.GridGroupingControl2.TableDescriptor.Appearance.AnyRecordFieldCell.Clickable = True
        Me.GridGroupingControl2.TableDescriptor.Appearance.AnyRecordFieldCell.CultureInfo = New System.Globalization.CultureInfo("pt-BR")
        Me.GridGroupingControl2.TableDescriptor.Appearance.AnyRecordFieldCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
        Me.GridGroupingControl2.TableDescriptor.Appearance.AnyRecordFieldCell.TextColor = System.Drawing.Color.Black
        Me.GridGroupingControl2.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.GridGroupingControl2.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.GridGroupingControl2.TableDescriptor.Appearance.AnySummaryCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)))
        Me.GridGroupingControl2.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = True
        Me.GridGroupingControl2.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader"
        Me.GridGroupingControl2.TableDescriptor.Appearance.RecordFieldCell.CellType = "TextBox"
        Me.GridGroupingControl2.TableDescriptor.TableOptions.CaptionRowHeight = 32
        Me.GridGroupingControl2.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 28
        Me.GridGroupingControl2.TableDescriptor.TableOptions.RecordRowHeight = 28
        Me.GridGroupingControl2.TableOptions.AllowSelection = Syncfusion.Windows.Forms.Grid.GridSelectionFlags.None
        Me.GridGroupingControl2.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer)))
        Me.GridGroupingControl2.TableOptions.ListBoxSelectionColorOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionColorOptions.ApplySelectionColor
        Me.GridGroupingControl2.TableOptions.ListBoxSelectionCurrentCellOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionCurrentCellOptions.HideCurrentCell
        Me.GridGroupingControl2.TableOptions.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.One
        Me.GridGroupingControl2.TableOptions.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.GridGroupingControl2.TableOptions.SelectionTextColor = System.Drawing.Color.White
        Me.GridGroupingControl2.TableOptions.ShowRecordPlusMinus = True
        Me.GridGroupingControl2.TableOptions.ShowRowHeader = True
        Me.GridGroupingControl2.TableOptions.ShowTableIndent = True
        Me.GridGroupingControl2.TableOptions.TreeLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.SystemColors.ControlDarkDark)
        Me.GridGroupingControl2.TabStop = False
        Me.GridGroupingControl2.Text = "GridGroupingControl2"
        Me.GridGroupingControl2.TopLevelGroupOptions.CaptionText = "{RecordCount} resultados"
        Me.GridGroupingControl2.TopLevelGroupOptions.ShowAddNewRecordAfterDetails = False
        Me.GridGroupingControl2.TopLevelGroupOptions.ShowCaption = False
        Me.GridGroupingControl2.TopLevelGroupOptions.ShowColumnHeaders = True
        Me.GridGroupingControl2.TopLevelGroupOptions.ShowFilterBar = False
        Me.GridGroupingControl2.TopLevelGroupOptions.ShowStackedHeaders = True
        Me.GridGroupingControl2.UseRightToLeftCompatibleTextBox = True
        Me.GridGroupingControl2.VersionInfo = "4.201.0.37"
        Me.GridGroupingControl2.Visible = False
        '
        'LblCampoCalculaTotal1
        '
        Me.LblCampoCalculaTotal1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblCampoCalculaTotal1.BackColor = System.Drawing.Color.White
        Me.LblCampoCalculaTotal1.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblCampoCalculaTotal1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblCampoCalculaTotal1.ForeColor = System.Drawing.Color.SeaGreen
        Me.LblCampoCalculaTotal1.Location = New System.Drawing.Point(7, 585)
        Me.LblCampoCalculaTotal1.Name = "LblCampoCalculaTotal1"
        Me.LblCampoCalculaTotal1.Size = New System.Drawing.Size(48, 21)
        Me.LblCampoCalculaTotal1.TabIndex = 133
        Me.LblCampoCalculaTotal1.Text = "Total"
        '
        'TxtCampoCalculaTotal1
        '
        Me.TxtCampoCalculaTotal1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtCampoCalculaTotal1.BackGroundColor = System.Drawing.SystemColors.Control
        Me.TxtCampoCalculaTotal1.BeforeTouchSize = New System.Drawing.Size(153, 29)
        Me.TxtCampoCalculaTotal1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.TxtCampoCalculaTotal1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.TxtCampoCalculaTotal1.BorderSides = System.Windows.Forms.Border3DSide.Bottom
        Me.TxtCampoCalculaTotal1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCampoCalculaTotal1.DoubleValue = 0R
        Me.TxtCampoCalculaTotal1.FocusBorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtCampoCalculaTotal1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCampoCalculaTotal1.ForeColor = System.Drawing.Color.SeaGreen
        Me.TxtCampoCalculaTotal1.Location = New System.Drawing.Point(7, 582)
        Me.TxtCampoCalculaTotal1.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TxtCampoCalculaTotal1.Name = "TxtCampoCalculaTotal1"
        Me.TxtCampoCalculaTotal1.NullString = ""
        Me.TxtCampoCalculaTotal1.PositiveColor = System.Drawing.Color.SeaGreen
        Me.TxtCampoCalculaTotal1.ReadOnly = True
        Me.TxtCampoCalculaTotal1.ReadOnlyBackColor = System.Drawing.SystemColors.Window
        Me.TxtCampoCalculaTotal1.Size = New System.Drawing.Size(153, 29)
        Me.TxtCampoCalculaTotal1.TabIndex = 134
        Me.TxtCampoCalculaTotal1.TabStop = False
        Me.TxtCampoCalculaTotal1.Text = "0,00"
        Me.TxtCampoCalculaTotal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtCampoCalculaTotal1.ZeroColor = System.Drawing.Color.SeaGreen
        '
        'FrmPesquisa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 615)
        Me.Controls.Add(Me.LblCampoCalculaTotal1)
        Me.Controls.Add(Me.GridGroupingControl2)
        Me.Controls.Add(Me.TxtCampoCalculaTotal1)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.Gr)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "FrmPesquisa"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pesquisar"
        Me.Gr.ResumeLayout(False)
        Me.Gr.PerformLayout()
        CType(Me.TxtRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SfComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelString.ResumeLayout(False)
        Me.PanelString.PerformLayout()
        CType(Me.TxtPesquisar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDate.ResumeLayout(False)
        Me.PanelDate.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridGroupingControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCampoCalculaTotal1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gr As GroupBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents BtnOk As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents PanelDate As Panel
    Friend WithEvents PanelString As Panel
    Private WithEvents BtnPesquisar As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Private WithEvents GridGroupingControl2 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
    Friend WithEvents DtInicio As Syncfusion.WinForms.Input.SfDateTimeEdit
    Friend WithEvents LblPeriodo As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents DtFim As Syncfusion.WinForms.Input.SfDateTimeEdit
    Friend WithEvents SfComboBox1 As Syncfusion.WinForms.ListView.SfComboBox
    Friend WithEvents AutoLabel1 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents AutoLabel2 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents TxtRegistros As Syncfusion.Windows.Forms.Tools.IntegerTextBox
    Friend WithEvents TxtPesquisar As Syncfusion.Windows.Forms.Tools.TextBoxExt
    Friend WithEvents AutoLabel3 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents LblCampoCalculaTotal1 As Syncfusion.Windows.Forms.Tools.AutoLabel
    Friend WithEvents TxtCampoCalculaTotal1 As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Private WithEvents BtnCadastrar As Button
End Class
