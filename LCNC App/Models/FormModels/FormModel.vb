Imports MongoDB.Bson

Public Class FormModel
    Public Property Id As ObjectId

    Public Property Username As String

    Public Property FormText As String

    Public Property FormWidth As Integer

    Public Property FormHeight As Integer

    Public Property SubmitText As String

    Public Property Components As List(Of FormComponentModel)

    Public Overrides Function ToString() As String
        Return FormText
    End Function
End Class
