<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReportViewer
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
        Dim PdfViewerPrinterSettings1 As Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings = New Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReportViewer))
        Dim TextSearchSettings1 As Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings = New Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings()
        Me.PdfViewerControl = New Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl()
        Me.SuspendLayout()
        '
        'PdfViewerControl
        '
        Me.PdfViewerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PdfViewerControl.EnableContextMenu = True
        Me.PdfViewerControl.EnableNotificationBar = True
        Me.PdfViewerControl.HorizontalScrollOffset = 0
        Me.PdfViewerControl.IsBookmarkEnabled = True
        Me.PdfViewerControl.Location = New System.Drawing.Point(0, 0)
        Me.PdfViewerControl.Name = "PdfViewerControl"
        Me.PdfViewerControl.PageBorderThickness = 1
        PdfViewerPrinterSettings1.PageOrientation = Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.[Auto]
        PdfViewerPrinterSettings1.PageSize = Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.ActualSize
        PdfViewerPrinterSettings1.PrintLocation = CType(resources.GetObject("PdfViewerPrinterSettings1.PrintLocation"), System.Drawing.PointF)
        Me.PdfViewerControl.PrinterSettings = PdfViewerPrinterSettings1
        Me.PdfViewerControl.ReferencePath = Nothing
        Me.PdfViewerControl.ScrollDisplacementValue = 0
        Me.PdfViewerControl.ShowHorizontalScrollBar = True
        Me.PdfViewerControl.ShowToolBar = True
        Me.PdfViewerControl.ShowVerticalScrollBar = True
        Me.PdfViewerControl.Size = New System.Drawing.Size(581, 324)
        Me.PdfViewerControl.SpaceBetweenPages = 8
        Me.PdfViewerControl.TabIndex = 0
        Me.PdfViewerControl.Text = "PdfViewerControl1"
        TextSearchSettings1.CurrentInstanceColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(64, Byte), Integer))
        TextSearchSettings1.HighlightAllInstance = True
        TextSearchSettings1.OtherInstanceColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PdfViewerControl.TextSearchSettings = TextSearchSettings1
        Me.PdfViewerControl.VerticalScrollOffset = 0
        Me.PdfViewerControl.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.[Default]
        Me.PdfViewerControl.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.[Default]
        '
        'FrmReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 324)
        Me.Controls.Add(Me.PdfViewerControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "FrmReportViewer"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Visualizar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PdfViewerControl As Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl
End Class
