Imports Microsoft.Extensions.DependencyInjection

Public Class MainPresenter

    ' Services
    Private ReadOnly serviceProvider As IServiceProvider

    Private ReadOnly _view As New MainView

    Private openedForm = False

    Private currentFeature As IFeature

    Public Sub New(serviceProvider As IServiceProvider)
        Me.serviceProvider = serviceProvider

        Me.AddEventHandlers()
    End Sub

    Private Sub AddEventHandlers()
        AddHandler Me._view.FormClosing, AddressOf FormClosing

        AddHandler Me._view.OpenForm, AddressOf Me.OpenForm
        AddHandler Me._view.ClickEditor, AddressOf Me.OpenEditor
        AddHandler Me._view.ClickReporting, AddressOf Me.OpenReporting
    End Sub

#Region "Properties"
    Public ReadOnly Property View() As MainView
        Get
            Return _view
        End Get
    End Property
#End Region

#Region "Event Handlers"
    Private Sub FormClosing(sender As Object, e As FormClosingEventArgs)
        Me.currentFeature?.View.Dispose()
    End Sub

    Private Sub OpenForm()
        If Me.openedForm Then Return

        ' Choose Form
        Dim selector = Me.serviceProvider.GetService(Of LoadFormPresenter)
        Dim res = selector.ShowDialog(Me.View)
        If res <> DialogResult.Yes Then Return

        Dim model = selector.FormModel

        ' Open Form
        Dim working = Me.serviceProvider.GetService(Of FormWorkingPresenter)
        AddHandler working.View.FormClosing, Sub() Me.openedForm = False
        Me.openedForm = True
        working.Show(model, Me.View)
    End Sub

    Private Sub OpenEditor()
        Me.OpenFeature(GetType(EditorPresenter))
    End Sub

    Private Sub OpenReporting()
        Me.OpenFeature(GetType(ReportingPresenter))
    End Sub
#End Region

#Region "Utility Methods"
    Private Sub OpenFeature(type As Type)
        Dim feature As IFeature = Me.serviceProvider.GetService(type)

        feature.View.Dock = DockStyle.Fill
        Me._view.PanelFeature.Controls.Add(feature.View)

        If Me.currentFeature IsNot Nothing Then
            Me._view.PanelFeature.Controls.Remove(Me.currentFeature.View)
            Me.currentFeature.View.Dispose()
        End If

        Me.currentFeature = feature
    End Sub
#End Region
End Class
