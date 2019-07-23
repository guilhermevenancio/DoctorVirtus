<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAtualizacaoSistema
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAtualizacaoSistema))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnIniciarDownload = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlControlesStatus = New System.Windows.Forms.Panel()
        Me.pgbarDownload = New System.Windows.Forms.ProgressBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTempoDecorrido = New System.Windows.Forms.Label()
        Me.lblTempoRestante = New System.Windows.Forms.Label()
        Me.lblProgresso = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControlesStatus.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoEllipsis = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(157, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 21)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Deseja atualizar agora ?"
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 21)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Existe uma atualização disponível"
        '
        'BtnIniciarDownload
        '
        Me.BtnIniciarDownload.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnIniciarDownload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIniciarDownload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnIniciarDownload.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BtnIniciarDownload.Image = CType(resources.GetObject("BtnIniciarDownload.Image"), System.Drawing.Image)
        Me.BtnIniciarDownload.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.BtnIniciarDownload.Location = New System.Drawing.Point(260, 88)
        Me.BtnIniciarDownload.Name = "BtnIniciarDownload"
        Me.BtnIniciarDownload.Size = New System.Drawing.Size(105, 31)
        Me.BtnIniciarDownload.TabIndex = 1
        Me.BtnIniciarDownload.Text = "SIM"
        Me.BtnIniciarDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnIniciarDownload.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoEllipsis = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(7, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(372, 21)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "* Para que o sistema funcione corretamente e recomendável que"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(113, 105)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'pnlControlesStatus
        '
        Me.pnlControlesStatus.Controls.Add(Me.pgbarDownload)
        Me.pnlControlesStatus.Controls.Add(Me.Label4)
        Me.pnlControlesStatus.Controls.Add(Me.Label3)
        Me.pnlControlesStatus.Controls.Add(Me.lblTempoDecorrido)
        Me.pnlControlesStatus.Controls.Add(Me.lblTempoRestante)
        Me.pnlControlesStatus.Controls.Add(Me.lblProgresso)
        Me.pnlControlesStatus.Location = New System.Drawing.Point(5, 5)
        Me.pnlControlesStatus.Name = "pnlControlesStatus"
        Me.pnlControlesStatus.Size = New System.Drawing.Size(387, 176)
        Me.pnlControlesStatus.TabIndex = 32
        Me.pnlControlesStatus.Visible = False
        '
        'pgbarDownload
        '
        Me.pgbarDownload.Location = New System.Drawing.Point(6, 125)
        Me.pgbarDownload.Name = "pgbarDownload"
        Me.pgbarDownload.Size = New System.Drawing.Size(378, 24)
        Me.pgbarDownload.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pgbarDownload.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(82, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(229, 30)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Baixando atualização..."
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(113, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 21)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Aguarde um momento"
        '
        'lblTempoDecorrido
        '
        Me.lblTempoDecorrido.Location = New System.Drawing.Point(3, 152)
        Me.lblTempoDecorrido.Name = "lblTempoDecorrido"
        Me.lblTempoDecorrido.Size = New System.Drawing.Size(166, 21)
        Me.lblTempoDecorrido.TabIndex = 21
        Me.lblTempoDecorrido.Text = "Tempo decorrido: n/a"
        '
        'lblTempoRestante
        '
        Me.lblTempoRestante.Location = New System.Drawing.Point(218, 152)
        Me.lblTempoRestante.Name = "lblTempoRestante"
        Me.lblTempoRestante.Size = New System.Drawing.Size(166, 21)
        Me.lblTempoRestante.TabIndex = 20
        Me.lblTempoRestante.Text = "Tempo restante: n/a"
        '
        'lblProgresso
        '
        Me.lblProgresso.AutoEllipsis = True
        Me.lblProgresso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgresso.Location = New System.Drawing.Point(3, 105)
        Me.lblProgresso.Name = "lblProgresso"
        Me.lblProgresso.Size = New System.Drawing.Size(251, 21)
        Me.lblProgresso.TabIndex = 10
        Me.lblProgresso.Text = "Progresso : 0%"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.BtnCancelar)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.BtnIniciarDownload)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(387, 176)
        Me.Panel1.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoEllipsis = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(131, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 21)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "atualize o sistema"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.BtnCancelar.Location = New System.Drawing.Point(149, 88)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(105, 31)
        Me.BtnCancelar.TabIndex = 0
        Me.BtnCancelar.Text = "NÃO"
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'FrmAtualizacaoSistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 187)
        Me.Controls.Add(Me.pnlControlesStatus)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAtualizacaoSistema"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Atualização"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControlesStatus.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnIniciarDownload As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlControlesStatus As Panel
    Friend WithEvents lblProgresso As Label
    Friend WithEvents pgbarDownload As ProgressBar
    Friend WithEvents lblTempoRestante As Label
    Friend WithEvents lblTempoDecorrido As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Label5 As Label
End Class
