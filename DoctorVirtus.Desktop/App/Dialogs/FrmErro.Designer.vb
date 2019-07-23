<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmErro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmErro))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.panelBotoes = New System.Windows.Forms.Panel()
        Me.BtnDetalhes = New System.Windows.Forms.Button()
        Me.TxtInfo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblDetalhe = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBotoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 48)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ops! ocorreu uma não conformidade no sistema"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "entre em contato com o suporte técnico"
        '
        'BtnOK
        '
        Me.BtnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOK.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnOK.ForeColor = System.Drawing.Color.White
        Me.BtnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOK.Location = New System.Drawing.Point(246, 10)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(92, 28)
        Me.BtnOK.TabIndex = 5
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = False
        '
        'panelBotoes
        '
        Me.panelBotoes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelBotoes.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panelBotoes.Controls.Add(Me.BtnDetalhes)
        Me.panelBotoes.Controls.Add(Me.BtnOK)
        Me.panelBotoes.Location = New System.Drawing.Point(0, 104)
        Me.panelBotoes.Name = "panelBotoes"
        Me.panelBotoes.Size = New System.Drawing.Size(350, 49)
        Me.panelBotoes.TabIndex = 0
        '
        'BtnDetalhes
        '
        Me.BtnDetalhes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDetalhes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDetalhes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDetalhes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDetalhes.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.BtnDetalhes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDetalhes.Location = New System.Drawing.Point(148, 10)
        Me.BtnDetalhes.Name = "BtnDetalhes"
        Me.BtnDetalhes.Size = New System.Drawing.Size(92, 28)
        Me.BtnDetalhes.TabIndex = 6
        Me.BtnDetalhes.Text = "Detalhes"
        Me.BtnDetalhes.UseVisualStyleBackColor = False
        '
        'TxtInfo
        '
        Me.TxtInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtInfo.Location = New System.Drawing.Point(12, -5)
        Me.TxtInfo.Multiline = True
        Me.TxtInfo.Name = "TxtInfo"
        Me.TxtInfo.ReadOnly = True
        Me.TxtInfo.Size = New System.Drawing.Size(326, 85)
        Me.TxtInfo.TabIndex = 3
        Me.TxtInfo.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(205, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Telefone: (27) 99896-4520"
        '
        'LblDetalhe
        '
        Me.LblDetalhe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblDetalhe.AutoSize = True
        Me.LblDetalhe.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDetalhe.Location = New System.Drawing.Point(9, 83)
        Me.LblDetalhe.Name = "LblDetalhe"
        Me.LblDetalhe.Size = New System.Drawing.Size(47, 15)
        Me.LblDetalhe.TabIndex = 5
        Me.LblDetalhe.Text = "Detalhe"
        Me.LblDetalhe.Visible = False
        '
        'FrmErro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(350, 151)
        Me.Controls.Add(Me.LblDetalhe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.panelBotoes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtInfo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmErro"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Atenção"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBotoes.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnOK As Button
    Friend WithEvents panelBotoes As Panel
    Friend WithEvents BtnDetalhes As Button
    Friend WithEvents TxtInfo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LblDetalhe As Label
End Class
