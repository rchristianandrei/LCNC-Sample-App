Public Class FormComponentsPresenter

    Private ReadOnly OrigColor = Color.FromArgb(240, 240, 240)

    Private ReadOnly preview As FormView

    Private selectedControl As FormTextbox

    Public Sub New(preview As FormView)
        Me.preview = preview

        Me.PrepareEventHandlers
    End Sub

    Private Sub PrepareEventHandlers()
        AddHandler Me.View.CompLabelChanged, AddressOf Me.CompLabelChanged
        AddHandler Me.View.CompLocationChanged, AddressOf Me.CompLocationChanged
    End Sub
#Region "Properties"
    Public ReadOnly Property View As New FormComponentsView
#End Region

#Region "Public Methods"
    Public Sub AddTextbox()
        Dim control As New FormTextbox
        control.Textbox.Enabled = False
        AddHandler control.Click, AddressOf ClickComponent
        Me.preview.ComponentsPanel.Controls.Add(control)
    End Sub
#End Region

#Region "Events"
    Public Event ShowCompInspector()
#End Region

#Region "Event Handlers"
    Private Sub CompLabelChanged()
        Me.selectedControl.Label.Text = Me.View.Label
    End Sub

    Private Sub CompLocationChanged()
        Dim x As Integer
        Dim y As Integer
        Dim valid = True

        ' Validate X
        If Not Integer.TryParse(Me.View.LocationX, x) Then
            Me.View.LocationX = Me.selectedControl.Location.X
            valid = False
        End If

        ' Validate Y
        If Not Integer.TryParse(Me.View.LocationY, y) Then
            Me.View.LocationY = Me.selectedControl.Location.Y
            valid = False
        End If

        If Not valid Then
            MsgBox("Invalid Location")
            Return
        End If

        Me.selectedControl.Location = New Point(x, y)
    End Sub
#End Region

#Region "Private Methods"
    Private Sub ClickComponent(sender As Object, e As EventArgs)
        Dim control As FormTextbox = sender

        control.BackColor = Color.Black

        If Me.selectedControl IsNot Nothing Then
            Me.selectedControl.BackColor = Me.OrigColor
        End If

        Me.selectedControl = control

        ' Show Values
        Me.View.Label = control.Label.Text

        Me.View.LocationX = control.Location.X
        Me.View.LocationY = control.Location.Y

        RaiseEvent ShowCompInspector()
    End Sub
#End Region
End Class
