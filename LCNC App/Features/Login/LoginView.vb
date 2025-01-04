Public Class LoginView
#Region "Events"
    Public Event SignIn()
#End Region

#Region "Event Handlers"
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        RaiseEvent SignIn()
    End Sub
#End Region
End Class