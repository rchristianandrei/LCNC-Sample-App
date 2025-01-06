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

    Public Async Function GetData(formId As ObjectId, fromDate As Date, toDate As Date) As Task(Of IEnumerable(Of SubmittedDataModel)) Implements ISubmittedDataRepo.GetData
        Dim client As New MongoClient(New MongoUrl(connString))

        Dim database As IMongoDatabase = client.GetDatabase(dbName)
        Dim collection As IMongoCollection(Of SubmittedDataModel) = database.GetCollection(Of SubmittedDataModel)(colName)

        Dim filter As FilterDefinition(Of SubmittedDataModel) = Builders(Of SubmittedDataModel).Filter.And(
            Builders(Of SubmittedDataModel).Filter.Eq(Function(model) model.FormId, formId),
            Builders(Of SubmittedDataModel).Filter.Gte(Function(model) model.DateTime, fromDate),
            Builders(Of SubmittedDataModel).Filter.Lte(Function(model) model.DateTime, toDate)
        )
        Dim results = Await collection.FindAsync(filter)

        Return Await results.ToListAsync
    End Function
End Class
