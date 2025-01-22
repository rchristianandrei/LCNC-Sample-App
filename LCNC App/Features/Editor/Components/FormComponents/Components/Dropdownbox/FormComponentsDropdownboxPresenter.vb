Public Class FormComponentsDropdownboxPresenter
    Implements ISpecialized

    Private ReadOnly _view As New FormComponentsDropdownboxView

    Private control As FormDropdownbox
    Private model As FormDropdownboxModel

    Public Sub New()
        Me.PrepareEventHandlers
    End Sub

    Private Sub PrepareEventHandlers()
        AddHandler Me._view.OpenItemsUploader, AddressOf Me.OpenItemsUploader
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

#Region "Event Handlers"
    Private Sub OpenItemsUploader()
        Dim uploder As New ItemsUploaderPresenter
        Dim result = uploder.ShowDialog(Me._view.ParentForm, Me.model.Items)

        If result <> DialogResult.Yes Then Return

        Me.model.Items = uploder.GetItems

        Me.control.Dropdownbox.Items.Clear()
        For Each item In Me.model.Items
            Me.control.Dropdownbox.Items.Add(item)
        Next
    End Sub
#End Region
End Class
