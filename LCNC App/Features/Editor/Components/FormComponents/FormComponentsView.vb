Public Class FormComponentsView

#Region "Properties"
    Public Property Label() As String
        Get
            Return Me.txtLabel.Text
        End Get
        Set(ByVal value As String)
            Me.txtLabel.Text = value
        End Set
    End Property

    Public Property LocationX() As String
        Get
            Return Me.txtX.Text
        End Get
        Set(ByVal value As String)
            Me.txtX.Text = value
        End Set
    End Property

    Public Property LocationY() As String
        Get
            Return Me.txtY.Text
        End Get
        Set(ByVal value As String)
            Me.txtY.Text = value
        End Set
    End Property

    Public Property LocationZ() As String
        Get
            Return Me.txtZ.Text
        End Get
        Set(ByVal value As String)
            Me.txtZ.Text = value
        End Set
    End Property
#End Region

#Region "Events"
    Public Event CompLabelChanged()
    Public Event CompLocationChanged()
#End Region

#Region "Event Handlers"
    Private Sub txtLabel_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLabel.KeyDown
        If e.KeyValue = Keys.Enter Then
            RaiseEvent CompLabelChanged()
        End If
    End Sub

    Private Sub txtLabel_Leave(sender As Object, e As EventArgs) Handles txtLabel.Leave
        If Me.FindForm() Is Nothing Then Return

        RaiseEvent CompLabelChanged()
    End Sub

    Private Sub CompLocation_KeyDown(sender As Object, e As KeyEventArgs) Handles txtX.KeyDown, txtY.KeyDown
        If e.KeyValue = Keys.Enter Then
            RaiseEvent CompLocationChanged()
        End If
    End Sub

    Private Sub CompLocation_Leave(sender As Object, e As EventArgs) Handles txtX.Leave, txtY.Leave
        If Me.FindForm() Is Nothing Then Return

        RaiseEvent CompLocationChanged()
    End Sub
#End Region
End Class
