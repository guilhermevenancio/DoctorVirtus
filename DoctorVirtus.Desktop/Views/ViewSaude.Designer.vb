
Partial Public Class ViewSaude
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing



    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Public treeNodeAdv4 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewSaude))
        Me.TabPrincipal = New Syncfusion.Windows.Forms.Tools.RibbonControlAdv()
        Me.TabItemPrincipal = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
        Me.MnuPrincipal = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.AtalhoParceiro = New System.Windows.Forms.ToolStripButton()
        Me.AtalhoProduto = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AtalhoPedidoVenda = New System.Windows.Forms.ToolStripButton()
        Me.AtalhoCaixa2 = New System.Windows.Forms.ToolStripButton()
        Me.AtalhoBanco2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AtalhoAcessoRemoto = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AtalhoSairSistema = New System.Windows.Forms.ToolStripButton()
        Me.TabItemCadastros = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
        Me.MenuCadastros = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.BtnUsuario = New System.Windows.Forms.ToolStripButton()
        Me.BtnPrestador = New System.Windows.Forms.ToolStripButton()
        Me.BtnTabela = New System.Windows.Forms.ToolStripButton()
        Me.AtalhoProduto2 = New System.Windows.Forms.ToolStripButton()
        Me.BtnOperadora = New System.Windows.Forms.ToolStripButton()
        Me.BtnLocalAtendimento = New System.Windows.Forms.ToolStripButton()
        Me.AtalhoFormaPagamento = New System.Windows.Forms.ToolStripButton()
        Me.TabItemCompras = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
        Me.MenuCompras = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.AtalhoEntradaMercadoria = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton()
        Me.TabItemVendas = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
        Me.MenuVendas = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.AtalhoPedidoVenda2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.AtalhoFaturamento = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.TabItemFinanceiro = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
        Me.MenuFinanceiro = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.AtalhoCaixa = New System.Windows.Forms.ToolStripButton()
        Me.AtalhoBanco = New System.Windows.Forms.ToolStripButton()
        Me.AtalhoMovimentacaoFinanceira = New System.Windows.Forms.ToolStripButton()
        Me.TabItemFiscal = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
        Me.MenuFiscal = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.AtalhoMenuFiscal = New System.Windows.Forms.ToolStripButton()
        Me.AtalhoNFe = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.AtalhoMenuFiscal1 = New System.Windows.Forms.ToolStripButton()
        Me.TabItemRelatorios = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
        Me.MenuRelatorios = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.AtalhoRelVendas = New System.Windows.Forms.ToolStripButton()
        Me.StripInferior = New System.Windows.Forms.StatusStrip()
        Me.MnuNomeFantasia = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MnuVersao = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MnuUsuarioLogado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MnuUltimoAcesso = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnChamadoPendente = New System.Windows.Forms.Button()
        Me.LblChamado = New System.Windows.Forms.Label()
        Me.BtnCompromissosFuturos = New System.Windows.Forms.Button()
        Me.BtnCompromissosHoje = New System.Windows.Forms.Button()
        Me.LblAgenda = New System.Windows.Forms.Label()
        Me.BtnCompromissosAtrasados = New System.Windows.Forms.Button()
        Me.Menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MnuCadastro = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParceiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuárioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrupoDeUsuárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FiscalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuTributacao = New System.Windows.Forms.ToolStripMenuItem()
        Me.NCMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CESTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinanceiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeContratoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FerramentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MacroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesFornecedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosServiçosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuAcessoRemoto = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuTrocarUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuConfiguracoes = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuSairSistema = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.TabPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPrincipal.SuspendLayout()
        Me.TabItemPrincipal.Panel.SuspendLayout()
        Me.MnuPrincipal.SuspendLayout()
        Me.TabItemCadastros.Panel.SuspendLayout()
        Me.MenuCadastros.SuspendLayout()
        Me.TabItemCompras.Panel.SuspendLayout()
        Me.MenuCompras.SuspendLayout()
        Me.TabItemVendas.Panel.SuspendLayout()
        Me.MenuVendas.SuspendLayout()
        Me.TabItemFinanceiro.Panel.SuspendLayout()
        Me.MenuFinanceiro.SuspendLayout()
        Me.TabItemFiscal.Panel.SuspendLayout()
        Me.MenuFiscal.SuspendLayout()
        Me.TabItemRelatorios.Panel.SuspendLayout()
        Me.MenuRelatorios.SuspendLayout()
        Me.StripInferior.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPrincipal
        '
        Me.TabPrincipal.CaptionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPrincipal.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.TabPrincipal.Header.AddMainItem(TabItemPrincipal)
        Me.TabPrincipal.Header.AddMainItem(TabItemCadastros)
        Me.TabPrincipal.Header.AddMainItem(TabItemCompras)
        Me.TabPrincipal.Header.AddMainItem(TabItemVendas)
        Me.TabPrincipal.Header.AddMainItem(TabItemFinanceiro)
        Me.TabPrincipal.Header.AddMainItem(TabItemFiscal)
        Me.TabPrincipal.Header.AddMainItem(TabItemRelatorios)
        Me.TabPrincipal.Location = New System.Drawing.Point(1, 0)
        Me.TabPrincipal.MenuButtonFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPrincipal.MenuButtonText = "Menu"
        Me.TabPrincipal.MenuButtonWidth = 56
        Me.TabPrincipal.MenuColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.TabPrincipal.Name = "TabPrincipal"
        Me.TabPrincipal.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Silver
        '
        'TabPrincipal.OfficeMenu
        '
        Me.TabPrincipal.OfficeMenu.Name = "OfficeMenu"
        Me.TabPrincipal.OfficeMenu.ShowItemToolTips = True
        Me.TabPrincipal.OfficeMenu.Size = New System.Drawing.Size(12, 65)
        Me.TabPrincipal.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TabPrincipal.QuickPanelVisible = False
        Me.TabPrincipal.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None
        Me.TabPrincipal.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2016
        Me.TabPrincipal.SelectedTab = Me.TabItemCadastros
        Me.TabPrincipal.ShowMinimizeButton = False
        Me.TabPrincipal.ShowQuickItemsDropDownButton = False
        Me.TabPrincipal.ShowRibbonDisplayOptionButton = False
        Me.TabPrincipal.Size = New System.Drawing.Size(1040, 142)
        Me.TabPrincipal.SystemText.QuickAccessDialogDropDownName = "Start menu"
        Me.TabPrincipal.SystemText.RenameDisplayLabelText = "&Display Name:"
        Me.TabPrincipal.TabIndex = 0
        Me.TabPrincipal.Text = "f"
        Me.TabPrincipal.TitleColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.TabPrincipal.TouchMode = True
        '
        'TabItemPrincipal
        '
        Me.TabItemPrincipal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabItemPrincipal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TabItemPrincipal.Name = "TabItemPrincipal"
        '
        'TabPrincipal.RibbonPanel1
        '
        Me.TabItemPrincipal.Panel.Controls.Add(Me.MnuPrincipal)
        Me.TabItemPrincipal.Panel.Name = "RibbonPanel1"
        Me.TabItemPrincipal.Panel.ScrollPosition = 0
        Me.TabItemPrincipal.Panel.TabIndex = 2
        Me.TabItemPrincipal.Panel.Text = "Principal"
        Me.TabItemPrincipal.Position = 0
        Me.TabItemPrincipal.Size = New System.Drawing.Size(67, 30)
        Me.TabItemPrincipal.Tag = "1"
        Me.TabItemPrincipal.Text = "Principal"
        Me.TabItemPrincipal.ToolTipText = "Principal"
        Me.TabItemPrincipal.Visible = False
        '
        'MnuPrincipal
        '
        Me.MnuPrincipal.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.MnuPrincipal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.MnuPrincipal.Image = Nothing
        Me.MnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AtalhoParceiro, Me.AtalhoProduto, Me.ToolStripSeparator1, Me.AtalhoPedidoVenda, Me.AtalhoCaixa2, Me.AtalhoBanco2, Me.ToolStripSeparator2, Me.AtalhoAcessoRemoto, Me.ToolStripSeparator3, Me.AtalhoSairSistema})
        Me.MnuPrincipal.Location = New System.Drawing.Point(0, 1)
        Me.MnuPrincipal.Name = "MnuPrincipal"
        Me.MnuPrincipal.Office12Mode = False
        Me.MnuPrincipal.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.MnuPrincipal.Size = New System.Drawing.Size(527, 76)
        Me.MnuPrincipal.TabIndex = 0
        '
        'AtalhoParceiro
        '
        Me.AtalhoParceiro.Image = CType(resources.GetObject("AtalhoParceiro.Image"), System.Drawing.Image)
        Me.AtalhoParceiro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AtalhoParceiro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AtalhoParceiro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AtalhoParceiro.Name = "AtalhoParceiro"
        Me.AtalhoParceiro.Size = New System.Drawing.Size(61, 62)
        Me.AtalhoParceiro.Text = " Parceiro  "
        Me.AtalhoParceiro.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AtalhoParceiro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.AtalhoParceiro.ToolTipText = "Cadastro de parceiro"
        '
        'AtalhoProduto
        '
        Me.AtalhoProduto.Image = CType(resources.GetObject("AtalhoProduto.Image"), System.Drawing.Image)
        Me.AtalhoProduto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AtalhoProduto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AtalhoProduto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AtalhoProduto.Name = "AtalhoProduto"
        Me.AtalhoProduto.Size = New System.Drawing.Size(62, 62)
        Me.AtalhoProduto.Text = " Produto  "
        Me.AtalhoProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AtalhoProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.AtalhoProduto.ToolTipText = "Cadastro de parceiro"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 76)
        '
        'AtalhoPedidoVenda
        '
        Me.AtalhoPedidoVenda.Image = CType(resources.GetObject("AtalhoPedidoVenda.Image"), System.Drawing.Image)
        Me.AtalhoPedidoVenda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AtalhoPedidoVenda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AtalhoPedidoVenda.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AtalhoPedidoVenda.Name = "AtalhoPedidoVenda"
        Me.AtalhoPedidoVenda.Size = New System.Drawing.Size(62, 62)
        Me.AtalhoPedidoVenda.Text = "  Pedido   " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "venda"
        Me.AtalhoPedidoVenda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AtalhoPedidoVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.AtalhoPedidoVenda.ToolTipText = "Cadastro de parceiro"
        '
        'AtalhoCaixa2
        '
        Me.AtalhoCaixa2.Image = CType(resources.GetObject("AtalhoCaixa2.Image"), System.Drawing.Image)
        Me.AtalhoCaixa2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AtalhoCaixa2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AtalhoCaixa2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AtalhoCaixa2.Name = "AtalhoCaixa2"
        Me.AtalhoCaixa2.Size = New System.Drawing.Size(62, 62)
        Me.AtalhoCaixa2.Text = "    Caixa    "
        Me.AtalhoCaixa2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AtalhoCaixa2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.AtalhoCaixa2.ToolTipText = "Cadastro de parceiro"
        '
        'AtalhoBanco2
        '
        Me.AtalhoBanco2.Image = CType(resources.GetObject("AtalhoBanco2.Image"), System.Drawing.Image)
        Me.AtalhoBanco2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AtalhoBanco2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AtalhoBanco2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AtalhoBanco2.Name = "AtalhoBanco2"
        Me.AtalhoBanco2.Size = New System.Drawing.Size(64, 62)
        Me.AtalhoBanco2.Text = "   Banco    "
        Me.AtalhoBanco2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AtalhoBanco2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.AtalhoBanco2.ToolTipText = "Cadastro de parceiro"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 76)
        '
        'AtalhoAcessoRemoto
        '
        Me.AtalhoAcessoRemoto.Image = CType(resources.GetObject("AtalhoAcessoRemoto.Image"), System.Drawing.Image)
        Me.AtalhoAcessoRemoto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AtalhoAcessoRemoto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AtalhoAcessoRemoto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AtalhoAcessoRemoto.Name = "AtalhoAcessoRemoto"
        Me.AtalhoAcessoRemoto.Size = New System.Drawing.Size(61, 62)
        Me.AtalhoAcessoRemoto.Text = "  Acesso   " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "remoto"
        Me.AtalhoAcessoRemoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AtalhoAcessoRemoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 76)
        '
        'AtalhoSairSistema
        '
        Me.AtalhoSairSistema.Image = CType(resources.GetObject("AtalhoSairSistema.Image"), System.Drawing.Image)
        Me.AtalhoSairSistema.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AtalhoSairSistema.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AtalhoSairSistema.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AtalhoSairSistema.Name = "AtalhoSairSistema"
        Me.AtalhoSairSistema.Size = New System.Drawing.Size(63, 62)
        Me.AtalhoSairSistema.Text = "     Sair      "
        Me.AtalhoSairSistema.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AtalhoSairSistema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.AtalhoSairSistema.ToolTipText = "Sair do sistema"
        '
        'TabItemCadastros
        '
        Me.TabItemCadastros.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabItemCadastros.Name = "TabItemCadastros"
        '
        'TabPrincipal.RibbonPanel2
        '
        Me.TabItemCadastros.Panel.Controls.Add(Me.MenuCadastros)
        Me.TabItemCadastros.Panel.Name = "RibbonPanel2"
        Me.TabItemCadastros.Panel.ScrollPosition = 0
        Me.TabItemCadastros.Panel.TabIndex = 3
        Me.TabItemCadastros.Panel.Text = "Cadastros"
        Me.TabItemCadastros.Position = 1
        Me.TabItemCadastros.Size = New System.Drawing.Size(74, 30)
        Me.TabItemCadastros.Tag = "2"
        Me.TabItemCadastros.Text = "Cadastros"
        '
        'MenuCadastros
        '
        Me.MenuCadastros.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.MenuCadastros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.MenuCadastros.Image = Nothing
        Me.MenuCadastros.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnUsuario, Me.BtnPrestador, Me.BtnLocalAtendimento, Me.BtnTabela, Me.AtalhoProduto2, Me.BtnOperadora, Me.AtalhoFormaPagamento})
        Me.MenuCadastros.Location = New System.Drawing.Point(0, 1)
        Me.MenuCadastros.Name = "MenuCadastros"
        Me.MenuCadastros.Office12Mode = False
        Me.MenuCadastros.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.MenuCadastros.Size = New System.Drawing.Size(458, 76)
        Me.MenuCadastros.TabIndex = 1
        '
        'BtnUsuario
        '
        Me.BtnUsuario.Image = CType(resources.GetObject("BtnUsuario.Image"), System.Drawing.Image)
        Me.BtnUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnUsuario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BtnUsuario.Name = "BtnUsuario"
        Me.BtnUsuario.Size = New System.Drawing.Size(63, 62)
        Me.BtnUsuario.Text = "  Usuário  "
        Me.BtnUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnUsuario.ToolTipText = "Cadastro de parceiro"
        '
        'BtnPrestador
        '
        Me.BtnPrestador.Image = CType(resources.GetObject("BtnPrestador.Image"), System.Drawing.Image)
        Me.BtnPrestador.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnPrestador.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrestador.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BtnPrestador.Name = "BtnPrestador"
        Me.BtnPrestador.Size = New System.Drawing.Size(60, 62)
        Me.BtnPrestador.Text = "Prestador"
        Me.BtnPrestador.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPrestador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnPrestador.ToolTipText = "Cadastro de parceiro"
        '
        'BtnTabela
        '
        Me.BtnTabela.Image = CType(resources.GetObject("BtnTabela.Image"), System.Drawing.Image)
        Me.BtnTabela.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnTabela.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnTabela.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BtnTabela.Name = "BtnTabela"
        Me.BtnTabela.Size = New System.Drawing.Size(63, 62)
        Me.BtnTabela.Text = "   Tabelas  "
        Me.BtnTabela.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnTabela.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnTabela.ToolTipText = "Cadastro de parceiro"
        '
        'AtalhoProduto2
        '
        Me.AtalhoProduto2.Image = CType(resources.GetObject("AtalhoProduto2.Image"), System.Drawing.Image)
        Me.AtalhoProduto2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AtalhoProduto2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AtalhoProduto2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AtalhoProduto2.Name = "AtalhoProduto2"
        Me.AtalhoProduto2.Size = New System.Drawing.Size(61, 62)
        Me.AtalhoProduto2.Text = " Procedi- " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  mentos  "
        Me.AtalhoProduto2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AtalhoProduto2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnOperadora
        '
        Me.BtnOperadora.Image = CType(resources.GetObject("BtnOperadora.Image"), System.Drawing.Image)
        Me.BtnOperadora.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnOperadora.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnOperadora.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BtnOperadora.Name = "BtnOperadora"
        Me.BtnOperadora.Size = New System.Drawing.Size(67, 62)
        Me.BtnOperadora.Tag = ""
        Me.BtnOperadora.Text = "Operadora"
        Me.BtnOperadora.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnOperadora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnOperadora.ToolTipText = "Plano contas"
        '
        'BtnLocalAtendimento
        '
        Me.BtnLocalAtendimento.Image = CType(resources.GetObject("BtnLocalAtendimento.Image"), System.Drawing.Image)
        Me.BtnLocalAtendimento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnLocalAtendimento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnLocalAtendimento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BtnLocalAtendimento.Name = "BtnLocalAtendimento"
        Me.BtnLocalAtendimento.Size = New System.Drawing.Size(78, 62)
        Me.BtnLocalAtendimento.Text = "Local" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Atendimento"
        Me.BtnLocalAtendimento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnLocalAtendimento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnLocalAtendimento.ToolTipText = "Cadastro de parceiro"
        '
        'AtalhoFormaPagamento
        '
        Me.AtalhoFormaPagamento.Image = CType(resources.GetObject("AtalhoFormaPagamento.Image"), System.Drawing.Image)
        Me.AtalhoFormaPagamento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AtalhoFormaPagamento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AtalhoFormaPagamento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AtalhoFormaPagamento.Name = "AtalhoFormaPagamento"
        Me.AtalhoFormaPagamento.Size = New System.Drawing.Size(74, 62)
        Me.AtalhoFormaPagamento.Text = "Formas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pagamentos"
        Me.AtalhoFormaPagamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AtalhoFormaPagamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.AtalhoFormaPagamento.ToolTipText = "Plano contas"
        Me.AtalhoFormaPagamento.Visible = False
        '
        'TabItemCompras
        '
        Me.TabItemCompras.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabItemCompras.Name = "TabItemCompras"
        '
        'TabPrincipal.RibbonPanel3
        '
        Me.TabItemCompras.Panel.Controls.Add(Me.MenuCompras)
        Me.TabItemCompras.Panel.Name = "RibbonPanel3"
        Me.TabItemCompras.Panel.ScrollPosition = 0
        Me.TabItemCompras.Panel.TabIndex = 3
        Me.TabItemCompras.Panel.Text = "Compras"
        Me.TabItemCompras.Position = 2
        Me.TabItemCompras.Size = New System.Drawing.Size(68, 30)
        Me.TabItemCompras.Tag = "2"
        Me.TabItemCompras.Text = "Compras"
        Me.TabItemCompras.Visible = False
        '
        'MenuCompras
        '
        Me.MenuCompras.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.MenuCompras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.MenuCompras.Image = Nothing
        Me.MenuCompras.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton6, Me.AtalhoEntradaMercadoria, Me.ToolStripButton12})
        Me.MenuCompras.Location = New System.Drawing.Point(0, 1)
        Me.MenuCompras.Name = "MenuCompras"
        Me.MenuCompras.Office12Mode = False
        Me.MenuCompras.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.MenuCompras.Size = New System.Drawing.Size(95, 76)
        Me.MenuCompras.TabIndex = 2
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(62, 66)
        Me.ToolStripButton6.Text = "  Pedido   " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Compra"
        Me.ToolStripButton6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButton6.ToolTipText = "Cadastro de parceiro"
        Me.ToolStripButton6.Visible = False
        '
        'AtalhoEntradaMercadoria
        '
        Me.AtalhoEntradaMercadoria.Image = CType(resources.GetObject("AtalhoEntradaMercadoria.Image"), System.Drawing.Image)
        Me.AtalhoEntradaMercadoria.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AtalhoEntradaMercadoria.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AtalhoEntradaMercadoria.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AtalhoEntradaMercadoria.Name = "AtalhoEntradaMercadoria"
        Me.AtalhoEntradaMercadoria.Size = New System.Drawing.Size(69, 62)
        Me.AtalhoEntradaMercadoria.Text = "Entrada" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mercadoria"
        Me.AtalhoEntradaMercadoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AtalhoEntradaMercadoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.AtalhoEntradaMercadoria.ToolTipText = "Plano contas"
        '
        'ToolStripButton12
        '
        Me.ToolStripButton12.Image = CType(resources.GetObject("ToolStripButton12.Image"), System.Drawing.Image)
        Me.ToolStripButton12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.Size = New System.Drawing.Size(65, 53)
        Me.ToolStripButton12.Text = "Devolução"
        Me.ToolStripButton12.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolStripButton12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButton12.ToolTipText = "Plano contas"
        Me.ToolStripButton12.Visible = False
        '
        'TabItemVendas
        '
        Me.TabItemVendas.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabItemVendas.Name = "TabItemVendas"
        '
        'TabPrincipal.RibbonPanel4
        '
        Me.TabItemVendas.Panel.Controls.Add(Me.MenuVendas)
        Me.TabItemVendas.Panel.Name = "RibbonPanel4"
        Me.TabItemVendas.Panel.ScrollPosition = 0
        Me.TabItemVendas.Panel.TabIndex = 3
        Me.TabItemVendas.Panel.Text = "Consultas"
        Me.TabItemVendas.Position = 3
        Me.TabItemVendas.Size = New System.Drawing.Size(74, 30)
        Me.TabItemVendas.Tag = "2"
        Me.TabItemVendas.Text = "Consultas"
        Me.TabItemVendas.ToolTipText = "Consultas"
        '
        'MenuVendas
        '
        Me.MenuVendas.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.MenuVendas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.MenuVendas.Image = Nothing
        Me.MenuVendas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AtalhoPedidoVenda2, Me.ToolStripButton3, Me.AtalhoFaturamento, Me.ToolStripButton1})
        Me.MenuVendas.Location = New System.Drawing.Point(0, 1)
        Me.MenuVendas.Name = "MenuVendas"
        Me.MenuVendas.Office12Mode = False
        Me.MenuVendas.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.MenuVendas.Size = New System.Drawing.Size(91, 76)
        Me.MenuVendas.TabIndex = 4
        '
        'AtalhoPedidoVenda2
        '
        Me.AtalhoPedidoVenda2.Image = CType(resources.GetObject("AtalhoPedidoVenda2.Image"), System.Drawing.Image)
        Me.AtalhoPedidoVenda2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AtalhoPedidoVenda2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AtalhoPedidoVenda2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AtalhoPedidoVenda2.Name = "AtalhoPedidoVenda2"
        Me.AtalhoPedidoVenda2.Size = New System.Drawing.Size(65, 62)
        Me.AtalhoPedidoVenda2.Text = "Consultas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Realizadas"
        Me.AtalhoPedidoVenda2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AtalhoPedidoVenda2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.AtalhoPedidoVenda2.ToolTipText = "Cadastro de parceiro"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(65, 53)
        Me.ToolStripButton3.Text = "     PDV      "
        Me.ToolStripButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButton3.ToolTipText = "Cadastro de parceiro"
        Me.ToolStripButton3.Visible = False
        '
        'AtalhoFaturamento
        '
        Me.AtalhoFaturamento.Image = CType(resources.GetObject("AtalhoFaturamento.Image"), System.Drawing.Image)
        Me.AtalhoFaturamento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AtalhoFaturamento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AtalhoFaturamento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AtalhoFaturamento.Name = "AtalhoFaturamento"
        Me.AtalhoFaturamento.Size = New System.Drawing.Size(77, 53)
        Me.AtalhoFaturamento.Text = "Faturamento"
        Me.AtalhoFaturamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AtalhoFaturamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.AtalhoFaturamento.ToolTipText = "Cadastro de parceiro"
        Me.AtalhoFaturamento.Visible = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(65, 53)
        Me.ToolStripButton1.Text = "Devolução"
        Me.ToolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButton1.ToolTipText = "Cadastro de parceiro"
        Me.ToolStripButton1.Visible = False
        '
        'TabItemFinanceiro
        '
        Me.TabItemFinanceiro.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabItemFinanceiro.ForeColor = System.Drawing.Color.Black
        Me.TabItemFinanceiro.Name = "TabItemFinanceiro"
        '
        'TabPrincipal.RibbonPanel5
        '
        Me.TabItemFinanceiro.Panel.Controls.Add(Me.MenuFinanceiro)
        Me.TabItemFinanceiro.Panel.Name = "RibbonPanel5"
        Me.TabItemFinanceiro.Panel.ScrollPosition = 0
        Me.TabItemFinanceiro.Panel.TabIndex = 4
        Me.TabItemFinanceiro.Panel.Text = "Financeiro"
        Me.TabItemFinanceiro.Position = 4
        Me.TabItemFinanceiro.Size = New System.Drawing.Size(77, 30)
        Me.TabItemFinanceiro.Tag = "3"
        Me.TabItemFinanceiro.Text = "Financeiro"
        Me.TabItemFinanceiro.ToolTipText = "MnuVendas"
        Me.TabItemFinanceiro.Visible = False
        '
        'MenuFinanceiro
        '
        Me.MenuFinanceiro.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.MenuFinanceiro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.MenuFinanceiro.Image = Nothing
        Me.MenuFinanceiro.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AtalhoCaixa, Me.AtalhoBanco, Me.AtalhoMovimentacaoFinanceira})
        Me.MenuFinanceiro.Location = New System.Drawing.Point(0, 1)
        Me.MenuFinanceiro.Name = "MenuFinanceiro"
        Me.MenuFinanceiro.Office12Mode = False
        Me.MenuFinanceiro.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.MenuFinanceiro.Size = New System.Drawing.Size(250, 76)
        Me.MenuFinanceiro.TabIndex = 3
        '
        'AtalhoCaixa
        '
        Me.AtalhoCaixa.Image = CType(resources.GetObject("AtalhoCaixa.Image"), System.Drawing.Image)
        Me.AtalhoCaixa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AtalhoCaixa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AtalhoCaixa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AtalhoCaixa.Name = "AtalhoCaixa"
        Me.AtalhoCaixa.Size = New System.Drawing.Size(62, 62)
        Me.AtalhoCaixa.Text = "    Caixa    "
        Me.AtalhoCaixa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AtalhoCaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.AtalhoCaixa.ToolTipText = "Cadastro de parceiro"
        '
        'AtalhoBanco
        '
        Me.AtalhoBanco.Image = CType(resources.GetObject("AtalhoBanco.Image"), System.Drawing.Image)
        Me.AtalhoBanco.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AtalhoBanco.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AtalhoBanco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AtalhoBanco.Name = "AtalhoBanco"
        Me.AtalhoBanco.Size = New System.Drawing.Size(61, 62)
        Me.AtalhoBanco.Text = "  Banco    "
        Me.AtalhoBanco.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AtalhoBanco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.AtalhoBanco.ToolTipText = "Cadastro de parceiro"
        '
        'AtalhoMovimentacaoFinanceira
        '
        Me.AtalhoMovimentacaoFinanceira.Image = CType(resources.GetObject("AtalhoMovimentacaoFinanceira.Image"), System.Drawing.Image)
        Me.AtalhoMovimentacaoFinanceira.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AtalhoMovimentacaoFinanceira.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AtalhoMovimentacaoFinanceira.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AtalhoMovimentacaoFinanceira.Name = "AtalhoMovimentacaoFinanceira"
        Me.AtalhoMovimentacaoFinanceira.Size = New System.Drawing.Size(85, 62)
        Me.AtalhoMovimentacaoFinanceira.Text = "Contas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Receber/Pagar"
        Me.AtalhoMovimentacaoFinanceira.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AtalhoMovimentacaoFinanceira.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.AtalhoMovimentacaoFinanceira.ToolTipText = "Cadastro de parceiro"
        '
        'TabItemFiscal
        '
        Me.TabItemFiscal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabItemFiscal.ForeColor = System.Drawing.Color.Black
        Me.TabItemFiscal.Name = "TabItemFiscal"
        '
        'TabPrincipal.RibbonPanel6
        '
        Me.TabItemFiscal.Panel.Controls.Add(Me.MenuFiscal)
        Me.TabItemFiscal.Panel.Name = "RibbonPanel6"
        Me.TabItemFiscal.Panel.ScrollPosition = 0
        Me.TabItemFiscal.Panel.TabIndex = 4
        Me.TabItemFiscal.Panel.Text = "Fiscal   "
        Me.TabItemFiscal.Position = 5
        Me.TabItemFiscal.Size = New System.Drawing.Size(60, 30)
        Me.TabItemFiscal.Tag = "3"
        Me.TabItemFiscal.Text = "Fiscal   "
        Me.TabItemFiscal.ToolTipText = "MnuVendas"
        Me.TabItemFiscal.Visible = False
        '
        'MenuFiscal
        '
        Me.MenuFiscal.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.MenuFiscal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.MenuFiscal.Image = Nothing
        Me.MenuFiscal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton5, Me.ToolStripButton4, Me.AtalhoMenuFiscal, Me.AtalhoNFe, Me.ToolStripButton2, Me.AtalhoMenuFiscal1})
        Me.MenuFiscal.Location = New System.Drawing.Point(0, 1)
        Me.MenuFiscal.Name = "MenuFiscal"
        Me.MenuFiscal.Office12Mode = False
        Me.MenuFiscal.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.MenuFiscal.Size = New System.Drawing.Size(88, 76)
        Me.MenuFiscal.TabIndex = 4
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(72, 53)
        Me.ToolStripButton5.Text = "Menu Fiscal"
        Me.ToolStripButton5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButton5.ToolTipText = "Cadastro de parceiro"
        Me.ToolStripButton5.Visible = False
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(66, 53)
        Me.ToolStripButton4.Text = "  Sintegra  "
        Me.ToolStripButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButton4.ToolTipText = "Cadastro de parceiro"
        Me.ToolStripButton4.Visible = False
        '
        'AtalhoMenuFiscal
        '
        Me.AtalhoMenuFiscal.Image = CType(resources.GetObject("AtalhoMenuFiscal.Image"), System.Drawing.Image)
        Me.AtalhoMenuFiscal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AtalhoMenuFiscal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AtalhoMenuFiscal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AtalhoMenuFiscal.Name = "AtalhoMenuFiscal"
        Me.AtalhoMenuFiscal.Size = New System.Drawing.Size(61, 53)
        Me.AtalhoMenuFiscal.Text = "    SPED    "
        Me.AtalhoMenuFiscal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AtalhoMenuFiscal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.AtalhoMenuFiscal.ToolTipText = "Cadastro de parceiro"
        Me.AtalhoMenuFiscal.Visible = False
        '
        'AtalhoNFe
        '
        Me.AtalhoNFe.Image = CType(resources.GetObject("AtalhoNFe.Image"), System.Drawing.Image)
        Me.AtalhoNFe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AtalhoNFe.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AtalhoNFe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AtalhoNFe.Name = "AtalhoNFe"
        Me.AtalhoNFe.Size = New System.Drawing.Size(62, 62)
        Me.AtalhoNFe.Text = "    NF-e     "
        Me.AtalhoNFe.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AtalhoNFe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.AtalhoNFe.ToolTipText = "Cadastro de parceiro"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(69, 53)
        Me.ToolStripButton2.Text = "    NFC-e     "
        Me.ToolStripButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButton2.ToolTipText = "Cadastro de parceiro"
        Me.ToolStripButton2.Visible = False
        '
        'AtalhoMenuFiscal1
        '
        Me.AtalhoMenuFiscal1.Image = CType(resources.GetObject("AtalhoMenuFiscal1.Image"), System.Drawing.Image)
        Me.AtalhoMenuFiscal1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AtalhoMenuFiscal1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AtalhoMenuFiscal1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AtalhoMenuFiscal1.Name = "AtalhoMenuFiscal1"
        Me.AtalhoMenuFiscal1.Size = New System.Drawing.Size(63, 53)
        Me.AtalhoMenuFiscal1.Text = "     CT-e     "
        Me.AtalhoMenuFiscal1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AtalhoMenuFiscal1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.AtalhoMenuFiscal1.ToolTipText = "Cadastro de parceiro"
        Me.AtalhoMenuFiscal1.Visible = False
        '
        'TabItemRelatorios
        '
        Me.TabItemRelatorios.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabItemRelatorios.ForeColor = System.Drawing.Color.Black
        Me.TabItemRelatorios.Name = "TabItemRelatorios"
        '
        'TabPrincipal.RibbonPanel7
        '
        Me.TabItemRelatorios.Panel.BackColor = System.Drawing.SystemColors.Control
        Me.TabItemRelatorios.Panel.Controls.Add(Me.MenuRelatorios)
        Me.TabItemRelatorios.Panel.Name = "RibbonPanel7"
        Me.TabItemRelatorios.Panel.ScrollPosition = 0
        Me.TabItemRelatorios.Panel.TabIndex = 5
        Me.TabItemRelatorios.Panel.Text = "Relátorios"
        Me.TabItemRelatorios.Position = 6
        Me.TabItemRelatorios.Size = New System.Drawing.Size(75, 30)
        Me.TabItemRelatorios.Tag = "9"
        Me.TabItemRelatorios.Text = "Relátorios"
        '
        'MenuRelatorios
        '
        Me.MenuRelatorios.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.MenuRelatorios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.MenuRelatorios.Image = Nothing
        Me.MenuRelatorios.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AtalhoRelVendas})
        Me.MenuRelatorios.Location = New System.Drawing.Point(0, 1)
        Me.MenuRelatorios.Name = "MenuRelatorios"
        Me.MenuRelatorios.Office12Mode = False
        Me.MenuRelatorios.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.MenuRelatorios.Size = New System.Drawing.Size(88, 76)
        Me.MenuRelatorios.TabIndex = 5
        '
        'AtalhoRelVendas
        '
        Me.AtalhoRelVendas.Image = CType(resources.GetObject("AtalhoRelVendas.Image"), System.Drawing.Image)
        Me.AtalhoRelVendas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AtalhoRelVendas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AtalhoRelVendas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AtalhoRelVendas.Name = "AtalhoRelVendas"
        Me.AtalhoRelVendas.Size = New System.Drawing.Size(62, 62)
        Me.AtalhoRelVendas.Text = "Consultas"
        Me.AtalhoRelVendas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AtalhoRelVendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.AtalhoRelVendas.ToolTipText = "Vendas"
        '
        'StripInferior
        '
        Me.StripInferior.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuNomeFantasia, Me.MnuVersao, Me.MnuUsuarioLogado, Me.MnuUltimoAcesso})
        Me.StripInferior.Location = New System.Drawing.Point(1, 615)
        Me.StripInferior.Name = "StripInferior"
        Me.StripInferior.Size = New System.Drawing.Size(1036, 22)
        Me.StripInferior.TabIndex = 2
        Me.StripInferior.Text = "MnuInferior"
        '
        'MnuNomeFantasia
        '
        Me.MnuNomeFantasia.Name = "MnuNomeFantasia"
        Me.MnuNomeFantasia.Size = New System.Drawing.Size(96, 17)
        Me.MnuNomeFantasia.Text = "Empresa:      -      "
        '
        'MnuVersao
        '
        Me.MnuVersao.Name = "MnuVersao"
        Me.MnuVersao.Size = New System.Drawing.Size(85, 17)
        Me.MnuVersao.Text = "Versão:      -      "
        '
        'MnuUsuarioLogado
        '
        Me.MnuUsuarioLogado.Name = "MnuUsuarioLogado"
        Me.MnuUsuarioLogado.Size = New System.Drawing.Size(91, 17)
        Me.MnuUsuarioLogado.Text = "Usuário:      -      "
        '
        'MnuUltimoAcesso
        '
        Me.MnuUltimoAcesso.Name = "MnuUltimoAcesso"
        Me.MnuUltimoAcesso.Size = New System.Drawing.Size(125, 17)
        Me.MnuUltimoAcesso.Text = "Último acesso:      -      "
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnChamadoPendente)
        Me.Panel1.Controls.Add(Me.LblChamado)
        Me.Panel1.Controls.Add(Me.BtnCompromissosFuturos)
        Me.Panel1.Controls.Add(Me.BtnCompromissosHoje)
        Me.Panel1.Controls.Add(Me.LblAgenda)
        Me.Panel1.Controls.Add(Me.BtnCompromissosAtrasados)
        Me.Panel1.Location = New System.Drawing.Point(650, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(384, 46)
        Me.Panel1.TabIndex = 4
        Me.Panel1.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightCoral
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(330, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(34, 25)
        Me.Button2.TabIndex = 17
        Me.Button2.TabStop = False
        Me.Button2.Text = "0"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(311, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Pendências"
        Me.Label2.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightCoral
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(242, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 25)
        Me.Button1.TabIndex = 15
        Me.Button1.TabStop = False
        Me.Button1.Text = "0"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(215, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Aniversáriantes"
        Me.Label1.Visible = False
        '
        'BtnChamadoPendente
        '
        Me.BtnChamadoPendente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnChamadoPendente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnChamadoPendente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnChamadoPendente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChamadoPendente.Location = New System.Drawing.Point(159, 1)
        Me.BtnChamadoPendente.Name = "BtnChamadoPendente"
        Me.BtnChamadoPendente.Size = New System.Drawing.Size(34, 25)
        Me.BtnChamadoPendente.TabIndex = 13
        Me.BtnChamadoPendente.TabStop = False
        Me.BtnChamadoPendente.Text = "0"
        Me.BtnChamadoPendente.UseVisualStyleBackColor = False
        '
        'LblChamado
        '
        Me.LblChamado.AutoSize = True
        Me.LblChamado.BackColor = System.Drawing.SystemColors.Control
        Me.LblChamado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblChamado.Location = New System.Drawing.Point(142, 26)
        Me.LblChamado.Name = "LblChamado"
        Me.LblChamado.Size = New System.Drawing.Size(67, 15)
        Me.LblChamado.TabIndex = 14
        Me.LblChamado.Text = "Chamados"
        '
        'BtnCompromissosFuturos
        '
        Me.BtnCompromissosFuturos.BackColor = System.Drawing.Color.LightBlue
        Me.BtnCompromissosFuturos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCompromissosFuturos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCompromissosFuturos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCompromissosFuturos.Location = New System.Drawing.Point(85, 1)
        Me.BtnCompromissosFuturos.Name = "BtnCompromissosFuturos"
        Me.BtnCompromissosFuturos.Size = New System.Drawing.Size(34, 25)
        Me.BtnCompromissosFuturos.TabIndex = 9
        Me.BtnCompromissosFuturos.TabStop = False
        Me.BtnCompromissosFuturos.Text = "0"
        Me.BtnCompromissosFuturos.UseVisualStyleBackColor = False
        '
        'BtnCompromissosHoje
        '
        Me.BtnCompromissosHoje.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnCompromissosHoje.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCompromissosHoje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCompromissosHoje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCompromissosHoje.Location = New System.Drawing.Point(45, 1)
        Me.BtnCompromissosHoje.Name = "BtnCompromissosHoje"
        Me.BtnCompromissosHoje.Size = New System.Drawing.Size(34, 25)
        Me.BtnCompromissosHoje.TabIndex = 10
        Me.BtnCompromissosHoje.TabStop = False
        Me.BtnCompromissosHoje.Text = "0"
        Me.BtnCompromissosHoje.UseVisualStyleBackColor = False
        '
        'LblAgenda
        '
        Me.LblAgenda.AutoSize = True
        Me.LblAgenda.BackColor = System.Drawing.SystemColors.Control
        Me.LblAgenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAgenda.Location = New System.Drawing.Point(15, 26)
        Me.LblAgenda.Name = "LblAgenda"
        Me.LblAgenda.Size = New System.Drawing.Size(90, 15)
        Me.LblAgenda.TabIndex = 11
        Me.LblAgenda.Text = "Agendamentos"
        '
        'BtnCompromissosAtrasados
        '
        Me.BtnCompromissosAtrasados.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnCompromissosAtrasados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCompromissosAtrasados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCompromissosAtrasados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCompromissosAtrasados.Location = New System.Drawing.Point(5, 1)
        Me.BtnCompromissosAtrasados.Name = "BtnCompromissosAtrasados"
        Me.BtnCompromissosAtrasados.Size = New System.Drawing.Size(34, 25)
        Me.BtnCompromissosAtrasados.TabIndex = 12
        Me.BtnCompromissosAtrasados.TabStop = False
        Me.BtnCompromissosAtrasados.Text = "0"
        Me.BtnCompromissosAtrasados.UseVisualStyleBackColor = False
        '
        'Menu
        '
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuCadastro, Me.FerramentasToolStripMenuItem, Me.ImportaçãoToolStripMenuItem, Me.MnuAcessoRemoto, Me.MnuTrocarUsuario, Me.MnuConfiguracoes, Me.MnuSairSistema})
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(154, 158)
        '
        'MnuCadastro
        '
        Me.MnuCadastro.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParceiroToolStripMenuItem, Me.ProdutoToolStripMenuItem, Me.EmpresaToolStripMenuItem, Me.UsuárioToolStripMenuItem, Me.FiscalToolStripMenuItem, Me.FinanceiroToolStripMenuItem})
        Me.MnuCadastro.Image = CType(resources.GetObject("MnuCadastro.Image"), System.Drawing.Image)
        Me.MnuCadastro.Name = "MnuCadastro"
        Me.MnuCadastro.Size = New System.Drawing.Size(153, 22)
        Me.MnuCadastro.Text = "Cadastros"
        '
        'ParceiroToolStripMenuItem
        '
        Me.ParceiroToolStripMenuItem.Image = CType(resources.GetObject("ParceiroToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ParceiroToolStripMenuItem.Name = "ParceiroToolStripMenuItem"
        Me.ParceiroToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.ParceiroToolStripMenuItem.Text = "Parceiro"
        Me.ParceiroToolStripMenuItem.Visible = False
        '
        'ProdutoToolStripMenuItem
        '
        Me.ProdutoToolStripMenuItem.Image = CType(resources.GetObject("ProdutoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProdutoToolStripMenuItem.Name = "ProdutoToolStripMenuItem"
        Me.ProdutoToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.ProdutoToolStripMenuItem.Text = "Produto"
        Me.ProdutoToolStripMenuItem.Visible = False
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.Image = CType(resources.GetObject("EmpresaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.EmpresaToolStripMenuItem.Text = "Empresa"
        Me.EmpresaToolStripMenuItem.Visible = False
        '
        'UsuárioToolStripMenuItem
        '
        Me.UsuárioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuárioToolStripMenuItem1, Me.GrupoDeUsuárioToolStripMenuItem})
        Me.UsuárioToolStripMenuItem.Image = CType(resources.GetObject("UsuárioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UsuárioToolStripMenuItem.Name = "UsuárioToolStripMenuItem"
        Me.UsuárioToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.UsuárioToolStripMenuItem.Text = "Usuário"
        Me.UsuárioToolStripMenuItem.Visible = False
        '
        'UsuárioToolStripMenuItem1
        '
        Me.UsuárioToolStripMenuItem1.Name = "UsuárioToolStripMenuItem1"
        Me.UsuárioToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.UsuárioToolStripMenuItem1.Text = "Usuário"
        '
        'GrupoDeUsuárioToolStripMenuItem
        '
        Me.GrupoDeUsuárioToolStripMenuItem.Name = "GrupoDeUsuárioToolStripMenuItem"
        Me.GrupoDeUsuárioToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.GrupoDeUsuárioToolStripMenuItem.Text = "Grupo de usuário"
        '
        'FiscalToolStripMenuItem
        '
        Me.FiscalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuTributacao, Me.NCMToolStripMenuItem, Me.CESTToolStripMenuItem})
        Me.FiscalToolStripMenuItem.Name = "FiscalToolStripMenuItem"
        Me.FiscalToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.FiscalToolStripMenuItem.Text = "Fiscal"
        '
        'MnuTributacao
        '
        Me.MnuTributacao.Name = "MnuTributacao"
        Me.MnuTributacao.Size = New System.Drawing.Size(130, 22)
        Me.MnuTributacao.Text = "Tributação"
        '
        'NCMToolStripMenuItem
        '
        Me.NCMToolStripMenuItem.Name = "NCMToolStripMenuItem"
        Me.NCMToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.NCMToolStripMenuItem.Text = "NCM"
        Me.NCMToolStripMenuItem.Visible = False
        '
        'CESTToolStripMenuItem
        '
        Me.CESTToolStripMenuItem.Name = "CESTToolStripMenuItem"
        Me.CESTToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.CESTToolStripMenuItem.Text = "CEST"
        Me.CESTToolStripMenuItem.Visible = False
        '
        'FinanceiroToolStripMenuItem
        '
        Me.FinanceiroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TipoDeContratoToolStripMenuItem})
        Me.FinanceiroToolStripMenuItem.Name = "FinanceiroToolStripMenuItem"
        Me.FinanceiroToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.FinanceiroToolStripMenuItem.Text = "Financeiro"
        '
        'TipoDeContratoToolStripMenuItem
        '
        Me.TipoDeContratoToolStripMenuItem.Name = "TipoDeContratoToolStripMenuItem"
        Me.TipoDeContratoToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.TipoDeContratoToolStripMenuItem.Text = "Tipo de contrato"
        '
        'FerramentasToolStripMenuItem
        '
        Me.FerramentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MacroToolStripMenuItem})
        Me.FerramentasToolStripMenuItem.Name = "FerramentasToolStripMenuItem"
        Me.FerramentasToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.FerramentasToolStripMenuItem.Text = "Ferramentas"
        '
        'MacroToolStripMenuItem
        '
        Me.MacroToolStripMenuItem.Name = "MacroToolStripMenuItem"
        Me.MacroToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.MacroToolStripMenuItem.Text = "Macro"
        '
        'ImportaçãoToolStripMenuItem
        '
        Me.ImportaçãoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesFornecedoresToolStripMenuItem, Me.ProdutosServiçosToolStripMenuItem})
        Me.ImportaçãoToolStripMenuItem.Name = "ImportaçãoToolStripMenuItem"
        Me.ImportaçãoToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ImportaçãoToolStripMenuItem.Text = "Importação"
        '
        'ClientesFornecedoresToolStripMenuItem
        '
        Me.ClientesFornecedoresToolStripMenuItem.Name = "ClientesFornecedoresToolStripMenuItem"
        Me.ClientesFornecedoresToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ClientesFornecedoresToolStripMenuItem.Text = "Clientes/Fornecedores"
        '
        'ProdutosServiçosToolStripMenuItem
        '
        Me.ProdutosServiçosToolStripMenuItem.Name = "ProdutosServiçosToolStripMenuItem"
        Me.ProdutosServiçosToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ProdutosServiçosToolStripMenuItem.Text = "Produtos/Serviços"
        '
        'MnuAcessoRemoto
        '
        Me.MnuAcessoRemoto.Image = CType(resources.GetObject("MnuAcessoRemoto.Image"), System.Drawing.Image)
        Me.MnuAcessoRemoto.Name = "MnuAcessoRemoto"
        Me.MnuAcessoRemoto.Size = New System.Drawing.Size(153, 22)
        Me.MnuAcessoRemoto.Text = "Acesso remoto"
        '
        'MnuTrocarUsuario
        '
        Me.MnuTrocarUsuario.Image = CType(resources.GetObject("MnuTrocarUsuario.Image"), System.Drawing.Image)
        Me.MnuTrocarUsuario.Name = "MnuTrocarUsuario"
        Me.MnuTrocarUsuario.Size = New System.Drawing.Size(153, 22)
        Me.MnuTrocarUsuario.Text = "Trocar usuário"
        Me.MnuTrocarUsuario.Visible = False
        '
        'MnuConfiguracoes
        '
        Me.MnuConfiguracoes.Image = CType(resources.GetObject("MnuConfiguracoes.Image"), System.Drawing.Image)
        Me.MnuConfiguracoes.Name = "MnuConfiguracoes"
        Me.MnuConfiguracoes.Size = New System.Drawing.Size(153, 22)
        Me.MnuConfiguracoes.Text = "Configurações"
        '
        'MnuSairSistema
        '
        Me.MnuSairSistema.Image = CType(resources.GetObject("MnuSairSistema.Image"), System.Drawing.Image)
        Me.MnuSairSistema.Name = "MnuSairSistema"
        Me.MnuSairSistema.Size = New System.Drawing.Size(153, 22)
        Me.MnuSairSistema.Text = "Sair do sistema"
        Me.MnuSairSistema.Visible = False
        '
        'ViewSaude
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Borders = New System.Windows.Forms.Padding(0)
        Me.ClientSize = New System.Drawing.Size(1038, 638)
        Me.ColorScheme = Syncfusion.Windows.Forms.Tools.RibbonForm.ColorSchemeType.Silver
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StripInferior)
        Me.Controls.Add(Me.TabPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "ViewSaude"
        Me.Padding = New System.Windows.Forms.Padding(1, 0, 1, 1)
        Me.ShowApplicationIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Atlanta Sistemas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TabPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPrincipal.ResumeLayout(False)
        Me.TabPrincipal.PerformLayout()
        Me.TabItemPrincipal.Panel.ResumeLayout(False)
        Me.TabItemPrincipal.Panel.PerformLayout()
        Me.MnuPrincipal.ResumeLayout(False)
        Me.MnuPrincipal.PerformLayout()
        Me.TabItemCadastros.Panel.ResumeLayout(False)
        Me.TabItemCadastros.Panel.PerformLayout()
        Me.MenuCadastros.ResumeLayout(False)
        Me.MenuCadastros.PerformLayout()
        Me.TabItemCompras.Panel.ResumeLayout(False)
        Me.TabItemCompras.Panel.PerformLayout()
        Me.MenuCompras.ResumeLayout(False)
        Me.MenuCompras.PerformLayout()
        Me.TabItemVendas.Panel.ResumeLayout(False)
        Me.TabItemVendas.Panel.PerformLayout()
        Me.MenuVendas.ResumeLayout(False)
        Me.MenuVendas.PerformLayout()
        Me.TabItemFinanceiro.Panel.ResumeLayout(False)
        Me.TabItemFinanceiro.Panel.PerformLayout()
        Me.MenuFinanceiro.ResumeLayout(False)
        Me.MenuFinanceiro.PerformLayout()
        Me.TabItemFiscal.Panel.ResumeLayout(False)
        Me.TabItemFiscal.Panel.PerformLayout()
        Me.MenuFiscal.ResumeLayout(False)
        Me.MenuFiscal.PerformLayout()
        Me.TabItemRelatorios.Panel.ResumeLayout(False)
        Me.TabItemRelatorios.Panel.PerformLayout()
        Me.MenuRelatorios.ResumeLayout(False)
        Me.MenuRelatorios.PerformLayout()
        Me.StripInferior.ResumeLayout(False)
        Me.StripInferior.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Menu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Declarations"
    Private TabPrincipal As Syncfusion.Windows.Forms.Tools.RibbonControlAdv
    Private TabItemPrincipal As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
    Private TabItemFinanceiro As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
    Private TabItemFiscal As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
    Private TabItemCadastros As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
    Private TabItemCompras As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
    Private TabItemVendas As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
    Private TabItemRelatorios As Syncfusion.Windows.Forms.Tools.ToolStripTabItem

    Friend WithEvents MnuPrincipal As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents AtalhoProduto As ToolStripButton
    Friend WithEvents AtalhoParceiro As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AtalhoPedidoVenda As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents AtalhoAcessoRemoto As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents AtalhoSairSistema As ToolStripButton
    Friend WithEvents MenuCadastros As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents BtnUsuario As ToolStripButton
    Friend WithEvents BtnTabela As ToolStripButton
    Friend WithEvents BtnLocalAtendimento As ToolStripButton
    Friend WithEvents AtalhoProduto2 As ToolStripButton
    Friend WithEvents AtalhoFormaPagamento As ToolStripButton
    Friend WithEvents BtnOperadora As ToolStripButton
    Friend WithEvents StripInferior As StatusStrip
    Friend WithEvents MnuNomeFantasia As ToolStripStatusLabel
    Friend WithEvents MnuVersao As ToolStripStatusLabel
    Friend WithEvents MnuUsuarioLogado As ToolStripStatusLabel
    Friend WithEvents MnuUltimoAcesso As ToolStripStatusLabel
    Friend WithEvents MenuFinanceiro As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents AtalhoMovimentacaoFinanceira As ToolStripButton
    Friend WithEvents MenuVendas As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents AtalhoFaturamento As ToolStripButton
    Friend WithEvents MenuRelatorios As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents AtalhoRelVendas As ToolStripButton
    Friend WithEvents BtnPrestador As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Private WithEvents Button2 As Button
    Private WithEvents Label2 As Label
    Private WithEvents Button1 As Button
    Private WithEvents Label1 As Label
    Private WithEvents BtnChamadoPendente As Button
    Private WithEvents LblChamado As Label
    Private WithEvents BtnCompromissosFuturos As Button
    Private WithEvents BtnCompromissosHoje As Button
    Private WithEvents LblAgenda As Label
    Private WithEvents BtnCompromissosAtrasados As Button
    Friend WithEvents AtalhoPedidoVenda2 As ToolStripButton
    Friend WithEvents MenuFiscal As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents AtalhoMenuFiscal As ToolStripButton
    Friend WithEvents AtalhoNFe As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents AtalhoMenuFiscal1 As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents AtalhoCaixa As ToolStripButton
    Friend WithEvents AtalhoBanco As ToolStripButton
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents AtalhoCaixa2 As ToolStripButton
    Friend WithEvents AtalhoBanco2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents Menu As ContextMenuStrip
    Friend WithEvents MnuCadastro As ToolStripMenuItem
    Friend WithEvents MnuConfiguracoes As ToolStripMenuItem
    Friend WithEvents MnuAcessoRemoto As ToolStripMenuItem
    Friend WithEvents MnuTrocarUsuario As ToolStripMenuItem
    Friend WithEvents MnuSairSistema As ToolStripMenuItem
    Friend WithEvents ParceiroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdutoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuárioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuárioToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GrupoDeUsuárioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FiscalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuTributacao As ToolStripMenuItem
    Friend WithEvents NCMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CESTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuCompras As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents AtalhoEntradaMercadoria As ToolStripButton
    Friend WithEvents ToolStripButton12 As ToolStripButton
    Friend WithEvents FerramentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MacroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FinanceiroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoDeContratoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportaçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesFornecedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdutosServiçosToolStripMenuItem As ToolStripMenuItem

#End Region

End Class


