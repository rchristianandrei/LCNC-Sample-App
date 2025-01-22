Public Interface IUsersRepo

    Function Insert(user As UserModel) As Task

    Function CheckUsernameAvailability(username As String) As Task(Of Boolean)

    Function GetOne(username As String, password As String) As Task(Of UserModel)

    Function GetAll(username As String) As Task(Of IEnumerable(Of SubmittedDataModel))
End Interface
