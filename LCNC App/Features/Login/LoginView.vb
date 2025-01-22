Public Class LoginView

#Region "Properties"
    Public Property Username() As String
        Get
            Return Me.txtUsername.Text
        End Get
        Set(ByVal value As String)
            Me.txtUsername.Text = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return Me.txtPassword.Text
        End Get
        Set(ByVal value As String)
            Me.txtPassword.Text = value
        End Set
    End Property
#End Region

#Region "Events"
    Public Event SignIn()
#End Region

#Region "Event Handlers"
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        RaiseEvent SignIn()
    End Sub
#End Region
End Class