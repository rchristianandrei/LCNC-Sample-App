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

    Public Property SizeWidth() As String
        Get
            Return Me.txtWidth.Text
        End Get
        Set(ByVal value As String)
            Me.txtWidth.Text = value
        End Set
    End Property

    Public Property SizeHeight() As String
        Get
            Return Me.txtHeight.Text
        End Get
        Set(ByVal value As String)
            Me.txtHeight.Text = value
        End Set
    End Property

    Public Property HeightEnabled() As Boolean
        Get
            Return Me.txtHeight.Enabled
        End Get
        Set(ByVal value As Boolean)
            Me.txtHeight.Enabled = value
        End Set
    End Property
#End Region

#Region "Events"
    Public Event CompLabelChanged()
    Public Event CompLocationChanged()
    Public Event CompBringToFront()
    Public Event CompSizeChanged()
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
        If FindForm() Is Nothing Then Return

        RaiseEvent CompLocationChanged()
    End Sub

    Private Sub btnBringToFront_Click(sender As Object, e As EventArgs) Handles btnBringToFront.Click
        RaiseEvent CompBringToFront()
    End Sub

    Private Sub CompSize_KeyDown(sender As Object, e As KeyEventArgs) Handles txtWidth.KeyDown, txtHeight.KeyDown
        If e.KeyValue = Keys.Enter Then
            RaiseEvent CompSizeChanged()
        End If
    End Sub

    Private Sub CompSize_Leave(sender As Object, e As EventArgs) Handles txtWidth.Leave, txtHeight.Leave
        If Me.FindForm() Is Nothing Then Return

        RaiseEvent CompSizeChanged()
    End Sub
#End Region
End Class
