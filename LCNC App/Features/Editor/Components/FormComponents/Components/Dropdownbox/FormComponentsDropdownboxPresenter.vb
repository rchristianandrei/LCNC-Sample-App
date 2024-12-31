Public Class FormComponentsDropdownboxPresenter
    Implements ISpecialized

    Private ReadOnly _view As New FormComponentsDropdownboxView

    Private control As FormDropdownbox
    Private model As FormDropdownboxModel

#Region "Properties"
    Public ReadOnly Property View As UserControl Implements ISpecialized.View
        Get
            Return Me._view
        End Get
    End Property
#End Region

#Region "Public Methods"
    Public Sub Show(control As FormControlComponent, model As FormComponentModel) Implements ISpecialized.Show
        Me.View.Visible = True
        Me.control = control
        Me.model = model
    End Sub

    Public Sub Hide() Implements ISpecialized.Hide
        Me.View.Visible = False
        Me.control = Nothing
        Me.model = Nothing
    End Sub
#End Region
End Class
