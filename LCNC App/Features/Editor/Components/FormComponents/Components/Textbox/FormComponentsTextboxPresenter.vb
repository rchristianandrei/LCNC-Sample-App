Public Class FormComponentsTextboxPresenter
    Implements ISpecialized

    Private ReadOnly _view As New FormComponentsTextboxView

    Private control As FormTextbox
    Private model As FormTextboxModel

    Public Sub New()
        Me.PrepareEventHandlers()
    End Sub

    Private Sub PrepareEventHandlers()
        AddHandler Me._view.MultiLineClicked, AddressOf Me.MultiLineClicked
    End Sub

#Region "Properties"
    Public ReadOnly Property View As UserControl Implements ISpecialized.View
        Get
            Return Me._view
        End Get
    End Property
#End Region

#Region "Public Methods"
    Public Sub Show(control As FormControlComponent, model As FormComponentModel) Implements ISpecialized.Show
        Me.view.Visible = True
        Me.control = control
        Me.model = model
    End Sub

    Public Sub Hide() Implements ISpecialized.Hide
        Me.View.Visible = False
        Me.control = Nothing
        Me.model = Nothing
    End Sub
#End Region

#Region "Event Handlers"
    Private Sub MultiLineClicked()
        Me.control.Textbox.Multiline = Me._view.MultiLine
        Me.model.Multiline = Me.control.Textbox.Multiline
    End Sub
#End Region
End Class
