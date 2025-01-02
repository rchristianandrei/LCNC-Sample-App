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

    Public Event StartForm()
    Public Event SubmitForm()
#End Region

#Region "Event Handlers"
    Private Sub FormInteract_Click(sender As Object, e As EventArgs) Handles pnlComponents.Click, btnSubmit.Click, btnStart.Click, Me.Click
        RaiseEvent FormInteract()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        RaiseEvent StartForm()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        RaiseEvent SubmitForm()
    End Sub
#End Region
End Class