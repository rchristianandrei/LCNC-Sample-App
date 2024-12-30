Public Class EditorPresenter
    Implements IFeature

    Private ReadOnly _view As New EditorView
    Private ReadOnly preview As New FormView

    Private ReadOnly formSettings As New FormSettingsPresenter(Me.preview)
    Private ReadOnly formComponents As New FormComponentsPresenter(Me.preview)

    ' Services
    Private ReadOnly formsRepo As IFormsRepo = New FormsRepo

    Private formModel As New FormModel

    Private selectedInspector As IInspector = Me.formSettings

    Public Sub New()
        Me.PrepareFeature()
        Me.PrepareEventHandlers()
    End Sub

    Private Sub PrepareFeature()
        ' Prepare Settings View
        Me.formSettings.View.Dock = DockStyle.Fill
        Me._view.PanelRight.Controls.Add(Me.formSettings.View)

        ' Prepare Components View
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

        AddHandler Me._view.Save, AddressOf Me.SaveForm

        AddHandler Me._view.AddTextbox, AddressOf Me.formComponents.AddTextbox
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
    Private Async Sub SaveForm()
        Me.formModel.FormText = Me.formSettings.FormText
        Me.formModel.FormWidth = Me.formSettings.FormWidth
        Me.formModel.FormHeight = Me.formSettings.FormHeight
        Me.formModel.SubmitText = Me.formSettings.SubmitText

        Try
            Await Me.formsRepo.Save(Me.formModel)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
End Class
