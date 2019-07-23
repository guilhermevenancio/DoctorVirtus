<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtSenha = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnEntrar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Carregando = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblOnline = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Carregando.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(279, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuário"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(279, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Senha"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtUsuario.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TxtUsuario.Location = New System.Drawing.Point(282, 55)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(174, 25)
        Me.TxtUsuario.TabIndex = 2
        '
        'TxtSenha
        '
        Me.TxtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSenha.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.TxtSenha.Location = New System.Drawing.Point(282, 104)
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtSenha.Size = New System.Drawing.Size(174, 25)
        Me.TxtSenha.TabIndex = 3
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.Red
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(371, 140)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(85, 28)
        Me.BtnCancelar.TabIndex = 5
        Me.BtnCancelar.Text = "Sair"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnEntrar
        '
        Me.BtnEntrar.BackColor = System.Drawing.Color.Green
        Me.BtnEntrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEntrar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEntrar.ForeColor = System.Drawing.Color.White
        Me.BtnEntrar.Image = CType(resources.GetObject("BtnEntrar.Image"), System.Drawing.Image)
        Me.BtnEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEntrar.Location = New System.Drawing.Point(282, 140)
        Me.BtnEntrar.Name = "BtnEntrar"
        Me.BtnEntrar.Size = New System.Drawing.Size(85, 29)
        Me.BtnEntrar.TabIndex = 4
        Me.BtnEntrar.Text = "Entrar"
        Me.BtnEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEntrar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(28, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 42)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Atlanta Sistemas"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(82, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Carregando)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.TxtSenha)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtUsuario)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnEntrar)
        Me.GroupBox1.Controls.Add(Me.LblOnline)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(4, -3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(466, 200)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'Carregando
        '
        Me.Carregando.Controls.Add(Me.Label5)
        Me.Carregando.Controls.Add(Me.Label4)
        Me.Carregando.Location = New System.Drawing.Point(258, 19)
        Me.Carregando.Name = "Carregando"
        Me.Carregando.Size = New System.Drawing.Size(202, 167)
        Me.Carregando.TabIndex = 86
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(57, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Carregando..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Aguarde um momento"
        '
        'LblOnline
        '
        Me.LblOnline.AutoSize = True
        Me.LblOnline.BackColor = System.Drawing.Color.Transparent
        Me.LblOnline.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOnline.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LblOnline.Location = New System.Drawing.Point(412, 32)
        Me.LblOnline.Name = "LblOnline"
        Me.LblOnline.Size = New System.Drawing.Size(20, 16)
        Me.LblOnline.TabIndex = 85
        Me.LblOnline.Text = "..."
        '
        'ViewLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(474, 200)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Carregando.ResumeLayout(False)
        Me.Carregando.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtSenha As TextBox
    Friend WithEvents BtnEntrar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Carregando As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblOnline As Label
End Class
