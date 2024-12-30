Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class FormsRepo
    Implements IFormsRepo

    Private ReadOnly connString As String
    Private ReadOnly dbName = "lcncApp"
    Private ReadOnly colName = "forms"

    Public Sub New(connString As String)
        Me.connString = connString
    End Sub

    Public Async Function Save(form As FormModel) As Task Implements IFormsRepo.Save
        Dim client As New MongoClient(New MongoUrl(connString))

        Dim database As IMongoDatabase = client.GetDatabase(dbName)
        Dim collection As IMongoCollection(Of FormModel) = database.GetCollection(Of FormModel)(colName)

        Await collection.InsertOneAsync(form)
    End Function

    Public Async Function LoadAll() As Task(Of ICollection(Of FormModel)) Implements IFormsRepo.LoadAll
        Dim client As New MongoClient(New MongoUrl(connString))

        Dim database As IMongoDatabase = client.GetDatabase(dbName)
        Dim collection As IMongoCollection(Of FormModel) = database.GetCollection(Of FormModel)(colName)

        Dim filter As FilterDefinition(Of FormModel) = Builders(Of FormModel).Filter.Empty
        Dim forms = Await collection.FindAsync(filter)

        Return Await forms.ToListAsync
    End Function

    Private Async Function LoadOne(id As ObjectId) As Task(Of FormModel) Implements IFormsRepo.LoadOne
        Dim client As New MongoClient(New MongoUrl(connString))

        Dim database As IMongoDatabase = client.GetDatabase(dbName)
        Dim collection As IMongoCollection(Of FormModel) = database.GetCollection(Of FormModel)(colName)

        Dim filter As FilterDefinition(Of FormModel) = Builders(Of FormModel).Filter.Eq(Function(f) f.Id, id)
        Dim results = Await collection.FindAsync(filter)

        Return results.FirstOrDefault()
    End Function

    Public Async Function Delete(id As ObjectId) As Task Implements IFormsRepo.Delete
        Dim client As New MongoClient(New MongoUrl(connString))

        Dim database As IMongoDatabase = client.GetDatabase(dbName)
        Dim collection As IMongoCollection(Of FormModel) = database.GetCollection(Of FormModel)(colName)

        Dim filter As FilterDefinition(Of FormModel) = Builders(Of FormModel).Filter.Eq(Function(f) f.Id, id)

        Await collection.DeleteOneAsync(filter)
    End Function
End Class
