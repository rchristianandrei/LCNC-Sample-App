
Imports Microsoft.Extensions.DependencyInjection

Public Class FormComponentsPresenter
    Implements IInspector

    Private ReadOnly OrigColor = Color.FromArgb(240, 240, 240)

    Private ReadOnly preview As FormView

    Private ReadOnly factoryComp As IFormControlFactory
    Private ReadOnly factoryModel As IFormComponentModelFactory

    Private ReadOnly presenters As New Dictionary(Of Type, ISpecialized) From {
        {GetType(FormTextbox), New FormComponentsTextboxPresenter},
        {GetType(FormDropdownbox), New FormComponentsDropdownboxPresenter}
    }
    Private selectedSpecialized As ISpecialized

    Private ctrlToModel As New Dictionary(Of FormControlComponent, FormComponentModel)
    Private selectedControl As FormControlComponent

    Public Sub New(preview As FormView, serviceProvider As IServiceProvider)
        Me.preview = preview

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
#End Region

#Region "Public Methods"
    Public Sub AddComponent(type As FormComponentType)
        Dim model = Me.factoryModel.CreateComponent(type)
        Dim control = Me.factoryComp.CreateComponent(type)
        control.Active = False

        model.Label = control.Label
        model.Location = control.Location
        model.Size = control.Size

        AddHandler control.Click, AddressOf ClickComponent
        Me.preview.ComponentsPanel.Controls.Add(control)

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

    Public Sub SetComponents(list As IEnumerable(Of FormComponentModel))
        Me.ctrlToModel.Clear()
        Me.preview.ComponentsPanel.Controls.Clear()

        For Each model In list
            Dim control = Me.factoryComp.CreateFromModel(model)
            control.Active = False

            AddHandler control.Click, AddressOf ClickComponent

            Me.ctrlToModel.Add(control, model)
            Me.preview.ComponentsPanel.Controls.Add(control)
        Next
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

        ' Rearrange
        Dim temp As New Dictionary(Of FormControlComponent, FormComponentModel)
        For Each ctrl As FormControlComponent In Me.preview.ComponentsPanel.Controls
            temp.Add(ctrl, Me.ctrlToModel(ctrl))
        Next
        Me.ctrlToModel = temp
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
