Imports Guna.UI2.WinForms

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

    Public ReadOnly Property RefreshTimer() As Timer
        Get
            Return Me.Timer1
        End Get
    End Property

    Public ReadOnly Property RefreshTimerVisual() As Guna2CircleProgressBar
        Get
            Return Me.prgLoading
        End Get
    End Property

    Public ReadOnly Property KpiPanel() As FlowLayoutPanel
        Get
            Return Me.pnlKpis
        End Get
    End Property
#End Region

#Region "Events"
    Public Event ChooseForm()
    Public Event OpenExportRawReport()
    Public Event RefreshNow()
#End Region

#Region "Event Handlers"
    Private Sub smiChooseForm_Click(sender As Object, e As EventArgs) Handles smiChooseForm.Click
        RaiseEvent ChooseForm()
    End Sub

    Private Sub smiExportRawReport_Click(sender As Object, e As EventArgs) Handles smiExportRawReport.Click
        RaiseEvent OpenExportRawReport()
    End Sub

    Private Sub btnRefreshNow_Click(sender As Object, e As EventArgs) Handles btnRefreshNow.Click
        RaiseEvent RefreshNow()
    End Sub
#End Region
End Class
