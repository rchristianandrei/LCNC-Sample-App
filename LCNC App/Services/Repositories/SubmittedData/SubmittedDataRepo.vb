Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class SubmittedDataRepo
    Implements ISubmittedDataRepo

    Private ReadOnly connString As String
    Private ReadOnly dbName = "lcncApp"
    Private ReadOnly colName = "submittedData"

    Public Sub New(connString As String)
        Me.connString = connString
    End Sub

    Public Async Function Insert(data As SubmittedDataModel) As Task Implements ISubmittedDataRepo.Insert
        data.DateTime = BsonDateTime.Create(DateTime.UtcNow)

        Dim client As New MongoClient(New MongoUrl(Me.connString))

        Dim database As IMongoDatabase = client.GetDatabase(Me.dbName)
        Dim collection As IMongoCollection(Of SubmittedDataModel) = database.GetCollection(Of SubmittedDataModel)(Me.colName)

        Await collection.InsertOneAsync(data)
    End Function
End Class
