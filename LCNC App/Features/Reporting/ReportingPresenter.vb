Imports Microsoft.Extensions.DependencyInjection

Public Class ReportingPresenter
    Implements IFeature

    Private ReadOnly _view As New ReportingView

    ' Services
    Private ReadOnly serviceProvider As IServiceProvider

    ' Variabes
    Private formModel As FormModel

    Public Sub New(serviceProvider As IServiceProvider)
        Me.serviceProvider = serviceProvider

        Me.PrepareEventHandlers()
    End Sub

    Private Sub PrepareEventHandlers()
        AddHandler Me._view.ChooseForm, AddressOf Me.ChooseForm
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
#End Region
End Class
