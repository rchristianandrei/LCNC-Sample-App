Imports MongoDB.Bson
Imports MongoDB.Bson.Serialization.Attributes

Public Class SubmittedDataModel
    Property Id As ObjectId

    Property Username As String

    Property FormId As ObjectId

    Property FormName As String

    Property HandlingTime As Integer

    ''' <summary>
    ''' Stores a Component and TextValue pair
    ''' </summary>
    ''' <returns></returns>
    Property Data As Dictionary(Of String, String)

    <BsonElement("DateTime"), BsonDateTimeOptions(Kind:=DateTimeKind.Local)>
    Property DateTime As Date
End Class
