Imports Guna.UI2.WinForms

Public Class FormView
#Region "Properties"
    Public ReadOnly Property WidthOffset = 16
    Public ReadOnly Property HeightOffset = 36

    Public ReadOnly Property StartButton() As Guna2Button
        Get
            Return Me.btnStart
        End Get
    End Property

    Public ReadOnly Property SubmitButton() As Guna2Button
        Get
            Return Me.btnSubmit
        End Get
    End Property

    Public ReadOnly Property ComponentsPanel() As Guna2Panel
        Get
            Return Me.pnlComponents
        End Get
    End Property
#End Region

#Region "Events"
    Public Event FormInteract()
#End Region

#Region "Event Handlers"
    Private Sub FormInteract_Click(sender As Object, e As EventArgs) Handles pnlComponents.Click, btnSubmit.Click
        RaiseEvent FormInteract()
    End Sub
#End Region
End Class