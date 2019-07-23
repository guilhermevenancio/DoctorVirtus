Public Class FrmReportViewer

    Private Sub FrmReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Frm As New HandleDynamic.Forms
        Frm.AddHandler_Dynamic(Me)

        MaximizeBox = False

        PdfViewerControl.Select()

    End Sub

End Class