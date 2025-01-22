Public Class RegisterView

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
    Public Event SignUp()
    Public Event LogIn()
#End Region

#Region "Event Handlers"
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        RaiseEvent SignUp()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        RaiseEvent LogIn()
    End Sub
#End Region

End Class