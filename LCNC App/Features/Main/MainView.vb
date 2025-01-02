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
    Public Event OpenForm()
    Public Event ClickEditor()
#End Region

#Region "Event Handlers"
    Private Sub smiForm_Click(sender As Object, e As EventArgs) Handles smiForm.Click
        RaiseEvent OpenForm()
    End Sub

    Private Sub smiEditor_Click(sender As Object, e As EventArgs) Handles smiEditor.Click
        RaiseEvent ClickEditor()
    End Sub
#End Region
End Class
