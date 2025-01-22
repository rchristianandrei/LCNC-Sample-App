Imports Microsoft.Extensions.DependencyInjection

Public Class RegisterPresenter

    Private ReadOnly serviceProvider As IServiceProvider
    Private ReadOnly usersRepo As IUsersRepo

    Public Sub New(serviceProvider As IServiceProvider, usersRepo As IUsersRepo)
        Me.serviceProvider = serviceProvider
        Me.usersRepo = usersRepo

        Me.PrepareEventHandlers()
    End Sub

    Private Sub PrepareEventHandlers()
        AddHandler Me.View.SignUp, AddressOf Me.SignUp
        AddHandler Me.View.LogIn, AddressOf Me.LogIn
    End Sub

#Region "Properties"
    Public ReadOnly Property View As New RegisterView
#End Region

#Region "Event Handlers"
    Private Async Sub SignUp()
        Try
            Dim username = Me.View.Username
            Dim password = Me.View.Password

            Dim available = Await Me.usersRepo.CheckUsernameAvailability(username)

            If Not available Then
                MsgBox("Please pick another username")
                Return
            End If

            Dim user As New UserModel With {.Username = username, .Password = password}

            Await Me.usersRepo.Insert(user)

            MsgBox("Successfully Registered!")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LogIn()
        Me.serviceProvider.GetService(Of LoginPresenter).View.Show()
        Me.View.Close()
    End Sub
#End Region
End Class
