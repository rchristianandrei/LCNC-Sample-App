﻿
Imports Microsoft.Extensions.DependencyInjection

Public Class FormComponentsPresenter
    Implements IInspector

    Private ReadOnly OrigColor = Color.FromArgb(240, 240, 240)

    Private preview As FormView

    ' Services
    Private ReadOnly factoryComp As IFormControlFactory
    Private ReadOnly factoryModel As IFormComponentModelFactory

    ' Presenter Components
    Private ReadOnly presenters As New Dictionary(Of Type, ISpecialized) From {
        {GetType(FormTextbox), New FormComponentsTextboxPresenter},
        {GetType(FormDropdownbox), New FormComponentsDropdownboxPresenter}
    }
    Private selectedSpecialized As ISpecialized

    Private formModel As FormModel
    Private ctrlToModel As New Dictionary(Of FormControlComponent, FormComponentModel)
    Private selectedControl As FormControlComponent

    Public Sub New(serviceProvider As IServiceProvider)
        Me.factoryComp = serviceProvider.GetService(Of IFormControlFactory)
        Me.factoryModel = serviceProvider.GetService(Of IFormComponentModelFactory)

        Me.PreparePresenters()
        Me.PrepareEventHandlers()
    End Sub

    Private Sub PreparePresenters()
        For Each special In Me.presenters.Values
            Me.View.SpecializedPanel.Controls.Add(special.View)
            special.Hide()
        Next
    End Sub

    Private Sub PrepareEventHandlers()
        AddHandler Me.View.CompLabelChanged, AddressOf Me.CompLabelChanged
        AddHandler Me.View.CompLocationChanged, AddressOf Me.CompLocationChanged
        AddHandler Me.View.CompBringToFront, AddressOf Me.CompBringToFront
        AddHandler Me.View.CompSizeChanged, AddressOf Me.CompSizeChanged
        AddHandler Me.View.DeleteComponent, AddressOf Me.DeleteComponent
    End Sub
#Region "Properties"
    Public ReadOnly Property View As New FormComponentsView

    Public ReadOnly Property ComponentModels() As List(Of FormComponentModel)
        Get
            Return Me.ctrlToModel.Values.ToList()
        End Get
    End Property
#End Region

#Region "Events"
    Public Event ShowCompInspector()
    Public Event HideCompInspector()
#End Region

#Region "Public Methods"
    Public Sub Initialize(previewObservable As IObservable(Of FormView), formObservable As IObservable(Of FormModel))

        previewObservable.Subscribe(
            Sub(preview)
                Me.preview = preview
            End Sub)

        formObservable.Subscribe(
            Sub(formModel)
                Me.SetComponents(formModel)
            End Sub)
    End Sub

    Public Sub AddComponent(type As FormComponentType)
        Dim model = Me.factoryModel.CreateComponent(type)
        Dim control = Me.factoryComp.CreateComponent(type)
        control.Active = False

        model.Label = control.Label
        model.Location = control.Location
        model.Size = control.Size

        AddHandler control.Click, AddressOf ClickComponent
        Me.preview.ComponentsPanel.Controls.Add(control)

        Me.formModel.Components.Add(model)
        Me.ctrlToModel.Add(control, model)
    End Sub

    Public Sub Show(visible As Boolean) Implements IInspector.Show
        Me.View.Visible = visible

        If visible Then Return
        If Me.selectedControl Is Nothing Then Return

        Me.selectedControl.BackColor = Me.OrigColor
        Me.SubscribeDragFeature(Me.selectedControl, False)
        Me.selectedControl = Nothing
    End Sub
#End Region

#Region "Event Handlers"
    Private Sub CompLabelChanged()
        Me.selectedControl.Label = Me.View.Label
        Me.ctrlToModel(Me.selectedControl).Label = Me.View.Label
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

        Me.selectedControl.Location = Me.LimitControlLocation(Me.selectedControl, x, y)
        Me.ctrlToModel(Me.selectedControl).Location = Me.selectedControl.Location

        Me.ShowControlLocation(Me.selectedControl.Location)
    End Sub

    Private Sub CompBringToFront()
        Me.preview.ComponentsPanel.Controls.SetChildIndex(Me.selectedControl, 0)

        ' Remove
        Dim model = Me.ctrlToModel(Me.selectedControl)
        Me.formModel.Components.Remove(model)

        ' Rearrange
        Me.formModel.Components.Insert(0, model)
    End Sub

    Private Sub CompSizeChanged()
        Dim width As Integer
        Dim height As Integer
        Dim valid = True

        ' Validate Width
        If Not Integer.TryParse(Me.View.SizeWidth, width) Then
            Me.View.SizeWidth = Me.selectedControl.Width
            valid = False
        End If

        ' Validate Height
        If Not Integer.TryParse(Me.View.SizeHeight, height) Then
            Me.View.SizeHeight = Me.selectedControl.Height
            valid = False
        End If

        If Not valid Then
            MsgBox("Invalid Size")
            Return
        End If

        Me.selectedControl.Size = New Size(width, height)
        Me.ctrlToModel(Me.selectedControl).Size = Me.selectedControl.Size
    End Sub

    Private Sub DeleteComponent()

        Dim res = MessageBox.Show("Are you sure you want to delete this component?", "Delete Component", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If res <> DialogResult.Yes Then Return

        Dim ctrl = Me.selectedControl

        Me.preview.ComponentsPanel.Controls.Remove(ctrl)
        Me.formModel.Components.Remove(Me.ctrlToModel(ctrl))
        Me.ctrlToModel.Remove(ctrl)

        ctrl.Dispose()

        Me.selectedControl = Nothing

        RaiseEvent HideCompInspector()
    End Sub
#End Region

#Region "Private Methods"
    Private Sub ClickComponent(sender As Object, e As EventArgs)
        Dim control As FormControlComponent = sender

        If control Is Me.selectedControl Then Return

        control.BackColor = Color.Black

        If Me.selectedControl IsNot Nothing Then
            Me.selectedControl.BackColor = Me.OrigColor
            Me.SubscribeDragFeature(Me.selectedControl, False)
        End If

        Me.selectedControl = control
        Me.SubscribeDragFeature(Me.selectedControl, True)

        ' Show Values
        Me.View.Label = control.Label

        Me.ShowControlLocation(control.Location)

        Me.View.SizeWidth = control.Width
        Me.View.SizeHeight = control.Height

        Me.View.HeightEnabled = control.CanSetHeight

        ' Specialization
        If Me.selectedSpecialized IsNot Nothing Then
            Me.selectedSpecialized.Hide()
        End If

        Dim type = control.GetType
        If Me.presenters.ContainsKey(type) Then
            Me.selectedSpecialized = Me.presenters(control.GetType)
            Me.selectedSpecialized.Show(control, Me.ctrlToModel(control))
        End If

        RaiseEvent ShowCompInspector()
    End Sub

    ' Variables to store the position and dragging state
    Private isDragging As Boolean = False
    Private startPoint As Point

    ''' <summary>
    ''' Subscribe / Unsubscribe drag feature delegates
    ''' </summary>
    ''' <param name="ctrl">The control in question.</param>
    ''' <param name="subscribe">Subscribe or unsubscribe.</param>
    Private Sub SubscribeDragFeature(ctrl As Control, subscribe As Boolean)
        If subscribe Then
            AddHandler ctrl.MouseDown, AddressOf Me.Component_MouseDown
            AddHandler ctrl.MouseMove, AddressOf Me.Component_MouseMove
            AddHandler ctrl.MouseUp, AddressOf Me.Component_MouseUp
        Else
            RemoveHandler ctrl.MouseDown, AddressOf Me.Component_MouseDown
            RemoveHandler ctrl.MouseMove, AddressOf Me.Component_MouseMove
            RemoveHandler ctrl.MouseUp, AddressOf Me.Component_MouseUp
        End If
    End Sub

    ' MouseDown event to start dragging
    Private Sub Component_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Me.isDragging = True
            Me.startPoint = e.Location
        End If
    End Sub

    ' MouseMove event to drag the control
    Private Sub Component_MouseMove(sender As Object, e As MouseEventArgs)
        If Me.isDragging Then
            Dim ctrl As Control = CType(sender, Control)

            Dim x As Integer = ctrl.Left + e.X - startPoint.X
            Dim y As Integer = ctrl.Top + e.Y - startPoint.Y

            ctrl.Location = Me.LimitControlLocation(ctrl, x, y)

            Me.ctrlToModel(ctrl).Location = ctrl.Location
            Me.ShowControlLocation(ctrl.Location)
        End If
    End Sub

    ' MouseUp event to stop dragging
    Private Sub Component_MouseUp(sender As Object, e As MouseEventArgs)
        Me.isDragging = False
    End Sub
#End Region

#Region "Utilities"
    Private Sub SetComponents(formModel As FormModel)
        Me.formModel = formModel
        Me.ctrlToModel.Clear()
        Me.preview.ComponentsPanel.Controls.Clear()

        If Me.formModel.Components Is Nothing Then
            Me.formModel.Components = New List(Of FormComponentModel)
        End If

        For Each model In Me.formModel.Components
            Dim control = Me.factoryComp.CreateFromModel(model)
            control.Active = False

            AddHandler control.Click, AddressOf ClickComponent

            Me.ctrlToModel.Add(control, model)
            Me.preview.ComponentsPanel.Controls.Add(control)
        Next
    End Sub

    ''' <summary>
    ''' Shows the Location X & Y of the control in View
    ''' </summary>
    ''' <param name="ctrl"></param>
    Private Sub ShowControlLocation(location As Point)
        Me.View.LocationX = location.X
        Me.View.LocationY = location.Y
    End Sub

    ''' <summary>
    ''' Limit the location of the control inside the form
    ''' </summary>
    ''' <param name="ctrl">The control in question.</param>
    ''' <param name="x">Target X Location.</param>
    ''' <param name="y">Target Y Location.</param>
    ''' <returns></returns>
    Private Function LimitControlLocation(ctrl As Control, x As Integer, y As Integer)
        If x < 0 Then
            x = 0
        ElseIf x > Me.preview.ComponentsPanel.Width - ctrl.Width Then
            x = Me.preview.ComponentsPanel.Width - ctrl.Width
        End If

        If y < 0 Then
            y = 0
        ElseIf y > Me.preview.ComponentsPanel.Height - ctrl.Height Then
            y = Me.preview.ComponentsPanel.Height - ctrl.Height
        End If

        Return New Point(x, y)
    End Function
#End Region
End Class
