Public Class FormSettingsView
#Region "Properties"
    Public Property FormText() As String
        Get
            Return Me.txtTitle.Text
        End Get
        Set(ByVal value As String)
            Me.txtTitle.Text = value
        End Set
    End Property

    Public Property FormWidth() As String
        Get
            Return Me.txtWidth.Text
        End Get
        Set(ByVal value As String)
            Me.txtWidth.Text = value
        End Set
    End Property

    Public Property FormHeight() As String
        Get
            Return Me.txtHeight.Text
        End Get
        Set(ByVal value As String)
            Me.txtHeight.Text = value
        End Set
    End Property

    Public Property SubmitText() As String
        Get
            Return Me.txtSubmitText.Text
        End Get
        Set(ByVal value As String)
            Me.txtSubmitText.Text = value
        End Set
    End Property
#End Region

#Region "Events"
    Public Event FormTextChanged()
    Public Event FormWidthChanged()
    Public Event FormHeightChanged()

    Public Event SubmitTextChanged()
#End Region

#Region "Event Handlers"
    Private Sub txtTitle_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTitle.KeyDown
        If e.KeyValue = Keys.Enter Then
            RaiseEvent FormTextChanged()
        End If
    End Sub

    Private Sub txtTitle_Leave(sender As Object, e As EventArgs) Handles txtTitle.Leave
        If Me.FindForm() Is Nothing Then Return

        RaiseEvent FormTextChanged()
    End Sub

    Private Sub txtWidth_KeyDown(sender As Object, e As KeyEventArgs) Handles txtWidth.KeyDown
        If e.KeyValue = Keys.Enter Then
            RaiseEvent FormWidthChanged()
        End If
    End Sub

    Private Sub txtWidth_Leave(sender As Object, e As EventArgs) Handles txtWidth.Leave
        If Me.FindForm() Is Nothing Then Return

        RaiseEvent FormWidthChanged()
    End Sub

    Private Sub txtHeight_KeyDown(sender As Object, e As KeyEventArgs) Handles txtHeight.KeyDown
        If e.KeyValue = Keys.Enter Then
            RaiseEvent FormHeightChanged()
        End If
    End Sub

    Private Sub txtHeight_Leave(sender As Object, e As EventArgs) Handles txtHeight.Leave
        If Me.FindForm() Is Nothing Then Return

        RaiseEvent FormHeightChanged()
    End Sub

    Private Sub txtSubmitText_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSubmitText.KeyDown
        If e.KeyValue = Keys.Enter Then
            RaiseEvent SubmitTextChanged()
        End If
    End Sub

    Private Sub txtSubmitText_Leave(sender As Object, e As EventArgs) Handles txtSubmitText.Leave
        If Me.FindForm() Is Nothing Then Return

        RaiseEvent SubmitTextChanged()
    End Sub
#End Region
End Class
