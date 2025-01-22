Imports Microsoft.Extensions.Configuration
Imports Microsoft.Extensions.DependencyInjection

Module MainServices
    Public Function GetServiceProvider() As IServiceProvider
        ' Load configuration
        Dim configuration = New ConfigurationBuilder().AddJsonFile("appsettings.json").Build()

        ' Create a service collection
        Dim serviceCollection As New ServiceCollection()

        ' Get the connection string
        Dim connectionString = configuration.GetConnectionString("MongoDB")

        ' Register services
        serviceCollection.AddSingleton(Of IFormComponentModelFactory, FormComponentModelFactory)
        serviceCollection.AddSingleton(Of IFormControlFactory, FormControlFactory)

        serviceCollection.AddScoped(Of IFormsRepo, FormsRepo)(Function(provider) New FormsRepo(connectionString))
        serviceCollection.AddScoped(Of IUsersRepo, UsersRepo)(Function(provider) New UsersRepo(connectionString))

        serviceCollection.AddScoped(Of ISubmittedDataRepo, SubmittedDataRepo)(Function(provider) New SubmittedDataRepo(connectionString))
        serviceCollection.AddScoped(Of IReportSubmittedCountRepo, ReportSubmittedCountRepo)(Function(provider) New ReportSubmittedCountRepo(connectionString))

        ' Feature Presenters
        serviceCollection.AddTransient(Of LoginPresenter)
        serviceCollection.AddTransient(Of RegisterPresenter)

        serviceCollection.AddTransient(Of ReportingPresenter)
        serviceCollection.AddTransient(Of RealtimeReportSubmittedCountPresenter)
        serviceCollection.AddTransient(Of ExportRawReportPresenter)

        serviceCollection.AddTransient(Of FormWorkingPresenter)
        serviceCollection.AddTransient(Of FormPreviewPresenter)
        serviceCollection.AddTransient(Of LoadFormPresenter)

        serviceCollection.AddTransient(Of MainPresenter)
        serviceCollection.AddTransient(Of EditorPresenter)

        ' Build the service provider
        Dim serviceProvider = serviceCollection.BuildServiceProvider()

        Return serviceProvider
    End Function
End Module
