Public Class FormWorkingPresenter
    Inherits FormPresenter

    Public Sub New(factory As IFormControlFactory)
        MyBase.New(factory)

        Me.PrepareEventHandlers
    End Sub

    Private Sub PrepareEventHandlers()
        AddHandler MyBase.View.StartForm, AddressOf Me.StartForm
        AddHandler MyBase.View.SubmitForm, AddressOf Me.SubmitForm
    End Sub

#Region "Public Methods"
    Public Overrides Sub Show(formModel As FormModel, owner As Form)
        MyBase.Show(formModel, owner)

        Me.InActiveState()
    End Sub
#End Region

#Region "Event Handlers"
    Private Sub StartForm()
        Me.ActiveState()
    End Sub

    Private Sub SubmitForm()
        Me.InActiveState()
    End Sub
#End Region

#Region "Utility Methods"
    Private Sub InActiveState()
        MyBase.View.StartButton.Enabled = True
        MyBase.View.ComponentsPanel.Enabled = False
        MyBase.View.SubmitButton.Enabled = False
    End Sub

    Private Sub ActiveState()
        MyBase.View.StartButton.Enabled = False
        MyBase.View.ComponentsPanel.Enabled = True
        MyBase.View.SubmitButton.Enabled = True
    End Sub
#End Region
End Class
