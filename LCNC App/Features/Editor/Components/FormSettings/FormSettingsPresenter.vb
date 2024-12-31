Public Class FormSettingsPresenter
    Implements IInspector

    Private ReadOnly preview As FormView

    Public Sub New(preview As FormView)
        Me.preview = preview

        Me.ShowSettings()
        Me.PrepareEventHandlers()
    End Sub

    Private Sub ShowSettings()
        Me.View.FormText = Me.preview.Text
        Me.View.FormWidth = Me.preview.Width
        Me.View.FormHeight = Me.preview.Height

        Me.View.SubmitText = Me.preview.SubmitButton.Text
    End Sub

    Private Sub PrepareEventHandlers()
        AddHandler Me.preview.FormInteract, Sub() RaiseEvent ShowFormInspector()
        AddHandler Me.preview.SizeChanged, AddressOf Me.PreviewSizeChanged

        AddHandler Me.View.FormTextChanged, AddressOf Me.FormTextChanged
        AddHandler Me.View.FormWidthChanged, AddressOf Me.FormWidthChanged
        AddHandler Me.View.FormHeightChanged, AddressOf Me.FormHeightChanged

        AddHandler Me.View.SubmitTextChanged, AddressOf Me.SubmitTextChanged
    End Sub

#Region "Properties"
    Public ReadOnly Property View As New FormSettingsView

    Public Property Model As FormModel
#End Region

#Region "Events"
    Public Event ShowFormInspector()
#End Region

#Region "Public Methods"
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
End Class
