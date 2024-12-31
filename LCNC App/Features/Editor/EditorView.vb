Imports Guna.UI2.WinForms

Public Class EditorView
#Region "Properties"
    Public ReadOnly Property PanelPreview() As Guna2Panel
        Get
            Return Me.pnlPreview
        End Get
    End Property

    Public ReadOnly Property PanelRight() As Guna2Panel
        Get
            Return Me.pnlRight
        End Get
    End Property
#End Region

#Region "Events"
    Public Event LoadForm()

    Public Event Preview()

    Public Event Save()

    Public Event AddTextbox()

    Public Event AddDropdownbox()
#End Region

#Region "EventHandlers"
    Private Sub smiLoad_Click(sender As Object, e As EventArgs) Handles smiLoad.Click
        RaiseEvent LoadForm()
    End Sub

    Private Sub smiPreview_Click(sender As Object, e As EventArgs) Handles smiPreview.Click
        RaiseEvent Preview()
    End Sub

    Private Sub smiSave_Click(sender As Object, e As EventArgs) Handles smiSave.Click
        RaiseEvent Save()
    End Sub

    Private Sub smiTextbox_Click(sender As Object, e As EventArgs) Handles smiTextbox.Click
        RaiseEvent AddTextbox()
    End Sub

    Private Sub smiDropdownbox_Click(sender As Object, e As EventArgs) Handles smiDropdownbox.Click
        RaiseEvent AddDropdownbox()
    End Sub
#End Region
End Class
