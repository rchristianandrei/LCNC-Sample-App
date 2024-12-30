Public Class MainPresenter
    Private ReadOnly _view As New MainView

    Private currentFeature As IFeature

    Public Sub New()
        AddEventHandlers()
    End Sub

#Region "Properties"
    Public ReadOnly Property View() As MainView
        Get
            Return _view
        End Get
    End Property
#End Region

#Region "Private Methods"
    Private Sub AddEventHandlers()
        AddHandler Me._view.FormClosing, AddressOf FormClosing

        AddHandler Me._view.ClickOpen, AddressOf Me.OpenForm
        AddHandler Me._view.ClickEditor, AddressOf Me.OpenEditor
    End Sub
#End Region

#Region "Event Handlers"
    Private Sub FormClosing(sender As Object, e As FormClosingEventArgs)
        Me.currentFeature?.View.Dispose()
    End Sub

    Private Sub OpenForm()
        Dim feature As New FormControlView
        'Dim feature As New EditorPresenter
        'feature.View.Dock = DockStyle.Fill
        'Me._view.PanelFeature.Controls.Add(feature.View)
        'Me._view.PanelFeature.Controls.Add(feature)

        'If Me.currentFeature IsNot Nothing Then
        '    Me._view.PanelFeature.Controls.Remove(Me.currentFeature.View)
        '    Me.currentFeature.View.Dispose()
        'End If

        'Me.currentFeature = feature
    End Sub

    Private Sub OpenEditor()
        Dim feature As New EditorPresenter
        feature.View.Dock = DockStyle.Fill
        Me._view.PanelFeature.Controls.Add(feature.View)

        If Me.currentFeature IsNot Nothing Then
            Me._view.PanelFeature.Controls.Remove(Me.currentFeature.View)
            Me.currentFeature.View.Dispose()
        End If

        Me.currentFeature = feature
    End Sub
#End Region
End Class
