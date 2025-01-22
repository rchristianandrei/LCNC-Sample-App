Imports Microsoft.Extensions.DependencyInjection

Public Class ReportingPresenter
    Implements IFeature

    Private ReadOnly _view As New ReportingView

    ' KPI Presenters
    Private ReadOnly kpiList As New List(Of IRealtimeReportKpi)

    ' Services
    Private ReadOnly serviceProvider As IServiceProvider

    ' Variabes
    Private formModel As FormModel

    Private Const refreshTimerMax = 30
    Private refreshTimer = 0

    Public Sub New(serviceProvider As IServiceProvider)
        Me.serviceProvider = serviceProvider

        Me._view.RefreshTimer.Start()

        Me.PrepareKPIPresenters

        Me.PrepareEventHandlers()
    End Sub

    Private Sub PrepareKPIPresenters()
        ' Submitted Count
        Dim count = serviceProvider.GetService(Of RealtimeReportSubmittedCountPresenter)
        kpiList.Add(count)
        _view.KpiPanel.Controls.Add(count.View)
    End Sub

    Private Sub PrepareEventHandlers()
        AddHandler Me._view.RefreshTimer.Tick, AddressOf Me.Tick1s
        AddHandler Me._view.ChooseForm, AddressOf Me.ChooseForm
        AddHandler Me._view.OpenExportRawReport, AddressOf Me.OpenExportRawReport
        AddHandler Me._view.RefreshNow, AddressOf Me.RefreshNow
    End Sub

#Region "Properties"
    Public ReadOnly Property View As UserControl Implements IFeature.View
        Get
            Return Me._view
        End Get
    End Property
#End Region

#Region "Event Handlers"
    Private Sub Tick1s(sender As Object, e As EventArgs)

        If formModel Is Nothing Then Return

        refreshTimer += 1

        If refreshTimer >= refreshTimerMax Then
            refreshTimer = 0
            Me.RefreshKPIs()
        End If

        Me._view.RefreshTimerVisual.Value = (refreshTimer / refreshTimerMax) * 100
    End Sub

    Private Sub ChooseForm()
        Dim selector = Me.serviceProvider.GetService(Of LoadFormPresenter)
        Dim res = selector.ShowDialog(Me._view.ParentForm)

        If res <> DialogResult.Yes Then Return

        Me.formModel = selector.FormModel
        Me._view.FormName = Me.formModel.FormText
    End Sub

    Private Sub OpenExportRawReport()
        If Me.formModel Is Nothing Then
            MsgBox("Please choose a form first")
            Return
        End If

        Dim export = Me.serviceProvider.GetService(Of ExportRawReportPresenter)
        export.ShowDialog(Me.formModel, Me._view.ParentForm)
    End Sub

    Private Sub RefreshNow()
        If formModel Is Nothing Then Return

        Me.RefreshKPIs()

        refreshTimer = 0
        Me._view.RefreshTimerVisual.Value = 0
    End Sub
#End Region

#Region "Private Methods"
    Private Async Sub RefreshKPIs()
        Try
            Dim tasks As New List(Of Task)

            For Each kpiPresenter In kpiList
                tasks.Add(kpiPresenter.Calculate(formModel))
            Next

            Await Task.WhenAll(tasks)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
