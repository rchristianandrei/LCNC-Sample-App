Imports Guna.UI2.WinForms

Public Class LoadFormView
#Region "Properties"
    Public ReadOnly Property FormColIndex As Integer
        Get
            Return Me.colForms.Index
        End Get
    End Property

    Public ReadOnly Property FormsGrid() As Guna2DataGridView
        Get
            Return Me.grdForms
        End Get
    End Property
#End Region

#Region "Events"
    Public Event Open()
    Public Event Cancel()
#End Region

#Region "Event Handlers"
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        RaiseEvent Open()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        RaiseEvent Cancel()
    End Sub
#End Region
End Class