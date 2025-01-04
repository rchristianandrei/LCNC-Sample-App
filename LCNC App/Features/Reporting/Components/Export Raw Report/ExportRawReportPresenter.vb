Public Class ExportRawReportPresenter

    Private ReadOnly view As New ExportRawReportView

#Region "Public Methods"
    Public Function ShowDialog(owner As Form) As DialogResult
        Me.View.ShowDialog(owner)

        Return DialogResult.Cancel
    End Function
#End Region
End Class
