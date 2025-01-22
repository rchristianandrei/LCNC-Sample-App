Imports Microsoft.Extensions.DependencyInjection

Public Class LoginPresenter

    ' Services
    Private ReadOnly serviceProvider As IServiceProvider
    Private ReadOnly usersRepo As IUsersRepo

    Public Sub New(serviceProvider As IServiceProvider, usersRepo As IUsersRepo)
        Me.serviceProvider = serviceProvider
        Me.usersRepo = usersRepo

        Me.PrepareEventHandlers()
    End Sub

    Private Sub PrepareEventHandlers()
        AddHandler Me.View.SignIn, AddressOf Me.SignIn
        AddHandler Me.View.Register, AddressOf Me.Register
    End Sub

#Region "Properties"
    Public ReadOnly Property View As New LoginView
#End Region

#Region "Event Handlers"
    Private Async Sub SignIn()

        Try
            Dim username = Me.View.Username
            Dim password = Me.View.Password

            Dim user = Await Me.usersRepo.GetOne(username, password)

            If user Is Nothing Then
                MsgBox("Invalid Credentials")
                Return
            End If

            Globals.CurrentUser = user

            Me.serviceProvider.GetService(Of MainPresenter).View.Show()
            Me.View.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Register()
        Me.serviceProvider.GetService(Of RegisterPresenter).View.Show()
        Me.View.Close()
    End Sub
#End Region
End Class
