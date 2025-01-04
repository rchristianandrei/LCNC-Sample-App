Imports Microsoft.Extensions.DependencyInjection

Public Class LoginPresenter

    ' Services
    Private ReadOnly serviceProvider As IServiceProvider

    Public Sub New(serviceProvider As IServiceProvider)
        Me.serviceProvider = serviceProvider

        Me.PrepareEventHandlers
    End Sub

    Private Sub PrepareEventHandlers()
        AddHandler Me.View.SignIn, AddressOf Me.SignIn
    End Sub

#Region "Properties"
    Public ReadOnly Property View As New LoginView
#End Region

#Region "Event Handlers"
    Private Sub SignIn()
        Me.serviceProvider.GetService(Of MainPresenter).View.Show()
        Me.View.Close()
    End Sub
#End Region
End Class
