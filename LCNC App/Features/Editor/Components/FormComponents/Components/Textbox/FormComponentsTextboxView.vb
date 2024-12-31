Public Class FormComponentsTextboxView

#Region "Properties"
    Public Property MultiLine() As Boolean
        Get
            Return Me.chkMultiline.Checked
        End Get
        Set(ByVal value As Boolean)
            Me.chkMultiline.Checked = value
        End Set
    End Property
#End Region

#Region "Events"
    Public Event MultiLineClicked()
#End Region

#Region "Event Handlers"
    Private Sub chkMultiline_Click(sender As Object, e As EventArgs) Handles chkMultiline.Click
        RaiseEvent MultiLineClicked()
    End Sub
#End Region
End Class
