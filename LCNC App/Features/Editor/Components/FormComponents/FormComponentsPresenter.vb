﻿Imports LCNC_App.FormComponentFactory

Public Class FormComponentsPresenter
    Implements IInspector

    Private ReadOnly OrigColor = Color.FromArgb(240, 240, 240)

    Private ReadOnly preview As FormView

    Private selectedControl As FormControlComponent

    Private ReadOnly factory As New FormComponentFactory

    Public Sub New(preview As FormView)
        Me.preview = preview

        Me.PrepareEventHandlers()
    End Sub

    Private Sub PrepareEventHandlers()
        AddHandler Me.View.CompLabelChanged, AddressOf Me.CompLabelChanged
        AddHandler Me.View.CompLocationChanged, AddressOf Me.CompLocationChanged
        AddHandler Me.View.CompSizeChanged, AddressOf Me.CompSizeChanged
    End Sub
#Region "Properties"
    Public ReadOnly Property View As New FormComponentsView
#End Region

#Region "Events"
    Public Event ShowCompInspector()
#End Region

#Region "Public Methods"
    Public Sub AddComponent(type As FormComponentType)
        Dim control = Me.factory.CreateComponent(type)
        control.Active = False
        AddHandler control.Click, AddressOf ClickComponent
        Me.preview.ComponentsPanel.Controls.Add(control)
    End Sub

    Public Sub Show(visible As Boolean) Implements IInspector.Show
        Me.View.Visible = visible

        If visible Then Return
        If Me.selectedControl Is Nothing Then Return

        Me.selectedControl.BackColor = Me.OrigColor
        Me.selectedControl = Nothing
    End Sub
#End Region

#Region "Event Handlers"
    Private Sub CompLabelChanged()
        Me.selectedControl.Label = Me.View.Label
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
    End Sub
#End Region

#Region "Private Methods"
    Private Sub ClickComponent(sender As Object, e As EventArgs)
        Dim control As FormControlComponent = sender

        If control Is Me.selectedControl Then Return

        control.BackColor = Color.Black

        If Me.selectedControl IsNot Nothing Then
            Me.selectedControl.BackColor = Me.OrigColor
        End If

        Me.selectedControl = control

        ' Show Values
        Me.View.Label = control.Label

        Me.View.LocationX = control.Location.X
        Me.View.LocationY = control.Location.Y

        Me.View.SizeWidth = control.Width
        Me.View.SizeHeight = control.Height

        Me.View.HeightEnabled = control.CanSetHeight

        RaiseEvent ShowCompInspector()
    End Sub
#End Region
End Class
