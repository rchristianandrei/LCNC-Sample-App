Imports Guna.UI2.WinForms

Public Class ItemsUploaderView

#Region "Properties"
    Public ReadOnly Property ItemsGrid() As Guna2DataGridView
        Get
            Return Me.grdItems
        End Get
    End Property
#End Region

#Region "Events"
    Public Event SaveItems()
    Public Event DeleteItem()
#End Region

#Region "Event Handlers"
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        RaiseEvent SaveItems()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        RaiseEvent DeleteItem()
    End Sub
#End Region
End Class