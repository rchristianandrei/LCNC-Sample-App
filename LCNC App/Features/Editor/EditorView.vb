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
    Public Event Save()

    Public Event AddTextbox()
#End Region

#Region "EventHandlers"
    Private Sub smiSave_Click(sender As Object, e As EventArgs) Handles smiSave.Click
        RaiseEvent Save()
    End Sub

    Private Sub TextboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextboxToolStripMenuItem.Click
        RaiseEvent AddTextbox()
    End Sub
#End Region
End Class
