Imports Microsoft.Extensions.DependencyInjection

Public Class EditorPresenter
    Implements IFeature

    Private ReadOnly _view As New EditorView
    Private ReadOnly preview As New FormView

    Private ReadOnly formSettings As New FormSettingsPresenter(Me.preview)
    Private formComponents As FormComponentsPresenter

    ' Required Services
    Private ReadOnly serviceProvider As IServiceProvider
    Private ReadOnly formsRepo As IFormsRepo

    ' Placeholders
    Private previewOpened = False

    Private ReadOnly formModel As New FormModel With {
        .FormText = Me.preview.Text,
        .FormWidth = Me.preview.Width,
        .FormHeight = Me.preview.Height,
        .SubmitText = Me.preview.SubmitButton.Text
    }
    Private selectedInspector As IInspector = Me.formSettings

    Public Sub New(serviceProvider As IServiceProvider, formsRepo As IFormsRepo)
        Me.serviceProvider = serviceProvider
        Me.formsRepo = formsRepo

        Me.PrepareFeature()
        Me.PrepareEventHandlers()
    End Sub

    Private Sub PrepareFeature()
        ' Prepare Settings View
        Me.formSettings.View.Dock = DockStyle.Fill
        Me.formSettings.Model = Me.formModel
        Me._view.PanelRight.Controls.Add(Me.formSettings.View)

        ' Prepare Components View
        Me.formComponents = New FormComponentsPresenter(Me.preview, Me.serviceProvider)
        Me.formComponents.View.Visible = False
        Me.formComponents.View.Dock = DockStyle.Fill
        Me._view.PanelRight.Controls.Add(Me.formComponents.View)

        ' Prepare Preview
        Me.preview.ControlBox = False
        Me.preview.TopLevel = False
        Dim x = (Me._view.PanelPreview.Width - Me.preview.Width) / 2
        Dim y = (Me._view.PanelPreview.Height - Me.preview.Height) / 2
        Me.preview.Location = New Point(x, y)
        Me._view.PanelPreview.Controls.Add(Me.preview)
        Me.preview.Show()
    End Sub

    Private Sub PrepareEventHandlers()
        AddHandler Me.formSettings.ShowFormInspector, AddressOf Me.ShowFormInspector
        AddHandler Me.formComponents.ShowCompInspector, AddressOf Me.ShowCompInspector

        AddHandler Me._view.Preview, AddressOf Me.OpenPreview
        AddHandler Me._view.Save, AddressOf Me.SaveForm

        AddHandler Me._view.AddTextbox, Sub() Me.formComponents.AddComponent(FormComponentType.Textbox)
        AddHandler Me._view.AddDropdownbox, Sub() Me.formComponents.AddComponent(FormComponentType.Dropdownbox)
    End Sub

#Region "Properties"
    Public ReadOnly Property View As UserControl Implements IFeature.View
        Get
            Return _view
        End Get
    End Property
#End Region

#Region "Presenter Event Handlers"
    Private Sub ShowFormInspector()
        If Me.selectedInspector Is Me.formSettings Then Return

        Me.selectedInspector.Show(False)
        Me.formSettings.Show(True)

        Me.selectedInspector = Me.formSettings
    End Sub

    Private Sub ShowCompInspector()
        If Me.selectedInspector Is Me.formComponents Then Return

        Me.selectedInspector.Show(False)
        Me.formComponents.Show(True)

        Me.selectedInspector = Me.formComponents
    End Sub
#End Region

#Region "View Event Handlers"
    Private Sub OpenPreview()
        If Me.previewOpened Then Return

        Dim preview = Me.serviceProvider.GetService(Of FormPreviewPresenter)()
        Me.previewOpened = True
        AddHandler preview.View.FormClosing, Sub() Me.previewOpened = False
        Me.formModel.Components = Me.formComponents.ComponentModels
        preview.Show(Me.formModel, Me.View.ParentForm)
    End Sub

    Private Async Sub SaveForm()
        Me.formModel.Components = Me.formComponents.ComponentModels

        Try
            Await Me.formsRepo.Save(Me.formModel)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
