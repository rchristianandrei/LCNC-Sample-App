Public Class EditorPresenter
    Implements IFeature

    Private ReadOnly _view As New EditorView
    Private ReadOnly preview As New FormView

    Private ReadOnly formSettings As New FormSettingsPresenter(Me.preview)

    Private formModel As New FormModel

    Public Sub New()
        Me.PrepareFeature()
        Me.PrepareEventHandlers()
    End Sub

#Region "Properties"
    Public ReadOnly Property View As UserControl Implements IFeature.View
        Get
            Return _view
        End Get
    End Property
#End Region

#Region "Private Methods"
    Private Sub PrepareFeature()
        Me.formSettings.View.Dock = DockStyle.Fill
        Me._view.PanelRight.Controls.Add(Me.formSettings.View)

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
        AddHandler Me._view.Save, AddressOf Me.SaveForm
    End Sub
#End Region

#Region "Event Handlers"
    Private Sub SaveForm()
        Throw New NotImplementedException()
    End Sub
#End Region
End Class
