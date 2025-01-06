Public Class ReportingView

#Region "Properties"
    Public Property FormName() As String
        Get
            Return Me.lblFormName.Text
        End Get
        Set(ByVal value As String)
            Me.lblFormName.Text = value
        End Set
    End Property
#End Region

#Region "Events"
    Public Event ChooseForm()
    Public Event OpenExportRawReport()
#End Region

#Region "Event Handlers"
    Private Sub smiChooseForm_Click(sender As Object, e As EventArgs) Handles smiChooseForm.Click
        RaiseEvent ChooseForm()
    End Sub

    Private Sub smiExportRawReport_Click(sender As Object, e As EventArgs) Handles smiExportRawReport.Click
        RaiseEvent OpenExportRawReport()
    End Sub
#End Region
End Class
