Public MustInherit Class FormPresenter

    ' Services
    Protected ReadOnly factory As IFormControlFactory

    ' Mapping
    Protected ReadOnly ctrlToModel As New Dictionary(Of FormControlComponent, FormComponentModel)

    ' Variables
    Protected formModel As FormModel
    Protected ReadOnly stopWatch As New Stopwatch

    Protected isActive = False


    Public Sub New(factory As IFormControlFactory)
        Me.factory = factory

        Me.PrepareEventHandlers
    End Sub

    Private Sub PrepareEventHandlers()
        AddHandler Me.View.StartButton.Click, AddressOf Me.StartClick
        AddHandler Me.View.Timer1s.Tick, AddressOf Me.Tick1s
        AddHandler Me.View.SubmitButton.Click, AddressOf Me.SubmitClick
    End Sub

#Region "Properties"
    Public ReadOnly Property View As New FormView With {
        .FormBorderStyle = FormBorderStyle.FixedSingle,
        .MaximizeBox = False
    }
#End Region

#Region "Public Methods"
    Public Overridable Sub Show(formModel As FormModel, owner As Form)
        Me.formModel = formModel

        Me.View.Text = formModel.FormText
        Me.View.Size = New Size(formModel.FormWidth, formModel.FormHeight)
        Me.View.SubmitButton.Text = formModel.SubmitText

        For Each model In formModel.Components
            Dim ctrl = Me.factory.CreateFromModel(model)
            Me.ctrlToModel.Add(ctrl, model)
            Me.View.ComponentsPanel.Controls.Add(ctrl)
        Next

        Me.View.Show(owner)

        Me.InActiveState()
    End Sub
#End Region

#Region "Event Handlers"
    Private Sub StartClick(sender As Object, e As EventArgs)
        Me.ActiveState()
    End Sub

    Private Sub Tick1s(sender As Object, e As EventArgs)
        If Me.isActive Then
            Me.View.StartButton.Text = Me.stopWatch.Elapsed.ToString("hh\:mm\:ss")
        End If
    End Sub

    Protected Overridable Sub SubmitClick(sender As Object, e As EventArgs)
        Me.InActiveState()
    End Sub
#End Region

#Region "Utility Methods"
    Protected Overridable Sub InActiveState()
        Me.isActive = False

        Me.View.StartButton.Text = "Start"
        Me.View.StartButton.Enabled = True
        Me.View.ComponentsPanel.Enabled = False
        Me.View.SubmitButton.Enabled = False

        For Each ctrl In Me.ctrlToModel.Keys
            ctrl.TextValue = String.Empty
        Next

        Me.View.Timer1s.Stop()
        Me.stopWatch.Stop()
        Me.stopWatch.Reset()
    End Sub

    Protected Overridable Sub ActiveState()
        Me.isActive = True

        Me.View.StartButton.Text = "00:00:00"
        Me.View.StartButton.Enabled = False
        Me.View.ComponentsPanel.Enabled = True
        Me.View.SubmitButton.Enabled = True

        Me.View.Timer1s.Start()
        Me.stopWatch.Start()
    End Sub
#End Region
End Class
