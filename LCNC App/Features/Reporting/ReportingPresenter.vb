Imports Microsoft.Extensions.DependencyInjection

Public Class ReportingPresenter
    Implements IFeature

    Private ReadOnly _view As New ReportingView

    ' Services
    Private ReadOnly serviceProvider As IServiceProvider

    Public Sub New(serviceProvider As IServiceProvider)
        Me.serviceProvider = serviceProvider

        Me.PrepareEventHandlers()
    End Sub

    Private Sub PrepareEventHandlers()
        AddHandler Me._view.OpenExportRawReport, AddressOf Me.OpenExportRawReport
    End Sub

#Region "Properties"
    Public ReadOnly Property View As UserControl Implements IFeature.View
        Get
            Return Me._view
        End Get
    End Property
#End Region

#Region "Event Handlers"
    Private Sub OpenExportRawReport()
        Dim export = Me.serviceProvider.GetService(Of ExportRawReportPresenter)
        export.ShowDialog(Me._view.ParentForm)
    End Sub
#End Region
End Class
