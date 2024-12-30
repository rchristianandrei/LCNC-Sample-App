Imports MongoDB.Bson

Public Class FormModel
    Public Property Id As ObjectId

    Public Property FormText As String

    Public Property FormWidth As Integer

    Public Property FormHeight As Integer

    Public Property SubmitText As String

    Public Property Components As IEnumerable(Of FormComponentModel)
End Class
