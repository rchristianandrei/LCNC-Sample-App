Imports Guna.UI2.WinForms

Public Class MainView

#Region "Properties"
    Public ReadOnly Property PanelFeature() As Guna2Panel
        Get
            Return Me.pnlFeature
        End Get
    End Property
#End Region

#Region "Events"
    Public Event ClickOpen()
    Public Event ClickEditor()
#End Region

#Region "Event Handlers"
    Private Sub smiOpen_Click(sender As Object, e As EventArgs) Handles smiOpen.Click
        RaiseEvent ClickOpen()
    End Sub

    Private Sub smiEditor_Click(sender As Object, e As EventArgs) Handles smiEditor.Click
        RaiseEvent ClickEditor()
    End Sub
#End Region
End Class
