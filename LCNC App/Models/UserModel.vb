Imports MongoDB.Bson
Imports MongoDB.Bson.Serialization.Attributes

Public Class UserModel

    Public Property Id As ObjectId

    Public Property Username As String

    Public Property Password As String

    <BsonElement("DateTime"), BsonDateTimeOptions(Kind:=DateTimeKind.Local)>
    Property DateTime As Date

End Class
