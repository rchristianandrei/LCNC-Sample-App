﻿Imports MongoDB.Bson
Imports MongoDB.Bson.Serialization.Attributes

Public Class SubmittedDataModel
    Property Id As ObjectId

    Property FormId As ObjectId

    Property FormName As String

    ''' <summary>
    ''' Stores a Component and TextValue pair
    ''' </summary>
    ''' <returns></returns>
    Property Data As Dictionary(Of String, String)

    <BsonElement("DateTime"), BsonDateTimeOptions(Kind:=DateTimeKind.Local)>
    Property DateTime As Date
End Class
