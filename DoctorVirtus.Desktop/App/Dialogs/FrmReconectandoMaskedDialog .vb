Partial Public Class FrmReconectandoMaskedDialog : Inherits Form

    Shared mask As FrmReconectandoMaskedDialog
    Shared frmContainer As Form
    Private dialog As Form
    Private ucDialog As UserControl

    Private Sub New(ByVal parent As Form, ByVal dialog As Form)

        Call InitializeComponent()

        Me.dialog = dialog
        Me.FormBorderStyle = FormBorderStyle.None
        Me.BackColor = Color.Black
        Me.Opacity = 0.6
        Me.ShowInTaskbar = False
        Me.StartPosition = FormStartPosition.Manual
        Me.Size = parent.ClientSize
        Me.Location = parent.PointToScreen(Point.Empty)
        'parent.Move += AddressOf AdjustPosition
        'parent.SizeChanged += AddressOf AdjustPosition
    End Sub

    Private Sub New(ByVal parent As Form, ByVal ucDialog As UserControl)

        Call InitializeComponent()

        Me.ucDialog = ucDialog
        Me.FormBorderStyle = FormBorderStyle.None
        Me.BackColor = Color.Black
        Me.Opacity = 0.6
        Me.ShowInTaskbar = False
        Me.StartPosition = FormStartPosition.Manual
        Me.Size = parent.ClientSize
        Me.Location = parent.PointToScreen(Point.Empty)
        'parent.Move += AddressOf AdjustPosition
        'parent.SizeChanged += AddressOf AdjustPosition
    End Sub

    Private Sub AdjustPosition(ByVal sender As Object, ByVal e As EventArgs)
        Dim parent As Form = TryCast(sender, Form)
        Me.Location = parent.PointToScreen(Point.Empty)
        Me.ClientSize = parent.ClientSize
    End Sub

    Public Shared Function ShowDialogs(ByVal parent As Form, ByVal dialog As Form) As DialogResult
        mask = New FrmReconectandoMaskedDialog(parent, dialog)
        dialog.StartPosition = FormStartPosition.CenterParent
        mask.MdiParent = parent.MdiParent
        mask.Show()
        Dim result As DialogResult = dialog.ShowDialog(mask)
        mask.Close()
        Return result
    End Function

    Public Shared Function ShowDialogs(ByVal parent As Form, ByVal dialog As UserControl) As DialogResult
        mask = New FrmReconectandoMaskedDialog(parent, dialog)
        frmContainer = New Form With {
            .ShowInTaskbar = False,
            .FormBorderStyle = FormBorderStyle.None,
            .StartPosition = FormStartPosition.CenterParent,
            .Height = dialog.Height,
            .Width = dialog.Width
        }

        frmContainer.Controls.Add(dialog)
        mask.MdiParent = parent.MdiParent
        mask.Show()
        Dim result As DialogResult = frmContainer.ShowDialog(mask)
        frmContainer.Close()
        mask.Close()
        Return result
    End Function

    Public Shared Sub CloseDialog()
        If frmContainer IsNot Nothing Then
            frmContainer.Close()
        End If
    End Sub

    Private Sub FrmReconectandoMaskedDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Private Sub InitializeComponent()
    'Me.SuspendLayout()
    'Me.ClientSize = New System.Drawing.Size(284, 262)
    'Me.Name = "MaskedDialog"
    'AddHandler Me.Load, New System.EventHandler(AddressOf Me.MaskedDialog_Load)
    'Me.ResumeLayout(False)
    'End Sub

End Class
