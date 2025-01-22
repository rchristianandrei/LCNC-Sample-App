Public Class FormSettingsPresenter
    Implements IInspector

    Private preview As FormView

    Private model As FormModel

    Public Sub New(preview As FormView)
        Me.preview = preview

        Me.PrepareEventHandlers()
    End Sub

    Private Sub PrepareEventHandlers()
        AddHandler Me.View.FormTextChanged, AddressOf Me.FormTextChanged
        AddHandler Me.View.FormWidthChanged, AddressOf Me.FormWidthChanged
        AddHandler Me.View.FormHeightChanged, AddressOf Me.FormHeightChanged

        AddHandler Me.View.SubmitTextChanged, AddressOf Me.SubmitTextChanged
    End Sub

#Region "Properties"
    Public ReadOnly Property View As New FormSettingsView
#End Region

#Region "Events"
    Public Event ShowFormInspector()
#End Region

#Region "Public Methods"
    Public Sub Initialize(previewObservable As IObservable(Of FormView), formObservable As IObservable(Of FormModel))
        previewObservable.Subscribe(
            Sub(preview)
                Me.preview = preview
                PreparePreviewEventHandlers()
            End Sub)

        formObservable.Subscribe(AddressOf Me.SetModel)
    End Sub

    Public Sub Show(visible As Boolean) Implements IInspector.Show
        Me.View.Visible = visible
    End Sub
#End Region

#Region "Event Handlers"
    Private Sub PreviewSizeChanged(sender As Object, e As EventArgs)
        Me.Model.FormWidth = Me.preview.Width
        Me.Model.FormHeight = Me.preview.Height

        Me.View.FormWidth = Me.preview.Width
        Me.View.FormHeight = Me.preview.Height
    End Sub

    Private Sub FormTextChanged()
        Me.Model.FormText = Me.View.FormText

        Me.preview.Text = Me.View.FormText
    End Sub

    Private Sub FormWidthChanged()
        Dim width As Integer

        If Not Integer.TryParse(Me.View.FormWidth, width) Then
            MsgBox("Invalid Width")
            Me.View.FormWidth = Me.preview.Width
            Return
        End If

        Me.Model.FormWidth = Me.preview.Width
        Me.preview.Width = width
    End Sub

    Private Sub FormHeightChanged()
        Dim height As Integer

        If Not Integer.TryParse(Me.View.FormHeight, height) Then
            MsgBox("Invalid Height")
            Me.View.FormHeight = Me.preview.Height
            Return
        End If

        Me.Model.FormHeight = Me.preview.Height
        Me.preview.Height = height
    End Sub

    Private Sub SubmitTextChanged()
        Me.Model.SubmitText = Me.View.SubmitText

        Me.preview.SubmitButton.Text = Me.View.SubmitText
    End Sub
#End Region

#Region "Utilities"
    Private Sub PreparePreviewEventHandlers()
        AddHandler Me.preview.FormInteract, Sub() RaiseEvent ShowFormInspector()
        AddHandler Me.preview.SizeChanged, AddressOf Me.PreviewSizeChanged
    End Sub

    Private Sub SetModel(formModel As FormModel)
        Me.model = formModel

        Me.ShowSettings()
    End Sub

    Private Sub ShowSettings()
        Me.preview.Text = Me.model.FormText
        Me.preview.Width = Me.model.FormWidth
        Me.preview.Height = Me.model.FormHeight
        Me.preview.SubmitButton.Text = Me.model.SubmitText

        Me.View.FormText = Me.model.FormText
        Me.View.FormWidth = Me.model.FormWidth
        Me.View.FormHeight = Me.model.FormHeight
        Me.View.SubmitText = Me.model.SubmitText
    End Sub
#End Region
End Class
