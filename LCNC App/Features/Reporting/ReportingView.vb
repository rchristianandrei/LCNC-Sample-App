Public Class ReportingView
#Region "Events"
    Public Event OpenExportRawReport()
#End Region

#Region "Event Handlers"
    Private Sub smiExportRawReport_Click(sender As Object, e As EventArgs) Handles smiExportRawReport.Click
        RaiseEvent OpenExportRawReport()
    End Sub
#End Region
End Class
