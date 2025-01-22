Public Class FormComponentsDropdownboxView
#Region "Events"
    Public Event OpenItemsUploader()
#End Region

#Region "Event Handlers"
    Private Sub btnBringToFront_Click(sender As Object, e As EventArgs) Handles btnBringToFront.Click
        RaiseEvent OpenItemsUploader()
    End Sub
#End Region
End Class
